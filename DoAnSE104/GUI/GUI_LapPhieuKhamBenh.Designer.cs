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
            this.btnLapPK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThuoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // btnLapPK
            // 
            this.btnLapPK.Location = new System.Drawing.Point(35, 582);
            this.btnLapPK.Name = "btnLapPK";
            this.btnLapPK.Size = new System.Drawing.Size(221, 44);
            this.btnLapPK.TabIndex = 97;
            this.btnLapPK.Text = "Lập phiếu khám";
            this.btnLapPK.UseVisualStyleBackColor = true;
            this.btnLapPK.Click += new System.EventHandler(this.btnLapPK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1003, 582);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenLoaiThuoc,
            this.SoLuong,
            this.DonVi,
            this.CachDung});
            this.dataGridView1.Location = new System.Drawing.Point(35, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 253);
            this.dataGridView1.TabIndex = 99;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 150;
            // 
            // TenLoaiThuoc
            // 
            this.TenLoaiThuoc.HeaderText = "TÊN LOẠI THUỐC";
            this.TenLoaiThuoc.MinimumWidth = 6;
            this.TenLoaiThuoc.Name = "TenLoaiThuoc";
            this.TenLoaiThuoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenLoaiThuoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TenLoaiThuoc.Width = 270;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "SỐ LƯỢNG";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // DonVi
            // 
            this.DonVi.HeaderText = "ĐƠN VỊ";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            this.DonVi.Width = 150;
            // 
            // CachDung
            // 
            this.CachDung.HeaderText = "CÁCH DÙNG";
            this.CachDung.MinimumWidth = 6;
            this.CachDung.Name = "CachDung";
            this.CachDung.Width = 320;
            // 
            // GUI_LapPhieuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1157, 638);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLapPK);
            this.Controls.Add(this.txtTenBN);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "GUI_LapPhieuKhamBenh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GUI_LapPhieuKhamBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtTrieuChung;
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
        private Button btnLapPK;
        private Button btnExit;
        private ErrorProvider errorProvider1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewComboBoxColumn TenLoaiThuoc;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn CachDung;
    }
}