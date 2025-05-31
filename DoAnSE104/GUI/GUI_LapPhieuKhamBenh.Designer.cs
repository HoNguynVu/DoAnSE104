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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.cboLoaiBenh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.txtMaKhamBenh = new System.Windows.Forms.TextBox();
            this.btnLapPhieuKham = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewPhieuKham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(173, 245);
            this.txtTrieuChung.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(944, 34);
            this.txtTrieuChung.TabIndex = 94;
            // 
            // cboLoaiBenh
            // 
            this.cboLoaiBenh.BackColor = System.Drawing.Color.LightGray;
            this.cboLoaiBenh.FormattingEnabled = true;
            this.cboLoaiBenh.ItemHeight = 29;
            this.cboLoaiBenh.Items.AddRange(new object[] {
            "df",
            "df",
            "df",
            "fed",
            "bd",
            "bfd"});
            this.cboLoaiBenh.Location = new System.Drawing.Point(859, 152);
            this.cboLoaiBenh.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.cboLoaiBenh.MaxDropDownItems = 20;
            this.cboLoaiBenh.Name = "cboLoaiBenh";
            this.cboLoaiBenh.Size = new System.Drawing.Size(237, 37);
            this.cboLoaiBenh.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(887, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 29);
            this.label6.TabIndex = 72;
            this.label6.Text = "Loại bệnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(564, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 29);
            this.label5.TabIndex = 71;
            this.label5.Text = "Tên bệnh nhân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(306, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 70;
            this.label4.Text = "Ngày khám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(30, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 69;
            this.label3.Text = "Triệu chứng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 68;
            this.label2.Text = "Mã khám bệnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 62);
            this.label1.TabIndex = 67;
            this.label1.Text = "Lập phiếu khám bệnh";
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNgayKham.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNgayKham.Enabled = false;
            this.txtNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayKham.Location = new System.Drawing.Point(302, 145);
            this.txtNgayKham.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayKham.Multiline = true;
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.Size = new System.Drawing.Size(221, 45);
            this.txtNgayKham.TabIndex = 96;
            this.txtNgayKham.TabStop = false;
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTenBenhNhan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTenBenhNhan.Enabled = false;
            this.txtTenBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBenhNhan.Location = new System.Drawing.Point(550, 145);
            this.txtTenBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBenhNhan.Multiline = true;
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(268, 45);
            this.txtTenBenhNhan.TabIndex = 96;
            this.txtTenBenhNhan.TabStop = false;
            // 
            // txtMaKhamBenh
            // 
            this.txtMaKhamBenh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMaKhamBenh.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaKhamBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhamBenh.Location = new System.Drawing.Point(35, 145);
            this.txtMaKhamBenh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhamBenh.Multiline = true;
            this.txtMaKhamBenh.Name = "txtMaKhamBenh";
            this.txtMaKhamBenh.Size = new System.Drawing.Size(221, 45);
            this.txtMaKhamBenh.TabIndex = 96;
            this.txtMaKhamBenh.TabStop = false;
            this.txtMaKhamBenh.TextChanged += new System.EventHandler(this.txtMaKhamBenh_TextChanged);
            // 
            // btnLapPhieuKham
            // 
            this.btnLapPhieuKham.Location = new System.Drawing.Point(35, 594);
            this.btnLapPhieuKham.Name = "btnLapPhieuKham";
            this.btnLapPhieuKham.Size = new System.Drawing.Size(221, 44);
            this.btnLapPhieuKham.TabIndex = 97;
            this.btnLapPhieuKham.Text = "Lập phiếu khám";
            this.btnLapPhieuKham.UseVisualStyleBackColor = true;
            this.btnLapPhieuKham.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1003, 594);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 44);
            this.btnExit.TabIndex = 98;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewPhieuKham
            // 
            this.dataGridViewPhieuKham.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuKham.Location = new System.Drawing.Point(35, 323);
            this.dataGridViewPhieuKham.Name = "dataGridViewPhieuKham";
            this.dataGridViewPhieuKham.RowHeadersWidth = 51;
            this.dataGridViewPhieuKham.RowTemplate.Height = 24;
            this.dataGridViewPhieuKham.Size = new System.Drawing.Size(1082, 252);
            this.dataGridViewPhieuKham.TabIndex = 99;
            // 
            // GUI_LapPhieuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1157, 700);
            this.Controls.Add(this.dataGridViewPhieuKham);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLapPhieuKham);
            this.Controls.Add(this.txtTenBenhNhan);
            this.Controls.Add(this.txtMaKhamBenh);
            this.Controls.Add(this.txtNgayKham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboLoaiBenh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "GUI_LapPhieuKhamBenh";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtTrieuChung;
        private ComboBox cboLoaiBenh;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNgayKham;
        private TextBox txtTenBenhNhan;
        private TextBox txtMaKhamBenh;
        private Button btnLapPhieuKham;
        private Button btnExit;
        private ErrorProvider errorProvider1;
        private DataGridView dataGridViewPhieuKham;
    }
}