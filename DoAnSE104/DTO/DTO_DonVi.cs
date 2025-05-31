using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO
{
    public class DTO_DonVi
    {
        private string MaDonVi;
        private string TenDonVi;

        public string maDonVi { get => MaDonVi; set => MaDonVi = value; }
        public string tenDonVi { get => TenDonVi; set => TenDonVi = value; }
        public DTO_DonVi() { }
        public DTO_DonVi(string maDonVi, string tenDonVi)
        {
            this.MaDonVi = maDonVi;
            this.TenDonVi = tenDonVi;
        }
    }
}
