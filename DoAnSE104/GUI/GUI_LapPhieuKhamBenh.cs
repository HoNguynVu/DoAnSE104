using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnSE104.BUS;
using DoAnSE104.DTO;
using DoAnSE104.DAL;

namespace DoAnSE104.GUI
{
    public partial class GUI_LapPhieuKhamBenh : Form
    {
        private BUS_HoaDon BUS_HoaDon = new BUS_HoaDon();
        private BUS_KhamBenh BUS_KhamBenh = new BUS_KhamBenh();
        private BUS_LoaiThuoc BUS_LoaiThuoc = new BUS_LoaiThuoc();
        private BUS_LoaiBenh BUS_LoaiBenh = new BUS_LoaiBenh();
        private BUS_CTKhamBenh BUS_CTKhamBenh = new BUS_CTKhamBenh();
        private BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();
        private List<DTO_LoaiThuoc> danhSachLoaiThuoc;

        public GUI_LapPhieuKhamBenh()
        {
            InitializeComponent();
            // Set default values for the form elements
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Configure DataGridView
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            // Configure STT column for auto-numbering
            dataGridView1.RowPrePaint += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
                }
            };
        }

        private void GUI_LapPhieuKhamBenh_Load(object sender, EventArgs e)
        {
            LoadDanhSachLoaiBenh();
            LoadDanhSachLoaiThuoc();

            // Reset all ComboBoxes to empty state
            selectLoaiBenh.SelectedIndex = -1;

            // Configure ComboBox in DataGridView
            SetupThuocComboBox();
        }

        private void LoadDanhSachLoaiBenh()
        {
            selectLoaiBenh.DataSource = BUS_LoaiBenh.LayDanhSachLoaiBenh();
            selectLoaiBenh.DisplayMember = "tenLoaiBenh";
            selectLoaiBenh.ValueMember = "maLoaiBenh";
        }

        private void LoadDanhSachLoaiThuoc()
        {
            danhSachLoaiThuoc = BUS_LoaiThuoc.LayDanhSachLoaiThuoc();
        }

        private void SetupThuocComboBox()
        {
            // Configure the ComboBox column for medications
            DataGridViewComboBoxColumn thuocColumn = (DataGridViewComboBoxColumn)dataGridView1.Columns["TenLoaiThuoc"];
            thuocColumn.DataSource = danhSachLoaiThuoc;
            thuocColumn.DisplayMember = "tenLoaiThuoc";
            thuocColumn.ValueMember = "maLoaiThuoc";
        }

        private void btnLapPK_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtMaKB.Text) ||
                string.IsNullOrWhiteSpace(txtTrieuChung.Text) ||
                selectLoaiBenh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Add medical examination record
                if (BUS_KhamBenh.CapNhatKhamBenh(txtMaKB.Text.Trim(), selectLoaiBenh.SelectedValue.ToString(), txtTrieuChung.Text.Trim()))
                {
                    // Save medication details if available
                    bool success = true;

                    // Process each row in the DataGridView that has medication info
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        // Skip the last row (new row) or rows without medication selected
                        if (row.IsNewRow || row.Cells["TenLoaiThuoc"].Value == null)
                            continue;

                        // Get medication info from the grid
                        string maLoaiThuoc = row.Cells["TenLoaiThuoc"].Value.ToString();
                        string soLuong = row.Cells["SoLuong"].Value?.ToString();

                        // Add medication record
                        if (!string.IsNullOrEmpty(soLuong) && !ThemChiTietThuoc(txtMaKB.Text.Trim(), maLoaiThuoc, soLuong))
                        {
                            success = false;
                        }
                    }

                    if (success)
                    {
                        MessageBox.Show("Lập phiếu khám bệnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Lập phiếu thành công nhưng có lỗi khi lưu thông tin thuốc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lập phiếu khám bệnh thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ThemChiTietThuoc(string maKhamBenh, string maLoaiThuoc, string soLuong)
        {
            try
            {
                if (int.TryParse(soLuong, out int sl) && sl > 0)
                {
                    return BUS_CTKhamBenh.ThemChiTietThuoc(maKhamBenh, maLoaiThuoc, sl);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void ClearForm()
        {
            txtMaKB.Clear();
            txtNK.Clear();
            txtTenBN.Clear();
            txtTrieuChung.Clear();
            selectLoaiBenh.SelectedIndex = -1;

            // Clear DataGridView
            dataGridView1.Rows.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaKB_TextChanged(object sender, EventArgs e)
        {
            string maKhamBenh = txtMaKB.Text.Trim();

            if (!string.IsNullOrEmpty(maKhamBenh))
            {
                try
                {
                    DTO_KhamBenh khamBenh = BUS_KhamBenh.LayThongTinKhamBenh(maKhamBenh);
                    if (khamBenh != null)
                    {
                        // Display examination date
                        txtNK.Text = khamBenh.ngayKham.ToString("dd/MM/yyyy");

                        // Get and display patient name
                        if (!string.IsNullOrEmpty(khamBenh.maBenhNhan))
                        {
                            DTO_BenhNhan benhNhan = BUS_BenhNhan.LayThongTinBenhNhan(khamBenh.maBenhNhan);
                            if (benhNhan != null)
                            {
                                txtTenBN.Text = benhNhan.hoTen;
                            }
                            else
                            {
                                txtTenBN.Text = "";
                            }
                            errorProvider1.SetError(txtMaKB, "");
                        }
                        else
                        {
                            // Display error using ErrorProvider
                            errorProvider1.SetError(txtMaKB, "Mã khám bệnh không có thông tin bệnh nhân");
                        }
                    }
                    else
                    {

                        errorProvider1.SetError(txtMaKB, "Mã khám bệnh không tồn tại");

                        txtNK.Text = "";
                        txtTenBN.Text = "";
                        txtTrieuChung.Text = "";
                        selectLoaiBenh.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                txtNK.Text = "";
                txtTenBN.Text = "";
                errorProvider1.SetError(txtMaKB, "Vui lòng nhập mã khám bệnh.");
            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["TenLoaiThuoc"].Index)
            {
                var selectedValue = dataGridView1.Rows[e.RowIndex].Cells["TenLoaiThuoc"].Value;
                if (selectedValue != null)
                {
                    string maLoaiThuoc = selectedValue.ToString();
                    var thuoc = danhSachLoaiThuoc.FirstOrDefault(t => t.maLoaiThuoc == maLoaiThuoc);
                    if (thuoc != null)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["DonVi"].Value = thuoc.maDonVi;
                    }
                }
            }
        }


        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            if (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].Cells["TenLoaiThuoc"].Value == null)
            {
                return;
            }

            int lastNonNewRowIndex = dataGridView1.Rows.Count - 2; // Index of last non-new row
            if (lastNonNewRowIndex >= 0 && dataGridView1.Rows[lastNonNewRowIndex].Cells["TenLoaiThuoc"].Value != null)
            {
                dataGridView1.AllowUserToAddRows = true;
            }
        }
    }
}