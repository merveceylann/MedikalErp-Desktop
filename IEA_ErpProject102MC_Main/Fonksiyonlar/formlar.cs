using IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Doktorlar;
using IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Firmalar;
using IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Hastaneler;
using IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject102MC_Main.Fonksiyonlar
{
    public class formlar
    {
        public int HastaneListesi(bool secim = false)
        {
            frmHastanelerListesi frm = new frmHastanelerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            return Home.Aktarma;
        }
        public int DoktorlarListesi(bool secim = false)
        {
            frmDoktorlarListesi frm = new frmDoktorlarListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            return Home.Aktarma;
        }
        public int FirmalarListesi(bool secim = false)
        {
            frmFirmalarListesi frm = new frmFirmalarListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            return Home.Aktarma;
        }
        public int PersonellerListesi(bool secim = false)
        {
            frmPersonellerListesi frm = new frmPersonellerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            return Home.Aktarma;
        }
    }
}
