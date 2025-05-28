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
            this.cbLoaiThuoc1 = new System.Windows.Forms.ComboBox();
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
            this.txtNK = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.txtMaKB = new System.Windows.Forms.TextBox();
            this.txtDonVi1 = new System.Windows.Forms.TextBox();
            this.txtCachDung1 = new System.Windows.Forms.TextBox();
            this.txtSTT1 = new System.Windows.Forms.TextBox();
            this.txtSLThuoc1 = new System.Windows.Forms.TextBox();
            this.cbLoaiThuoc2 = new System.Windows.Forms.ComboBox();
            this.txtSTT2 = new System.Windows.Forms.TextBox();
            this.txtSLThuoc2 = new System.Windows.Forms.TextBox();
            this.txtDonVi2 = new System.Windows.Forms.TextBox();
            this.txtCachDung2 = new System.Windows.Forms.TextBox();
            this.cbLoaiThuoc3 = new System.Windows.Forms.ComboBox();
            this.txtSTT3 = new System.Windows.Forms.TextBox();
            this.txtSLThuoc3 = new System.Windows.Forms.TextBox();
            this.txtDonVi3 = new System.Windows.Forms.TextBox();
            this.txtCachDung3 = new System.Windows.Forms.TextBox();
            this.btnLapPK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // cbLoaiThuoc1
            // 
            this.cbLoaiThuoc1.BackColor = System.Drawing.Color.LightGray;
            this.cbLoaiThuoc1.FormattingEnabled = true;
            this.cbLoaiThuoc1.ItemHeight = 29;
            this.cbLoaiThuoc1.Location = new System.Drawing.Point(180, 381);
            this.cbLoaiThuoc1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.cbLoaiThuoc1.MaxDropDownItems = 20;
            this.cbLoaiThuoc1.Name = "cbLoaiThuoc1";
            this.cbLoaiThuoc1.Size = new System.Drawing.Size(221, 37);
            this.cbLoaiThuoc1.TabIndex = 89;
            this.cbLoaiThuoc1.SelectedIndexChanged += new System.EventHandler(this.cbLoaiThuoc1_SelectedIndexChanged);
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
            this.selectLoaiBenh.Location = new System.Drawing.Point(859, 152);
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
            // 
            // txtNK
            // 
            this.txtNK.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNK.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNK.Enabled = false;
            this.txtNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNK.Location = new System.Drawing.Point(302, 145);
            this.txtNK.Margin = new System.Windows.Forms.Padding(4);
            this.txtNK.Multiline = true;
            this.txtNK.Name = "txtNK";
            this.txtNK.Size = new System.Drawing.Size(221, 45);
            this.txtNK.TabIndex = 96;
            this.txtNK.TabStop = false;
            // 
            // txtTenBN
            // 
            this.txtTenBN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTenBN.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTenBN.Enabled = false;
            this.txtTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBN.Location = new System.Drawing.Point(550, 145);
            this.txtTenBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBN.Multiline = true;
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(268, 45);
            this.txtTenBN.TabIndex = 96;
            this.txtTenBN.TabStop = false;
            // 
            // txtMaKB
            // 
            this.txtMaKB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMaKB.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKB.Location = new System.Drawing.Point(35, 145);
            this.txtMaKB.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKB.Multiline = true;
            this.txtMaKB.Name = "txtMaKB";
            this.txtMaKB.Size = new System.Drawing.Size(221, 45);
            this.txtMaKB.TabIndex = 96;
            this.txtMaKB.TabStop = false;
            this.txtMaKB.TextChanged += new System.EventHandler(this.txtMaKB_TextChanged);
            // 
            // txtDonVi1
            // 
            this.txtDonVi1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDonVi1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDonVi1.Enabled = false;
            this.txtDonVi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi1.Location = new System.Drawing.Point(606, 373);
            this.txtDonVi1.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonVi1.Multiline = true;
            this.txtDonVi1.Name = "txtDonVi1";
            this.txtDonVi1.Size = new System.Drawing.Size(132, 45);
            this.txtDonVi1.TabIndex = 96;
            this.txtDonVi1.TabStop = false;
            // 
            // txtCachDung1
            // 
            this.txtCachDung1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCachDung1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCachDung1.Enabled = false;
            this.txtCachDung1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCachDung1.Location = new System.Drawing.Point(784, 373);
            this.txtCachDung1.Margin = new System.Windows.Forms.Padding(4);
            this.txtCachDung1.Multiline = true;
            this.txtCachDung1.Name = "txtCachDung1";
            this.txtCachDung1.Size = new System.Drawing.Size(312, 45);
            this.txtCachDung1.TabIndex = 96;
            this.txtCachDung1.TabStop = false;
            // 
            // txtSTT1
            // 
            this.txtSTT1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSTT1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSTT1.Enabled = false;
            this.txtSTT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTT1.Location = new System.Drawing.Point(35, 372);
            this.txtSTT1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSTT1.Multiline = true;
            this.txtSTT1.Name = "txtSTT1";
            this.txtSTT1.Size = new System.Drawing.Size(107, 45);
            this.txtSTT1.TabIndex = 96;
            this.txtSTT1.TabStop = false;
            // 
            // txtSLThuoc1
            // 
            this.txtSLThuoc1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSLThuoc1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSLThuoc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLThuoc1.Location = new System.Drawing.Point(434, 372);
            this.txtSLThuoc1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLThuoc1.Multiline = true;
            this.txtSLThuoc1.Name = "txtSLThuoc1";
            this.txtSLThuoc1.Size = new System.Drawing.Size(107, 45);
            this.txtSLThuoc1.TabIndex = 96;
            this.txtSLThuoc1.TabStop = false;
            this.txtSLThuoc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLThuoc1_KeyPress);
            // 
            // cbLoaiThuoc2
            // 
            this.cbLoaiThuoc2.BackColor = System.Drawing.Color.LightGray;
            this.cbLoaiThuoc2.FormattingEnabled = true;
            this.cbLoaiThuoc2.ItemHeight = 29;
            this.cbLoaiThuoc2.Location = new System.Drawing.Point(180, 443);
            this.cbLoaiThuoc2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.cbLoaiThuoc2.MaxDropDownItems = 20;
            this.cbLoaiThuoc2.Name = "cbLoaiThuoc2";
            this.cbLoaiThuoc2.Size = new System.Drawing.Size(221, 37);
            this.cbLoaiThuoc2.TabIndex = 89;
            this.cbLoaiThuoc2.SelectedIndexChanged += new System.EventHandler(this.cbLoaiThuoc2_SelectedIndexChanged);
            // 
            // txtSTT2
            // 
            this.txtSTT2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSTT2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSTT2.Enabled = false;
            this.txtSTT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTT2.Location = new System.Drawing.Point(35, 434);
            this.txtSTT2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSTT2.Multiline = true;
            this.txtSTT2.Name = "txtSTT2";
            this.txtSTT2.Size = new System.Drawing.Size(107, 45);
            this.txtSTT2.TabIndex = 96;
            this.txtSTT2.TabStop = false;
            // 
            // txtSLThuoc2
            // 
            this.txtSLThuoc2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSLThuoc2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSLThuoc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLThuoc2.Location = new System.Drawing.Point(434, 434);
            this.txtSLThuoc2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLThuoc2.Multiline = true;
            this.txtSLThuoc2.Name = "txtSLThuoc2";
            this.txtSLThuoc2.Size = new System.Drawing.Size(107, 45);
            this.txtSLThuoc2.TabIndex = 96;
            this.txtSLThuoc2.TabStop = false;
            this.txtSLThuoc2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLThuoc2_KeyPress);
            // 
            // txtDonVi2
            // 
            this.txtDonVi2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDonVi2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDonVi2.Enabled = false;
            this.txtDonVi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi2.Location = new System.Drawing.Point(606, 435);
            this.txtDonVi2.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonVi2.Multiline = true;
            this.txtDonVi2.Name = "txtDonVi2";
            this.txtDonVi2.Size = new System.Drawing.Size(132, 45);
            this.txtDonVi2.TabIndex = 96;
            this.txtDonVi2.TabStop = false;
            // 
            // txtCachDung2
            // 
            this.txtCachDung2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCachDung2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCachDung2.Enabled = false;
            this.txtCachDung2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCachDung2.Location = new System.Drawing.Point(784, 435);
            this.txtCachDung2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCachDung2.Multiline = true;
            this.txtCachDung2.Name = "txtCachDung2";
            this.txtCachDung2.Size = new System.Drawing.Size(312, 45);
            this.txtCachDung2.TabIndex = 96;
            this.txtCachDung2.TabStop = false;
            // 
            // cbLoaiThuoc3
            // 
            this.cbLoaiThuoc3.BackColor = System.Drawing.Color.LightGray;
            this.cbLoaiThuoc3.FormattingEnabled = true;
            this.cbLoaiThuoc3.ItemHeight = 29;
            this.cbLoaiThuoc3.Location = new System.Drawing.Point(180, 511);
            this.cbLoaiThuoc3.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.cbLoaiThuoc3.MaxDropDownItems = 20;
            this.cbLoaiThuoc3.Name = "cbLoaiThuoc3";
            this.cbLoaiThuoc3.Size = new System.Drawing.Size(221, 37);
            this.cbLoaiThuoc3.TabIndex = 89;
            this.cbLoaiThuoc3.SelectedIndexChanged += new System.EventHandler(this.cbLoaiThuoc3_SelectedIndexChanged);
            // 
            // txtSTT3
            // 
            this.txtSTT3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSTT3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSTT3.Enabled = false;
            this.txtSTT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTT3.Location = new System.Drawing.Point(35, 502);
            this.txtSTT3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSTT3.Multiline = true;
            this.txtSTT3.Name = "txtSTT3";
            this.txtSTT3.Size = new System.Drawing.Size(107, 45);
            this.txtSTT3.TabIndex = 96;
            this.txtSTT3.TabStop = false;
            // 
            // txtSLThuoc3
            // 
            this.txtSLThuoc3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSLThuoc3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSLThuoc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLThuoc3.Location = new System.Drawing.Point(434, 502);
            this.txtSLThuoc3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLThuoc3.Multiline = true;
            this.txtSLThuoc3.Name = "txtSLThuoc3";
            this.txtSLThuoc3.Size = new System.Drawing.Size(107, 45);
            this.txtSLThuoc3.TabIndex = 96;
            this.txtSLThuoc3.TabStop = false;
            this.txtSLThuoc3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLThuoc3_KeyPress);
            // 
            // txtDonVi3
            // 
            this.txtDonVi3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDonVi3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDonVi3.Enabled = false;
            this.txtDonVi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi3.Location = new System.Drawing.Point(606, 503);
            this.txtDonVi3.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonVi3.Multiline = true;
            this.txtDonVi3.Name = "txtDonVi3";
            this.txtDonVi3.Size = new System.Drawing.Size(132, 45);
            this.txtDonVi3.TabIndex = 96;
            this.txtDonVi3.TabStop = false;
            // 
            // txtCachDung3
            // 
            this.txtCachDung3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCachDung3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCachDung3.Enabled = false;
            this.txtCachDung3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCachDung3.Location = new System.Drawing.Point(784, 503);
            this.txtCachDung3.Margin = new System.Windows.Forms.Padding(4);
            this.txtCachDung3.Multiline = true;
            this.txtCachDung3.Name = "txtCachDung3";
            this.txtCachDung3.Size = new System.Drawing.Size(312, 45);
            this.txtCachDung3.TabIndex = 96;
            this.txtCachDung3.TabStop = false;
            // 
            // btnLapPK
            // 
            this.btnLapPK.Location = new System.Drawing.Point(35, 581);
            this.btnLapPK.Name = "btnLapPK";
            this.btnLapPK.Size = new System.Drawing.Size(221, 44);
            this.btnLapPK.TabIndex = 97;
            this.btnLapPK.Text = "Lập phiếu khám";
            this.btnLapPK.UseVisualStyleBackColor = true;
            this.btnLapPK.Click += new System.EventHandler(this.btnLapPK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(982, 581);
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
            // GUI_LapPhieuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1157, 649);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLapPK);
            this.Controls.Add(this.txtCachDung3);
            this.Controls.Add(this.txtCachDung2);
            this.Controls.Add(this.txtCachDung1);
            this.Controls.Add(this.txtDonVi3);
            this.Controls.Add(this.txtDonVi2);
            this.Controls.Add(this.txtDonVi1);
            this.Controls.Add(this.txtTenBN);
            this.Controls.Add(this.txtSLThuoc3);
            this.Controls.Add(this.txtSLThuoc2);
            this.Controls.Add(this.txtSLThuoc1);
            this.Controls.Add(this.txtSTT3);
            this.Controls.Add(this.txtSTT2);
            this.Controls.Add(this.txtSTT1);
            this.Controls.Add(this.txtMaKB);
            this.Controls.Add(this.txtNK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectLoaiBenh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbLoaiThuoc3);
            this.Controls.Add(this.cbLoaiThuoc2);
            this.Controls.Add(this.cbLoaiThuoc1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "GUI_LapPhieuKhamBenh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GUI_LapPhieuKhamBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtTrieuChung;
        private ComboBox cbLoaiThuoc1;
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
        private TextBox txtNK;
        private TextBox txtTenBN;
        private TextBox txtMaKB;
        private TextBox txtDonVi1;
        private TextBox txtCachDung1;
        private TextBox txtSTT1;
        private TextBox txtSLThuoc1;
        private ComboBox cbLoaiThuoc2;
        private TextBox txtSTT2;
        private TextBox txtSLThuoc2;
        private TextBox txtDonVi2;
        private TextBox txtCachDung2;
        private ComboBox cbLoaiThuoc3;
        private TextBox txtSTT3;
        private TextBox txtSLThuoc3;
        private TextBox txtDonVi3;
        private TextBox txtCachDung3;
        private Button btnLapPK;
        private Button btnExit;
        private ErrorProvider errorProvider1;
    }
}