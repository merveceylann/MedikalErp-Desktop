using IEA_ErpProject102MC_Main.Entity;
using IEA_ErpProject102MC_Main.Fonksiyonlar;
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
            var lst = (from s in erp.tblCariler
                       where s.isActive == true && s.CariGrupId == 4
                       select new
                       {
                           id = s.Id,
                           pkodu = s.CariKodu,
                           padi = s.CariAdi,
                           ptel = s.CariTel,
                           pgsm = s.YetkiliCep1,
                           pmail = s.CariMail,
                           pbaslama=s.IseBaslamaT,
                           pbitis=s.IstenAyrilmaT
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
                    hst.IseBaslamaT = txtPBaslama.Value;
                    hst.IstenAyrilmaT = txtPBitis.Value;
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
                    MessageBox.Show("Kayit Basarili");

                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Bu kayit alinmistir!!!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hatali Giris");
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
                tblCariler hst = erp.tblCariler.Find(secimId);
                hst.CariAdi = txtPAdi.Text;
                hst.CariMail = txtPMail.Text;
                hst.CariTel = txtPTel.Text;
                hst.YetkiliDep1 = txtPDep.Text;
                hst.YetkiliCep1 = txtPGsm.Text;
                hst.Adres1 = txtPAdres.Text;
                hst.CariUnvan = txtPUnvan.Text;
                hst.IseBaslamaT = txtPBaslama.Value;
                hst.IstenAyrilmaT = txtPBitis.Value;
                hst.SehirId = (int?)txtSehir.SelectedValue ?? null;
                hst.UpdateDate = DateTime.Now;
                hst.UpdateUserId = 1; //hangi kullanıcı hangi kaydi ne zaman degistirir onu kaydetmek adina (tedbir)
                hst.CariKodu = lblPersonelKodu.Text;

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
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }
        public void Ac(int i)
        {
            secimId = i;
            try
            {
                tblCariler hst = erp.tblCariler.Find(i);

                txtPAdi.Text = hst.CariAdi;
                txtPMail.Text = hst.CariMail;
                
                txtPTel.Text = hst.CariTel;
                txtPDep.Text = hst.YetkiliDep1;
                txtPGsm.Text = hst.YetkiliCep1;
                txtPAdres.Text = hst.Adres1;
                txtPUnvan.Text = hst.CariUnvan;
                txtPBaslama.Text = hst.IseBaslamaT.ToString();
                txtPBitis.Text = hst.IstenAyrilmaT.ToString();
                //txtSehir.Text = hst.tblSehirler.sehir;
                txtSehir.Text = hst.tblSehirler == null ? "" : hst.tblSehirler.sehir;
                lblPersonelKodu.Text = hst.CariKodu;
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
                tblCariler hst = erp.tblCariler.Find(secimId);
                hst.isActive = false;
                erp.SaveChanges();
                MessageBox.Show("Silme Basarili");
                Temizle();
                Listele();
            }
        }

        private void txtPBitis_ValueChanged(object sender, EventArgs e)
        {
            txtPBitis.CustomFormat = "dd.MM.yyyy";
        }
    }
}
