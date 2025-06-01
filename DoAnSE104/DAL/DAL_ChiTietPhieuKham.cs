using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAnSE104.DAL {
    internal class DAL_ChiTietPhieuKham {
        private DatabaseHelper db = new DatabaseHelper();

        public bool ThemChiTietPhieuKham(DTO.DTO_ChiTietPhieuKham ct)
        {
            string query = $"INSERT INTO CHITIETPHIEUKHAM (MaKhamBenh, MaThuoc, SoLuong) VALUES ('{ct.maKhamBenh}', '{ct.maThuoc}', {ct.soLuong})";
            return db.ExecuteNonQuery(query) > 0;
        }
    }
}
