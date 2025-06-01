using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnSE104.DTO;
using DoAnSE104.DAL;

namespace DoAnSE104.BUS
{
    public class BUS_KhamBenh
    {
        DAL_KhamBenh DAL_KhamBenh = new DAL_KhamBenh();
        public List<DTO_KhamBenh> LayDanhSachKhamBenh()
        {
            return DAL_KhamBenh.LayDanhSachKhamBenh();
        }
        public bool ThemKhamBenh(DTO_KhamBenh newKhamBenh)
        {
            if (string.IsNullOrWhiteSpace(newKhamBenh.maBenhNhan))
                throw new Exception("Mã bệnh nhân không được để trống.");
            return DAL_KhamBenh.ThemKhamBenh(newKhamBenh);
        }
        public string LayMaKhamBenhMoi()
        {
            return DAL_KhamBenh.LayMaKhamBenhMoi();
        }
        public bool CapNhatKhamBenh(string maKhamBenh, string maLoaiBenh, string trieuChung)
        {
            if (string.IsNullOrWhiteSpace(maKhamBenh) || string.IsNullOrWhiteSpace(maLoaiBenh) || string.IsNullOrWhiteSpace(trieuChung))
                throw new Exception("Thông tin khám bệnh không hợp lệ.");
            return DAL_KhamBenh.CapNhatKhamBenh(maKhamBenh, maLoaiBenh, trieuChung);
        }
        public DTO_KhamBenh LayThongTinKhamBenh(string maKhamBenh)
        {
            if (string.IsNullOrWhiteSpace(maKhamBenh))
                throw new Exception("Mã khám bệnh không được để trống.");
            return DAL_KhamBenh.LayThongTinKhamBenh(maKhamBenh);
        }
        public int LaySoLuongBenhNhanHienTaiTrongNgay(DateTime ngayKham)
        {
            return DAL_KhamBenh.LaySoLuongBenhNhanHienTaiTrongNgay(ngayKham);
        }
    }
}
