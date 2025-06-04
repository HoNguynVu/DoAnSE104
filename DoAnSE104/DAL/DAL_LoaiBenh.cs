using DoAnSE104.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace DoAnSE104.DAL
{
    class DAL_LoaiBenh
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        public bool XoaTatCaLoaiBenh()
        {
            string query = "DELETE FROM LOAIBENH";
            return DatabaseHelper.ExecuteNonQuery(query) > 0;
        }
        public List<DTO_LoaiBenh> LayDanhSachLoaiBenh()
        {
            string query = "SELECT * FROM LOAIBENH";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<DTO_LoaiBenh> DanhSachLoaiBenh = new List<DTO_LoaiBenh>();
            foreach (DataRow row in dt.Rows)
            {
                string maLoaiBenh = row["MaLoaiBenh"].ToString();
                string tenLoaiBenh = row["TenLoaiBenh"].ToString();
                DTO_LoaiBenh loaiBenh = new DTO_LoaiBenh(maLoaiBenh, tenLoaiBenh);
                DanhSachLoaiBenh.Add(loaiBenh);
            }
            return DanhSachLoaiBenh;
        }

        public bool ThemLoaiBenh(DTO_LoaiBenh lb)
        {
            try
            {
                string query = @"INSERT INTO LOAIBENH (MaloaiBenh, TenLoaiBenh) 
                                VALUES (@MaLoaiBenh, @TenLoaiBenh)";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@MaLoaiBenh", lb.maLoaiBenh),
                    new MySqlParameter("@TenLoaiBenh", lb.tenLoaiBenh)
                };
                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaLoaiBenh(string maLoaiBenh)
        {
            try
            {
                string query = "DELETE FROM LOAIBENH WHERE MaloaiBenh = @MaloaiBenh";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@MaloaiBenh", maLoaiBenh)
                };
                return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
            }
            catch
            {
                return false;
            }
        }
        public string GetNextMaLoaiBenh()
        {
            string query = "SELECT MaLoaiBenh FROM LOAIBENH ORDER BY MaLoaiBenh DESC LIMIT 1";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                string lastID = dt.Rows[0]["MaLoaiBenh"].ToString(); // VD: "LB007"

                // Cắt bỏ "LB" để lấy phần số
                int number = int.Parse(lastID.Substring(2));

                // Tăng lên 1
                number++;

                // Ghép lại "LB" + số với định dạng 3 chữ số (001, 002, ...)
                return "LB" + number.ToString("D3");
            }
            else
            {
                // Nếu bảng rỗng
                return "LB001";
            }
        }


        public bool KiemTraLoaiBenhDangDuocSuDung(string maLoaiBenh)
        {
            try
            {
                // Kiểm tra trong bảng BENHNHAN
                string query = @"SELECT COUNT(*) 
                                FROM KHAMBENH  
                                WHERE MaLoaiBenh = @MaLoaiBenh";
                MySqlParameter[] parameters = new MySqlParameter[] {
                    new MySqlParameter("@MaLoaiBenh", maLoaiBenh)
                };
                int count = Convert.ToInt32(DatabaseHelper.ExcuteScalar(query, parameters));
                return count > 0;
            }
            catch
            {
                return false; // Nếu có lỗi, trả về false để đảm bảo an toàn
            }
        }
    } 
}
