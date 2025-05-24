using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO
{
    public class DTO_HoaDon
    {
        private string MaHoaDon;
        private double TienKham;
        private double TienThuoc;
        private string MaKhamBenh;
        public string maHoaDon { get => MaHoaDon; set => MaHoaDon = value; }
        public double tienKham { get => TienKham; set => TienKham = value; }
        public double tienThuoc { get => TienThuoc; set => TienThuoc = value; }
        public string maKhamBenh { get => MaKhamBenh; set => MaKhamBenh = value; }
        public DTO_HoaDon(string maHoaDon, double tienKham, double tienThuoc, string maKhamBenh)
        {
            this.MaHoaDon = maHoaDon;
            this.TienKham = tienKham;
            this.TienThuoc = tienThuoc;
            this.MaKhamBenh = maKhamBenh;
        }
    }
}
