using DoAnSE104.BUS;
using DoAnSE104.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAnSE104.GUI {
    public partial class GUI_QuanLyCachDung : Form {
        private BUS_CachDung busCachDung = new BUS_CachDung();
        private List<DTO_CachDung> listCachDung = new List<DTO_CachDung>();
        private List<DTO_CachDung> listCachDungMoi = new List<DTO_CachDung>();
        private string tenCachDung = string.Empty;

        public GUI_QuanLyCachDung() {
            InitializeComponent();
            LoadDataToGridView();
            
            // Display initial new code
            txtMaCachDung.Text = busCachDung.LayMaCachDungMoi(listCachDungMoi);
            txtMaCachDung.Enabled = false; // Make it read-only
            
            // Add CellClick event handler
            dgvDanhSachCachDung.CellClick += dgvDanhSachCachDung_CellClick;
        }
        private void LoadData() {
            dgvDanhSachCachDung.Rows.Clear();
            if (dgvDanhSachCachDung.Columns.Count == 0) {
                dgvDanhSachCachDung.Columns.Add("STT", "STT");
                dgvDanhSachCachDung.Columns.Add("MaCachDung", "Mã Cách dùng");
                dgvDanhSachCachDung.Columns.Add("TenCachDung", "Tên Cách dùng");

                // Thêm cột button xóa
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                btnXoa.HeaderText = "Thao Tác";
                btnXoa.Text = "Xóa";
                btnXoa.Name = "btnXoa";
                btnXoa.UseColumnTextForButtonValue = true;
                dgvDanhSachCachDung.Columns.Add(btnXoa);
            }

            int stt = 0;

            foreach (DTO_CachDung cd in listCachDung) {
                dgvDanhSachCachDung.Rows.Add(
                    ++stt,
                    cd.maCachDung,
                    cd.tenCachDung
                );
            }

            dgvDanhSachCachDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachCachDung.AllowUserToAddRows = false;
            dgvDanhSachCachDung.ReadOnly = true;
            dgvDanhSachCachDung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadDataToGridView() {
            try {
                listCachDung = busCachDung.LayDanhSachCachDung();
                LoadData();
            }
            catch (Exception ex) {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemCachDung_Click(object sender, EventArgs e) {
            try {
                // Generate new usage code first
                string maCachDungMoi = busCachDung.LayMaCachDungMoi(listCachDungMoi);
                
                // Validate inputs
                if (string.IsNullOrWhiteSpace(tenCachDung)) {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cách dùng!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Display new code
                txtMaCachDung.Text = maCachDungMoi;

                // Create new usage type with the generated code
                DTO_CachDung newCachDung = new DTO_CachDung(maCachDungMoi, tenCachDung);

                // Add to the lists and refresh DataGridView
                listCachDung.Add(newCachDung);
                listCachDungMoi.Add(newCachDung);
                reloadData();

                // Clear input fields
                txtCachDung.Clear();

                MessageBox.Show($"Thêm cách dùng thành công! Mã cách dùng mới: {maCachDungMoi}",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show($"Lỗi khi thêm cách dùng: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCachDung_TextChanged(object sender, EventArgs e) {
            tenCachDung = txtCachDung.Text.Trim();
        }
        private void reloadData() {
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
                if (listCachDungMoi.Count == 0) {
                    MessageBox.Show("Không có cách dùng mới để lưu!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show(
                    $"Bạn có chắc muốn lưu {listCachDungMoi.Count} cách dùng mới vào cơ sở dữ liệu?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes) {
                    if (busCachDung.ThemNhieuCachDung(listCachDungMoi)) {
                        MessageBox.Show("Đã lưu thành công tất cả cách dùng mới vào cơ sở dữ liệu!",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        listCachDungMoi.Clear();
                        LoadDataToGridView();
                    }
                    else {
                        MessageBox.Show("Không thể lưu một số cách dùng. Vui lòng kiểm tra lại!",
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

        private void dgvDanhSachCachDung_CellClick(object sender, DataGridViewCellEventArgs e) {
            // Check if clicked on Delete button column
            if (e.ColumnIndex == dgvDanhSachCachDung.Columns["btnXoa"].Index && e.RowIndex >= 0) {
                try {
                    string maCachDung = dgvDanhSachCachDung.Rows[e.RowIndex].Cells["MaCachDung"].Value.ToString();

                    // Check if this is a newly added item
                    var cachDungMoi = listCachDungMoi.FirstOrDefault(cd => cd.maCachDung == maCachDung);

                    if (cachDungMoi != null) {
                        // If it's a new item, remove directly
                        listCachDungMoi.Remove(cachDungMoi);
                        listCachDung.RemoveAll(cd => cd.maCachDung == maCachDung);
                        reloadData();
                        MessageBox.Show("Đã xóa cách dùng khỏi danh sách mới!", 
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        // If it exists in DB, first check if it's being used
                        if (busCachDung.KiemTraCachDungDangDuocSuDung(maCachDung)) {
                            MessageBox.Show("Không thể xóa cách dùng này vì đang được sử dụng cho một số loại thuốc!", 
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // If not being used, ask for confirmation
                        var result = MessageBox.Show(
                            "Bạn có chắc muốn xóa cách dùng này khỏi cơ sở dữ liệu?",
                            "Xác nhận xóa",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes) {
                            if (busCachDung.XoaCachDung(maCachDung)) {
                                listCachDung.RemoveAll(cd => cd.maCachDung == maCachDung);
                                reloadData();
                                MessageBox.Show("Đã xóa cách dùng khỏi cơ sở dữ liệu!", 
                                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else {
                                MessageBox.Show("Không thể xóa cách dùng này! Vui lòng thử lại sau.", 
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"Lỗi khi xóa cách dùng: {ex.Message}", 
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
