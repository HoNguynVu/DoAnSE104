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
            txtTienKham.Text = "30000";
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

            var khamBenh = busKhamBenh.LayThongTinKhamBenh(maKhamBenh);
            if (khamBenh == null)
            {
                errorProvider1.SetError(txtMaKhamBenh, "Mã phiếu khám không tồn tại.");
                MessageBox.Show("Mã phiếu khám không tồn tại. Vui lòng nhập lại.", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhamBenh.Focus();
                return;
            }

            try
            {
                double tienKham = 30000;
                double tienThuoc = busHoaDon.TinhTienThuoc(maKhamBenh);
                double tongTien = tienKham + tienThuoc;

                string maHoaDon = busHoaDon.LayMaHoaDonMoi();
                DTO_HoaDon hoaDon = new DTO_HoaDon(maHoaDon, tienKham, tienThuoc, maKhamBenh);

                if (busHoaDon.LapHoaDon(hoaDon))
                {
                    txtTienThuoc.Text = tienThuoc.ToString("N0");
                    MessageBox.Show("Lập hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // Nếu không nhập gì thì xóa dữ liệu và hiện lỗi qua ErrorProvider
            if (string.IsNullOrEmpty(maKhamBenh))
            {
                ClearThongTinHoaDon();
                errorProvider1.SetError(txtMaKhamBenh, "Vui lòng nhập mã khám bệnh.");
                return;
            }

            try
            {
                var khamBenh = busKhamBenh.LayThongTinKhamBenh(maKhamBenh);

                if (khamBenh != null && !string.IsNullOrEmpty(khamBenh.maBenhNhan))
                {
                    var benhNhan = busBenhNhan.LayThongTinBenhNhan(khamBenh.maBenhNhan);

                    txtTenBenhNhan.Text = benhNhan?.hoTen ?? "Không rõ";
                    txtNgayKham.Text = khamBenh.ngayKham.ToString("dd/MM/yyyy");
                    txtTienKham.Text = "30000";

                    double tienThuoc = busHoaDon.TinhTienThuoc(maKhamBenh);
                    txtTienThuoc.Text = tienThuoc.ToString("N0");

                    HienThiChiTietThuoc(maKhamBenh);

                    errorProvider1.SetError(txtMaKhamBenh, ""); // Xóa lỗi nếu có
                }
                else
                {
                    ClearThongTinHoaDon();
                    errorProvider1.SetError(txtMaKhamBenh, "Mã khám bệnh không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearThongTinHoaDon()
        {
            txtTenBenhNhan.Text = "";
            txtNgayKham.Text = "";
            txtTienKham.Text = "";
            txtTienThuoc.Text = "";
            dataGridView1.DataSource = null;
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

    }
}
