using DoAnSE104.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DAL
{
    class DAL_LoaiThuoc
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        public List<DTO_LoaiThuoc> LayDanhSachLoaiThuoc()
        {
            string query = "SELECT * FROM LOAITHUOC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<DTO_LoaiThuoc> DanhSachLoaiThuoc = new List<DTO_LoaiThuoc>();
            foreach (DataRow row in dt.Rows)
            {
                string maLoaiThuoc = row["MaLoaiThuoc"].ToString();
                string tenLoaiThuoc = row["TenLoaiThuoc"].ToString();
                string maDonVi = row["MaDonVi"].ToString();
                string maCachDung = row["MaCachDung"].ToString();
                double donGia = Convert.ToDouble(row["DonGia"]);
                DTO_LoaiThuoc loaiThuocDTO = new DTO_LoaiThuoc(maLoaiThuoc, tenLoaiThuoc, maDonVi, maCachDung, donGia);
                DanhSachLoaiThuoc.Add(loaiThuocDTO);
            }
            return DanhSachLoaiThuoc;
        }
    }
}
