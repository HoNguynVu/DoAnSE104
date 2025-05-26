using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnSE104.DTO;
using DoAnSE104.DAL;

namespace DoAnSE104.BUS
{
    public class BUS_DonVi
    {
        DAL_DonVi DAL_DonVi = new DAL_DonVi();
        public List<DTO_DonVi> LayDanhSachDonVi()
        {
            return DAL_DonVi.LayDanhSachDonVi();
        }
    }
}
