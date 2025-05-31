using DoAnSE104.DTO;
using DoAnSE104.DAL;
using System.Collections.Generic;

namespace DoAnSE104.BUS
{
    public class BUS_BaoCaoDoanhThu
    {
        private DAL_BaoCaoDoanhThu dalBaoCao = new DAL_BaoCaoDoanhThu();

        /// <summary>
        /// Lấy danh sách báo cáo doanh thu theo năm và tháng.
        /// </summary>
        /// <param name="year">Năm cần báo cáo</param>
        /// <param name="month">Tháng cần báo cáo</param>
        /// <returns>Danh sách DTO_BaoCaoDoanhThu</returns>
        public List<DTO_BaoCaoDoanhThu> LayBaoCaoDoanhThu(int year, int month)
        {
            return dalBaoCao.LayBaoCaoDoanhThu(year, month);
        }
    }
}
