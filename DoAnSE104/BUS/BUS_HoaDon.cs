using DoAnSE104.DAL;
using DoAnSE104.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.BUS
{
    public class BUS_HoaDon
    {
        private DAL_HoaDon DAL_HoaDon = new DAL_HoaDon();

        // Lấy danh sách hóa đơn từ database
        public List<DTO_HoaDon> LayDanhSachHoaDon()
        {
            return DAL_HoaDon.LayDanhSachHoaDon();
        }

        // Sinh mã hóa đơn mới
        public string LayMaHoaDonMoi()
        {
            return DAL_HoaDon.LayMaHoaDonMoi();
        }

        // Lấy tiền khám từ bảng THAMSO
        public double LayTienKham()
        {
            return DAL_HoaDon.LayTienKham();
        }

        // Tính tiền thuốc theo mã khám bệnh
        public double TinhTienThuoc(string maKhamBenh)
        {
            return DAL_HoaDon.TinhTienThuoc(maKhamBenh);
        }

        // Lập hóa đơn mới (thêm vào DB)
        public bool LapHoaDon(DTO_HoaDon hoaDon)
        {
            return DAL_HoaDon.LapHoaDon(hoaDon);
        }

        public DataTable LayChiTietThuocTheoMaKhamBenh(string maKhamBenh)
        {
            return DAL_HoaDon.LayChiTietThuocTheoMaKhamBenh(maKhamBenh);
        }

        public DTO_HoaDon LayHoaDonTheoMaKhamBenh(string maKhamBenh)
        {
            return DAL_HoaDon.LayHoaDonTheoMaKhamBenh(maKhamBenh);
        }
    }
}
