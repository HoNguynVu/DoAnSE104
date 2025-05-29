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

        private void ShowControlInMainPanel(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void ShowFormInMainPanel(Form form)
        {
            panelMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void btnTiepNhanBenhNhan_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_TiepNhanBenhNhan());
        }
        private void btnTiepNhanKhamBenh_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_TiepNhanKhamBenh());
        }

        private void btnLapPhieuKhamBenh_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_LapPhieuKhamBenh());
        }

        private void btnTraCuuBenhNhan_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_TraCuuBenhNhan());
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_LapHoaDon());
        }

    }
}
