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
    public partial class GUI_LapHoaDon : Form
    {
        private BUS_ThamSo busThamSo = new BUS_ThamSo();
        private BUS_HoaDon busHoaDon = new BUS_HoaDon();
        private BUS_KhamBenh busKhamBenh = new BUS_KhamBenh();
        private BUS_BenhNhan busBenhNhan = new BUS_BenhNhan();

        public GUI_LapHoaDon()
        {
            InitializeComponent();
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

        private void GUI_LapHoaDon_Load(object sender, EventArgs e)
        {
            CauHinhTienKham();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            string maKhamBenh = txtMaKhamBenh.Text.Trim();

            if (string.IsNullOrEmpty(maKhamBenh))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu khám.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhamBenh.Focus();
                return;
            }

            //Kiểm tra tiền khám có bị bỏ trống
            if (string.IsNullOrWhiteSpace(txtTienKham.Text))
            {
                MessageBox.Show("Không được để trống tiền khám.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienKham.Focus();
                return;
            }

            var khamBenh = busKhamBenh.LayThongTinKhamBenh(maKhamBenh);
            if (khamBenh == null)
            {
                errorProvider1.SetError(txtMaKhamBenh, "Mã phiếu khám không tồn tại.");
                MessageBox.Show("Mã phiếu khám không tồn tại. Vui lòng nhập lại.", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhamBenh.Focus();
                return;
            }

            //Kiểm tra mã khám bệnh đã có hóa đơn chưa
            var hoaDonDaCo = busHoaDon.LayHoaDonTheoMaKhamBenh(maKhamBenh);
            if (hoaDonDaCo != null)
            {
                MessageBox.Show("Mã khám bệnh này đã có hóa đơn. Vui lòng kiểm tra lại.", "Trùng hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                double tienKham = Convert.ToDouble(txtTienKham.Text);
                double tienThuoc = busHoaDon.TinhTienThuoc(maKhamBenh);
                double tongTien = tienKham + tienThuoc;

                string maHoaDon = busHoaDon.LayMaHoaDonMoi();
                DTO_HoaDon hoaDon = new DTO_HoaDon(maHoaDon, tienKham, tienThuoc, maKhamBenh);

                if (busHoaDon.LapHoaDon(hoaDon))
                {
                    txtTienThuoc.Text = tienThuoc.ToString("N0");
                    MessageBox.Show("Lập hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hiển thị mã hóa đơn mới
                    txtMaHoaDon.Text = maHoaDon;
                    txtMaHoaDon.Visible = true;
                    label7.Visible = true;
                }
                else
                {
                    MessageBox.Show("Lập hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lập hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaKhamBenh_TextChanged(object sender, EventArgs e)
        {
            string maKhamBenh = txtMaKhamBenh.Text.Trim();

            if (string.IsNullOrEmpty(maKhamBenh))
            {
                ClearThongTinHoaDon(clearMaHoaDon: true); // Vẫn xóa hết nếu textbox trống
                errorProvider1.SetError(txtMaKhamBenh, "Vui lòng nhập mã khám bệnh.");
                return;
            }

            try
            {
                var khamBenh = busKhamBenh.LayThongTinKhamBenh(maKhamBenh);

                if (khamBenh != null && !string.IsNullOrEmpty(khamBenh.maBenhNhan))
                {
                    // ko xóa mã hóa đơn ở đây
                    ClearThongTinHoaDon(clearMaHoaDon: false);

                    var benhNhan = busBenhNhan.LayThongTinBenhNhan(khamBenh.maBenhNhan);

                    txtTenBenhNhan.Text = benhNhan?.hoTen ?? "Không rõ";
                    txtNgayKham.Text = khamBenh.ngayKham.ToString("dd/MM/yyyy");

                    var thamSo = busThamSo.LayThamSo();

                    if (thamSo != null && thamSo.quyDinhTienKhamCoDinh)
                    {
                        txtTienKham.ReadOnly = true;
                        txtTienKham.BackColor = Color.LightGray;
                        txtTienKham.Text = thamSo.tienKhamCoDinh.ToString("N0");
                    }
                    else
                    {
                        txtTienKham.ReadOnly = false;
                        txtTienKham.BackColor = Color.White;
                        txtTienKham.Text = "0";
                    }

                    double tienThuoc = busHoaDon.TinhTienThuoc(maKhamBenh);
                    txtTienThuoc.Text = tienThuoc.ToString("N0");

                    HienThiChiTietThuoc(maKhamBenh);

                    errorProvider1.SetError(txtMaKhamBenh, "");
                }
                else
                {
                    ClearThongTinHoaDon(clearMaHoaDon: true);
                    errorProvider1.SetError(txtMaKhamBenh, "Mã khám bệnh không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearThongTinHoaDon(bool clearMaHoaDon = true)
        {
            txtTenBenhNhan.Text = "";
            txtNgayKham.Text = "";
            txtTienKham.Text = "";
            txtTienThuoc.Text = "";
            dataGridView1.DataSource = null;

            if (clearMaHoaDon)
            {
                txtMaHoaDon.Text = "";
                txtMaHoaDon.Visible = false;
                label7.Visible = false;
            }

            errorProvider1.SetError(txtMaKhamBenh, "");
        }
        private void HienThiChiTietThuoc(string maKhamBenh)
        {
            dataGridView1.AutoGenerateColumns = false;

            DataTable dt = busHoaDon.LayChiTietThuocTheoMaKhamBenh(maKhamBenh);

            // Kiểm tra và thêm cột Thành Tiền nếu chưa có
            if (!dt.Columns.Contains("ThanhTien"))
            {
                dt.Columns.Add("ThanhTien", typeof(double));
                foreach (DataRow row in dt.Rows)
                {
                    try
                    {
                        int soLuong = Convert.ToInt32(row["SoLuongThuoc"]);
                        double donGia = Convert.ToDouble(row["DonGia"]);
                        row["ThanhTien"] = soLuong * donGia;
                    }
                    catch
                    {
                        row["ThanhTien"] = 0;
                    }
                }
            }

            dataGridView1.DataSource = dt;
        }

        private void btnHDMoi_Click(object sender, EventArgs e)
        {
            // Xóa toàn bộ dữ liệu, bao gồm cả mã hóa đơn
            txtMaKhamBenh.Text = "";
            ClearThongTinHoaDon(clearMaHoaDon: true);

            txtMaKhamBenh.Enabled = true;
            txtMaKhamBenh.Focus();
        }

        private void btnTimHD_Click(object sender, EventArgs e)
        {
            string maKhamBenh = txtMaKhamBenh.Text.Trim();
            if (string.IsNullOrEmpty(maKhamBenh))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu khám để tìm hóa đơn.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var hoaDon = busHoaDon.LayHoaDonTheoMaKhamBenh(maKhamBenh);
                if (hoaDon != null)
                {
                    // Hiển thị thông tin
                    txtMaHoaDon.Text = hoaDon.maHoaDon;
                    txtTienKham.Text = hoaDon.tienKham.ToString("N0");
                    txtTienThuoc.Text = hoaDon.tienThuoc.ToString("N0");

                    // Hiển thị thêm label + textbox Mã Hóa Đơn
                    label7.Visible = true;
                    txtMaHoaDon.Visible = true;

                    // Hiển thị các thông tin bệnh nhân như khi lập hóa đơn
                    var khamBenh = busKhamBenh.LayThongTinKhamBenh(maKhamBenh);
                    if (khamBenh != null && !string.IsNullOrEmpty(khamBenh.maBenhNhan))
                    {
                        var benhNhan = busBenhNhan.LayThongTinBenhNhan(khamBenh.maBenhNhan);
                        txtTenBenhNhan.Text = benhNhan?.hoTen ?? "Không rõ";
                        txtNgayKham.Text = khamBenh.ngayKham.ToString("dd/MM/yyyy");
                    }

                    // Hiện chi tiết thuốc
                    HienThiChiTietThuoc(maKhamBenh);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn với mã khám bệnh này.", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CauHinhTienKham()
        {
            var thamSo = busThamSo.LayThamSo();
            MessageBox.Show($"QuyDinhTienKhamCoDinh = {thamSo?.quyDinhTienKhamCoDinh}");

            if (thamSo != null && thamSo.quyDinhTienKhamCoDinh)
            {
                txtTienKham.ReadOnly = true;
                txtTienKham.BackColor = Color.LightGray;
                txtTienKham.Text = thamSo.tienKhamCoDinh.ToString("N0");
            }
            else
            {
                txtTienKham.ReadOnly = false;
                txtTienKham.BackColor = Color.White;
                txtTienKham.Text = "0";
            }
        }

        private void txtTienKham_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím điều khiển (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // chặn ký tự không hợp lệ
            }
        }
    }
}
