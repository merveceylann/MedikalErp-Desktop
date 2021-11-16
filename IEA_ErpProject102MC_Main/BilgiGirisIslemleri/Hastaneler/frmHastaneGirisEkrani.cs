using IEA_ErpProject102MC_Main.Dal;
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

namespace IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Hastaneler
{
    public partial class frmHastaneGirisEkrani : baglanti
    {
        //private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int secimId = -1;

        public frmHastaneGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            string hkodu = n.CariKoduHastane();
            try
            {
                if (txtHastAdi.Text == "")
                {
                    return;
                }
                if (secimId==-1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi =        txtHastAdi.Text;
                    hst.CariMail =       txtHastMail.Text;
                    hst.CariTel =        txtHastTel.Text;
                    hst.YetkiliAdi1 =    txtYetAdi1.Text;
                    hst.YetkiliAdi2 =    txtYetAdi2.Text;
                    hst.YetkiliAdi3 =    txtYetAdi3.Text;
                    hst.YetkiliDep1 =    txtYetDep1.Text;
                    hst.YetkiliDep2 =    txtYetDep2.Text;
                    hst.YetkiliDep3 =    txtYetDep3.Text;
                    hst.YetkiliTel1 =    txtYetTel1.Text;
                    hst.YetkiliTel2 =    txtYetTel2.Text;
                    hst.YetkiliTel3 =    txtYetTel3.Text;
                    hst.YetkiliCep1 =    txtYetCep1.Text;
                    hst.YetkiliCep2 =    txtYetCep2.Text;
                    hst.YetkiliCep3 =    txtYetCep3.Text;
                    hst.YetkiliMail1 =   txtYetEmail1.Text;
                    hst.YetkiliMail2 =   txtYetEmail2.Text;
                    hst.YetkiliMail3 =   txtYetEmail3.Text;
                    hst.Adres1 =         txtAdres1.Text;
                    hst.Adres2 =         txtAdres2.Text;
                    hst.CariGrupId = 1;
                    hst.CariTipId = 1;
                    hst.CariUnvan =      txtHastUnvan.Text;
                    hst.VDairesi =       txtVergiD.Text;
                    hst.VnoTcno =        txtVnTc.Text;
                    //hst.SehirId = erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                    //ternary ile yapilmis versiyonu
                    //hst.SehirId = txtSehir.SelectedValue != null ? (int)txtSehir.SelectedValue : -1;
                    //int ten farkli bir deger gelirse -1 yap
                    //hst.SehirId = (int?)txtSehir.SelectedValue ?? null;
                    if (txtSehir.SelectedValue != null)
                    {
                        hst.SehirId = (int)txtSehir.SelectedValue;
                    }
                    hst.SaveDate = DateTime.Now;
                    hst.SaveUserId = 1;
                    hst.CariKodu =       hkodu;

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
                hst.CariAdi =       txtHastAdi.Text;
                hst.CariMail =      txtHastMail.Text;
                hst.CariTel =       txtHastTel.Text;
                hst.YetkiliAdi1 =   txtYetAdi1.Text;
                hst.YetkiliAdi2 =   txtYetAdi2.Text;
                hst.YetkiliAdi3 =   txtYetAdi3.Text;
                hst.YetkiliDep1 =   txtYetDep1.Text;
                hst.YetkiliDep2 =   txtYetDep2.Text;
                hst.YetkiliDep3 =   txtYetDep3.Text;
                hst.YetkiliTel1 =   txtYetTel1.Text;
                hst.YetkiliTel2 =   txtYetTel2.Text;
                hst.YetkiliTel3 =   txtYetTel3.Text;
                hst.YetkiliCep1 =   txtYetCep1.Text;
                hst.YetkiliCep2 =   txtYetCep2.Text;
                hst.YetkiliCep3 =   txtYetCep3.Text;
                hst.YetkiliMail1 =  txtYetEmail1.Text;
                hst.YetkiliMail2 =  txtYetEmail2.Text;
                hst.YetkiliMail3 =  txtYetEmail3.Text;
                hst.Adres1 =        txtAdres1.Text;
                hst.Adres2 =        txtAdres2.Text;
                hst.CariTipId = 1;
                hst.CariUnvan =     txtHastUnvan.Text;
                hst.VDairesi = txtVergiD.Text;
                hst.VnoTcno = txtVnTc.Text;
                hst.SehirId = (int?)txtSehir.SelectedValue ?? null;
                hst.UpdateDate = DateTime.Now;
                hst.UpdateUserId = 1; //hangi kullanıcı hangi kaydi ne zaman degistirir onu kaydetmek adina (tedbir)
                hst.CariKodu = lblHastaneKodu.Text;

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

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control k in pnlOrta.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    k.Text = "";
                }
            }
            secimId = -1;
            txtSehir.SelectedIndex = -1;
            txtYetDep1.SelectedIndex = -1;
            txtYetDep2.SelectedIndex = -1;
            txtYetDep3.SelectedIndex = -1;
        }

