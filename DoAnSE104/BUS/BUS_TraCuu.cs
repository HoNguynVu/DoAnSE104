using DoAnSE104.DAL;
using DoAnSE104.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.BUS
{
    public class BUS_TraCuu
    {
        DAL_TraCuu DAL_TraCuu = new DAL_TraCuu();
        public List<DTO_BenhNhanTraCuu> LayDanhSachBenhNhanTraCuu(
            string maBenhNhan = "",
            string hoTen = "",
            string gioiTinh = "",
            string diaChi = "",
            string trieuChung = "",
            string maLoaiBenh = "",
            DateTime? ngayKhamTu = null,
            DateTime? ngayKhamDen = null,
            int? namSinhTu = null,
            int? namSinhDen = null,
            string maKhamTu = "",
            string maKhamDen = "",
            string maLoaiThuoc = "",
            string maDonVi = "")
        {
            return DAL_TraCuu.TraCuuBenhNhan(
                maBenhNhan, hoTen, gioiTinh, diaChi,
                trieuChung, maLoaiBenh,
                ngayKhamTu, ngayKhamDen,
                namSinhTu, namSinhDen,
                maKhamTu, maKhamDen,
                maLoaiThuoc, maDonVi
            );
        }

    }
}
