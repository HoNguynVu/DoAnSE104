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
    public partial class GUI_TiepNhanKhamBenh: Form
    {
        public GUI_TiepNhanKhamBenh()
        {
            InitializeComponent();
                        
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

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Visible = false;
        }
    }
}
