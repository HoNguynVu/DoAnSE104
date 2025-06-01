using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using DoAnSE104.DTO;
using System.Diagnostics.Eventing.Reader;

namespace DoAnSE104.DAL
{
    class DAL_KhamBenh
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        public List<DTO_KhamBenh> LayDanhSachKhamBenh()
        {
            string query = "SELECT * FROM KHAMBENH";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<DTO_KhamBenh> DanhSachKhamBenh = new List<DTO_KhamBenh>();
            foreach (DataRow row in dt.Rows)
            {
                string maKhamBenh = row["MaKhamBenh"].ToString();
                DateTime ngayKham = DateTime.Parse(row["NgayKham"].ToString());
                string maBenhNhan = row["MaBenhNhan"].ToString();
                string trieuChung = row["TrieuChung"].ToString();
                string maLoaiBenh = row["MaLoaiBenh"].ToString();
                DTO_KhamBenh khamBenh = new DTO_KhamBenh(maKhamBenh, ngayKham, maBenhNhan, trieuChung, maLoaiBenh);
                DanhSachKhamBenh.Add(khamBenh);
            }
            return DanhSachKhamBenh;
        }
        public string LayMaKhamBenhMoi()
        {
            string query = "SELECT MAX(MaKhamBenh) AS MaKhamBenh FROM KHAMBENH";
            object result = DatabaseHelper.ExecuteScalar(query);
            if (result == DBNull.Value || result == null)
                return "KB001";
            string maCuoi = result.ToString();
            int soMoi;
            if (int.TryParse(maCuoi.Substring(2), out soMoi))
            {
                soMoi++;
                return "KB" + soMoi.ToString("D3");
            }
            return "KB001";
        }
        public bool ThemKhamBenh(DTO_KhamBenh newKhamBenh)
        {
            string query = "INSERT INTO KHAMBENH (MaKhamBenh, NgayKham, MaBenhNhan) " +
                           "VALUES (@MaKhamBenh, @NgayKham, @MaBenhNhan)";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@MaKhamBenh", newKhamBenh.maKhamBenh),
                new MySqlParameter("@NgayKham", newKhamBenh.ngayKham),
                new MySqlParameter("@MaBenhNhan", newKhamBenh.maBenhNhan),
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool CapNhatKhamBenh(string maKhamBenh, string maLoaiBenh, string trieuChung)
        {
            string query = "UPDATE KHAMBENH SET MaLoaiBenh = @maLoaiBenh, TrieuChung = @trieuChung WHERE MaKhamBenh = @maKhamBenh";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@maLoaiBenh", maLoaiBenh),
                new MySqlParameter("@trieuChung", trieuChung),
                new MySqlParameter("@maKhamBenh", maKhamBenh)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public List<string> LayDanhSachMaKhamBenh()
        {
            string query = "SELECT MaKhamBenh FROM KHAMBENH ORDER BY CAST(SUBSTRING(MaKhamBenh, 3) AS UNSIGNED) ASC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<string> danhSach = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                danhSach.Add(row["MaKhamBenh"].ToString());
            }

            return danhSach;
        }
        public DTO_KhamBenh LayThongTinKhamBenh(string maKhamBenh)
        {
            string query = "SELECT * FROM KHAMBENH WHERE MaKhamBenh = @MaKhamBenh";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@MaKhamBenh", maKhamBenh)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string maBenhNhan = row["MaBenhNhan"].ToString();
                DateTime ngayKham = DateTime.Parse(row["NgayKham"].ToString());
                string trieuChung = row["TrieuChung"] != DBNull.Value ? row["TrieuChung"].ToString() : "";
                string maLoaiBenh = row["MaLoaiBenh"] != DBNull.Value ? row["MaLoaiBenh"].ToString() : "";

                return new DTO_KhamBenh(maKhamBenh, ngayKham, maBenhNhan, trieuChung, maLoaiBenh);
            }
            return null;
        }
        public int LaySoLuongBenhNhanHienTaiTrongNgay(DateTime ngayKham)
        {
            string query = "SELECT COUNT(*) FROM KHAMBENH WHERE NgayKham = @NgayKham";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@NgayKham", ngayKham.Date) // đảm bảo chỉ lấy phần ngày
            };

            object result = DatabaseHelper.ExcuteScalar(query, parameters);

            return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
        }

    }
}
