using IEA_ErpProject102MC_Main.Entity;
using IEA_ErpProject102MC_Main.Fonksiyonlar;
using IEA_ErpProject102MC_Main.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Personeller
{
    public partial class frmPersonelGirisEkrani : Form
    {
        public frmPersonelGirisEkrani()
        {
            InitializeComponent();
        }

        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();

        private int secimId = -1;

        private void frmPersonelGirisEkrani_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblPersonelDetay
                       where s.tblCariler.isActive == true 
                       where s.tblCariler.CariGrupId == 4
                       select new
                       {
                           id = s.Id,
                           pkodu = s.tblCariler.CariKodu,
                           padi = s.tblCariler.CariAdi,
                           ptel = s.tblCariler.CariTel,
                           pgsm = s.tblCariler.YetkiliCep1,
                           pmail = s.tblCariler.CariMail,
                           pbaslama=s.IsBasiTarih,
                           pbitis=s.IsBitisTarih
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.pkodu;
                Liste.Rows[i].Cells[3].Value = k.padi;
                Liste.Rows[i].Cells[4].Value = k.ptel;
                Liste.Rows[i].Cells[5].Value = k.pgsm;
                Liste.Rows[i].Cells[6].Value = k.pmail;
                Liste.Rows[i].Cells[7].Value = k.pbaslama;
                Liste.Rows[i].Cells[8].Value = k.pbitis;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblPersonelKodu.Text = n.CariKoduPersonel();
        }
        private void ComboDoldur()
        {
            txtPUnvan.DataSource = Enum.GetValues(typeof(enumPersonelUnvanlar));

            var dep = erp.tblDepartmanlar.Where(x => x.GrupId == 4).ToList();

            var seh = erp.tblSehirler.ToList();

            txtSehir.DataSource = seh;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "sehir";
            txtSehir.SelectedIndex = -1;

            txtPDep.DataSource = dep;
            txtPDep.ValueMember = "Id";
            txtPDep.DisplayMember = "DeptAdi";
            txtPDep.SelectedIndex = -1;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            string pkodu = n.CariKoduPersonel();
            try
            {
                if (txtPAdi.Text=="")
                {
                    return;
                }
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtPAdi.Text;
                    hst.CariMail = txtPMail.Text;
                    hst.CariTel = txtPTel.Text;
                    hst.YetkiliDep1 = txtPDep.Text;
                    hst.YetkiliCep1 = txtPGsm.Text;
                    hst.Adres1 = txtPAdres.Text;
                    hst.CariGrupId = 4;
                    hst.CariTipId = 1;
                    hst.CariUnvan = txtPUnvan.Text;
                    //hst.SehirId = (int?)txtSehir.SelectedValue ?? null;
                    if (txtSehir.SelectedValue != null)
                    {
                        hst.SehirId = (int)txtSehir.SelectedValue;
                    }
                    hst.SaveDate = DateTime.Now;
                    hst.SaveUserId = 1;
                    hst.CariKodu = pkodu;

                    erp.tblCariler.Add(hst);
                    erp.SaveChanges();

                    tblPersonelDetay pdet = new tblPersonelDetay();
                    pdet.IsBasiTarih = txtPBaslama.Value;
                    pdet.CariId = erp.tblCariler.First(x=> x.CariAdi==txtPAdi.Text).Id;

                    erp.tblPersonelDetay.Add(pdet);
                    erp.SaveChanges();

                    MessageBox.Show(@"Kayit Basarili");

                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show(@"Bu kayit alinmistir!!!");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Temizle()
        {
            foreach (Control k in pnlOrta.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox|| k is DateTimePicker)
                {
                    k.Text = "";
                }
            }
            secimId = -1;
            txtSehir.SelectedIndex = -1;
            txtPUnvan.SelectedIndex = -1;
            txtPDep.SelectedIndex = -1;

            txtDurum.Visible = false;
            txtDurum.Checked = false;
            txtPBitis.Visible = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            
            try
            {
                if (secimId < 0)
                {
                    return;
                }
                tblPersonelDetay hst = erp.tblPersonelDetay.Find(secimId);
                hst.tblCariler.CariAdi = txtPAdi.Text;
                hst.tblCariler.CariMail = txtPMail.Text;
                hst.tblCariler.CariTel = txtPTel.Text;
                hst.tblCariler.YetkiliDep1 = txtPDep.Text;
                hst.tblCariler.YetkiliCep1 = txtPGsm.Text;
                hst.tblCariler.Adres1 = txtPAdres.Text;
                hst.tblCariler.CariUnvan = txtPUnvan.Text;
                hst.tblCariler.IseBaslamaT = txtPBaslama.Value;
                if (txtDurum.Checked)
                {
                    hst.IsBitisTarih = txtPBitis.Value;
                }
                if (txtSehir.SelectedValue != null)
                {
                    hst.tblCariler.SehirId = (int)txtSehir.SelectedValue;
                }
                hst.tblCariler.UpdateDate = DateTime.Now;
                hst.tblCariler.UpdateUserId = 1; //hangi kullanıcı hangi kaydi ne zaman degistirir onu kaydetmek adina (tedbir)
                hst.tblCariler.CariKodu = lblPersonelKodu.Text;

                erp.SaveChanges();
                MessageBox.Show("Guncelleme Basarili");

                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Temizle();
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }
        public void Ac(int i)
        {
            txtDurum.Visible = true;
            secimId = i;
            try
            {
                tblPersonelDetay hst = erp.tblPersonelDetay.Find(i);

                txtPAdi.Text = hst.tblCariler.CariAdi;
                txtPMail.Text = hst.tblCariler.CariMail;
                txtPTel.Text = hst.tblCariler.CariTel;
                txtPDep.Text = hst.tblCariler.YetkiliDep1;
                txtPGsm.Text = hst.tblCariler.YetkiliCep1;
                txtPAdres.Text = hst.tblCariler.Adres1;
                txtPUnvan.Text = hst.tblCariler.CariUnvan;
                //txtSehir.Text = hst.tblSehirler.sehir;
                txtSehir.Text = hst.tblCariler.tblSehirler == null ? "" : hst.tblCariler.tblSehirler.sehir;
                lblPersonelKodu.Text = hst.tblCariler.CariKodu;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblPersonelDetay hst = erp.tblPersonelDetay.Find(secimId);
                hst.tblCariler.isActive = false;
                erp.SaveChanges();
                MessageBox.Show(@"Silme Basarili");
                Temizle();
                Listele();
            }
        }

        private void txtPBitis_ValueChanged(object sender, EventArgs e)
        {
            txtPBitis.CustomFormat = "dd.MM.yyyy";
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button(); //ramde bir buton olusturmus olduk.
            btn.Size = new Size(25, txtHKoduBul.ClientSize.Height + 0);
            btn.Location = new Point(txtHKoduBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.Image = Resources.arrow_1176;
            txtHKoduBul.Controls.Add(btn);

            base.OnLoad(e);
            btn.Click += btn_Click;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[""] == null)
            {
                frmPersonellerListesi frm = new frmPersonellerListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
        }

        private void txtDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDurum.Checked)
            {
                txtPBitis.Visible = true;
            }
            else
            {
                txtPBitis.Visible = false;
            }
        }

        
    }
}
