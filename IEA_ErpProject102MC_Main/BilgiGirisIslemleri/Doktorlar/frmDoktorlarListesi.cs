using IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Hastaneler;
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
    public partial class frmDoktorlarListesi : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int secimId = -1;

        public bool Secim = false;

        public frmDoktorlarListesi()
        {
            InitializeComponent();
        }

        private void frmDoktorlarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {

            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true && s.CariGrupId == 2
                       select new
                       {
                           id = s.Id,
                           dkodu = s.CariKodu,
                           dadi = s.CariAdi,
                           dtel = s.CariTel,
                           dgsm = s.YetkiliCep1,
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

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;

            if (secimId > 0 && Secim && Application.OpenForms["frmDoktorGirisEkrani"] == null)
            {
                //frmDoktorGirisEkrani frm = new frmDoktorGirisEkrani();
                //frm.MdiParent = Home.ActiveForm;
                //frm.Show();
                //frm.Ac(secimId);
                Home.Aktarma = secimId;
                Close();
            }
            else if (Application.OpenForms["frmDoktorGirisEkrani"] != null)
            {
                frmDoktorGirisEkrani frm = Application.OpenForms["frmDoktorGirisEkrani"] as frmDoktorGirisEkrani;
                frm.Ac(secimId);
                Close();
            }
        }
    }
}
