using System.Drawing;

namespace DoAnSE104.GUI
{
    partial class GUI_TiepNhanBenhNhan
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(568, 72);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Tiếp nhận bệnh nhân";
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
            this.groupBoxInfo.Controls.Add(this.labelNamSinh);
            this.groupBoxInfo.Controls.Add(this.txtNamSinh);
            this.groupBoxInfo.Controls.Add(this.labelDiaChi);
            this.groupBoxInfo.Controls.Add(this.txtDiaChi);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(30, 110);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(22, 29, 22, 29);
            this.groupBoxInfo.Size = new System.Drawing.Size(900, 198);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin bệnh nhân";
            // 
            // labelMaBenhNhan
            // 
            this.labelMaBenhNhan.AutoSize = true;
            this.labelMaBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaBenhNhan.Location = new System.Drawing.Point(30, 40);
            this.labelMaBenhNhan.Name = "labelMaBenhNhan";
            this.labelMaBenhNhan.Size = new System.Drawing.Size(137, 28);
            this.labelMaBenhNhan.TabIndex = 1;
            this.labelMaBenhNhan.Text = "Mã bệnh nhân";
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaBenhNhan.Enabled = false;
            this.txtMaBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaBenhNhan.Location = new System.Drawing.Point(34, 70);
            this.txtMaBenhNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.ReadOnly = true;
            this.txtMaBenhNhan.Size = new System.Drawing.Size(247, 34);
            this.txtMaBenhNhan.TabIndex = 2;
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelHoTen.Location = new System.Drawing.Point(304, 40);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(96, 28);
            this.labelHoTen.TabIndex = 3;
            this.labelHoTen.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHoTen.Location = new System.Drawing.Point(308, 70);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(247, 34);
            this.txtHoTen.TabIndex = 4;
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelGioiTinh.Location = new System.Drawing.Point(585, 40);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(87, 28);
            this.labelGioiTinh.TabIndex = 5;
            this.labelGioiTinh.Text = "Giới tính";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtGioiTinh.Location = new System.Drawing.Point(590, 70);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(157, 34);
            this.txtGioiTinh.TabIndex = 6;
            // 
            // labelNamSinh
            // 
            this.labelNamSinh.AutoSize = true;
            this.labelNamSinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNamSinh.Location = new System.Drawing.Point(34, 115);
            this.labelNamSinh.Name = "labelNamSinh";
            this.labelNamSinh.Size = new System.Drawing.Size(94, 28);
            this.labelNamSinh.TabIndex = 7;
            this.labelNamSinh.Text = "Năm sinh";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamSinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNamSinh.Location = new System.Drawing.Point(34, 145);
            this.txtNamSinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(157, 34);
            this.txtNamSinh.TabIndex = 8;
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDiaChi.Location = new System.Drawing.Point(225, 115);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(71, 28);
            this.labelDiaChi.TabIndex = 9;
            this.labelDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(230, 145);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(517, 34);
            this.txtDiaChi.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 556);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 44);
            this.btnAdd.TabIndex = 11;
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
            this.btnNew.Location = new System.Drawing.Point(236, 556);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 44);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "Tìm bệnh nhân";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(730, 556);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 44);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GUI_TiepNhanBenhNhan
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(960, 620);
            this.Name = "GUI_TiepNhanBenhNhan";
            this.Text = "Tiếp nhận bệnh nhân";
            this.Load += new System.EventHandler(this.GUI_TiepNhanBenhNhan_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
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
        private System.Windows.Forms.Label labelNamSinh;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
    }
}