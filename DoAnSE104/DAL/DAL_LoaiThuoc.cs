using DoAnSE104.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DoAnSE104.DAL
{
    class DAL_LoaiThuoc
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        public List<DTO_LoaiThuoc> LayDanhSachLoaiThuoc()
        {
            string query = "SELECT * FROM LOAITHUOC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<DTO_LoaiThuoc> DanhSachLoaiThuoc = new List<DTO_LoaiThuoc>();
            foreach (DataRow row in dt.Rows)
            {
                string maLoaiThuoc = row["MaLoaiThuoc"].ToString();
                string tenLoaiThuoc = row["TenLoaiThuoc"].ToString();
                string maDonVi = row["MaDonVi"].ToString();
                string maCachDung = row["MaCachDung"].ToString();
                double donGia = Convert.ToDouble(row["DonGia"]);
                DTO_LoaiThuoc loaiThuocDTO = new DTO_LoaiThuoc(maLoaiThuoc, tenLoaiThuoc, maDonVi, maCachDung, donGia);
                DanhSachLoaiThuoc.Add(loaiThuocDTO);
            }
            return DanhSachLoaiThuoc;
        }

        public bool ThemLoaiThuoc(DTO_LoaiThuoc loaiThuoc)
        {
            try
            {
                string query = @"INSERT INTO LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaDonVi, MaCachDung, DonGia) 
                               VALUES (@MaLoaiThuoc, @TenLoaiThuoc, @MaDonVi, @MaCachDung, @DonGia)";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@MaLoaiThuoc", loaiThuoc.maLoaiThuoc),
                    new MySqlParameter("@TenLoaiThuoc", loaiThuoc.tenLoaiThuoc),
                    new MySqlParameter("@MaDonVi", loaiThuoc.maDonVi),
                    new MySqlParameter("@MaCachDung", loaiThuoc.maCachDung),
                    new MySqlParameter("@DonGia", loaiThuoc.donGia)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaLoaiThuoc(string maLoaiThuoc)
        {
            try
            {
                string query = "DELETE FROM LOAITHUOC WHERE MaLoaiThuoc = @MaLoaiThuoc";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@MaLoaiThuoc", maLoaiThuoc)
                };
                return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool KiemTraLoaiThuocDangDuocSuDung(string maLoaiThuoc)
        {
            string query = "SELECT COUNT(*) FROM CTKHAMBENH WHERE MaLoaiThuoc = @MaLoaiThuoc";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@MaLoaiThuoc", maLoaiThuoc)
            };

            object result = DatabaseHelper.ExcuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                int count = Convert.ToInt32(result);
                return count > 0;
            }

            return false;
        }
        public bool CapNhatDonGia(string maLoaiThuoc, double donGiaMoi)
        {
            try
            {
                string query = "UPDATE LOAITHUOC SET DonGia = @DonGia WHERE MaLoaiThuoc = @MaLoaiThuoc";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
            new MySqlParameter("@DonGia", donGiaMoi),
            new MySqlParameter("@MaLoaiThuoc", maLoaiThuoc)
                };
                return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
