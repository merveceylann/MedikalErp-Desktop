using IEA_ErpProject102MC_Main.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject102MC_Main.UrunIslemleri
{
    public partial class frmUrunlerListesi : Form
    {
        public frmUrunlerListesi()
        {
            InitializeComponent();
        }
        private ErpProject102Entities erp = new ErpProject102Entities();
        private int secimId = -1;

        private void frmUrunlerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblUrunler
                       where s.isActive == true
                       select new
                       {
                           id = s.Id,
                           ukodu = s.UrunKodu,
                           uadi = s.UrunAdi,
                           uaciklama = s.UrunAciklama,
                           ubarkod = s.Barkod,
                           ufiyat = s.Fiyat,
                           uparab = s.ParaBirimi,
                           uskt = s.SonKullanmaT,
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.ukodu;
                Liste.Rows[i].Cells[3].Value = k.uadi;
                Liste.Rows[i].Cells[4].Value = k.uaciklama;
                Liste.Rows[i].Cells[5].Value = k.ubarkod;
                Liste.Rows[i].Cells[6].Value = k.ufiyat + " " + k.uparab;
                Liste.Rows[i].Cells[7].Value = k.uskt;
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

            if (secimId > 0 && Application.OpenForms["frmUrunBilgiGirisEkrani"] == null)
            {
                frmUrunBilgiGirisEkrani frm = new frmUrunBilgiGirisEkrani();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Ac(secimId);
                Close();
            }
            else if (Application.OpenForms["frmUrunBilgiGirisEkrani"] != null)
            {
                frmUrunBilgiGirisEkrani frm = Application.OpenForms["frmUrunBilgiGirisEkrani"] as frmUrunBilgiGirisEkrani;
                frm.Ac(secimId);
                Close();
            }
        }
    }
}
