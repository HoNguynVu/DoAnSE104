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
    class DAL_CachDung
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        public List<DTO_CachDung> LayDanhSachCachDung()
        {
            string query = "SELECT * FROM CACHDUNG";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<DTO_CachDung> danhSachCachDung = new List<DTO_CachDung>();
            foreach (DataRow row in dt.Rows)
            {
                string maCachDung = row["MaCachDung"].ToString();
                string tenCachDung = row["TenCachDung"].ToString();
                DTO_CachDung cachDung = new DTO_CachDung(maCachDung, tenCachDung);
                danhSachCachDung.Add(cachDung);
            }
            return danhSachCachDung;
        }
        public bool ThemCachDung(DTO_CachDung cachDung) {
            try {
                string query = "INSERT INTO CACHDUNG (MaCachDung, TenCachDung) VALUES (@MaCachDung, @TenCachDung)";
                
                MySqlParameter[] parameters = new MySqlParameter[] {
                    new MySqlParameter("@MaCachDung", cachDung.maCachDung),
                    new MySqlParameter("@TenCachDung", cachDung.tenCachDung)
                };

                return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
            }
            catch {
                return false;
            }
        }

        public bool XoaCachDung(string maCachDung) {
            try {
                string query = "DELETE FROM CACHDUNG WHERE MaCachDung = @MaCachDung";
                MySqlParameter[] parameters = new MySqlParameter[] {
                    new MySqlParameter("@MaCachDung", maCachDung)
                };
                return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
            }
            catch {
                return false;
            }
        }

        public bool KiemTraCachDungDangDuocSuDung(string maCachDung) {
            try {
                // Kiểm tra trong bảng LOAITHUOC
                string query = @"SELECT COUNT(*) 
                                FROM LOAITHUOC 
                                WHERE MaCachDung = @MaCachDung";

                MySqlParameter[] parameters = new MySqlParameter[] {
                    new MySqlParameter("@MaCachDung", maCachDung)
                };

                int count = Convert.ToInt32(DatabaseHelper.ExcuteScalar(query, parameters));
                return count > 0;
            }
            catch {
                return false; // Nếu có lỗi, trả về false để đảm bảo an toàn
            }
        }
    }
}
