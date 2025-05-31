namespace DoAnSE104.GUI
{
    partial class GUI_TiepNhanBenhNhan
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maBenhNhan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(229, 346);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(176, 41);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Tìm bệnh nhân";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(29, 346);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Tiếp nhận";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(507, 346);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(30, 275);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(581, 37);
            this.txtDiaChi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 44);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tiếp nhận bệnh nhân";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Năm sinh";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.BackColor = System.Drawing.SystemColors.Window;
            this.txtNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Location = new System.Drawing.Point(362, 186);
            this.txtNamSinh.Multiline = true;
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(248, 37);
            this.txtNamSinh.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(363, 98);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(248, 37);
            this.txtHoTen.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giới tính";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.BackColor = System.Drawing.SystemColors.Window;
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(30, 186);
            this.txtGioiTinh.Multiline = true;
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(248, 37);
            this.txtGioiTinh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã bệnh nhân";
            // 
            // maBenhNhan
            // 
            this.maBenhNhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.maBenhNhan.Cursor = System.Windows.Forms.Cursors.Default;
            this.maBenhNhan.Enabled = false;
            this.maBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maBenhNhan.Location = new System.Drawing.Point(30, 98);
            this.maBenhNhan.Multiline = true;
            this.maBenhNhan.Name = "maBenhNhan";
            this.maBenhNhan.Size = new System.Drawing.Size(248, 37);
            this.maBenhNhan.TabIndex = 20;
            this.maBenhNhan.TabStop = false;
            // 
            // GUI_TiepNhanBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 411);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maBenhNhan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI_TiepNhanBenhNhan";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GUI_TiepNhanBenhNhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maBenhNhan;
    }
}