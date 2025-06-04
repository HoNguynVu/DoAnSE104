using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnSE104.DTO;
using DoAnSE104.DAL;

namespace DoAnSE104.BUS
{
    public class BUS_DonVi
    {
        DAL_DonVi DAL_DonVi = new DAL_DonVi();
        public List<DTO_DonVi> LayDanhSachDonVi()
        {
            return DAL_DonVi.LayDanhSachDonVi();
        }

        public bool Them(DTO_DonVi dvt)
        {
            return DAL_DonVi.ThemDonVi(dvt);
        }


        public bool Xoa(string ma)
        {
            return DAL_DonVi.XoaDonVi(ma);
        }

        public string TaoMaDonViMoi(List<DTO_DonVi> danhSachTam)
        {
            // Lấy mã mới nhất từ DB
            string maCuoiDb = DAL_DonVi.LayMaDonViMoi(); // Ví dụ: DV008
            int maxDb = int.Parse(maCuoiDb.Substring(2));

            // Lấy mã cao nhất trong danh sách tạm (nếu có)
            int maxTam = danhSachTam
                .Select(dv => dv.maDonVi)
                .Where(ma => ma.StartsWith("DV") && int.TryParse(ma.Substring(2), out _))
                .Select(ma => int.Parse(ma.Substring(2)))
                .DefaultIfEmpty(0)
                .Max();

            int next = Math.Max(maxDb, maxTam) + 1;

            return "DV" + next.ToString("D3");
        }

        public bool CapNhat(DTO_DonVi dvt)
        {
            return DAL_DonVi.CapNhatDonVi(dvt);
        }
        public bool KiemTraDonViDangDuocSuDung(string maDonVi)
        {
            return DAL_DonVi.KiemTraDonViDangDuocSuDung(maDonVi);
        }
    } 
}
