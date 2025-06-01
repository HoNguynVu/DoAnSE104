namespace DoAnSE104.GUI
{
    partial class GUI_TraCuuBenhNhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelMaBenhNhan = new System.Windows.Forms.Label();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.labelTenLoaiBenh = new System.Windows.Forms.Label();
            this.cbbTenLoaiBenh = new System.Windows.Forms.ComboBox();
            this.labelTrieuChung = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.labelNgayKhamTu = new System.Windows.Forms.Label();
            this.dtpNgayKhamTu = new System.Windows.Forms.DateTimePicker();
            this.labelNgayKhamDen = new System.Windows.Forms.Label();
            this.dtpNgayKhamDen = new System.Windows.Forms.DateTimePicker();
            this.labelNamSinhTu = new System.Windows.Forms.Label();
            this.numericNamSinhTu = new System.Windows.Forms.NumericUpDown();
            this.labelNamSinhDen = new System.Windows.Forms.Label();
            this.numericNamSinhDen = new System.Windows.Forms.NumericUpDown();
            this.labelMaPhieuKhamTu = new System.Windows.Forms.Label();
            this.cbbMaPhieuKhamTu = new System.Windows.Forms.ComboBox();
            this.cbbMaPhieuKhamDen = new System.Windows.Forms.ComboBox();
            this.labelTenLoaiThuoc = new System.Windows.Forms.Label();
            this.cbbTenLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.labelDonVi = new System.Windows.Forms.Label();
            this.cbbDonVi = new System.Windows.Forms.ComboBox();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.btnTraCuuBenhNhan = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMaPhieuKhamDen = new System.Windows.Forms.Label();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNamSinhTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNamSinhDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(504, 72);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Tra cứu bệnh nhân";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.labelMaBenhNhan);
            this.groupBoxInfo.Controls.Add(this.txtMaBenhNhan);
            this.groupBoxInfo.Controls.Add(this.labelHoTen);
            this.groupBoxInfo.Controls.Add(this.txtHoTen);
            this.groupBoxInfo.Controls.Add(this.labelGioiTinh);
            this.groupBoxInfo.Controls.Add(this.txtGioiTinh);
            this.groupBoxInfo.Controls.Add(this.labelDiaChi);
            this.groupBoxInfo.Controls.Add(this.txtDiaChi);
            this.groupBoxInfo.Controls.Add(this.labelTenLoaiBenh);
            this.groupBoxInfo.Controls.Add(this.cbbTenLoaiBenh);
            this.groupBoxInfo.Controls.Add(this.labelTrieuChung);
            this.groupBoxInfo.Controls.Add(this.txtTrieuChung);
            this.groupBoxInfo.Controls.Add(this.labelNgayKhamTu);
            this.groupBoxInfo.Controls.Add(this.dtpNgayKhamTu);
            this.groupBoxInfo.Controls.Add(this.labelNgayKhamDen);
            this.groupBoxInfo.Controls.Add(this.dtpNgayKhamDen);
            this.groupBoxInfo.Controls.Add(this.labelNamSinhTu);
            this.groupBoxInfo.Controls.Add(this.numericNamSinhTu);
            this.groupBoxInfo.Controls.Add(this.labelNamSinhDen);
            this.groupBoxInfo.Controls.Add(this.numericNamSinhDen);
            this.groupBoxInfo.Controls.Add(this.labelMaPhieuKhamTu);
            this.groupBoxInfo.Controls.Add(this.cbbMaPhieuKhamTu);
            this.groupBoxInfo.Controls.Add(this.labelMaPhieuKhamDen);
            this.groupBoxInfo.Controls.Add(this.cbbMaPhieuKhamDen);
            this.groupBoxInfo.Controls.Add(this.labelTenLoaiThuoc);
            this.groupBoxInfo.Controls.Add(this.cbbTenLoaiThuoc);
            this.groupBoxInfo.Controls.Add(this.labelDonVi);
            this.groupBoxInfo.Controls.Add(this.cbbDonVi);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(30, 110);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxInfo.Size = new System.Drawing.Size(1200, 280);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin tra cứu";
            // 
            // labelMaBenhNhan
            // 
            this.labelMaBenhNhan.AutoSize = true;
            this.labelMaBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaBenhNhan.Location = new System.Drawing.Point(30, 40);
            this.labelMaBenhNhan.Name = "labelMaBenhNhan";
            this.labelMaBenhNhan.Size = new System.Drawing.Size(137, 28);
            this.labelMaBenhNhan.TabIndex = 2;
            this.labelMaBenhNhan.Text = "Mã bệnh nhân";
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.BackColor = System.Drawing.Color.White;
            this.txtMaBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaBenhNhan.Location = new System.Drawing.Point(34, 70);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(180, 34);
            this.txtMaBenhNhan.TabIndex = 1;
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelHoTen.Location = new System.Drawing.Point(240, 40);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(71, 28);
            this.labelHoTen.TabIndex = 4;
            this.labelHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHoTen.Location = new System.Drawing.Point(244, 70);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 34);
            this.txtHoTen.TabIndex = 3;
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelGioiTinh.Location = new System.Drawing.Point(450, 40);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(87, 28);
            this.labelGioiTinh.TabIndex = 6;
            this.labelGioiTinh.Text = "Giới tính";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.BackColor = System.Drawing.Color.White;
            this.txtGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtGioiTinh.Location = new System.Drawing.Point(454, 70);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(120, 34);
            this.txtGioiTinh.TabIndex = 5;
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDiaChi.Location = new System.Drawing.Point(600, 40);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(71, 28);
            this.labelDiaChi.TabIndex = 8;
            this.labelDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(604, 70);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(220, 34);
            this.txtDiaChi.TabIndex = 7;
            // 
            // labelTenLoaiBenh
            // 
            this.labelTenLoaiBenh.AutoSize = true;
            this.labelTenLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTenLoaiBenh.Location = new System.Drawing.Point(850, 40);
            this.labelTenLoaiBenh.Name = "labelTenLoaiBenh";
            this.labelTenLoaiBenh.Size = new System.Drawing.Size(127, 28);
            this.labelTenLoaiBenh.TabIndex = 10;
            this.labelTenLoaiBenh.Text = "Tên loại bệnh";
            // 
            // cbbTenLoaiBenh
            // 
            this.cbbTenLoaiBenh.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbTenLoaiBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbTenLoaiBenh.FormattingEnabled = true;
            this.cbbTenLoaiBenh.Location = new System.Drawing.Point(854, 70);
            this.cbbTenLoaiBenh.Name = "cbbTenLoaiBenh";
            this.cbbTenLoaiBenh.Size = new System.Drawing.Size(180, 36);
            this.cbbTenLoaiBenh.TabIndex = 9;
            // 
            // labelTrieuChung
            // 
            this.labelTrieuChung.AutoSize = true;
            this.labelTrieuChung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTrieuChung.Location = new System.Drawing.Point(30, 120);
            this.labelTrieuChung.Name = "labelTrieuChung";
            this.labelTrieuChung.Size = new System.Drawing.Size(113, 28);
            this.labelTrieuChung.TabIndex = 12;
            this.labelTrieuChung.Text = "Triệu chứng";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.BackColor = System.Drawing.Color.White;
            this.txtTrieuChung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrieuChung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTrieuChung.Location = new System.Drawing.Point(34, 150);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(635, 34);
            this.txtTrieuChung.TabIndex = 11;
            // 
            // labelNgayKhamTu
            // 
            this.labelNgayKhamTu.AutoSize = true;
            this.labelNgayKhamTu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNgayKhamTu.Location = new System.Drawing.Point(31, 203);
            this.labelNgayKhamTu.Name = "labelNgayKhamTu";
            this.labelNgayKhamTu.Size = new System.Drawing.Size(136, 28);
            this.labelNgayKhamTu.TabIndex = 14;
            this.labelNgayKhamTu.Text = "Ngày khám từ";
            // 
            // dtpNgayKhamTu
            // 
            this.dtpNgayKhamTu.CustomFormat = "dd/mm/yyyy";
            this.dtpNgayKhamTu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpNgayKhamTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKhamTu.Location = new System.Drawing.Point(172, 200);
            this.dtpNgayKhamTu.Name = "dtpNgayKhamTu";
            this.dtpNgayKhamTu.Size = new System.Drawing.Size(220, 34);
            this.dtpNgayKhamTu.TabIndex = 13;
            this.dtpNgayKhamTu.Value = new System.DateTime(2025, 6, 1, 18, 15, 21, 0);
            // 
            // labelNgayKhamDen
            // 
            this.labelNgayKhamDen.AutoSize = true;
            this.labelNgayKhamDen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNgayKhamDen.Location = new System.Drawing.Point(398, 203);
            this.labelNgayKhamDen.Name = "labelNgayKhamDen";
            this.labelNgayKhamDen.Size = new System.Drawing.Size(45, 28);
            this.labelNgayKhamDen.TabIndex = 15;
            this.labelNgayKhamDen.Text = "đến";
            // 
            // dtpNgayKhamDen
            // 
            this.dtpNgayKhamDen.CustomFormat = "dd/mm/yyyy";
            this.dtpNgayKhamDen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpNgayKhamDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKhamDen.Location = new System.Drawing.Point(449, 200);
            this.dtpNgayKhamDen.Name = "dtpNgayKhamDen";
            this.dtpNgayKhamDen.Size = new System.Drawing.Size(220, 34);
            this.dtpNgayKhamDen.TabIndex = 16;
            // 
            // labelNamSinhTu
            // 
            this.labelNamSinhTu.AutoSize = true;
            this.labelNamSinhTu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNamSinhTu.Location = new System.Drawing.Point(700, 120);
            this.labelNamSinhTu.Name = "labelNamSinhTu";
            this.labelNamSinhTu.Size = new System.Drawing.Size(118, 28);
            this.labelNamSinhTu.TabIndex = 17;
            this.labelNamSinhTu.Text = "Năm sinh từ";
            // 
            // numericNamSinhTu
            // 
            this.numericNamSinhTu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericNamSinhTu.Location = new System.Drawing.Point(850, 118);
            this.numericNamSinhTu.Name = "numericNamSinhTu";
            this.numericNamSinhTu.Size = new System.Drawing.Size(120, 34);
            this.numericNamSinhTu.TabIndex = 32;
            // 
            // labelNamSinhDen
            // 
            this.labelNamSinhDen.AutoSize = true;
            this.labelNamSinhDen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNamSinhDen.Location = new System.Drawing.Point(980, 120);
            this.labelNamSinhDen.Name = "labelNamSinhDen";
            this.labelNamSinhDen.Size = new System.Drawing.Size(45, 28);
            this.labelNamSinhDen.TabIndex = 18;
            this.labelNamSinhDen.Text = "đến";
            // 
            // numericNamSinhDen
            // 
            this.numericNamSinhDen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericNamSinhDen.Location = new System.Drawing.Point(1031, 118);
            this.numericNamSinhDen.Name = "numericNamSinhDen";
            this.numericNamSinhDen.Size = new System.Drawing.Size(119, 34);
            this.numericNamSinhDen.TabIndex = 33;
            // 
            // labelMaPhieuKhamTu
            // 
            this.labelMaPhieuKhamTu.AutoSize = true;
            this.labelMaPhieuKhamTu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaPhieuKhamTu.Location = new System.Drawing.Point(700, 160);
            this.labelMaPhieuKhamTu.Name = "labelMaPhieuKhamTu";
            this.labelMaPhieuKhamTu.Size = new System.Drawing.Size(147, 28);
            this.labelMaPhieuKhamTu.TabIndex = 19;
            this.labelMaPhieuKhamTu.Text = "Mã phiếu khám";
            // 
            // cbbMaPhieuKhamTu
            // 
            this.cbbMaPhieuKhamTu.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbMaPhieuKhamTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaPhieuKhamTu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbMaPhieuKhamTu.FormattingEnabled = true;
            this.cbbMaPhieuKhamTu.Location = new System.Drawing.Point(850, 160);
            this.cbbMaPhieuKhamTu.Name = "cbbMaPhieuKhamTu";
            this.cbbMaPhieuKhamTu.Size = new System.Drawing.Size(120, 36);
            this.cbbMaPhieuKhamTu.TabIndex = 23;
            // 
            // cbbMaPhieuKhamDen
            // 
            this.cbbMaPhieuKhamDen.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbMaPhieuKhamDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaPhieuKhamDen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbMaPhieuKhamDen.FormattingEnabled = true;
            this.cbbMaPhieuKhamDen.Location = new System.Drawing.Point(1030, 160);
            this.cbbMaPhieuKhamDen.Name = "cbbMaPhieuKhamDen";
            this.cbbMaPhieuKhamDen.Size = new System.Drawing.Size(120, 36);
            this.cbbMaPhieuKhamDen.TabIndex = 24;
            // 
            // labelTenLoaiThuoc
            // 
            this.labelTenLoaiThuoc.AutoSize = true;
            this.labelTenLoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTenLoaiThuoc.Location = new System.Drawing.Point(700, 203);
            this.labelTenLoaiThuoc.Name = "labelTenLoaiThuoc";
            this.labelTenLoaiThuoc.Size = new System.Drawing.Size(133, 28);
            this.labelTenLoaiThuoc.TabIndex = 27;
            this.labelTenLoaiThuoc.Text = "Tên loại thuốc";
            // 
            // cbbTenLoaiThuoc
            // 
            this.cbbTenLoaiThuoc.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbTenLoaiThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenLoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbTenLoaiThuoc.FormattingEnabled = true;
            this.cbbTenLoaiThuoc.Location = new System.Drawing.Point(850, 200);
            this.cbbTenLoaiThuoc.Name = "cbbTenLoaiThuoc";
            this.cbbTenLoaiThuoc.Size = new System.Drawing.Size(100, 36);
            this.cbbTenLoaiThuoc.TabIndex = 25;
            // 
            // labelDonVi
            // 
            this.labelDonVi.AutoSize = true;
            this.labelDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDonVi.Location = new System.Drawing.Point(980, 203);
            this.labelDonVi.Name = "labelDonVi";
            this.labelDonVi.Size = new System.Drawing.Size(69, 28);
            this.labelDonVi.TabIndex = 28;
            this.labelDonVi.Text = "Đơn vị";
            // 
            // cbbDonVi
            // 
            this.cbbDonVi.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDonVi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbDonVi.FormattingEnabled = true;
            this.cbbDonVi.Location = new System.Drawing.Point(1050, 200);
            this.cbbDonVi.Name = "cbbDonVi";
            this.cbbDonVi.Size = new System.Drawing.Size(100, 36);
            this.cbbDonVi.TabIndex = 26;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.BackgroundColor = System.Drawing.Color.White;
            this.dgvKetQua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKetQua.ColumnHeadersHeight = 32;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaBenhNhan,
            this.TenBenhNhan,
            this.GioiTinh,
            this.NamSinh,
            this.DiaChi,
            this.NgayKham,
            this.TrieuChung,
            this.TenLoaiBenh});
            this.dgvKetQua.EnableHeadersVisualStyles = false;
            this.dgvKetQua.GridColor = System.Drawing.Color.LightGray;
            this.dgvKetQua.Location = new System.Drawing.Point(30, 410);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersVisible = false;
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.RowTemplate.Height = 32;
            this.dgvKetQua.Size = new System.Drawing.Size(1200, 230);
            this.dgvKetQua.TabIndex = 29;
            // 
            // btnTraCuuBenhNhan
            // 
            this.btnTraCuuBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTraCuuBenhNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTraCuuBenhNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraCuuBenhNhan.FlatAppearance.BorderSize = 0;
            this.btnTraCuuBenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTraCuuBenhNhan.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuBenhNhan.Location = new System.Drawing.Point(30, 652);
            this.btnTraCuuBenhNhan.Name = "btnTraCuuBenhNhan";
            this.btnTraCuuBenhNhan.Size = new System.Drawing.Size(252, 44);
            this.btnTraCuuBenhNhan.TabIndex = 30;
            this.btnTraCuuBenhNhan.Text = "Tra cứu bệnh nhân";
            this.btnTraCuuBenhNhan.UseVisualStyleBackColor = false;
            this.btnTraCuuBenhNhan.Click += new System.EventHandler(this.btnTraCuuBenhNhan_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1030, 652);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 44);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.HeaderText = "Mã bệnh nhân";
            this.MaBenhNhan.MinimumWidth = 6;
            this.MaBenhNhan.Name = "MaBenhNhan";
            // 
            // TenBenhNhan
            // 
            this.TenBenhNhan.HeaderText = "Tên bệnh nhân";
            this.TenBenhNhan.MinimumWidth = 6;
            this.TenBenhNhan.Name = "TenBenhNhan";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NamSinh
            // 
            this.NamSinh.HeaderText = "Năm sinh";
            this.NamSinh.MinimumWidth = 6;
            this.NamSinh.Name = "NamSinh";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // NgayKham
            // 
            this.NgayKham.HeaderText = "Ngày khám";
            this.NgayKham.MinimumWidth = 6;
            this.NgayKham.Name = "NgayKham";
            // 
            // TrieuChung
            // 
            this.TrieuChung.HeaderText = "Triệu chứng";
            this.TrieuChung.MinimumWidth = 6;
            this.TrieuChung.Name = "TrieuChung";
            // 
            // TenLoaiBenh
            // 
            this.TenLoaiBenh.HeaderText = "Tên loại bệnh";
            this.TenLoaiBenh.MinimumWidth = 6;
            this.TenLoaiBenh.Name = "TenLoaiBenh";
            // 
            // labelMaPhieuKhamDen
            // 
            this.labelMaPhieuKhamDen.AutoSize = true;
            this.labelMaPhieuKhamDen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaPhieuKhamDen.Location = new System.Drawing.Point(981, 160);
            this.labelMaPhieuKhamDen.Name = "labelMaPhieuKhamDen";
            this.labelMaPhieuKhamDen.Size = new System.Drawing.Size(45, 28);
            this.labelMaPhieuKhamDen.TabIndex = 20;
            this.labelMaPhieuKhamDen.Text = "đến";
            // 
            // GUI_TraCuuBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 708);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTraCuuBenhNhan);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "GUI_TraCuuBenhNhan";
            this.Text = "Tra cứu bệnh nhân";
            this.Load += new System.EventHandler(this.GUI_TraCuuBenhNhan_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNamSinhTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNamSinhDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelMaBenhNhan;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label labelTenLoaiBenh;
        private System.Windows.Forms.ComboBox cbbTenLoaiBenh;
        private System.Windows.Forms.Label labelTrieuChung;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label labelNgayKhamTu;
        private System.Windows.Forms.DateTimePicker dtpNgayKhamTu;
        private System.Windows.Forms.Label labelNgayKhamDen;
        private System.Windows.Forms.DateTimePicker dtpNgayKhamDen;
        private System.Windows.Forms.Label labelNamSinhTu;
        private System.Windows.Forms.NumericUpDown numericNamSinhTu;
        private System.Windows.Forms.Label labelNamSinhDen;
        private System.Windows.Forms.NumericUpDown numericNamSinhDen;
        private System.Windows.Forms.Label labelMaPhieuKhamTu;
        private System.Windows.Forms.ComboBox cbbMaPhieuKhamTu;
        private System.Windows.Forms.ComboBox cbbMaPhieuKhamDen;
        private System.Windows.Forms.Label labelTenLoaiThuoc;
        private System.Windows.Forms.ComboBox cbbTenLoaiThuoc;
        private System.Windows.Forms.Label labelDonVi;
        private System.Windows.Forms.ComboBox cbbDonVi;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Button btnTraCuuBenhNhan;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrieuChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiBenh;
        private System.Windows.Forms.Label labelMaPhieuKhamDen;
    }
}