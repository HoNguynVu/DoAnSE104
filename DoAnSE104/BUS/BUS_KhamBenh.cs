using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnSE104.DTO;
using DoAnSE104.DAL;

namespace DoAnSE104.BUS
{
    public class BUS_KhamBenh
    {
        DAL_KhamBenh DAL_KhamBenh = new DAL_KhamBenh();
        public List<DTO_KhamBenh> LayDanhSachKhamBenh()
        {
            return DAL_KhamBenh.LayDanhSachKhamBenh();
        }
        public bool ThemKhamBenh(DTO_KhamBenh newKhamBenh)
        {
            if (string.IsNullOrWhiteSpace(newKhamBenh.maBenhNhan))
                throw new Exception("Mã bệnh nhân không được để trống.");
            return DAL_KhamBenh.ThemKhamBenh(newKhamBenh);
        }
        public string LayMaKhamBenhMoi()
        {
            return DAL_KhamBenh.LayMaKhamBenhMoi();
        }
    }
}
