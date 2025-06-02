using System;
using System.Windows.Forms;
using DoAnSE104.GUI;

namespace DoAnSE104
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GUI_QuanLyDonViTinh());
            //Application.Run(new GUI_QuanLyCachDung());
            Application.Run(new GUI_QuanLyLoaiBenh());
            //Application.Run(new GUI_QuanLyLoaiThuoc());

        }
    }
}
