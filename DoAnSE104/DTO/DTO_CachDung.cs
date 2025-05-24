using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO
{
    public class DTO_CachDung
    {
        private string MaCachDung;
        private string TenCachDung;
        public string maCachDung { get => MaCachDung; set => MaCachDung = value; }
        public string tenCachDung { get => TenCachDung; set => TenCachDung = value; }
        public DTO_CachDung(string maCachDung, string tenCachDung)
        {
            this.MaCachDung = maCachDung;
            this.TenCachDung = tenCachDung;
        }
    }
}
