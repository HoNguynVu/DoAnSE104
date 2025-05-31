using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DoAnSE104.DTO;

namespace DoAnSE104.DAL
{
    public class DAL_BaoCaoSuDungThuoc
    {
        private DatabaseHelper DatabaseHelper = new DatabaseHelper();

        public int LayTongSoLuongThuoc(int year, int month)
        {
            string query = @"
                    SELECT SUM(CTKB.SoLuong)
                    FROM CTKHAMBENH CTKB
                    JOIN KHAMBENH KB ON CTKB.MAKHAMBENH = KB.MAKHAMBENH
                    WHERE YEAR(KB.NGAYKHAM) = @year AND MONTH(KB.NGAYKHAM) = @month";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                    new MySqlParameter("@year", year),
                    new MySqlParameter("@month", month)
            };

            object result = DatabaseHelper.ExcuteScalar(query, parameters);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }

        public List<DTO_BaoCaoSuDungThuoc> LayBaoCaoSuDungThuoc(int year, int month)
        {
            string query = @"
        SELECT 
            LT.TenLoaiThuoc, 
            DV.TenDonVi, 
            SUM(CTKB.SoLuongThuoc) AS SoLuong, 
             COUNT(DISTINCT CTKB.MaKhamBenh) AS SoLanDung
        FROM CTKHAMBENH CTKB
        JOIN KHAMBENH KB ON CTKB.MaKhamBenh = KB.MaKhamBenh
        JOIN LOAITHUOC LT ON CTKB.MaLoaiThuoc = LT.MaLoaiThuoc
        JOIN DONVI DV ON LT.MaDonVi = DV.MaDonVi
        WHERE YEAR(KB.NgayKham) = @year AND MONTH(KB.NgayKham) = @month
        GROUP BY LT.TenLoaiThuoc, DV.TenDonVi
        ORDER BY SoLuong DESC";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@year", year),
        new MySqlParameter("@month", month)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            List<DTO_BaoCaoSuDungThuoc> danhSach = new List<DTO_BaoCaoSuDungThuoc>();

            foreach (DataRow row in dt.Rows)
            {
                string tenThuoc = row["TenLoaiThuoc"].ToString();
                int soLuong = row["SoLuong"] != DBNull.Value ? Convert.ToInt32(row["SoLuong"]) : 0;
                string donVi = row["TenDonVi"].ToString();
                int soLanDung = row["SoLanDung"] != DBNull.Value ? Convert.ToInt32(row["SoLanDung"]) : 0;

                danhSach.Add(new DTO_BaoCaoSuDungThuoc(tenThuoc, soLuong, donVi, soLanDung));
            }

            return danhSach;
        }
        public int LayTongSoLanSuDungThuoc(int year, int month)
        {
            string query = @"
        SELECT COUNT(*) 
        FROM CTKHAMBENH CTKB
        JOIN KHAMBENH KB ON CTKB.MAKHAMBENH = KB.MAKHAMBENH
        WHERE YEAR(KB.NGAYKHAM) = @year AND MONTH(KB.NGAYKHAM) = @month";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@year", year),
        new MySqlParameter("@month", month)
            };

            object result = DatabaseHelper.ExcuteScalar(query, parameters);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }
    }

}
