namespace DoAnSE104.GUI
{
    partial class GUI_TiepNhanKhamBenh
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TiepNhanKhamBenh));
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelMaKhamBenh = new System.Windows.Forms.Label();
            this.txtMaKhamBenh = new System.Windows.Forms.TextBox();
            this.labelMaBenhNhan = new System.Windows.Forms.Label();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.labelNamSinh = new System.Windows.Forms.Label();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.labelNgayKham = new System.Windows.Forms.Label();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.pictureBoxToggleCalendar = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToggleCalendar)).BeginInit();
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
            this.labelTitle.Size = new System.Drawing.Size(581, 72);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Tiếp nhận khám bệnh";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.labelMaKhamBenh);
            this.groupBoxInfo.Controls.Add(this.txtMaKhamBenh);
            this.groupBoxInfo.Controls.Add(this.labelMaBenhNhan);
            this.groupBoxInfo.Controls.Add(this.txtMaBenhNhan);
            this.groupBoxInfo.Controls.Add(this.labelHoTen);
            this.groupBoxInfo.Controls.Add(this.txtHoTen);
            this.groupBoxInfo.Controls.Add(this.labelGioiTinh);
            this.groupBoxInfo.Controls.Add(this.txtGioiTinh);
            this.groupBoxInfo.Controls.Add(this.labelNamSinh);
            this.groupBoxInfo.Controls.Add(this.txtNamSinh);
            this.groupBoxInfo.Controls.Add(this.labelDiaChi);
            this.groupBoxInfo.Controls.Add(this.txtDiaChi);
            this.groupBoxInfo.Controls.Add(this.labelNgayKham);
            this.groupBoxInfo.Controls.Add(this.txtNgayKham);
            this.groupBoxInfo.Controls.Add(this.pictureBoxToggleCalendar);
            this.groupBoxInfo.Controls.Add(this.monthCalendar1);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(30, 110);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxInfo.Size = new System.Drawing.Size(900, 436);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin khám bệnh";
            // 
            // labelMaKhamBenh
            // 
            this.labelMaKhamBenh.AutoSize = true;
            this.labelMaKhamBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaKhamBenh.Location = new System.Drawing.Point(30, 40);
            this.labelMaKhamBenh.Name = "labelMaKhamBenh";
            this.labelMaKhamBenh.Size = new System.Drawing.Size(142, 28);
            this.labelMaKhamBenh.TabIndex = 1;
            this.labelMaKhamBenh.Text = "Mã khám bệnh";
            // 
            // txtMaKhamBenh
            // 
            this.txtMaKhamBenh.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaKhamBenh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhamBenh.Enabled = false;
            this.txtMaKhamBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaKhamBenh.Location = new System.Drawing.Point(34, 70);
            this.txtMaKhamBenh.Name = "txtMaKhamBenh";
            this.txtMaKhamBenh.ReadOnly = true;
            this.txtMaKhamBenh.Size = new System.Drawing.Size(220, 34);
            this.txtMaKhamBenh.TabIndex = 2;
            // 
            // labelMaBenhNhan
            // 
            this.labelMaBenhNhan.AutoSize = true;
            this.labelMaBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaBenhNhan.Location = new System.Drawing.Point(270, 40);
            this.labelMaBenhNhan.Name = "labelMaBenhNhan";
            this.labelMaBenhNhan.Size = new System.Drawing.Size(137, 28);
            this.labelMaBenhNhan.TabIndex = 3;
            this.labelMaBenhNhan.Text = "Mã bệnh nhân";
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaBenhNhan.Location = new System.Drawing.Point(274, 70);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(220, 34);
            this.txtMaBenhNhan.TabIndex = 4;
            this.txtMaBenhNhan.TextChanged += new System.EventHandler(this.txtMaBenhNhan_TextChanged);
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelHoTen.Location = new System.Drawing.Point(520, 40);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(96, 28);
            this.labelHoTen.TabIndex = 5;
            this.labelHoTen.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHoTen.Location = new System.Drawing.Point(524, 70);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(340, 34);
            this.txtHoTen.TabIndex = 6;
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelGioiTinh.Location = new System.Drawing.Point(30, 115);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(87, 28);
            this.labelGioiTinh.TabIndex = 7;
            this.labelGioiTinh.Text = "Giới tính";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGioiTinh.Enabled = false;
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtGioiTinh.Location = new System.Drawing.Point(34, 145);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(140, 34);
            this.txtGioiTinh.TabIndex = 8;
            // 
            // labelNamSinh
            // 
            this.labelNamSinh.AutoSize = true;
            this.labelNamSinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNamSinh.Location = new System.Drawing.Point(200, 115);
            this.labelNamSinh.Name = "labelNamSinh";
            this.labelNamSinh.Size = new System.Drawing.Size(94, 28);
            this.labelNamSinh.TabIndex = 9;
            this.labelNamSinh.Text = "Năm sinh";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNamSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamSinh.Enabled = false;
            this.txtNamSinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNamSinh.Location = new System.Drawing.Point(204, 145);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.ReadOnly = true;
            this.txtNamSinh.Size = new System.Drawing.Size(140, 34);
            this.txtNamSinh.TabIndex = 10;
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDiaChi.Location = new System.Drawing.Point(370, 115);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(71, 28);
            this.labelDiaChi.TabIndex = 11;
            this.labelDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(374, 145);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(490, 34);
            this.txtDiaChi.TabIndex = 12;
            // 
            // labelNgayKham
            // 
            this.labelNgayKham.AutoSize = true;
            this.labelNgayKham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNgayKham.Location = new System.Drawing.Point(30, 200);
            this.labelNgayKham.Name = "labelNgayKham";
            this.labelNgayKham.Size = new System.Drawing.Size(112, 28);
            this.labelNgayKham.TabIndex = 13;
            this.labelNgayKham.Text = "Ngày khám";
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNgayKham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayKham.Enabled = false;
            this.txtNgayKham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNgayKham.Location = new System.Drawing.Point(34, 230);
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.Size = new System.Drawing.Size(180, 34);
            this.txtNgayKham.TabIndex = 14;
            // 
            // pictureBoxToggleCalendar
            // 
            this.pictureBoxToggleCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxToggleCalendar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxToggleCalendar.Image")));
            this.pictureBoxToggleCalendar.Location = new System.Drawing.Point(220, 230);
            this.pictureBoxToggleCalendar.Name = "pictureBoxToggleCalendar";
            this.pictureBoxToggleCalendar.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxToggleCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxToggleCalendar.TabIndex = 15;
            this.pictureBoxToggleCalendar.TabStop = false;
            this.pictureBoxToggleCalendar.Click += new System.EventHandler(this.pictureBoxToggleCalendar_Click_1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(264, 191);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 557);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 44);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Tiếp nhận";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(236, 557);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 44);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "Bệnh nhân mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(730, 557);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 44);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GUI_TiepNhanKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 613);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(960, 620);
            this.Name = "GUI_TiepNhanKhamBenh";
            this.Text = "Tiếp nhận khám bệnh";
            this.Load += new System.EventHandler(this.GUI_TiepNhanKhamBenh_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToggleCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelMaKhamBenh;
        private System.Windows.Forms.TextBox txtMaKhamBenh;
        private System.Windows.Forms.Label labelMaBenhNhan;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label labelNamSinh;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label labelNgayKham;
        private System.Windows.Forms.TextBox txtNgayKham;
        private System.Windows.Forms.PictureBox pictureBoxToggleCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}