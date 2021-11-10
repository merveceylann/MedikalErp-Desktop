
using IEA_ErpProject102MC_Main.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject102MC_Main.Fonksiyonlar
{
    class Numaralar
    {
        private readonly ErpProject102Entities erp = new ErpProject102Entities();
        public string CariKoduHastane()
        {
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id;
                numara++;
                string num = "H" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "H00000001";
            }
        }
    }
}
