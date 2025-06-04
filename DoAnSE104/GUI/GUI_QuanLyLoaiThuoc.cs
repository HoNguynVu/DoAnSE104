using DoAnSE104.BUS;
using DoAnSE104.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DoAnSE104.GUI
{
    public partial class GUI_QuanLyLoaiThuoc : Form
    {
        private BUS_LoaiThuoc BUS_LoaiThuoc = new BUS_LoaiThuoc();
        private BUS_DonVi BUS_DonVi = new BUS_DonVi();
        private BUS_CachDung BUS_CachDung = new BUS_CachDung();
        private string tenLoaiThuoc = string.Empty;
        private string tenDonVi = string.Empty;
        private string tenCachDung = string.Empty;
        private string donGia = string.Empty;
        private int hoverRowIndex = -1;
        private int hoverColIndex = -1;
        List<DTO_LoaiThuoc> danhSachLoaiThuoc;
        List<DTO_LoaiThuoc> danhSachLoaiThuocMoi = new List<DTO_LoaiThuoc>();
        private Dictionary<string, double> changedPrices = new Dictionary<string, double>();

        public GUI_QuanLyLoaiThuoc()
        {
            InitializeComponent();
            dgvDanhSachLoaiThuoc.CellPainting += dgvDanhSachLoaiThuoc_CellPainting;
            dgvDanhSachLoaiThuoc.CellMouseMove += dgvDanhSachLoaiThuoc_CellMouseMove;
            dgvDanhSachLoaiThuoc.CellMouseLeave += dgvDanhSachLoaiThuoc_CellMouseLeave;
            LoadDataToGridView();
            LoadDataDonVi();
            LoadDataCachDung();

            txtMaLoaiThuoc.Text = BUS_LoaiThuoc.LayMaLoaiThuocMoi(danhSachLoaiThuocMoi);
            txtMaLoaiThuoc.Enabled = false;

            dgvDanhSachLoaiThuoc.CellClick += dgvDanhSachLoaiThuoc_CellClick;
            dgvDanhSachLoaiThuoc.CellValueChanged += dgvDanhSachLoaiThuoc_CellValueChanged;
            dgvDanhSachLoaiThuoc.CellEndEdit += dgvDanhSachLoaiThuoc_CellEndEdit;
        }
        private void LoadDataDonVi()
        {
            try
            {
                List<DTO_DonVi> danhSachDonVi = BUS_DonVi.LayDanhSachDonVi();
                cbDonVi.Items.Clear();
                foreach (DTO_DonVi donVi in danhSachDonVi)
                {
                    cbDonVi.Items.Add(donVi.tenDonVi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu đơn vị: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataCachDung()
        {
            try
            {
                List<DTO_CachDung> danhSachCachDung = BUS_CachDung.LayDanhSachCachDung();
                cbCachDung.Items.Clear();
                foreach (DTO_CachDung cachDung in danhSachCachDung)
                {
                    cbCachDung.Items.Add(cachDung.tenCachDung);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu cách dùng: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            // Xóa các hàng hiện có mà không ảnh hưởng đến các cột
            dgvDanhSachLoaiThuoc.Rows.Clear();

            int stt = 0;
            foreach (DTO_LoaiThuoc loaiThuoc in danhSachLoaiThuoc)
            {
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

            // Chỉ cho phép chỉnh sửa cột Đơn giá
            dgvDanhSachLoaiThuoc.Columns["donGiaItem"].ReadOnly = false;

            foreach (DataGridViewColumn column in dgvDanhSachLoaiThuoc.Columns)
            {
                if (column.Name != "donGiaItem" && column.Name != "btnXoa")
                {
                    column.ReadOnly = true;
                }
            }

            dgvDanhSachLoaiThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachLoaiThuoc.AllowUserToAddRows = false;
            dgvDanhSachLoaiThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void LoadDataToGridView()
        {
            try
            {
                danhSachLoaiThuoc = BUS_LoaiThuoc.LayDanhSachLoaiThuoc();
                LoadData();

            }
            catch (Exception ex)
            {
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
                        bool isBeingUsed = BUS_LoaiThuoc.KiemTraLoaiThuocDangDuocSuDung(maLoaiThuoc);
                        if (isBeingUsed)
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

        private void txtTenLoaiThuoc_TextChanged(object sender, EventArgs e)
        {
            tenLoaiThuoc = txtTenLoaiThuoc.Text.Trim();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            donGia = txtDonGia.Text.Trim();
        }

        private void cbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            tenDonVi = cbDonVi.SelectedItem?.ToString() ?? string.Empty;
        }

        private void cbCachDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            tenCachDung = cbCachDung.SelectedItem?.ToString() ?? string.Empty;
        }

        private void btnThemLoaiThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo mã loại thuốc mới
                string maLoaiThuocMoi = BUS_LoaiThuoc.LayMaLoaiThuocMoi(danhSachLoaiThuocMoi);

                // Kiểm tra dữ liệu đầu vào
                if (!string.IsNullOrWhiteSpace(tenLoaiThuoc) &&
                    !string.IsNullOrWhiteSpace(tenDonVi) &&
                    !string.IsNullOrWhiteSpace(tenCachDung) &&
                    !string.IsNullOrWhiteSpace(donGia))
                {
                    // Chuyển đổi giá thành double
                    if (!double.TryParse(txtDonGia.Text.Trim(), out double donGia) || donGia <= 0)
                    {
                        MessageBox.Show("Đơn giá không hợp lệ!",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tìm các đối tượng DonVi và CachDung đã chọn
                    DTO_DonVi selectedDonVi = BUS_DonVi.LayDanhSachDonVi()
                        .FirstOrDefault(d => d.tenDonVi == tenDonVi);
                    DTO_CachDung selectedCachDung = BUS_CachDung.LayDanhSachCachDung()
                        .FirstOrDefault(c => c.tenCachDung == tenCachDung);

                    if (selectedDonVi == null || selectedCachDung == null)
                    {
                        MessageBox.Show("Đơn vị hoặc cách dùng không hợp lệ!",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    // Tạo loại thuốc mới với mã được tạo
                    DTO_LoaiThuoc newLoaiThuoc = new DTO_LoaiThuoc
                    {
                        maLoaiThuoc = maLoaiThuocMoi,
                        tenLoaiThuoc = tenLoaiThuoc,
                        maDonVi = selectedDonVi.maDonVi,
                        maCachDung = selectedCachDung.maCachDung,
                        donGia = donGia
                    };

                    // Thêm vào danh sách và làm mới DataGridView
                    danhSachLoaiThuoc.Add(newLoaiThuoc);
                    danhSachLoaiThuocMoi.Add(newLoaiThuoc);
                    ReloadDataToGridView();

                    // Xóa các trường nhập liệu
                    txtTenLoaiThuoc.Clear();
                    txtDonGia.Clear();
                    cbDonVi.SelectedIndex = -1;
                    cbCachDung.SelectedIndex = -1;

                    MessageBox.Show($"Thêm loại thuốc thành công! Mã loại thuốc mới: {maLoaiThuocMoi}",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin loại thuốc!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm loại thuốc: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReloadDataToGridView()
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasChanges = false;

                // Kiểm tra xem có loại thuốc mới nào cần lưu không
                if (danhSachLoaiThuocMoi.Count > 0)
                {
                    hasChanges = true;
                    var result = MessageBox.Show(
                        $"Bạn có chắc muốn lưu {danhSachLoaiThuocMoi.Count} loại thuốc mới vào cơ sở dữ liệu?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        if (BUS_LoaiThuoc.ThemNhieuLoaiThuoc(danhSachLoaiThuocMoi))
                        {
                            MessageBox.Show("Đã lưu thành công tất cả loại thuốc mới vào cơ sở dữ liệu!",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            danhSachLoaiThuocMoi.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không thể lưu một số loại thuốc mới. Vui lòng kiểm tra lại!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        return; // Người dùng hủy thao tác lưu
                    }
                }

                // Kiểm tra xem có thay đổi giá nào cần lưu không
                if (changedPrices.Count > 0)
                {
                    hasChanges = true;
                    var result = MessageBox.Show(
                        $"Bạn có chắc muốn cập nhật đơn giá cho {changedPrices.Count} loại thuốc?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        int successCount = 0;
                        List<string> failedItems = new List<string>();

                        foreach (var item in changedPrices)
                        {
                            string maLoaiThuoc = item.Key;
                            double donGiaMoi = item.Value;

                            if (BUS_LoaiThuoc.CapNhatDonGia(maLoaiThuoc, donGiaMoi))
                            {
                                // Cập nhật giá trong danh sách cục bộ
                                var loaiThuoc = danhSachLoaiThuoc.Find(t => t.maLoaiThuoc == maLoaiThuoc);
                                if (loaiThuoc != null)
                                {
                                    loaiThuoc.donGia = donGiaMoi;
                                }
                                successCount++;
                            }
                            else
                            {
                                failedItems.Add(maLoaiThuoc);
                            }
                        }

                        if (successCount == changedPrices.Count)
                        {
                            MessageBox.Show($"Đã cập nhật thành công đơn giá cho {successCount} loại thuốc!",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            changedPrices.Clear();
                        }
                        else
                        {
                            string failedMessage = string.Join(", ", failedItems);
                            MessageBox.Show($"Đã cập nhật {successCount}/{changedPrices.Count} loại thuốc.\nCác mã loại thuốc cập nhật không thành công: {failedMessage}",
                                "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            // Xóa các cập nhật thành công khỏi từ điển changedPrices
                            foreach (string maLoaiThuoc in failedItems)
                            {
                                changedPrices.Remove(maLoaiThuoc);
                            }
                        }
                    }
                    else
                    {
                        return; // Người dùng hủy việc cập nhật giá
                    }
                }

                if (!hasChanges)
                {
                    MessageBox.Show("Không có thay đổi nào để lưu!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Tải lại dữ liệu để làm mới giao diện và xóa đánh dấu
                    LoadDataToGridView();
                    // Đặt lại txt mã loại thuốc
                    txtMaLoaiThuoc.Text = BUS_LoaiThuoc.LayMaLoaiThuocMoi(danhSachLoaiThuocMoi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
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

                    Color backColor = (e.RowIndex == hoverRowIndex && e.ColumnIndex == hoverColIndex)
                        ? Color.FromArgb(211, 47, 47) // Màu hover (đỏ đậm hơn)
                        : Color.FromArgb(244, 67, 54); // Màu mặc định giống nút Thoát

                    using (Brush backColorBrush = new SolidBrush(backColor))
                    {
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                    }

                    // Vẽ viền nếu muốn
                    using (Pen pen = new Pen(dgvDanhSachLoaiThuoc.GridColor))
                    {
                        e.Graphics.DrawRectangle(pen, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
                    }

                    TextRenderer.DrawText(e.Graphics, "Xóa", dgvDanhSachLoaiThuoc.Font,
                        e.CellBounds, Color.White,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi vẽ ô: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSachLoaiThuoc_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachLoaiThuoc.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                if (hoverRowIndex != e.RowIndex || hoverColIndex != e.ColumnIndex)
                {
                    hoverRowIndex = e.RowIndex;
                    hoverColIndex = e.ColumnIndex;
                    dgvDanhSachLoaiThuoc.InvalidateCell(e.ColumnIndex, e.RowIndex);
                }
            }
            else if (hoverRowIndex != -1 || hoverColIndex != -1)
            {
                int oldRow = hoverRowIndex, oldCol = hoverColIndex;
                hoverRowIndex = -1;
                hoverColIndex = -1;
                if (oldRow >= 0 && oldCol >= 0 && oldRow < dgvDanhSachLoaiThuoc.RowCount && oldCol < dgvDanhSachLoaiThuoc.ColumnCount)
                {
                    dgvDanhSachLoaiThuoc.InvalidateCell(oldCol, oldRow);
                }
            }
        }

        private void dgvDanhSachLoaiThuoc_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (hoverRowIndex != -1 || hoverColIndex != -1)
            {
                int oldRow = hoverRowIndex, oldCol = hoverColIndex;
                hoverRowIndex = -1;
                hoverColIndex = -1;
                dgvDanhSachLoaiThuoc.InvalidateCell(oldCol, oldRow);
            }
        }

        private void dgvDanhSachLoaiThuoc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Chỉ xử lý thay đổi đối với cột giá
            if (e.RowIndex >= 0 && dgvDanhSachLoaiThuoc.Columns[e.ColumnIndex].Name == "donGiaItem")
            {
                try
                {
                    string maLoaiThuoc = dgvDanhSachLoaiThuoc.Rows[e.RowIndex].Cells["maLoaiThuocItem"].Value.ToString();
                    string donGiaStr = dgvDanhSachLoaiThuoc.Rows[e.RowIndex].Cells["donGiaItem"].Value.ToString();

                    // Xóa dấu phẩy phân cách hàng nghìn và phân tích
                    donGiaStr = donGiaStr.Replace(",", "");

                    if (double.TryParse(donGiaStr, out double donGiaMoi) && donGiaMoi > 0)
                    {
                        // Lưu vào từ điển changedPrices để lưu sau
                        changedPrices[maLoaiThuoc] = donGiaMoi;

                        // Đánh dấu hàng để chỉ ra thay đổi đang chờ xử lý
                        dgvDanhSachLoaiThuoc.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                    else
                    {
                        MessageBox.Show("Đơn giá không hợp lệ! Vui lòng nhập số dương.",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Khôi phục về giá trị ban đầu
                        DTO_LoaiThuoc loaiThuoc = danhSachLoaiThuoc.Find(t => t.maLoaiThuoc == maLoaiThuoc);
                        if (loaiThuoc != null)
                        {
                            dgvDanhSachLoaiThuoc.Rows[e.RowIndex].Cells["donGiaItem"].Value = loaiThuoc.donGia.ToString("N0");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật đơn giá: {ex.Message}",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDanhSachLoaiThuoc_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Định dạng giá với dấu phẩy phân cách hàng nghìn sau khi chỉnh sửa
            if (e.RowIndex >= 0 && dgvDanhSachLoaiThuoc.Columns[e.ColumnIndex].Name == "donGiaItem")
            {
                string donGiaStr = dgvDanhSachLoaiThuoc.Rows[e.RowIndex].Cells["donGiaItem"].Value?.ToString();
                if (!string.IsNullOrEmpty(donGiaStr))
                {
                    // Xóa bất kỳ định dạng nào hiện có
                    donGiaStr = donGiaStr.Replace(",", "");

                    if (double.TryParse(donGiaStr, out double donGia))
                    {
                        dgvDanhSachLoaiThuoc.Rows[e.RowIndex].Cells["donGiaItem"].Value = donGia.ToString("N0");
                    }
                }
            }
        }
    }
}