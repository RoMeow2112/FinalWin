namespace HotelManagement
{
    partial class RoomManagement
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
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonOccupied = new System.Windows.Forms.RadioButton();
            this.radioButtonAvailable = new System.Windows.Forms.RadioButton();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Location = new System.Drawing.Point(12, 21);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.RowHeadersWidth = 51;
            this.dataGridViewRoom.RowTemplate.Height = 24;
            this.dataGridViewRoom.Size = new System.Drawing.Size(815, 545);
            this.dataGridViewRoom.TabIndex = 0;
            this.dataGridViewRoom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellDoubleClick);
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
            this.groupBoxFilter.TabIndex = 1;
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
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
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
            // buttonAddRoom
            // 
            this.buttonAddRoom.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRoom.Location = new System.Drawing.Point(854, 426);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(196, 61);
            this.buttonAddRoom.TabIndex = 4;
            this.buttonAddRoom.Text = "Add New Room";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(854, 505);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(196, 61);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(873, 237);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(167, 156);
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 578);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.dataGridViewRoom);
            this.Name = "RoomManagement";
            this.Text = "RoomManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonOccupied;
        private System.Windows.Forms.RadioButton radioButtonAvailable;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}