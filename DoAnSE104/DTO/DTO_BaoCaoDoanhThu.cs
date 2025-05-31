using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO {
    public class DTO_BaoCaoDoanhThu {
        public DateTime Ngay { get; set; }
        public int SoLuongHoaDon { get; set; }
        public double TongDoanhThu { get; set; }
        public double TyLe { get; set; } 

        public DTO_BaoCaoDoanhThu() { }

        public DTO_BaoCaoDoanhThu(DateTime ngay, int soLuongHoaDon, double tongDoanhThu, double tyLe) {
            Ngay = ngay;
            SoLuongHoaDon = soLuongHoaDon;
            TongDoanhThu = tongDoanhThu;
            TyLe = tyLe;
        }
    }
}
