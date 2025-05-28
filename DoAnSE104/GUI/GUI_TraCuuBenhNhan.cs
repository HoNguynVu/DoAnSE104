using DoAnSE104.BUS;
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
    public partial class GUI_TraCuuBenhNhan : Form
    {
        private BUS_KhamBenh BUS_KhamBenh = new BUS_KhamBenh();
        private BUS_LoaiThuoc BUS_LoaiThuoc = new BUS_LoaiThuoc();
        private BUS_LoaiBenh BUS_LoaiBenh = new BUS_LoaiBenh();
        private BUS_CTKhamBenh BUS_CTKhamBenh = new BUS_CTKhamBenh();
        private BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();
        private BUS_TraCuu BUS_TraCuu = new BUS_TraCuu();
        public GUI_TraCuuBenhNhan()
        {
            InitializeComponent();
        }

        private void GUI_TraCuuBenhNhan_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;

            // Set up numericNamSinhTu
            numericNamSinhTu.Minimum = 1900;
            numericNamSinhTu.Maximum = currentYear;
            numericNamSinhTu.Value = 1900; // Default to 1900 instead of 0

            // Set up numericNamSinhDen
            numericNamSinhDen.Minimum = 1900;
            numericNamSinhDen.Maximum = currentYear;
            numericNamSinhDen.Value = currentYear; // Default to current year

            // Set up date time pickers
            dtpNgayKhamTu.ShowCheckBox = true;
            dtpNgayKhamTu.Checked = false;

            dtpNgayKhamDen.ShowCheckBox = true;
            dtpNgayKhamDen.Checked = false;

            // Load data for comboboxes
            LoadDanhSachLoaiBenh();
            LoadDanhSachLoaiThuoc();
            LoadDanhSachPhieuKham();
        }
        private void LoadDanhSachLoaiBenh()
        {
            List<DTO_LoaiBenh> danhSach = BUS_LoaiBenh.LayDanhSachLoaiBenh();
            danhSach.Insert(0, new DTO_LoaiBenh { maLoaiBenh ="", tenLoaiBenh = ""});

            cmbTenLoaiBenh.DataSource = danhSach;
            cmbTenLoaiBenh.DisplayMember = "tenLoaiBenh";
            cmbTenLoaiBenh.ValueMember = "maLoaiBenh";
            cmbTenLoaiBenh.SelectedIndex = 0;
        }

        private void LoadDanhSachLoaiThuoc()
        {
            List<DTO_LoaiThuoc> danhSach = BUS_LoaiThuoc.LayDanhSachLoaiThuoc();
            danhSach.Insert(0, new DTO_LoaiThuoc { maLoaiThuoc = "", tenLoaiThuoc = "" });

            cmbTenLoaiThuoc.DataSource = danhSach;
            cmbTenLoaiThuoc.DisplayMember = "tenLoaiThuoc";
            cmbTenLoaiThuoc.ValueMember = "maLoaiThuoc";
            cmbTenLoaiThuoc.SelectedIndex = 0;
        }

        private void LoadDanhSachPhieuKham()
        {
            List<DTO_KhamBenh> danhSach = BUS_KhamBenh.LayDanhSachKhamBenh();
            danhSach.Insert(0, new DTO_KhamBenh { maKhamBenh = "" });

            cmbMaPhieuKhamTu.DataSource = danhSach;
            cmbMaPhieuKhamTu.DisplayMember = "maKhamBenh";
            cmbMaPhieuKhamTu.ValueMember = "maKhamBenh";
            cmbMaPhieuKhamTu.SelectedIndex = 0;
        }

        private void HienThiKetQua(List<DTO_BenhNhanTraCuu> danhSach)
        {
            // Set AutoGenerateColumns to false since you're using predefined columns
            dgvKetQua.AutoGenerateColumns = false;

            // Map your data properties to the corresponding columns
            dgvKetQua.Columns["MaBenhNhan"].DataPropertyName = "MaBenhNhan";
            dgvKetQua.Columns["TenBenhNhan"].DataPropertyName = "HoTen";
            dgvKetQua.Columns["GioiTinh"].DataPropertyName = "GioiTinh";
            dgvKetQua.Columns["NamSinh"].DataPropertyName = "NamSinh";
            dgvKetQua.Columns["DiaChi"].DataPropertyName = "DiaChi";
            dgvKetQua.Columns["NgayKham"].DataPropertyName = "NgayKham";
            dgvKetQua.Columns["TrieuChung"].DataPropertyName = "TrieuChung";
            dgvKetQua.Columns["TenLoaiBenh"].DataPropertyName = "TenLoaiBenh";

            // Clear and set the data source
            dgvKetQua.DataSource = null;
            dgvKetQua.DataSource = danhSach;

            // Auto-increment STT column
            for (int i = 0; i < dgvKetQua.Rows.Count; i++)
            {
                dgvKetQua.Rows[i].Cells["STT"].Value = (i + 1).ToString();
            }

            // Format date column
            dgvKetQua.Columns["NgayKham"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // IMPORTANT: Resize the DataGridView to show results
            // Adjust the height based on number of results (with a minimum and maximum)
            int rowHeight = dgvKetQua.RowTemplate.Height;
            int headerHeight = dgvKetQua.ColumnHeadersHeight;
            int desiredRows = Math.Min(danhSach.Count, 10); // Show up to 10 rows
            int newHeight = headerHeight + (rowHeight * desiredRows) + 2; // +2 for border

            // Set minimum height even for empty results to show headers
            newHeight = Math.Max(newHeight, headerHeight + rowHeight + 2);

            // Resize the DataGridView
            dgvKetQua.Height = newHeight;

            // Ensure the DataGridView is not positioned too low on the form
            if (dgvKetQua.Bottom > btnTraCuuBenhNhan.Top - 10)
            {
                // If too low, adjust button positions down if needed
                int shift = dgvKetQua.Bottom - btnTraCuuBenhNhan.Top + 10;
                btnTraCuuBenhNhan.Top += shift;
                btnCancel.Top += shift;
            }

            // Set display properties
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.ReadOnly = true;
            dgvKetQua.AllowUserToAddRows = false;
        }

        private void btnTraCuuBenhNhan_Click(object sender, EventArgs e)
        {
            int? namSinhTu = (numericNamSinhTu.Value > 0) ? (int?)numericNamSinhTu.Value : null;
            int? namSinhDen = (numericNamSinhDen.Value > 0) ? (int?)numericNamSinhDen.Value : null;
            List<DTO_BenhNhanTraCuu> ketQua = BUS_TraCuu.LayDanhSachBenhNhanTraCuu(txtMaBenhNhan.Text, txtHoTen.Text,
                txtGioiTinh.Text, txtDiaChi.Text, txtTrieuChung.Text, cmbTenLoaiBenh.SelectedValue?.ToString() ?? "",
                dtpNgayKhamTu.Checked ? dtpNgayKhamTu.Value : (DateTime?)null,
                dtpNgayKhamDen.Checked ? dtpNgayKhamDen.Value : (DateTime?)null,
                namSinhTu, namSinhDen,
                cmbMaPhieuKhamTu.SelectedValue?.ToString() ?? "",
                cmbMaPhieuKhamDen.SelectedValue?.ToString() ?? "",
                cmbTenLoaiThuoc.SelectedValue?.ToString() ?? "",
                cmbDonVi.SelectedValue?.ToString() ?? ""
                );
            MessageBox.Show($"Tìm thấy {ketQua.Count} kết quả");
            HienThiKetQua(ketQua);
        }
    }
}
