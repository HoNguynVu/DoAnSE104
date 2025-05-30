namespace DoAnSE104.GUI
{
    partial class GUI_DanhSachThamSo
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
            this.txtSoLuongToiDa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTienKhamCoDinh = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(7, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(443, 62);
            this.label13.TabIndex = 117;
            this.label13.Text = "Danh sách tham số";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 67);
            this.label1.TabIndex = 117;
            this.label1.Text = "Quy định số lượng bệnh nhân tối đa trong ngày";
            // 
            // txtSoLuongToiDa
            // 
            this.txtSoLuongToiDa.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSoLuongToiDa.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSoLuongToiDa.Enabled = false;
            this.txtSoLuongToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongToiDa.Location = new System.Drawing.Point(874, 114);
            this.txtSoLuongToiDa.Margin = new System.Windows.Forms.Padding(7);
            this.txtSoLuongToiDa.Multiline = true;
            this.txtSoLuongToiDa.Name = "txtSoLuongToiDa";
            this.txtSoLuongToiDa.Size = new System.Drawing.Size(252, 67);
            this.txtSoLuongToiDa.TabIndex = 118;
            this.txtSoLuongToiDa.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(582, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 67);
            this.label2.TabIndex = 117;
            this.label2.Text = "Số lượng bệnh nhân tối đa trong ngày";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 35);
            this.label3.TabIndex = 117;
            this.label3.Text = "Quy định tiền khám cố định";
            // 
            // txtTienKhamCoDinh
            // 
            this.txtTienKhamCoDinh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtTienKhamCoDinh.Location = new System.Drawing.Point(582, 332);
            this.txtTienKhamCoDinh.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtTienKhamCoDinh.Name = "txtTienKhamCoDinh";
            this.txtTienKhamCoDinh.Size = new System.Drawing.Size(268, 31);
            this.txtTienKhamCoDinh.TabIndex = 117;
            this.txtTienKhamCoDinh.Text = "Tiền khám cố định";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(874, 310);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 67);
            this.textBox1.TabIndex = 118;
            this.textBox1.TabStop = false;
            // 
            // GUI_DanhSachThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 601);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSoLuongToiDa);
            this.Controls.Add(this.txtTienKhamCoDinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Name = "GUI_DanhSachThamSo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuongToiDa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTienKhamCoDinh;
        private System.Windows.Forms.TextBox textBox1;
    }
}