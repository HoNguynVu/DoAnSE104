namespace DoAnSE104.GUI
{
    partial class GUI_DanhSachThamSo
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelQDSLBNToiDaTrongNgay = new System.Windows.Forms.Label();
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay = new Styling_Toggle_Button.SButton();
            this.labelSLBNToiDaTrongNgay = new System.Windows.Forms.Label();
            this.txtSoLuongBenhNhanToiDaTrongNgay = new System.Windows.Forms.TextBox();
            this.labelQDTienKhamCoDinh = new System.Windows.Forms.Label();
            this.QuyDinhTienKhamCoDinh = new Styling_Toggle_Button.SButton();
            this.textTienKhamCoDinh = new System.Windows.Forms.Label();
            this.txtTienKhamCoDinh = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(407, 59);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Danh sách tham số";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.labelQDSLBNToiDaTrongNgay);
            this.groupBoxInfo.Controls.Add(this.QuyDinhSoLuongBenhNhanToiDaTrongNgay);
            this.groupBoxInfo.Controls.Add(this.labelSLBNToiDaTrongNgay);
            this.groupBoxInfo.Controls.Add(this.txtSoLuongBenhNhanToiDaTrongNgay);
            this.groupBoxInfo.Controls.Add(this.labelQDTienKhamCoDinh);
            this.groupBoxInfo.Controls.Add(this.QuyDinhTienKhamCoDinh);
            this.groupBoxInfo.Controls.Add(this.textTienKhamCoDinh);
            this.groupBoxInfo.Controls.Add(this.txtTienKhamCoDinh);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(30, 110);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxInfo.Size = new System.Drawing.Size(1033, 260);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin tham số";
            // 
            // labelQDSLBNToiDaTrongNgay
            // 
            this.labelQDSLBNToiDaTrongNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelQDSLBNToiDaTrongNgay.Location = new System.Drawing.Point(30, 50);
            this.labelQDSLBNToiDaTrongNgay.Name = "labelQDSLBNToiDaTrongNgay";
            this.labelQDSLBNToiDaTrongNgay.Size = new System.Drawing.Size(414, 30);
            this.labelQDSLBNToiDaTrongNgay.TabIndex = 0;
            this.labelQDSLBNToiDaTrongNgay.Text = "Quy định số lượng bệnh nhân tối đa trong ngày";
            // 
            // QuyDinhSoLuongBenhNhanToiDaTrongNgay
            // 
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.Location = new System.Drawing.Point(450, 46);
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.MinimumSize = new System.Drawing.Size(40, 18);
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.Name = "QuyDinhSoLuongBenhNhanToiDaTrongNgay";
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.OffBackColor = System.Drawing.Color.Gray;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.Size = new System.Drawing.Size(70, 30);
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.TabIndex = 1;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.UseVisualStyleBackColor = true;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.CheckedChanged += new System.EventHandler(this.QuyDinhSoLuongBenhNhanToiDaTrongNgay_CheckedChanged);
            // 
            // labelSLBNToiDaTrongNgay
            // 
            this.labelSLBNToiDaTrongNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelSLBNToiDaTrongNgay.Location = new System.Drawing.Point(560, 50);
            this.labelSLBNToiDaTrongNgay.Name = "labelSLBNToiDaTrongNgay";
            this.labelSLBNToiDaTrongNgay.Size = new System.Drawing.Size(321, 30);
            this.labelSLBNToiDaTrongNgay.TabIndex = 2;
            this.labelSLBNToiDaTrongNgay.Text = "Số lượng bệnh nhân tối đa trong ngày";
            // 
            // txtSoLuongBenhNhanToiDaTrongNgay
            // 
            this.txtSoLuongBenhNhanToiDaTrongNgay.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSoLuongBenhNhanToiDaTrongNgay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongBenhNhanToiDaTrongNgay.Enabled = false;
            this.txtSoLuongBenhNhanToiDaTrongNgay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoLuongBenhNhanToiDaTrongNgay.Location = new System.Drawing.Point(887, 46);
            this.txtSoLuongBenhNhanToiDaTrongNgay.Name = "txtSoLuongBenhNhanToiDaTrongNgay";
            this.txtSoLuongBenhNhanToiDaTrongNgay.Size = new System.Drawing.Size(120, 29);
            this.txtSoLuongBenhNhanToiDaTrongNgay.TabIndex = 3;
            this.txtSoLuongBenhNhanToiDaTrongNgay.TabStop = false;
            this.txtSoLuongBenhNhanToiDaTrongNgay.TextChanged += new System.EventHandler(this.txtSoLuongBenhNhanToiDaTrongNgay_TextChanged);
            // 
            // labelQDTienKhamCoDinh
            // 
            this.labelQDTienKhamCoDinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelQDTienKhamCoDinh.Location = new System.Drawing.Point(30, 120);
            this.labelQDTienKhamCoDinh.Name = "labelQDTienKhamCoDinh";
            this.labelQDTienKhamCoDinh.Size = new System.Drawing.Size(350, 30);
            this.labelQDTienKhamCoDinh.TabIndex = 4;
            this.labelQDTienKhamCoDinh.Text = "Quy định tiền khám cố định";
            // 
            // QuyDinhTienKhamCoDinh
            // 
            this.QuyDinhTienKhamCoDinh.Location = new System.Drawing.Point(450, 116);
            this.QuyDinhTienKhamCoDinh.MinimumSize = new System.Drawing.Size(40, 18);
            this.QuyDinhTienKhamCoDinh.Name = "QuyDinhTienKhamCoDinh";
            this.QuyDinhTienKhamCoDinh.OffBackColor = System.Drawing.Color.Gray;
            this.QuyDinhTienKhamCoDinh.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.QuyDinhTienKhamCoDinh.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.QuyDinhTienKhamCoDinh.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.QuyDinhTienKhamCoDinh.Size = new System.Drawing.Size(70, 30);
            this.QuyDinhTienKhamCoDinh.TabIndex = 5;
            this.QuyDinhTienKhamCoDinh.UseVisualStyleBackColor = true;
            this.QuyDinhTienKhamCoDinh.CheckedChanged += new System.EventHandler(this.QuyDinhTienKhamCoDinh_CheckedChanged);
            // 
            // textTienKhamCoDinh
            // 
            this.textTienKhamCoDinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.textTienKhamCoDinh.Location = new System.Drawing.Point(560, 120);
            this.textTienKhamCoDinh.Name = "textTienKhamCoDinh";
            this.textTienKhamCoDinh.Size = new System.Drawing.Size(220, 30);
            this.textTienKhamCoDinh.TabIndex = 6;
            this.textTienKhamCoDinh.Text = "Tiền khám cố định";
            // 
            // txtTienKhamCoDinh
            // 
            this.txtTienKhamCoDinh.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTienKhamCoDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienKhamCoDinh.Enabled = false;
            this.txtTienKhamCoDinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTienKhamCoDinh.Location = new System.Drawing.Point(887, 116);
            this.txtTienKhamCoDinh.Name = "txtTienKhamCoDinh";
            this.txtTienKhamCoDinh.Size = new System.Drawing.Size(120, 29);
            this.txtTienKhamCoDinh.TabIndex = 7;
            this.txtTienKhamCoDinh.TabStop = false;
            this.txtTienKhamCoDinh.TextChanged += new System.EventHandler(this.txtTienKhamCoDinh_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(30, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(863, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 44);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GUI_DanhSachThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 470);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(960, 470);
            this.Name = "GUI_DanhSachThamSo";
            this.Text = "Danh sách tham số";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelQDSLBNToiDaTrongNgay;
        private Styling_Toggle_Button.SButton QuyDinhSoLuongBenhNhanToiDaTrongNgay;
        private System.Windows.Forms.Label labelSLBNToiDaTrongNgay;
        private System.Windows.Forms.TextBox txtSoLuongBenhNhanToiDaTrongNgay;
        private System.Windows.Forms.Label labelQDTienKhamCoDinh;
        private Styling_Toggle_Button.SButton QuyDinhTienKhamCoDinh;
        private System.Windows.Forms.Label textTienKhamCoDinh;
        private System.Windows.Forms.TextBox txtTienKhamCoDinh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}