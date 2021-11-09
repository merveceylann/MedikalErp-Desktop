using IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Hastaneler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject102MC_Main
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MenuOlustur();
        }

        private void MenuOlustur()
        {
            #region Bilgi Giris Islemleri

            tvBilgiGirisIslemleri.Nodes.Add("Hastaneler"); //root elemani
            tvBilgiGirisIslemleri.Nodes[0].Nodes.Add("Hastane Bilgi Giris Ekrani"); //child
            tvBilgiGirisIslemleri.Nodes[0].Nodes.Add("Hastaneler Listesi"); //child

            tvBilgiGirisIslemleri.Nodes.Add("Doktorlar"); //ikinci root
            tvBilgiGirisIslemleri.Nodes[1].Nodes.Add("Doktor Bilgi Giris Ekrani"); //child
            tvBilgiGirisIslemleri.Nodes[1].Nodes.Add("Doktorlar Listesi"); //child

            tvBilgiGirisIslemleri.Nodes.Add("Firmalar"); //ucuncu root
            tvBilgiGirisIslemleri.Nodes[2].Nodes.Add("Firma Bilgi Giris Ekrani"); //child
            tvBilgiGirisIslemleri.Nodes[2].Nodes.Add("Firmalar Listesi"); //child

            #endregion
        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblMenuText.Text = btnBilgiGiris.Text;
            TvGorunum();
            tvBilgiGirisIslemleri.Visible = true;
        }

        private void TvGorunum()
        {
            tvBilgiGirisIslemleri.Visible = false;
            tv2.Visible = false;
            tv3.Visible = false;
            tv4.Visible = false;
            tv5.Visible = false;
            tv6.Visible = false;
            tv7.Visible = false;
            tv8.Visible = false;
            tv9.Visible = false;
            tv10.Visible = false;
            tv11.Visible = false;
            tv12.Visible = false;
        }

        private void tvBilgiGirisIslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = tvBilgiGirisIslemleri.SelectedNode.Text;
            if (isim == "Hastane Bilgi Giris Ekrani" && Application.OpenForms[""] is null)
            {
                frmHastaneGirisEkrani frm = new frmHastaneGirisEkrani();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Hastaneler Listesi" && Application.OpenForms[""] as frmHastanelerListesi is null)
            {
                frmHastanelerListesi frm = new frmHastanelerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }
    }
}
