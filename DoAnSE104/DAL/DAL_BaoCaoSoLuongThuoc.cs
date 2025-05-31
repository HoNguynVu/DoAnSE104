using DoAnSE104.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DAL
{
    internal class DAL_BaoCaoSoLuongThuoc
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();

        // Lấy báo cáo thuốc dùng theo tháng, năm
        public List<DTO_BaoCaoSuDungThuoc> LayBaoCaoSuDungThuoc(int month, int year)
        {
            string query = @"
                SELECT 
                    lt.TenLoaiThuoc AS TenThuoc,
                    dv.TenDonVi AS DonViTinh,
                    SUM(ct.SoLuongThuoc) AS TongSoLuong,
                    COUNT(DISTINCT ct.MaKhamBenh) AS SoLanDung
                FROM CTKhamBenh ct
                INNER JOIN LoaiThuoc lt ON ct.MaLoaiThuoc = lt.MaLoaiThuoc
                INNER JOIN DonVi dv ON lt.MaDonVi = dv.MaDonVi
                INNER JOIN KhamBenh kb ON ct.MaKhamBenh = kb.MaKhamBenh
                WHERE MONTH(kb.NgayKham) = @month AND YEAR(kb.NgayKham) = @year
                GROUP BY lt.TenLoaiThuoc, dv.TenDonVi
                ORDER BY lt.TenLoaiThuoc";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@month", month),
                new MySqlParameter("@year", year)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            List<DTO_BaoCaoSuDungThuoc> danhSachBaoCao = new List<DTO_BaoCaoSuDungThuoc>();
            foreach (DataRow row in dt.Rows)
            {
                string tenThuoc = row["TenThuoc"].ToString();
                string donViTinh = row["DonViTinh"].ToString();
                int soLuong = row["TongSoLuong"] != DBNull.Value ? Convert.ToInt32(row["TongSoLuong"]) : 0;
                int soLanDung = row["SoLanDung"] != DBNull.Value ? Convert.ToInt32(row["SoLanDung"]) : 0;

                danhSachBaoCao.Add(new DTO_BaoCaoSuDungThuoc(soLuong, donViTinh, tenThuoc, soLanDung));
            }

            return danhSachBaoCao;
        }
    }
}
