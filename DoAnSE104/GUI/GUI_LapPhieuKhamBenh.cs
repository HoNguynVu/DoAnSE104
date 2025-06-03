using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using DoAnSE104.BUS;
using DoAnSE104.DTO;
using System.Linq;

namespace DoAnSE104.GUI
{
    public partial class GUI_LapPhieuKhamBenh : Form
    {
        private BUS_KhamBenh BUS_KhamBenh;
        private BUS_BenhNhan BUS_BenhNhan;
        private BUS_LoaiBenh BUS_LoaiBenh;
        private BUS_LoaiThuoc BUS_LoaiThuoc;
        private BUS_CTKhamBenh BUS_CTKhamBenh;
        private List<DTO_LoaiThuoc> danhSachLoaiThuoc;
        private GUI_Home homeForm;

        public GUI_LapPhieuKhamBenh()
        {
            InitializeComponent();
            BUS_KhamBenh = new BUS_KhamBenh();
            BUS_BenhNhan = new BUS_BenhNhan();
            BUS_LoaiBenh = new BUS_LoaiBenh();
            BUS_LoaiThuoc = new BUS_LoaiThuoc();
            BUS_CTKhamBenh = new BUS_CTKhamBenh();
            InitializeDataGridView();
            LoadLoaiBenh();
            LoadDanhSachThuoc();
        }

        public GUI_LapPhieuKhamBenh(GUI_Home home)
        {
            InitializeComponent();
            BUS_KhamBenh = new BUS_KhamBenh();
            BUS_BenhNhan = new BUS_BenhNhan();
            BUS_LoaiBenh = new BUS_LoaiBenh();
            BUS_LoaiThuoc = new BUS_LoaiThuoc();
            BUS_CTKhamBenh = new BUS_CTKhamBenh();
            InitializeDataGridView();
            LoadLoaiBenh();
            LoadDanhSachThuoc();
            this.homeForm = home;
        }

