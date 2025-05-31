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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaKhamBenh = new System.Windows.Forms.TextBox();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.txtTienThuoc = new System.Windows.Forms.TextBox();
            this.txtTienKham = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnHDMoi = new System.Windows.Forms.Button();
            this.btnTimHD = new System.Windows.Forms.Button();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(35, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 97;
            this.label2.Text = "Mã khám bệnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(456, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 97;
            this.label3.Text = "Tên bệnh nhân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(848, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 97;
            this.label4.Text = "Ngày khám";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(35, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 97;
            this.label5.Text = "Tiền khám";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(456, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 97;
            this.label6.Text = "Tiền thuốc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(29, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(554, 62);
            this.label13.TabIndex = 116;
            this.label13.Text = "Lập hóa đơn thanh toán";
            // 
            // txtMaKhamBenh
            // 
            this.txtMaKhamBenh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMaKhamBenh.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaKhamBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhamBenh.Location = new System.Drawing.Point(41, 165);
            this.txtMaKhamBenh.Margin = new System.Windows.Forms.Padding(7);
            this.txtMaKhamBenh.Multiline = true;
            this.txtMaKhamBenh.Name = "txtMaKhamBenh";
            this.txtMaKhamBenh.Size = new System.Drawing.Size(252, 48);
            this.txtMaKhamBenh.TabIndex = 110;
            this.txtMaKhamBenh.TabStop = false;
            this.txtMaKhamBenh.TextChanged += new System.EventHandler(this.txtMaKhamBenh_TextChanged);
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTenBenhNhan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTenBenhNhan.Enabled = false;
            this.txtTenBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBenhNhan.Location = new System.Drawing.Point(461, 165);
            this.txtTenBenhNhan.Margin = new System.Windows.Forms.Padding(7);
            this.txtTenBenhNhan.Multiline = true;
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(252, 48);
            this.txtTenBenhNhan.TabIndex = 110;
            this.txtTenBenhNhan.TabStop = false;
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNgayKham.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNgayKham.Enabled = false;
            this.txtNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayKham.Location = new System.Drawing.Point(853, 165);
            this.txtNgayKham.Margin = new System.Windows.Forms.Padding(7);
            this.txtNgayKham.Multiline = true;
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.Size = new System.Drawing.Size(252, 48);
            this.txtNgayKham.TabIndex = 110;
            this.txtNgayKham.TabStop = false;
            // 
            // txtTienThuoc
            // 
            this.txtTienThuoc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTienThuoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTienThuoc.Enabled = false;
            this.txtTienThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThuoc.Location = new System.Drawing.Point(461, 280);
            this.txtTienThuoc.Margin = new System.Windows.Forms.Padding(7);
            this.txtTienThuoc.Multiline = true;
            this.txtTienThuoc.Name = "txtTienThuoc";
            this.txtTienThuoc.Size = new System.Drawing.Size(252, 48);
            this.txtTienThuoc.TabIndex = 110;
            this.txtTienThuoc.TabStop = false;
            // 
            // txtTienKham
            // 
            this.txtTienKham.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTienKham.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTienKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKham.Location = new System.Drawing.Point(41, 280);
            this.txtTienKham.Margin = new System.Windows.Forms.Padding(7);
            this.txtTienKham.Multiline = true;
            this.txtTienKham.Name = "txtTienKham";
            this.txtTienKham.Size = new System.Drawing.Size(252, 48);
            this.txtTienKham.TabIndex = 110;
            this.txtTienKham.TabStop = false;
            this.txtTienKham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienKham_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaLoaiThuoc,
            this.TenLoaiThuoc,
            this.SoLuongThuoc,
            this.DonGia,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(40, 388);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 179);
            this.dataGridView1.TabIndex = 117;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 80;
            // 
            // MaLoaiThuoc
            // 
            this.MaLoaiThuoc.DataPropertyName = "MaLoaiThuoc";
            this.MaLoaiThuoc.HeaderText = "MÃ LOẠI THUỐC";
            this.MaLoaiThuoc.MinimumWidth = 6;
            this.MaLoaiThuoc.Name = "MaLoaiThuoc";
            this.MaLoaiThuoc.ReadOnly = true;
            this.MaLoaiThuoc.Width = 200;
            // 
            // TenLoaiThuoc
            // 
            this.TenLoaiThuoc.DataPropertyName = "TenLoaiThuoc";
            this.TenLoaiThuoc.HeaderText = "TÊN LOẠI THUỐC";
            this.TenLoaiThuoc.MinimumWidth = 6;
            this.TenLoaiThuoc.Name = "TenLoaiThuoc";
            this.TenLoaiThuoc.ReadOnly = true;
            this.TenLoaiThuoc.Width = 200;
            // 
            // SoLuongThuoc
            // 
            this.SoLuongThuoc.DataPropertyName = "SoLuongThuoc";
            this.SoLuongThuoc.HeaderText = "SỐ LƯỢNG THUỐC";
            this.SoLuongThuoc.MinimumWidth = 6;
            this.SoLuongThuoc.Name = "SoLuongThuoc";
            this.SoLuongThuoc.ReadOnly = true;
            this.SoLuongThuoc.Width = 200;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "ĐƠN GIÁ";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 200;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "THÀNH TIỀN";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 200;
            // 
            // btnLapHD
            // 
            this.btnLapHD.Location = new System.Drawing.Point(40, 582);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(280, 44);
            this.btnLapHD.TabIndex = 118;
            this.btnLapHD.Text = "Lập hóa đơn thanh toán";
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1028, 582);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 44);
            this.btnExit.TabIndex = 119;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnHDMoi
            // 
            this.btnHDMoi.Location = new System.Drawing.Point(397, 582);
            this.btnHDMoi.Name = "btnHDMoi";
            this.btnHDMoi.Size = new System.Drawing.Size(221, 44);
            this.btnHDMoi.TabIndex = 120;
            this.btnHDMoi.Text = "Lập hóa đơn mới \r\n";
            this.btnHDMoi.UseVisualStyleBackColor = true;
            this.btnHDMoi.Click += new System.EventHandler(this.btnHDMoi_Click);
            // 
            // btnTimHD
            // 
            this.btnTimHD.Location = new System.Drawing.Point(706, 582);
            this.btnTimHD.Name = "btnTimHD";
            this.btnTimHD.Size = new System.Drawing.Size(221, 44);
            this.btnTimHD.TabIndex = 121;
            this.btnTimHD.Text = "Tìm hóa đơn";
            this.btnTimHD.UseVisualStyleBackColor = true;
            this.btnTimHD.Click += new System.EventHandler(this.btnTimHD_Click);
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMaHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaHoaDon.Enabled = false;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(853, 280);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(7);
            this.txtMaHoaDon.Multiline = true;
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(252, 48);
            this.txtMaHoaDon.TabIndex = 123;
            this.txtMaHoaDon.TabStop = false;
            this.txtMaHoaDon.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(848, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 29);
            this.label7.TabIndex = 122;
            this.label7.Text = "Mã hóa đơn";
            this.label7.Visible = false;
            // 
            // GUI_LapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 638);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTimHD);
            this.Controls.Add(this.btnHDMoi);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTienKham);
            this.Controls.Add(this.txtTienThuoc);
            this.Controls.Add(this.txtNgayKham);
            this.Controls.Add(this.txtTenBenhNhan);
            this.Controls.Add(this.txtMaKhamBenh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GUI_LapHoaDon";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaKhamBenh;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.TextBox txtNgayKham;
        private System.Windows.Forms.TextBox txtTienThuoc;
        private System.Windows.Forms.TextBox txtTienKham;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label label7;
    }
}