        private void frmHastaneGirisEkrani_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {
            var dep1 = erp.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();
            var dep2 = erp.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();
            var dep3 = erp.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();
            var seh = erp.tblSehirler.ToList();

            txtSehir.DataSource = seh;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "sehir";
            txtSehir.SelectedIndex = -1;

            txtYetDep1.DataSource = dep1;
            txtYetDep1.ValueMember = "Id";
            txtYetDep1.DisplayMember = "DeptAdi";
            txtYetDep1.SelectedIndex = -1;

            txtYetDep2.DataSource = dep2;
            txtYetDep2.ValueMember = "Id";
            txtYetDep2.DisplayMember = "DeptAdi";
            txtYetDep2.SelectedIndex = -1;

            txtYetDep3.DataSource = dep3;
            txtYetDep3.ValueMember = "Id";
            txtYetDep3.DisplayMember = "DeptAdi";
            txtYetDep3.SelectedIndex = -1;
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true
                       where s.CariGrupId==1
                       select new
                       {
                           id = s.Id,
                           hkodu = s.CariKodu,
                           hadi = s.CariAdi,
                           htel = s.CariTel,
                           hmail = s.CariMail,
                           hyet = s.YetkiliAdi1,
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.hkodu;
                Liste.Rows[i].Cells[3].Value = k.hadi;
                Liste.Rows[i].Cells[4].Value = k.htel;
                Liste.Rows[i].Cells[5].Value = k.hmail;
                Liste.Rows[i].Cells[6].Value = k.hyet;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblHastaneKodu.Text = n.CariKoduHastane();
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

                txtHastAdi.Text = hst.CariAdi;
                txtHastMail.Text = hst.CariMail;
                txtHastTel.Text = hst.CariTel;
                txtYetAdi1.Text = hst.YetkiliAdi1;
                txtYetAdi2.Text = hst.YetkiliAdi2;
                txtYetAdi3.Text = hst.YetkiliAdi3;
                txtYetDep1.Text = hst.YetkiliDep1;
                txtYetDep2.Text = hst.YetkiliDep2;
                txtYetDep3.Text = hst.YetkiliDep3;
                txtYetTel1.Text = hst.YetkiliTel1;
                txtYetTel2.Text = hst.YetkiliTel2;
                txtYetTel3.Text = hst.YetkiliTel3;
                txtYetCep1.Text = hst.YetkiliCep1;
                txtYetCep2.Text = hst.YetkiliCep2;
                txtYetCep3.Text = hst.YetkiliCep3;
                txtYetEmail1.Text = hst.YetkiliMail1;
                txtYetEmail2.Text = hst.YetkiliMail2;
                txtYetEmail3.Text = hst.YetkiliMail3;
                txtAdres1.Text = hst.Adres1;
                txtAdres2.Text = hst.Adres2;
                txtHastUnvan.Text = hst.CariUnvan;
                txtVergiD.Text = hst.VDairesi;
                txtVnTc.Text = hst.VnoTcno;
                //txtSehir.Text = hst.tblSehirler.sehir;
                txtSehir.Text = hst.tblSehirler == null ? "" : hst.tblSehirler.sehir;
                lblHastaneKodu.Text = hst.CariKodu;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        //sanal buton olusturma!
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
            if (Application.OpenForms[""]==null)
            {
                frmHastanelerListesi frm = new frmHastanelerListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
        }
        //son
    }
}
