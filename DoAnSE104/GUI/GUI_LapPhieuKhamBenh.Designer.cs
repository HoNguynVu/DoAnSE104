using System.Drawing;
using System.Windows.Forms;

namespace DoAnSE104.GUI
{
    partial class GUI_LapPhieuKhamBenh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelMaKhamBenh = new System.Windows.Forms.Label();
            this.txtMaKhamBenh = new System.Windows.Forms.TextBox();
            this.labelNgayKham = new System.Windows.Forms.Label();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.labelTenBenhNhan = new System.Windows.Forms.Label();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.labelLoaiBenh = new System.Windows.Forms.Label();
            this.cbbLoaiBenh = new System.Windows.Forms.ComboBox();
            this.labelTrieuChung = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.btnLapPhieuKham = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvPhieuKham = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTimPhieuKham = new System.Windows.Forms.Button();
            this.btnTimBenhNhan = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).BeginInit();
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
            this.labelTitle.Size = new System.Drawing.Size(461, 59);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Lập phiếu khám bệnh";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.labelMaKhamBenh);
            this.groupBoxInfo.Controls.Add(this.txtMaKhamBenh);
            this.groupBoxInfo.Controls.Add(this.labelNgayKham);
            this.groupBoxInfo.Controls.Add(this.txtNgayKham);
            this.groupBoxInfo.Controls.Add(this.labelTenBenhNhan);
            this.groupBoxInfo.Controls.Add(this.txtTenBenhNhan);
            this.groupBoxInfo.Controls.Add(this.labelLoaiBenh);
            this.groupBoxInfo.Controls.Add(this.cbbLoaiBenh);
            this.groupBoxInfo.Controls.Add(this.labelTrieuChung);
            this.groupBoxInfo.Controls.Add(this.txtTrieuChung);
            this.groupBoxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(30, 110);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(20);
            this.groupBoxInfo.Size = new System.Drawing.Size(1100, 230);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin phiếu khám";
            // 
            // labelMaKhamBenh
            // 
            this.labelMaKhamBenh.AutoSize = true;
            this.labelMaKhamBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaKhamBenh.Location = new System.Drawing.Point(30, 40);
            this.labelMaKhamBenh.Name = "labelMaKhamBenh";
            this.labelMaKhamBenh.Size = new System.Drawing.Size(114, 21);
            this.labelMaKhamBenh.TabIndex = 0;
            this.labelMaKhamBenh.Text = "Mã khám bệnh";
            // 
            // txtMaKhamBenh
            // 
            this.txtMaKhamBenh.BackColor = System.Drawing.Color.White;
            this.txtMaKhamBenh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhamBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaKhamBenh.Location = new System.Drawing.Point(34, 70);
            this.txtMaKhamBenh.Name = "txtMaKhamBenh";
            this.txtMaKhamBenh.Size = new System.Drawing.Size(180, 29);
            this.txtMaKhamBenh.TabIndex = 1;
            this.txtMaKhamBenh.TextChanged += new System.EventHandler(this.txtMaKhamBenh_TextChanged);
            // 
            // labelNgayKham
            // 
            this.labelNgayKham.AutoSize = true;
            this.labelNgayKham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNgayKham.Location = new System.Drawing.Point(240, 40);
            this.labelNgayKham.Name = "labelNgayKham";
            this.labelNgayKham.Size = new System.Drawing.Size(90, 21);
            this.labelNgayKham.TabIndex = 2;
            this.labelNgayKham.Text = "Ngày khám";
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNgayKham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayKham.Enabled = false;
            this.txtNgayKham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNgayKham.Location = new System.Drawing.Point(244, 70);
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.Size = new System.Drawing.Size(180, 29);
            this.txtNgayKham.TabIndex = 3;
            this.txtNgayKham.TabStop = false;
            // 
            // labelTenBenhNhan
            // 
            this.labelTenBenhNhan.AutoSize = true;
            this.labelTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTenBenhNhan.Location = new System.Drawing.Point(450, 40);
            this.labelTenBenhNhan.Name = "labelTenBenhNhan";
            this.labelTenBenhNhan.Size = new System.Drawing.Size(111, 21);
            this.labelTenBenhNhan.TabIndex = 4;
            this.labelTenBenhNhan.Text = "Tên bệnh nhân";
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTenBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenBenhNhan.Enabled = false;
            this.txtTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenBenhNhan.Location = new System.Drawing.Point(454, 70);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(220, 29);
            this.txtTenBenhNhan.TabIndex = 5;
            this.txtTenBenhNhan.TabStop = false;
            // 
            // labelLoaiBenh
            // 
            this.labelLoaiBenh.AutoSize = true;
            this.labelLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelLoaiBenh.Location = new System.Drawing.Point(700, 40);
            this.labelLoaiBenh.Name = "labelLoaiBenh";
            this.labelLoaiBenh.Size = new System.Drawing.Size(78, 21);
            this.labelLoaiBenh.TabIndex = 6;
            this.labelLoaiBenh.Text = "Loại bệnh";
            // 
            // cbbLoaiBenh
            // 
            this.cbbLoaiBenh.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbLoaiBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbLoaiBenh.FormattingEnabled = true;
            this.cbbLoaiBenh.Location = new System.Drawing.Point(704, 70);
            this.cbbLoaiBenh.Name = "cbbLoaiBenh";
            this.cbbLoaiBenh.Size = new System.Drawing.Size(220, 29);
            this.cbbLoaiBenh.TabIndex = 7;
            // 
            // labelTrieuChung
            // 
            this.labelTrieuChung.AutoSize = true;
            this.labelTrieuChung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTrieuChung.Location = new System.Drawing.Point(30, 120);
            this.labelTrieuChung.Name = "labelTrieuChung";
            this.labelTrieuChung.Size = new System.Drawing.Size(91, 21);
            this.labelTrieuChung.TabIndex = 8;
            this.labelTrieuChung.Text = "Triệu chứng";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrieuChung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTrieuChung.Location = new System.Drawing.Point(34, 150);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(890, 29);
            this.txtTrieuChung.TabIndex = 9;
            // 
            // btnLapPhieuKham
            // 
            this.btnLapPhieuKham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLapPhieuKham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLapPhieuKham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapPhieuKham.FlatAppearance.BorderSize = 0;
            this.btnLapPhieuKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieuKham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLapPhieuKham.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieuKham.Location = new System.Drawing.Point(30, 587);
            this.btnLapPhieuKham.Name = "btnLapPhieuKham";
            this.btnLapPhieuKham.Size = new System.Drawing.Size(200, 44);
            this.btnLapPhieuKham.TabIndex = 10;
            this.btnLapPhieuKham.Text = "Lập phiếu khám";
            this.btnLapPhieuKham.UseVisualStyleBackColor = false;
            this.btnLapPhieuKham.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(930, 587);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 44);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvPhieuKham
            // 
            this.dgvPhieuKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuKham.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuKham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuKham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuKham.ColumnHeadersHeight = 32;
            this.dgvPhieuKham.EnableHeadersVisualStyles = false;
            this.dgvPhieuKham.GridColor = System.Drawing.Color.LightGray;
            this.dgvPhieuKham.Location = new System.Drawing.Point(30, 346);
            this.dgvPhieuKham.Name = "dgvPhieuKham";
            this.dgvPhieuKham.RowHeadersVisible = false;
            this.dgvPhieuKham.RowHeadersWidth = 51;
            this.dgvPhieuKham.RowTemplate.Height = 32;
            this.dgvPhieuKham.Size = new System.Drawing.Size(1100, 230);
            this.dgvPhieuKham.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnTimPhieuKham
            // 
            this.btnTimPhieuKham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimPhieuKham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTimPhieuKham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimPhieuKham.FlatAppearance.BorderSize = 0;
            this.btnTimPhieuKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimPhieuKham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTimPhieuKham.ForeColor = System.Drawing.Color.White;
            this.btnTimPhieuKham.Location = new System.Drawing.Point(608, 587);
            this.btnTimPhieuKham.Name = "btnTimPhieuKham";
            this.btnTimPhieuKham.Size = new System.Drawing.Size(200, 44);
            this.btnTimPhieuKham.TabIndex = 13;
            this.btnTimPhieuKham.Text = "Tìm Phiếu Khám";
            this.btnTimPhieuKham.UseVisualStyleBackColor = false;
            this.btnTimPhieuKham.Click += new System.EventHandler(this.btnTimPhieuKham_Click);
            // 
            // btnTimBenhNhan
            // 
            this.btnTimBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimBenhNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTimBenhNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimBenhNhan.FlatAppearance.BorderSize = 0;
            this.btnTimBenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTimBenhNhan.ForeColor = System.Drawing.Color.White;
            this.btnTimBenhNhan.Location = new System.Drawing.Point(311, 587);
            this.btnTimBenhNhan.Name = "btnTimBenhNhan";
            this.btnTimBenhNhan.Size = new System.Drawing.Size(200, 44);
            this.btnTimBenhNhan.TabIndex = 14;
            this.btnTimBenhNhan.Text = "Tìm Bệnh Nhân";
            this.btnTimBenhNhan.UseVisualStyleBackColor = false;
            this.btnTimBenhNhan.Click += new System.EventHandler(this.btnTimBenhNhan_Click);
            // 
            // GUI_LapPhieuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 643);
            this.Controls.Add(this.btnTimBenhNhan);
            this.Controls.Add(this.btnTimPhieuKham);
            this.Controls.Add(this.dgvPhieuKham);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLapPhieuKham);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "GUI_LapPhieuKhamBenh";
            this.Text = "Lập phiếu khám bệnh";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelTitle;
        private GroupBox groupBoxInfo;
        private Label labelMaKhamBenh;
        private TextBox txtMaKhamBenh;
        private Label labelNgayKham;
        private TextBox txtNgayKham;
        private Label labelTenBenhNhan;
        private TextBox txtTenBenhNhan;
        private Label labelLoaiBenh;
        private ComboBox cbbLoaiBenh;
        private Label labelTrieuChung;
        private TextBox txtTrieuChung;
        private Button btnLapPhieuKham;
        private Button btnExit;
        private DataGridView dgvPhieuKham;
        private ErrorProvider errorProvider1;
        private Button btnTimBenhNhan;
        private Button btnTimPhieuKham;
    }
}