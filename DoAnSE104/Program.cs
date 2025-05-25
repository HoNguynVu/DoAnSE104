using System;
using System.Windows.Forms;

namespace DoAnSE104
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI.GUI_TiepNhanBenhNhan());
        }
    }
}
