namespace EmployeeManagementSystem.Forms
{
    partial class EmploymentHistoryForm
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
            this.lblEditorTitle = new System.Windows.Forms.Label();
            this.pnlEditorControls = new System.Windows.Forms.Panel();
            this.lblEmployeeInfo = new System.Windows.Forms.Label();
            this.txtEmployeeBanner = new System.Windows.Forms.TextBox();
            this.lblHistoryId = new System.Windows.Forms.Label();
            this.txtHistoryId = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblEmploymentType = new System.Windows.Forms.Label();
            this.cboEmploymentType = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.chkCurrentJob = new System.Windows.Forms.CheckBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pnlEditorButtons = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.pnlGridHeader = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.lblHistoryCount = new System.Windows.Forms.Label();
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
            this.pnlEditorButtons.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.pnlGridHeader.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1150, 68);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(22, 40);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(465, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Manage one-to-many employment career records filtered by employee ID";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 11);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(325, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Employment History Management";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 68);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMain.Size = new System.Drawing.Size(1150, 560);
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
            this.splitContainer.Panel1MinSize = 400;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlGridCard);
            this.splitContainer.Size = new System.Drawing.Size(1126, 536);
            this.splitContainer.SplitterDistance = 420;
            this.splitContainer.SplitterWidth = 10;
            this.splitContainer.TabIndex = 0;
            // 
            // pnlEditorCard
            // 
            this.pnlEditorCard.Controls.Add(this.lblEditorTitle);
            this.pnlEditorCard.Controls.Add(this.pnlEditorControls);
            this.pnlEditorCard.Controls.Add(this.pnlEditorButtons);
            this.pnlEditorCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditorCard.Location = new System.Drawing.Point(0, 0);
            this.pnlEditorCard.Name = "pnlEditorCard";
            this.pnlEditorCard.Size = new System.Drawing.Size(420, 536);
            this.pnlEditorCard.TabIndex = 0;
            // 
            // lblEditorTitle
            // 
            this.lblEditorTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEditorTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblEditorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblEditorTitle.Location = new System.Drawing.Point(0, 0);
            this.lblEditorTitle.Name = "lblEditorTitle";
            this.lblEditorTitle.Padding = new System.Windows.Forms.Padding(6, 4, 0, 8);
            this.lblEditorTitle.Size = new System.Drawing.Size(420, 32);
            this.lblEditorTitle.TabIndex = 0;
            this.lblEditorTitle.Text = "Employment Record Details";
            // 
            // pnlEditorControls
            // 
            this.pnlEditorControls.AutoScroll = true;
            this.pnlEditorControls.Controls.Add(this.lblEmployeeInfo);
            this.pnlEditorControls.Controls.Add(this.txtEmployeeBanner);
            this.pnlEditorControls.Controls.Add(this.lblHistoryId);
            this.pnlEditorControls.Controls.Add(this.txtHistoryId);
            this.pnlEditorControls.Controls.Add(this.lblCompanyName);
            this.pnlEditorControls.Controls.Add(this.txtCompanyName);
            this.pnlEditorControls.Controls.Add(this.lblJobTitle);
            this.pnlEditorControls.Controls.Add(this.txtJobTitle);
            this.pnlEditorControls.Controls.Add(this.lblEmploymentType);
            this.pnlEditorControls.Controls.Add(this.cboEmploymentType);
            this.pnlEditorControls.Controls.Add(this.lblStartDate);
            this.pnlEditorControls.Controls.Add(this.dtpStartDate);
            this.pnlEditorControls.Controls.Add(this.lblEndDate);
            this.pnlEditorControls.Controls.Add(this.dtpEndDate);
            this.pnlEditorControls.Controls.Add(this.chkCurrentJob);
            this.pnlEditorControls.Controls.Add(this.lblReason);
            this.pnlEditorControls.Controls.Add(this.txtReason);
            this.pnlEditorControls.Controls.Add(this.lblNotes);
            this.pnlEditorControls.Controls.Add(this.txtNotes);
            this.pnlEditorControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditorControls.Location = new System.Drawing.Point(0, 32);
            this.pnlEditorControls.Name = "pnlEditorControls";
            this.pnlEditorControls.Padding = new System.Windows.Forms.Padding(8, 0, 16, 0);
            this.pnlEditorControls.Size = new System.Drawing.Size(420, 448);
            this.pnlEditorControls.TabIndex = 1;
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.Location = new System.Drawing.Point(10, 8);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(120, 20);
            this.lblEmployeeInfo.TabIndex = 0;
            this.lblEmployeeInfo.Text = "Employee:";
            // 
            // txtEmployeeBanner
            // 
            this.txtEmployeeBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.txtEmployeeBanner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtEmployeeBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtEmployeeBanner.Location = new System.Drawing.Point(135, 5);
            this.txtEmployeeBanner.Name = "txtEmployeeBanner";
            this.txtEmployeeBanner.ReadOnly = true;
            this.txtEmployeeBanner.Size = new System.Drawing.Size(250, 23);
            this.txtEmployeeBanner.TabIndex = 1;
            // 
            // lblHistoryId
            // 
            this.lblHistoryId.Location = new System.Drawing.Point(10, 38);
            this.lblHistoryId.Name = "lblHistoryId";
            this.lblHistoryId.Size = new System.Drawing.Size(120, 20);
            this.lblHistoryId.TabIndex = 2;
            this.lblHistoryId.Text = "History ID:";
            // 
            // txtHistoryId
            // 
            this.txtHistoryId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHistoryId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.txtHistoryId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.txtHistoryId.Location = new System.Drawing.Point(135, 35);
            this.txtHistoryId.Name = "txtHistoryId";
            this.txtHistoryId.ReadOnly = true;
            this.txtHistoryId.Size = new System.Drawing.Size(250, 23);
            this.txtHistoryId.TabIndex = 3;
            this.txtHistoryId.Text = "(New Record)";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Location = new System.Drawing.Point(10, 68);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(120, 20);
            this.lblCompanyName.TabIndex = 4;
            this.lblCompanyName.Text = "Company *:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyName.Location = new System.Drawing.Point(135, 65);
            this.txtCompanyName.MaxLength = 150;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(250, 23);
            this.txtCompanyName.TabIndex = 5;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.Location = new System.Drawing.Point(10, 98);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(120, 20);
            this.lblJobTitle.TabIndex = 6;
            this.lblJobTitle.Text = "Job Title *:";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobTitle.Location = new System.Drawing.Point(135, 95);
            this.txtJobTitle.MaxLength = 100;
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(250, 23);
            this.txtJobTitle.TabIndex = 7;
            // 
            // lblEmploymentType
            // 
            this.lblEmploymentType.Location = new System.Drawing.Point(10, 128);
            this.lblEmploymentType.Name = "lblEmploymentType";
            this.lblEmploymentType.Size = new System.Drawing.Size(120, 20);
            this.lblEmploymentType.TabIndex = 8;
            this.lblEmploymentType.Text = "Type *:";
            // 
            // cboEmploymentType
            // 
            this.cboEmploymentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEmploymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmploymentType.FormattingEnabled = true;
            this.cboEmploymentType.Items.AddRange(new object[] {
            "Permanent",
            "Contractual",
            "Part-time",
            "Internship",
            "Temporary",
            "Volunteer"});
            this.cboEmploymentType.Location = new System.Drawing.Point(135, 125);
            this.cboEmploymentType.Name = "cboEmploymentType";
            this.cboEmploymentType.Size = new System.Drawing.Size(250, 23);
            this.cboEmploymentType.TabIndex = 9;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(10, 158);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(120, 20);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Start Date *:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(135, 155);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(250, 23);
            this.dtpStartDate.TabIndex = 11;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(10, 188);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(120, 20);
            this.lblEndDate.TabIndex = 12;
            this.lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(135, 185);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(250, 23);
            this.dtpEndDate.TabIndex = 13;
            // 
            // chkCurrentJob
            // 
            this.chkCurrentJob.AutoSize = true;
            this.chkCurrentJob.Location = new System.Drawing.Point(135, 214);
            this.chkCurrentJob.Name = "chkCurrentJob";
            this.chkCurrentJob.Size = new System.Drawing.Size(222, 19);
            this.chkCurrentJob.TabIndex = 14;
            this.chkCurrentJob.Text = "Currently Employed Here (No End Date)";
            this.chkCurrentJob.UseVisualStyleBackColor = true;
            // 
            // lblReason
            // 
            this.lblReason.Location = new System.Drawing.Point(10, 240);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(120, 20);
            this.lblReason.TabIndex = 15;
            this.lblReason.Text = "Leaving Reason:";
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.Location = new System.Drawing.Point(135, 237);
            this.txtReason.MaxLength = 255;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(250, 23);
            this.txtReason.TabIndex = 16;
            // 
            // lblNotes
            // 
            this.lblNotes.Location = new System.Drawing.Point(10, 270);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(120, 20);
            this.lblNotes.TabIndex = 17;
            this.lblNotes.Text = "Notes / Description:";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(135, 267);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(250, 80);
            this.txtNotes.TabIndex = 18;
            // 
            // pnlEditorButtons
            // 
            this.pnlEditorButtons.Controls.Add(this.btnSave);
            this.pnlEditorButtons.Controls.Add(this.btnUpdate);
            this.pnlEditorButtons.Controls.Add(this.btnDelete);
            this.pnlEditorButtons.Controls.Add(this.btnClear);
            this.pnlEditorButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEditorButtons.Location = new System.Drawing.Point(0, 480);
            this.pnlEditorButtons.Name = "pnlEditorButtons";
            this.pnlEditorButtons.Padding = new System.Windows.Forms.Padding(4);
            this.pnlEditorButtons.Size = new System.Drawing.Size(420, 56);
            this.pnlEditorButtons.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(104, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(202, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.Controls.Add(this.dgvHistory);
            this.pnlGridCard.Controls.Add(this.pnlGridHeader);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Location = new System.Drawing.Point(0, 0);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(696, 536);
            this.pnlGridCard.TabIndex = 0;
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 42);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.Size = new System.Drawing.Size(696, 494);
            this.dgvHistory.TabIndex = 1;
            // 
            // pnlGridHeader
            // 
            this.pnlGridHeader.Controls.Add(this.lblGridTitle);
            this.pnlGridHeader.Controls.Add(this.lblHistoryCount);
            this.pnlGridHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlGridHeader.Name = "pnlGridHeader";
            this.pnlGridHeader.Size = new System.Drawing.Size(696, 42);
            this.pnlGridHeader.TabIndex = 0;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblGridTitle.Location = new System.Drawing.Point(8, 11);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(188, 19);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Employment Records History";
            // 
            // lblHistoryCount
            // 
            this.lblHistoryCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHistoryCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblHistoryCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblHistoryCount.Location = new System.Drawing.Point(510, 11);
            this.lblHistoryCount.Name = "lblHistoryCount";
            this.lblHistoryCount.Size = new System.Drawing.Size(175, 20);
            this.lblHistoryCount.TabIndex = 1;
            this.lblHistoryCount.Text = "0 record(s)";
            this.lblHistoryCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1150, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.tsStatusLabel.Text = "Ready";
            // 
            // EmploymentHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "EmploymentHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employment History - Visual Studio Purple";
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
            this.pnlEditorButtons.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.pnlGridHeader.ResumeLayout(false);
            this.pnlGridHeader.PerformLayout();
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
        private System.Windows.Forms.Label lblEditorTitle;
        private System.Windows.Forms.Panel pnlEditorControls;
        private System.Windows.Forms.Label lblEmployeeInfo;
        private System.Windows.Forms.TextBox txtEmployeeBanner;
        private System.Windows.Forms.Label lblHistoryId;
        private System.Windows.Forms.TextBox txtHistoryId;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label lblEmploymentType;
        private System.Windows.Forms.ComboBox cboEmploymentType;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.CheckBox chkCurrentJob;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlEditorButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Panel pnlGridHeader;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Label lblHistoryCount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
    }
}
