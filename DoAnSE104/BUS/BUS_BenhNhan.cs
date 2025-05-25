using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnSE104.DTO;
using DoAnSE104.DAL;
using System.Runtime.CompilerServices;

namespace DoAnSE104.BUS
{
    public class BUS_BenhNhan
    {
        DAL_BenhNhan DAL_BenhNhan = new DAL_BenhNhan();
        public List<DTO_BenhNhan> LayDanhSachBenhNhan()
        {
            return DAL_BenhNhan.LayDanhSachBenhNhan();
        }
        public bool ThemBenhNhan(DTO_BenhNhan newBenhNhan)
        {
            KiemTraTinhHopLe(newBenhNhan);
            return DAL_BenhNhan.ThemBenhNhan(newBenhNhan);
        }
        private void KiemTraTinhHopLe(DTO_BenhNhan newBenhNhan)
        {
            int currentYear = DateTime.Now.Year;
            if (string.IsNullOrWhiteSpace(newBenhNhan.hoTen))
                throw new Exception("Họ tên bệnh nhân không được để trống.");
            if (string.IsNullOrWhiteSpace(newBenhNhan.gioiTinh))
                throw new Exception("Giới tính bệnh nhân không được để trống.");
            if (newBenhNhan.namSinh <= 0 || newBenhNhan.namSinh > currentYear)
                throw new Exception("Năm sinh bệnh nhân không hợp lệ.");
            if (string.IsNullOrWhiteSpace(newBenhNhan.diaChi))
                throw new Exception("Địa chỉ bệnh nhân không được để trống.");
        }
        public string LayMaBenhNhanMoi()
        {
            return DAL_BenhNhan.LayMaBenhNhanMoi();
        }
        public DTO_BenhNhan LayThongTinBenhNhan(string maBenhNhan)
        {
            if (string.IsNullOrWhiteSpace(maBenhNhan))
                throw new Exception("Mã bệnh nhân không được để trống.");
            return DAL_BenhNhan.LayThongTinBenhNhan(maBenhNhan);
        }
    }
}
