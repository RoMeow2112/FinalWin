namespace HotelManagement
{
    partial class CustomerManagement
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
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonOccupied = new System.Windows.Forms.RadioButton();
            this.radioButtonAvailable = new System.Windows.Forms.RadioButton();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(12, 21);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(815, 570);
            this.dataGridViewCustomer.TabIndex = 7;
            this.dataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellClick);
            this.dataGridViewCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellDoubleClick);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAll.Location = new System.Drawing.Point(59, 93);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(51, 25);
            this.radioButtonAll.TabIndex = 2;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonOccupied
            // 
            this.radioButtonOccupied.AutoSize = true;
            this.radioButtonOccupied.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOccupied.Location = new System.Drawing.Point(59, 62);
            this.radioButtonOccupied.Name = "radioButtonOccupied";
            this.radioButtonOccupied.Size = new System.Drawing.Size(108, 25);
            this.radioButtonOccupied.TabIndex = 1;
            this.radioButtonOccupied.TabStop = true;
            this.radioButtonOccupied.Text = "Occupied";
            this.radioButtonOccupied.UseVisualStyleBackColor = true;
            // 
            // radioButtonAvailable
            // 
            this.radioButtonAvailable.AutoSize = true;
            this.radioButtonAvailable.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAvailable.Location = new System.Drawing.Point(59, 31);
            this.radioButtonAvailable.Name = "radioButtonAvailable";
            this.radioButtonAvailable.Size = new System.Drawing.Size(104, 25);
            this.radioButtonAvailable.TabIndex = 0;
            this.radioButtonAvailable.TabStop = true;
            this.radioButtonAvailable.Text = "Available";
            this.radioButtonAvailable.UseVisualStyleBackColor = true;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.buttonCheck);
            this.groupBoxFilter.Controls.Add(this.radioButtonAll);
            this.groupBoxFilter.Controls.Add(this.radioButtonOccupied);
            this.groupBoxFilter.Controls.Add(this.radioButtonAvailable);
            this.groupBoxFilter.Location = new System.Drawing.Point(844, 21);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(220, 182);
            this.groupBoxFilter.TabIndex = 8;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.Location = new System.Drawing.Point(29, 124);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(167, 43);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "CHECK";
            this.buttonCheck.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.Location = new System.Drawing.Point(844, 220);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(220, 217);
            this.pictureBoxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCustomer.TabIndex = 11;
            this.pictureBoxCustomer.TabStop = false;
            this.pictureBoxCustomer.DoubleClick += new System.EventHandler(this.pictureBoxCustomer_DoubleClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(854, 530);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(196, 61);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.Location = new System.Drawing.Point(854, 454);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(196, 61);
            this.buttonAddCustomer.TabIndex = 9;
            this.buttonAddCustomer.Text = "Add New Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 603);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.pictureBoxCustomer);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAddCustomer);
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonOccupied;
        private System.Windows.Forms.RadioButton radioButtonAvailable;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAddCustomer;
    }
}