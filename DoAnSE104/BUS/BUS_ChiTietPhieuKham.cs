using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnSE104.DTO;
using DoAnSE104.DAL;

namespace DoAnSE104.BUS
{
    public class BUS_ChiTietPhieuKham
    {
        private DAL_ChiTietPhieuKham dal = new DAL_ChiTietPhieuKham();

        public bool ThemChiTietPhieuKham(DTO_ChiTietPhieuKham ct)
        {
            return dal.ThemChiTietPhieuKham(ct);
        }
    }
}
