using DoAnSE104.BUS;
using System;
using System.Windows.Forms;

namespace DoAnSE104.GUI
{
    public partial class GUI_DanhSachThamSo : Form
    {
        BUS_ThamSo BUS_ThamSo = new BUS_ThamSo();
        public GUI_DanhSachThamSo()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                txtSoLuongBenhNhanToiDaTrongNgay.Text = BUS_ThamSo.SoLuongBenhNhanToiDaTrongNgay().ToString();
                txtTienKhamCoDinh.Text = BUS_ThamSo.TienKhamCoDinh().ToString("F4");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void QuyDinhSoLuongBenhNhanToiDaTrongNgay_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (QuyDinhSoLuongBenhNhanToiDaTrongNgay.Checked)
                {
                    // Enable the text box and load the old value
                    txtSoLuongBenhNhanToiDaTrongNgay.Enabled = true;
                    int oldValue = BUS_ThamSo.SoLuongBenhNhanToiDaTrongNgay();
                    txtSoLuongBenhNhanToiDaTrongNgay.Text = oldValue.ToString();
                }
                else
                {
                    // Disable the text box and clear its value
                    txtSoLuongBenhNhanToiDaTrongNgay.Enabled = false;
                    txtSoLuongBenhNhanToiDaTrongNgay.Text = BUS_ThamSo.SoLuongBenhNhanToiDaTrongNgay().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý quy định số lượng bệnh nhân: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuyDinhTienKhamCoDinh_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (QuyDinhTienKhamCoDinh.Checked)
                {
                    // Enable the text box and load the old value
                    txtTienKhamCoDinh.Enabled = true;
                    double oldValue = BUS_ThamSo.TienKhamCoDinh();
                    txtTienKhamCoDinh.Text = oldValue.ToString("F4");
                }
                else
                {
                    // Disable the text box and clear its value
                    txtTienKhamCoDinh.Enabled = false;
                    txtTienKhamCoDinh.Text = BUS_ThamSo.TienKhamCoDinh().ToString("F4");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý quy định tiền khám cố định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string slbn = txtSoLuongBenhNhanToiDaTrongNgay.Text.Trim();
                string tien = txtTienKhamCoDinh.Text.Trim();
                int soLuongBenhNhan = int.Parse(txtSoLuongBenhNhanToiDaTrongNgay.Text);
                double tienKhamCoDinh = double.Parse(txtTienKhamCoDinh.Text);
                if (QuyDinhSoLuongBenhNhanToiDaTrongNgay.Checked)
                {
                    if (string.IsNullOrEmpty(slbn))
                    {
                        MessageBox.Show("Vui lòng nhập số lượng bệnh nhân");
                        return;
                    }
                    if(soLuongBenhNhan <= 0)
                    {
                        MessageBox.Show("Số lượng bệnh nhân phải lớn hơn 0");
                        return;
                    }
                    BUS_ThamSo.updateSoLuongBenhNhanToiDaTrongNgay(soLuongBenhNhan);
                }
                if (QuyDinhTienKhamCoDinh.Checked)
                {
                    if (string.IsNullOrEmpty(tien))
                    {
                        MessageBox.Show("Vui lòng tiền khám cố định");
                        return;
                    }
                    if(tienKhamCoDinh <= 1000)
                    {
                        MessageBox.Show("Tiền khám cố định phải lớn hơn 1000");
                        return;
                    }
                    BUS_ThamSo.updateTienKhamCoDinh(tienKhamCoDinh);
                }

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoLuongBenhNhanToiDaTrongNgay_TextChanged(object sender, EventArgs e)
        {
            txtSoLuongBenhNhanToiDaTrongNgay.Text = txtSoLuongBenhNhanToiDaTrongNgay.Text.Trim();
        }

        private void txtTienKhamCoDinh_TextChanged(object sender, EventArgs e)
        {
            txtTienKhamCoDinh.Text = txtTienKhamCoDinh.Text.Trim();
        }
    }
}
