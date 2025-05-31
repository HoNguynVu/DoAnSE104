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
    class DAL_ThamSo
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        public int SoLuongBenhNhanToiDaTrongNgay()
        {
            string query = "SELECT SoLuongBenhNhanToiDaTrongNgay FROM THAMSO";
            object result = DatabaseHelper.ExecuteScalar(query);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return 0;
        }
        public double TienKhamCoDinh()
        {
            string query = "SELECT TienKhamCoDinh FROM THAMSO";
            object result = DatabaseHelper.ExecuteScalar(query);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToDouble(result);
            }
            return 0;
        }
        public bool CapNhatQuyDinhSoLuongBenhNhan(int soLuongBenhNhanToiDaTrongNgay)
        {
            string query = "UPDATE THAMSO SET SoLuongBenhNhanToiDaTrongNgay = @SoLuongBenhNhanToiDaTrongNgay";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@SoLuongBenhNhanToiDaTrongNgay", soLuongBenhNhanToiDaTrongNgay)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool CapNhatQuyDinhTienKham(double tienKhamCoDinh)
        {
            string query = "UPDATE THAMSO SET TienKhamCoDinh = @TienKhamCoDinh";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@TienKhamCoDinh", tienKhamCoDinh)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool QuyDinhSoLuongBenhNhanToiDaTrongNgay()
        {
            string query = "SELECT QuyDinhSoLuongBenhNhanToiDaTrongNgay FROM THAMSO";
            object result = DatabaseHelper.ExecuteScalar(query);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToBoolean(result);
            }
            return false;
        }
        public bool QuyDinhTienKhamCoDinh()
        {
            string query = "SELECT QuyDinhTienKhamCoDinh FROM THAMSO";
            object result = DatabaseHelper.ExecuteScalar(query);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToBoolean(result);
            }
            return false;
        }

        public DTO_ThamSo LayThamSo()
        {
            string query = "SELECT * FROM THAMSO";
            DataTable dt = DatabaseHelper.ExecuteQuery(query); 

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                int soLuong = Convert.ToInt32(row["SoLuongBenhNhanToiDaTrongNgay"]);
                bool qdSoLuong = Convert.ToInt32(row["QuyDinhSoLuongBenhNhanToiDaTrongNgay"]) == 1;
                double tienKham = Convert.ToDouble(row["TienKhamCoDinh"]);
                bool qdTienKham = Convert.ToInt32(row["QuyDinhTienKhamCoDinh"]) == 1;

                return new DTO_ThamSo(soLuong, qdSoLuong, tienKham, qdTienKham);
            }

            return null;
        }
    }
}
