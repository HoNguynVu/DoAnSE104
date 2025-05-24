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
    }
}
