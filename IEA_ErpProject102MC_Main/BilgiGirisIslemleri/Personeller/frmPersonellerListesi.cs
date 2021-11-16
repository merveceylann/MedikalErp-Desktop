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
    public partial class frmPersonellerListesi : Form
    {
        public frmPersonellerListesi()
        {
            InitializeComponent();
        }

        private ErpProject102Entities erp = new ErpProject102Entities();
        private int secimId = -1;

        public bool Secim = false;

        private void frmPersonellerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblPersonelDetay
                       where s.tblCariler.isActive == true
                       where s.tblCariler.CariGrupId == 4
                       select new  //butun alanlar degil de belli basli alanlar gelsin istedik
                       {
                           id = s.Id,
                           pkodu = s.tblCariler.CariKodu,
                           padi = s.tblCariler.CariAdi,
                           ptel = s.tblCariler.CariTel,
                           pgsm = s.tblCariler.YetkiliCep1,
                           pmail = s.tblCariler.CariMail,
                           pbaslama = s.IsBasiTarih,
                           pbitis = s.IsBitisTarih
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


        }

        private void Liste_DoubleClick_1(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;

            if (secimId > 0 && Secim && Application.OpenForms["frmPersonelGirisEkrani"] == null)
            {
                //frmPersonelGirisEkrani frm = new frmPersonelGirisEkrani();
                //frm.MdiParent = Home.ActiveForm;
                //frm.Show();
                //frm.Ac(secimId);
                Home.Aktarma = secimId;
                Close();
            }
            else if (Application.OpenForms["frmPersonelGirisEkrani"] != null)
            {
                frmPersonelGirisEkrani frm = Application.OpenForms["frmPersonelGirisEkrani"] as frmPersonelGirisEkrani;
                frm.Ac(secimId);
                Close();
            }

        }
    }
}
