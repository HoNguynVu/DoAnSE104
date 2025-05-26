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
        private BUS_KhamBenh BUS_KhamBenh = new BUS_KhamBenh();
        private BUS_LoaiThuoc BUS_LoaiThuoc = new BUS_LoaiThuoc();
        private BUS_LoaiBenh BUS_LoaiBenh = new BUS_LoaiBenh();
        private BUS_CTKhamBenh BUS_CTKhamBenh = new BUS_CTKhamBenh();
        private BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();

        public GUI_LapPhieuKhamBenh()
        {
            InitializeComponent();
            // Thiết lập các giá trị mặc định cho các TextBox
            this.textBox4.Text = "1";
            this.textBox7.Text = "2";
            this.textBox12.Text = "3";
        }

        private void GUI_LapPhieuKhamBenh_Load(object sender, EventArgs e)
        {
            LoadDanhSachLoaiBenh();
            LoadDanhSachLoaiThuoc();
            
            
            // Reset tất cả ComboBox về trạng thái trống
            cbLoaiBenh.SelectedIndex = -1;
            cbLoaiThuoc1.SelectedIndex = -1;
            cbLoaiThuoc2.SelectedIndex = -1;
            cbLoaiThuoc3.SelectedIndex = -1;
        }

        private void LoadDanhSachLoaiBenh()
        {
            cbLoaiBenh.DataSource = BUS_LoaiBenh.LayDanhSachLoaiBenh();
            cbLoaiBenh.DisplayMember = "tenLoaiBenh";
            cbLoaiBenh.ValueMember = "maLoaiBenh";
        }

        private void LoadDanhSachLoaiThuoc()
        {
            List<DTO_LoaiThuoc> danhSachLoaiThuoc = BUS_LoaiThuoc.LayDanhSachLoaiThuoc();
            cbLoaiThuoc1.DataSource = new List<DTO_LoaiThuoc>(danhSachLoaiThuoc);
            cbLoaiThuoc1.DisplayMember = "tenLoaiThuoc";
            cbLoaiThuoc1.ValueMember = "maLoaiThuoc";

            cbLoaiThuoc2.DataSource = new List<DTO_LoaiThuoc>(danhSachLoaiThuoc);
            cbLoaiThuoc2.DisplayMember = "tenLoaiThuoc";
            cbLoaiThuoc2.ValueMember = "maLoaiThuoc";

            cbLoaiThuoc3.DataSource = new List<DTO_LoaiThuoc>(danhSachLoaiThuoc);
            cbLoaiThuoc3.DisplayMember = "tenLoaiThuoc";
            cbLoaiThuoc3.ValueMember = "maLoaiThuoc";
        }

        private void btnLapPK_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtMaKB.Text) ||
                string.IsNullOrWhiteSpace(txtTrieuChung.Text) ||
                cbLoaiBenh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {  
                // Thêm phiếu khám bệnh
                if (BUS_KhamBenh.CapNhatKhamBenh(txtMaKB.Text.Trim(), cbLoaiBenh.SelectedValue.ToString(), txtTrieuChung.Text.Trim()))
                {
                    // Lưu chi tiết thuốc nếu có
                    bool success = true;

                    // Thuốc 1
                    if (cbLoaiThuoc1.SelectedValue != null && !string.IsNullOrEmpty(txtSLThuoc1.Text))
                    {
                        success &= ThemChiTietThuoc(txtMaKB.Text, cbLoaiThuoc1.SelectedValue.ToString(), txtSLThuoc1.Text);
                    }

                    // Thuốc 2
                    if (cbLoaiThuoc2.SelectedValue != null && !string.IsNullOrEmpty(txtSLThuoc2.Text))
                    {
                        success &= ThemChiTietThuoc(txtMaKB.Text, cbLoaiThuoc2.SelectedValue.ToString(), txtSLThuoc2.Text);
                    }

                    // Thuốc 3
                    if (cbLoaiThuoc3.SelectedValue != null && !string.IsNullOrEmpty(txtSLThuoc3.Text))
                    {
                        success &= ThemChiTietThuoc(txtMaKB.Text, cbLoaiThuoc3.SelectedValue.ToString(), txtSLThuoc3.Text);
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
            cbLoaiBenh.SelectedIndex = -1;

            cbLoaiThuoc1.SelectedIndex = -1;
            cbLoaiThuoc2.SelectedIndex = -1;
            cbLoaiThuoc3.SelectedIndex = -1;

            txtSLThuoc1.Clear();
            txtSLThuoc2.Clear();
            txtSLThuoc3.Clear();

            txtDonVi1.Clear();
            txtDonVi2.Clear();
            txtDonVi3.Clear();

            txtCachDung1.Clear();
            txtCachDung2.Clear();
            txtCachDung3.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLoaiThuoc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiThuoc1.SelectedItem != null)
            {
                DTO_LoaiThuoc loaiThuoc = cbLoaiThuoc1.SelectedItem as DTO_LoaiThuoc;
                string tenDonVi = BUS_LoaiThuoc.LayTenDonVi(loaiThuoc.maDonVi);
                string tenCachDung = BUS_LoaiThuoc.LayTenCachDung(loaiThuoc.maCachDung);

                txtDonVi1.Text = tenDonVi;
                txtCachDung1.Text = tenCachDung;
            }
            else
            {
                txtDonVi1.Text = "";
                txtCachDung1.Text = "";
            }
        }

        private void cbLoaiThuoc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiThuoc2.SelectedItem != null)
            {
                DTO_LoaiThuoc loaiThuoc = cbLoaiThuoc2.SelectedItem as DTO_LoaiThuoc;
                string tenDonVi = BUS_LoaiThuoc.LayTenDonVi(loaiThuoc.maDonVi);
                string tenCachDung = BUS_LoaiThuoc.LayTenCachDung(loaiThuoc.maCachDung);

                txtDonVi2.Text = tenDonVi;
                txtCachDung2.Text = tenCachDung;
            }
            else
            {
                txtDonVi2.Text = "";
                txtCachDung2.Text = "";
            }
        }

        private void cbLoaiThuoc3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiThuoc3.SelectedItem != null)
            {
                DTO_LoaiThuoc loaiThuoc = cbLoaiThuoc3.SelectedItem as DTO_LoaiThuoc;
                string tenDonVi = BUS_LoaiThuoc.LayTenDonVi(loaiThuoc.maDonVi);
                string tenCachDung = BUS_LoaiThuoc.LayTenCachDung(loaiThuoc.maCachDung);

                txtDonVi3.Text = tenDonVi;
                txtCachDung3.Text = tenCachDung;
            }
            else
            {
                txtDonVi3.Text = "";
                txtCachDung3.Text = "";
            }
        }

        // Validation chỉ cho phép nhập số cho số lượng thuốc
        private void txtSLThuoc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSLThuoc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSLThuoc3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
                        // Hiển thị ngày khám
                        txtNK.Text = khamBenh.ngayKham.ToString("dd/MM/yyyy");

                        // Lấy và hiển thị tên bệnh nhân
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
                            // Hiển thị lỗi bằng ErrorProvider
                            errorProvider1.SetError(txtMaKB, "Mã khám bệnh không tồn tại");
                            // Xóa các thông tin hiển thị
                            txtNK.Text = "";
                            txtTrieuChung.Text = "";
                            cbLoaiBenh.SelectedIndex = -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Xóa thông tin hiển thị nếu mã khám bệnh trống
                txtNK.Text = "";
                errorProvider1.SetError(txtMaKB, "Vui lòng nhập mã khám bệnh.");
            }
        }
        
    }
}