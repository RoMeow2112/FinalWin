namespace HotelManagement
{
    partial class MainForm
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
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonBooking = new System.Windows.Forms.Button();
            this.buttonFoods = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonRevenue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRoom
            // 
            this.buttonRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom.Location = new System.Drawing.Point(39, 67);
            this.buttonRoom.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(141, 43);
            this.buttonRoom.TabIndex = 0;
            this.buttonRoom.Text = "Room Manage";
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomer.Location = new System.Drawing.Point(60, 165);
            this.buttonCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(141, 57);
            this.buttonCustomer.TabIndex = 1;
            this.buttonCustomer.Text = "Customer Manage";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonBooking
            // 
            this.buttonBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooking.Location = new System.Drawing.Point(60, 262);
            this.buttonBooking.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(141, 50);
            this.buttonBooking.TabIndex = 2;
            this.buttonBooking.Text = "Booking";
            this.buttonBooking.UseVisualStyleBackColor = true;
            this.buttonBooking.Click += new System.EventHandler(this.buttonBooking_Click);
            // 
            // buttonFoods
            // 
            this.buttonFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFoods.Location = new System.Drawing.Point(205, 165);
            this.buttonFoods.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFoods.Name = "buttonFoods";
            this.buttonFoods.Size = new System.Drawing.Size(141, 50);
            this.buttonFoods.TabIndex = 3;
            this.buttonFoods.Text = "Foods";
            this.buttonFoods.UseVisualStyleBackColor = true;
            this.buttonFoods.Click += new System.EventHandler(this.buttonFoods_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventory.Location = new System.Drawing.Point(184, 63);
            this.buttonInventory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(141, 50);
            this.buttonInventory.TabIndex = 4;
            this.buttonInventory.Text = "Inventory";
            this.buttonInventory.UseVisualStyleBackColor = true;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonRevenue
            // 
            this.buttonRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevenue.Location = new System.Drawing.Point(205, 262);
            this.buttonRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRevenue.Name = "buttonRevenue";
            this.buttonRevenue.Size = new System.Drawing.Size(141, 50);
            this.buttonRevenue.TabIndex = 5;
            this.buttonRevenue.Text = "Revenue";
            this.buttonRevenue.UseVisualStyleBackColor = true;
            this.buttonRevenue.Click += new System.EventHandler(this.buttonRevenue_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(329, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRevenue);
            this.Controls.Add(this.buttonInventory);
            this.Controls.Add(this.buttonFoods);
            this.Controls.Add(this.buttonBooking);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonRoom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonBooking;
        private System.Windows.Forms.Button buttonFoods;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonRevenue;
        private System.Windows.Forms.Button button1;
    }
}