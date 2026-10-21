using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Utilities;

namespace EmployeeManagementSystem.Forms
{
    public partial class EmploymentHistoryForm : Form
    {
        private readonly string _employeeId;
        private readonly string _employeeName;
        private readonly string _departmentName;
        private readonly string _currentJobTitle;
        private EmployeeManagementDataContext _db;
        private long? _selectedHistoryId = null;

        public EmploymentHistoryForm(string employeeId, string employeeName = "", string departmentName = "", string currentJobTitle = "")
        {
            InitializeComponent();
            _employeeId = employeeId;
            _employeeName = employeeName;
            _departmentName = departmentName;
            _currentJobTitle = currentJobTitle;

            InitializeCustomEvents();
        }

        private void InitializeCustomEvents()
        {
            this.Load += EmploymentHistoryForm_Load;
            this.FormClosed += (s, e) => _db?.Dispose();

            // Button actions
            btnSave.Click += BtnSave_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += (s, e) => ResetEditor();

            // Checkbox event
            chkCurrentJob.CheckedChanged += ChkCurrentJob_CheckedChanged;

            // Grid events
            dgvHistory.SelectionChanged += DgvHistory_SelectionChanged;
            dgvHistory.CellFormatting += DgvHistory_CellFormatting;
        }

        private void EmploymentHistoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Apply Visual Studio Purple Theme
                VsPurpleTheme.ApplyTheme(this);
                VsPurpleTheme.StyleHeaderPanel(pnlHeader, lblHeaderTitle, lblHeaderSubtitle);
                VsPurpleTheme.StyleCardPanel(pnlEditorCard);
                VsPurpleTheme.StyleCardPanel(pnlGridCard);
                VsPurpleTheme.StyleDataGridView(dgvHistory);
                VsPurpleTheme.StyleStatusStrip(statusStrip1);

                VsPurpleTheme.StyleSuccessButton(btnSave, "💾");
                VsPurpleTheme.StylePrimaryButton(btnUpdate, "✏️");
                VsPurpleTheme.StyleDangerButton(btnDelete, "🗑️");
                VsPurpleTheme.StyleSecondaryButton(btnClear, "🧹");

                _db = new EmployeeManagementDataContext();

                txtEmployeeBanner.Text = $"{_employeeId} - {_employeeName} ({_currentJobTitle} | {_departmentName})";

                ResetEditor();
                LoadHistory();

