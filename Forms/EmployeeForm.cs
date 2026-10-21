using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Utilities;

namespace EmployeeManagementSystem.Forms
{
    public partial class EmployeeForm : Form
    {
        private EmployeeManagementDataContext _db;
        private string _selectedEmployeeId = null;

        public EmployeeForm()
        {
            InitializeComponent();
            InitializeCustomEvents();
        }

        private void InitializeCustomEvents()
        {
            this.Load += EmployeeForm_Load;
            this.FormClosed += (s, e) => _db?.Dispose();

            // Button actions
            btnSave.Click += BtnSave_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += (s, e) => ResetEditor();
            btnOpenHistory.Click += BtnOpenHistory_Click;

            // Search and filter actions
            btnSearch.Click += (s, e) => PerformSearch();
            btnResetSearch.Click += (s, e) => ResetSearchFilters();
            txtSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; PerformSearch(); } };
            cboFilterDept.SelectedIndexChanged += (s, e) => PerformSearch();
            cboFilterStatus.SelectedIndexChanged += (s, e) => PerformSearch();

            // Grid interactions
            dgvEmployees.SelectionChanged += DgvEmployees_SelectionChanged;
            dgvEmployees.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) OpenEmploymentHistory(); };

            // Dynamic age preview on birthdate change
            dtpBirthDate.ValueChanged += (s, e) => UpdateLiveAgePreview();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Apply Visual Studio Purple Theme
                VsPurpleTheme.ApplyTheme(this);
                VsPurpleTheme.StyleHeaderPanel(pnlHeader, lblHeaderTitle, lblHeaderSubtitle);
                VsPurpleTheme.StyleCardPanel(pnlEditorCard);
                VsPurpleTheme.StyleCardPanel(pnlGridCard);
                VsPurpleTheme.StyleDataGridView(dgvEmployees);
                VsPurpleTheme.StyleStatusStrip(statusStrip1);

                VsPurpleTheme.StyleSuccessButton(btnSave, "💾");
                VsPurpleTheme.StylePrimaryButton(btnUpdate, "✏️");
                VsPurpleTheme.StyleDangerButton(btnDelete, "🗑️");
                VsPurpleTheme.StyleSecondaryButton(btnClear, "🧹");
                VsPurpleTheme.StylePrimaryButton(btnOpenHistory, "📜");
                VsPurpleTheme.StylePrimaryButton(btnSearch, "🔍");
                VsPurpleTheme.StyleSecondaryButton(btnResetSearch, "🔄");

                _db = new EmployeeManagementDataContext();

                LoadDepartments();
                LoadStatusDropdowns();
                ResetEditor();
                LoadEmployees();

                tsStatusLabel.Text = "Ready • Visual Studio Purple Employee Management";
            }
            catch (Exception ex)
            {
                DatabaseHelper.ShowErrorDialog(ex, "Initialization Error");
                tsStatusLabel.Text = "Error during form initialization.";
            }
        }

        private void LoadDepartments()
        {
            try
            {
                var departments = _db.Departments
                    .OrderBy(d => d.DepartmentName)
                    .Select(d => new { d.DepartmentId, d.DepartmentName })
                    .ToList();

                // Bind editor department dropdown
                cboDepartment.DisplayMember = "DepartmentName";
                cboDepartment.ValueMember = "DepartmentId";
                cboDepartment.DataSource = departments.ToList();
                cboDepartment.SelectedIndex = -1;

                // Bind filter department dropdown
                var filterList = new List<dynamic>
                {
                    new { DepartmentId = (int?)null, DepartmentName = "-- All Departments --" }
                };
                foreach (var dept in departments)
                {
                    filterList.Add(new { DepartmentId = (int?)dept.DepartmentId, dept.DepartmentName });
                }

                cboFilterDept.DisplayMember = "DepartmentName";
                cboFilterDept.ValueMember = "DepartmentId";
                cboFilterDept.DataSource = filterList;
                cboFilterDept.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                DatabaseHelper.ShowErrorDialog(ex, "Failed to Load Departments");
            }
        }

        private void LoadStatusDropdowns()
        {
            // Filter status dropdown
            cboFilterStatus.Items.Clear();
            cboFilterStatus.Items.Add("-- All Statuses --");
            cboFilterStatus.Items.Add("Active");
            cboFilterStatus.Items.Add("On Leave");
            cboFilterStatus.Items.Add("Resigned");
            cboFilterStatus.Items.Add("Terminated");
            cboFilterStatus.Items.Add("Retired");
            cboFilterStatus.SelectedIndex = 0;

            if (cboEmploymentStatus.Items.Count > 0 && cboEmploymentStatus.SelectedIndex == -1)
            {
                cboEmploymentStatus.SelectedIndex = 0; // default "Active"
            }
        }

        public void LoadEmployees(string search = null, int? departmentId = null, string status = null)
        {
            try
            {
                string searchTerm = string.IsNullOrWhiteSpace(search) ? null : search.Trim();
                string statusFilter = (status == "-- All Statuses --" || string.IsNullOrWhiteSpace(status)) ? null : status;

                // Call mapped stored procedure usp_Employee_Search
                var results = _db.Usp_Employee_Search(searchTerm, departmentId, statusFilter).ToList();

                dgvEmployees.DataSource = results;
                ConfigureGridColumns();

                lblRecordCount.Text = $"{results.Count} employee(s) found";
                tsStatusLabel.Text = $"Loaded {results.Count} employee records successfully.";

                // Restore selection if exists
                if (!string.IsNullOrEmpty(_selectedEmployeeId))
                {
                    SelectEmployeeInGrid(_selectedEmployeeId);
                }
            }
            catch (Exception ex)
            {
                DatabaseHelper.ShowErrorDialog(ex, "Search Failed");
                tsStatusLabel.Text = "Failed to load employee directory.";
            }
        }

        private void ConfigureGridColumns()
        {
            if (dgvEmployees.Columns.Count == 0) return;

            // Hide raw or redundant columns
            if (dgvEmployees.Columns["CreatedAt"] != null) dgvEmployees.Columns["CreatedAt"].Visible = false;
            if (dgvEmployees.Columns["UpdatedAt"] != null) dgvEmployees.Columns["UpdatedAt"].Visible = false;
            if (dgvEmployees.Columns["MiddleName"] != null) dgvEmployees.Columns["MiddleName"].Visible = false;
            if (dgvEmployees.Columns["FirstName"] != null) dgvEmployees.Columns["FirstName"].Visible = false;
            if (dgvEmployees.Columns["LastName"] != null) dgvEmployees.Columns["LastName"].Visible = false;
            if (dgvEmployees.Columns["DepartmentId"] != null) dgvEmployees.Columns["DepartmentId"].Visible = false;
            if (dgvEmployees.Columns["DepartmentCode"] != null) dgvEmployees.Columns["DepartmentCode"].Visible = false;

            // Set headers and formatting
            if (dgvEmployees.Columns["EmployeeId"] != null)
            {
                dgvEmployees.Columns["EmployeeId"].HeaderText = "Employee ID";
                dgvEmployees.Columns["EmployeeId"].Width = 110;
            }

            if (dgvEmployees.Columns["FullName"] != null)
            {
                dgvEmployees.Columns["FullName"].HeaderText = "Full Name";
                dgvEmployees.Columns["FullName"].Width = 160;
            }

            if (dgvEmployees.Columns["Age"] != null)
            {
                dgvEmployees.Columns["Age"].HeaderText = "Age";
                dgvEmployees.Columns["Age"].Width = 60;
                dgvEmployees.Columns["Age"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvEmployees.Columns["DepartmentName"] != null)
            {
                dgvEmployees.Columns["DepartmentName"].HeaderText = "Department";
                dgvEmployees.Columns["DepartmentName"].Width = 130;
            }

            if (dgvEmployees.Columns["JobTitle"] != null)
            {
                dgvEmployees.Columns["JobTitle"].HeaderText = "Job Title";
                dgvEmployees.Columns["JobTitle"].Width = 140;
            }

            if (dgvEmployees.Columns["EmploymentStatus"] != null)
            {
                dgvEmployees.Columns["EmploymentStatus"].HeaderText = "Status";
                dgvEmployees.Columns["EmploymentStatus"].Width = 95;
            }

            if (dgvEmployees.Columns["Salary"] != null)
            {
                dgvEmployees.Columns["Salary"].HeaderText = "Salary";
                dgvEmployees.Columns["Salary"].Width = 100;
                dgvEmployees.Columns["Salary"].DefaultCellStyle.Format = "N2";
                dgvEmployees.Columns["Salary"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvEmployees.Columns["HireDate"] != null)
            {
                dgvEmployees.Columns["HireDate"].HeaderText = "Hire Date";
                dgvEmployees.Columns["HireDate"].Width = 95;
                dgvEmployees.Columns["HireDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvEmployees.Columns["Email"] != null)
            {
                dgvEmployees.Columns["Email"].HeaderText = "Email";
                dgvEmployees.Columns["Email"].Width = 160;
            }
        }

        private void PerformSearch()
        {
            string search = txtSearch.Text;
            int? deptId = null;

            if (cboFilterDept.SelectedValue != null && cboFilterDept.SelectedValue is int id)
            {
                deptId = id;
            }

            string status = cboFilterStatus.SelectedItem?.ToString();
            LoadEmployees(search, deptId, status);
        }

        private void ResetSearchFilters()
        {
            txtSearch.Clear();
            cboFilterDept.SelectedIndex = 0;
            cboFilterStatus.SelectedIndex = 0;
            LoadEmployees();
        }

        private void DgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0) return;

            var row = dgvEmployees.SelectedRows[0];
            if (row.DataBoundItem is Usp_Employee_SearchResult emp)
            {
                PopulateEditor(emp);
            }
        }

        private void PopulateEditor(Usp_Employee_SearchResult emp)
        {
            if (emp == null) return;

            _selectedEmployeeId = emp.EmployeeId;
            txtEmployeeId.Text = emp.EmployeeId;
            txtFirstName.Text = emp.FirstName ?? string.Empty;
            txtMiddleName.Text = emp.MiddleName ?? string.Empty;
            txtLastName.Text = emp.LastName ?? string.Empty;

            if (!string.IsNullOrEmpty(emp.Sex) && cboSex.Items.Contains(emp.Sex))
            {
                cboSex.SelectedItem = emp.Sex;
            }
            else
            {
                cboSex.SelectedIndex = -1;
            }

            if (emp.BirthDate.HasValue)
            {
                dtpBirthDate.Value = emp.BirthDate.Value;
            }

            // Display dynamic view-computed Age
            txtAge.Text = emp.Age.HasValue ? emp.Age.Value.ToString() : string.Empty;

            txtEmail.Text = emp.Email ?? string.Empty;
            txtPhone.Text = emp.Phone ?? string.Empty;
            txtAddress.Text = emp.Address ?? string.Empty;

            if (emp.DepartmentId.HasValue)
            {
                cboDepartment.SelectedValue = emp.DepartmentId.Value;
            }
            else
            {
                cboDepartment.SelectedIndex = -1;
            }

            txtJobTitle.Text = emp.JobTitle ?? string.Empty;

            if (!string.IsNullOrEmpty(emp.EmploymentStatus) && cboEmploymentStatus.Items.Contains(emp.EmploymentStatus))
            {
                cboEmploymentStatus.SelectedItem = emp.EmploymentStatus;
            }
            else
            {
                cboEmploymentStatus.SelectedIndex = 0;
            }

            if (emp.HireDate.HasValue)
            {
                dtpHireDate.Value = emp.HireDate.Value;
            }

            numSalary.Value = emp.Salary.HasValue ? Math.Max(numSalary.Minimum, Math.Min(numSalary.Maximum, emp.Salary.Value)) : 0;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnOpenHistory.Enabled = true;
            btnSave.Enabled = false;

            errorProvider1.Clear();
            tsStatusLabel.Text = $"Selected employee: {emp.EmployeeId} - {emp.FullName}";
        }

        private void ResetEditor()
        {
            _selectedEmployeeId = null;
            txtEmployeeId.Text = "(Auto-generated: EMP-xxxxxx)";
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            cboSex.SelectedIndex = -1;
            dtpBirthDate.Value = new DateTime(1995, 1, 1);
            txtAge.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cboDepartment.SelectedIndex = -1;
            txtJobTitle.Clear();
            cboEmploymentStatus.SelectedIndex = 0; // "Active"
            dtpHireDate.Value = DateTime.Today;
            numSalary.Value = 25000.00m;

            UpdateLiveAgePreview();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnOpenHistory.Enabled = false;

            errorProvider1.Clear();
            dgvEmployees.ClearSelection();
            txtFirstName.Focus();
            tsStatusLabel.Text = "Form cleared. Ready for new employee entry.";
        }

        private void UpdateLiveAgePreview()
        {
            int calculatedAge = ValidationHelper.CalculateAge(dtpBirthDate.Value);
            txtAge.Text = calculatedAge.ToString();
        }

        private bool ValidateEmployeeInputs()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (!ValidationHelper.ValidateRequired(txtFirstName, errorProvider1, "First Name")) isValid = false;
            if (!ValidationHelper.ValidateRequired(txtLastName, errorProvider1, "Last Name")) isValid = false;
            if (!ValidationHelper.ValidateEmail(txtEmail, errorProvider1)) isValid = false;
            if (!ValidationHelper.ValidateRequired(txtJobTitle, errorProvider1, "Job Title")) isValid = false;

            if (cboEmploymentStatus.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboEmploymentStatus, "Please select an employment status.");
                isValid = false;
            }

            if (!ValidationHelper.ValidateHireDate(dtpHireDate, dtpBirthDate, errorProvider1)) isValid = false;

            if (numSalary.Value < 0)
            {
                errorProvider1.SetError(numSalary, "Salary must be greater than or equal to zero.");
                isValid = false;
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateEmployeeInputs())
            {
                MessageBox.Show("Please correct the highlighted validation errors before saving.", "Validation Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string firstName = txtFirstName.Text.Trim();
                string middleName = string.IsNullOrWhiteSpace(txtMiddleName.Text) ? null : txtMiddleName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string sex = cboSex.SelectedItem?.ToString();
                DateTime birthDate = dtpBirthDate.Value.Date;
                string email = txtEmail.Text.Trim();
                string phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text.Trim();
                string address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text.Trim();
                int? departmentId = cboDepartment.SelectedValue as int?;
                string jobTitle = txtJobTitle.Text.Trim();
                string status = cboEmploymentStatus.SelectedItem?.ToString() ?? "Active";
                DateTime hireDate = dtpHireDate.Value.Date;
                decimal salary = numSalary.Value;

                // EmployeeId is generated by the SQL Server sequence/default constraint.
                string newEmployeeId = null;

                // Call mapped stored procedure usp_Employee_Create with ref/OUTPUT parameter
                _db.Usp_Employee_Create(
                    firstName, middleName, lastName, sex, birthDate,
                    email, phone, address, departmentId, jobTitle, status,
                    hireDate, salary, ref newEmployeeId);

                _selectedEmployeeId = newEmployeeId;

                MessageBox.Show(
                    $"Employee created successfully!\nGenerated Employee ID: {newEmployeeId}",
                    "Employee Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadEmployees();
                SelectEmployeeInGrid(newEmployeeId);
            }
            catch (Exception ex)
            {
                DatabaseHelper.ShowErrorDialog(ex, "Create Employee Failed");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedEmployeeId))
            {
                MessageBox.Show("Please select an employee to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateEmployeeInputs())
            {
                MessageBox.Show("Please correct the highlighted validation errors before updating.", "Validation Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string employeeId = _selectedEmployeeId;
                string firstName = txtFirstName.Text.Trim();
                string middleName = string.IsNullOrWhiteSpace(txtMiddleName.Text) ? null : txtMiddleName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string sex = cboSex.SelectedItem?.ToString();
                DateTime birthDate = dtpBirthDate.Value.Date;
                string email = txtEmail.Text.Trim();
                string phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text.Trim();
                string address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text.Trim();
                int? departmentId = cboDepartment.SelectedValue as int?;
                string jobTitle = txtJobTitle.Text.Trim();
                string status = cboEmploymentStatus.SelectedItem?.ToString() ?? "Active";
                DateTime hireDate = dtpHireDate.Value.Date;
                decimal salary = numSalary.Value;

                // Call mapped stored procedure usp_Employee_Update
                _db.Usp_Employee_Update(
                    employeeId, firstName, middleName, lastName, sex,
                    birthDate, email, phone, address, departmentId, jobTitle,
                    status, hireDate, salary);

                MessageBox.Show($"Employee '{employeeId}' updated successfully.", "Update Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadEmployees();
                SelectEmployeeInGrid(employeeId);
            }
            catch (Exception ex)
            {
                DatabaseHelper.ShowErrorDialog(ex, "Update Employee Failed");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedEmployeeId))
            {
                MessageBox.Show("Please select an employee record to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string empId = _selectedEmployeeId;
            string fullName = $"{txtFirstName.Text} {txtLastName.Text}".Trim();

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete employee '{empId}' ({fullName})?\n\nWarning: Associated employment history records will also be removed following foreign key cascade policy.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Call mapped stored procedure usp_Employee_Delete
                    _db.Usp_Employee_Delete(empId);

                    MessageBox.Show($"Employee '{empId}' was deleted successfully.", "Employee Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _selectedEmployeeId = null;
                    ResetEditor();
                    LoadEmployees();
                }
                catch (Exception ex)
                {
                    DatabaseHelper.ShowErrorDialog(ex, "Delete Employee Failed");
                }
            }
        }

        private void BtnOpenHistory_Click(object sender, EventArgs e)
        {
            OpenEmploymentHistory();
        }

        private void OpenEmploymentHistory()
        {
            if (string.IsNullOrEmpty(_selectedEmployeeId))
            {
                MessageBox.Show("Please select an employee first to view employment history.", "Select Employee",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string fullName = $"{txtFirstName.Text} {txtLastName.Text}".Trim();
            string deptName = cboDepartment.Text;
            string jobTitle = txtJobTitle.Text;

            using (var historyForm = new EmploymentHistoryForm(_selectedEmployeeId, fullName, deptName, jobTitle))
            {
                historyForm.ShowDialog(this);
            }
        }

        private void SelectEmployeeInGrid(string employeeId)
        {
            if (string.IsNullOrEmpty(employeeId)) return;

            foreach (DataGridViewRow row in dgvEmployees.Rows)
            {
                if (row.DataBoundItem is Usp_Employee_SearchResult emp && emp.EmployeeId == employeeId)
                {
                    row.Selected = true;
                    dgvEmployees.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }
    }
}
