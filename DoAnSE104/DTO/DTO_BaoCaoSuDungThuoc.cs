using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO
{
    public class DTO_BaoCaoSuDungThuoc
    {
        public int soLuong {  get; set; }
        public string donViTinh {  get; set; }
        public string tenThuoc {  get; set; }
        public int soLanDung {  get; set; }
        public DTO_BaoCaoSuDungThuoc() { }

        public DTO_BaoCaoSuDungThuoc(int sl, string dvt, string ten, int sld)
        {
            soLuong = sl;
            donViTinh = dvt;
            tenThuoc = ten;
            soLanDung = sld;
        }
    }

}
