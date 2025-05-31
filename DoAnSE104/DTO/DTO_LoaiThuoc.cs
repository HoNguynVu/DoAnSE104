using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO
{
    public class DTO_LoaiThuoc
    {
        private string MaLoaiThuoc;
        private string TenLoaiThuoc;
        private string MaDonVi;
        private string MaCachDung;
        private double DonGia;
        public string maLoaiThuoc { get => MaLoaiThuoc; set => MaLoaiThuoc = value; }
        public string tenLoaiThuoc { get => TenLoaiThuoc; set => TenLoaiThuoc = value; }
        public string maDonVi { get => MaDonVi; set => MaDonVi = value; }
        public string maCachDung { get => MaCachDung; set => MaCachDung = value; }
        public double donGia { get => DonGia; set => DonGia = value; }
        public DTO_LoaiThuoc(string maLoaiThuoc, string tenLoaiThuoc, string maDonVi, string maCachDung, double donGia)
        {
            this.MaLoaiThuoc = maLoaiThuoc;
            this.TenLoaiThuoc = tenLoaiThuoc;
            this.MaDonVi = maDonVi;
            this.MaCachDung = maCachDung;
            this.DonGia = donGia;
        }
        public DTO_LoaiThuoc()
        {
            
        }
    }
}
