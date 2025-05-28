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
    class DAL_DonVi
    {
        DatabaseHelper DatabaseHelper = new DatabaseHelper();
        public List<DTO_DonVi> LayDanhSachDonVi()
        {
            string query = "SELECT * FROM DONVI";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<DTO_DonVi> danhSachDonVi = new List<DTO_DonVi>();
            foreach (DataRow row in dt.Rows)
            {
                string maDonVi = row["MaDonVi"].ToString();
                string tenDonVi = row["TenDonVi"].ToString();
                DTO_DonVi donVi = new DTO_DonVi(maDonVi, tenDonVi);
                danhSachDonVi.Add(donVi);
            }
            return danhSachDonVi;
        }
    }
}
