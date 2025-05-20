namespace HotelManagement.Employee
{
    partial class FormManager
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
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnCalam = new System.Windows.Forms.Button();
            this.btnLuong = new System.Windows.Forms.Button();
            this.panelNhanVien = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.panelHost = new System.Windows.Forms.Panel();
            this.panelLuong = new System.Windows.Forms.Panel();
            this.dtpSalaryDate = new System.Windows.Forms.DateTimePicker();
            this.btnSalaryTomorrow = new System.Windows.Forms.Button();
            this.btnSalaryYesterday = new System.Windows.Forms.Button();
            this.dgvSalaries = new System.Windows.Forms.DataGridView();
            this.panelCaLam = new System.Windows.Forms.Panel();
            this.dtpShiftDate = new System.Windows.Forms.DateTimePicker();
            this.dgvShifts = new System.Windows.Forms.DataGridView();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelHost.SuspendLayout();
            this.panelLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).BeginInit();
            this.panelCaLam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Location = new System.Drawing.Point(3, 3);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(102, 28);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnCalam
            // 
            this.btnCalam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalam.Location = new System.Drawing.Point(111, 3);
            this.btnCalam.Name = "btnCalam";
            this.btnCalam.Size = new System.Drawing.Size(102, 28);
            this.btnCalam.TabIndex = 1;
            this.btnCalam.Text = "Ca làm";
            this.btnCalam.UseVisualStyleBackColor = true;
            this.btnCalam.Click += new System.EventHandler(this.btnCalam_Click);
            // 
            // btnLuong
            // 
            this.btnLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuong.Location = new System.Drawing.Point(3, 37);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(102, 28);
            this.btnLuong.TabIndex = 2;
            this.btnLuong.Text = "Lương";
            this.btnLuong.UseVisualStyleBackColor = true;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // panelNhanVien
            // 
            this.panelNhanVien.Controls.Add(this.button1);
            this.panelNhanVien.Controls.Add(this.dgvEmployees);
            this.panelNhanVien.Controls.Add(this.btnEdit);
            this.panelNhanVien.Controls.Add(this.btnAdd);
            this.panelNhanVien.Controls.Add(this.btnDelete);
            this.panelNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhanVien.Location = new System.Drawing.Point(0, 0);
            this.panelNhanVien.Name = "panelNhanVien";
            this.panelNhanVien.Size = new System.Drawing.Size(788, 364);
            this.panelNhanVien.TabIndex = 3;
            this.panelNhanVien.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(123, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm ca";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 3);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(778, 313);
            this.dgvEmployees.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(339, 322);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 28);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(231, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(447, 322);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 28);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnCalam);
            this.panel1.Controls.Add(this.btnLuong);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 68);
            this.panel1.TabIndex = 9;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Location = new System.Drawing.Point(111, 37);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(102, 28);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // panelHost
            // 
            this.panelHost.Controls.Add(this.panelLuong);
            this.panelHost.Controls.Add(this.panelCaLam);
            this.panelHost.Controls.Add(this.panelNhanVien);
            this.panelHost.Location = new System.Drawing.Point(12, 86);
            this.panelHost.Name = "panelHost";
            this.panelHost.Size = new System.Drawing.Size(788, 364);
            this.panelHost.TabIndex = 10;
            // 
            // panelLuong
            // 
            this.panelLuong.Controls.Add(this.dtpSalaryDate);
            this.panelLuong.Controls.Add(this.btnSalaryTomorrow);
            this.panelLuong.Controls.Add(this.btnSalaryYesterday);
            this.panelLuong.Controls.Add(this.dgvSalaries);
            this.panelLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLuong.Location = new System.Drawing.Point(0, 0);
            this.panelLuong.Name = "panelLuong";
            this.panelLuong.Size = new System.Drawing.Size(788, 364);
            this.panelLuong.TabIndex = 7;
            this.panelLuong.Visible = false;
            // 
            // dtpSalaryDate
            // 
            this.dtpSalaryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalaryDate.Location = new System.Drawing.Point(335, 337);
            this.dtpSalaryDate.Name = "dtpSalaryDate";
            this.dtpSalaryDate.Size = new System.Drawing.Size(96, 20);
            this.dtpSalaryDate.TabIndex = 3;
            this.dtpSalaryDate.ValueChanged += new System.EventHandler(this.dtpSalaryDate_ValueChanged);
            // 
            // btnSalaryTomorrow
            // 
            this.btnSalaryTomorrow.Location = new System.Drawing.Point(437, 334);
            this.btnSalaryTomorrow.Name = "btnSalaryTomorrow";
            this.btnSalaryTomorrow.Size = new System.Drawing.Size(75, 23);
            this.btnSalaryTomorrow.TabIndex = 2;
            this.btnSalaryTomorrow.Text = "Tomorrow";
            this.btnSalaryTomorrow.UseVisualStyleBackColor = true;
            this.btnSalaryTomorrow.Click += new System.EventHandler(this.btnSalaryTomorrow_Click);
            // 
            // btnSalaryYesterday
            // 
            this.btnSalaryYesterday.Location = new System.Drawing.Point(254, 334);
            this.btnSalaryYesterday.Name = "btnSalaryYesterday";
            this.btnSalaryYesterday.Size = new System.Drawing.Size(75, 23);
            this.btnSalaryYesterday.TabIndex = 1;
            this.btnSalaryYesterday.Text = "Yesterday";
            this.btnSalaryYesterday.UseVisualStyleBackColor = true;
            this.btnSalaryYesterday.Click += new System.EventHandler(this.btnSalaryYesterday_Click);
            // 
            // dgvSalaries
            // 
            this.dgvSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaries.Location = new System.Drawing.Point(3, 3);
            this.dgvSalaries.Name = "dgvSalaries";
            this.dgvSalaries.Size = new System.Drawing.Size(778, 325);
            this.dgvSalaries.TabIndex = 0;
            this.dgvSalaries.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSalaries_CellValueChanged);
            this.dgvSalaries.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvSalaries_CurrentCellDirtyStateChanged);
            // 
            // panelCaLam
            // 
            this.panelCaLam.Controls.Add(this.dtpShiftDate);
            this.panelCaLam.Controls.Add(this.dgvShifts);
            this.panelCaLam.Controls.Add(this.btnYesterday);
            this.panelCaLam.Controls.Add(this.btnTomorrow);
            this.panelCaLam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCaLam.Location = new System.Drawing.Point(0, 0);
            this.panelCaLam.Name = "panelCaLam";
            this.panelCaLam.Size = new System.Drawing.Size(788, 364);
            this.panelCaLam.TabIndex = 7;
            this.panelCaLam.Visible = false;
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShiftDate.Location = new System.Drawing.Point(336, 325);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(105, 20);
            this.dtpShiftDate.TabIndex = 7;
            this.dtpShiftDate.ValueChanged += new System.EventHandler(this.dtpShiftDate_ValueChanged);
            // 
            // dgvShifts
            // 
            this.dgvShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShifts.Location = new System.Drawing.Point(3, 3);
            this.dgvShifts.Name = "dgvShifts";
            this.dgvShifts.Size = new System.Drawing.Size(778, 313);
            this.dgvShifts.TabIndex = 0;
            // 
            // btnYesterday
            // 
            this.btnYesterday.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnYesterday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesterday.ForeColor = System.Drawing.Color.White;
            this.btnYesterday.Location = new System.Drawing.Point(228, 322);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(102, 28);
            this.btnYesterday.TabIndex = 4;
            this.btnYesterday.Text = "Yesterday";
            this.btnYesterday.UseVisualStyleBackColor = false;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.BackColor = System.Drawing.Color.Red;
            this.btnTomorrow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomorrow.ForeColor = System.Drawing.Color.White;
            this.btnTomorrow.Location = new System.Drawing.Point(447, 322);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(102, 28);
            this.btnTomorrow.TabIndex = 6;
            this.btnTomorrow.Text = "Tomorrow";
            this.btnTomorrow.UseVisualStyleBackColor = false;
            this.btnTomorrow.Click += new System.EventHandler(this.btnTomorrow_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(219, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Quản lý";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(805, 462);
            this.Controls.Add(this.panelHost);
            this.Controls.Add(this.panel1);
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.panelNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelHost.ResumeLayout(false);
            this.panelLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).EndInit();
            this.panelCaLam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnCalam;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Panel panelNhanVien;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Panel panelHost;
        private System.Windows.Forms.Panel panelLuong;
        private System.Windows.Forms.DataGridView dgvSalaries;
        private System.Windows.Forms.Panel panelCaLam;
        private System.Windows.Forms.DataGridView dgvShifts;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.Button btnTomorrow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpShiftDate;
        private System.Windows.Forms.DateTimePicker dtpSalaryDate;
        private System.Windows.Forms.Button btnSalaryTomorrow;
        private System.Windows.Forms.Button btnSalaryYesterday;
        private System.Windows.Forms.Button button2;
    }
}