        private void LoadLoaiBenh()
        {
            try
            {
                List<DTO_LoaiBenh> danhSachLoaiBenh = BUS_LoaiBenh.LayDanhSachLoaiBenh();
                cbbLoaiBenh.DataSource = danhSachLoaiBenh;
                cbbLoaiBenh.DisplayMember = "tenLoaiBenh";
                cbbLoaiBenh.ValueMember = "maLoaiBenh";
                cbbLoaiBenh.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại bệnh: " + ex.Message, 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDataGridView()
        {
            DataGridViewTextBoxColumn colSTT = new DataGridViewTextBoxColumn();
            colSTT.HeaderText = "STT";
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            colSTT.Width = 50;

            DataGridViewComboBoxColumn colTenThuoc = new DataGridViewComboBoxColumn();
            colTenThuoc.HeaderText = "Tên loại thuốc";
            colTenThuoc.Name = "colTenThuoc";
            colTenThuoc.Width = 200;

            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.Name = "colSoLuong";
            colSoLuong.Width = 80;

            DataGridViewTextBoxColumn colDonVi = new DataGridViewTextBoxColumn();
            colDonVi.HeaderText = "Đơn vị";
            colDonVi.Name = "colDonVi";
            colDonVi.ReadOnly = true;
            colDonVi.Width = 100;
            colDonVi.DefaultCellStyle.BackColor = Color.LightGray; 

            DataGridViewTextBoxColumn colCachDung = new DataGridViewTextBoxColumn();
            colCachDung.HeaderText = "Cách dùng";
            colCachDung.Name = "colCachDung";
            colCachDung.ReadOnly = true;
            colCachDung.Width = 200;
            colCachDung.DefaultCellStyle.BackColor = Color.LightGray; 

            dgvPhieuKham.Columns.AddRange(new DataGridViewColumn[] {
                colSTT,
                colTenThuoc,
                colSoLuong,
                colDonVi,
                colCachDung
            });

            dgvPhieuKham.RowsAdded += DgvChiTietThuoc_RowsAdded;
            dgvPhieuKham.CellValueChanged += DgvChiTietThuoc_CellValueChanged;
            dgvPhieuKham.EditingControlShowing += DgvChiTietThuoc_EditingControlShowing;
            dgvPhieuKham.CurrentCellDirtyStateChanged += DgvPhieuKham_CurrentCellDirtyStateChanged;
        }

        private void DgvPhieuKham_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPhieuKham.IsCurrentCellDirty)
            {
                dgvPhieuKham.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void LoadDanhSachThuoc()
        {
            try
            {
                danhSachLoaiThuoc = BUS_LoaiThuoc.LayDanhSachLoaiThuoc();
                DataGridViewComboBoxColumn colTenThuoc = dgvPhieuKham.Columns["colTenThuoc"] as DataGridViewComboBoxColumn;
                if (colTenThuoc != null)
                {
                    colTenThuoc.DataSource = danhSachLoaiThuoc;
                    colTenThuoc.DisplayMember = "tenLoaiThuoc";
                    colTenThuoc.ValueMember = "maLoaiThuoc";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách thuốc: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvChiTietThuoc_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvPhieuKham.Rows.Count; i++)
            {
                if (dgvPhieuKham.Rows[i].IsNewRow) continue;
                dgvPhieuKham.Rows[i].Cells["colSTT"].Value = (i + 1).ToString();
            }
        }

        private void DgvChiTietThuoc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = dgvPhieuKham.Rows[e.RowIndex];
            
            if (e.ColumnIndex == dgvPhieuKham.Columns["colTenThuoc"].Index)
            {
                row.Cells["colDonVi"].Value = "";
                row.Cells["colCachDung"].Value = "";

                string maLoaiThuoc = row.Cells["colTenThuoc"].Value?.ToString();
                if (!string.IsNullOrEmpty(maLoaiThuoc))
                {
                    try
                    {
                        var thuoc = danhSachLoaiThuoc.Find(t => t.maLoaiThuoc == maLoaiThuoc);
                        if (thuoc != null)
                        {
                            try
                            {
                                string tenDonVi = BUS_LoaiThuoc.LayTenDonVi(thuoc.maDonVi);
                                if (!string.IsNullOrEmpty(tenDonVi))
                                {
                                    row.Cells["colDonVi"].Value = tenDonVi;
                                }

                                string cachDung = BUS_LoaiThuoc.LayTenCachDung(thuoc.maCachDung);
                                if (!string.IsNullOrEmpty(cachDung))
                                {
                                    row.Cells["colCachDung"].Value = cachDung;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi khi lấy thông tin thuốc: " + ex.Message,
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tìm thông tin thuốc: " + ex.Message,
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DgvChiTietThuoc_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvPhieuKham.CurrentCell.ColumnIndex == dgvPhieuKham.Columns["colSoLuong"].Index)
            {
                if (e.Control is TextBox txt)
                {
                    txt.KeyPress += (s, evt) => {
                        if (!char.IsControl(evt.KeyChar) && !char.IsDigit(evt.KeyChar))
                        {
                            evt.Handled = true;
                        }
                    };
                }
            }
        }

        private void txtMaKhamBenh_TextChanged(object sender, EventArgs e)
        {
            string maKhamBenh = txtMaKhamBenh.Text.Trim();

            if (!string.IsNullOrEmpty(maKhamBenh))
            {
                try
                {
                    DTO_KhamBenh khamBenh = BUS_KhamBenh.LayThongTinKhamBenh(maKhamBenh);
                    if (khamBenh != null)
                    {
                        txtNgayKham.Text = khamBenh.ngayKham.ToString("dd/MM/yyyy");

                        DTO_BenhNhan benhNhan = BUS_BenhNhan.LayThongTinBenhNhan(khamBenh.maBenhNhan);
                        if (benhNhan != null)
                        {
                            txtTenBenhNhan.Text = benhNhan.hoTen;
                            errorProvider1.SetError(txtMaKhamBenh, "");
                        }
                    }
                    else
                    {
                        ClearDisplayInfo();
                        errorProvider1.SetError(txtMaKhamBenh, "Mã khám bệnh không tồn tại.");
                    }
                }
                catch (Exception ex)
                {
                    ClearDisplayInfo();
                    errorProvider1.SetError(txtMaKhamBenh, "Lỗi: " + ex.Message);
                }
            }
            else
            {
                ClearDisplayInfo();
                errorProvider1.SetError(txtMaKhamBenh, "Vui lòng nhập mã khám bệnh.");
            }
        }

        private void ClearDisplayInfo()
        {
            txtNgayKham.Text = "";
            txtTenBenhNhan.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhamBenh.Text) ||
                string.IsNullOrWhiteSpace(cbbLoaiBenh.Text) ||
                string.IsNullOrWhiteSpace(txtTrieuChung.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bệnh!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }   

            string maKhamBenh = txtMaKhamBenh.Text.Trim();

            try
            {
                DTO_KhamBenh khamBenh = BUS_KhamBenh.LayThongTinKhamBenh(maKhamBenh);
                if (khamBenh == null)
                {
                    MessageBox.Show("Mã khám bệnh không tồn tại!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrEmpty(khamBenh.maLoaiBenh) || !string.IsNullOrEmpty(khamBenh.trieuChung))
                {
                    MessageBox.Show("Phiếu khám bệnh này đã được lập trước đó!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<DTO_CTKhamBenh> chiTietKhamBenh = BUS_CTKhamBenh.LayDanhSachChiTietKhamBenh(maKhamBenh);
                //if (chiTietKhamBenh != null && chiTietKhamBenh.Count > 0)
                //{
                //    MessageBox.Show("Phiếu khám bệnh này đã tồn tại chi tiết khám bệnh!",
                //        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                try
                {
                    string maLoaiBenh = cbbLoaiBenh.SelectedValue?.ToString();
                    string trieuChung = txtTrieuChung.Text.Trim();

                    if (BUS_KhamBenh.CapNhatKhamBenh(maKhamBenh, maLoaiBenh, trieuChung))
                    {
                        bool success = true;
                        string errorMessage = "";

                        foreach (DataGridViewRow row in dgvPhieuKham.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string maThuoc = row.Cells["colTenThuoc"].Value?.ToString();
                            if (string.IsNullOrEmpty(maThuoc)) continue;

                            string soLuongStr = row.Cells["colSoLuong"].Value?.ToString();
                            if (string.IsNullOrEmpty(soLuongStr) || !int.TryParse(soLuongStr, out int soLuong))
                            {
                                errorMessage = "Số lượng thuốc không hợp lệ";
                                success = false;
                                break;
                            }

                            try
                            {
                                if (!BUS_CTKhamBenh.ThemChiTietThuoc(maKhamBenh, maThuoc, soLuong))
                                {
                                    success = false;
                                    errorMessage = "Không thể thêm chi tiết thuốc";
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {
                                success = false;
                                errorMessage = ex.Message;
                                break;
                            }
                        }

                        if (success)
                        {
                            MessageBox.Show("Lập phiếu khám bệnh thành công!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            //this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi lưu chi tiết thuốc: " + errorMessage,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật thông tin khám bệnh!",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra thông tin khám bệnh: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhieuKham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvPhieuKham.Columns["TenLoaiThuoc"].Index)
            {
                var selectedValue = dgvPhieuKham.Rows[e.RowIndex].Cells["TenLoaiThuoc"].Value;
                if (selectedValue != null)
                {
                    string maLoaiThuoc = selectedValue.ToString();
                    var thuoc = danhSachLoaiThuoc.FirstOrDefault(t => t.maLoaiThuoc == maLoaiThuoc);
                    
                    if (thuoc != null)
                    {
                        dgvPhieuKham.Rows[e.RowIndex].Cells["DonVi"].Value = thuoc.maDonVi;
                    }
                }
            }
        }


        private void dgvPhieuKham_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            if (dgvPhieuKham.Rows.Count == 1 && dgvPhieuKham.Rows[0].Cells["TenLoaiThuoc"].Value == null)
            {
                return;
            }

            int lastNonNewRowIndex = dgvPhieuKham.Rows.Count - 2;  
            
            if (lastNonNewRowIndex >= 0 && dgvPhieuKham.Rows[lastNonNewRowIndex].Cells["TenLoaiThuoc"].Value != null)

            {
                dgvPhieuKham.AllowUserToAddRows = true;
            }
        }

        private void btnTimPhieuKham_Click(object sender, EventArgs e)
        {
            string maKhamBenh = txtMaKhamBenh.Text.Trim();

            if (string.IsNullOrEmpty(maKhamBenh))
            {
                MessageBox.Show("Vui lòng nhập mã khám bệnh!", 
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhamBenh.Focus();
                return;
            }

            try
            {
                DTO_KhamBenh khamBenh = BUS_KhamBenh.LayThongTinKhamBenh(maKhamBenh);
                if (khamBenh == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin khám bệnh!", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                txtNgayKham.Text = khamBenh.ngayKham.ToString("dd/MM/yyyy");
                
                if (!string.IsNullOrEmpty(khamBenh.maLoaiBenh))
                {
                    for (int i = 0; i < cbbLoaiBenh.Items.Count; i++)
                    {
                        var item = (DTO_LoaiBenh)cbbLoaiBenh.Items[i];
                        if (item.maLoaiBenh == khamBenh.maLoaiBenh)
                        {
                            cbbLoaiBenh.SelectedIndex = i;
                            break;
                        }
                    }
                }

                txtTrieuChung.Text = khamBenh.trieuChung;

                DTO_BenhNhan benhNhan = BUS_BenhNhan.LayThongTinBenhNhan(khamBenh.maBenhNhan);
                if (benhNhan != null)
                {
                    txtTenBenhNhan.Text = benhNhan.hoTen;
                }

                List<DTO_CTKhamBenh> danhSachThuoc = BUS_CTKhamBenh.LayDanhSachChiTietKhamBenh(maKhamBenh);
                dgvPhieuKham.Rows.Clear();

                foreach (var chiTiet in danhSachThuoc)
                {
                    var thuoc = danhSachLoaiThuoc.Find(t => t.maLoaiThuoc == chiTiet.maLoaiThuoc);
                    if (thuoc != null)
                    {
                        string tenDonVi = BUS_LoaiThuoc.LayTenDonVi(thuoc.maDonVi);
                        string cachDung = BUS_LoaiThuoc.LayTenCachDung(thuoc.maCachDung);

                        var index = dgvPhieuKham.Rows.Add();
                        var row = dgvPhieuKham.Rows[index];
                        
                        row.Cells["colSTT"].Value = (index + 1).ToString();
                        row.Cells["colTenThuoc"].Value = thuoc.maLoaiThuoc;
                        row.Cells["colSoLuong"].Value = chiTiet.soLuongThuoc;
                        row.Cells["colDonVi"].Value = tenDonVi;
                        row.Cells["colCachDung"].Value = cachDung;
                    }
                }

                errorProvider1.SetError(txtMaKhamBenh, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm thông tin khám bệnh: " + ex.Message, 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimBenhNhan_Click(object sender, EventArgs e)
        {
            GUI_TraCuuBenhNhan traCuuForm = new GUI_TraCuuBenhNhan(homeForm);
            homeForm.ShowFormInMainPanel(traCuuForm);
            this.Close();
        }
    }
}