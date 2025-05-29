using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnSE104.GUI
{
    public partial class GUI_Home : Form
    {
        public GUI_Home()
        {
            InitializeComponent();
        }

        private void BtnMedicalExamination_Click(object sender, EventArgs e)
        {
            GUI_TiepNhanBenhNhan gui_TiepNhanBenhNhan = new GUI_TiepNhanBenhNhan();
            gui_TiepNhanBenhNhan.Show();
        }

        private void BtnCreateMedicalExamination_Click(object sender, EventArgs e)
        {
            GUI_LapPhieuKhamBenh gui_LapPhieuKhamBenh = new GUI_LapPhieuKhamBenh();
            gui_LapPhieuKhamBenh.Show();
        }

        private void BtnInvoicePayment_Click(object sender, EventArgs e)
        {
            GUI_LapHoaDon gui_LapHoaDon = new GUI_LapHoaDon();
            gui_LapHoaDon.Show();
        }
    }
}
