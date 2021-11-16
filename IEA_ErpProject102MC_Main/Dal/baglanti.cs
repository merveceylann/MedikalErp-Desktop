using IEA_ErpProject102MC_Main.Entity;
using IEA_ErpProject102MC_Main.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject102MC_Main.Dal
{
    public class baglanti:Form
    {
        internal ErpProject102Entities erp = new ErpProject102Entities();
        internal Numaralar _n = new Numaralar();
        protected int secimId = -1;
        public formlar f = new formlar();
    }
}
