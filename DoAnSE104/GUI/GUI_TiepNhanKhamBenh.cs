﻿using System;
using System.Windows.Forms;
using DoAnSE104.BUS;
using DoAnSE104.DTO;

namespace DoAnSE104.GUI
{
    public partial class GUI_TiepNhanKhamBenh: Form
    {
        BUS_KhamBenh BUS_KhamBenh = new BUS_KhamBenh();
        BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();
        BUS_ThamSo BUS_ThamSo = new BUS_ThamSo();
        private GUI_Home homeForm;
        public GUI_TiepNhanKhamBenh()
        {
            InitializeComponent();
                        
        }
        public GUI_TiepNhanKhamBenh(GUI_Home home)
        {
            InitializeComponent();
            this.homeForm = home;
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Khi chọn ngày trên lịch, cập nhật giá trị vào textBox ngày khám
            txtNgayKham.Text = e.Start.ToString("dd/MM/yyyy");
            
        }

        private void pictureBoxToggleCalendar_Click_1(object sender, EventArgs e)
        {
            monthCalendar1.Visible = !monthCalendar1.Visible;

            if (monthCalendar1.Visible)
            {
                pictureBoxToggleCalendar.Image = Properties.Resources.calendar;
            }
            else
            {
                pictureBoxToggleCalendar.Image = Properties.Resources.calendar;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Visible = false;
        }
        private void LayMaKhamBenhMoi()
        {
            txtMaKhamBenh.Text = BUS_KhamBenh.LayMaKhamBenhMoi();
        }
        private void GUI_TiepNhanKhamBenh_Load(object sender, EventArgs e)
        {
            LayMaKhamBenhMoi();
            DateTime today = DateTime.Today;
            monthCalendar1.SelectionStart = today;
            txtNgayKham.Text = today.ToString("dd/MM/yyyy");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GUI_TiepNhanBenhNhan guiTiepNhanBenhNhan = new GUI_TiepNhanBenhNhan(homeForm);
            homeForm.ShowFormInMainPanel(guiTiepNhanBenhNhan);
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaBenhNhan.Text) || string.IsNullOrWhiteSpace(txtNgayKham.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DTO_KhamBenh newKhamBenh = new DTO_KhamBenh(
                txtMaKhamBenh.Text.Trim(),
                monthCalendar1.SelectionStart,
                txtMaBenhNhan.Text.Trim()
            );
            DateTime ngayKham = monthCalendar1.SelectionStart;

            if (BUS_ThamSo.QuyDinhSoLuongBenhNhanToiDaTrongNgay())
            {
                int soLuongHienTai = BUS_KhamBenh.LaySoLuongBenhNhanHienTaiTrongNgay(ngayKham);
                int gioiHanToiDa = BUS_ThamSo.SoLuongBenhNhanToiDaTrongNgay();
                if (soLuongHienTai >= gioiHanToiDa)
                {
                    MessageBox.Show(
                        $"Đã đạt giới hạn {gioiHanToiDa} bệnh nhân trong ngày {ngayKham:dd/MM/yyyy}. Vui lòng thử lại sau.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }

            try
            {
                if (BUS_KhamBenh.ThemKhamBenh(newKhamBenh))
                {
                    MessageBox.Show("Tiếp nhận khám bệnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Tiếp nhận khám bệnh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtMaBenhNhan_TextChanged(object sender, EventArgs e)
        {
            string maBenhNhan = txtMaBenhNhan.Text.Trim();

            if (!string.IsNullOrEmpty(maBenhNhan))
            {
                DTO_BenhNhan benhNhan = BUS_BenhNhan.LayThongTinBenhNhan(maBenhNhan);
                if (benhNhan != null)
                {
                    txtHoTen.Text = benhNhan.hoTen;
                    txtGioiTinh.Text = benhNhan.gioiTinh;
                    txtNamSinh.Text = benhNhan.namSinh.ToString();
                    txtDiaChi.Text = benhNhan.diaChi;

                    // Xóa thông báo lỗi nếu có
                    errorProvider1.SetError(txtMaBenhNhan, "");
                }
                else
                {
                    // Hiển thị lỗi bằng ErrorProvider
                    errorProvider1.SetError(txtMaBenhNhan, "Bệnh nhân không tồn tại.");
                    // Xóa thông tin hiển thị nếu không tìm thấy
                    txtHoTen.Text = "";
                    txtGioiTinh.Text = "";
                    txtNamSinh.Text = "";
                    txtDiaChi.Text = "";
                }
            }
            else
            {
                errorProvider1.SetError(txtMaBenhNhan, "Vui lòng nhập mã bệnh nhân.");
            }
        }
        private void ResetForm()
        {
            // Reset các TextBox về rỗng hoặc mặc định
            LayMaKhamBenhMoi();
            // Nếu có mã tự sinh
            txtMaBenhNhan.Clear();
            txtHoTen.Clear();
            txtGioiTinh.Clear();
            txtNamSinh.Clear();
            txtDiaChi.Clear();

            // Đặt ngày khám là hôm nay
            DateTime today = DateTime.Today;
            txtNgayKham.Text = today.ToString("dd/MM/yyyy");
            monthCalendar1.SelectionStart = today;

            // Ẩn lịch
            monthCalendar1.Visible = false;

            // Reset lỗi nếu có
            errorProvider1.Clear();

            // Có thể khóa các TextBox nếu muốn
            txtHoTen.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtNamSinh.Enabled = false;
            txtDiaChi.Enabled = false;
        }

    }
}
