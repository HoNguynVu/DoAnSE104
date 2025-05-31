namespace DoAnSE104.GUI
{
    partial class GUI_LapBaoCaoSuDungThuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.LabelYear = new System.Windows.Forms.Label();
            this.LableMonth = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.BtnCreateReport = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo sử dụng thuốc";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(43, 144);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(313, 34);
            this.textBoxYear.TabIndex = 1;
            this.textBoxYear.TextChanged += new System.EventHandler(this.TextBoxYear_TextChanged);
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYear.Location = new System.Drawing.Point(37, 106);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(195, 29);
            this.LabelYear.TabIndex = 2;
            this.LabelYear.Text = "Năm lập báo cáo";
            // 
            // LableMonth
            // 
            this.LableMonth.AutoSize = true;
            this.LableMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableMonth.Location = new System.Drawing.Point(395, 106);
            this.LableMonth.Name = "LableMonth";
            this.LableMonth.Size = new System.Drawing.Size(213, 29);
            this.LableMonth.TabIndex = 4;
            this.LableMonth.Text = "Tháng lập báo cáo";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonth.Location = new System.Drawing.Point(400, 144);
            this.textBoxMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(313, 34);
            this.textBoxMonth.TabIndex = 3;
            this.textBoxMonth.TextChanged += new System.EventHandler(this.TextBoxMonth_TextChanged);
            // 
            // dataGridViewReport
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Thuoc,
            this.DonViTinh,
            this.SoLuong,
            this.SoLanDung});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReport.Location = new System.Drawing.Point(43, 338);
            this.dataGridViewReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.RowTemplate.Height = 24;
            this.dataGridViewReport.Size = new System.Drawing.Size(962, 202);
            this.dataGridViewReport.TabIndex = 100;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 150;
            // 
            // Thuoc
            // 
            this.Thuoc.HeaderText = "THUỐC";
            this.Thuoc.MinimumWidth = 6;
            this.Thuoc.Name = "Thuoc";
            this.Thuoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thuoc.Width = 170;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "ĐƠN VỊ TÍNH";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Width = 250;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "SỐ LƯỢNG";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 200;
            // 
            // SoLanDung
            // 
            this.SoLanDung.HeaderText = "SỐ LẦN DÙNG";
            this.SoLanDung.MinimumWidth = 6;
            this.SoLanDung.Name = "SoLanDung";
            this.SoLanDung.Width = 300;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(46, 289);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(270, 29);
            this.LabelTotal.TabIndex = 102;
            this.LabelTotal.Text = "Tổng số lần dùng thuốc:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(368, 286);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(345, 34);
            this.textBoxTotal.TabIndex = 101;
            // 
            // BtnCreateReport
            // 
            this.BtnCreateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateReport.Location = new System.Drawing.Point(528, 202);
            this.BtnCreateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateReport.Name = "BtnCreateReport";
            this.BtnCreateReport.Size = new System.Drawing.Size(333, 44);
            this.BtnCreateReport.TabIndex = 103;
            this.BtnCreateReport.Text = "Lập báo cáo sử dụng";
            this.BtnCreateReport.UseVisualStyleBackColor = true;
            this.BtnCreateReport.Click += new System.EventHandler(this.BtnCreateReport_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(876, 202);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(128, 44);
            this.BtnCancel.TabIndex = 104;
            this.BtnCancel.Text = "Thoát";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.TextChanged += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GUI_LapBaoCaoSuDungThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 562);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnCreateReport);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.LableMonth);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUI_LapBaoCaoSuDungThuoc";
            this.Text = "Báo cáo doanh thu theo ngày";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LableMonth;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLanDung;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button BtnCreateReport;
        private System.Windows.Forms.Button BtnCancel;
    }
}