                tsStatusLabel.Text = $"Ready • Employment records for {_employeeId}";
            }
            catch (Exception ex)
            {
                DatabaseHelper.ShowErrorDialog(ex, "Initialization Error");
            }
        }

        private void ChkCurrentJob_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.Enabled = !chkCurrentJob.Checked;
            if (chkCurrentJob.Checked)
            {
                errorProvider1.SetError(dtpEndDate, string.Empty);
            }
        }

        private void LoadHistory()
        {
            try
            {
                // Call mapped stored procedure usp_EmployeeHistory_ReadByEmployee
                var historyRecords = _db.Usp_EmployeeHistory_ReadByEmployee(_employeeId).ToList();

                dgvHistory.DataSource = historyRecords;
                ConfigureGridColumns();

                lblHistoryCount.Text = $"{historyRecords.Count} record(s)";
                tsStatusLabel.Text = $"Loaded {historyRecords.Count} history record(s).";

                if (_selectedHistoryId.HasValue)
                {
                    SelectHistoryInGrid(_selectedHistoryId.Value);
                }
            }
            catch (Exception ex)
            {
                DatabaseHelper.ShowErrorDialog(ex, "Failed to Load History");
            }
        }

        private void ConfigureGridColumns()
        {
            if (dgvHistory.Columns.Count == 0) return;

            // Hide raw columns
            if (dgvHistory.Columns["EmployeeId"] != null) dgvHistory.Columns["EmployeeId"].Visible = false;
            if (dgvHistory.Columns["CreatedAt"] != null) dgvHistory.Columns["CreatedAt"].Visible = false;

            if (dgvHistory.Columns["HistoryId"] != null)
            {
                dgvHistory.Columns["HistoryId"].HeaderText = "ID";
                dgvHistory.Columns["HistoryId"].Width = 60;
            }

            if (dgvHistory.Columns["CompanyName"] != null)
            {
                dgvHistory.Columns["CompanyName"].HeaderText = "Company";
                dgvHistory.Columns["CompanyName"].Width = 140;
            }

            if (dgvHistory.Columns["JobTitle"] != null)
            {
                dgvHistory.Columns["JobTitle"].HeaderText = "Position / Job Title";
                dgvHistory.Columns["JobTitle"].Width = 130;
            }

            if (dgvHistory.Columns["EmploymentType"] != null)
            {
                dgvHistory.Columns["EmploymentType"].HeaderText = "Type";
                dgvHistory.Columns["EmploymentType"].Width = 90;
            }

            if (dgvHistory.Columns["StartDate"] != null)
            {
                dgvHistory.Columns["StartDate"].HeaderText = "Start Date";
                dgvHistory.Columns["StartDate"].Width = 85;
                dgvHistory.Columns["StartDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvHistory.Columns["EndDate"] != null)
            {
                dgvHistory.Columns["EndDate"].HeaderText = "End Date";
                dgvHistory.Columns["EndDate"].Width = 95;
            }

            if (dgvHistory.Columns["ReasonForLeaving"] != null)
            {
                dgvHistory.Columns["ReasonForLeaving"].HeaderText = "Leaving Reason";
                dgvHistory.Columns["ReasonForLeaving"].Width = 130;
            }

            if (dgvHistory.Columns["Notes"] != null)
            {
                dgvHistory.Columns["Notes"].HeaderText = "Notes";
                dgvHistory.Columns["Notes"].Width = 150;
            }
        }

        private void DgvHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHistory.Columns[e.ColumnIndex].Name == "EndDate")
            {
                if (e.Value == null || e.Value == DBNull.Value)
                {
                    e.Value = "Current / Present";
                    e.CellStyle.ForeColor = VsPurpleTheme.SuccessGreen;
                    e.CellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Italic);
                    e.FormattingApplied = true;
                }
                else if (e.Value is DateTime dt)
                {
                    e.Value = dt.ToString("yyyy-MM-dd");
                    e.FormattingApplied = true;
                }
            }
        }

        private void DgvHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count == 0) return;

            var row = dgvHistory.SelectedRows[0];
            if (row.DataBoundItem is Usp_EmployeeHistory_ReadByEmployeeResult item)
            {
                PopulateEditor(item);
            }
        }

        private void PopulateEditor(Usp_EmployeeHistory_ReadByEmployeeResult item)
        {
            if (item == null) return;

            _selectedHistoryId = item.HistoryId;
            txtHistoryId.Text = item.HistoryId.ToString();
            txtCompanyName.Text = item.CompanyName ?? string.Empty;
            txtJobTitle.Text = item.JobTitle ?? string.Empty;

            if (!string.IsNullOrEmpty(item.EmploymentType) && cboEmploymentType.Items.Contains(item.EmploymentType))
            {
                cboEmploymentType.SelectedItem = item.EmploymentType;
            }
            else
            {
                cboEmploymentType.SelectedIndex = 0;
            }

            dtpStartDate.Value = item.StartDate ?? DateTime.Today;

            if (item.EndDate.HasValue)
            {
                chkCurrentJob.Checked = false;
                dtpEndDate.Enabled = true;
                dtpEndDate.Value = item.EndDate.Value;
            }
            else
            {
                chkCurrentJob.Checked = true;
                dtpEndDate.Enabled = false;
            }

            txtReason.Text = item.ReasonForLeaving ?? string.Empty;
            txtNotes.Text = item.Notes ?? string.Empty;

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            errorProvider1.Clear();
            tsStatusLabel.Text = $"Selected record ID: {item.HistoryId} at {item.CompanyName}";
        }

        private void ResetEditor()
        {
            _selectedHistoryId = null;
            txtHistoryId.Text = "(New Record)";
            txtCompanyName.Clear();
            txtJobTitle.Clear();
            cboEmploymentType.SelectedIndex = 0; // "Permanent"
            dtpStartDate.Value = DateTime.Today.AddYears(-2);
            dtpEndDate.Value = DateTime.Today;
            chkCurrentJob.Checked = false;
            dtpEndDate.Enabled = true;
            txtReason.Clear();
            txtNotes.Clear();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            errorProvider1.Clear();
            dgvHistory.ClearSelection();
            txtCompanyName.Focus();
            tsStatusLabel.Text = "Form ready for new history entry.";
        }

        private bool ValidateHistoryInputs()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (!ValidationHelper.ValidateRequired(txtCompanyName, errorProvider1, "Company Name")) isValid = false;
            if (!ValidationHelper.ValidateRequired(txtJobTitle, errorProvider1, "Job Title")) isValid = false;

            if (cboEmploymentType.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboEmploymentType, "Please select an employment type.");
                isValid = false;
            }

            if (!ValidationHelper.ValidateHistoryDates(dtpStartDate, dtpEndDate, chkCurrentJob.Checked, errorProvider1))
            {
                isValid = false;
            }

            return isValid;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateHistoryInputs())
            {
                MessageBox.Show("Please correct the highlighted validation errors before saving.", "Validation Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string company = txtCompanyName.Text.Trim();
                string jobTitle = txtJobTitle.Text.Trim();
                string type = cboEmploymentType.SelectedItem?.ToString() ?? "Permanent";
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime? endDate = chkCurrentJob.Checked ? (DateTime?)null : dtpEndDate.Value.Date;
                string reason = string.IsNullOrWhiteSpace(txtReason.Text) ? null : txtReason.Text.Trim();
                string notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim();

                // Call mapped stored procedure usp_EmployeeHistory_Create
                var result = _db.Usp_EmployeeHistory_Create(
                    _employeeId, company, jobTitle, type,
                    startDate, endDate, reason, notes).FirstOrDefault();

                MessageBox.Show("Employment record added successfully!", "Record Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _selectedHistoryId = result?.HistoryId;
                LoadHistory();
            }
            catch (Exception ex)
            {
                DatabaseHelper.ShowErrorDialog(ex, "Create History Failed");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!_selectedHistoryId.HasValue)
            {
                MessageBox.Show("Please select an employment record to update.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateHistoryInputs())
            {
                MessageBox.Show("Please correct the highlighted validation errors before updating.", "Validation Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                long historyId = _selectedHistoryId.Value;
                string company = txtCompanyName.Text.Trim();
                string jobTitle = txtJobTitle.Text.Trim();
                string type = cboEmploymentType.SelectedItem?.ToString() ?? "Permanent";
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime? endDate = chkCurrentJob.Checked ? (DateTime?)null : dtpEndDate.Value.Date;
                string reason = string.IsNullOrWhiteSpace(txtReason.Text) ? null : txtReason.Text.Trim();
                string notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim();

                // Call mapped stored procedure usp_EmployeeHistory_Update
                _db.Usp_EmployeeHistory_Update(
                    historyId, company, jobTitle, type,
                    startDate, endDate, reason, notes);

                MessageBox.Show("Employment record updated successfully.", "Update Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadHistory();
                SelectHistoryInGrid(historyId);
            }
            catch (Exception ex)
            {
                DatabaseHelper.ShowErrorDialog(ex, "Update History Failed");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!_selectedHistoryId.HasValue)
            {
                MessageBox.Show("Please select an employment record to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long historyId = _selectedHistoryId.Value;
            string company = txtCompanyName.Text.Trim();

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete this employment record for '{company}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Call mapped stored procedure usp_EmployeeHistory_Delete
                    _db.Usp_EmployeeHistory_Delete(historyId);

                    MessageBox.Show("Employment record deleted.", "Record Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _selectedHistoryId = null;
                    ResetEditor();
                    LoadHistory();
                }
                catch (Exception ex)
                {
                    DatabaseHelper.ShowErrorDialog(ex, "Delete History Failed");
                }
            }
        }

        private void SelectHistoryInGrid(long historyId)
        {
            foreach (DataGridViewRow row in dgvHistory.Rows)
            {
                if (row.DataBoundItem is Usp_EmployeeHistory_ReadByEmployeeResult item && item.HistoryId == historyId)
                {
                    row.Selected = true;
                    dgvHistory.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }
    }
}
