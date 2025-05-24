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
            if(int.TryParse(maCuoi.Substring(2), out soMoi))
            {
                soMoi++;
                return "KB" + soMoi.ToString("D3");
            }
            return "KB001";
        }
        public bool ThemKhamBenh(DTO_KhamBenh newKhamBenh)
        {
            string query = "INSERT INTO KhamBenh (MaKhamBenh, NgayKham, MaLoaiBenh) " +
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
            string query = "UPDATE KhamBenh SET MaLoaiBenh = @maLoaiBenh, TrieuChung = @trieuChung WHERE MaKhamBenh = @maKhamBenh";

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
    }
}
