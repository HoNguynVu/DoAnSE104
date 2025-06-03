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
        //so luong
        public void updateSoLuongBenhNhanToiDaTrongNgay(int soLuongBenhNhanToiDaTrongNgay)
        {
            if (dalThamSo.CapNhatSoLuongBenhNhanToiDaTrongNgay(soLuongBenhNhanToiDaTrongNgay))
            {
               
            }
            else
            {
                MessageBox.Show("Cập nhật số lượng bệnh nhân tối đa trong ngày thất bại.");
            }
        }
        // tien kham
        public void updateTienKhamCoDinh(double tienKhamCoDinh)
        {
            if (dalThamSo.CapNhatTienKham(tienKhamCoDinh))
            {
                
            }
            else
            {
                MessageBox.Show("Cập nhật tiền khám cố định thất bại.");
            }
        }
        //quy dinh so luong
        public void updateQuyDinhSoLuongBenhNhanToiDaTrongNgay(bool quyDinhSoLuongBenhNhanToiDaTrongNgay)
        {
            if (dalThamSo.CapNhatQuyDinhSoLuongBenhNhan(quyDinhSoLuongBenhNhanToiDaTrongNgay))
            {

            }
            else
            {
                MessageBox.Show("Cập nhật quy định số lượng bệnh nhân tối đa trong ngày thất bại.");
            }
        }
        //quy dinh tien kham
        public void updateQuyDinhTienKhamCoDinh(bool quyDinhTienKhamCoDinh)
        {
            if (dalThamSo.CapNhatQuyDinhTienKham(quyDinhTienKhamCoDinh))
            {
                
            }
            else
            {
                MessageBox.Show("Cập nhật quy định tiền khám cố định thất bại.");
            }
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
