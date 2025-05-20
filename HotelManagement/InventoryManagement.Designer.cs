namespace HotelManagement
{
    partial class InventoryManagement
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
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAllocatedStock = new System.Windows.Forms.Button();
            this.textBoxAllocatedStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInventoryWarning = new System.Windows.Forms.Label();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.textBoxStockAvailable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(11, 11);
            this.dataGridViewInventory.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.RowTemplate.Height = 24;
            this.dataGridViewInventory.Size = new System.Drawing.Size(826, 289);
            this.dataGridViewInventory.TabIndex = 12;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(680, 353);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(157, 50);
            this.buttonRefresh.TabIndex = 15;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAllocatedStock
            // 
            this.buttonAllocatedStock.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllocatedStock.Location = new System.Drawing.Point(496, 353);
            this.buttonAllocatedStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAllocatedStock.Name = "buttonAllocatedStock";
            this.buttonAllocatedStock.Size = new System.Drawing.Size(157, 50);
            this.buttonAllocatedStock.TabIndex = 14;
            this.buttonAllocatedStock.Text = "Allocate";
            this.buttonAllocatedStock.UseVisualStyleBackColor = true;
            this.buttonAllocatedStock.Click += new System.EventHandler(this.buttonAllocatedStock_Click);
            // 
            // textBoxAllocatedStock
            // 
            this.textBoxAllocatedStock.Location = new System.Drawing.Point(631, 317);
            this.textBoxAllocatedStock.Name = "textBoxAllocatedStock";
            this.textBoxAllocatedStock.Size = new System.Drawing.Size(206, 20);
            this.textBoxAllocatedStock.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Allocated Stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Item:";
            // 
            // labelInventoryWarning
            // 
            this.labelInventoryWarning.AutoSize = true;
            this.labelInventoryWarning.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryWarning.Location = new System.Drawing.Point(190, 422);
            this.labelInventoryWarning.Name = "labelInventoryWarning";
            this.labelInventoryWarning.Size = new System.Drawing.Size(0, 19);
            this.labelInventoryWarning.TabIndex = 27;
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(75, 317);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(253, 21);
            this.comboBoxItem.TabIndex = 28;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Font = new System.Drawing.Font("Helvetica Neue", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.Location = new System.Drawing.Point(333, 316);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(117, 22);
            this.buttonAddItem.TabIndex = 29;
            this.buttonAddItem.Text = "Add New Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // textBoxStockAvailable
            // 
            this.textBoxStockAvailable.Location = new System.Drawing.Point(75, 352);
            this.textBoxStockAvailable.Name = "textBoxStockAvailable";
            this.textBoxStockAvailable.Size = new System.Drawing.Size(375, 20);
            this.textBoxStockAvailable.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Stock:";
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStock.Location = new System.Drawing.Point(16, 391);
            this.buttonAddStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(157, 50);
            this.buttonAddStock.TabIndex = 30;
            this.buttonAddStock.Text = "ADD STOCK";
            this.buttonAddStock.UseVisualStyleBackColor = true;
            this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 493);
            this.Controls.Add(this.textBoxStockAvailable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddStock);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.labelInventoryWarning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAllocatedStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAllocatedStock);
            this.Name = "InventoryManagement";
            this.Text = "InventoryManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAllocatedStock;
        private System.Windows.Forms.TextBox textBoxAllocatedStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInventoryWarning;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.TextBox textBoxStockAvailable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddStock;
    }
}