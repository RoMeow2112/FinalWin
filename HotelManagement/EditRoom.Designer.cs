namespace HotelManagement
{
    partial class EditRoom
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonAvailable = new System.Windows.Forms.RadioButton();
            this.radioButtonOccupied = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Salmon;
            this.buttonCancel.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(369, 270);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(132, 60);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.LightGreen;
            this.buttonEdit.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(208, 270);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(132, 60);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(199, 154);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(316, 22);
            this.textBoxPrice.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Price per Nights:";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacity.Location = new System.Drawing.Point(38, 93);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(87, 21);
            this.labelCapacity.TabIndex = 11;
            this.labelCapacity.Text = "Capacity:";
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Location = new System.Drawing.Point(199, 95);
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCapacity.TabIndex = 10;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(199, 39);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(316, 22);
            this.textBoxRoomNumber.TabIndex = 9;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNumber.Location = new System.Drawing.Point(38, 38);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(132, 21);
            this.labelRoomNumber.TabIndex = 8;
            this.labelRoomNumber.Text = "Room Number:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDelete.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(42, 270);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(132, 60);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Status:";
            // 
            // radioButtonAvailable
            // 
            this.radioButtonAvailable.AutoSize = true;
            this.radioButtonAvailable.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAvailable.Location = new System.Drawing.Point(199, 210);
            this.radioButtonAvailable.Name = "radioButtonAvailable";
            this.radioButtonAvailable.Size = new System.Drawing.Size(98, 24);
            this.radioButtonAvailable.TabIndex = 18;
            this.radioButtonAvailable.TabStop = true;
            this.radioButtonAvailable.Text = "Available";
            this.radioButtonAvailable.UseVisualStyleBackColor = true;
            // 
            // radioButtonOccupied
            // 
            this.radioButtonOccupied.AutoSize = true;
            this.radioButtonOccupied.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOccupied.Location = new System.Drawing.Point(349, 210);
            this.radioButtonOccupied.Name = "radioButtonOccupied";
            this.radioButtonOccupied.Size = new System.Drawing.Size(103, 24);
            this.radioButtonOccupied.TabIndex = 19;
            this.radioButtonOccupied.TabStop = true;
            this.radioButtonOccupied.Text = "Occupied";
            this.radioButtonOccupied.UseVisualStyleBackColor = true;
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 348);
            this.Controls.Add(this.radioButtonOccupied);
            this.Controls.Add(this.radioButtonAvailable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.numericUpDownCapacity);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.labelRoomNumber);
            this.Name = "EditRoom";
            this.Text = "EditRoom";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonAvailable;
        private System.Windows.Forms.RadioButton radioButtonOccupied;
    }
}