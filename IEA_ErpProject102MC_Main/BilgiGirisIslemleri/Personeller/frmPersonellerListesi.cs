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

        private void frmPersonellerListesi_Load(object sender, EventArgs e)
        {
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
                           pbaslama = s.IseBaslamaT,
                           pbitis = s.IstenAyrilmaT
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

            if (secimId > 0 && Application.OpenForms["frmPersonelGirisEkrani"] == null)
            {
                frmPersonelGirisEkrani frm = new frmPersonelGirisEkrani();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Ac(secimId);
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
