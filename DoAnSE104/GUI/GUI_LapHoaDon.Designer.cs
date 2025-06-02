namespace DoAnSE104.GUI
{
    partial class GUI_LapHoaDon
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelMaKhamBenh = new System.Windows.Forms.Label();
            this.txtMaKhamBenh = new System.Windows.Forms.TextBox();
            this.labelTenBenhNhan = new System.Windows.Forms.Label();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.labelNgayKham = new System.Windows.Forms.Label();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.labelTienKham = new System.Windows.Forms.Label();
            this.txtTienKham = new System.Windows.Forms.TextBox();
            this.labelTienThuoc = new System.Windows.Forms.Label();
            this.txtTienThuoc = new System.Windows.Forms.TextBox();
            this.labelMaHoaDon = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.dgvDanhSachThuoc = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.btnHDMoi = new System.Windows.Forms.Button();
            this.btnTimHD = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(639, 72);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Lập hóa đơn thanh toán";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.labelMaKhamBenh);
            this.groupBoxInfo.Controls.Add(this.txtMaKhamBenh);
            this.groupBoxInfo.Controls.Add(this.labelTenBenhNhan);
            this.groupBoxInfo.Controls.Add(this.txtTenBenhNhan);
            this.groupBoxInfo.Controls.Add(this.labelNgayKham);
            this.groupBoxInfo.Controls.Add(this.txtNgayKham);
            this.groupBoxInfo.Controls.Add(this.labelTienKham);
            this.groupBoxInfo.Controls.Add(this.txtTienKham);
            this.groupBoxInfo.Controls.Add(this.labelTienThuoc);
            this.groupBoxInfo.Controls.Add(this.txtTienThuoc);
            this.groupBoxInfo.Controls.Add(this.labelMaHoaDon);
            this.groupBoxInfo.Controls.Add(this.txtMaHoaDon);
            this.groupBoxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(30, 110);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxInfo.Size = new System.Drawing.Size(1100, 180);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin hóa đơn";
            // 
            // labelMaKhamBenh
            // 
            this.labelMaKhamBenh.AutoSize = true;
            this.labelMaKhamBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaKhamBenh.Location = new System.Drawing.Point(10, 40);
            this.labelMaKhamBenh.Name = "labelMaKhamBenh";
            this.labelMaKhamBenh.Size = new System.Drawing.Size(142, 28);
            this.labelMaKhamBenh.TabIndex = 0;
            this.labelMaKhamBenh.Text = "Mã khám bệnh";
            // 
            // txtMaKhamBenh
            // 
            this.txtMaKhamBenh.BackColor = System.Drawing.Color.White;
            this.txtMaKhamBenh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhamBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaKhamBenh.Location = new System.Drawing.Point(14, 70);
            this.txtMaKhamBenh.Name = "txtMaKhamBenh";
            this.txtMaKhamBenh.Size = new System.Drawing.Size(180, 34);
            this.txtMaKhamBenh.TabIndex = 1;
            this.txtMaKhamBenh.TextChanged += new System.EventHandler(this.txtMaKhamBenh_TextChanged);
            // 
            // labelTenBenhNhan
            // 
            this.labelTenBenhNhan.AutoSize = true;
            this.labelTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTenBenhNhan.Location = new System.Drawing.Point(210, 40);
            this.labelTenBenhNhan.Name = "labelTenBenhNhan";
            this.labelTenBenhNhan.Size = new System.Drawing.Size(138, 28);
            this.labelTenBenhNhan.TabIndex = 2;
            this.labelTenBenhNhan.Text = "Tên bệnh nhân";
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTenBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenBenhNhan.Enabled = false;
            this.txtTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenBenhNhan.Location = new System.Drawing.Point(214, 70);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(220, 34);
            this.txtTenBenhNhan.TabIndex = 3;
            this.txtTenBenhNhan.TabStop = false;
            // 
            // labelNgayKham
            // 
            this.labelNgayKham.AutoSize = true;
            this.labelNgayKham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNgayKham.Location = new System.Drawing.Point(450, 40);
            this.labelNgayKham.Name = "labelNgayKham";
            this.labelNgayKham.Size = new System.Drawing.Size(112, 28);
            this.labelNgayKham.TabIndex = 4;
            this.labelNgayKham.Text = "Ngày khám";
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNgayKham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayKham.Enabled = false;
            this.txtNgayKham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNgayKham.Location = new System.Drawing.Point(454, 70);
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.Size = new System.Drawing.Size(180, 34);
            this.txtNgayKham.TabIndex = 5;
            this.txtNgayKham.TabStop = false;
            // 
            // labelTienKham
            // 
            this.labelTienKham.AutoSize = true;
            this.labelTienKham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTienKham.Location = new System.Drawing.Point(650, 40);
            this.labelTienKham.Name = "labelTienKham";
            this.labelTienKham.Size = new System.Drawing.Size(101, 28);
            this.labelTienKham.TabIndex = 6;
            this.labelTienKham.Text = "Tiền khám";
            // 
            // txtTienKham
            // 
            this.txtTienKham.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTienKham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienKham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTienKham.Location = new System.Drawing.Point(654, 70);
            this.txtTienKham.Name = "txtTienKham";
            this.txtTienKham.Size = new System.Drawing.Size(120, 34);
            this.txtTienKham.TabIndex = 7;
            this.txtTienKham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienKham_KeyPress);
            // 
            // labelTienThuoc
            // 
            this.labelTienThuoc.AutoSize = true;
            this.labelTienThuoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTienThuoc.Location = new System.Drawing.Point(790, 40);
            this.labelTienThuoc.Name = "labelTienThuoc";
            this.labelTienThuoc.Size = new System.Drawing.Size(103, 28);
            this.labelTienThuoc.TabIndex = 8;
            this.labelTienThuoc.Text = "Tiền thuốc";
            // 
            // txtTienThuoc
            // 
            this.txtTienThuoc.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTienThuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienThuoc.Enabled = false;
            this.txtTienThuoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTienThuoc.Location = new System.Drawing.Point(794, 70);
            this.txtTienThuoc.Name = "txtTienThuoc";
            this.txtTienThuoc.Size = new System.Drawing.Size(120, 34);
            this.txtTienThuoc.TabIndex = 9;
            this.txtTienThuoc.TabStop = false;
            // 
            // labelMaHoaDon
            // 
            this.labelMaHoaDon.AutoSize = true;
            this.labelMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaHoaDon.Location = new System.Drawing.Point(930, 40);
            this.labelMaHoaDon.Name = "labelMaHoaDon";
            this.labelMaHoaDon.Size = new System.Drawing.Size(118, 28);
            this.labelMaHoaDon.TabIndex = 10;
            this.labelMaHoaDon.Text = "Mã hóa đơn";
            this.labelMaHoaDon.Visible = false;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHoaDon.Enabled = false;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaHoaDon.Location = new System.Drawing.Point(934, 70);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(120, 34);
            this.txtMaHoaDon.TabIndex = 11;
            this.txtMaHoaDon.TabStop = false;
            this.txtMaHoaDon.Visible = false;
            // 
            // dgvDanhSachThuoc
            // 
            this.dgvDanhSachThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachThuoc.ColumnHeadersHeight = 32;
            this.dgvDanhSachThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaLoaiThuoc,
            this.TenLoaiThuoc,
            this.SoLuongThuoc,
            this.DonGia,
            this.ThanhTien});
            this.dgvDanhSachThuoc.EnableHeadersVisualStyles = false;
            this.dgvDanhSachThuoc.GridColor = System.Drawing.Color.LightGray;
            this.dgvDanhSachThuoc.Location = new System.Drawing.Point(30, 310);
            this.dgvDanhSachThuoc.Name = "dgvDanhSachThuoc";
            this.dgvDanhSachThuoc.RowHeadersVisible = false;
            this.dgvDanhSachThuoc.RowHeadersWidth = 51;
            this.dgvDanhSachThuoc.RowTemplate.Height = 32;
            this.dgvDanhSachThuoc.Size = new System.Drawing.Size(1100, 230);
            this.dgvDanhSachThuoc.TabIndex = 12;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaLoaiThuoc
            // 
            this.MaLoaiThuoc.DataPropertyName = "MaLoaiThuoc";
            this.MaLoaiThuoc.HeaderText = "MÃ LOẠI THUỐC";
            this.MaLoaiThuoc.MinimumWidth = 6;
            this.MaLoaiThuoc.Name = "MaLoaiThuoc";
            this.MaLoaiThuoc.ReadOnly = true;
            // 
            // TenLoaiThuoc
            // 
            this.TenLoaiThuoc.DataPropertyName = "TenLoaiThuoc";
            this.TenLoaiThuoc.HeaderText = "TÊN LOẠI THUỐC";
            this.TenLoaiThuoc.MinimumWidth = 6;
            this.TenLoaiThuoc.Name = "TenLoaiThuoc";
            this.TenLoaiThuoc.ReadOnly = true;
            // 
            // SoLuongThuoc
            // 
            this.SoLuongThuoc.DataPropertyName = "SoLuongThuoc";
            this.SoLuongThuoc.HeaderText = "SỐ LƯỢNG THUỐC";
            this.SoLuongThuoc.MinimumWidth = 6;
            this.SoLuongThuoc.Name = "SoLuongThuoc";
            this.SoLuongThuoc.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "ĐƠN GIÁ";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "THÀNH TIỀN";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // btnLapHD
            // 
            this.btnLapHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLapHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLapHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapHD.FlatAppearance.BorderSize = 0;
            this.btnLapHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLapHD.ForeColor = System.Drawing.Color.White;
            this.btnLapHD.Location = new System.Drawing.Point(30, 587);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(200, 44);
            this.btnLapHD.TabIndex = 13;
            this.btnLapHD.Text = "Lập hóa đơn";
            this.btnLapHD.UseVisualStyleBackColor = false;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // btnHDMoi
            // 
            this.btnHDMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHDMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnHDMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHDMoi.FlatAppearance.BorderSize = 0;
            this.btnHDMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHDMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHDMoi.ForeColor = System.Drawing.Color.White;
            this.btnHDMoi.Location = new System.Drawing.Point(236, 587);
            this.btnHDMoi.Name = "btnHDMoi";
            this.btnHDMoi.Size = new System.Drawing.Size(200, 44);
            this.btnHDMoi.TabIndex = 14;
            this.btnHDMoi.Text = "Hóa đơn mới";
            this.btnHDMoi.UseVisualStyleBackColor = false;
            this.btnHDMoi.Click += new System.EventHandler(this.btnHDMoi_Click);
            // 
            // btnTimHD
            // 
            this.btnTimHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTimHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimHD.FlatAppearance.BorderSize = 0;
            this.btnTimHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTimHD.ForeColor = System.Drawing.Color.White;
            this.btnTimHD.Location = new System.Drawing.Point(442, 587);
            this.btnTimHD.Name = "btnTimHD";
            this.btnTimHD.Size = new System.Drawing.Size(200, 44);
            this.btnTimHD.TabIndex = 15;
            this.btnTimHD.Text = "Tìm hóa đơn";
            this.btnTimHD.UseVisualStyleBackColor = false;
            this.btnTimHD.Click += new System.EventHandler(this.btnTimHD_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(930, 587);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 44);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GUI_LapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 643);
            this.Controls.Add(this.dgvDanhSachThuoc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTimHD);
            this.Controls.Add(this.btnHDMoi);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "GUI_LapHoaDon";
            this.Text = "Lập hóa đơn thanh toán";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMaKhamBenh;
        private System.Windows.Forms.Label labelTenBenhNhan;
        private System.Windows.Forms.Label labelNgayKham;
        private System.Windows.Forms.Label labelTienKham;
        private System.Windows.Forms.Label labelTienThuoc;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtMaKhamBenh;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.TextBox txtNgayKham;
        private System.Windows.Forms.TextBox txtTienThuoc;
        private System.Windows.Forms.TextBox txtTienKham;
        private System.Windows.Forms.DataGridView dgvDanhSachThuoc;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnHDMoi;
        private System.Windows.Forms.Button btnTimHD;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label labelMaHoaDon;
        private System.Windows.Forms.GroupBox groupBoxInfo;
    }
}