namespace HotelManagement
{
    partial class AddNewRoom
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
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNumber.Location = new System.Drawing.Point(12, 40);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(132, 21);
            this.labelRoomNumber.TabIndex = 0;
            this.labelRoomNumber.Text = "Room Number:";
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(173, 41);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(316, 22);
            this.textBoxRoomNumber.TabIndex = 1;
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Location = new System.Drawing.Point(173, 97);
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCapacity.TabIndex = 2;
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacity.Location = new System.Drawing.Point(12, 95);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(87, 21);
            this.labelCapacity.TabIndex = 3;
            this.labelCapacity.Text = "Capacity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price per Nights:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(173, 156);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(316, 22);
            this.textBoxPrice.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(80, 222);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 60);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Salmon;
            this.buttonCancel.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(275, 222);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(132, 60);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddNewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 313);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.numericUpDownCapacity);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.labelRoomNumber);
            this.Name = "AddNewRoom";
            this.Text = "AddNewRoom";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}