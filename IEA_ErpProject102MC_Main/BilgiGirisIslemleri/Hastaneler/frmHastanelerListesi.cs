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

namespace IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Hastaneler
{
    public partial class frmHastanelerListesi : Form
    {
        public frmHastanelerListesi()
        {
            InitializeComponent();
        }

        private ErpProject102Entities erp = new ErpProject102Entities();
        private frmHastaneGirisEkrani frm = new frmHastaneGirisEkrani();
        private Numaralar n = new Numaralar();
        private int secimId = -1;

        public bool Secim = false;

        //private frmHastaneGirisEkrani acik = (frmHastaneGirisEkrani)Application.OpenForms["frmHastaneGirisEkrani"];

        private void frmHastanelerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true
                       where s.CariGrupId == 1
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

            frm.lblHastaneKodu.Text = n.CariKoduHastane();
        }


        private void Liste_DoubleClick_1(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;

            if (secimId > 0 && Secim && Application.OpenForms["frmHastaneGirisEkrani"] == null)
            {
                //frmHastaneGirisEkrani frm = new frmHastaneGirisEkrani();
                //frm.MdiParent = Home.ActiveForm;
                //frm.Show();
                //frm.Ac(secimId);
                Home.Aktarma = secimId;
                Close();
            }
            else if (Application.OpenForms["frmHastaneGirisEkrani"] != null)
            {
                frmHastaneGirisEkrani frm = Application.OpenForms["frmHastaneGirisEkrani"] as frmHastaneGirisEkrani;
                frm.Ac(secimId);
                Close();
            }
        }

        //diger formdan aldigimiz icin gerek kalmadi
        /*
        private void Ac(int i)
        {
            try
            {
                tblCariler hst = erp.tblCariler.Find(i);

                acik.txtHastAdi.Text = hst.CariAdi;
                acik.txtHastMail.Text = hst.CariMail;
                acik.txtHastTel.Text = hst.CariTel;
                acik.txtYetAdi1.Text = hst.YetkiliAdi1;
                acik.txtYetAdi2.Text = hst.YetkiliAdi2;
                acik.txtYetAdi3.Text = hst.YetkiliAdi3;
                acik.txtYetDep1.Text = hst.YetkiliDep1;
                acik.txtYetDep2.Text = hst.YetkiliDep2;
                acik.txtYetDep3.Text = hst.YetkiliDep3;
                acik.txtYetTel1.Text = hst.YetkiliTel1;
                acik.txtYetTel2.Text = hst.YetkiliTel2;
                acik.txtYetTel3.Text = hst.YetkiliTel3;
                acik.txtYetCep1.Text = hst.YetkiliCep1;
                acik.txtYetCep2.Text = hst.YetkiliCep2;
                acik.txtYetCep3.Text = hst.YetkiliCep3;
                acik.txtYetEmail1.Text = hst.YetkiliMail1;
                acik.txtYetEmail2.Text = hst.YetkiliMail2;
                acik.txtYetEmail3.Text = hst.YetkiliMail3;
                acik.txtAdres1.Text = hst.Adres1;
                acik.txtAdres2.Text = hst.Adres2;
                acik.txtHastUnvan.Text = hst.CariUnvan;
                acik.txtVergiD.Text = hst.VDairesi;
                acik.txtVnTc.Text = hst.VnoTcno;
                acik.txtSehir.Text = hst.tblSehirler.sehir;
                acik.lblHastaneKodu.Text = hst.CariKodu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

        }*/

    }
}
