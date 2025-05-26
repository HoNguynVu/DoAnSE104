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
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.selectTenLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selectLoaiBenh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.txtMaKhamBenh = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(173, 245);
            this.txtTrieuChung.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(956, 34);
            this.txtTrieuChung.TabIndex = 94;
            // 
            // selectTenLoaiThuoc
            // 
            this.selectTenLoaiThuoc.BackColor = System.Drawing.Color.LightGray;
            this.selectTenLoaiThuoc.FormattingEnabled = true;
            this.selectTenLoaiThuoc.ItemHeight = 29;
            this.selectTenLoaiThuoc.Location = new System.Drawing.Point(180, 381);
            this.selectTenLoaiThuoc.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.selectTenLoaiThuoc.MaxDropDownItems = 20;
            this.selectTenLoaiThuoc.Name = "selectTenLoaiThuoc";
            this.selectTenLoaiThuoc.Size = new System.Drawing.Size(221, 37);
            this.selectTenLoaiThuoc.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 329);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 29);
            this.label11.TabIndex = 79;
            this.label11.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(779, 329);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 29);
            this.label10.TabIndex = 78;
            this.label10.Text = "Cách dùng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(601, 329);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 29);
            this.label9.TabIndex = 77;
            this.label9.Text = "Đơn vị";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 329);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 29);
            this.label8.TabIndex = 76;
            this.label8.Text = "Tên loại thuốc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 29);
            this.label7.TabIndex = 75;
            this.label7.Text = "STT";
            // 
            // selectLoaiBenh
            // 
            this.selectLoaiBenh.BackColor = System.Drawing.Color.LightGray;
            this.selectLoaiBenh.FormattingEnabled = true;
            this.selectLoaiBenh.ItemHeight = 29;
            this.selectLoaiBenh.Location = new System.Drawing.Point(892, 153);
            this.selectLoaiBenh.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.selectLoaiBenh.MaxDropDownItems = 20;
            this.selectLoaiBenh.Name = "selectLoaiBenh";
            this.selectLoaiBenh.Size = new System.Drawing.Size(237, 37);
            this.selectLoaiBenh.TabIndex = 74;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNgayKham.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNgayKham.Enabled = false;
            this.txtNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayKham.Location = new System.Drawing.Point(311, 145);
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
            this.txtTenBenhNhan.Location = new System.Drawing.Point(571, 145);
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
            this.txtMaKhamBenh.Enabled = false;
            this.txtMaKhamBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhamBenh.Location = new System.Drawing.Point(35, 145);
            this.txtMaKhamBenh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhamBenh.Multiline = true;
            this.txtMaKhamBenh.Name = "txtMaKhamBenh";
            this.txtMaKhamBenh.Size = new System.Drawing.Size(238, 45);
            this.txtMaKhamBenh.TabIndex = 96;
            this.txtMaKhamBenh.TabStop = false;
            // 
            // txtDonVi
            // 
            this.txtDonVi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDonVi.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDonVi.Enabled = false;
            this.txtDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(606, 373);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonVi.Multiline = true;
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(132, 45);
            this.txtDonVi.TabIndex = 96;
            this.txtDonVi.TabStop = false;
            // 
            // txtCachDung
            // 
            this.txtCachDung.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCachDung.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCachDung.Enabled = false;
            this.txtCachDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCachDung.Location = new System.Drawing.Point(784, 373);
            this.txtCachDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtCachDung.Multiline = true;
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(345, 45);
            this.txtCachDung.TabIndex = 96;
            this.txtCachDung.TabStop = false;
            // 
            // txtSTT
            // 
            this.txtSTT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSTT.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSTT.Enabled = false;
            this.txtSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTT.Location = new System.Drawing.Point(35, 372);
            this.txtSTT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSTT.Multiline = true;
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(107, 45);
            this.txtSTT.TabIndex = 96;
            this.txtSTT.TabStop = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(434, 372);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(138, 45);
            this.txtSoLuong.TabIndex = 96;
            this.txtSoLuong.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 29;
            this.comboBox1.Location = new System.Drawing.Point(180, 443);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.comboBox1.MaxDropDownItems = 20;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 37);
            this.comboBox1.TabIndex = 89;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(35, 434);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(107, 45);
            this.textBox7.TabIndex = 96;
            this.textBox7.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(434, 434);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(138, 45);
            this.textBox8.TabIndex = 96;
            this.textBox8.TabStop = false;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(606, 435);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(132, 45);
            this.textBox9.TabIndex = 96;
            this.textBox9.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox10.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(784, 435);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(345, 45);
            this.textBox10.TabIndex = 96;
            this.textBox10.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.LightGray;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 29;
            this.comboBox3.Location = new System.Drawing.Point(180, 511);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.comboBox3.MaxDropDownItems = 20;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(221, 37);
            this.comboBox3.TabIndex = 89;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox12.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox12.Enabled = false;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(35, 502);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(107, 45);
            this.textBox12.TabIndex = 96;
            this.textBox12.TabStop = false;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox13.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox13.Enabled = false;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(434, 502);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(138, 45);
            this.textBox13.TabIndex = 96;
            this.textBox13.TabStop = false;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox14.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox14.Enabled = false;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(606, 503);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(132, 45);
            this.textBox14.TabIndex = 96;
            this.textBox14.TabStop = false;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox15.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox15.Enabled = false;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(784, 503);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(345, 45);
            this.textBox15.TabIndex = 96;
            this.textBox15.TabStop = false;
            // 
            // GUI_LapPhieuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1182, 635);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.txtCachDung);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.txtTenBenhNhan);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.txtMaKhamBenh);
            this.Controls.Add(this.txtNgayKham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectLoaiBenh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.selectTenLoaiThuoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "GUI_LapPhieuKhamBenh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GUI_LapPhieuKhamBenh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtTrieuChung;
        private ComboBox selectTenLoaiThuoc;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox selectLoaiBenh;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private SaveFileDialog saveFileDialog1;
        private TextBox txtNgayKham;
        private TextBox txtTenBenhNhan;
        private TextBox txtMaKhamBenh;
        private TextBox txtDonVi;
        private TextBox txtCachDung;
        private TextBox txtSTT;
        private TextBox txtSoLuong;
        private ComboBox comboBox1;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private ComboBox comboBox3;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
    }
}