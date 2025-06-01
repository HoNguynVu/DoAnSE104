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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelThemLoaiThuoc = new System.Windows.Forms.Label();
            this.labelMaLoaiThuoc = new System.Windows.Forms.Label();
            this.txtMaLoaiThuoc = new System.Windows.Forms.TextBox();
            this.labelTenLoaiThuoc = new System.Windows.Forms.Label();
            this.txtTenLoaiThuoc = new System.Windows.Forms.TextBox();
            this.labelDonVi = new System.Windows.Forms.Label();
            this.cbDonVi = new System.Windows.Forms.ComboBox();
            this.labelCachDung = new System.Windows.Forms.Label();
            this.cbCachDung = new System.Windows.Forms.ComboBox();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnThemLoaiThuoc = new System.Windows.Forms.Button();
            this.dgvDanhSachLoaiThuoc = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiThuocItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiThuocItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cachDungItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.groupBox1.Controls.Add(this.cbDonVi);
            this.groupBox1.Controls.Add(this.labelCachDung);
            this.groupBox1.Controls.Add(this.cbCachDung);
            this.groupBox1.Controls.Add(this.labelDonGia);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.btnThemLoaiThuoc);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(30, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
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
            this.txtTenLoaiThuoc.TextChanged += new System.EventHandler(this.txtTenLoaiThuoc_TextChanged);
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
            // cbDonVi
            // 
            this.cbDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbDonVi.Location = new System.Drawing.Point(524, 105);
            this.cbDonVi.Name = "cbDonVi";
            this.cbDonVi.Size = new System.Drawing.Size(180, 36);
            this.cbDonVi.TabIndex = 6;
            this.cbDonVi.SelectedIndexChanged += new System.EventHandler(this.cbDonVi_SelectedIndexChanged);
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
            // cbCachDung
            // 
            this.cbCachDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCachDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbCachDung.Location = new System.Drawing.Point(34, 180);
            this.cbCachDung.Name = "cbCachDung";
            this.cbCachDung.Size = new System.Drawing.Size(350, 36);
            this.cbCachDung.TabIndex = 8;
            this.cbCachDung.SelectedIndexChanged += new System.EventHandler(this.cbCachDung_SelectedIndexChanged);
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
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // btnThemLoaiThuoc
            // 
            this.btnThemLoaiThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnThemLoaiThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemLoaiThuoc.FlatAppearance.BorderSize = 0;
            this.btnThemLoaiThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemLoaiThuoc.ForeColor = System.Drawing.Color.White;
            this.btnThemLoaiThuoc.Location = new System.Drawing.Point(892, 25);
            this.btnThemLoaiThuoc.Name = "btnThemLoaiThuoc";
            this.btnThemLoaiThuoc.Size = new System.Drawing.Size(185, 45);
            this.btnThemLoaiThuoc.TabIndex = 5;
            this.btnThemLoaiThuoc.Text = "Thêm loại thuốc";
            this.btnThemLoaiThuoc.UseVisualStyleBackColor = false;
            this.btnThemLoaiThuoc.Click += new System.EventHandler(this.btnThemLoaiThuoc_Click);
            // 
            // dgvDanhSachLoaiThuoc
            // 
            this.dgvDanhSachLoaiThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLoaiThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachLoaiThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachLoaiThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachLoaiThuoc.ColumnHeadersHeight = 29;
            this.dgvDanhSachLoaiThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maLoaiThuocItem,
            this.tenLoaiThuocItem,
            this.donViItem,
            this.cachDungItem,
            this.donGiaItem,
            this.btnXoa});
            this.dgvDanhSachLoaiThuoc.EnableHeadersVisualStyles = false;
            this.dgvDanhSachLoaiThuoc.GridColor = System.Drawing.Color.LightGray;
            this.dgvDanhSachLoaiThuoc.Location = new System.Drawing.Point(30, 360);
            this.dgvDanhSachLoaiThuoc.Name = "dgvDanhSachLoaiThuoc";
            this.dgvDanhSachLoaiThuoc.RowHeadersVisible = false;
            this.dgvDanhSachLoaiThuoc.RowHeadersWidth = 51;
            this.dgvDanhSachLoaiThuoc.RowTemplate.Height = 32;
            this.dgvDanhSachLoaiThuoc.Size = new System.Drawing.Size(978, 222);
            this.dgvDanhSachLoaiThuoc.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(652, 514);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(166, 36);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(838, 514);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(166, 36);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // maLoaiThuocItem
            // 
            this.maLoaiThuocItem.HeaderText = "MÃ LOẠI THUỐC";
            this.maLoaiThuocItem.MinimumWidth = 6;
            this.maLoaiThuocItem.Name = "maLoaiThuocItem";
            // 
            // tenLoaiThuocItem
            // 
            this.tenLoaiThuocItem.HeaderText = "TÊN LOẠI THUỐC";
            this.tenLoaiThuocItem.MinimumWidth = 6;
            this.tenLoaiThuocItem.Name = "tenLoaiThuocItem";
            // 
            // donViItem
            // 
            this.donViItem.HeaderText = "ĐƠN VỊ";
            this.donViItem.MinimumWidth = 6;
            this.donViItem.Name = "donViItem";
            // 
            // cachDungItem
            // 
            this.cachDungItem.HeaderText = "CÁCH DÙNG";
            this.cachDungItem.MinimumWidth = 6;
            this.cachDungItem.Name = "cachDungItem";
            // 
            // donGiaItem
            // 
            this.donGiaItem.HeaderText = "ĐƠN GIÁ";
            this.donGiaItem.MinimumWidth = 6;
            this.donGiaItem.Name = "donGiaItem";
            // 
            // btnXoa
            // 
            this.btnXoa.HeaderText = "THAO TÁC";
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseColumnTextForButtonValue = true;
            // 
            // GUI_QuanLyLoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 560);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
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
        private System.Windows.Forms.ComboBox cbDonVi;
        private System.Windows.Forms.Label labelCachDung;
        private System.Windows.Forms.ComboBox cbCachDung;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThemLoaiThuoc;
        private System.Windows.Forms.DataGridView dgvDanhSachLoaiThuoc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiThuocItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiThuocItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cachDungItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaItem;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}