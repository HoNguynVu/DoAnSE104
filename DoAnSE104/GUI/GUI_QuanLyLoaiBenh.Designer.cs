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
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLoaiBenh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLoaiBenh = new System.Windows.Forms.TextBox();
            this.btnNewLoaiBenh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThaoTac = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(16, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(411, 62);
            this.label13.TabIndex = 117;
            this.label13.Text = "Quản lý loại bệnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 117;
            this.label1.Text = "Thêm loại bệnh";
            // 
            // txtTenLoaiBenh
            // 
            this.txtTenLoaiBenh.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenLoaiBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiBenh.Location = new System.Drawing.Point(589, 147);
            this.txtTenLoaiBenh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenLoaiBenh.Name = "txtTenLoaiBenh";
            this.txtTenLoaiBenh.Size = new System.Drawing.Size(472, 34);
            this.txtTenLoaiBenh.TabIndex = 118;
            this.txtTenLoaiBenh.TextChanged += new System.EventHandler(this.txtTenLoaiBenh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 119;
            this.label2.Text = "Mã loại bệnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 119;
            this.label3.Text = "Tên loại bệnh";
            // 
            // txtMaLoaiBenh
            // 
            this.txtMaLoaiBenh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMaLoaiBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiBenh.Location = new System.Drawing.Point(31, 147);
            this.txtMaLoaiBenh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaLoaiBenh.Name = "txtMaLoaiBenh";
            this.txtMaLoaiBenh.Size = new System.Drawing.Size(472, 34);
            this.txtMaLoaiBenh.TabIndex = 118;
            // 
            // btnNewLoaiBenh
            // 
            this.btnNewLoaiBenh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNewLoaiBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLoaiBenh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewLoaiBenh.Location = new System.Drawing.Point(861, 20);
            this.btnNewLoaiBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewLoaiBenh.Name = "btnNewLoaiBenh";
            this.btnNewLoaiBenh.Size = new System.Drawing.Size(200, 50);
            this.btnNewLoaiBenh.TabIndex = 120;
            this.btnNewLoaiBenh.Text = "Thêm loại bệnh";
            this.btnNewLoaiBenh.UseVisualStyleBackColor = false;
            this.btnNewLoaiBenh.Click += new System.EventHandler(this.btnNewLoaiBenh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenLoaiThuoc,
            this.SoLuong,
            this.ThaoTac});
            this.dataGridView1.Location = new System.Drawing.Point(28, 410);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 72);
            this.dataGridView1.TabIndex = 121;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.TenLoaiThuoc.HeaderText = "MÃ LOẠI BỆNH";
            this.TenLoaiThuoc.MinimumWidth = 6;
            this.TenLoaiThuoc.Name = "TenLoaiThuoc";
            this.TenLoaiThuoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenLoaiThuoc.Width = 300;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "TÊN LOẠI BỆNH";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 470;
            // 
            // ThaoTac
            // 
            this.ThaoTac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ThaoTac.DataPropertyName = "Xóa";
            this.ThaoTac.HeaderText = "THAO TÁC";
            this.ThaoTac.MinimumWidth = 6;
            this.ThaoTac.Name = "ThaoTac";
            this.ThaoTac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ThaoTac.Text = "Xóa";
            this.ThaoTac.Width = 260;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtMaLoaiBenh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNewLoaiBenh);
            this.groupBox1.Controls.Add(this.txtTenLoaiBenh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(27, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 278);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(814, 214);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 50);
            this.btnSave.TabIndex = 122;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(937, 214);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 50);
            this.btnCancel.TabIndex = 121;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GUI_QuanLyLoaiBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 703);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Name = "GUI_QuanLyLoaiBenh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GUI_QuanLyLoaiBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLoaiBenh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLoaiBenh;
        private System.Windows.Forms.Button btnNewLoaiBenh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewButtonColumn ThaoTac;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}