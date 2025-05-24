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
    class DAL_KhamBenh
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        public List<DTO_KhamBenh> LayDanhSachKhamBenh()
        {
            string query = "SELECT * FROM KhamBenh";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<DTO.DTO_KhamBenh> DanhSachKhamBenh = new List<DTO.DTO_KhamBenh>();
            foreach (DataRow row in dt.Rows)
            {
                string maKhamBenh = row["MaKhamBenh"].ToString();
                DateTime ngayKham = DateTime.Parse(row["NgayKham"].ToString());
                string maBenhNhan = row["MaBenhNhan"].ToString();
                string trieuChung = row["TrieuChung"].ToString();
                string maLoaiBenh = row["MaLoaiBenh"].ToString();
                DTO.DTO_KhamBenh khamBenh = new DTO.DTO_KhamBenh(maKhamBenh, ngayKham, maBenhNhan, trieuChung, maLoaiBenh);
                DanhSachKhamBenh.Add(khamBenh);
            }
            return DanhSachKhamBenh;
        }
        public string LayMaKhamBenhMoi()
        {
            string query = "SELECT MaKhamBenh FROM KHAMBENH ORDER BY MaKhamBenh DESC LIMIT 1";
            DataTable result = DatabaseHelper.ExecuteQuery(query);
            if(result.Rows.Count > 0)
            {
                return "KB001"; // Neu chua co kham benh nao, tra ve ma mac dinh
            }
            string MaKhamBenh_prev = result.Rows[0]["MaKhamBenh"].ToString();
            int soMoi = int.Parse(MaKhamBenh_prev.Substring(2)) + 1;
            return "KB" + soMoi.ToString("D3");


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

    }
}
