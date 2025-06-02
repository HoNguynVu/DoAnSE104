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
        private BUS_LoaiBenh busLoaiBenh = new BUS_LoaiBenh();
        private int hoverRowIndex = -1;
        private int hoverColIndex = -1;

        public GUI_QuanLyLoaiBenh()
        {
            InitializeComponent();
            LoadDataToDataGridView();

            dgvDanhSachLoaiBenh.CellPainting += dataGridView1_CellPainting;
            dgvDanhSachLoaiBenh.CellMouseMove += dgvDanhSachLoaiBenh_CellMouseMove;
            dgvDanhSachLoaiBenh.CellMouseLeave += dgvDanhSachLoaiBenh_CellMouseLeave;
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                dtLoaiBenhGoc = busLoaiBenh.LayDanhSachLoaiBenh();
                dtLoaiBenh = new List<DTO_LoaiBenh>(dtLoaiBenhGoc); // clone danh sách

                // Always clear and add columns
                dgvDanhSachLoaiBenh.Columns.Clear();
                if (dgvDanhSachLoaiBenh.Columns.Count == 0)
                {
                    dgvDanhSachLoaiBenh.Columns.Add("MaLoaiBenh", "Mã Loại Bệnh");
                    dgvDanhSachLoaiBenh.Columns.Add("TenLoaiBenh", "Tên Loại Bệnh");
                }

                // Add the button column
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                btnXoa.HeaderText = "Xóa";
                btnXoa.Text = "Xóa";
                btnXoa.Name = "btnXoa";
                btnXoa.UseColumnTextForButtonValue = true;
                btnXoa.DefaultCellStyle.BackColor = Color.Red;
                btnXoa.DefaultCellStyle.ForeColor = Color.White;
                dgvDanhSachLoaiBenh.Columns.Add(btnXoa);

                // Populate rows
                dgvDanhSachLoaiBenh.Rows.Clear();
                foreach (DTO_LoaiBenh lb in dtLoaiBenhGoc)
                {
                    dgvDanhSachLoaiBenh.Rows.Add(
                        lb.maLoaiBenh,
                        lb.tenLoaiBenh
                    );
                }
                int rowHeight = dgvDanhSachLoaiBenh.RowTemplate.Height;
                int headerHeight = dgvDanhSachLoaiBenh.ColumnHeadersHeight;
                int totalRowsHeight = (dgvDanhSachLoaiBenh.Rows.Count * rowHeight) + headerHeight;

                // Set a maximum height to prevent excessive growth
                int maxHeight = 200; // Adjust as needed
                dgvDanhSachLoaiBenh.Height = Math.Min(totalRowsHeight, maxHeight);
                dgvDanhSachLoaiBenh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDanhSachLoaiBenh.AllowUserToAddRows = false;
                dgvDanhSachLoaiBenh.ReadOnly = true;
                dgvDanhSachLoaiBenh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GUI_QuanLyLoaiBenh_Load(object sender, EventArgs e)
        {
            string newMa = busLoaiBenh.NextMaLoaiBenh();
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
            txtMaLoaiBenh.Text = busLoaiBenh.NextMaLoaiBenh(); // Generate new ID
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
            var btnXoaColumn = dgvDanhSachLoaiBenh.Columns["btnXoa"];
            if (btnXoaColumn != null && e.ColumnIndex == btnXoaColumn.Index && e.RowIndex >= 0)
            {
                try
                {
                    string ma = dgvDanhSachLoaiBenh.Rows[e.RowIndex].Cells["MaLoaiBenh"].Value?.ToString();
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
                    busLoaiBenh.ThemLoaiBenh(lb);
                }

                // Thực hiện xóa
                foreach (var lb in danhSachXoa)
                {
                    busLoaiBenh.XoaLoaiBenh(lb.maLoaiBenh);
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
                if (!dgvDanhSachLoaiBenh.Columns.Contains("btnXoa"))
                {
                    dgvDanhSachLoaiBenh.Columns.Clear();
                    dgvDanhSachLoaiBenh.Columns.Add("MaLoaiBenh", "Mã Loại Bệnh");
                    dgvDanhSachLoaiBenh.Columns.Add("TenLoaiBenh", "Tên Loại Bệnh");

                    DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                    btnXoa.HeaderText = "Xóa";
                    btnXoa.Text = "Xóa";
                    btnXoa.Name = "btnXoa";
                    btnXoa.UseColumnTextForButtonValue = true;
                    dgvDanhSachLoaiBenh.Columns.Add(btnXoa);
                }

                dgvDanhSachLoaiBenh.Rows.Clear();
                foreach (DTO_LoaiBenh lb in dtLoaiBenh)
                {
                    dgvDanhSachLoaiBenh.Rows.Add(
                        lb.maLoaiBenh,
                        lb.tenLoaiBenh);
                }
                int rowHeight = dgvDanhSachLoaiBenh.RowTemplate.Height;
                int headerHeight = dgvDanhSachLoaiBenh.ColumnHeadersHeight;
                int totalRowsHeight = (dgvDanhSachLoaiBenh.Rows.Count * rowHeight) + headerHeight;

                // Set a maximum height to prevent excessive growth
                int maxHeight = 200; // Adjust as needed
                dgvDanhSachLoaiBenh.Height = Math.Min(totalRowsHeight, maxHeight);

                dgvDanhSachLoaiBenh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDanhSachLoaiBenh.AllowUserToAddRows = false;
                dgvDanhSachLoaiBenh.ReadOnly = true;
                dgvDanhSachLoaiBenh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải lại dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSachLoaiBenh_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachLoaiBenh.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                if (hoverRowIndex != e.RowIndex || hoverColIndex != e.ColumnIndex)
                {
                    hoverRowIndex = e.RowIndex;
                    hoverColIndex = e.ColumnIndex;
                    dgvDanhSachLoaiBenh.InvalidateCell(e.ColumnIndex, e.RowIndex);
                }
            }
            else if (hoverRowIndex != -1 || hoverColIndex != -1)
            {
                int oldRow = hoverRowIndex, oldCol = hoverColIndex;
                hoverRowIndex = -1;
                hoverColIndex = -1;
                dgvDanhSachLoaiBenh.InvalidateCell(oldCol, oldRow);
            }
        }

        private void dgvDanhSachLoaiBenh_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (hoverRowIndex != -1 || hoverColIndex != -1)
            {
                int oldRow = hoverRowIndex, oldCol = hoverColIndex;
                hoverRowIndex = -1;
                hoverColIndex = -1;
                dgvDanhSachLoaiBenh.InvalidateCell(oldCol, oldRow);
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvDanhSachLoaiBenh.Columns[e.ColumnIndex].Name == "btnXoa")
                {
                    e.PaintBackground(e.ClipBounds, true);

                    Color backColor = (e.RowIndex == hoverRowIndex && e.ColumnIndex == hoverColIndex)
                        ? Color.FromArgb(211, 47, 47) // Màu hover (đỏ đậm hơn)
                        : Color.FromArgb(244, 67, 54); // Màu mặc định giống nút Thoát

                    using (Brush backColorBrush = new SolidBrush(backColor))
                    {
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                    }

                    // Vẽ viền nếu muốn
                    using (Pen pen = new Pen(dgvDanhSachLoaiBenh.GridColor))
                    {
                        e.Graphics.DrawRectangle(pen, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
                    }

                    TextRenderer.DrawText(e.Graphics, "Xóa", dgvDanhSachLoaiBenh.Font, e.CellBounds, Color.White,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi vẽ ô: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimPhieuKham_Click(object sender, EventArgs e)
        {

        }
    }
}
