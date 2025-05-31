using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using DoAnSE104.DTO;

namespace DoAnSE104.DAL
{
    public class DAL_BaoCaoDoanhThu
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();

        public double LayTongDoanhThuThang(int nam, int thang)
        {
            string query = @"
                SELECT SUM(TIENKHAM + TIENTHUOC)
                FROM HOADON H
                JOIN KHAMBENH KB ON H.MAKHAMBENH = KB.MAKHAMBENH
                WHERE YEAR(KB.NGAYKHAM) = @nam AND MONTH(KB.NGAYKHAM) = @thang";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@nam", nam),
                new MySqlParameter("@thang", thang)
            };

            object result = DatabaseHelper.ExcuteScalar(query, parameters);
            return result != null && result != DBNull.Value ? Convert.ToDouble(result) : 0;
        }

        public List<DTO_BaoCaoDoanhThu> LayBaoCaoDoanhThu(int nam, int thang)
        {
            double tongThang = LayTongDoanhThuThang(nam, thang);

            string query = @"
                SELECT 
                    DATE(KB.NGAYKHAM) AS NGAY,
                    COUNT(*) AS SOHOADON,
                    SUM(H.TIENKHAM + H.TIENTHUOC) AS DOANHTHU
                FROM HOADON H
                JOIN KHAMBENH KB ON H.MAKHAMBENH = KB.MAKHAMBENH
                WHERE YEAR(KB.NGAYKHAM) = @nam AND MONTH(KB.NGAYKHAM) = @thang
                GROUP BY DATE(KB.NGAYKHAM)
                ORDER BY NGAY";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@nam", nam),
                new MySqlParameter("@thang", thang)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            List<DTO_BaoCaoDoanhThu> danhSach = new List<DTO_BaoCaoDoanhThu>();

            foreach (DataRow row in dt.Rows)
            {
                DateTime ngay = Convert.ToDateTime(row["NGAY"]);
                int soHoaDon = Convert.ToInt32(row["SOHOADON"]);
                double doanhThu = row["DOANHTHU"] != DBNull.Value ? Convert.ToDouble(row["DOANHTHU"]) : 0;
                double tyLe = (tongThang > 0) ? (doanhThu / tongThang) * 100 : 0;

                danhSach.Add(new DTO_BaoCaoDoanhThu(ngay, soHoaDon, doanhThu, tyLe));
            }

            return danhSach;
        }
        /*public List<DTO_BaoCaoDoanhThu> LayBaoCaoDoanhThu(int nam, int thang) {
            // Dữ liệu mẫu để test giao diện
            return new List<DTO_BaoCaoDoanhThu>
            {
                new DTO_BaoCaoDoanhThu(new DateTime(nam, thang, 1), 2, 200000, 40),
                new DTO_BaoCaoDoanhThu(new DateTime(nam, thang, 2), 1, 300000, 60)
            };
        }*/
    }
}