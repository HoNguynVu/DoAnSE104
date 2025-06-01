namespace DoAnSE104.GUI
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.ThaoTac = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCachDung)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(34, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(597, 86);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Quản lý cách dùng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.labelThemCachDung);
            this.groupBox1.Controls.Add(this.labelMaCachDung);
            this.groupBox1.Controls.Add(this.txtMaCachDung);
            this.groupBox1.Controls.Add(this.labelCachDung);
            this.groupBox1.Controls.Add(this.txtCachDung);
            this.groupBox1.Controls.Add(this.btnThemCachDung);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(34, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.groupBox1.Size = new System.Drawing.Size(1238, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // labelThemCachDung
            // 
            this.labelThemCachDung.AutoSize = true;
            this.labelThemCachDung.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelThemCachDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelThemCachDung.Location = new System.Drawing.Point(28, 31);
            this.labelThemCachDung.Name = "labelThemCachDung";
            this.labelThemCachDung.Size = new System.Drawing.Size(266, 45);
            this.labelThemCachDung.TabIndex = 0;
            this.labelThemCachDung.Text = "Thêm cách dùng";
            // 
            // labelMaCachDung
            // 
            this.labelMaCachDung.AutoSize = true;
            this.labelMaCachDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaCachDung.Location = new System.Drawing.Point(34, 94);
            this.labelMaCachDung.Name = "labelMaCachDung";
            this.labelMaCachDung.Size = new System.Drawing.Size(166, 32);
            this.labelMaCachDung.TabIndex = 1;
            this.labelMaCachDung.Text = "Mã cách dùng";
            // 
            // txtMaCachDung
            // 
            this.txtMaCachDung.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaCachDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaCachDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaCachDung.Location = new System.Drawing.Point(38, 131);
            this.txtMaCachDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaCachDung.Name = "txtMaCachDung";
            this.txtMaCachDung.ReadOnly = true;
            this.txtMaCachDung.Size = new System.Drawing.Size(247, 39);
            this.txtMaCachDung.TabIndex = 2;
            // 
            // labelCachDung
            // 
            this.labelCachDung.AutoSize = true;
            this.labelCachDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelCachDung.Location = new System.Drawing.Point(304, 94);
            this.labelCachDung.Name = "labelCachDung";
            this.labelCachDung.Size = new System.Drawing.Size(129, 32);
            this.labelCachDung.TabIndex = 3;
            this.labelCachDung.Text = "Cách dùng";
            // 
            // txtCachDung
            // 
            this.txtCachDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCachDung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCachDung.Location = new System.Drawing.Point(308, 131);
            this.txtCachDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(247, 39);
            this.txtCachDung.TabIndex = 4;
            // 
            // btnThemCachDung
            // 
            this.btnThemCachDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnThemCachDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCachDung.FlatAppearance.BorderSize = 0;
            this.btnThemCachDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCachDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemCachDung.ForeColor = System.Drawing.Color.White;
            this.btnThemCachDung.Location = new System.Drawing.Point(1001, 31);
            this.btnThemCachDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemCachDung.Name = "btnThemCachDung";
            this.btnThemCachDung.Size = new System.Drawing.Size(210, 56);
            this.btnThemCachDung.TabIndex = 5;
            this.btnThemCachDung.Text = "Thêm cách dùng";
            this.btnThemCachDung.UseVisualStyleBackColor = false;
            // 
            // dgvDanhSachCachDung
            // 
            this.dgvDanhSachCachDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachCachDung.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachCachDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachCachDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachCachDung.ColumnHeadersHeight = 29;
            this.dgvDanhSachCachDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaCachDung,
            this.CachDung,
            this.ThaoTac});
            this.dgvDanhSachCachDung.EnableHeadersVisualStyles = false;
            this.dgvDanhSachCachDung.GridColor = System.Drawing.Color.LightGray;
            this.dgvDanhSachCachDung.Location = new System.Drawing.Point(34, 450);
            this.dgvDanhSachCachDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachCachDung.Name = "dgvDanhSachCachDung";
            this.dgvDanhSachCachDung.RowHeadersVisible = false;
            this.dgvDanhSachCachDung.RowHeadersWidth = 51;
            this.dgvDanhSachCachDung.RowTemplate.Height = 32;
            this.dgvDanhSachCachDung.Size = new System.Drawing.Size(1238, 375);
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
            // ThaoTac
            // 
            this.ThaoTac.HeaderText = "THAO TÁC";
            this.ThaoTac.MinimumWidth = 6;
            this.ThaoTac.Name = "ThaoTac";
            this.ThaoTac.Text = "Xóa";
            this.ThaoTac.UseColumnTextForButtonValue = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1084, 219);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 56);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(964, 219);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 56);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1305, 875);
            this.Controls.Add(this.dgvDanhSachCachDung);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Quản lý loại thuốc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCachDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelThemCachDung;
        private System.Windows.Forms.Label labelMaCachDung;
        private System.Windows.Forms.TextBox txtMaCachDung;
        private System.Windows.Forms.Label labelCachDung;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Button btnThemCachDung;
        private System.Windows.Forms.DataGridView dgvDanhSachCachDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCachDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
        private System.Windows.Forms.DataGridViewButtonColumn ThaoTac;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}