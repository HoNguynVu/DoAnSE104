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
    public partial class GUI_QuanLyLoaiBenh : Form
    {
        public GUI_QuanLyLoaiBenh()
        {
            InitializeComponent();
            
        }

        private void GUI_QuanLyLoaiBenh_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "THAO TÁC";
            btnColumn.Text = "Xóa";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnColumn);
        }

    }
}
