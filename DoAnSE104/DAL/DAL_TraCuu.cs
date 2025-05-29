using DoAnSE104.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DAL
{
    public class DAL_TraCuu
    {
        private DatabaseHelper db = new DatabaseHelper();

        public List<DTO_BenhNhanTraCuu> TraCuuBenhNhan(
            string maBenhNhan, string hoTen, string gioiTinh, string diaChi,
            string trieuChung, string maLoaiBenh,
            DateTime? ngayKhamTu, DateTime? ngayKhamDen,
            int? namSinhTu, int? namSinhDen,
            string maKhamTu, string maKhamDen,
            string maLoaiThuoc, string maDonVi)
        {
            string query = @"
                SELECT 
                BN.MaBenhNhan, BN.HoTen, BN.GioiTinh, BN.NamSinh, BN.DiaChi,
                KB.NgayKham, KB.TrieuChung,
                LB.TenLoaiBenh
                FROM BENHNHAN BN
                LEFT JOIN KHAMBENH KB ON BN.MaBenhNhan = KB.MaBenhNhan
                LEFT JOIN LOAIBENH LB ON KB.MaLoaiBenh = LB.MaLoaiBenh
                LEFT JOIN CTKHAMBENH CT ON KB.MaKhamBenh = CT.MaKhamBenh
                LEFT JOIN LOAITHUOC LT ON CT.MaLoaiThuoc = LT.MaLoaiThuoc
                LEFT JOIN DONVI DV ON LT.MaDonVi = DV.MaDonVi
                WHERE 1 = 1";

            List<MySqlParameter> parameters = new List<MySqlParameter>();

            // Điều kiện tìm kiếm linh hoạt
            if (!string.IsNullOrEmpty(maBenhNhan))
            {
                query += " AND BN.MaBenhNhan LIKE @MaBenhNhan";
                parameters.Add(new MySqlParameter("@MaBenhNhan", $"%{maBenhNhan}%"));
            }

            if (!string.IsNullOrEmpty(hoTen))
            {
                query += " AND BN.HoTen LIKE @HoTen";
                parameters.Add(new MySqlParameter("@HoTen", $"%{hoTen}%"));
            }

            if (!string.IsNullOrEmpty(gioiTinh))
            {
                query += " AND BN.GioiTinh = @GioiTinh";
                parameters.Add(new MySqlParameter("@GioiTinh", gioiTinh));
            }

            if (!string.IsNullOrEmpty(diaChi))
            {
                query += " AND BN.DiaChi LIKE @DiaChi";
                parameters.Add(new MySqlParameter("@DiaChi", $"%{diaChi}%"));
            }

            if (!string.IsNullOrEmpty(trieuChung))
            {
                query += " AND KB.TrieuChung LIKE @TrieuChung";
                parameters.Add(new MySqlParameter("@TrieuChung", $"%{trieuChung}%"));
            }

            if (!string.IsNullOrEmpty(maLoaiBenh))
            {
                query += " AND KB.MaLoaiBenh = @MaLoaiBenh";
                parameters.Add(new MySqlParameter("@MaLoaiBenh", maLoaiBenh));
            }

            if (ngayKhamTu.HasValue)
            {
                query += " AND KB.NgayKham >= @NgayKhamTu";
                parameters.Add(new MySqlParameter("@NgayKhamTu", ngayKhamTu.Value));
            }

            if (ngayKhamDen.HasValue)
            {
                query += " AND KB.NgayKham <= @NgayKhamDen";
                parameters.Add(new MySqlParameter("@NgayKhamDen", ngayKhamDen.Value));
            }

            if (namSinhTu.HasValue)
            {
                query += " AND BN.NamSinh >= @NamSinhTu";
                parameters.Add(new MySqlParameter("@NamSinhTu", namSinhTu.Value));
            }

            if (namSinhDen.HasValue)
            {
                query += " AND BN.NamSinh <= @NamSinhDen";
                parameters.Add(new MySqlParameter("@NamSinhDen", namSinhDen.Value));
            }

            if (!string.IsNullOrEmpty(maKhamTu) && int.TryParse(maKhamTu.Substring(2), out int soTu))
            {
                query += " AND CAST(SUBSTRING(KB.MaKhamBenh, 3) AS UNSIGNED) >= @SoTu";
                parameters.Add(new MySqlParameter("@SoTu", soTu));
            }

            if (!string.IsNullOrEmpty(maKhamDen) && int.TryParse(maKhamDen.Substring(2), out int soDen))
            {
                query += " AND CAST(SUBSTRING(KB.MaKhamBenh, 3) AS UNSIGNED) <= @SoDen";
                parameters.Add(new MySqlParameter("@SoDen", soDen));
            }

            if (!string.IsNullOrEmpty(maLoaiThuoc))
            {
                query += " AND LT.MaLoaiThuoc = @MaLoaiThuoc";
                parameters.Add(new MySqlParameter("@MaLoaiThuoc", maLoaiThuoc));
            }

            if (!string.IsNullOrEmpty(maDonVi))
            {
                query += " AND DV.MaDonVi = @MaDonVi";
                parameters.Add(new MySqlParameter("@MaDonVi", maDonVi));
            }

            // Thực thi truy vấn
            DataTable dt = db.ExecuteQuery(query, parameters.ToArray());

            // Chuyển DataTable thành danh sách DTO
            List<DTO_BenhNhanTraCuu> ketQua = new List<DTO_BenhNhanTraCuu>();
            foreach (DataRow row in dt.Rows)
            {
                ketQua.Add(new DTO_BenhNhanTraCuu
                {
                    MaBenhNhan = row["MaBenhNhan"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    GioiTinh = row["GioiTinh"].ToString(),
                    NamSinh = Convert.ToInt32(row["NamSinh"]),
                    DiaChi = row["DiaChi"].ToString(),
                    //NgayKham = Convert.ToDateTime(row["NgayKham"]),
                    //TrieuChung = row["TrieuChung"].ToString(),
                    //TenLoaiBenh = row["TenLoaiBenh"].ToString()
                    NgayKham = row["NgayKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["NgayKham"]) : null,
                    TrieuChung = row["TrieuChung"] != DBNull.Value ? row["TrieuChung"].ToString() : "",
                    TenLoaiBenh = row["TenLoaiBenh"] != DBNull.Value ? row["TenLoaiBenh"].ToString() : "",

                });
            }

            return ketQua;
        }
    }
}
