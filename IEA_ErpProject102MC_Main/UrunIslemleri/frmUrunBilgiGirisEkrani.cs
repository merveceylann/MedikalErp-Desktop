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

namespace IEA_ErpProject102MC_Main.UrunIslemleri
{
    public partial class frmUrunBilgiGirisEkrani : Form
    {
        public frmUrunBilgiGirisEkrani()
        {
            InitializeComponent();
        }
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();

        private int secimId = -1;

        private void frmUrunBilgiGirisEkrani_Load(object sender, EventArgs e)
        {
           ComboDoldur();
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
                           uparab=s.ParaBirimi,
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

            lblUrunKodu.Text = n.UrunGenelKodu();
            //txtUKoduBul.Text = n.UrunGenelKodu();
        }
        private void ComboDoldur()
        {
            txtParaB.DataSource = Enum.GetValues(typeof(enumParaBirimi));
            txtKulTarih.DataSource = Enum.GetValues(typeof(enumTarih));
            txtTFirmaId.DataSource = Enum.GetValues(typeof(enumFirmaTipi));
            
            /*
            Distributor.DataSource=(from s in erp.tblCariler
                                      where s.CariGrupId==3 
                                      where s.CariTipID==1
                                      select s).ToList();
            Distributor.ValueMember = "Id";
            Distributor.DisplayMember = "Tedarikciii";
            Distributor.SelectedIndex = -1;
            */

            //var ted = erp.tblCariler.Where(x => x.CariTipId==1 && x.CariTipId==2 && x.CariTipId==4).ToList();

            //txtTFirmaId.DataSource = ted;
            //txtTFirmaId.ValueMember = "Id";
            //txtTFirmaId.DisplayMember = "CariTipId";
            //txtTFirmaId.SelectedIndex = -1;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }
        private void YeniKayit()
        {
            string ukodu = n.UrunGenelKodu();
            try
            {
                if (txtUrunAdi.Text == "")
                {
                    return;
                }
                if (secimId == -1)
                {
                    tblUrunler urun = new tblUrunler();
                    urun.isActive = true;
                    urun.UrunAdi = txtUrunAdi.Text;
                    urun.UrunAciklama = txtUrunAciklama.Text;
                    urun.KutuIcerik = txtKutuIcerik.Text;
                    urun.TedarikciFirmaId = txtTFirmaId.Text;
                    urun.Barkod = txtBarkod.Text;
                    urun.Fiyat = txtFiyat.Text;
                    urun.ParaBirimi = txtParaB.Text;
                    urun.UretimTarihi = txtUretimT.Value;
                    if (txtDurum.Checked == true)
                    {
                        int sure = Convert.ToInt32(txtKSure.Text);
                        if (txtKulTarih.Text == "Gun")
                        {
                            txtSkt.Value = txtUretimT.Value.AddDays(sure);
                        }
                        else if (txtKulTarih.Text == "Ay")
                        {
                            txtSkt.Value = txtUretimT.Value.AddMonths(sure);
                        }
                        else
                        {
                            txtSkt.Value = txtUretimT.Value.AddYears(sure);
                        }
                    }
                    urun.SonKullanmaT = txtSkt.Value;
                    urun.UrunKodu = ukodu;

                    erp.tblUrunler.Add(urun);
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
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is DateTimePicker)
                {
                    k.Text = "";
                }
            }
            secimId = -1;
            txtParaB.SelectedIndex = -1;
            txtTFirmaId.SelectedIndex = -1;
            txtKulTarih.SelectedIndex = -1;

            txtDurum.Checked = false;
            txtKSure.Visible = false;
            btnSure.Visible = false;
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
                tblUrunler urun = erp.tblUrunler.Find(secimId);
                urun.UrunAdi = txtUrunAdi.Text;
                urun.UrunAciklama = txtUrunAciklama.Text;
                urun.KutuIcerik = txtKutuIcerik.Text;
                urun.TedarikciFirmaId = txtTFirmaId.Text;
                urun.Barkod = txtBarkod.Text;
                urun.Fiyat = txtFiyat.Text;
                urun.ParaBirimi = txtParaB.Text;
                urun.UretimTarihi = txtUretimT.Value;
                urun.SonKullanmaT = txtSkt.Value;
                urun.UrunKodu = lblUrunKodu.Text;

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

        public void Ac(int i)
        {
            txtDurum.Visible = true;
            secimId = i;
            try
            {
                tblUrunler urun = erp.tblUrunler.Find(i);

                txtUrunAdi.Text = urun.UrunAdi;
                txtUrunAciklama.Text = urun.UrunAciklama;
                txtKutuIcerik.Text = urun.KutuIcerik;
                txtTFirmaId.Text = urun.TedarikciFirmaId;
                txtBarkod.Text = urun.Barkod;
                txtFiyat.Text = urun.Fiyat;
                txtParaB.Text = urun.ParaBirimi;
                txtUretimT.Text = urun.UretimTarihi.ToString();
                txtSkt.Text = urun.SonKullanmaT.ToString();

                lblUrunKodu.Text = urun.UrunKodu;
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

        private void txtDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDurum.Checked)
            {
                txtKulTarih.Visible = true;
                txtKSure.Visible = true;
                label4.Visible = true;
                btnSure.Visible = true;
            }
            else
            {
                txtKulTarih.Visible = false;
                txtKSure.Visible = false;
                label4.Visible = false;
                btnSure.Visible = false;
            }
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtDurum.Checked == true)
            {
                int sure = Convert.ToInt32(txtKSure.Text);
                if (txtKulTarih.Text == "Gun")
                {
                    txtSkt.Value = txtUretimT.Value.AddDays(sure);
                }
                else if (txtKulTarih.Text == "Ay")
                {
                    txtSkt.Value = txtUretimT.Value.AddMonths(sure);
                }
                else
                {
                    txtSkt.Value = txtUretimT.Value.AddYears(sure);
                }
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Temizle();
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblUrunler urun = erp.tblUrunler.Find(secimId);
                urun.isActive = false;
                erp.SaveChanges();
                MessageBox.Show(@"Silme Basarili");
                Temizle();
                Listele();
            }
        }
    }
}
