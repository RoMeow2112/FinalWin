namespace HotelManagement
{
    partial class FoodManagement
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
            this.dataGridViewFoods = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonUpdateStock = new System.Windows.Forms.Button();
            this.labelRoom = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStockUsed = new System.Windows.Forms.TextBox();
            this.labelWarning = new System.Windows.Forms.Label();
            this.comboBoxFoodItem = new System.Windows.Forms.ComboBox();
            this.labelFoodItem = new System.Windows.Forms.Label();
            this.textBoxStockIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddFood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFoods
            // 
            this.dataGridViewFoods.AllowUserToAddRows = false;
            this.dataGridViewFoods.AllowUserToDeleteRows = false;
            this.dataGridViewFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoods.Location = new System.Drawing.Point(11, 11);
            this.dataGridViewFoods.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFoods.Name = "dataGridViewFoods";
            this.dataGridViewFoods.ReadOnly = true;
            this.dataGridViewFoods.RowHeadersWidth = 51;
            this.dataGridViewFoods.RowTemplate.Height = 24;
            this.dataGridViewFoods.Size = new System.Drawing.Size(611, 218);
            this.dataGridViewFoods.TabIndex = 15;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(506, 322);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(116, 35);
            this.buttonRefresh.TabIndex = 18;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonUpdateStock
            // 
            this.buttonUpdateStock.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateStock.Location = new System.Drawing.Point(371, 322);
            this.buttonUpdateStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateStock.Name = "buttonUpdateStock";
            this.buttonUpdateStock.Size = new System.Drawing.Size(131, 35);
            this.buttonUpdateStock.TabIndex = 17;
            this.buttonUpdateStock.Text = "Update Stock";
            this.buttonUpdateStock.UseVisualStyleBackColor = true;
            this.buttonUpdateStock.Click += new System.EventHandler(this.buttonUpdateStock_Click);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom.Location = new System.Drawing.Point(12, 242);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(60, 19);
            this.labelRoom.TabIndex = 19;
            this.labelRoom.Text = "Room:";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(78, 244);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(266, 21);
            this.comboBoxRoom.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Stock Used:";
            // 
            // textBoxStockUsed
            // 
            this.textBoxStockUsed.Location = new System.Drawing.Point(457, 281);
            this.textBoxStockUsed.Name = "textBoxStockUsed";
            this.textBoxStockUsed.Size = new System.Drawing.Size(164, 20);
            this.textBoxStockUsed.TabIndex = 22;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.Location = new System.Drawing.Point(12, 322);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 19);
            this.labelWarning.TabIndex = 23;
            // 
            // comboBoxFoodItem
            // 
            this.comboBoxFoodItem.FormattingEnabled = true;
            this.comboBoxFoodItem.Location = new System.Drawing.Point(78, 283);
            this.comboBoxFoodItem.Name = "comboBoxFoodItem";
            this.comboBoxFoodItem.Size = new System.Drawing.Size(266, 21);
            this.comboBoxFoodItem.TabIndex = 25;
            // 
            // labelFoodItem
            // 
            this.labelFoodItem.AutoSize = true;
            this.labelFoodItem.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoodItem.Location = new System.Drawing.Point(12, 281);
            this.labelFoodItem.Name = "labelFoodItem";
            this.labelFoodItem.Size = new System.Drawing.Size(48, 19);
            this.labelFoodItem.TabIndex = 24;
            this.labelFoodItem.Text = "Item:";
            // 
            // textBoxStockIn
            // 
            this.textBoxStockIn.Location = new System.Drawing.Point(457, 246);
            this.textBoxStockIn.Name = "textBoxStockIn";
            this.textBoxStockIn.Size = new System.Drawing.Size(164, 20);
            this.textBoxStockIn.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Stock In:";
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFood.Location = new System.Drawing.Point(270, 322);
            this.buttonAddFood.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(97, 35);
            this.buttonAddFood.TabIndex = 28;
            this.buttonAddFood.Text = "Add Item";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            this.buttonAddFood.Click += new System.EventHandler(this.buttonAddFood_Click);
            // 
            // FoodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 375);
            this.Controls.Add(this.buttonAddFood);
            this.Controls.Add(this.textBoxStockIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFoodItem);
            this.Controls.Add(this.labelFoodItem);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.textBoxStockUsed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.dataGridViewFoods);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonUpdateStock);
            this.Name = "FoodManagement";
            this.Text = "FoodManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFoods;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonUpdateStock;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStockUsed;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.ComboBox comboBoxFoodItem;
        private System.Windows.Forms.Label labelFoodItem;
        private System.Windows.Forms.TextBox textBoxStockIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddFood;
    }
}