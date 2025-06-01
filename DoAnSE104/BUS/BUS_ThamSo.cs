using DoAnSE104.DAL;
using DoAnSE104.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnSE104.BUS
{
    public class BUS_ThamSo
    {
        private DAL_ThamSo dalThamSo = new DAL_ThamSo();

       
        public int SoLuongBenhNhanToiDaTrongNgay()
        {
            return dalThamSo.SoLuongBenhNhanToiDaTrongNgay();
        }
        public double TienKhamCoDinh()
        {
            return dalThamSo.TienKhamCoDinh();
        }
        public bool QuyDinhSoLuongBenhNhanToiDaTrongNgay()
        {
            return dalThamSo.QuyDinhSoLuongBenhNhanToiDaTrongNgay();
        }
        public bool QuyDinhTienKhamCoDinh()
        {
            return dalThamSo.QuyDinhTienKhamCoDinh();
        }
    }
}
