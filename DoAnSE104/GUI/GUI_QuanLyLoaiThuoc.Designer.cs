namespace DoAnSE104.GUI
{
    partial class GUI_QuanLyLoaiThuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelThemLoaiThuoc = new System.Windows.Forms.Label();
            this.labelMaLoaiThuoc = new System.Windows.Forms.Label();
            this.txtMaLoaiThuoc = new System.Windows.Forms.TextBox();
            this.labelTenLoaiThuoc = new System.Windows.Forms.Label();
            this.txtTenLoaiThuoc = new System.Windows.Forms.TextBox();
            this.labelDonVi = new System.Windows.Forms.Label();
            this.cbbDonVi = new System.Windows.Forms.ComboBox();
            this.labelCachDung = new System.Windows.Forms.Label();
            this.cbbCachDung = new System.Windows.Forms.ComboBox();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnThemDonVi = new System.Windows.Forms.Button();
            this.dgvDanhSachLoaiThuoc = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThaoTac = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(493, 72);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Quản lý loại thuốc";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelThemLoaiThuoc);
            this.groupBox1.Controls.Add(this.labelMaLoaiThuoc);
            this.groupBox1.Controls.Add(this.txtMaLoaiThuoc);
            this.groupBox1.Controls.Add(this.labelTenLoaiThuoc);
            this.groupBox1.Controls.Add(this.txtTenLoaiThuoc);
            this.groupBox1.Controls.Add(this.labelDonVi);
            this.groupBox1.Controls.Add(this.cbbDonVi);
            this.groupBox1.Controls.Add(this.labelCachDung);
            this.groupBox1.Controls.Add(this.cbbCachDung);
            this.groupBox1.Controls.Add(this.labelDonGia);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.btnThemDonVi);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(30, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(1100, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // labelThemLoaiThuoc
            // 
            this.labelThemLoaiThuoc.AutoSize = true;
            this.labelThemLoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelThemLoaiThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelThemLoaiThuoc.Location = new System.Drawing.Point(25, 25);
            this.labelThemLoaiThuoc.Name = "labelThemLoaiThuoc";
            this.labelThemLoaiThuoc.Size = new System.Drawing.Size(224, 37);
            this.labelThemLoaiThuoc.TabIndex = 0;
            this.labelThemLoaiThuoc.Text = "Thêm loại thuốc";
            // 
            // labelMaLoaiThuoc
            // 
            this.labelMaLoaiThuoc.AutoSize = true;
            this.labelMaLoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaLoaiThuoc.Location = new System.Drawing.Point(30, 75);
            this.labelMaLoaiThuoc.Name = "labelMaLoaiThuoc";
            this.labelMaLoaiThuoc.Size = new System.Drawing.Size(132, 28);
            this.labelMaLoaiThuoc.TabIndex = 1;
            this.labelMaLoaiThuoc.Text = "Mã loại thuốc";
            // 
            // txtMaLoaiThuoc
            // 
            this.txtMaLoaiThuoc.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaLoaiThuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaLoaiThuoc.Location = new System.Drawing.Point(34, 105);
            this.txtMaLoaiThuoc.Name = "txtMaLoaiThuoc";
            this.txtMaLoaiThuoc.ReadOnly = true;
            this.txtMaLoaiThuoc.Size = new System.Drawing.Size(220, 34);
            this.txtMaLoaiThuoc.TabIndex = 2;
            // 
            // labelTenLoaiThuoc
            // 
            this.labelTenLoaiThuoc.AutoSize = true;
            this.labelTenLoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTenLoaiThuoc.Location = new System.Drawing.Point(270, 75);
            this.labelTenLoaiThuoc.Name = "labelTenLoaiThuoc";
            this.labelTenLoaiThuoc.Size = new System.Drawing.Size(133, 28);
            this.labelTenLoaiThuoc.TabIndex = 3;
            this.labelTenLoaiThuoc.Text = "Tên loại thuốc";
            // 
            // txtTenLoaiThuoc
            // 
            this.txtTenLoaiThuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenLoaiThuoc.Location = new System.Drawing.Point(274, 105);
            this.txtTenLoaiThuoc.Name = "txtTenLoaiThuoc";
            this.txtTenLoaiThuoc.Size = new System.Drawing.Size(220, 34);
            this.txtTenLoaiThuoc.TabIndex = 4;
            // 
            // labelDonVi
            // 
            this.labelDonVi.AutoSize = true;
            this.labelDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDonVi.Location = new System.Drawing.Point(520, 75);
            this.labelDonVi.Name = "labelDonVi";
            this.labelDonVi.Size = new System.Drawing.Size(69, 28);
            this.labelDonVi.TabIndex = 5;
            this.labelDonVi.Text = "Đơn vị";
            // 
            // cbbDonVi
            // 
            this.cbbDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbDonVi.Location = new System.Drawing.Point(524, 105);
            this.cbbDonVi.Name = "cbbDonVi";
            this.cbbDonVi.Size = new System.Drawing.Size(180, 36);
            this.cbbDonVi.TabIndex = 6;
            // 
            // labelCachDung
            // 
            this.labelCachDung.AutoSize = true;
            this.labelCachDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelCachDung.Location = new System.Drawing.Point(30, 150);
            this.labelCachDung.Name = "labelCachDung";
            this.labelCachDung.Size = new System.Drawing.Size(105, 28);
            this.labelCachDung.TabIndex = 7;
            this.labelCachDung.Text = "Cách dùng";
            // 
            // cbbCachDung
            // 
            this.cbbCachDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCachDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbCachDung.Location = new System.Drawing.Point(34, 180);
            this.cbbCachDung.Name = "cbbCachDung";
            this.cbbCachDung.Size = new System.Drawing.Size(350, 36);
            this.cbbCachDung.TabIndex = 8;
            // 
            // labelDonGia
            // 
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDonGia.Location = new System.Drawing.Point(730, 75);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(81, 28);
            this.labelDonGia.TabIndex = 9;
            this.labelDonGia.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDonGia.Location = new System.Drawing.Point(734, 105);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(180, 34);
            this.txtDonGia.TabIndex = 10;
            // 
            // btnThemDonVi
            // 
            this.btnThemDonVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnThemDonVi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDonVi.FlatAppearance.BorderSize = 0;
            this.btnThemDonVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDonVi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemDonVi.ForeColor = System.Drawing.Color.White;
            this.btnThemDonVi.Location = new System.Drawing.Point(892, 25);
            this.btnThemDonVi.Name = "btnThemDonVi";
            this.btnThemDonVi.Size = new System.Drawing.Size(185, 45);
            this.btnThemDonVi.TabIndex = 5;
            this.btnThemDonVi.Text = "Thêm loại thuốc";
            this.btnThemDonVi.UseVisualStyleBackColor = false;
            // 
            // dgvDanhSachLoaiThuoc
            // 
            this.dgvDanhSachLoaiThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLoaiThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachLoaiThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachLoaiThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachLoaiThuoc.ColumnHeadersHeight = 29;
            this.dgvDanhSachLoaiThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaLoaiThuoc,
            this.TenLoaiThuoc,
            this.DonVi,
            this.CachDung,
            this.DonGia,
            this.ThaoTac});
            this.dgvDanhSachLoaiThuoc.EnableHeadersVisualStyles = false;
            this.dgvDanhSachLoaiThuoc.GridColor = System.Drawing.Color.LightGray;
            this.dgvDanhSachLoaiThuoc.Location = new System.Drawing.Point(30, 360);
            this.dgvDanhSachLoaiThuoc.Name = "dgvDanhSachLoaiThuoc";
            this.dgvDanhSachLoaiThuoc.RowHeadersVisible = false;
            this.dgvDanhSachLoaiThuoc.RowHeadersWidth = 51;
            this.dgvDanhSachLoaiThuoc.RowTemplate.Height = 32;
            this.dgvDanhSachLoaiThuoc.Size = new System.Drawing.Size(1100, 300);
            this.dgvDanhSachLoaiThuoc.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaLoaiThuoc
            // 
            this.MaLoaiThuoc.HeaderText = "MÃ LOẠI THUỐC";
            this.MaLoaiThuoc.MinimumWidth = 6;
            this.MaLoaiThuoc.Name = "MaLoaiThuoc";
            // 
            // TenLoaiThuoc
            // 
            this.TenLoaiThuoc.HeaderText = "TÊN LOẠI THUỐC";
            this.TenLoaiThuoc.MinimumWidth = 6;
            this.TenLoaiThuoc.Name = "TenLoaiThuoc";
            // 
            // DonVi
            // 
            this.DonVi.HeaderText = "ĐƠN VỊ";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            // 
            // CachDung
            // 
            this.CachDung.HeaderText = "CÁCH DÙNG";
            this.CachDung.MinimumWidth = 6;
            this.CachDung.Name = "CachDung";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "ĐƠN GIÁ";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // ThaoTac
            // 
            this.ThaoTac.HeaderText = "THAO TÁC";
            this.ThaoTac.MinimumWidth = 6;
            this.ThaoTac.Name = "ThaoTac";
            this.ThaoTac.Text = "Xóa";
            this.ThaoTac.UseColumnTextForButtonValue = true;
            // 
            // GUI_QuanLyLoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 700);
            this.Controls.Add(this.dgvDanhSachLoaiThuoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "GUI_QuanLyLoaiThuoc";
            this.Text = "Quản lý loại thuốc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelThemLoaiThuoc;
        private System.Windows.Forms.Label labelMaLoaiThuoc;
        private System.Windows.Forms.TextBox txtMaLoaiThuoc;
        private System.Windows.Forms.Label labelTenLoaiThuoc;
        private System.Windows.Forms.TextBox txtTenLoaiThuoc;
        private System.Windows.Forms.Label labelDonVi;
        private System.Windows.Forms.ComboBox cbbDonVi;
        private System.Windows.Forms.Label labelCachDung;
        private System.Windows.Forms.ComboBox cbbCachDung;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThemDonVi;
        private System.Windows.Forms.DataGridView dgvDanhSachLoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewButtonColumn ThaoTac;
    }
}