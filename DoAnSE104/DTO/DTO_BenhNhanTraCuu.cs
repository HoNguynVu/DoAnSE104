using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO
{
    public class DTO_BenhNhanTraCuu
    {
        public string MaBenhNhan { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }

        // Các thuộc tính có thể null
        public DateTime? NgayKham { get; set; }
        public string TrieuChung { get; set; }
        public string TenLoaiBenh { get; set; }
    }
}
