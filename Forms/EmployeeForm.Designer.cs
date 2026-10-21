namespace EmployeeManagementSystem.Forms
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pnlEditorCard = new System.Windows.Forms.Panel();
            this.lblEditorSection = new System.Windows.Forms.Label();
            this.pnlEditorControls = new System.Windows.Forms.Panel();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboEmploymentStatus = new System.Windows.Forms.ComboBox();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblSalary = new System.Windows.Forms.Label();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.pnlEditorButtons = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpenHistory = new System.Windows.Forms.Button();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.pnlSearchFilter = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilterDept = new System.Windows.Forms.Label();
            this.cboFilterDept = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlEditorCard.SuspendLayout();
            this.pnlEditorControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            this.pnlEditorButtons.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.pnlSearchFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1240, 68);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(22, 40);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(515, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Manage employee master records with automatic sequence IDs, view-based dynamic age, and LINQ to SQL";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 11);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(325, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Employee Directory & Records (CRUDS)";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 68);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMain.Size = new System.Drawing.Size(1240, 650);
            this.pnlMain.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(12, 12);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pnlEditorCard);
            this.splitContainer.Panel1MinSize = 420;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlGridCard);
            this.splitContainer.Size = new System.Drawing.Size(1216, 626);
            this.splitContainer.SplitterDistance = 450;
            this.splitContainer.SplitterWidth = 10;
            this.splitContainer.TabIndex = 0;
            // 
            // pnlEditorCard
            // 
            this.pnlEditorCard.Controls.Add(this.lblEditorSection);
            this.pnlEditorCard.Controls.Add(this.pnlEditorControls);
            this.pnlEditorCard.Controls.Add(this.pnlEditorButtons);
            this.pnlEditorCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditorCard.Location = new System.Drawing.Point(0, 0);
            this.pnlEditorCard.Name = "pnlEditorCard";
            this.pnlEditorCard.Size = new System.Drawing.Size(450, 626);
            this.pnlEditorCard.TabIndex = 0;
            // 
            // lblEditorSection
            // 
            this.lblEditorSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEditorSection.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblEditorSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblEditorSection.Location = new System.Drawing.Point(0, 0);
            this.lblEditorSection.Name = "lblEditorSection";
            this.lblEditorSection.Padding = new System.Windows.Forms.Padding(6, 4, 0, 8);
            this.lblEditorSection.Size = new System.Drawing.Size(450, 32);
            this.lblEditorSection.TabIndex = 0;
            this.lblEditorSection.Text = "Employee Details & Form Controls";
            // 
            // pnlEditorControls
            // 
            this.pnlEditorControls.AutoScroll = true;
            this.pnlEditorControls.Controls.Add(this.lblEmployeeId);
            this.pnlEditorControls.Controls.Add(this.txtEmployeeId);
            this.pnlEditorControls.Controls.Add(this.lblFirstName);
            this.pnlEditorControls.Controls.Add(this.txtFirstName);
            this.pnlEditorControls.Controls.Add(this.lblMiddleName);
            this.pnlEditorControls.Controls.Add(this.txtMiddleName);
            this.pnlEditorControls.Controls.Add(this.lblLastName);
            this.pnlEditorControls.Controls.Add(this.txtLastName);
            this.pnlEditorControls.Controls.Add(this.lblSex);
            this.pnlEditorControls.Controls.Add(this.cboSex);
            this.pnlEditorControls.Controls.Add(this.lblBirthDate);
            this.pnlEditorControls.Controls.Add(this.dtpBirthDate);
            this.pnlEditorControls.Controls.Add(this.lblAge);
            this.pnlEditorControls.Controls.Add(this.txtAge);
            this.pnlEditorControls.Controls.Add(this.lblEmail);
            this.pnlEditorControls.Controls.Add(this.txtEmail);
            this.pnlEditorControls.Controls.Add(this.lblPhone);
            this.pnlEditorControls.Controls.Add(this.txtPhone);
            this.pnlEditorControls.Controls.Add(this.lblAddress);
            this.pnlEditorControls.Controls.Add(this.txtAddress);
            this.pnlEditorControls.Controls.Add(this.lblDepartment);
            this.pnlEditorControls.Controls.Add(this.cboDepartment);
            this.pnlEditorControls.Controls.Add(this.lblJobTitle);
            this.pnlEditorControls.Controls.Add(this.txtJobTitle);
            this.pnlEditorControls.Controls.Add(this.lblStatus);
            this.pnlEditorControls.Controls.Add(this.cboEmploymentStatus);
            this.pnlEditorControls.Controls.Add(this.lblHireDate);
            this.pnlEditorControls.Controls.Add(this.dtpHireDate);
            this.pnlEditorControls.Controls.Add(this.lblSalary);
            this.pnlEditorControls.Controls.Add(this.numSalary);
            this.pnlEditorControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditorControls.Location = new System.Drawing.Point(0, 32);
            this.pnlEditorControls.Name = "pnlEditorControls";
            this.pnlEditorControls.Padding = new System.Windows.Forms.Padding(8, 0, 16, 0);
            this.pnlEditorControls.Size = new System.Drawing.Size(450, 498);
            this.pnlEditorControls.TabIndex = 1;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.Location = new System.Drawing.Point(10, 8);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(120, 20);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "Employee ID:";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.txtEmployeeId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtEmployeeId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtEmployeeId.Location = new System.Drawing.Point(135, 5);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeeId.Size = new System.Drawing.Size(275, 23);
            this.txtEmployeeId.TabIndex = 1;
            this.txtEmployeeId.Text = "(Auto-generated)";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(10, 38);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(120, 20);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name *:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(135, 35);
            this.txtFirstName.MaxLength = 60;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(275, 23);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Location = new System.Drawing.Point(10, 68);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(120, 20);
            this.lblMiddleName.TabIndex = 4;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMiddleName.Location = new System.Drawing.Point(135, 65);
            this.txtMiddleName.MaxLength = 60;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(275, 23);
            this.txtMiddleName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(10, 98);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(120, 20);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name *:";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(135, 95);
            this.txtLastName.MaxLength = 60;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(275, 23);
            this.txtLastName.TabIndex = 7;
            // 
            // lblSex
            // 
            this.lblSex.Location = new System.Drawing.Point(10, 128);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(120, 20);
            this.lblSex.TabIndex = 8;
            this.lblSex.Text = "Sex:";
            // 
            // cboSex
            // 
            this.cboSex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Prefer not to say"});
            this.cboSex.Location = new System.Drawing.Point(135, 125);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(275, 23);
            this.cboSex.TabIndex = 9;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Location = new System.Drawing.Point(10, 158);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(120, 20);
            this.lblBirthDate.TabIndex = 10;
            this.lblBirthDate.Text = "Birth Date *:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(135, 155);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(165, 23);
            this.dtpBirthDate.TabIndex = 11;
            this.dtpBirthDate.Value = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            // 
            // lblAge
            // 
            this.lblAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAge.Location = new System.Drawing.Point(305, 158);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 20);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtAge.Location = new System.Drawing.Point(345, 155);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(65, 23);
            this.txtAge.TabIndex = 13;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(10, 188);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(120, 20);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email Address *:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(135, 185);
            this.txtEmail.MaxLength = 150;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(10, 218);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(120, 20);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(135, 215);
            this.txtPhone.MaxLength = 30;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(275, 23);
            this.txtPhone.TabIndex = 17;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(10, 248);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(120, 20);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(135, 245);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(275, 23);
            this.txtAddress.TabIndex = 19;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(10, 278);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(120, 20);
            this.lblDepartment.TabIndex = 20;
            this.lblDepartment.Text = "Department:";
            // 
            // cboDepartment
            // 
            this.cboDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(135, 275);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(275, 23);
            this.cboDepartment.TabIndex = 21;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.Location = new System.Drawing.Point(10, 308);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(120, 20);
            this.lblJobTitle.TabIndex = 22;
            this.lblJobTitle.Text = "Job Title *:";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobTitle.Location = new System.Drawing.Point(135, 305);
            this.txtJobTitle.MaxLength = 100;
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(275, 23);
            this.txtJobTitle.TabIndex = 23;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(10, 338);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 20);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Status *:";
            // 
            // cboEmploymentStatus
            // 
            this.cboEmploymentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEmploymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmploymentStatus.FormattingEnabled = true;
            this.cboEmploymentStatus.Items.AddRange(new object[] {
            "Active",
            "On Leave",
            "Resigned",
            "Terminated",
            "Retired"});
            this.cboEmploymentStatus.Location = new System.Drawing.Point(135, 335);
            this.cboEmploymentStatus.Name = "cboEmploymentStatus";
            this.cboEmploymentStatus.Size = new System.Drawing.Size(275, 23);
            this.cboEmploymentStatus.TabIndex = 25;
            // 
            // lblHireDate
            // 
            this.lblHireDate.Location = new System.Drawing.Point(10, 368);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(120, 20);
            this.lblHireDate.TabIndex = 26;
            this.lblHireDate.Text = "Hire Date *:";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(135, 365);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(275, 23);
            this.dtpHireDate.TabIndex = 27;
            // 
            // lblSalary
            // 
            this.lblSalary.Location = new System.Drawing.Point(10, 398);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(120, 20);
            this.lblSalary.TabIndex = 28;
            this.lblSalary.Text = "Salary (PHP) *:";
            // 
            // numSalary
            // 
            this.numSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSalary.DecimalPlaces = 2;
            this.numSalary.Location = new System.Drawing.Point(135, 395);
            this.numSalary.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(275, 23);
            this.numSalary.TabIndex = 29;
            this.numSalary.ThousandsSeparator = true;
            // 
            // pnlEditorButtons
            // 
            this.pnlEditorButtons.Controls.Add(this.btnSave);
            this.pnlEditorButtons.Controls.Add(this.btnUpdate);
            this.pnlEditorButtons.Controls.Add(this.btnDelete);
            this.pnlEditorButtons.Controls.Add(this.btnClear);
            this.pnlEditorButtons.Controls.Add(this.btnOpenHistory);
            this.pnlEditorButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEditorButtons.Location = new System.Drawing.Point(0, 530);
            this.pnlEditorButtons.Name = "pnlEditorButtons";
            this.pnlEditorButtons.Padding = new System.Windows.Forms.Padding(4);
            this.pnlEditorButtons.Size = new System.Drawing.Size(450, 96);
            this.pnlEditorButtons.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(110, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(318, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnOpenHistory
            // 
            this.btnOpenHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenHistory.Location = new System.Drawing.Point(6, 48);
            this.btnOpenHistory.Name = "btnOpenHistory";
            this.btnOpenHistory.Size = new System.Drawing.Size(410, 38);
            this.btnOpenHistory.TabIndex = 4;
            this.btnOpenHistory.Text = "View Employment History";
            this.btnOpenHistory.UseVisualStyleBackColor = true;
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.Controls.Add(this.dgvEmployees);
            this.pnlGridCard.Controls.Add(this.pnlSearchFilter);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Location = new System.Drawing.Point(0, 0);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(756, 626);
            this.pnlGridCard.TabIndex = 0;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 80);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(756, 546);
            this.dgvEmployees.TabIndex = 1;
            // 
            // pnlSearchFilter
            // 
            this.pnlSearchFilter.Controls.Add(this.lblSearch);
            this.pnlSearchFilter.Controls.Add(this.txtSearch);
            this.pnlSearchFilter.Controls.Add(this.lblFilterDept);
            this.pnlSearchFilter.Controls.Add(this.cboFilterDept);
            this.pnlSearchFilter.Controls.Add(this.lblFilterStatus);
            this.pnlSearchFilter.Controls.Add(this.cboFilterStatus);
            this.pnlSearchFilter.Controls.Add(this.btnSearch);
            this.pnlSearchFilter.Controls.Add(this.btnResetSearch);
            this.pnlSearchFilter.Controls.Add(this.lblRecordCount);
            this.pnlSearchFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchFilter.Name = "pnlSearchFilter";
            this.pnlSearchFilter.Size = new System.Drawing.Size(756, 80);
            this.pnlSearchFilter.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(8, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search ID / Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // lblFilterDept
            // 
            this.lblFilterDept.AutoSize = true;
            this.lblFilterDept.Location = new System.Drawing.Point(180, 9);
            this.lblFilterDept.Name = "lblFilterDept";
            this.lblFilterDept.Size = new System.Drawing.Size(73, 15);
            this.lblFilterDept.TabIndex = 2;
            this.lblFilterDept.Text = "Department:";
            // 
            // cboFilterDept
            // 
            this.cboFilterDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterDept.FormattingEnabled = true;
            this.cboFilterDept.Location = new System.Drawing.Point(183, 28);
            this.cboFilterDept.Name = "cboFilterDept";
            this.cboFilterDept.Size = new System.Drawing.Size(145, 23);
            this.cboFilterDept.TabIndex = 3;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Location = new System.Drawing.Point(335, 9);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(42, 15);
            this.lblFilterStatus.TabIndex = 4;
            this.lblFilterStatus.Text = "Status:";
            // 
            // cboFilterStatus
            // 
            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Location = new System.Drawing.Point(338, 28);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(120, 23);
            this.cboFilterStatus.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(468, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.Location = new System.Drawing.Point(559, 25);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(80, 30);
            this.btnResetSearch.TabIndex = 7;
            this.btnResetSearch.Text = "Reset";
            this.btnResetSearch.UseVisualStyleBackColor = true;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblRecordCount.Location = new System.Drawing.Point(595, 54);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(150, 20);
            this.lblRecordCount.TabIndex = 8;
            this.lblRecordCount.Text = "0 employee(s) found";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 718);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1240, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.tsStatusLabel.Text = "Ready";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 740);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Directory - Visual Studio Purple";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlEditorCard.ResumeLayout(false);
            this.pnlEditorControls.ResumeLayout(false);
            this.pnlEditorControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            this.pnlEditorButtons.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.pnlSearchFilter.ResumeLayout(false);
            this.pnlSearchFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel pnlEditorCard;
        private System.Windows.Forms.Label lblEditorSection;
        private System.Windows.Forms.Panel pnlEditorControls;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboEmploymentStatus;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.Panel pnlEditorButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpenHistory;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel pnlSearchFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterDept;
        private System.Windows.Forms.ComboBox cboFilterDept;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnResetSearch;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
    }
}
