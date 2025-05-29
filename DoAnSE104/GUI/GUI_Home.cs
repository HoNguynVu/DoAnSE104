using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnSE104.GUI
{
    public partial class GUI_Home : Form
    {
        public GUI_Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;
        }

        private void BtnMedicalExamination_Click(object sender, EventArgs e)
        {
            GUI_TiepNhanBenhNhan gui_TiepNhanBenhNhan = new GUI_TiepNhanBenhNhan();
            gui_TiepNhanBenhNhan.ShowDialog();
        }

        private void BtnCreateMedicalExamination_Click(object sender, EventArgs e)
        {
            GUI_LapPhieuKhamBenh gui_LapPhieuKhamBenh = new GUI_LapPhieuKhamBenh();
            gui_LapPhieuKhamBenh.ShowDialog();
        }

        private void BtnPatientLookup_Click(object sender, EventArgs e)
        {
            GUI_TraCuuBenhNhan gui_TraCuuBenhNhan = new GUI_TraCuuBenhNhan();
            gui_TraCuuBenhNhan.ShowDialog();
        }

        private void BtnInvoicePayment_Click(object sender, EventArgs e)
        {
            GUI_LapHoaDon gui_LapHoaDon = new GUI_LapHoaDon();
            gui_LapHoaDon.ShowDialog();
        }
    }
}
