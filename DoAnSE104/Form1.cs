using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnSE104
{
    public partial class FrmTiepNhanBenhNhan: Form
    {
        public FrmTiepNhanBenhNhan()
        {
            InitializeComponent();
            // Đổi màu nền form
            this.BackColor = Color.WhiteSmoke;
            // Đổi font chữ toàn form
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            // Làm đẹp các button nếu có
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                // Làm đẹp các textbox
                if (ctrl is TextBox tb)
                {
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    tb.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                }
                // Làm đẹp các label
                if (ctrl is Label lb)
                {
                    lb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    lb.ForeColor = Color.DimGray;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Khi chọn ngày trên lịch, cập nhật giá trị vào textBox3 (ngày khám)
            txtNgayKham.Text = e.Start.ToString("dd/MM/yyyy");
        }

        private void pictureBoxToggleCalendar_Click_1(object sender, EventArgs e)
        {
            monthCalendar1.Visible = !monthCalendar1.Visible;

            if (monthCalendar1.Visible)
            {
                pictureBoxToggleCalendar.Image = Properties.Resources.calendar;
            }
            else
            {
                pictureBoxToggleCalendar.Image = Properties.Resources.calendar;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
