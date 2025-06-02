using DoAnSE104.BUS;
using DoAnSE104.DAL;
using DoAnSE104.DTO;
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
        private List<DTO_LoaiBenh> dtLoaiBenh = new List<DTO_LoaiBenh>();
        private List<DTO_LoaiBenh> dtLoaiBenhGoc = new List<DTO_LoaiBenh>();
        private DAL_LoaiBenh dalLoaiBenh = new DAL.DAL_LoaiBenh();
        public GUI_QuanLyLoaiBenh()
        {
            InitializeComponent();
            LoadDataToDataGridView();
            //dataGridView1.CellPainting += dataGridView1_CellPainting;

        }
        private void LoadDataToDataGridView()
        {
            try
            {
                dtLoaiBenhGoc = dalLoaiBenh.LayDanhSachLoaiBenh();
                dtLoaiBenh = new List<DTO_LoaiBenh>(dtLoaiBenhGoc); // clone danh sách

                // Always clear and add columns
                dataGridView1.Columns.Clear();
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("MaLoaiBenh", "Mã Loại Bệnh");
                    dataGridView1.Columns.Add("TenLoaiBenh", "Tên Loại Bệnh");
                }

                // Add the button column
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                btnXoa.HeaderText = "Xóa";
                btnXoa.Text = "Xóa";
                btnXoa.Name = "btnXoa";
                btnXoa.UseColumnTextForButtonValue = true;
                btnXoa.DefaultCellStyle.BackColor = Color.Red;
                btnXoa.DefaultCellStyle.ForeColor = Color.White;
                dataGridView1.Columns.Add(btnXoa);

                // Populate rows
                dataGridView1.Rows.Clear();
                foreach (DTO_LoaiBenh lb in dtLoaiBenhGoc)
                {
                    dataGridView1.Rows.Add(
                        //dataGridView1.Rows.Count + 1,
                        lb.maLoaiBenh,
                        lb.tenLoaiBenh
                    );
                }
                int rowHeight = dataGridView1.RowTemplate.Height;
                int headerHeight = dataGridView1.ColumnHeadersHeight;
                int totalRowsHeight = (dataGridView1.Rows.Count * rowHeight) + headerHeight;

                // Set a maximum height to prevent excessive growth
                int maxHeight = 200; // Adjust as needed
                dataGridView1.Height = Math.Min(totalRowsHeight, maxHeight);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GUI_QuanLyLoaiBenh_Load(object sender, EventArgs e)
        {
            string newMa = dalLoaiBenh.GetNextMaLoaiBenh();
            txtMaLoaiBenh.Text = newMa;
            txtMaLoaiBenh.Enabled = false;
        }

        private void btnNewLoaiBenh_Click(object sender, EventArgs e)
        {
            string ma = txtMaLoaiBenh.Text.Trim();
            string ten = txtTenLoaiBenh.Text.Trim();

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên loại bệnh!");
                return;
            }

            DTO_LoaiBenh loaiBenh = new DTO_LoaiBenh(ma, ten);
            dtLoaiBenh.Add(loaiBenh); // Add to the list only
            MessageBox.Show("Thêm loại bệnh thành công!");
            txtTenLoaiBenh.Clear();
            txtMaLoaiBenh.Text = dalLoaiBenh.GetNextMaLoaiBenh(); // Generate new ID
            ReloadDataGridView(); // Refresh the DataGridView
        }

        private void txtTenLoaiBenh_TextChanged(object sender, EventArgs e)
        {
            txtTenLoaiBenh.Text = txtTenLoaiBenh.Text.Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var btnXoaColumn = dataGridView1.Columns["btnXoa"];
            if (btnXoaColumn != null && e.ColumnIndex == btnXoaColumn.Index && e.RowIndex >= 0)
            {
                try
                {
                    string ma = dataGridView1.Rows[e.RowIndex].Cells["MaLoaiBenh"].Value?.ToString();
                    var confirm = MessageBox.Show($"Xóa loại bệnh có mã {ma}?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        dtLoaiBenh.RemoveAll(lb => lb.maLoaiBenh == ma); // Remove from the list only
                        ReloadDataGridView(); // Refresh the DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa loại thuốc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // THÊM mới: có trong dtLoaiBenh nhưng không có trong dtLoaiBenhGoc
                var danhSachThem = dtLoaiBenh
                    .Where(lb => !dtLoaiBenhGoc.Any(goc => goc.maLoaiBenh == lb.maLoaiBenh))
                    .ToList();

                // XÓA: có trong dtLoaiBenhGoc nhưng không còn trong dtLoaiBenh
                var danhSachXoa = dtLoaiBenhGoc
                    .Where(goc => !dtLoaiBenh.Any(lb => lb.maLoaiBenh == goc.maLoaiBenh))
                    .ToList();

                // Thực hiện thêm
                foreach (var lb in danhSachThem)
                {
                    dalLoaiBenh.ThemLoaiBenh(lb);
                }

                // Thực hiện xóa
                foreach (var lb in danhSachXoa)
                {
                    dalLoaiBenh.XoaLoaiBenh(lb.maLoaiBenh);
                }

                MessageBox.Show("Lưu thành công vào cơ sở dữ liệu!");

                // Cập nhật danh sách gốc để tránh trùng lần sau
                dtLoaiBenhGoc = new List<DTO_LoaiBenh>(dtLoaiBenh);
                ReloadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }
        private void ReloadDataGridView()
        {
            try
            {
                if (!dataGridView1.Columns.Contains("btnXoa"))
                {
                    dataGridView1.Columns.Clear();
                    //dataGridView1.Columns.Add("STT", "STT");
                    dataGridView1.Columns.Add("MaLoaiBenh", "Mã Loại Bệnh");
                    dataGridView1.Columns.Add("TenLoaiBenh", "Tên Loại Bệnh");

                    DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                    btnXoa.HeaderText = "Xóa";
                    btnXoa.Text = "Xóa";
                    btnXoa.Name = "btnXoa";
                    btnXoa.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btnXoa);
                }

                dataGridView1.Rows.Clear();
                foreach (DTO_LoaiBenh lb in dtLoaiBenh)
                {
                    dataGridView1.Rows.Add(
                        //dataGridView1.Rows.Count + 1,
                        lb.maLoaiBenh,
                        lb.tenLoaiBenh);
                }
                int rowHeight = dataGridView1.RowTemplate.Height;
                int headerHeight = dataGridView1.ColumnHeadersHeight;
                int totalRowsHeight = (dataGridView1.Rows.Count * rowHeight) + headerHeight;

                // Set a maximum height to prevent excessive growth
                int maxHeight = 200; // Adjust as needed
                dataGridView1.Height = Math.Min(totalRowsHeight, maxHeight);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải lại dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btnXoa")
                {
                    e.PaintBackground(e.ClipBounds, true);

                    // Check if the mouse is hovering over the cell
                    bool isHovered = dataGridView1.CurrentCell != null &&
                                     dataGridView1.CurrentCell.RowIndex == e.RowIndex &&
                                     dataGridView1.CurrentCell.ColumnIndex == e.ColumnIndex;

                    // Change background color based on hover state
                    Color backColor = isHovered ? Color.Orange : Color.Red;

                    using (Brush backColorBrush = new SolidBrush(backColor))
                    {
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                    }

                    // Draw the text in the cell
                    TextRenderer.DrawText(e.Graphics, "Xóa", dataGridView1.Font, e.CellBounds, Color.White,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi vẽ ô: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
