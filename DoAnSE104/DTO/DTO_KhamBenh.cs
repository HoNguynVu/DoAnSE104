using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO
{
    public class DTO_KhamBenh
    {
        private string MaKhamBenh;
        private DateTime NgayKham;
        private string MaBenhNhan;
        private string TrieuChung;
        private string MaLoaiBenh;
        public string maKhamBenh { get => MaKhamBenh; set => MaKhamBenh = value; }
        public DateTime ngayKham { get => NgayKham; set => NgayKham = value; }
        public string maBenhNhan { get => MaBenhNhan; set => MaBenhNhan = value; }
        public string trieuChung { get => TrieuChung; set => TrieuChung = value; }
        public string maLoaiBenh { get => MaLoaiBenh; set => MaLoaiBenh = value; }
        public DTO_KhamBenh(string maKhamBenh, DateTime ngayKham, string maBenhNhan, string trieuChung, string maLoaiBenh)
        {
            this.MaKhamBenh = maKhamBenh;
            this.NgayKham = ngayKham;
            this.MaBenhNhan = maBenhNhan;
            this.TrieuChung = trieuChung;
            this.MaLoaiBenh = maLoaiBenh;
        }
    }
}
