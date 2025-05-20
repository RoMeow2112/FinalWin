namespace HotelManagement
{
    partial class BookingDetail
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
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonPaid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDetails.Location = new System.Drawing.Point(0, 0);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDetails.Size = new System.Drawing.Size(422, 450);
            this.textBoxDetails.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.IndianRed;
            this.buttonClose.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(279, 387);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(104, 42);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonPrint.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(142, 387);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(104, 42);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "PRINT";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPaid
            // 
            this.buttonPaid.BackColor = System.Drawing.Color.Gold;
            this.buttonPaid.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaid.Location = new System.Drawing.Point(12, 387);
            this.buttonPaid.Name = "buttonPaid";
            this.buttonPaid.Size = new System.Drawing.Size(104, 42);
            this.buttonPaid.TabIndex = 3;
            this.buttonPaid.Text = "PAID!";
            this.buttonPaid.UseVisualStyleBackColor = false;
            this.buttonPaid.Click += new System.EventHandler(this.buttonPaid_Click);
            // 
            // BookingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.buttonPaid);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxDetails);
            this.Name = "BookingDetail";
            this.Text = "BookingDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPaid;
    }
}