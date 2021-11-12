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

namespace IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Doktorlar
{
    public partial class frmDoktorGirisEkrani : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();

        private int secimId = -1;

        public frmDoktorGirisEkrani()
        {
            InitializeComponent();
        }
        private void frmDoktorGirisEkrani_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {

            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true && s.CariGrupId==2
                       select new
                       {
                           id = s.Id,
                           dkodu = s.CariKodu,
                           dadi = s.CariAdi,
                           dtel = s.CariTel,
                           dgsm=s.YetkiliCep1,
                           dmail = s.CariMail,
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.dkodu;
                Liste.Rows[i].Cells[3].Value = k.dadi;
                Liste.Rows[i].Cells[4].Value = k.dtel;
                Liste.Rows[i].Cells[5].Value = k.dgsm;
                Liste.Rows[i].Cells[6].Value = k.dmail;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblDoktorKodu.Text = n.CariKoduDoktor();
        }

        private void ComboDoldur()
        {
            txtDokUnvan.DataSource = Enum.GetValues(typeof(enumDoktorUnvanlar));

            var dep = erp.tblDepartmanlar.Where(x => x.GrupId == 2).ToList();
            
            var seh = erp.tblSehirler.ToList();

            txtSehir.DataSource = seh;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "sehir";
            txtSehir.SelectedIndex = -1;

            txtDokDep.DataSource = dep;
            txtDokDep.ValueMember = "Id";
            txtDokDep.DisplayMember = "DeptAdi";
            txtDokDep.SelectedIndex = -1;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            string dkodu = n.CariKoduDoktor();
            try
            {
                if (txtDokAdi.Text == "")
                {
                    return;
                }
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtDokAdi.Text;
                    hst.CariMail = txtDokMail.Text;
                    hst.CariTel = txtDokTel.Text;
                    hst.YetkiliDep1 = txtDokDep.Text;
                    hst.YetkiliCep1 = txtDokGsm.Text;
                    hst.Adres1 = txtDokHAdres.Text;
                    hst.Adres2 = txtDokMAdres.Text;
                    hst.CariGrupId = 2;
                    hst.CariTipId = 1;
                    hst.CariUnvan = txtDokUnvan.Text;
                    hst.VDairesi = txtDokVergiD.Text;
                    hst.VnoTcno = txtDokVnTc.Text;
                    //hst.SehirId = (int?)txtSehir.SelectedValue ?? null;
                    if (txtSehir.SelectedValue!=null)
                    {
                        hst.SehirId = (int)txtSehir.SelectedValue;
                    }
                    hst.SaveDate = DateTime.Now;
                    hst.SaveUserId = 1;
                    hst.CariKodu = dkodu;

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
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    k.Text = "";
                }
            }
            secimId = -1;
            txtSehir.SelectedIndex = -1;
            txtDokDep.SelectedIndex = -1;
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
                hst.CariAdi = txtDokAdi.Text;
                hst.CariMail = txtDokMail.Text;
                hst.CariTel = txtDokTel.Text;
                hst.YetkiliDep1 = txtDokDep.Text;
                hst.YetkiliCep1 = txtDokGsm.Text;
                hst.Adres1 = txtDokHAdres.Text;
                hst.Adres2 = txtDokMAdres.Text;
                hst.CariUnvan = txtDokUnvan.Text;
                hst.VDairesi = txtDokVergiD.Text;
                hst.VnoTcno = txtDokVnTc.Text;
                hst.SehirId = (int?)txtSehir.SelectedValue ?? null;                
                hst.UpdateDate = DateTime.Now;
                hst.UpdateUserId = 1; //hangi kullanıcı hangi kaydi ne zaman degistirir onu kaydetmek adina (tedbir)
                hst.CariKodu = lblDoktorKodu.Text;

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

                txtDokAdi.Text = hst.CariAdi;
                txtDokMail.Text = hst.CariMail;
                txtDokTel.Text = hst.CariTel;
                txtDokDep.Text = hst.YetkiliDep1;
                txtDokGsm.Text = hst.YetkiliCep1;
                txtDokHAdres.Text = hst.Adres1;
                txtDokMAdres.Text = hst.Adres2;
                txtDokUnvan.Text = hst.CariUnvan;
                txtDokVergiD.Text = hst.VDairesi;
                txtDokVnTc.Text = hst.VnoTcno;
                txtSehir.Text = hst.tblSehirler==null ? "" : hst.tblSehirler.sehir;
                lblDoktorKodu.Text = hst.CariKodu;
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
    }
}

//SKTsi olmayan urunlerin de 1 senelik surelerini yapcaz.
//homeda buton2 ye ve tv2 ye menu olustur.
//tv2= tvUrunIslemleri
//btnUrunGiris
//abstrack concret
//generic ler