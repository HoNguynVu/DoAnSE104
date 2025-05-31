using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DoAnSE104.BUS;
using DoAnSE104.DTO;

namespace DoAnSE104.GUI {
    public partial class GUI_LapBaoCaoDoanhThu : Form {
        private string year = string.Empty;
        private string month = string.Empty;
        private BUS_BaoCaoDoanhThu busBaoCaoDoanhThu = new BUS_BaoCaoDoanhThu();

        public GUI_LapBaoCaoDoanhThu() {    
            InitializeComponent();

            SetupDataGridView();
        }

        private void SetupDataGridView() {
            dataGridViewReport.AutoGenerateColumns = false;
            dataGridViewReport.Columns.Clear();

            dataGridViewReport.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "STT",
                HeaderText = "STT",
                Width = 50,
                ReadOnly = true
            });
            dataGridViewReport.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "Ngay",
                HeaderText = "Ngày",
                DataPropertyName = "Ngay",
                Width = 100
            });
            dataGridViewReport.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "SoLuongHoaDon",
                HeaderText = "Số lượng hóa đơn",
                DataPropertyName = "SoLuongHoaDon",
                Width = 120
            });
            dataGridViewReport.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "TongDoanhThu",
                HeaderText = "Tổng doanh thu",
                DataPropertyName = "TongDoanhThu",
                Width = 150
            });
            dataGridViewReport.Columns.Add(new DataGridViewTextBoxColumn {
                Name = "TyLe",
                HeaderText = "Tỷ lệ (%)",
                DataPropertyName = "TyLe",
                Width = 100
            });
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void TextBoxYear_TextChanged(object sender, EventArgs e) {
            year = textBoxYear.Text.Trim();
        }

        private void TextBoxMonth_TextChanged(object sender, EventArgs e) {
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

        private void BtnCreateReport_Click(object sender, EventArgs e) {
            long total = 0;
            if (!int.TryParse(year, out int yearValue) || yearValue < 1900 || yearValue > DateTime.Now.Year) {
                MessageBox.Show("Vui lòng nhập năm hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxYear.Focus();
                return;
            }
            if (!int.TryParse(month, out int monthValue) || monthValue < 1 || monthValue > 12) {
                MessageBox.Show("Vui lòng nhập tháng hợp lệ (1-12)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMonth.Focus();
                return;
            }

            try {
                List<DTO_BaoCaoDoanhThu> reportData = busBaoCaoDoanhThu.LayBaoCaoDoanhThu(yearValue, monthValue);
                dataGridViewReport.Rows.Clear();

                for (int i = 0; i < reportData.Count; i++) {
                    var row = reportData[i];
                    dataGridViewReport.Rows.Add(
                        (i + 1).ToString(),
                        row.Ngay.ToString("dd/MM/yyyy"),
                        row.SoLuongHoaDon,
                        row.TongDoanhThu.ToString("N0"),
                        row.TyLe.ToString("F2")
                    );
                    total += (long)row.TongDoanhThu;
                }

                textBoxTotal.Text = total.ToString("N0");

                if (reportData.Count == 0) {
                    MessageBox.Show("Không có dữ liệu cho tháng/năm này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}