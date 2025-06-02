using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using DoAnSE104.DTO;
using System.Windows.Forms;

namespace DoAnSE104.DAL
{
    class DAL_DonVi
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        // Lấy danh sách đơn vị
        public List<DTO_DonVi> LayDanhSachDonVi()
        {
            string query = "SELECT * FROM DONVI"; 
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<DTO_DonVi> danhSachDonVi = new List<DTO_DonVi>();

            foreach (DataRow row in dt.Rows)
            {
                string ma = row["MaDonVi"].ToString();
                string ten = row["TenDonVi"].ToString();
                DTO_DonVi donVi = new DTO_DonVi(ma, ten);
                danhSachDonVi.Add(donVi);
            }

            return danhSachDonVi;
        }

        // Thêm đơn vị
        public bool ThemDonVi(DTO_DonVi dvt)
        {
            string query = "INSERT INTO DONVI (MaDonVi, TenDonVi) VALUES (@ma, @ten)";
            MySqlParameter[] parameters = {
            new MySqlParameter("@ma", dvt.maDonVi),
            new MySqlParameter("@ten", dvt.tenDonVi)
        };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Cập nhật đơn vị
        public bool CapNhatDonVi(DTO_DonVi dvt)
        {
            string query = "UPDATE DONVI SET TenDonVi = @ten WHERE MaDonVi = @ma";
            MySqlParameter[] parameters = {
            new MySqlParameter("@ma", dvt.maDonVi),
            new MySqlParameter("@ten", dvt.tenDonVi)
        };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Xoá đơn vị
        public static bool XoaDonVi(string maDonVi)
        {
            string query = "DELETE FROM DONVI WHERE MaDonVi = @ma";

            MySqlParameter[] parameters = {
        new MySqlParameter("@ma", maDonVi)
    };

            var dbHelper = new DatabaseHelper();
            try
            {
                return dbHelper.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (MySqlException ex)
            {
                // Nếu lỗi do ràng buộc khóa ngoại
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Không thể xóa vì đơn vị này đang được sử dụng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                    return false;
                }
            }
        }
        public string LayMaDonViMoi()
        {
            string query = "SELECT MaDonVi FROM DONVI ORDER BY MaDonVi DESC LIMIT 1";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                string maCuoi = dt.Rows[0]["MaDonVi"].ToString(); // VD: DV09
                int so = int.Parse(maCuoi.Substring(2));          // Lấy số: 9
                so++;                                              // +1 → 10
                return "DV" + so.ToString("D3");                   // "DV10"
            }
            else
            {
                return "DV01"; // Nếu chưa có mã nào
            }
        }

    }
}
