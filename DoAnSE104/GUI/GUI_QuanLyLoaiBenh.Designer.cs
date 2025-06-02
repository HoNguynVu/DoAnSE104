namespace DoAnSE104.GUI
{
    partial class GUI_QuanLyLoaiBenh
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
            this.labelThemLoaiBenh = new System.Windows.Forms.Label();
            this.labelMaLoaiBenh = new System.Windows.Forms.Label();
            this.txtMaLoaiBenh = new System.Windows.Forms.TextBox();
            this.labelTenLoaiBenh = new System.Windows.Forms.Label();
            this.txtTenLoaiBenh = new System.Windows.Forms.TextBox();
            this.btnThemLoaiBenh = new System.Windows.Forms.Button();
            this.dgvDanhSachLoaiBenh = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThaoTac = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiBenh)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(475, 72);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Quản lý loại bệnh";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.labelThemLoaiBenh);
            this.groupBoxInfo.Controls.Add(this.labelMaLoaiBenh);
            this.groupBoxInfo.Controls.Add(this.txtMaLoaiBenh);
            this.groupBoxInfo.Controls.Add(this.labelTenLoaiBenh);
            this.groupBoxInfo.Controls.Add(this.txtTenLoaiBenh);
            this.groupBoxInfo.Controls.Add(this.btnThemLoaiBenh);
            this.groupBoxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(30, 110);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxInfo.Size = new System.Drawing.Size(1100, 230);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            // 
            // labelThemLoaiBenh
            // 
            this.labelThemLoaiBenh.AutoSize = true;
            this.labelThemLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelThemLoaiBenh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelThemLoaiBenh.Location = new System.Drawing.Point(25, 35);
            this.labelThemLoaiBenh.Name = "labelThemLoaiBenh";
            this.labelThemLoaiBenh.Size = new System.Drawing.Size(215, 37);
            this.labelThemLoaiBenh.TabIndex = 0;
            this.labelThemLoaiBenh.Text = "Thêm loại bệnh";
            // 
            // labelMaLoaiBenh
            // 
            this.labelMaLoaiBenh.AutoSize = true;
            this.labelMaLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaLoaiBenh.Location = new System.Drawing.Point(30, 90);
            this.labelMaLoaiBenh.Name = "labelMaLoaiBenh";
            this.labelMaLoaiBenh.Size = new System.Drawing.Size(126, 28);
            this.labelMaLoaiBenh.TabIndex = 1;
            this.labelMaLoaiBenh.Text = "Mã loại bệnh";
            // 
            // txtMaLoaiBenh
            // 
            this.txtMaLoaiBenh.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaLoaiBenh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaLoaiBenh.Location = new System.Drawing.Point(34, 120);
            this.txtMaLoaiBenh.Name = "txtMaLoaiBenh";
            this.txtMaLoaiBenh.ReadOnly = true;
            this.txtMaLoaiBenh.Size = new System.Drawing.Size(220, 34);
            this.txtMaLoaiBenh.TabIndex = 2;
            // 
            // labelTenLoaiBenh
            // 
            this.labelTenLoaiBenh.AutoSize = true;
            this.labelTenLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTenLoaiBenh.Location = new System.Drawing.Point(270, 90);
            this.labelTenLoaiBenh.Name = "labelTenLoaiBenh";
            this.labelTenLoaiBenh.Size = new System.Drawing.Size(127, 28);
            this.labelTenLoaiBenh.TabIndex = 3;
            this.labelTenLoaiBenh.Text = "Tên loại bệnh";
            // 
            // txtTenLoaiBenh
            // 
            this.txtTenLoaiBenh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenLoaiBenh.Location = new System.Drawing.Point(274, 120);
            this.txtTenLoaiBenh.Name = "txtTenLoaiBenh";
            this.txtTenLoaiBenh.Size = new System.Drawing.Size(220, 34);
            this.txtTenLoaiBenh.TabIndex = 4;
            // 
            // btnThemLoaiBenh
            // 
            this.btnThemLoaiBenh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemLoaiBenh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnThemLoaiBenh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemLoaiBenh.FlatAppearance.BorderSize = 0;
            this.btnThemLoaiBenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemLoaiBenh.ForeColor = System.Drawing.Color.White;
            this.btnThemLoaiBenh.Location = new System.Drawing.Point(877, 34);
            this.btnThemLoaiBenh.Name = "btnThemLoaiBenh";
            this.btnThemLoaiBenh.Size = new System.Drawing.Size(200, 44);
            this.btnThemLoaiBenh.TabIndex = 5;
            this.btnThemLoaiBenh.Text = "Thêm loại bệnh";
            this.btnThemLoaiBenh.UseVisualStyleBackColor = false;
            this.btnThemLoaiBenh.Click += new System.EventHandler(this.btnNewLoaiBenh_Click);
            // 
            // dgvDanhSachLoaiBenh
            // 
            this.dgvDanhSachLoaiBenh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachLoaiBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachLoaiBenh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachLoaiBenh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachLoaiBenh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachLoaiBenh.ColumnHeadersHeight = 32;
            this.dgvDanhSachLoaiBenh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaLoaiBenh,
            this.TenLoaiBenh,
            this.ThaoTac});
            this.dgvDanhSachLoaiBenh.EnableHeadersVisualStyles = false;
            this.dgvDanhSachLoaiBenh.GridColor = System.Drawing.Color.LightGray;
            this.dgvDanhSachLoaiBenh.Location = new System.Drawing.Point(30, 360);
            this.dgvDanhSachLoaiBenh.Name = "dgvDanhSachLoaiBenh";
            this.dgvDanhSachLoaiBenh.RowHeadersVisible = false;
            this.dgvDanhSachLoaiBenh.RowHeadersWidth = 51;
            this.dgvDanhSachLoaiBenh.RowTemplate.Height = 32;
            this.dgvDanhSachLoaiBenh.Size = new System.Drawing.Size(1100, 230);
            this.dgvDanhSachLoaiBenh.TabIndex = 2;
            this.dgvDanhSachLoaiBenh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaLoaiBenh
            // 
            this.MaLoaiBenh.HeaderText = "MÃ LOẠI BỆNH";
            this.MaLoaiBenh.MinimumWidth = 6;
            this.MaLoaiBenh.Name = "MaLoaiBenh";
            // 
            // TenLoaiBenh
            // 
            this.TenLoaiBenh.HeaderText = "TÊN LOẠI BỆNH";
            this.TenLoaiBenh.MinimumWidth = 6;
            this.TenLoaiBenh.Name = "TenLoaiBenh";
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
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnThoat.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GUI_QuanLyLoaiBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 670);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvDanhSachLoaiBenh);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "GUI_QuanLyLoaiBenh";
            this.Text = "Quản lý loại bệnh";
            this.Load += new System.EventHandler(this.GUI_QuanLyLoaiBenh_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiBenh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelThemLoaiBenh;
        private System.Windows.Forms.Label labelMaLoaiBenh;
        private System.Windows.Forms.TextBox txtMaLoaiBenh;
        private System.Windows.Forms.Label labelTenLoaiBenh;
        private System.Windows.Forms.TextBox txtTenLoaiBenh;
        private System.Windows.Forms.Button btnThemLoaiBenh;
        private System.Windows.Forms.DataGridView dgvDanhSachLoaiBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiBenh;
        private System.Windows.Forms.DataGridViewButtonColumn ThaoTac;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}