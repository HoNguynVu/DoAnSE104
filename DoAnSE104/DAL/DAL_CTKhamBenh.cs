using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

    }
}
