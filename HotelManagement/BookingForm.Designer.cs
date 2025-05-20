namespace HotelManagement
{
    partial class BookingForm
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
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Helvetica Neue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPrice.Location = new System.Drawing.Point(151, 249);
            this.textBoxTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(209, 33);
            this.textBoxTotalPrice.TabIndex = 30;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(25, 192);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(117, 17);
            this.labelEmail.TabIndex = 29;
            this.labelEmail.Text = "Date Check Out:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Salmon;
            this.buttonCancel.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(323, 313);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 49);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.LightGreen;
            this.buttonConfirm.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(86, 313);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(99, 49);
            this.buttonConfirm.TabIndex = 26;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(25, 133);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(105, 17);
            this.labelPhone.TabIndex = 24;
            this.labelPhone.Text = "Date Check In:";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom.Location = new System.Drawing.Point(25, 78);
            this.labelRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(110, 17);
            this.labelRoom.TabIndex = 23;
            this.labelRoom.Text = "Room Booked:";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(25, 26);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(121, 17);
            this.labelCustomer.TabIndex = 21;
            this.labelCustomer.Text = "Customer Name:";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(151, 26);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(229, 21);
            this.comboBoxCustomer.TabIndex = 31;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(151, 78);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(333, 21);
            this.comboBoxRoom.TabIndex = 32;
            // 
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(151, 130);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(333, 20);
            this.dateTimePickerCheckIn.TabIndex = 33;
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(151, 189);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(333, 20);
            this.dateTimePickerCheckOut.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Total Price:";
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAddCustomer.Font = new System.Drawing.Font("Helvetica Neue", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.Location = new System.Drawing.Point(385, 11);
            this.buttonAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(99, 49);
            this.buttonAddCustomer.TabIndex = 36;
            this.buttonAddCustomer.Text = "Add New Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = false;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 396);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerCheckOut);
            this.Controls.Add(this.dateTimePickerCheckIn);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelCustomer);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCustomer;
    }
}