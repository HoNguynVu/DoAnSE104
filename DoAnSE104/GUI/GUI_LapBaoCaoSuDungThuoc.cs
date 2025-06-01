using DoAnSE104.BUS;
using DoAnSE104.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAnSE104.GUI
{
    public partial class GUI_LapBaoCaoSuDungThuoc : Form
    {
        private string year = string.Empty;
        private string month = string.Empty;
        private BUS_BaoCaoSuDungThuoc busBaoCaoSuDungThuoc = new BUS_BaoCaoSuDungThuoc();

        public GUI_LapBaoCaoSuDungThuoc()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridViewReport.AutoGenerateColumns = false;
            dataGridViewReport.Columns.Clear();

            dataGridViewReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "STT",
                HeaderText = "STT",
                Width = 50,
                ReadOnly = true
            });
            dataGridViewReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenThuoc",
                HeaderText = "Tên thuốc",
                DataPropertyName = "TenThuoc",
                Width = 150
            });
            dataGridViewReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DonVi",
                HeaderText = "Đơn vị",
                DataPropertyName = "DonVi",
                Width = 100
            });
            dataGridViewReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                HeaderText = "Số lượng sử dụng",
                DataPropertyName = "SoLuong",
                Width = 120
            });

            dataGridViewReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Số lần dùng",
                HeaderText = "Số lần dùng",
                DataPropertyName = "SoLanDung",
                Width = 100
            });
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxYear_TextChanged(object sender, EventArgs e)
        {
            year = textBoxYear.Text.Trim();
        }

        private void TextBoxMonth_TextChanged(object sender, EventArgs e)
        {
            month = textBoxMonth.Text.Trim();
        }

        private void TextBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys and digits only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnCreateReport_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (!int.TryParse(year, out int yearValue) || yearValue < 1900 || yearValue > 2050)
            {
                MessageBox.Show("Vui lòng nhập năm hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxYear.Focus();
                return;
            }
            if (!int.TryParse(month, out int monthValue) || monthValue < 1 || monthValue > 12)
            {
                MessageBox.Show("Vui lòng nhập tháng hợp lệ (1-12)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMonth.Focus();
                return;
            }

            try
            {
                List<DTO_BaoCaoSuDungThuoc> reportData = busBaoCaoSuDungThuoc.LayBaoCaoSuDungThuoc(yearValue, monthValue);
                int tongSoLanDung = busBaoCaoSuDungThuoc.LayTongSoLanSuDungThuoc(yearValue, monthValue);

                dataGridViewReport.Rows.Clear();
                int totalSoLuong = 0;

                for (int i = 0; i < reportData.Count; i++)
                {
                    var row = reportData[i];
                    dataGridViewReport.Rows.Add(
                        (i + 1).ToString(),
                        row.TenThuoc,
                        row.DonVi,
                        row.SoLuong,
                        row.SoLanDung
                    );
                    totalSoLuong += row.SoLuong;
                }
                textBoxTotal.Text = tongSoLanDung.ToString("N0"); // Tổng số lần sử dụng (thêm 1 textbox nữa để hiển thị)

                if (reportData.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho tháng/năm này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message);
            }
        }
    }
}
