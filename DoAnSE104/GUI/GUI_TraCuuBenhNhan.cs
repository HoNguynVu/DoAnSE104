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
        private GUI_Home homeForm;

        private BUS_KhamBenh BUS_KhamBenh = new BUS_KhamBenh();
        private BUS_LoaiThuoc BUS_LoaiThuoc = new BUS_LoaiThuoc();
        private BUS_LoaiBenh BUS_LoaiBenh = new BUS_LoaiBenh();
        private BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();
        private BUS_TraCuu BUS_TraCuu = new BUS_TraCuu();
        public GUI_TraCuuBenhNhan()
        {
            InitializeComponent();
            KhoiTaoDtp();
        }
        public GUI_TraCuuBenhNhan(GUI_Home home)
        {
            InitializeComponent();
            this.homeForm = home;
        }

        private void KhoiTaoDtp()
        {
            dtpNgayKhamTu.Format = DateTimePickerFormat.Custom;
            dtpNgayKhamTu.CustomFormat = "dd/MM/yyyy";
            dtpNgayKhamTu.MaxDate = DateTime.Now;
            dtpNgayKhamTu.MinDate = new DateTime(1900, 1, 1);

            dtpNgayKhamTu.KeyPress += (s, e) => e.Handled = true; // chặn gõ bàn phím

            dtpNgayKhamDen.Format = DateTimePickerFormat.Custom;
            dtpNgayKhamDen.CustomFormat = "dd/MM/yyyy";
            dtpNgayKhamDen.MaxDate = DateTime.Now;
            dtpNgayKhamDen.MinDate = new DateTime(1900, 1, 1);

            dtpNgayKhamDen.KeyPress += (s, e) => e.Handled = true;

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
            LoadDanhSachDonVi();
        }
        private void LoadDanhSachLoaiBenh()
        {
            List<DTO_LoaiBenh> danhSach = BUS_LoaiBenh.LayDanhSachLoaiBenh();
            danhSach.Insert(0, new DTO_LoaiBenh { maLoaiBenh ="", tenLoaiBenh = ""});

            cbbTenLoaiBenh.DataSource = danhSach;
            cbbTenLoaiBenh.DisplayMember = "tenLoaiBenh";
            cbbTenLoaiBenh.ValueMember = "maLoaiBenh";
            cbbTenLoaiBenh.SelectedIndex = 0;
        }

        private void LoadDanhSachLoaiThuoc()
        {
            List<DTO_LoaiThuoc> danhSach = BUS_LoaiThuoc.LayDanhSachLoaiThuoc();
            danhSach.Insert(0, new DTO_LoaiThuoc { maLoaiThuoc = "", tenLoaiThuoc = "" });

            cbbTenLoaiThuoc.DataSource = danhSach;
            cbbTenLoaiThuoc.DisplayMember = "tenLoaiThuoc";
            cbbTenLoaiThuoc.ValueMember = "maLoaiThuoc";
            cbbTenLoaiThuoc.SelectedIndex = 0;
        }
        private void LoadDanhSachDonVi()
        {
            List<DTO_DonVi> danhSach = BUS_LoaiThuoc.LayDanhSachDonVi();
            danhSach.Insert(0, new DTO_DonVi ("",""));

            cbbDonVi.DataSource = danhSach;
            cbbDonVi.DisplayMember = "tenDonVi";
            cbbDonVi.ValueMember = "maDonVi";
            cbbDonVi.SelectedIndex = 0;
        }

        private void LoadDanhSachPhieuKham()
        {
            List<DTO_KhamBenh> danhSach = BUS_KhamBenh.LayDanhSachKhamBenh();
            danhSach.Insert(0, new DTO_KhamBenh { maKhamBenh = "" });

            cbbMaPhieuKhamTu.DataSource = danhSach;
            cbbMaPhieuKhamTu.DisplayMember = "maKhamBenh";
            cbbMaPhieuKhamTu.ValueMember = "maKhamBenh";
            cbbMaPhieuKhamTu.SelectedIndex = 0;

            List<DTO_KhamBenh> danhSachDen = BUS_KhamBenh.LayDanhSachKhamBenh();
            danhSachDen.Insert(0, new DTO_KhamBenh { maKhamBenh = "" });
            cbbMaPhieuKhamDen.DataSource = danhSachDen;
            cbbMaPhieuKhamDen.DisplayMember = "maKhamBenh";
            cbbMaPhieuKhamDen.ValueMember = "maKhamBenh";
            cbbMaPhieuKhamDen.SelectedIndex = 0;
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
                txtGioiTinh.Text, txtDiaChi.Text, txtTrieuChung.Text, cbbTenLoaiBenh.SelectedValue?.ToString() ?? "",
                dtpNgayKhamTu.Checked ? dtpNgayKhamTu.Value : (DateTime?)null,
                dtpNgayKhamDen.Checked ? dtpNgayKhamDen.Value : (DateTime?)null,
                namSinhTu, namSinhDen,
                cbbMaPhieuKhamTu.SelectedValue?.ToString() ?? "",
                cbbMaPhieuKhamDen.SelectedValue?.ToString() ?? "",
                cbbTenLoaiThuoc.SelectedValue?.ToString() ?? "",
                cbbDonVi.SelectedValue?.ToString() ?? ""
                );
            MessageBox.Show($"Tìm thấy {ketQua.Count} kết quả");
            HienThiKetQua(ketQua);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
