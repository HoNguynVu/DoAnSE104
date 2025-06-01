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
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongBenhNhanToiDaTrongNgay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textblock = new System.Windows.Forms.Label();
            this.txtTienKhamCoDinh = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.QuyDinhTienKhamCoDinh = new Styling_Toggle_Button.SButton();
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay = new Styling_Toggle_Button.SButton();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(7, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(443, 62);
            this.label13.TabIndex = 117;
            this.label13.Text = "Danh sách tham số";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 67);
            this.label1.TabIndex = 117;
            this.label1.Text = "Quy định số lượng bệnh nhân tối đa trong ngày";
            // 
            // txtSoLuongBenhNhanToiDaTrongNgay
            // 
            this.txtSoLuongBenhNhanToiDaTrongNgay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSoLuongBenhNhanToiDaTrongNgay.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSoLuongBenhNhanToiDaTrongNgay.Enabled = false;
            this.txtSoLuongBenhNhanToiDaTrongNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongBenhNhanToiDaTrongNgay.Location = new System.Drawing.Point(865, 129);
            this.txtSoLuongBenhNhanToiDaTrongNgay.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtSoLuongBenhNhanToiDaTrongNgay.Name = "txtSoLuongBenhNhanToiDaTrongNgay";
            this.txtSoLuongBenhNhanToiDaTrongNgay.Size = new System.Drawing.Size(252, 34);
            this.txtSoLuongBenhNhanToiDaTrongNgay.TabIndex = 118;
            this.txtSoLuongBenhNhanToiDaTrongNgay.TabStop = false;
            this.txtSoLuongBenhNhanToiDaTrongNgay.TextChanged += new System.EventHandler(this.txtSoLuongBenhNhanToiDaTrongNgay_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(582, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 67);
            this.label2.TabIndex = 117;
            this.label2.Text = "Số lượng bệnh nhân tối đa trong ngày";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 35);
            this.label3.TabIndex = 117;
            this.label3.Text = "Quy định tiền khám cố định";
            // 
            // textblock
            // 
            this.textblock.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.textblock.Location = new System.Drawing.Point(582, 332);
            this.textblock.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.textblock.Name = "textblock";
            this.textblock.Size = new System.Drawing.Size(268, 31);
            this.textblock.TabIndex = 117;
            this.textblock.Text = "Tiền khám cố định";
            // 
            // txtTienKhamCoDinh
            // 
            this.txtTienKhamCoDinh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTienKhamCoDinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTienKhamCoDinh.Enabled = false;
            this.txtTienKhamCoDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKhamCoDinh.Location = new System.Drawing.Point(865, 334);
            this.txtTienKhamCoDinh.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtTienKhamCoDinh.Name = "txtTienKhamCoDinh";
            this.txtTienKhamCoDinh.Size = new System.Drawing.Size(252, 34);
            this.txtTienKhamCoDinh.TabIndex = 118;
            this.txtTienKhamCoDinh.TabStop = false;
            this.txtTienKhamCoDinh.TextChanged += new System.EventHandler(this.txtTienKhamCoDinh_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(803, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 45);
            this.btnSave.TabIndex = 122;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(979, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 45);
            this.btnCancel.TabIndex = 121;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // QuyDinhTienKhamCoDinh
            // 
            this.QuyDinhTienKhamCoDinh.Location = new System.Drawing.Point(359, 332);
            this.QuyDinhTienKhamCoDinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuyDinhTienKhamCoDinh.MinimumSize = new System.Drawing.Size(40, 18);
            this.QuyDinhTienKhamCoDinh.Name = "QuyDinhTienKhamCoDinh";
            this.QuyDinhTienKhamCoDinh.OffBackColor = System.Drawing.Color.Gray;
            this.QuyDinhTienKhamCoDinh.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.QuyDinhTienKhamCoDinh.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.QuyDinhTienKhamCoDinh.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.QuyDinhTienKhamCoDinh.Size = new System.Drawing.Size(89, 40);
            this.QuyDinhTienKhamCoDinh.TabIndex = 120;
            this.QuyDinhTienKhamCoDinh.UseVisualStyleBackColor = true;
            this.QuyDinhTienKhamCoDinh.CheckedChanged += new System.EventHandler(this.QuyDinhTienKhamCoDinh_CheckedChanged);
            // 
            // QuyDinhSoLuongBenhNhanToiDaTrongNgay
            // 
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.Location = new System.Drawing.Point(359, 129);
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.MinimumSize = new System.Drawing.Size(40, 18);
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.Name = "QuyDinhSoLuongBenhNhanToiDaTrongNgay";
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.OffBackColor = System.Drawing.Color.Gray;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.Size = new System.Drawing.Size(89, 40);
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.TabIndex = 119;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.UseVisualStyleBackColor = true;
            this.QuyDinhSoLuongBenhNhanToiDaTrongNgay.CheckedChanged += new System.EventHandler(this.QuyDinhSoLuongBenhNhanToiDaTrongNgay_CheckedChanged);
            // 
            // GUI_DanhSachThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 490);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.QuyDinhTienKhamCoDinh);
            this.Controls.Add(this.QuyDinhSoLuongBenhNhanToiDaTrongNgay);
            this.Controls.Add(this.txtTienKhamCoDinh);
            this.Controls.Add(this.txtSoLuongBenhNhanToiDaTrongNgay);
            this.Controls.Add(this.textblock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Name = "GUI_DanhSachThamSo";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.QuyDinhTienKhamCoDinh_CheckedChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuongBenhNhanToiDaTrongNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textblock;
        private System.Windows.Forms.TextBox txtTienKhamCoDinh;
        private Styling_Toggle_Button.SButton QuyDinhSoLuongBenhNhanToiDaTrongNgay;
        private Styling_Toggle_Button.SButton QuyDinhTienKhamCoDinh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}