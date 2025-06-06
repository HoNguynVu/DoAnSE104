﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using DoAnSE104.DTO;

namespace DoAnSE104.DAL
{
    class DAL_BenhNhan
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        public List<DTO_BenhNhan> LayDanhSachBenhNhan()
        {
            string query = "SELECT * FROM BENHNHAN";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<DTO_BenhNhan> DanhSachBenhNhan = new List<DTO_BenhNhan>();
            foreach (DataRow row in dt.Rows)
            {
                string maBenhNhan = row["MaBenhNhan"].ToString();
                string hoTen = row["HoTen"].ToString();
                string gioiTinh = row["GioiTinh"].ToString();
                int namSinh = int.Parse(row["NamSinh"].ToString());
                string diaChi = row["DiaChi"].ToString();
                DTO_BenhNhan benhNhan = new DTO_BenhNhan(maBenhNhan, hoTen, gioiTinh, namSinh, diaChi);
                DanhSachBenhNhan.Add(benhNhan);
            }
            return DanhSachBenhNhan;
        }
        public DTO_BenhNhan LayThongTinBenhNhan(string maBenhNhan)
        {
            string query = "SELECT * FROM BENHNHAN WHERE MaBenhNhan = @MaBenhNhan";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@MaBenhNhan", maBenhNhan)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string hoTen = row["HoTen"].ToString();
                string gioiTinh = row["GioiTinh"].ToString();
                int namSinh = int.Parse(row["NamSinh"].ToString());
                string diaChi = row["DiaChi"].ToString();
                return new DTO_BenhNhan(maBenhNhan, hoTen, gioiTinh, namSinh, diaChi);
            }
            return null;
        }

        public bool ThemBenhNhan(DTO_BenhNhan BenhNhan)
        {
            string query = "INSERT INTO BENHNHAN (MaBenhNhan, HoTen, GioiTinh, NamSinh, DiaChi) " +
                           "VALUES (@MaBenhNhan, @HoTen, @GioiTinh, @NamSinh, @DiaChi)";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@MaBenhNhan", BenhNhan.maBenhNhan),
                new MySqlParameter("@HoTen", BenhNhan.hoTen),
                new MySqlParameter("@GioiTinh", BenhNhan.gioiTinh),
                new MySqlParameter("@NamSinh", BenhNhan.namSinh),
                new MySqlParameter("@DiaChi", BenhNhan.diaChi)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public string LayMaBenhNhanMoi()
        {
            string query = "SELECT MAX(MaBenhNhan) FROM BENHNHAN";
            object result = DatabaseHelper.ExecuteScalar(query);

           
            if (result == DBNull.Value || result == null)
                return "BN001";

            string maCuoi = result.ToString(); 

            
            int so;
            if (int.TryParse(maCuoi.Substring(2), out so))
            {
                so += 1;
                return "BN" + so.ToString("D3"); 
            }
            return "BN001";
        }
    }
}
