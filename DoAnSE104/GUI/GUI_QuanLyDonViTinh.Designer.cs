namespace DoAnSE104.GUI
{
    partial class GUI_QuanLyDonViTinh
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
            this.labelThemDonViTinh = new System.Windows.Forms.Label();
            this.labelMaDonVi = new System.Windows.Forms.Label();
            this.txtMaDonVi = new System.Windows.Forms.TextBox();
            this.labelTenDonVi = new System.Windows.Forms.Label();
            this.txtTenDonVi = new System.Windows.Forms.TextBox();
            this.btnThemDonVi = new System.Windows.Forms.Button();
            this.dgvDanhSachLoaiThuoc = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThaoTac = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(34, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(615, 86);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Quản lý đơn vị tính";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            //this.groupBox1.Controls.Add(this.btnSave);
            //this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.labelThemDonViTinh);
            this.groupBox1.Controls.Add(this.labelMaDonVi);
            this.groupBox1.Controls.Add(this.txtMaDonVi);
            this.groupBox1.Controls.Add(this.labelTenDonVi);
            this.groupBox1.Controls.Add(this.txtTenDonVi);
            this.groupBox1.Controls.Add(this.btnThemDonVi);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(34, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.groupBox1.Size = new System.Drawing.Size(1238, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // labelThemDonViTinh
            // 
            this.labelThemDonViTinh.AutoSize = true;
            this.labelThemDonViTinh.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelThemDonViTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelThemDonViTinh.Location = new System.Drawing.Point(28, 31);
            this.labelThemDonViTinh.Name = "labelThemDonViTinh";
            this.labelThemDonViTinh.Size = new System.Drawing.Size(275, 45);
            this.labelThemDonViTinh.TabIndex = 0;
            this.labelThemDonViTinh.Text = "Thêm đơn vị tính";
            // 
            // labelMaDonVi
            // 
            this.labelMaDonVi.AutoSize = true;
            this.labelMaDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaDonVi.Location = new System.Drawing.Point(34, 94);
            this.labelMaDonVi.Name = "labelMaDonVi";
            this.labelMaDonVi.Size = new System.Drawing.Size(122, 32);
            this.labelMaDonVi.TabIndex = 1;
            this.labelMaDonVi.Text = "Mã đơn vị";
            // 
            // txtMaDonVi
            // 
            this.txtMaDonVi.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaDonVi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaDonVi.Location = new System.Drawing.Point(38, 131);
            this.txtMaDonVi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDonVi.Name = "txtMaDonVi";
            this.txtMaDonVi.ReadOnly = true;
            this.txtMaDonVi.Size = new System.Drawing.Size(247, 39);
            this.txtMaDonVi.TabIndex = 2;
            // 
            // labelTenDonVi
            // 
            this.labelTenDonVi.AutoSize = true;
            this.labelTenDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTenDonVi.Location = new System.Drawing.Point(304, 94);
            this.labelTenDonVi.Name = "labelTenDonVi";
            this.labelTenDonVi.Size = new System.Drawing.Size(126, 32);
            this.labelTenDonVi.TabIndex = 3;
            this.labelTenDonVi.Text = "Tên đơn vị";
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenDonVi.Location = new System.Drawing.Point(308, 131);
            this.txtTenDonVi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.Size = new System.Drawing.Size(247, 39);
            this.txtTenDonVi.TabIndex = 4;
            // 
            // btnThemDonVi
            // 
            this.btnThemDonVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnThemDonVi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDonVi.FlatAppearance.BorderSize = 0;
            this.btnThemDonVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDonVi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemDonVi.ForeColor = System.Drawing.Color.White;
            this.btnThemDonVi.Location = new System.Drawing.Point(1043, 31);
            this.btnThemDonVi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemDonVi.Name = "btnThemDonVi";
            this.btnThemDonVi.Size = new System.Drawing.Size(169, 56);
            this.btnThemDonVi.TabIndex = 5;
            this.btnThemDonVi.Text = "Thêm đơn vị";
            this.btnThemDonVi.UseVisualStyleBackColor = false;
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
            this.MaDonVi,
            this.TenDonVi,
            this.ThaoTac});
            this.dgvDanhSachLoaiThuoc.EnableHeadersVisualStyles = false;
            this.dgvDanhSachLoaiThuoc.GridColor = System.Drawing.Color.LightGray;
            this.dgvDanhSachLoaiThuoc.Location = new System.Drawing.Point(34, 450);
            this.dgvDanhSachLoaiThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachLoaiThuoc.Name = "dgvDanhSachLoaiThuoc";
            this.dgvDanhSachLoaiThuoc.RowHeadersVisible = false;
            this.dgvDanhSachLoaiThuoc.RowHeadersWidth = 51;
            this.dgvDanhSachLoaiThuoc.RowTemplate.Height = 32;
            this.dgvDanhSachLoaiThuoc.Size = new System.Drawing.Size(1100, 277);
            this.dgvDanhSachLoaiThuoc.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaDonVi
            // 
            this.MaDonVi.HeaderText = "MÃ ĐƠN VỊ";
            this.MaDonVi.MinimumWidth = 6;
            this.MaDonVi.Name = "MaDonVi";
            // 
            // TenDonVi
            // 
            this.TenDonVi.HeaderText = "TÊN ĐƠN VỊ";
            this.TenDonVi.MinimumWidth = 6;
            this.TenDonVi.Name = "TenDonVi";
            // 
            // ThaoTac
            // 
            this.ThaoTac.HeaderText = "THAO TÁC";
            this.ThaoTac.MinimumWidth = 6;
            this.ThaoTac.Name = "ThaoTac";
            this.ThaoTac.Text = "Xóa";
            this.ThaoTac.UseColumnTextForButtonValue = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(733, 643);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(187, 45);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(943, 643);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(187, 45);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // GUI_QuanLyDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 700);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvDanhSachLoaiThuoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI_QuanLyDonViTinh";
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
        private System.Windows.Forms.Label labelThemDonViTinh;
        private System.Windows.Forms.Label labelMaDonVi;
        private System.Windows.Forms.TextBox txtMaDonVi;
        private System.Windows.Forms.Label labelTenDonVi;
        private System.Windows.Forms.TextBox txtTenDonVi;
        private System.Windows.Forms.Button btnThemDonVi;
        private System.Windows.Forms.DataGridView dgvDanhSachLoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDonVi;
        private System.Windows.Forms.DataGridViewButtonColumn ThaoTac;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}