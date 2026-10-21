using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Utilities;

namespace EmployeeManagementSystem.Forms
{
    public partial class MainForm : Form
    {
        private EmployeeManagementDataContext _db;

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomEvents();
        }

        private void InitializeCustomEvents()
        {
            this.Load += MainForm_Load;
            this.FormClosed += (s, e) => _db?.Dispose();

            // Navigation
            btnNavEmployees.Click += (s, e) => OpenEmployeeDirectory();
            openEmployeeDirectoryToolStripMenuItem.Click += (s, e) => OpenEmployeeDirectory();

            btnNavHistory.Click += (s, e) => OpenEmploymentHistorySelector();
            openEmploymentHistoryToolStripMenuItem.Click += (s, e) => OpenEmploymentHistorySelector();

            btnRefresh.Click += (s, e) => RefreshDashboard();
            refreshDashboardToolStripMenuItem.Click += (s, e) => RefreshDashboard();

            databaseDiagnosticsToolStripMenuItem.Click += (s, e) => TestDatabaseDiagnostics();
            aboutToolStripMenuItem.Click += (s, e) => ShowAboutDialog();
            exitToolStripMenuItem.Click += (s, e) => Application.Exit();

            // Clock update
            timerClock.Tick += (s, e) => tsTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Apply Visual Studio Purple Theme
                VsPurpleTheme.ApplyTheme(this);
                VsPurpleTheme.StyleHeaderPanel(pnlTopHeader, lblHeaderTitle, lblHeaderSubtitle);
                VsPurpleTheme.StyleCardPanel(pnlMetricTotal);
                VsPurpleTheme.StyleCardPanel(pnlMetricActive);
                VsPurpleTheme.StyleCardPanel(pnlMetricDepartments);
                VsPurpleTheme.StyleCardPanel(pnlMetricAvgSalary);
                VsPurpleTheme.StyleCardPanel(pnlDeptSummaryCard);
                VsPurpleTheme.StyleDataGridView(dgvDeptStats);
                VsPurpleTheme.StyleStatusStrip(statusStrip1);

                VsPurpleTheme.StylePrimaryButton(btnNavEmployees, "👥");
                VsPurpleTheme.StylePrimaryButton(btnNavHistory, "📜");
                VsPurpleTheme.StyleSecondaryButton(btnRefresh, "🔄");

                _db = new EmployeeManagementDataContext();

                RefreshDashboard();
                tsDbStatus.Text = "Connected: .\\SQLEXPRESS • EmployeeManagementDB (LINQ to SQL)";
            }
            catch (Exception ex)
            {
                DatabaseHelper.ShowErrorDialog(ex, "Main Dashboard Initialization Error");
                tsDbStatus.Text = "SQL Server Connection Failed.";
            }
        }

        private void RefreshDashboard()
        {
            try
            {
                // Dispose previous context and instantiate fresh context for up-to-date data
                _db?.Dispose();
                _db = new EmployeeManagementDataContext();

                // Fetch lists in-memory so string evaluation and groupings are not restricted by SQL translation
                var allEmployees = _db.Employees.ToList();
                var allDepartments = _db.Departments.ToList();
                var directoryRows = _db.Vw_EmployeeDirectory.ToList();

                // Compute KPI metrics
                int totalEmployees = allEmployees.Count;
                int activeEmployees = allEmployees.Count(e => e.EmploymentStatus == "Active");
                int deptCount = allDepartments.Count;
                decimal avgSalary = allEmployees.Count > 0 ? allEmployees.Average(e => e.Salary) : 0m;

                lblMetricTotalVal.Text = totalEmployees.ToString("N0");
                lblMetricActiveVal.Text = activeEmployees.ToString("N0");
                lblMetricDeptVal.Text = deptCount.ToString("N0");
                lblMetricAvgSalaryVal.Text = $"PHP {avgSalary:N2}";

                // Group by department from dynamic directory view
                var deptSummary = directoryRows
                    .GroupBy(e => string.IsNullOrWhiteSpace(e.DepartmentName) ? "(Unassigned)" : e.DepartmentName)
                    .Select(g => new
                    {
                        DepartmentName = g.Key,
                        EmployeeCount = g.Count(),
                        AverageSalary = g.Any() ? g.Average(e => e.Salary) : 0m
                    })
                    .OrderByDescending(s => s.EmployeeCount)
                    .ToList();

                dgvDeptStats.DataSource = deptSummary;
                ConfigureDeptGridColumns();
            }
            catch (Exception ex)
            {
                DatabaseHelper.ShowErrorDialog(ex, "Failed to Refresh Dashboard");
            }
        }

        private void ConfigureDeptGridColumns()
        {
            if (dgvDeptStats.Columns.Count == 0) return;

            if (dgvDeptStats.Columns["DepartmentName"] != null)
            {
                dgvDeptStats.Columns["DepartmentName"].HeaderText = "Department Name";
                dgvDeptStats.Columns["DepartmentName"].Width = 250;
            }

            if (dgvDeptStats.Columns["EmployeeCount"] != null)
            {
                dgvDeptStats.Columns["EmployeeCount"].HeaderText = "Employee Count";
                dgvDeptStats.Columns["EmployeeCount"].Width = 140;
                dgvDeptStats.Columns["EmployeeCount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvDeptStats.Columns["AverageSalary"] != null)
            {
                dgvDeptStats.Columns["AverageSalary"].HeaderText = "Average Salary (PHP)";
                dgvDeptStats.Columns["AverageSalary"].Width = 180;
                dgvDeptStats.Columns["AverageSalary"].DefaultCellStyle.Format = "N2";
                dgvDeptStats.Columns["AverageSalary"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void OpenEmployeeDirectory()
        {
            using (var form = new EmployeeForm())
            {
                form.ShowDialog(this);
            }
            RefreshDashboard();
        }

        private void OpenEmploymentHistorySelector()
        {
            // Open EmployeeForm so the user can select an employee to view their career history
            MessageBox.Show(
                "Please select an employee from the directory and click 'View Employment History' to manage career records.",
                "Employment History Navigation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            OpenEmployeeDirectory();
        }

        private void TestDatabaseDiagnostics()
        {
            if (DatabaseHelper.TestConnection(out string message))
            {
                MessageBox.Show(
                    $"{message}\n\nServer: .\\SQLEXPRESS\nDatabase: EmployeeManagementDB\nIntegrated Security: True",
                    "Connection Test Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    $"Database Connection Test Failed:\n{message}",
                    "Connection Test Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ShowAboutDialog()
        {
            MessageBox.Show(
                "Employee Management System\n" +
                "Theme: Visual Studio Purple Edition (#5C2D91)\n" +
                "Architecture: C# Windows Forms (.NET Framework 4.8)\n" +
                "Data Tier: Microsoft SQL Server 2025/Express + LINQ to SQL (.dbml)\n" +
                "Features:\n" +
                " • Sequence-generated Employee ID (EMP-000001)\n" +
                " • View-computed dynamic age\n" +
                " • Full Employee and Employment History CRUDS\n" +
                " • Mapped Stored Procedures (No manual ADO.NET code)\n" +
                " • Input validation with ErrorProvider\n\n" +
                "DBMS Laboratory Activity",
                "About Employee Management System",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
