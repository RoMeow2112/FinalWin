namespace HotelManagement
{
    partial class DailyRevenueReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCalculateRevenue = new System.Windows.Forms.Button();
            this.buttonShowReport = new System.Windows.Forms.Button();
            this.dataGridViewRevenue = new System.Windows.Forms.DataGridView();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(76, 12);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(255, 20);
            this.dateTimePickerDate.TabIndex = 31;
            this.dateTimePickerDate.Value = new System.DateTime(2025, 5, 12, 1, 34, 26, 0);
            // 
            // buttonCalculateRevenue
            // 
            this.buttonCalculateRevenue.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculateRevenue.Location = new System.Drawing.Point(76, 46);
            this.buttonCalculateRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalculateRevenue.Name = "buttonCalculateRevenue";
            this.buttonCalculateRevenue.Size = new System.Drawing.Size(123, 50);
            this.buttonCalculateRevenue.TabIndex = 32;
            this.buttonCalculateRevenue.Text = "Calculate Revenue";
            this.buttonCalculateRevenue.UseVisualStyleBackColor = true;
            this.buttonCalculateRevenue.Click += new System.EventHandler(this.buttonCalculateRevenue_Click);
            // 
            // buttonShowReport
            // 
            this.buttonShowReport.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowReport.Location = new System.Drawing.Point(213, 46);
            this.buttonShowReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowReport.Name = "buttonShowReport";
            this.buttonShowReport.Size = new System.Drawing.Size(118, 50);
            this.buttonShowReport.TabIndex = 33;
            this.buttonShowReport.Text = "Show Report";
            this.buttonShowReport.UseVisualStyleBackColor = true;
            this.buttonShowReport.Click += new System.EventHandler(this.buttonShowReport_Click);
            // 
            // dataGridViewRevenue
            // 
            this.dataGridViewRevenue.AllowUserToAddRows = false;
            this.dataGridViewRevenue.AllowUserToDeleteRows = false;
            this.dataGridViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevenue.Location = new System.Drawing.Point(12, 132);
            this.dataGridViewRevenue.Name = "dataGridViewRevenue";
            this.dataGridViewRevenue.ReadOnly = true;
            this.dataGridViewRevenue.Size = new System.Drawing.Size(319, 441);
            this.dataGridViewRevenue.TabIndex = 34;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Helvetica Neue", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(13, 113);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 15);
            this.labelStatus.TabIndex = 35;
            // 
            // DailyRevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 585);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.dataGridViewRevenue);
            this.Controls.Add(this.buttonShowReport);
            this.Controls.Add(this.buttonCalculateRevenue);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label2);
            this.Name = "DailyRevenueReport";
            this.Text = "DailyRevenueReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonCalculateRevenue;
        private System.Windows.Forms.Button buttonShowReport;
        private System.Windows.Forms.DataGridView dataGridViewRevenue;
        private System.Windows.Forms.Label labelStatus;
    }
}