namespace HotelManagement
{
    partial class EditCustomer
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxCccd = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCccd = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonDownloadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDelete.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(45, 631);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(132, 60);
            this.buttonDelete.TabIndex = 28;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Salmon;
            this.buttonCancel.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(372, 631);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(132, 60);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.LightGreen;
            this.buttonEdit.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(211, 631);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(132, 60);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonUploadImage.Location = new System.Drawing.Point(328, 140);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(176, 56);
            this.buttonUploadImage.TabIndex = 38;
            this.buttonUploadImage.Text = "Upload Image";
            this.buttonUploadImage.UseVisualStyleBackColor = false;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBoxCustomer.Location = new System.Drawing.Point(31, 24);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(267, 244);
            this.pictureBoxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCustomer.TabIndex = 37;
            this.pictureBoxCustomer.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(188, 493);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(316, 110);
            this.textBoxEmail.TabIndex = 36;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(27, 492);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(131, 21);
            this.labelEmail.TabIndex = 35;
            this.labelEmail.Text = "Email Address:";
            // 
            // textBoxCccd
            // 
            this.textBoxCccd.Location = new System.Drawing.Point(188, 366);
            this.textBoxCccd.Name = "textBoxCccd";
            this.textBoxCccd.Size = new System.Drawing.Size(316, 22);
            this.textBoxCccd.TabIndex = 34;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(188, 426);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(316, 22);
            this.textBoxPhone.TabIndex = 33;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(27, 425);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(136, 21);
            this.labelPhone.TabIndex = 32;
            this.labelPhone.Text = "Phone Number:";
            // 
            // labelCccd
            // 
            this.labelCccd.AutoSize = true;
            this.labelCccd.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCccd.Location = new System.Drawing.Point(27, 365);
            this.labelCccd.Name = "labelCccd";
            this.labelCccd.Size = new System.Drawing.Size(67, 21);
            this.labelCccd.TabIndex = 31;
            this.labelCccd.Text = "CCCD:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(188, 311);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(316, 22);
            this.textBoxName.TabIndex = 30;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(27, 310);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 21);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "Full Name:";
            // 
            // buttonDownloadImage
            // 
            this.buttonDownloadImage.BackColor = System.Drawing.Color.Gold;
            this.buttonDownloadImage.Location = new System.Drawing.Point(328, 212);
            this.buttonDownloadImage.Name = "buttonDownloadImage";
            this.buttonDownloadImage.Size = new System.Drawing.Size(176, 56);
            this.buttonDownloadImage.TabIndex = 39;
            this.buttonDownloadImage.Text = "Download Image";
            this.buttonDownloadImage.UseVisualStyleBackColor = false;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 703);
            this.Controls.Add(this.buttonDownloadImage);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.pictureBoxCustomer);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxCccd);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelCccd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxCccd;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCccd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonDownloadImage;
    }
}