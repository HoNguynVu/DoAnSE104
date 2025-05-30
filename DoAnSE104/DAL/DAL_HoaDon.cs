using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using DoAnSE104.DTO;

namespace DoAnSE104.DAL
{
    class DAL_HoaDon
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        public List<DTO_HoaDon> LayDanhSachHoaDon()
        {
            string query = "SELECT * FROM HOADON";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<DTO_HoaDon> danhSachHoaDon = new List<DTO_HoaDon>();
            foreach (DataRow row in dt.Rows)
            {
                string maHoaDon = row["MaHoaDon"].ToString();
                double tienKham = double.Parse(row["TienKham"].ToString());
                double tienThuoc = double.Parse(row["TienThuoc"].ToString());
                string maKhamBenh = row["MaKhamBenh"].ToString();
                DTO_HoaDon hoaDon = new DTO_HoaDon(maHoaDon, tienKham, tienThuoc, maKhamBenh);
                danhSachHoaDon.Add(hoaDon);
            }
            return danhSachHoaDon;
        }
        public string LayMaHoaDonMoi()
        {
            string query = "SELECT MAX(MaHoaDon) FROM HOADON";
            object result = DatabaseHelper.ExecuteScalar(query);
            if (result == DBNull.Value || result == null)
                return "HD001";
            string maCuoi = result.ToString();
            int soCuoi;
            if(int.TryParse(maCuoi.Substring(2), out soCuoi))
            {
                soCuoi += 1;
                return "HD" + soCuoi.ToString("D3");
            }
            return "HD001";
        }
        public double LayTienKham()
        {
            string query = "SELECT * FROM THAMSO LIMIT 1";
            DataTable result = DatabaseHelper.ExecuteQuery(query);
            if (result.Rows.Count == 0)
                return 0;
            if (Convert.ToBoolean(result.Rows[0]["QuyDinhTienKhamCoDinh"]))
                return 0;
            return Convert.ToDouble(result.Rows[0]["TienKhamCoDinh"]);
        }
        public double TinhTienThuoc(string MaKhamBenh)
        {
            string query = @"
                            SELECT ct.SoLuongThuoc, lt.DonGia
                            FROM CTKHAMBENH ct
                            JOIN LOAITHUOC lt ON ct.MaLoaiThuoc = lt.MaLoaiThuoc
                            WHERE ct.MaKhamBenh = @MaKhamBenh";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@MaKhamBenh", MaKhamBenh)
            };
            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);
            double tongTienThuoc = 0;
            foreach (DataRow row in result.Rows)
            {
                int soLuongThuoc = Convert.ToInt32(row["SoLuongThuoc"]);
                double donGia = Convert.ToDouble(row["DonGia"]);
                tongTienThuoc += soLuongThuoc * donGia;
            }
            return tongTienThuoc;
        }
        public bool LapHoaDon(DTO_HoaDon hoaDon)
        {
            string query = "INSERT INTO HOADON (MaHoaDon, TienKham, TienThuoc, MaKhamBenh) " +
                           "VALUES (@MaHoaDon, @TienKham, @TienThuoc, @MaKhamBenh)";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@MaHoaDon", hoaDon.maHoaDon),
                new MySqlParameter("@TienKham", hoaDon.tienKham),
                new MySqlParameter("@TienThuoc", hoaDon.tienThuoc),
                new MySqlParameter("@MaKhamBenh", hoaDon.maKhamBenh)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable LayChiTietThuocTheoMaKhamBenh(string maKhamBenh)
        {
            string query = @"
        SELECT 
            ct.MaLoaiThuoc, 
            lt.TenLoaiThuoc, 
            ct.SoLuongThuoc, 
            lt.DonGia
        FROM CTKHAMBENH ct
        JOIN LOAITHUOC lt ON ct.MaLoaiThuoc = lt.MaLoaiThuoc
        WHERE ct.MaKhamBenh = @MaKhamBenh";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@MaKhamBenh", maKhamBenh)
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
    }
}
