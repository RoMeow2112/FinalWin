namespace HotelManagement.EmployeeForms
{
    partial class FormEditEmployee
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
            this.cbbPosition = new System.Windows.Forms.ComboBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.numHourlyRate = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEditingEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHourlyRate)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbPosition
            // 
            this.cbbPosition.FormattingEnabled = true;
            this.cbbPosition.Location = new System.Drawing.Point(139, 49);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Size = new System.Drawing.Size(121, 21);
            this.cbbPosition.TabIndex = 0;
            this.cbbPosition.SelectedIndexChanged += new System.EventHandler(this.CbbPosition_SelectedIndexChanged);
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(139, 123);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbbStatus.TabIndex = 1;
            // 
            // numHourlyRate
            // 
            this.numHourlyRate.Location = new System.Drawing.Point(140, 85);
            this.numHourlyRate.Name = "numHourlyRate";
            this.numHourlyRate.Size = new System.Drawing.Size(120, 20);
            this.numHourlyRate.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hourly Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            // 
            // lblEditingEmployee
            // 
            this.lblEditingEmployee.AutoSize = true;
            this.lblEditingEmployee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditingEmployee.Location = new System.Drawing.Point(12, 9);
            this.lblEditingEmployee.Name = "lblEditingEmployee";
            this.lblEditingEmployee.Size = new System.Drawing.Size(142, 21);
            this.lblEditingEmployee.TabIndex = 7;
            this.lblEditingEmployee.Text = "Editing employee:";
            // 
            // FormEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 290);
            this.Controls.Add(this.lblEditingEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numHourlyRate);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.cbbPosition);
            this.Name = "FormEditEmployee";
            this.Text = "FormEditEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.numHourlyRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbPosition;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.NumericUpDown numHourlyRate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEditingEmployee;
    }
}