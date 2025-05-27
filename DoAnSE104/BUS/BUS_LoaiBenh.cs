using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnSE104.DTO;
using DoAnSE104.DAL;

namespace DoAnSE104.BUS
{
    public class BUS_LoaiBenh
    {
        DAL_LoaiBenh DAL_LoaiBenh = new DAL_LoaiBenh();
        public List<DTO_LoaiBenh> LayDanhSachLoaiBenh()
        {
            return DAL_LoaiBenh.LayDanhSachLoaiBenh();
        }
    }
}
