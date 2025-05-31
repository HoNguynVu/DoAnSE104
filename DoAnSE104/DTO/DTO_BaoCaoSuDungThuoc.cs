using System;

namespace DoAnSE104.DTO
{
    public class DTO_BaoCaoSuDungThuoc
    {
        public string TenThuoc { get; set; }
        public int SoLuong { get; set; }
        public string DonVi { get; set; }
        public int SoLanDung { get; set; }

        public DTO_BaoCaoSuDungThuoc() { }

        public DTO_BaoCaoSuDungThuoc(string tenThuoc, int soLuong, string donVi, int soLanDung)
        {
            TenThuoc = tenThuoc;
            SoLuong = soLuong;
            DonVi = donVi;
            SoLanDung = soLanDung;
        }
    }
}
