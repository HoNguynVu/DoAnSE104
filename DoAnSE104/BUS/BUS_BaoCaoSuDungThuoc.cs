using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnSE104.DTO;
using DoAnSE104.DAL;

namespace DoAnSE104.BUS
{
    public class BUS_BaoCaoSuDungThuoc
    {
        private DAL_BaoCaoSuDungThuoc dal = new DAL_BaoCaoSuDungThuoc();

        public int LayTongSoLanSuDungThuoc(int year, int month)
        {
            return dal.LayTongSoLanSuDungThuoc(year, month);
        }
        public List<DTO_BaoCaoSuDungThuoc> LayBaoCaoSuDungThuoc(int year, int month)
        {
            return dal.LayBaoCaoSuDungThuoc(year, month);
        }
    }
}
