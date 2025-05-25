using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO
{
    public class DTO_BenhNhan
    {
        private string MaBenhNhan;
        private string HoTen;
        private string GioiTinh;
        private int NamSinh;
        private string DiaChi;
        public string maBenhNhan { get => MaBenhNhan; set => MaBenhNhan = value; }
        public string hoTen { get => HoTen; set => HoTen = value; }
        public string gioiTinh { get => GioiTinh; set => GioiTinh = value; }
        public int namSinh { get => NamSinh; set => NamSinh = value; }
        public string diaChi { get => DiaChi; set => DiaChi = value; }
        public DTO_BenhNhan(string maBenhNhan, string hoTen, string gioiTinh, int namSinh, string diaChi)
        {
            this.MaBenhNhan = maBenhNhan;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NamSinh = namSinh;
            this.DiaChi = diaChi;
        }
    }
}
