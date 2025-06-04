using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnSE104.DTO;
using DoAnSE104.DAL;

namespace DoAnSE104.BUS {
    public class BUS_LoaiBenh
    {
        DAL_LoaiBenh DAL_LoaiBenh = new DAL_LoaiBenh();

        public bool ThemLoaiBenh(DTO_LoaiBenh lt)
        {
            return DAL_LoaiBenh.ThemLoaiBenh(lt);
        }
        public bool XoaLoaiBenh(string maLoaiBenh)
        {
            return DAL_LoaiBenh.XoaLoaiBenh(maLoaiBenh);
        }
        public List<DTO_LoaiBenh> LayDanhSachLoaiBenh()
        {
            return DAL_LoaiBenh.LayDanhSachLoaiBenh();
        }

        public string NextMaLoaiBenh()
        {
            string nextMaLoaiBenh = DAL_LoaiBenh.GetNextMaLoaiBenh();
            if (nextMaLoaiBenh == null)
            {
                throw new Exception("Không thể lấy mã loại bệnh tiếp theo.");
            }
            else
            {
                Console.WriteLine("Mã loại bệnh tiếp theo: " + nextMaLoaiBenh);
                return nextMaLoaiBenh;
            }
        }

        public bool KiemTraLoaiBenhDangDuocSuDung(string maLoaiBenh)
        {
            return DAL_LoaiBenh.KiemTraLoaiBenhDangDuocSuDung(maLoaiBenh);
        }

        public string NextMaLoaiBenh(List<DTO_LoaiBenh> danhSachLoaiBenh)
        {
            string lastIdFromDb = DAL_LoaiBenh.GetNextMaLoaiBenh(); // VD: LB008 từ DB
            int maxFromDb = int.Parse(lastIdFromDb.Substring(2));

            // Tìm max trong danh sách đang hiển thị (cả loại mới thêm chưa lưu)
            int maxFromList = danhSachLoaiBenh
                .Select(lb => lb.maLoaiBenh)
                .Where(ma => ma.StartsWith("LB") && int.TryParse(ma.Substring(2), out _))
                .Select(ma => int.Parse(ma.Substring(2)))
                .DefaultIfEmpty(0)
                .Max();

            int next = Math.Max(maxFromDb, maxFromList) + 1;

            return "LB" + next.ToString("D3");
        }

    }
}
