using System.Drawing;

namespace DoAnSE104.GUI
{
    partial class GUI_LapBaoCaoDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.LabelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.LableMonth = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.BtnCreateReport = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(777, 72);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Báo cáo doanh thu theo ngày";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.LabelYear);
            this.groupBoxInfo.Controls.Add(this.textBoxYear);
            this.groupBoxInfo.Controls.Add(this.LableMonth);
            this.groupBoxInfo.Controls.Add(this.textBoxMonth);
            this.groupBoxInfo.Controls.Add(this.BtnCreateReport);
            this.groupBoxInfo.Controls.Add(this.BtnCancel);
            this.groupBoxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(30, 110);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxInfo.Size = new System.Drawing.Size(1100, 110);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin báo cáo";
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabelYear.Location = new System.Drawing.Point(30, 40);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(129, 28);
            this.LabelYear.TabIndex = 0;
            this.LabelYear.Text = "Năm báo cáo";
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.White;
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxYear.Location = new System.Drawing.Point(34, 70);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(180, 34);
            this.textBoxYear.TabIndex = 1;
            this.textBoxYear.TextChanged += new System.EventHandler(this.TextBoxYear_TextChanged);
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumber_KeyPress);
            // 
            // LableMonth
            // 
            this.LableMonth.AutoSize = true;
            this.LableMonth.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LableMonth.Location = new System.Drawing.Point(240, 40);
            this.LableMonth.Name = "LableMonth";
            this.LableMonth.Size = new System.Drawing.Size(141, 28);
            this.LableMonth.TabIndex = 2;
            this.LableMonth.Text = "Tháng báo cáo";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.BackColor = System.Drawing.Color.White;
            this.textBoxMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMonth.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxMonth.Location = new System.Drawing.Point(244, 70);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(180, 34);
            this.textBoxMonth.TabIndex = 3;
            this.textBoxMonth.TextChanged += new System.EventHandler(this.TextBoxMonth_TextChanged);
            this.textBoxMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumber_KeyPress);
            // 
            // BtnCreateReport
            // 
            this.BtnCreateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.BtnCreateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateReport.FlatAppearance.BorderSize = 0;
            this.BtnCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCreateReport.ForeColor = System.Drawing.Color.White;
            this.BtnCreateReport.Location = new System.Drawing.Point(651, 60);
            this.BtnCreateReport.Name = "BtnCreateReport";
            this.BtnCreateReport.Size = new System.Drawing.Size(220, 44);
            this.BtnCreateReport.TabIndex = 4;
            this.BtnCreateReport.Text = "Lập báo cáo";
            this.BtnCreateReport.UseVisualStyleBackColor = false;
            this.BtnCreateReport.Click += new System.EventHandler(this.BtnCreateReport_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(877, 60);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(200, 44);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Thoát";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabelTotal.Location = new System.Drawing.Point(34, 240);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(212, 28);
            this.LabelTotal.TabIndex = 6;
            this.LabelTotal.Text = "Tổng doanh thu tháng:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxTotal.Location = new System.Drawing.Point(260, 237);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(220, 34);
            this.textBoxTotal.TabIndex = 7;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReport.ColumnHeadersHeight = 32;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ngay,
            this.SoBenhNhan,
            this.DoanhThu,
            this.TyLe});
            this.dataGridViewReport.EnableHeadersVisualStyles = false;
            this.dataGridViewReport.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewReport.Location = new System.Drawing.Point(30, 290);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersVisible = false;
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.RowTemplate.Height = 32;
            this.dataGridViewReport.Size = new System.Drawing.Size(1100, 230);
            this.dataGridViewReport.TabIndex = 8;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "NGÀY";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            // 
            // SoBenhNhan
            // 
            this.SoBenhNhan.HeaderText = "SỐ BỆNH NHÂN";
            this.SoBenhNhan.MinimumWidth = 6;
            this.SoBenhNhan.Name = "SoBenhNhan";
            // 
            // DoanhThu
            // 
            this.DoanhThu.HeaderText = "DOANH THU";
            this.DoanhThu.MinimumWidth = 6;
            this.DoanhThu.Name = "DoanhThu";
            // 
            // TyLe
            // 
            this.TyLe.HeaderText = "TỶ LỆ";
            this.TyLe.MinimumWidth = 6;
            this.TyLe.Name = "TyLe";
            // 
            // GUI_LapBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 550);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "GUI_LapBaoCaoDoanhThu";
            this.Text = "Báo cáo doanh thu theo ngày";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label LableMonth;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Button BtnCreateReport;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLe;
    }
}