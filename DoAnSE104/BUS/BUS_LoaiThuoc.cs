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
    }
}
