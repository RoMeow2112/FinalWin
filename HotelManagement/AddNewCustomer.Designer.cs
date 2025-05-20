namespace HotelManagement
{
    partial class AddNewCustomer
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCccd = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCccd = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Salmon;
            this.buttonCancel.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(373, 295);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 49);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(135, 295);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(99, 49);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(135, 121);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(238, 20);
            this.textBoxPhone.TabIndex = 13;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(14, 120);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(111, 17);
            this.labelPhone.TabIndex = 12;
            this.labelPhone.Text = "Phone Number:";
            // 
            // labelCccd
            // 
            this.labelCccd.AutoSize = true;
            this.labelCccd.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCccd.Location = new System.Drawing.Point(14, 72);
            this.labelCccd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCccd.Name = "labelCccd";
            this.labelCccd.Size = new System.Drawing.Size(52, 17);
            this.labelCccd.TabIndex = 11;
            this.labelCccd.Text = "CCCD:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(135, 28);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(238, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(14, 27);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Full Name:";
            // 
            // textBoxCccd
            // 
            this.textBoxCccd.Location = new System.Drawing.Point(135, 72);
            this.textBoxCccd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCccd.Name = "textBoxCccd";
            this.textBoxCccd.Size = new System.Drawing.Size(238, 20);
            this.textBoxCccd.TabIndex = 16;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(135, 176);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(238, 90);
            this.textBoxEmail.TabIndex = 18;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(14, 175);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(111, 17);
            this.labelEmail.TabIndex = 17;
            this.labelEmail.Text = "Email Address:";
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBoxCustomer.Location = new System.Drawing.Point(397, 28);
            this.pictureBoxCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(200, 198);
            this.pictureBoxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCustomer.TabIndex = 19;
            this.pictureBoxCustomer.TabStop = false;
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUploadImage.Location = new System.Drawing.Point(397, 238);
            this.buttonUploadImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(200, 27);
            this.buttonUploadImage.TabIndex = 20;
            this.buttonUploadImage.Text = "Upload Image";
            this.buttonUploadImage.UseVisualStyleBackColor = false;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 366);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.pictureBoxCustomer);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxCccd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelCccd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNewCustomer";
            this.Text = "AddNewCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCccd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxCccd;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.Button buttonUploadImage;
    }
}