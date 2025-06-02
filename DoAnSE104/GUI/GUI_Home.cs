using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnSE104.GUI
{
    public partial class GUI_Home : Form
    {
        // Trong GUI_TiepNhanBenhNhan.cs
        private GUI_Home homeForm;
        public GUI_Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;
        }
        public void ShowFormInMainPanel(Form form)
        {
            panelMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }
        // Trong GUI_Home.cs
        private void btnTiepNhanBenhNhan_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_TiepNhanBenhNhan(this));
        }
        private void btnTiepNhanKhamBenh_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_TiepNhanKhamBenh(this));
        }
        private void btnLapPhieuKhamBenh_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_LapPhieuKhamBenh(this));
        }
        private void btnTraCuuBenhNhan_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_TraCuuBenhNhan());
        }
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_LapHoaDon());
        }
        private void btnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_LapBaoCaoDoanhThu());
        }
        private void btnBaoCaoSuDungThuoc_Click(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_LapBaoCaoSuDungThuoc());
        }
        private void bthSearch_Click(object sender, EventArgs e)
        {
            homeForm.Invoke(new Action(() =>
            {
                homeForm.GetType()
                    .GetMethod("ShowFormInMainPanel", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .Invoke(homeForm, new object[] { new GUI_TraCuuBenhNhan() });
            }));
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            homeForm.Invoke(new Action(() =>
            {
                homeForm.GetType()
                    .GetMethod("ShowFormInMainPanel", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .Invoke(homeForm, new object[] { new GUI_TiepNhanBenhNhan() });
            }));
        }

        private void btnTimBenhNhan_Click(object sender, EventArgs e)
        {
            homeForm.Invoke(new Action(() =>
            {
                homeForm.GetType()
                    .GetMethod("ShowFormInMainPanel", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .Invoke(homeForm, new object[] { new GUI_LapPhieuKhamBenh() });
            }));
        }

        private void btnTiepNhanKhamBenh_Click_1(object sender, EventArgs e)
        {
            ShowFormInMainPanel(new GUI_TiepNhanKhamBenh());
        }
    }  
}
