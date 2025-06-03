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
        public bool CapNhatSoLuongBenhNhanToiDaTrongNgay(int soLuong) {
            string query = "UPDATE THAMSO SET SoLuongBenhNhanToiDaTrongNgay = @SoLuongBenhNhanToiDaTrongNgay";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@SoLuongBenhNhanToiDaTrongNgay", soLuong)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool CapNhatQuyDinhSoLuongBenhNhan(bool quyDinh) {
            string query = "UPDATE THAMSO SET QuyDinhSoLuongBenhNhanToiDaTrongNgay = @QuyDinhSoLuongBenhNhanToiDaTrongNgay";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@QuyDinhSoLuongBenhNhanToiDaTrongNgay", quyDinh)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool CapNhatTienKham(double tienKhamCoDinh)
        {
            string query = "UPDATE THAMSO SET TienKhamCoDinh = @TienKhamCoDinh";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@TienKhamCoDinh", tienKhamCoDinh)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool CapNhatQuyDinhTienKham(bool quyDinh) {
            string query = "UPDATE THAMSO SET QuyDinhTienKhamCoDinh = @QuyDinhTienKhamCoDinh";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@QuyDinhTienKhamCoDinh", quyDinh)
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
    }
}
