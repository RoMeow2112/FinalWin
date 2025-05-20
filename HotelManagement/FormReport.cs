using HotelManagement.Models;
using HotelManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.EmployeeForms
{
    public partial class FormReport : Form
    {
        private readonly DB _db;
        private readonly ReportRepository _reportRepo;

        public FormReport()
        {
            InitializeComponent();

            _db = new DB();
            _reportRepo = new ReportRepository(_db);

            btnGenerateReport.Click += BtnGenerateReport_Click;
            dtpReportDate.ValueChanged += DtpReportDate_ValueChanged;

            this.Load += (s, e) => LoadReport(DateTime.Today);
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            LoadReport(dtpReportDate.Value.Date);
        }

        private void DtpReportDate_ValueChanged(object sender, EventArgs e)
        {
            LoadReport(dtpReportDate.Value.Date);
        }

        private void LoadReport(DateTime date)
        {
            ClearReport();

            var (totalDue, totalPaid) = _reportRepo.GetSalarySummary(date);

            lblTotalSalaryDue.Text = $"Total Salary Due: {totalDue:N0} VND";
            lblTotalSalaryPaid.Text = $"Total Salary Paid: {totalPaid:N0} VND";

            DisplayEmployeesByShift(_reportRepo.GetEmployeesByShift(date, "Morning"), flpMorning);
            DisplayEmployeesByShift(_reportRepo.GetEmployeesByShift(date, "Evening"), flpEvening);
            DisplayEmployeesByShift(_reportRepo.GetEmployeesByShift(date, "Night"), flpNight);
        }

        private void ClearReport()
        {
            lblTotalSalaryDue.Text = "Total Salary Due:";
            lblTotalSalaryPaid.Text = "Total Salary Paid:";

            flpMorning.Controls.Clear();
            flpEvening.Controls.Clear();
            flpNight.Controls.Clear();
        }

        private void DisplayEmployeesByShift(List<SalaryReportItem> employees, FlowLayoutPanel flowPanel)
        {
            flowPanel.Controls.Clear();

            foreach (var emp in employees)
            {
                Label lbl = new Label()
                {
                    Text = emp.EmployeeName,
                    AutoSize = true,
                    Margin = new Padding(3)
                };
                flowPanel.Controls.Add(lbl);
            }
        }
    }
}
