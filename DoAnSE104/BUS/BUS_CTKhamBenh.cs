using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnSE104.DTO;
using DoAnSE104.DAL;
namespace DoAnSE104.BUS
{
    public class BUS_CTKhamBenh
    {
        DAL_CTKhamBenh DAL_CTKhamBenh = new DAL_CTKhamBenh();
        
        public bool ThemChiTietThuoc(string maKhamBenh, string maLoaiThuoc, int soLuong)
        {
            if (string.IsNullOrWhiteSpace(maKhamBenh) || string.IsNullOrWhiteSpace(maLoaiThuoc) || soLuong <= 0)
                throw new Exception("Thông tin chi tiết thuốc không hợp lệ.");
            return DAL_CTKhamBenh.ThemChiTietThuoc(maKhamBenh, maLoaiThuoc, soLuong);
        }
        public List<DTO_CTKhamBenh> LayDanhSachChiTietKhamBenh(string maKhamBenh)
        {
            if (string.IsNullOrWhiteSpace(maKhamBenh))
                throw new Exception("Mã khám bệnh không được để trống.");
            return DAL_CTKhamBenh.LayDanhSachChiTietKhamBenh(maKhamBenh);
        }
    }
}
