using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DAL
{
    public class DoanhThuNgayDTO
    {
        public DateTime Ngay { get; set; }
        public int SoBenhNhan { get; set; }
        public double DoanhThu { get; set; }
        public double TyLe { get; set; } // phần trăm trong tháng
    }

    class DAL_DOANHTHU
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();

        // Tổng doanh thu toàn tháng
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

        // Lấy chi tiết doanh thu theo ngày trong tháng
        public List<DoanhThuNgayDTO> LayBaoCaoDoanhThuTheoNgay(int nam, int thang)
        {
            double tongThang = LayTongDoanhThuThang(nam, thang);

            string query = @"
                SELECT 
                    DATE(KB.NGAYKHAM) AS NGAY,
                    COUNT(*) AS SOBENHNHAN,
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
            List<DoanhThuNgayDTO> danhSach = new List<DoanhThuNgayDTO>();

            foreach (DataRow row in dt.Rows)
            {
                DateTime ngay = Convert.ToDateTime(row["NGAY"]);
                int soBN = Convert.ToInt32(row["SOBENHNHAN"]);
                double doanhThu = Convert.ToDouble(row["DOANHTHU"]);
                double tyLe = tongThang == 0 ? 0 : Math.Round((doanhThu / tongThang) * 100, 2);

                danhSach.Add(new DoanhThuNgayDTO
                {
                    Ngay = ngay,
                    SoBenhNhan = soBN,
                    DoanhThu = doanhThu,
                    TyLe = tyLe
                });
            }

            return danhSach;
        }
    }
}
