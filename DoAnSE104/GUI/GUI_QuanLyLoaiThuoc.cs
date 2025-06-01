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
    public partial class GUI_QuanLyLoaiThuoc : Form {
        private BUS_LoaiThuoc BUS_LoaiThuoc = new BUS_LoaiThuoc();
        private BUS_DonVi BUS_DonVi = new BUS_DonVi();
        private BUS_CachDung BUS_CachDung = new BUS_CachDung();
        private string tenLoaiThuoc = string.Empty;
        private string tenDonVi = string.Empty;
        private string tenCachDung = string.Empty;
        private string donGia = string.Empty;
        List<DTO_LoaiThuoc> danhSachLoaiThuoc;
        List<DTO_LoaiThuoc> danhSachLoaiThuocMoi = new List<DTO_LoaiThuoc>();

        public GUI_QuanLyLoaiThuoc() {
            InitializeComponent();
            dgvDanhSachLoaiThuoc.CellPainting += dgvDanhSachLoaiThuoc_CellPainting;
            LoadDataToGridView();
            LoadDataDonVi();
            LoadDataCachDung();
            
            // Thêm event handler cho CellClick
            dgvDanhSachLoaiThuoc.CellClick += dgvDanhSachLoaiThuoc_CellClick;
        }
        private void LoadDataDonVi() {
            try {
                List<DTO_DonVi> danhSachDonVi = BUS_DonVi.LayDanhSachDonVi();
                cbDonVi.Items.Clear();
                foreach (DTO_DonVi donVi in danhSachDonVi) {
                    cbDonVi.Items.Add(donVi.tenDonVi);
                }
            } catch (Exception ex) {
                MessageBox.Show($"Lỗi khi tải dữ liệu đơn vị: {ex.Message}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataCachDung() {
            try {
                List<DTO_CachDung> danhSachCachDung = BUS_CachDung.LayDanhSachCachDung();
                cbCachDung.Items.Clear();
                foreach (DTO_CachDung cachDung in danhSachCachDung) {
                    cbCachDung.Items.Add(cachDung.tenCachDung);
                }
            } catch (Exception ex) {
                MessageBox.Show($"Lỗi khi tải dữ liệu cách dùng: {ex.Message}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData() {
            if (dgvDanhSachLoaiThuoc.Columns.Count == 0) {
                dgvDanhSachLoaiThuoc.Columns.Add("STT", "STT");
                dgvDanhSachLoaiThuoc.Columns.Add("MaLoaiThuoc", "Mã loại thuốc");
                dgvDanhSachLoaiThuoc.Columns.Add("TenLoaiThuoc", "Tên loại thuốc");
                dgvDanhSachLoaiThuoc.Columns.Add("DonVi", "Đơn vị");
                dgvDanhSachLoaiThuoc.Columns.Add("CachDung", "Cách dùng");
                dgvDanhSachLoaiThuoc.Columns.Add("DonGia", "Đơn giá");

                // Thêm cột button xóa
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                btnXoa.HeaderText = "Xóa";
                btnXoa.Text = "Xóa";
                btnXoa.Name = "btnXoa";
                btnXoa.UseColumnTextForButtonValue = true;
                btnXoa.DefaultCellStyle.BackColor = Color.Red;
                btnXoa.DefaultCellStyle.ForeColor = Color.White;
                dgvDanhSachLoaiThuoc.Columns.Add(btnXoa);
            }

            dgvDanhSachLoaiThuoc.Rows.Clear();
            int stt = 0;
            foreach (DTO_LoaiThuoc loaiThuoc in danhSachLoaiThuoc) {
                string tenDonVi = BUS_LoaiThuoc.LayTenDonVi(loaiThuoc.maDonVi);
                string cachDung = BUS_LoaiThuoc.LayTenCachDung(loaiThuoc.maCachDung);

                dgvDanhSachLoaiThuoc.Rows.Add(
                    ++stt,
                    loaiThuoc.maLoaiThuoc,
                    loaiThuoc.tenLoaiThuoc,
                    tenDonVi,
                    cachDung,
                    loaiThuoc.donGia.ToString("N0")
                );
            }

            dgvDanhSachLoaiThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachLoaiThuoc.AllowUserToAddRows = false;
            dgvDanhSachLoaiThuoc.ReadOnly = true;
            dgvDanhSachLoaiThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadDataToGridView() {
            try {
                danhSachLoaiThuoc = BUS_LoaiThuoc.LayDanhSachLoaiThuoc();
                LoadData();

            }
            catch (Exception ex) {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSachLoaiThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào cột button Xóa
            if (e.ColumnIndex == dgvDanhSachLoaiThuoc.Columns["btnXoa"].Index && e.RowIndex >= 0)
            {
                try
                {
                    string maLoaiThuoc = dgvDanhSachLoaiThuoc.Rows[e.RowIndex].Cells["maLoaiThuocItem"].Value.ToString();

                    // Kiểm tra xem loại thuốc có trong danh sách mới không
                    var thuocMoi = danhSachLoaiThuocMoi.FirstOrDefault(t => t.maLoaiThuoc == maLoaiThuoc);

                    if (thuocMoi != null)
                    {
                        // Nếu là thuốc mới chưa lưu - xóa trực tiếp 
                        danhSachLoaiThuocMoi.Remove(thuocMoi);
                        danhSachLoaiThuoc.RemoveAll(t => t.maLoaiThuoc == maLoaiThuoc);
                        ReloadDataToGridView();
                        MessageBox.Show("Đã xóa loại thuốc khỏi danh sách mới!", 
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Kiểm tra xem loại thuốc đã được sử dụng chưa
                        if (BUS_LoaiThuoc.KiemTraLoaiThuocDangDuocSuDung(maLoaiThuoc))
                        {
                            MessageBox.Show("Không thể xóa loại thuốc này vì đang được sử dụng trong đơn thuốc!", 
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Nếu chưa được sử dụng, hỏi xác nhận xóa
                        var result = MessageBox.Show(
                            "Bạn có chắc muốn xóa loại thuốc này khỏi cơ sở dữ liệu?",
                            "Xác nhận xóa",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes)
                        {
                            if (BUS_LoaiThuoc.XoaLoaiThuoc(maLoaiThuoc))
                            {
                                danhSachLoaiThuoc.RemoveAll(t => t.maLoaiThuoc == maLoaiThuoc);
                                ReloadDataToGridView();
                                MessageBox.Show("Đã xóa loại thuốc khỏi cơ sở dữ liệu!", 
                                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa loại thuốc này!", 
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa loại thuốc: {ex.Message}", 
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTenLoaiThuoc_TextChanged(object sender, EventArgs e) {
            tenLoaiThuoc = txtTenLoaiThuoc.Text.Trim();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e) {
            tenCachDung = txtDonGia.Text.Trim();
        }

        private void cbDonVi_SelectedIndexChanged(object sender, EventArgs e) {
            tenDonVi = cbDonVi.SelectedItem?.ToString() ?? string.Empty;
        }

        private void cbCachDung_SelectedIndexChanged(object sender, EventArgs e) {
            tenCachDung = cbCachDung.SelectedItem?.ToString() ?? string.Empty;
        }

        private void btnThemLoaiThuoc_Click(object sender, EventArgs e) {
            try {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(tenLoaiThuoc) ||
                    string.IsNullOrWhiteSpace(tenDonVi) ||
                    string.IsNullOrWhiteSpace(tenCachDung) ||
                    string.IsNullOrWhiteSpace(txtDonGia.Text)) {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin loại thuốc!", 
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convert price to double
                if (!double.TryParse(txtDonGia.Text.Trim(), out double donGia) || donGia <= 0) {
                    MessageBox.Show("Đơn giá không hợp lệ!", 
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Find selected DonVi and CachDung objects
                DTO_DonVi selectedDonVi = BUS_DonVi.LayDanhSachDonVi()
                    .FirstOrDefault(d => d.tenDonVi == tenDonVi);
                DTO_CachDung selectedCachDung = BUS_CachDung.LayDanhSachCachDung()
                    .FirstOrDefault(c => c.tenCachDung == tenCachDung);

                if (selectedDonVi == null || selectedCachDung == null) {
                    MessageBox.Show("Đơn vị hoặc cách dùng không hợp lệ!", 
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Generate new medication code
                string maLoaiThuocMoi = BUS_LoaiThuoc.LayMaLoaiThuocMoi(danhSachLoaiThuocMoi);

                // Create new drug type with the generated code
                DTO_LoaiThuoc newLoaiThuoc = new DTO_LoaiThuoc {
                    maLoaiThuoc = maLoaiThuocMoi,
                    tenLoaiThuoc = tenLoaiThuoc,
                    maDonVi = selectedDonVi.maDonVi,
                    maCachDung = selectedCachDung.maCachDung,
                    donGia = donGia
                };

                // Add to the lists and refresh DataGridView
                danhSachLoaiThuoc.Add(newLoaiThuoc);
                danhSachLoaiThuocMoi.Add(newLoaiThuoc);
                ReloadDataToGridView();

                // Clear input fields
                txtTenLoaiThuoc.Clear();
                txtDonGia.Clear();
                cbDonVi.SelectedIndex = -1;
                cbCachDung.SelectedIndex = -1;

                MessageBox.Show($"Thêm loại thuốc thành công! Mã loại thuốc mới: {maLoaiThuocMoi}", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show($"Lỗi khi thêm loại thuốc: {ex.Message}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReloadDataToGridView() {
            try {
                LoadData();
            }
            catch (Exception ex) {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e) {
            try {
                if (danhSachLoaiThuocMoi.Count == 0) {
                    MessageBox.Show("Không có loại thuốc mới để lưu!", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show(
                    $"Bạn có chắc muốn lưu {danhSachLoaiThuocMoi.Count} loại thuốc mới vào cơ sở dữ liệu?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes) {
                    if (BUS_LoaiThuoc.ThemNhieuLoaiThuoc(danhSachLoaiThuocMoi)) {
                        MessageBox.Show("Đã lưu thành công tất cả loại thuốc mới vào cơ sở dữ liệu!", 
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        danhSachLoaiThuocMoi.Clear();
                        
                        LoadDataToGridView();
                    }
                    else {
                        MessageBox.Show("Không thể lưu một số loại thuốc. Vui lòng kiểm tra lại!", 
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void GUI_QuanLyLoaiThuoc_Load(object sender, EventArgs e)
        {
            txtMaLoaiThuoc.Text = BUS_LoaiThuoc.LayMaLoaiThuocMoi(danhSachLoaiThuocMoi);
            txtMaLoaiThuoc.Enabled = false; // Không cho phép chỉnh sửa mã loại thuốc mới
        }
        private void dgvDanhSachLoaiThuoc_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0 && dgvDanhSachLoaiThuoc.Columns[e.ColumnIndex].Name == "btnXoa")
                {
                    e.PaintBackground(e.ClipBounds, true);

                    // Check if the mouse is hovering over the cell
                    bool isHovered = dgvDanhSachLoaiThuoc.CurrentCell != null &&
                                     dgvDanhSachLoaiThuoc.CurrentCell.RowIndex == e.RowIndex &&
                                     dgvDanhSachLoaiThuoc.CurrentCell.ColumnIndex == e.ColumnIndex;

                    // Change background color based on hover state
                    Color backColor = isHovered ? Color.Orange : Color.Red;

                    using (Brush backColorBrush = new SolidBrush(backColor))
                    {
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                    }

                    // Draw the text in the cell
                    TextRenderer.DrawText(e.Graphics, "Xóa", dgvDanhSachLoaiThuoc.Font, e.CellBounds, Color.White,
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
