namespace DoAnSE104.GUI
{
    partial class GUI_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Home));
            this.btnMedicalExamination = new System.Windows.Forms.Button();
            this.BtnCreateMedicalExamination = new System.Windows.Forms.Button();
            this.BtnPatientLookup = new System.Windows.Forms.Button();
            this.BtnInvoicePayment = new System.Windows.Forms.Button();
            this.BtnDrugUseReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMedicalExamination
            // 
            this.btnMedicalExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalExamination.Location = new System.Drawing.Point(20, 121);
            this.btnMedicalExamination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMedicalExamination.Name = "btnMedicalExamination";
            this.btnMedicalExamination.Size = new System.Drawing.Size(293, 49);
            this.btnMedicalExamination.TabIndex = 1;
            this.btnMedicalExamination.Text = "Tiếp nhận khám bệnh";
            this.btnMedicalExamination.UseVisualStyleBackColor = true;
            this.btnMedicalExamination.Click += new System.EventHandler(this.BtnMedicalExamination_Click);
            // 
            // BtnCreateMedicalExamination
            // 
            this.BtnCreateMedicalExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateMedicalExamination.Location = new System.Drawing.Point(20, 219);
            this.BtnCreateMedicalExamination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateMedicalExamination.Name = "BtnCreateMedicalExamination";
            this.BtnCreateMedicalExamination.Size = new System.Drawing.Size(293, 49);
            this.BtnCreateMedicalExamination.TabIndex = 2;
            this.BtnCreateMedicalExamination.Text = "Lập phiếu khám bệnh";
            this.BtnCreateMedicalExamination.UseVisualStyleBackColor = true;
            this.BtnCreateMedicalExamination.Click += new System.EventHandler(this.BtnCreateMedicalExamination_Click);
            // 
            // BtnPatientLookup
            // 
            this.BtnPatientLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatientLookup.Location = new System.Drawing.Point(20, 325);
            this.BtnPatientLookup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPatientLookup.Name = "BtnPatientLookup";
            this.BtnPatientLookup.Size = new System.Drawing.Size(293, 49);
            this.BtnPatientLookup.TabIndex = 3;
            this.BtnPatientLookup.Text = "Tra cứu bệnh nhân";
            this.BtnPatientLookup.UseVisualStyleBackColor = true;
            this.BtnPatientLookup.Click += new System.EventHandler(this.BtnPatientLookup_Click);
            // 
            // BtnInvoicePayment
            // 
            this.BtnInvoicePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInvoicePayment.Location = new System.Drawing.Point(394, 121);
            this.BtnInvoicePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInvoicePayment.Name = "BtnInvoicePayment";
            this.BtnInvoicePayment.Size = new System.Drawing.Size(293, 49);
            this.BtnInvoicePayment.TabIndex = 4;
            this.BtnInvoicePayment.Text = "Lập hoá đơn thanh toán";
            this.BtnInvoicePayment.UseVisualStyleBackColor = true;
            this.BtnInvoicePayment.Click += new System.EventHandler(this.BtnInvoicePayment_Click);
            // 
            // BtnDrugUseReport
            // 
            this.BtnDrugUseReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrugUseReport.Location = new System.Drawing.Point(394, 219);
            this.BtnDrugUseReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDrugUseReport.Name = "BtnDrugUseReport";
            this.BtnDrugUseReport.Size = new System.Drawing.Size(293, 49);
            this.BtnDrugUseReport.TabIndex = 5;
            this.BtnDrugUseReport.Text = "Báo cáo sử dụng thuốc";
            this.BtnDrugUseReport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHÒNG MẠCH TƯ ";
            // 
            // GUI_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 442);
            this.Controls.Add(this.BtnDrugUseReport);
            this.Controls.Add(this.BtnInvoicePayment);
            this.Controls.Add(this.BtnPatientLookup);
            this.Controls.Add(this.BtnCreateMedicalExamination);
            this.Controls.Add(this.btnMedicalExamination);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUI_Home";
            this.Text = "Trang chủ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMedicalExamination;
        private System.Windows.Forms.Button BtnCreateMedicalExamination;
        private System.Windows.Forms.Button BtnPatientLookup;
        private System.Windows.Forms.Button BtnInvoicePayment;
        private System.Windows.Forms.Button BtnDrugUseReport;
        private System.Windows.Forms.Label label1;
    }
}