namespace DoAnSE104.GUI
{
    partial class GUI_BaoCaoSuDungThuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxYear = new System.Windows.Forms.TextBox();
            this.LabelYear = new System.Windows.Forms.Label();
            this.LableMonth = new System.Windows.Forms.Label();
            this.TextBoxMonth = new System.Windows.Forms.TextBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.TextBoxTotal = new System.Windows.Forms.TextBox();
            this.BtnCreateReport = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo sử dụng thuốc";
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxYear.Location = new System.Drawing.Point(48, 180);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(352, 39);
            this.TextBoxYear.TabIndex = 1;
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYear.Location = new System.Drawing.Point(42, 133);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(227, 32);
            this.LabelYear.TabIndex = 2;
            this.LabelYear.Text = "Năm lập báo cáo";
            // 
            // LableMonth
            // 
            this.LableMonth.AutoSize = true;
            this.LableMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableMonth.Location = new System.Drawing.Point(444, 133);
            this.LableMonth.Name = "LableMonth";
            this.LableMonth.Size = new System.Drawing.Size(249, 32);
            this.LableMonth.TabIndex = 4;
            this.LableMonth.Text = "Tháng lập báo cáo";
            // 
            // TextBoxMonth
            // 
            this.TextBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMonth.Location = new System.Drawing.Point(450, 180);
            this.TextBoxMonth.Name = "TextBoxMonth";
            this.TextBoxMonth.Size = new System.Drawing.Size(352, 39);
            this.TextBoxMonth.TabIndex = 3;
            // 
            // Table
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Thuoc,
            this.DonViTinh,
            this.SoLuong,
            this.SoLanDung});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle6;
            this.Table.Location = new System.Drawing.Point(48, 423);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(1082, 253);
            this.Table.TabIndex = 100;
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
            this.LabelTotal.Location = new System.Drawing.Point(52, 361);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(318, 32);
            this.LabelTotal.TabIndex = 102;
            this.LabelTotal.Text = "Tổng số lần dùng thuốc:";
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxTotal.Enabled = false;
            this.TextBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTotal.Location = new System.Drawing.Point(414, 358);
            this.TextBoxTotal.Name = "TextBoxTotal";
            this.TextBoxTotal.Size = new System.Drawing.Size(388, 39);
            this.TextBoxTotal.TabIndex = 101;
            // 
            // BtnCreateReport
            // 
            this.BtnCreateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateReport.Location = new System.Drawing.Point(594, 252);
            this.BtnCreateReport.Name = "BtnCreateReport";
            this.BtnCreateReport.Size = new System.Drawing.Size(375, 55);
            this.BtnCreateReport.TabIndex = 103;
            this.BtnCreateReport.Text = "Lập báo cáo sử dụng";
            this.BtnCreateReport.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(986, 252);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(144, 55);
            this.BtnCancel.TabIndex = 104;
            this.BtnCancel.Text = "Thoát";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // GUI_BaoCaoSuDungThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 703);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnCreateReport);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.TextBoxTotal);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.LableMonth);
            this.Controls.Add(this.TextBoxMonth);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.TextBoxYear);
            this.Controls.Add(this.label1);
            this.Name = "GUI_BaoCaoSuDungThuoc";
            this.Text = "Báo cáo doanh thu theo ngày";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxYear;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LableMonth;
        private System.Windows.Forms.TextBox TextBoxMonth;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLanDung;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.TextBox TextBoxTotal;
        private System.Windows.Forms.Button BtnCreateReport;
        private System.Windows.Forms.Button BtnCancel;
    }
}