namespace HotelManagement
{
    partial class BookingBillManagement
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
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonOverdue = new System.Windows.Forms.RadioButton();
            this.radioButtonValid = new System.Windows.Forms.RadioButton();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonBooking = new System.Windows.Forms.Button();
            this.radioButtonPaid = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(11, 11);
            this.dataGridViewBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.RowHeadersWidth = 51;
            this.dataGridViewBooking.RowTemplate.Height = 24;
            this.dataGridViewBooking.Size = new System.Drawing.Size(611, 463);
            this.dataGridViewBooking.TabIndex = 11;
            this.dataGridViewBooking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooking_CellDoubleClick);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.radioButtonPaid);
            this.groupBoxFilter.Controls.Add(this.buttonCheck);
            this.groupBoxFilter.Controls.Add(this.radioButtonAll);
            this.groupBoxFilter.Controls.Add(this.radioButtonOverdue);
            this.groupBoxFilter.Controls.Add(this.radioButtonValid);
            this.groupBoxFilter.Location = new System.Drawing.Point(635, 11);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFilter.Size = new System.Drawing.Size(165, 186);
            this.groupBoxFilter.TabIndex = 12;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.Location = new System.Drawing.Point(22, 136);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(125, 35);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "CHECK";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAll.Location = new System.Drawing.Point(44, 76);
            this.radioButtonAll.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(44, 21);
            this.radioButtonAll.TabIndex = 2;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonOverdue
            // 
            this.radioButtonOverdue.AutoSize = true;
            this.radioButtonOverdue.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOverdue.Location = new System.Drawing.Point(44, 50);
            this.radioButtonOverdue.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonOverdue.Name = "radioButtonOverdue";
            this.radioButtonOverdue.Size = new System.Drawing.Size(82, 21);
            this.radioButtonOverdue.TabIndex = 1;
            this.radioButtonOverdue.TabStop = true;
            this.radioButtonOverdue.Text = "Overdue";
            this.radioButtonOverdue.UseVisualStyleBackColor = true;
            // 
            // radioButtonValid
            // 
            this.radioButtonValid.AutoSize = true;
            this.radioButtonValid.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonValid.Location = new System.Drawing.Point(44, 25);
            this.radioButtonValid.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonValid.Name = "radioButtonValid";
            this.radioButtonValid.Size = new System.Drawing.Size(59, 21);
            this.radioButtonValid.TabIndex = 0;
            this.radioButtonValid.TabStop = true;
            this.radioButtonValid.Text = "Valid";
            this.radioButtonValid.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(644, 424);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(156, 50);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonBooking
            // 
            this.buttonBooking.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooking.Location = new System.Drawing.Point(644, 361);
            this.buttonBooking.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(156, 50);
            this.buttonBooking.TabIndex = 13;
            this.buttonBooking.Text = "NEW BOOKING";
            this.buttonBooking.UseVisualStyleBackColor = true;
            this.buttonBooking.Click += new System.EventHandler(this.buttonBooking_Click);
            // 
            // radioButtonPaid
            // 
            this.radioButtonPaid.AutoSize = true;
            this.radioButtonPaid.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPaid.Location = new System.Drawing.Point(44, 101);
            this.radioButtonPaid.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPaid.Name = "radioButtonPaid";
            this.radioButtonPaid.Size = new System.Drawing.Size(56, 21);
            this.radioButtonPaid.TabIndex = 4;
            this.radioButtonPaid.TabStop = true;
            this.radioButtonPaid.Text = "Paid";
            this.radioButtonPaid.UseVisualStyleBackColor = true;
            // 
            // BookingBillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 490);
            this.Controls.Add(this.dataGridViewBooking);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonBooking);
            this.Name = "BookingBillManagement";
            this.Text = "BookingBillManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonOverdue;
        private System.Windows.Forms.RadioButton radioButtonValid;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonBooking;
        private System.Windows.Forms.RadioButton radioButtonPaid;
    }
}