﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnSE104.DTO
{
    public class DTO_ThamSo
    {
        private int SoLuongBenhNhanToiDaTrongNgay;
        private bool QuyDinhSoLuongBenhNhanToiDaTrongNgay;
        private double TienKhamCoDinh;
        private bool QuyDinhTienKhamCoDinh;
        public int soLuongBenhNhanToiDaTrongNgay { get => SoLuongBenhNhanToiDaTrongNgay; set => SoLuongBenhNhanToiDaTrongNgay = value; }
        public bool quyDinhSoLuongBenhNhanToiDaTrongNgay { get => QuyDinhSoLuongBenhNhanToiDaTrongNgay; set => QuyDinhSoLuongBenhNhanToiDaTrongNgay = value; }
        public double tienKhamCoDinh { get => TienKhamCoDinh; set => TienKhamCoDinh = value; }
        public bool quyDinhTienKhamCoDinh { get => QuyDinhTienKhamCoDinh; set => QuyDinhTienKhamCoDinh = value; }
        public DTO_ThamSo(int soLuongBenhNhanToiDaTrongNgay, bool quyDinhSoLuongBenhNhanToiDaTrongNgay, double tienKhamCoDinh, bool quyDinhTienKhamCoDinh)
        {
            this.SoLuongBenhNhanToiDaTrongNgay = soLuongBenhNhanToiDaTrongNgay;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay = quyDinhSoLuongBenhNhanToiDaTrongNgay;
            this.tienKhamCoDinh = tienKhamCoDinh;
            this.quyDinhTienKhamCoDinh = quyDinhTienKhamCoDinh;
        }

    }
}
