using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnSE104.DTO;
using DoAnSE104.DAL;

namespace DoAnSE104.BUS
{
   public class BUS_CachDung
    {
        DAL_CachDung DAL_CachDung = new DAL_CachDung();
        public List<DTO_CachDung> LayDanhSachCachDung()
        {
            return DAL_CachDung.LayDanhSachCachDung();
        }
    }
}
