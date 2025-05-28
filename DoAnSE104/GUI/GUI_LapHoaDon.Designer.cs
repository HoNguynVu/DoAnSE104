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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoluongThuoc
            // 
            this.txtSoluongThuoc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSoluongThuoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSoluongThuoc.Enabled = false;
            this.txtSoluongThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluongThuoc.Location = new System.Drawing.Point(610, 406);
            this.txtSoluongThuoc.Margin = new System.Windows.Forms.Padding(7);
            this.txtSoluongThuoc.Multiline = true;
            this.txtSoluongThuoc.Name = "txtSoluongThuoc";
            this.txtSoluongThuoc.Size = new System.Drawing.Size(168, 48);
            this.txtSoluongThuoc.TabIndex = 113;
            this.txtSoluongThuoc.TabStop = false;
            // 
            // txtSTT
            // 
            this.txtSTT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSTT.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSTT.Enabled = false;
            this.txtSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTT.Location = new System.Drawing.Point(30, 406);
            this.txtSTT.Margin = new System.Windows.Forms.Padding(7);
            this.txtSTT.Multiline = true;
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(99, 48);
            this.txtSTT.TabIndex = 110;
            this.txtSTT.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(25, 370);
            this.label7.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 97;
            this.label7.Text = "STT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(138, 370);
            this.label8.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 24);
            this.label8.TabIndex = 98;
            this.label8.Text = "Mã loại thuốc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(605, 370);
            this.label9.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 24);
            this.label9.TabIndex = 99;
            this.label9.Text = "Số lượng thuốc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(787, 370);
            this.label10.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 24);
            this.label10.TabIndex = 100;
            this.label10.Text = "Đơn giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(339, 370);
            this.label11.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 24);
            this.label11.TabIndex = 101;
            this.label11.Text = "Tên loại thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(974, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 100;
            this.label1.Text = "Thành tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(35, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
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
            this.label3.Size = new System.Drawing.Size(141, 24);
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
            this.label4.Size = new System.Drawing.Size(105, 24);
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
            this.label5.Size = new System.Drawing.Size(99, 24);
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
            this.label6.Size = new System.Drawing.Size(100, 24);
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
            this.label13.Size = new System.Drawing.Size(447, 51);
            this.label13.TabIndex = 116;
            this.label13.Text = "Lập hóa đơn thanh toán";
            // 
            // txtMaKhamBenh
            // 
            this.txtMaKhamBenh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMaKhamBenh.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaKhamBenh.Enabled = false;
            this.txtMaKhamBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhamBenh.Location = new System.Drawing.Point(41, 165);
            this.txtMaKhamBenh.Margin = new System.Windows.Forms.Padding(7);
            this.txtMaKhamBenh.Multiline = true;
            this.txtMaKhamBenh.Name = "txtMaKhamBenh";
            this.txtMaKhamBenh.Size = new System.Drawing.Size(252, 48);
            this.txtMaKhamBenh.TabIndex = 110;
            this.txtMaKhamBenh.TabStop = false;
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
            this.txtTienKham.Enabled = false;
            this.txtTienKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKham.Location = new System.Drawing.Point(41, 280);
            this.txtTienKham.Margin = new System.Windows.Forms.Padding(7);
            this.txtTienKham.Multiline = true;
            this.txtTienKham.Name = "txtTienKham";
            this.txtTienKham.Size = new System.Drawing.Size(252, 48);
            this.txtTienKham.TabIndex = 110;
            this.txtTienKham.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridView1.Size = new System.Drawing.Size(1102, 76);
            this.dataGridView1.TabIndex = 117;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 80;
            // 
            // MaLoaiThuoc
            // 
            this.MaLoaiThuoc.HeaderText = "MÃ LOẠI THUỐC";
            this.MaLoaiThuoc.MinimumWidth = 6;
            this.MaLoaiThuoc.Name = "MaLoaiThuoc";
            this.MaLoaiThuoc.Width = 200;
            // 
            // TenLoaiThuoc
            // 
            this.TenLoaiThuoc.HeaderText = "TÊN LOẠI THUỐC";
            this.TenLoaiThuoc.MinimumWidth = 6;
            this.TenLoaiThuoc.Name = "TenLoaiThuoc";
            this.TenLoaiThuoc.Width = 200;
            // 
            // SoLuongThuoc
            // 
            this.SoLuongThuoc.HeaderText = "SỐ LƯỢNG THUỐC";
            this.SoLuongThuoc.MinimumWidth = 6;
            this.SoLuongThuoc.Name = "SoLuongThuoc";
            this.SoLuongThuoc.Width = 200;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "ĐƠN GIÁ";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 200;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "THÀNH TIỀN";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 200;
            // 
            // GUI_LapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 542);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}