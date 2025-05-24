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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maKhamBenh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void pictureBoxToggleCalendar_Click(object sender, EventArgs e)
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

        private void pictureBoxToggleCalendar_Click_1(object sender, EventArgs e)
        {
            if (!monthCalendar1.Visible)
            {
                var x = pictureBoxToggleCalendar.Left;
                var y = pictureBoxToggleCalendar.Bottom + 2;
                monthCalendar1.Location = new Point(x, y);
            }

            monthCalendar1.Visible = !monthCalendar1.Visible;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
