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
            Application.Run(new GUI_LapBaoCaoSuDungThuoc());
        }
    }
}
