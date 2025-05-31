using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO
{
    public class DTO_ChiTietPhieuKham
    {
        public string maKhamBenh { get; set; }
        public string maThuoc { get; set; }
        public int soLuong { get; set; }

        public DTO_ChiTietPhieuKham(string maKhamBenh, string maThuoc, int soLuong)
        {
            this.maKhamBenh = maKhamBenh;
            this.maThuoc = maThuoc;
            this.soLuong = soLuong;
        }
    }
}
