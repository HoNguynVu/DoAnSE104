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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelThemDonViTinh = new System.Windows.Forms.Label();
            this.labelMaDonVi = new System.Windows.Forms.Label();
            this.txtMaDonVi = new System.Windows.Forms.TextBox();
            this.labelTenDonVi = new System.Windows.Forms.Label();
            this.txtTenDonVi = new System.Windows.Forms.TextBox();
            this.btnThemDonVi = new System.Windows.Forms.Button();
            this.dgvDanhSachDonVi = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThaoTac = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDonVi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(517, 72);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Quản lý đơn vị tính";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.labelThemDonViTinh);
            this.groupBoxInfo.Controls.Add(this.labelMaDonVi);
            this.groupBoxInfo.Controls.Add(this.txtMaDonVi);
            this.groupBoxInfo.Controls.Add(this.labelTenDonVi);
            this.groupBoxInfo.Controls.Add(this.txtTenDonVi);
            this.groupBoxInfo.Controls.Add(this.btnThemDonVi);
            this.groupBoxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(30, 110);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxInfo.Size = new System.Drawing.Size(1100, 230);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            // 
            // labelThemDonViTinh
            // 
            this.labelThemDonViTinh.AutoSize = true;
            this.labelThemDonViTinh.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelThemDonViTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelThemDonViTinh.Location = new System.Drawing.Point(25, 35);
            this.labelThemDonViTinh.Name = "labelThemDonViTinh";
            this.labelThemDonViTinh.Size = new System.Drawing.Size(234, 37);
            this.labelThemDonViTinh.TabIndex = 0;
            this.labelThemDonViTinh.Text = "Thêm đơn vị tính";
            // 
            // labelMaDonVi
            // 
            this.labelMaDonVi.AutoSize = true;
            this.labelMaDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaDonVi.Location = new System.Drawing.Point(30, 90);
            this.labelMaDonVi.Name = "labelMaDonVi";
            this.labelMaDonVi.Size = new System.Drawing.Size(100, 28);
            this.labelMaDonVi.TabIndex = 1;
            this.labelMaDonVi.Text = "Mã đơn vị";
            // 
            // txtMaDonVi
            // 
            this.txtMaDonVi.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaDonVi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaDonVi.Location = new System.Drawing.Point(34, 120);
            this.txtMaDonVi.Name = "txtMaDonVi";
            this.txtMaDonVi.ReadOnly = true;
            this.txtMaDonVi.Size = new System.Drawing.Size(220, 34);
            this.txtMaDonVi.TabIndex = 2;
            // 
            // labelTenDonVi
            // 
            this.labelTenDonVi.AutoSize = true;
            this.labelTenDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTenDonVi.Location = new System.Drawing.Point(270, 90);
            this.labelTenDonVi.Name = "labelTenDonVi";
            this.labelTenDonVi.Size = new System.Drawing.Size(101, 28);
            this.labelTenDonVi.TabIndex = 3;
            this.labelTenDonVi.Text = "Tên đơn vị";
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenDonVi.Location = new System.Drawing.Point(274, 120);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.Size = new System.Drawing.Size(220, 34);
            this.txtTenDonVi.TabIndex = 4;
            // 
            // btnThemDonVi
            // 
            this.btnThemDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemDonVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnThemDonVi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDonVi.FlatAppearance.BorderSize = 0;
            this.btnThemDonVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDonVi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemDonVi.ForeColor = System.Drawing.Color.White;
            this.btnThemDonVi.Location = new System.Drawing.Point(877, 34);
            this.btnThemDonVi.Name = "btnThemDonVi";
            this.btnThemDonVi.Size = new System.Drawing.Size(200, 44);
            this.btnThemDonVi.TabIndex = 5;
            this.btnThemDonVi.Text = "Thêm đơn vị";
            this.btnThemDonVi.UseVisualStyleBackColor = false;
            this.btnThemDonVi.Click += new System.EventHandler(this.btnThemDonVi_Click_1);
            // 
            // dgvDanhSachDonVi
            // 
            this.dgvDanhSachDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachDonVi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachDonVi.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachDonVi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachDonVi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachDonVi.ColumnHeadersHeight = 32;
            this.dgvDanhSachDonVi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDonVi,
            this.TenDonVi,
            this.ThaoTac});
            this.dgvDanhSachDonVi.EnableHeadersVisualStyles = false;
            this.dgvDanhSachDonVi.GridColor = System.Drawing.Color.LightGray;
            this.dgvDanhSachDonVi.Location = new System.Drawing.Point(30, 360);
            this.dgvDanhSachDonVi.Name = "dgvDanhSachDonVi";
            this.dgvDanhSachDonVi.RowHeadersVisible = false;
            this.dgvDanhSachDonVi.RowHeadersWidth = 51;
            this.dgvDanhSachDonVi.RowTemplate.Height = 32;
            this.dgvDanhSachDonVi.Size = new System.Drawing.Size(1100, 230);
            this.dgvDanhSachDonVi.TabIndex = 2;
            this.dgvDanhSachDonVi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDonVi_CellClick_1);
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
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(30, 605);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(200, 44);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(930, 605);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(200, 44);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // GUI_QuanLyDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 670);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvDanhSachDonVi);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "GUI_QuanLyDonViTinh";
            this.Text = "Quản lý đơn vị tính";
            this.Load += new System.EventHandler(this.GUI_QuanLyDonViTinh_Load_1);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDonVi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelMaDonVi;
        private System.Windows.Forms.TextBox txtMaDonVi;
        private System.Windows.Forms.Label labelTenDonVi;
        private System.Windows.Forms.TextBox txtTenDonVi;
        private System.Windows.Forms.Button btnThemDonVi;
        private System.Windows.Forms.DataGridView dgvDanhSachDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDonVi;
        private System.Windows.Forms.DataGridViewButtonColumn ThaoTac;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label labelThemDonViTinh;
    }
}