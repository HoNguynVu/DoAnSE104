using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO
{
    public class DTO_LoaiBenh
    {
        private string MaLoaiBenh;
        private string TenLoaiBenh;
        public string maLoaiBenh { get => MaLoaiBenh; set => MaLoaiBenh = value; }
        public string tenLoaiBenh { get => TenLoaiBenh; set => TenLoaiBenh = value; }
        public DTO_LoaiBenh(string maLoaiBenh, string tenLoaiBenh)
        {
            this.MaLoaiBenh = maLoaiBenh;
            this.TenLoaiBenh = tenLoaiBenh;
        }
        public DTO_LoaiBenh()
        {
        
        }
    }
}
