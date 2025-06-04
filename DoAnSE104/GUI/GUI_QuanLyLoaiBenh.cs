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
            MessageBox.Show($"Đã thêm đơn vị thành công! Mã đơn vị: {ma}",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTenLoaiBenh.Clear();
            txtMaLoaiBenh.Text = busLoaiBenh.NextMaLoaiBenh(dtLoaiBenh); // Generate new ID
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
            if (e.RowIndex >= 0 && dgvDanhSachLoaiBenh.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                try
                {
                    string maLoaiBenh = dgvDanhSachLoaiBenh.Rows[e.RowIndex].Cells["MaLoaiBenh"].Value?.ToString();

                    // Kiểm tra xem loại bệnh có trong danh sách mới không (chưa lưu vào DB)
                    var loaiBenhMoi = dtLoaiBenh.FirstOrDefault(lb => lb.maLoaiBenh == maLoaiBenh &&
                                                                       !dtLoaiBenhGoc.Any(goc => goc.maLoaiBenh == lb.maLoaiBenh));
                    if (loaiBenhMoi != null)
                    {
                        dtLoaiBenh.Remove(loaiBenhMoi);
                        ReloadDataGridView();
                        MessageBox.Show("Đã xóa loại bệnh khỏi danh sách mới!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Kiểm tra xem loại bệnh đã được sử dụng chưa
                        bool isUsed = busLoaiBenh.KiemTraLoaiBenhDangDuocSuDung(maLoaiBenh);
                        if (isUsed)
                        {
                            MessageBox.Show("Không thể xóa loại bệnh này vì đang được sử dụng trong hồ sơ bệnh nhân!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var confirm = MessageBox.Show("Bạn có chắc muốn xóa loại bệnh này khỏi cơ sở dữ liệu?",
                            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirm == DialogResult.Yes)
                        {
                            if (busLoaiBenh.XoaLoaiBenh(maLoaiBenh))
                            {
                                dtLoaiBenh.RemoveAll(lb => lb.maLoaiBenh == maLoaiBenh);
                                dtLoaiBenhGoc.RemoveAll(lb => lb.maLoaiBenh == maLoaiBenh);
                                ReloadDataGridView();
                                MessageBox.Show("Đã xóa loại bệnh khỏi cơ sở dữ liệu!",
                                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Xóa loại bệnh không thành công!",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa loại bệnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // THÊM mới: có trong dtLoaiBenh nhưng không có trong dtLoaiBenhGoc
                var danhSachThem = dtLoaiBenh
                .Where(lb =>
                !dtLoaiBenhGoc.Any(goc => goc.maLoaiBenh == lb.maLoaiBenh) // chưa có trong DB
                && !string.IsNullOrWhiteSpace(lb.tenLoaiBenh)) // vẫn còn trong danh sách hiện tại
                .ToList();


                if (danhSachThem.Count > 0)
                {
                    foreach (var lb in danhSachThem)
                    {
                        busLoaiBenh.ThemLoaiBenh(lb);
                    }
                    MessageBox.Show("Lưu thành công vào cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu mới để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }





              

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
    }
}
