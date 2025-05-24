using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO
{
    public class DTO_CTKhamBenh
    {
        private string MaKhamBenh;
        private string MaLoaiThuoc;
        private int SoLuongThuoc;
        public string maKhamBenh { get => MaKhamBenh; set => MaKhamBenh = value; }
        public string maLoaiThuoc { get => MaLoaiThuoc; set => MaLoaiThuoc = value; }
        public int soLuongThuoc { get => SoLuongThuoc; set => SoLuongThuoc = value; }
        public DTO_CTKhamBenh(string maKhamBenh, string maLoaiThuoc, int soLuongThuoc)
        {
            this.MaKhamBenh = maKhamBenh;
            this.MaLoaiThuoc = maLoaiThuoc;
            this.SoLuongThuoc = soLuongThuoc;
        }
    }
}
