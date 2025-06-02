using System.Collections.Generic;
using DoAnSE104.DTO;
using DoAnSE104.DAL;
using System.Linq;

namespace DoAnSE104.BUS
{
   public class BUS_CachDung
    {
        DAL_CachDung DAL_CachDung = new DAL_CachDung();
        public List<DTO_CachDung> LayDanhSachCachDung()
        {
            return DAL_CachDung.LayDanhSachCachDung();
        }
        public string LayMaCachDungMoi(List<DTO_CachDung> dsCachDung = null) {
            var danhSach = (dsCachDung != null && dsCachDung.Count > 0)
                ? dsCachDung
                : LayDanhSachCachDung();

            var maxNumber = danhSach
                .Select(lt => lt.maCachDung)
                .Where(m => !string.IsNullOrEmpty(m) && m.StartsWith("CD") && m.Length >= 3 && int.TryParse(m.Substring(2), out _))
                .Select(m => int.Parse(m.Substring(2)))
                .DefaultIfEmpty(0)
                .Max();

            return $"CD{(maxNumber + 1):D3}";
        }
        public bool ThemNhieuCachDung(List<DTO_CachDung> dsCachDung) {
            try {
                foreach (var cd in dsCachDung) {
                    if (!DAL_CachDung.ThemCachDung(cd))
                        return false;
                }
                return true;
            }
            catch {
                return false;
            }
        }

        public bool ThemCachDungMoi(DTO_CachDung cachDung) {
            return DAL_CachDung.ThemCachDung(cachDung);
        }

        public bool KiemTraCachDungDangDuocSuDung(string maCachDung) {
            try {
                return DAL_CachDung.KiemTraCachDungDangDuocSuDung(maCachDung);
            }
            catch {
                return false;
            }
        }

        public bool XoaCachDung(string maCachDung) {
            try {
                if (KiemTraCachDungDangDuocSuDung(maCachDung)) {
                    return false; 
                }

                return DAL_CachDung.XoaCachDung(maCachDung);
            }
            catch {
                return false;
            }
        }
    }
}
