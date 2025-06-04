using DoAnSE104.BUS;
using DoAnSE104.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DoAnSE104.GUI
{
    public partial class GUI_QuanLyDonViTinh : Form
    {
        private List<DTO_DonVi> danhSachDonVi = new List<DTO_DonVi>();
        private List<DTO_DonVi> danhSachTam = new List<DTO_DonVi>();
        BUS_DonVi BUS_DonVi = new BUS_DonVi();

        private int hoverRowIndex = -1;
        private int hoverColIndex = -1;

        public GUI_QuanLyDonViTinh()
        {
            InitializeComponent();
            SetupDataGridView();

            dgvDanhSachDonVi.CellPainting += dgvDanhSachDonVi_CellPainting;
            dgvDanhSachDonVi.CellMouseMove += dgvDanhSachDonVi_CellMouseMove;
            dgvDanhSachDonVi.CellMouseLeave += dgvDanhSachDonVi_CellMouseLeave;
        }

        private void SetupDataGridView()
        {
            dgvDanhSachDonVi.AllowUserToAddRows = false; // tắt không muốn dòng mới do user thêm trực tiếp
            dgvDanhSachDonVi.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvDanhSachDonVi.AutoGenerateColumns = false; // Tắt tự động tạo cột

            // Xóa cột cũ nếu có
            dgvDanhSachDonVi.Columns.Clear();

            // Tạo cột STT
            DataGridViewTextBoxColumn colSTT = new DataGridViewTextBoxColumn();
            colSTT.Name = "STT";
            colSTT.HeaderText = "STT";
            colSTT.Width = 50;
            colSTT.ReadOnly = true;
            dgvDanhSachDonVi.Columns.Add(colSTT);

            // Tạo cột MaDonVi
            DataGridViewTextBoxColumn colMaDonVi = new DataGridViewTextBoxColumn();
            colMaDonVi.Name = "MaDonVi";
            colMaDonVi.HeaderText = "MÃ ĐƠN VỊ";
            colMaDonVi.DataPropertyName = "MaDonVi"; // tên thuộc tính trong DTO_DonVi
            colMaDonVi.Width = 150;
            dgvDanhSachDonVi.Columns.Add(colMaDonVi);

            // Tạo cột TenDonVi
            DataGridViewTextBoxColumn colTenDonVi = new DataGridViewTextBoxColumn();
            colTenDonVi.Name = "TenDonVi";
            colTenDonVi.HeaderText = "TÊN ĐƯƠN VỊ";
            colTenDonVi.DataPropertyName = "TenDonVi"; // tên thuộc tính trong DTO_DonVi
            colTenDonVi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDanhSachDonVi.Columns.Add(colTenDonVi);

            // thêm cột ThaoTac (nút xóa)
            if (!dgvDanhSachDonVi.Columns.Contains("ThaoTac"))
            {
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                btnXoa.Name = "ThaoTac";
                btnXoa.HeaderText = "THAO TÁC";
                btnXoa.Text = "Xóa";
                btnXoa.UseColumnTextForButtonValue = true;
                btnXoa.Width = 70;
                dgvDanhSachDonVi.Columns.Add(btnXoa);
            }

            // đánh số STT
            dgvDanhSachDonVi.RowPrePaint += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachDonVi.Rows.Count)
                {
                    if (dgvDanhSachDonVi.Rows[e.RowIndex].Cells["STT"] != null)
                    {
                        dgvDanhSachDonVi.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
                    }
                }
            };
        }

        // Sự kiện khi chuột di chuyển trên cell
        private void dgvDanhSachDonVi_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachDonVi.Columns[e.ColumnIndex].Name == "ThaoTac")
            {
                if (hoverRowIndex != e.RowIndex || hoverColIndex != e.ColumnIndex)
                {
                    hoverRowIndex = e.RowIndex;
                    hoverColIndex = e.ColumnIndex;
                    dgvDanhSachDonVi.InvalidateCell(e.ColumnIndex, e.RowIndex);
                }
            }
            else if (hoverRowIndex != -1 || hoverColIndex != -1)
            {
                int oldRow = hoverRowIndex, oldCol = hoverColIndex;
                hoverRowIndex = -1;
                hoverColIndex = -1;
                dgvDanhSachDonVi.InvalidateCell(oldCol, oldRow);
            }
        }

        // Sự kiện khi chuột rời khỏi DataGridView
        private void dgvDanhSachDonVi_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (hoverRowIndex != -1 || hoverColIndex != -1)
            {
                int oldRow = hoverRowIndex, oldCol = hoverColIndex;
                hoverRowIndex = -1;
                hoverColIndex = -1;
                dgvDanhSachDonVi.InvalidateCell(oldCol, oldRow);
            }
        }

        // Hàm xử lý vẽ lại nút Xóa với màu nền giống nút Thoát
        private void dgvDanhSachDonVi_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDanhSachDonVi.Columns[e.ColumnIndex].Name == "ThaoTac" && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);

                Color backColor = (e.RowIndex == hoverRowIndex && e.ColumnIndex == hoverColIndex)
                    ? Color.FromArgb(211, 47, 47) // Màu hover (đỏ đậm hơn)
                    : Color.FromArgb(244, 67, 54); // Màu mặc định

                using (SolidBrush brush = new SolidBrush(backColor))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }

                using (Pen pen = new Pen(dgvDanhSachDonVi.GridColor))
                {
                    e.Graphics.DrawRectangle(pen, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    "Xóa",
                    dgvDanhSachDonVi.Font,
                    e.CellBounds,
                    Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                e.Handled = true;
            }
        }

        private void TaiLai()
        {
            danhSachDonVi = BUS_DonVi.LayDanhSachDonVi();
            dgvDanhSachDonVi.DataSource = danhSachDonVi;
            dgvDanhSachDonVi.ClearSelection();

            txtMaDonVi.Text = BUS_DonVi.TaoMaDonViMoi(danhSachTam);
            txtMaDonVi.Enabled = false; // Không cho phép sửa mã đơn vị
            txtTenDonVi.Clear();
        }

        private void GUI_QuanLyDonViTinh_Load_1(object sender, EventArgs e)
        {
            TaiLai();
        }

        private void btnThemDonVi_Click_1(object sender, EventArgs e)
        {
            try
            {
                string maDonViMoi = BUS_DonVi.TaoMaDonViMoi(danhSachTam);
                string tenDonVi = txtTenDonVi.Text.Trim();

                if (string.IsNullOrWhiteSpace(tenDonVi))
                {
                    MessageBox.Show("Vui lòng nhập tên đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(tenDonVi, @"^[\p{L}\s]+$"))
                {
                    MessageBox.Show("Tên đơn vị chỉ được chứa chữ cái và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra trùng tên
                if (danhSachTam.Any(d => d.tenDonVi.Equals(tenDonVi, StringComparison.OrdinalIgnoreCase)) ||
                    danhSachDonVi.Any(d => d.tenDonVi.Equals(tenDonVi, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Tên đơn vị đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTO_DonVi donViMoi = new DTO_DonVi(maDonViMoi, tenDonVi);
                danhSachTam.Add(donViMoi);

                // Gộp lại để hiển thị: đơn vị từ DB + mới thêm
                var danhSachHienThi = danhSachDonVi.Concat(danhSachTam).ToList();
                dgvDanhSachDonVi.DataSource = null;
                dgvDanhSachDonVi.DataSource = danhSachHienThi;
                dgvDanhSachDonVi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                txtTenDonVi.Clear();
                txtMaDonVi.Text = BUS_DonVi.TaoMaDonViMoi(danhSachTam);

                MessageBox.Show($"Đã thêm đơn vị thành công! Mã đơn vị: {maDonViMoi}",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm đơn vị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            int thanhCong = 0;

            // Lưu các đơn vị mới
            foreach (DTO_DonVi donVi in danhSachTam)
            {
                if (BUS_DonVi.Them(donVi))
                {
                    thanhCong++;
                }
            }

            // Xóa các đơn vị đã được chọn xóa
           

            if (thanhCong > 0)
            {
                MessageBox.Show($"Đã lưu {thanhCong} đơn vị mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có thay đổi nào được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Clear danh sách tạm và load lại
            danhSachTam.Clear();
            TaiLai();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhSachDonVi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDanhSachDonVi.Columns["ThaoTac"].Index && e.RowIndex >= 0)
            {
                try
                {
                    string maDonVi = dgvDanhSachDonVi.Rows[e.RowIndex].Cells["MaDonVi"].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(maDonVi))
                    {
                        MessageBox.Show("Không thể xác định mã đơn vị để xóa.",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var donViMoi = danhSachTam.FirstOrDefault(d => d.maDonVi == maDonVi);
                    if (donViMoi != null)
                    {
                        danhSachTam.Remove(donViMoi);

                        // Gộp lại để hiển thị
                        var danhSachHienThi = danhSachDonVi.Concat(danhSachTam).ToList();
                        dgvDanhSachDonVi.DataSource = null;
                        dgvDanhSachDonVi.DataSource = danhSachHienThi;

                        MessageBox.Show("Đã xóa đơn vị khỏi danh sách mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bool isUsed = BUS_DonVi.KiemTraDonViDangDuocSuDung(maDonVi);
                        if (isUsed)
                        {
                            MessageBox.Show("Không thể xóa đơn vị này vì đang được sử dụng!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var result = MessageBox.Show(
                            $"Bạn có chắc muốn xóa đơn vị có mã {maDonVi} khỏi cơ sở dữ liệu?",
                            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (BUS_DonVi.Xoa(maDonVi))
                            {
                                danhSachDonVi = BUS_DonVi.LayDanhSachDonVi();
                                var danhSachHienThi = danhSachDonVi.Concat(danhSachTam).ToList();
                                dgvDanhSachDonVi.DataSource = null;
                                dgvDanhSachDonVi.DataSource = danhSachHienThi;

                                MessageBox.Show("Đã xóa đơn vị khỏi cơ sở dữ liệu!",
                                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa đơn vị này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa đơn vị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





    }
}
