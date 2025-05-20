namespace HotelManagement.EmployeeForms
{
    partial class FormReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpReportDate = new System.Windows.Forms.DateTimePicker();
            this.gbMorning = new System.Windows.Forms.GroupBox();
            this.gbEvening = new System.Windows.Forms.GroupBox();
            this.gbNight = new System.Windows.Forms.GroupBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lblTotalSalaryDue = new System.Windows.Forms.Label();
            this.lblTotalSalaryPaid = new System.Windows.Forms.Label();
            this.flpMorning = new System.Windows.Forms.FlowLayoutPanel();
            this.flpEvening = new System.Windows.Forms.FlowLayoutPanel();
            this.flpNight = new System.Windows.Forms.FlowLayoutPanel();
            this.gbMorning.SuspendLayout();
            this.gbEvening.SuspendLayout();
            this.gbNight.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report ";
            // 
            // dtpReportDate
            // 
            this.dtpReportDate.Location = new System.Drawing.Point(83, 47);
            this.dtpReportDate.Name = "dtpReportDate";
            this.dtpReportDate.Size = new System.Drawing.Size(210, 20);
            this.dtpReportDate.TabIndex = 1;
            // 
            // gbMorning
            // 
            this.gbMorning.Controls.Add(this.flpMorning);
            this.gbMorning.Location = new System.Drawing.Point(27, 91);
            this.gbMorning.Name = "gbMorning";
            this.gbMorning.Size = new System.Drawing.Size(200, 100);
            this.gbMorning.TabIndex = 2;
            this.gbMorning.TabStop = false;
            this.gbMorning.Text = "Morning";
            // 
            // gbEvening
            // 
            this.gbEvening.Controls.Add(this.flpEvening);
            this.gbEvening.Location = new System.Drawing.Point(274, 91);
            this.gbEvening.Name = "gbEvening";
            this.gbEvening.Size = new System.Drawing.Size(200, 100);
            this.gbEvening.TabIndex = 3;
            this.gbEvening.TabStop = false;
            this.gbEvening.Text = "Evening";
            // 
            // gbNight
            // 
            this.gbNight.Controls.Add(this.flpNight);
            this.gbNight.Location = new System.Drawing.Point(507, 91);
            this.gbNight.Name = "gbNight";
            this.gbNight.Size = new System.Drawing.Size(200, 100);
            this.gbNight.TabIndex = 3;
            this.gbNight.TabStop = false;
            this.gbNight.Text = "Night";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(299, 41);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(90, 26);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Check";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // lblTotalSalaryDue
            // 
            this.lblTotalSalaryDue.AutoSize = true;
            this.lblTotalSalaryDue.Location = new System.Drawing.Point(154, 245);
            this.lblTotalSalaryDue.Name = "lblTotalSalaryDue";
            this.lblTotalSalaryDue.Size = new System.Drawing.Size(35, 13);
            this.lblTotalSalaryDue.TabIndex = 5;
            this.lblTotalSalaryDue.Text = "label2";
            // 
            // lblTotalSalaryPaid
            // 
            this.lblTotalSalaryPaid.AutoSize = true;
            this.lblTotalSalaryPaid.Location = new System.Drawing.Point(445, 245);
            this.lblTotalSalaryPaid.Name = "lblTotalSalaryPaid";
            this.lblTotalSalaryPaid.Size = new System.Drawing.Size(35, 13);
            this.lblTotalSalaryPaid.TabIndex = 6;
            this.lblTotalSalaryPaid.Text = "label2";
            // 
            // flpMorning
            // 
            this.flpMorning.Location = new System.Drawing.Point(6, 19);
            this.flpMorning.Name = "flpMorning";
            this.flpMorning.Size = new System.Drawing.Size(188, 75);
            this.flpMorning.TabIndex = 0;
            // 
            // flpEvening
            // 
            this.flpEvening.Location = new System.Drawing.Point(6, 19);
            this.flpEvening.Name = "flpEvening";
            this.flpEvening.Size = new System.Drawing.Size(188, 75);
            this.flpEvening.TabIndex = 1;
            // 
            // flpNight
            // 
            this.flpNight.Location = new System.Drawing.Point(6, 19);
            this.flpNight.Name = "flpNight";
            this.flpNight.Size = new System.Drawing.Size(188, 75);
            this.flpNight.TabIndex = 2;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 329);
            this.Controls.Add(this.lblTotalSalaryPaid);
            this.Controls.Add(this.lblTotalSalaryDue);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.gbEvening);
            this.Controls.Add(this.gbNight);
            this.Controls.Add(this.gbMorning);
            this.Controls.Add(this.dtpReportDate);
            this.Controls.Add(this.label1);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.gbMorning.ResumeLayout(false);
            this.gbEvening.ResumeLayout(false);
            this.gbNight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpReportDate;
        private System.Windows.Forms.GroupBox gbMorning;
        private System.Windows.Forms.GroupBox gbEvening;
        private System.Windows.Forms.GroupBox gbNight;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblTotalSalaryDue;
        private System.Windows.Forms.Label lblTotalSalaryPaid;
        private System.Windows.Forms.FlowLayoutPanel flpMorning;
        private System.Windows.Forms.FlowLayoutPanel flpEvening;
        private System.Windows.Forms.FlowLayoutPanel flpNight;
    }
}