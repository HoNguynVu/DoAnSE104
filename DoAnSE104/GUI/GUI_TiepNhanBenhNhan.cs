using System;
using System.Windows.Forms;
using DoAnSE104.BUS;
using DoAnSE104.DTO;

namespace DoAnSE104.GUI
{
    public partial class GUI_TiepNhanBenhNhan : Form
    {
        BUS_BenhNhan BUS_BenhNhan = new BUS_BenhNhan();
        private GUI_Home homeForm;

        public GUI_TiepNhanBenhNhan(GUI_Home home)
        {
            InitializeComponent();
            this.homeForm = home;
        }
        public GUI_TiepNhanBenhNhan()
        {
            InitializeComponent();
           

        }

        private void LayMaBenhNhanMoi()
        {
            maBenhNhan.Text = BUS_BenhNhan.LayMaBenhNhanMoi();
        }

        private void GUI_TiepNhanBenhNhan_Load(object sender, EventArgs e)
        {
            LayMaBenhNhanMoi();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtGioiTinh.Clear();
            txtNamSinh.Clear();
            maBenhNhan.Text = BUS_BenhNhan.LayMaBenhNhanMoi();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
            string.IsNullOrWhiteSpace(txtGioiTinh.Text) ||
            string.IsNullOrWhiteSpace(txtNamSinh.Text) ||
            string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DTO_BenhNhan newBenhNhan = new DTO_BenhNhan(
                maBenhNhan.Text,
                txtHoTen.Text.Trim(),
                txtGioiTinh.Text.Trim(),
                int.Parse(txtNamSinh.Text.Trim()),
                txtDiaChi.Text.Trim()
            );
            try
            {
                if (BUS_BenhNhan.ThemBenhNhan(newBenhNhan))
                {
                    MessageBox.Show("Thêm bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm bệnh nhân thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Đảm bảo bạn đã có form GUI_TraCuuBenhNhan
            GUI_TraCuuBenhNhan traCuuForm = new GUI_TraCuuBenhNhan(homeForm);
            homeForm.ShowFormInMainPanel(traCuuForm);
            this.Close(); // Đóng form hiện tại nếu muốn
        }
    }
}
