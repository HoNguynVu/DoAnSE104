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
        }

        private void GUI_LapPhieuKhamBenh_Load(object sender, EventArgs e)
        {
            LoadDanhSachLoaiBenh();
            LoadDanhSachLoaiThuoc();
            
            
            // Reset tất cả ComboBox về trạng thái trống
            selectLoaiBenh.SelectedIndex = -1;
        }

        private void LoadDanhSachLoaiBenh()
        {
            selectLoaiBenh.DataSource = BUS_LoaiBenh.LayDanhSachLoaiBenh();
            selectLoaiBenh.DisplayMember = "tenLoaiBenh";
            selectLoaiBenh.ValueMember = "maLoaiBenh";
        }

        private void LoadDanhSachLoaiThuoc()
        {
            List<DTO_LoaiThuoc> danhSachLoaiThuoc = BUS_LoaiThuoc.LayDanhSachLoaiThuoc();
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
                // Thêm phiếu khám bệnh
                if (BUS_KhamBenh.CapNhatKhamBenh(txtMaKB.Text.Trim(), selectLoaiBenh.SelectedValue.ToString(), txtTrieuChung.Text.Trim()))
                {
                    // Lưu chi tiết thuốc nếu có
                    bool success = true;

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
                            selectLoaiBenh.SelectedIndex = -1;
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