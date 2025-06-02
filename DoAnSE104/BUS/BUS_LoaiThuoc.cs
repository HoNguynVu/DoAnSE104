using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnSE104.DTO;
using DoAnSE104.DAL;

namespace DoAnSE104.BUS
{
    public class BUS_LoaiThuoc
    {
        DAL_LoaiThuoc DAL_LoaiThuoc = new DAL_LoaiThuoc();
        BUS_DonVi BUS_DonVi = new BUS_DonVi();
        BUS_CachDung BUS_CachDung = new BUS_CachDung();
        public List<DTO_LoaiThuoc> LayDanhSachLoaiThuoc()
        {
            return DAL_LoaiThuoc.LayDanhSachLoaiThuoc();
        }
        public string LayTenDonVi(string maDonVi)
        {
            List<DTO_DonVi> danhSachDonVi = BUS_DonVi.LayDanhSachDonVi();
            DTO_DonVi donVi = danhSachDonVi.FirstOrDefault(dv => dv.maDonVi == maDonVi);
            return donVi != null ? donVi.tenDonVi : maDonVi;
        }
        public List<DTO_DonVi> LayDanhSachDonVi()
        {
            return BUS_DonVi.LayDanhSachDonVi();
        }

        public string LayTenCachDung(string maCachDung)
        {
            List<DTO_CachDung> danhSachCachDung = BUS_CachDung.LayDanhSachCachDung();
            DTO_CachDung cachDung = danhSachCachDung.FirstOrDefault(cd => cd.maCachDung == maCachDung);
            return cachDung != null ? cachDung.tenCachDung : maCachDung;
        }

        public string LayMaLoaiThuocMoi(List<DTO_LoaiThuoc> danhSachThuocmoi = null)
        {
            var danhSach = (danhSachThuocmoi != null && danhSachThuocmoi.Count > 0)
                ? danhSachThuocmoi
                : LayDanhSachLoaiThuoc();

            var maxNumber = danhSach
                .Select(lt => lt.maLoaiThuoc)
                .Where(m => !string.IsNullOrEmpty(m) && m.StartsWith("LT") && m.Length >= 3 && int.TryParse(m.Substring(2), out _))
                .Select(m => int.Parse(m.Substring(2)))
                .DefaultIfEmpty(0)
                .Max();

            return $"LT{(maxNumber + 1):D3}";
        }

        public bool ThemNhieuLoaiThuoc(List<DTO_LoaiThuoc> danhSachThuoc)
        {
            try
            {
                foreach (var loaiThuoc in danhSachThuoc)
                {
                    if (!DAL_LoaiThuoc.ThemLoaiThuoc(loaiThuoc))
                        return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemLoaiThuoc(DTO_LoaiThuoc loaiThuoc)
        {
            return DAL_LoaiThuoc.ThemLoaiThuoc(loaiThuoc);
        }

        public bool XoaLoaiThuoc(string maLoaiThuoc)
        {
            return DAL_LoaiThuoc.XoaLoaiThuoc(maLoaiThuoc);
        }

        public bool KiemTraLoaiThuocDangDuocSuDung(string maLoaiThuoc)
        {
            return DAL_LoaiThuoc.KiemTraLoaiThuocDangDuocSuDung(maLoaiThuoc);
        }
    }
}
