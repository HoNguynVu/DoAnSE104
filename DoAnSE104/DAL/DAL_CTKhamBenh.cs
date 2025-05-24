using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAnSE104.DTO;

namespace DoAnSE104.DAL
{
    class DAL_CTKhamBenh
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        public bool ThemChiTietThuoc(string maKhamBenh, string maLoaiThuoc, int soLuong)
        {
            string query = "INSERT INTO CTKhamBenh (MaKhamBenh, MaLoaiThuoc, SoLuongThuoc) " +
                           "VALUES (@maKham, @maThuoc, @soLuong)";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@maKham", maKhamBenh),
                new MySqlParameter("@maThuoc", maLoaiThuoc),
                new MySqlParameter("@soLuong", soLuong)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public List<DTO_CTKhamBenh> LayDanhSachChiTietKhamBenh(string maKhamBenh)
        {
            string query = "SELECT * FROM CTKhamBenh WHERE MaKhamBenh = @maKham";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@maKham", maKhamBenh)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            List<DTO_CTKhamBenh> danhSachChiTiet = new List<DTO_CTKhamBenh>();
            foreach (DataRow row in dt.Rows)
            {
                string maThuoc = row["MaLoaiThuoc"].ToString();
                int soLuong = int.Parse(row["SoLuongThuoc"].ToString());
                DTO_CTKhamBenh chiTiet = new DTO_CTKhamBenh(maKhamBenh, maThuoc, soLuong);
                danhSachChiTiet.Add(chiTiet);
            }
            return danhSachChiTiet;
        }

    }
}
