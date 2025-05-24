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
            string query = "SELECT TenCachDung FROM CACHDUNG";
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
    }
}
