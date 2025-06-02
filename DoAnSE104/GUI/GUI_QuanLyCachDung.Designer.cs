namespace DoAnSE104.GUI {
    partial class GUI_QuanLyCachDung {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelThemCachDung = new System.Windows.Forms.Label();
            this.labelMaCachDung = new System.Windows.Forms.Label();
            this.txtMaCachDung = new System.Windows.Forms.TextBox();
            this.labelCachDung = new System.Windows.Forms.Label();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.btnThemCachDung = new System.Windows.Forms.Button();
            this.dgvDanhSachCachDung = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCachDung)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(501, 72);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Quản lý cách dùng";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.labelThemCachDung);
            this.groupBoxInfo.Controls.Add(this.labelMaCachDung);
            this.groupBoxInfo.Controls.Add(this.txtMaCachDung);
            this.groupBoxInfo.Controls.Add(this.labelCachDung);
            this.groupBoxInfo.Controls.Add(this.txtCachDung);
            this.groupBoxInfo.Controls.Add(this.btnThemCachDung);
            this.groupBoxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(30, 110);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxInfo.Size = new System.Drawing.Size(1100, 230);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            // 
            // labelThemCachDung
            // 
            this.labelThemCachDung.AutoSize = true;
            this.labelThemCachDung.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelThemCachDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelThemCachDung.Location = new System.Drawing.Point(25, 35);
            this.labelThemCachDung.Name = "labelThemCachDung";
            this.labelThemCachDung.Size = new System.Drawing.Size(226, 37);
            this.labelThemCachDung.TabIndex = 0;
            this.labelThemCachDung.Text = "Thêm cách dùng";
            // 
            // labelMaCachDung
            // 
            this.labelMaCachDung.AutoSize = true;
            this.labelMaCachDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaCachDung.Location = new System.Drawing.Point(30, 90);
            this.labelMaCachDung.Name = "labelMaCachDung";
            this.labelMaCachDung.Size = new System.Drawing.Size(135, 28);
            this.labelMaCachDung.TabIndex = 1;
            this.labelMaCachDung.Text = "Mã cách dùng";
            // 
            // txtMaCachDung
            // 
            this.txtMaCachDung.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaCachDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaCachDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaCachDung.Location = new System.Drawing.Point(34, 120);
            this.txtMaCachDung.Name = "txtMaCachDung";
            this.txtMaCachDung.ReadOnly = true;
            this.txtMaCachDung.Size = new System.Drawing.Size(220, 34);
            this.txtMaCachDung.TabIndex = 2;
            // 
            // labelCachDung
            // 
            this.labelCachDung.AutoSize = true;
            this.labelCachDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelCachDung.Location = new System.Drawing.Point(270, 90);
            this.labelCachDung.Name = "labelCachDung";
            this.labelCachDung.Size = new System.Drawing.Size(105, 28);
            this.labelCachDung.TabIndex = 3;
            this.labelCachDung.Text = "Cách dùng";
            // 
            // txtCachDung
            // 
            this.txtCachDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCachDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCachDung.Location = new System.Drawing.Point(274, 120);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(220, 34);
            this.txtCachDung.TabIndex = 4;
            this.txtCachDung.TextChanged += new System.EventHandler(this.txtCachDung_TextChanged);
            // 
            // btnThemCachDung
            // 
            this.btnThemCachDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemCachDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnThemCachDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCachDung.FlatAppearance.BorderSize = 0;
            this.btnThemCachDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCachDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemCachDung.ForeColor = System.Drawing.Color.White;
            this.btnThemCachDung.Location = new System.Drawing.Point(877, 34);
            this.btnThemCachDung.Name = "btnThemCachDung";
            this.btnThemCachDung.Size = new System.Drawing.Size(200, 44);
            this.btnThemCachDung.TabIndex = 5;
            this.btnThemCachDung.Text = "Thêm cách dùng";
            this.btnThemCachDung.UseVisualStyleBackColor = false;
            this.btnThemCachDung.Click += new System.EventHandler(this.btnThemCachDung_Click);
            // 
            // dgvDanhSachCachDung
            // 
            this.dgvDanhSachCachDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachCachDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachCachDung.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachCachDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachCachDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachCachDung.ColumnHeadersHeight = 32;
            this.dgvDanhSachCachDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaCachDung,
            this.CachDung,
            this.btnXoa});
            this.dgvDanhSachCachDung.EnableHeadersVisualStyles = false;
            this.dgvDanhSachCachDung.GridColor = System.Drawing.Color.LightGray;
            this.dgvDanhSachCachDung.Location = new System.Drawing.Point(30, 360);
            this.dgvDanhSachCachDung.Name = "dgvDanhSachCachDung";
            this.dgvDanhSachCachDung.RowHeadersVisible = false;
            this.dgvDanhSachCachDung.RowHeadersWidth = 51;
            this.dgvDanhSachCachDung.RowTemplate.Height = 32;
            this.dgvDanhSachCachDung.Size = new System.Drawing.Size(1100, 230);
            this.dgvDanhSachCachDung.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaCachDung
            // 
            this.MaCachDung.HeaderText = "MÃ CÁCH DÙNG";
            this.MaCachDung.MinimumWidth = 6;
            this.MaCachDung.Name = "MaCachDung";
            // 
            // CachDung
            // 
            this.CachDung.HeaderText = "CÁCH DÙNG";
            this.CachDung.MinimumWidth = 6;
            this.CachDung.Name = "CachDung";
            // 
            // btnXoa
            // 
            this.btnXoa.HeaderText = "THAO TÁC";
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseColumnTextForButtonValue = true;
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
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // GUI_QuanLyCachDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 670);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvDanhSachCachDung);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "GUI_QuanLyCachDung";
            this.Text = "Quản lý cách dùng";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCachDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelThemCachDung;
        private System.Windows.Forms.Label labelMaCachDung;
        private System.Windows.Forms.TextBox txtMaCachDung;
        private System.Windows.Forms.Label labelCachDung;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Button btnThemCachDung;
        private System.Windows.Forms.DataGridView dgvDanhSachCachDung;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCachDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}