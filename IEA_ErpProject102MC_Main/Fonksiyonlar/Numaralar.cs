
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
        public string CariKoduDoktor()
        {
            try
            {
                //where yaz 
                var numara = (from s in erp.tblCariler where s.CariGrupId == 2 orderby s.Id  descending select s).First().Id;
                numara++;
                string num = "D" + numara.ToString().PadLeft(8, '0');
                return num;
            }
            catch (Exception)
            {
                return "D00000001";
            }
        }
    }
}
