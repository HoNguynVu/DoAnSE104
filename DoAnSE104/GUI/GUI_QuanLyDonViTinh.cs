using DoAnSE104.BUS;
using DoAnSE104.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnSE104.GUI
{
    public partial class GUI_QuanLyDonViTinh : Form
    {
        private List<DTO_DonVi> danhSachCanXoa = new List<DTO_DonVi>();
        private List<DTO_DonVi> danhSachTam = new List<DTO_DonVi>();
        BUS_DonVi BUS_DonVi = new BUS_DonVi();
        public GUI_QuanLyDonViTinh()
        {
            InitializeComponent();
            SetupDataGridView();
        }
        private void SetupDataGridView()
        {
            dgvDanhSachDonVi.AllowUserToAddRows = false; // nên tắt nếu bạn không muốn dòng mới do user thêm trực tiếp
            dgvDanhSachDonVi.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvDanhSachDonVi.AutoGenerateColumns = false; // Tắt tự động tạo cột

            // Xóa cột cũ nếu có
            dgvDanhSachDonVi.Columns.Clear();

            // Tạo cột STT
            DataGridViewTextBoxColumn colSTT = new DataGridViewTextBoxColumn();
            colSTT.Name = "STT";
            colSTT.HeaderText = "STT";
            colSTT.Width = 50;
            colSTT.ReadOnly = true;
            dgvDanhSachDonVi.Columns.Add(colSTT);

            // Tạo cột MaDonVi
            DataGridViewTextBoxColumn colMaDonVi = new DataGridViewTextBoxColumn();
            colMaDonVi.Name = "MaDonVi";
            colMaDonVi.HeaderText = "MÃ ĐƠN VỊ";
            colMaDonVi.DataPropertyName = "MaDonVi"; // tên thuộc tính trong DTO_DonVi
            colMaDonVi.Width = 150;
            dgvDanhSachDonVi.Columns.Add(colMaDonVi);

            // Tạo cột TenDonVi
            DataGridViewTextBoxColumn colTenDonVi = new DataGridViewTextBoxColumn();
            colTenDonVi.Name = "TenDonVi";
            colTenDonVi.HeaderText = "TÊN ĐƯƠN VỊ";
            colTenDonVi.DataPropertyName = "TenDonVi"; // tên thuộc tính trong DTO_DonVi
            colTenDonVi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDanhSachDonVi.Columns.Add(colTenDonVi);

            // Nếu cần thêm cột ThaoTac (nút xóa)
            if (!dgvDanhSachDonVi.Columns.Contains("ThaoTac"))
            {
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                btnXoa.Name = "ThaoTac";
                btnXoa.HeaderText = "THAO TÁC";
                btnXoa.Text = "Xóa";
                btnXoa.UseColumnTextForButtonValue = true;
                btnXoa.Width = 70;
                dgvDanhSachDonVi.Columns.Add(btnXoa);
            }

            // Sự kiện đánh số STT
            dgvDanhSachDonVi.RowPrePaint += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachDonVi.Rows.Count)
                {
                    dgvDanhSachDonVi.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
                }
            };
        }
        private void TaiLai()
        {
            dgvDanhSachDonVi.DataSource = BUS_DonVi.LayDanhSachDonVi();
            dgvDanhSachDonVi.ClearSelection();

            txtMaDonVi.Text = BUS_DonVi.TaoMaDonViMoi();
            txtTenDonVi.Clear();
        }

        private void GUI_QuanLyDonViTinh_Load_1(object sender, EventArgs e)
        {
            TaiLai();
        }

        private void btnThemDonVi_Click_1(object sender, EventArgs e)
        {

            string ten = txtTenDonVi.Text.Trim();

            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra chỉ chứa chữ cái
            if (!Regex.IsMatch(ten, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show("Tên đơn vị chỉ được chứa chữ cái và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ma = txtMaDonVi.Text.Trim(); // Lấy mã đơn vị từ ô nhập
            string tenDv = txtTenDonVi.Text.Trim();
            // Tạo đối tượng đơn vị mới và thêm vào danh sách tạm
            DTO_DonVi donVi = new DTO_DonVi(ma, tenDv);
            danhSachTam.Add(donVi);

            // Cập nhật lại DataGridView
            dgvDanhSachDonVi.DataSource = null;
            dgvDanhSachDonVi.DataSource = danhSachTam;

            // Reset
            txtMaDonVi.Text = BUS_DonVi.TaoMaDonViMoi();
            txtTenDonVi.Clear();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            int thanhCong = 0;

            // Lưu các đơn vị mới
            foreach (DTO_DonVi donVi in danhSachTam)
            {
                if (BUS_DonVi.Them(donVi))
                {
                    thanhCong++;
                }
            }

            // Xóa các đơn vị đã được chọn xóa
            int xoaThanhCong = 0;
            foreach (DTO_DonVi donVi in danhSachCanXoa)
            {
                try
                {
                    if (BUS_DonVi.Xoa(donVi.maDonVi))
                    {
                        xoaThanhCong++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể xóa đơn vị {donVi.maDonVi}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Thông báo kết quả
            if (thanhCong > 0 || xoaThanhCong > 0)
            {
                MessageBox.Show($"Đã lưu {thanhCong} đơn vị mới và xóa {xoaThanhCong} đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có thay đổi nào được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Clear danh sách tạm và load lại
            danhSachTam.Clear();
            danhSachCanXoa.Clear();
            TaiLai();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhSachDonVi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachDonVi.Columns[e.ColumnIndex].Name == "ThaoTac")
            {
                string maDonVi = dgvDanhSachDonVi.Rows[e.RowIndex].Cells["MaDonVi"].Value?.ToString();

                if (string.IsNullOrEmpty(maDonVi))
                {
                    MessageBox.Show("Không thể xác định mã đơn vị để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa đơn vị có mã {maDonVi} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Tìm và xóa trong danh sách tạm nếu có
                    DTO_DonVi donViCanXoa = danhSachTam.FirstOrDefault(d => d.maDonVi == maDonVi);
                    if (donViCanXoa != null)
                    {
                        danhSachTam.Remove(donViCanXoa);
                    }
                    else
                    {
                        // Nếu không nằm trong danh sách tạm thì nằm trong DB → thêm vào danh sách chờ xóa
                        DTO_DonVi donViTuDB = BUS_DonVi.LayDanhSachDonVi().FirstOrDefault(d => d.maDonVi == maDonVi);
                        if (donViTuDB != null)
                        {
                            danhSachCanXoa.Add(donViTuDB);
                        }
                    }

                    // Cập nhật lại DataGridView: danh sách tạm + dữ liệu từ DB (trừ các đơn vị đã chọn xóa)
                    var danhSachHienThi = danhSachTam
                        .Concat(BUS_DonVi.LayDanhSachDonVi().Where(d => !danhSachCanXoa.Any(x => x.maDonVi == d.maDonVi)))
                        .ToList();

                    dgvDanhSachDonVi.DataSource = null;
                    dgvDanhSachDonVi.DataSource = danhSachHienThi;
                }
            }
        }
    }
}
