using DoAnSE104.DAL;
using DoAnSE104.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.BUS
{
    public class BUS_BaoCaoSuDungThuoc
    {
        DAL_BaoCaoSoLuongThuoc dal = new DAL_BaoCaoSoLuongThuoc();

        public List<DTO_BaoCaoSuDungThuoc> LayBaoCaoSuDungThuoc(int month, int year)
        {
            if (month < 1 || month > 12)
                throw new ArgumentException("Tháng không hợp lệ.");

            if (year < 2000 || year > DateTime.Now.Year)
                throw new ArgumentException("Năm không hợp lệ.");

            return dal.LayBaoCaoSuDungThuoc(month, year);
        }
    }
}
