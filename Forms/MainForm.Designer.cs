namespace EmployeeManagementSystem.Forms
{
    partial class MainForm
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
            this.pnlTopHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEmployeeDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEmploymentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseDiagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlDeptSummaryCard = new System.Windows.Forms.Panel();
            this.dgvDeptStats = new System.Windows.Forms.DataGridView();
            this.pnlDeptHeader = new System.Windows.Forms.Panel();
            this.lblDeptStatsTitle = new System.Windows.Forms.Label();
            this.pnlMetricsRow = new System.Windows.Forms.Panel();
            this.pnlMetricAvgSalary = new System.Windows.Forms.Panel();
            this.lblMetricAvgSalaryVal = new System.Windows.Forms.Label();
            this.lblMetricAvgSalaryTitle = new System.Windows.Forms.Label();
            this.pnlMetricDepartments = new System.Windows.Forms.Panel();
            this.lblMetricDeptVal = new System.Windows.Forms.Label();
            this.lblMetricDeptTitle = new System.Windows.Forms.Label();
            this.pnlMetricActive = new System.Windows.Forms.Panel();
            this.lblMetricActiveVal = new System.Windows.Forms.Label();
            this.lblMetricActiveTitle = new System.Windows.Forms.Label();
            this.pnlMetricTotal = new System.Windows.Forms.Panel();
            this.lblMetricTotalVal = new System.Windows.Forms.Label();
            this.lblMetricTotalTitle = new System.Windows.Forms.Label();
            this.pnlNavBanner = new System.Windows.Forms.Panel();
            this.btnNavHistory = new System.Windows.Forms.Button();
            this.btnNavEmployees = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsDbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.pnlTopHeader.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlDeptSummaryCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptStats)).BeginInit();
            this.pnlDeptHeader.SuspendLayout();
            this.pnlMetricsRow.SuspendLayout();
            this.pnlMetricAvgSalary.SuspendLayout();
            this.pnlMetricDepartments.SuspendLayout();
            this.pnlMetricActive.SuspendLayout();
            this.pnlMetricTotal.SuspendLayout();
            this.pnlNavBanner.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopHeader
            // 
            this.pnlTopHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlTopHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(0, 24);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Size = new System.Drawing.Size(1080, 80);
            this.pnlTopHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(24, 46);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(588, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Enterprise WinForms (.NET 4.8) • Visual Studio Purple Edition • LINQ to SQL with Mapped Stored Procedures";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Location = new System.Drawing.Point(22, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(395, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Employee Management System (DBMS Lab)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEmployeeDirectoryToolStripMenuItem,
            this.openEmploymentHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.fileToolStripMenuItem.Text = "&Navigation";
            // 
            // openEmployeeDirectoryToolStripMenuItem
            // 
            this.openEmployeeDirectoryToolStripMenuItem.Name = "openEmployeeDirectoryToolStripMenuItem";
            this.openEmployeeDirectoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.openEmployeeDirectoryToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.openEmployeeDirectoryToolStripMenuItem.Text = "&Employee Directory (CRUDS)";
            // 
            // openEmploymentHistoryToolStripMenuItem
            // 
            this.openEmploymentHistoryToolStripMenuItem.Name = "openEmploymentHistoryToolStripMenuItem";
            this.openEmploymentHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.openEmploymentHistoryToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.openEmploymentHistoryToolStripMenuItem.Text = "Employment &History";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(259, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshDashboardToolStripMenuItem,
            this.databaseDiagnosticsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // refreshDashboardToolStripMenuItem
            // 
            this.refreshDashboardToolStripMenuItem.Name = "refreshDashboardToolStripMenuItem";
            this.refreshDashboardToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshDashboardToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.refreshDashboardToolStripMenuItem.Text = "&Refresh Dashboard";
            // 
            // databaseDiagnosticsToolStripMenuItem
            // 
            this.databaseDiagnosticsToolStripMenuItem.Name = "databaseDiagnosticsToolStripMenuItem";
            this.databaseDiagnosticsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.databaseDiagnosticsToolStripMenuItem.Text = "&Test DB Connection";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutToolStripMenuItem.Text = "&About System";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlDeptSummaryCard);
            this.pnlContent.Controls.Add(this.pnlMetricsRow);
            this.pnlContent.Controls.Add(this.pnlNavBanner);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 104);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(16);
            this.pnlContent.Size = new System.Drawing.Size(1080, 550);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlDeptSummaryCard
            // 
            this.pnlDeptSummaryCard.Controls.Add(this.dgvDeptStats);
            this.pnlDeptSummaryCard.Controls.Add(this.pnlDeptHeader);
            this.pnlDeptSummaryCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeptSummaryCard.Location = new System.Drawing.Point(16, 178);
            this.pnlDeptSummaryCard.Name = "pnlDeptSummaryCard";
            this.pnlDeptSummaryCard.Size = new System.Drawing.Size(1048, 356);
            this.pnlDeptSummaryCard.TabIndex = 2;
            // 
            // dgvDeptStats
            // 
            this.dgvDeptStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeptStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeptStats.Location = new System.Drawing.Point(0, 42);
            this.dgvDeptStats.Name = "dgvDeptStats";
            this.dgvDeptStats.ReadOnly = true;
            this.dgvDeptStats.Size = new System.Drawing.Size(1048, 314);
            this.dgvDeptStats.TabIndex = 1;
            // 
            // pnlDeptHeader
            // 
            this.pnlDeptHeader.Controls.Add(this.lblDeptStatsTitle);
            this.pnlDeptHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDeptHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlDeptHeader.Name = "pnlDeptHeader";
            this.pnlDeptHeader.Size = new System.Drawing.Size(1048, 42);
            this.pnlDeptHeader.TabIndex = 0;
            // 
            // lblDeptStatsTitle
            // 
            this.lblDeptStatsTitle.AutoSize = true;
            this.lblDeptStatsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblDeptStatsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblDeptStatsTitle.Location = new System.Drawing.Point(10, 10);
            this.lblDeptStatsTitle.Name = "lblDeptStatsTitle";
            this.lblDeptStatsTitle.Size = new System.Drawing.Size(434, 20);
            this.lblDeptStatsTitle.TabIndex = 0;
            this.lblDeptStatsTitle.Text = "Department Summary & Analytics (Aggregated from Directory View)";
            // 
            // pnlMetricsRow
            // 
            this.pnlMetricsRow.Controls.Add(this.pnlMetricAvgSalary);
            this.pnlMetricsRow.Controls.Add(this.pnlMetricDepartments);
            this.pnlMetricsRow.Controls.Add(this.pnlMetricActive);
            this.pnlMetricsRow.Controls.Add(this.pnlMetricTotal);
            this.pnlMetricsRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMetricsRow.Location = new System.Drawing.Point(16, 76);
            this.pnlMetricsRow.Name = "pnlMetricsRow";
            this.pnlMetricsRow.Padding = new System.Windows.Forms.Padding(0, 8, 0, 12);
            this.pnlMetricsRow.Size = new System.Drawing.Size(1048, 102);
            this.pnlMetricsRow.TabIndex = 1;
            // 
            // pnlMetricAvgSalary
            // 
            this.pnlMetricAvgSalary.Controls.Add(this.lblMetricAvgSalaryVal);
            this.pnlMetricAvgSalary.Controls.Add(this.lblMetricAvgSalaryTitle);
            this.pnlMetricAvgSalary.Location = new System.Drawing.Point(768, 6);
            this.pnlMetricAvgSalary.Name = "pnlMetricAvgSalary";
            this.pnlMetricAvgSalary.Padding = new System.Windows.Forms.Padding(8);
            this.pnlMetricAvgSalary.Size = new System.Drawing.Size(240, 80);
            this.pnlMetricAvgSalary.TabIndex = 3;
            // 
            // lblMetricAvgSalaryVal
            // 
            this.lblMetricAvgSalaryVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMetricAvgSalaryVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMetricAvgSalaryVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblMetricAvgSalaryVal.Location = new System.Drawing.Point(8, 28);
            this.lblMetricAvgSalaryVal.Name = "lblMetricAvgSalaryVal";
            this.lblMetricAvgSalaryVal.Size = new System.Drawing.Size(224, 44);
            this.lblMetricAvgSalaryVal.TabIndex = 1;
            this.lblMetricAvgSalaryVal.Text = "PHP 0.00";
            this.lblMetricAvgSalaryVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetricAvgSalaryTitle
            // 
            this.lblMetricAvgSalaryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMetricAvgSalaryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblMetricAvgSalaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(97)))), ((int)(((byte)(122)))));
            this.lblMetricAvgSalaryTitle.Location = new System.Drawing.Point(8, 8);
            this.lblMetricAvgSalaryTitle.Name = "lblMetricAvgSalaryTitle";
            this.lblMetricAvgSalaryTitle.Size = new System.Drawing.Size(224, 20);
            this.lblMetricAvgSalaryTitle.TabIndex = 0;
            this.lblMetricAvgSalaryTitle.Text = "Average Salary";
            this.lblMetricAvgSalaryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMetricDepartments
            // 
            this.pnlMetricDepartments.Controls.Add(this.lblMetricDeptVal);
            this.pnlMetricDepartments.Controls.Add(this.lblMetricDeptTitle);
            this.pnlMetricDepartments.Location = new System.Drawing.Point(512, 6);
            this.pnlMetricDepartments.Name = "pnlMetricDepartments";
            this.pnlMetricDepartments.Padding = new System.Windows.Forms.Padding(8);
            this.pnlMetricDepartments.Size = new System.Drawing.Size(240, 80);
            this.pnlMetricDepartments.TabIndex = 2;
            // 
            // lblMetricDeptVal
            // 
            this.lblMetricDeptVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMetricDeptVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMetricDeptVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblMetricDeptVal.Location = new System.Drawing.Point(8, 28);
            this.lblMetricDeptVal.Name = "lblMetricDeptVal";
            this.lblMetricDeptVal.Size = new System.Drawing.Size(224, 44);
            this.lblMetricDeptVal.TabIndex = 1;
            this.lblMetricDeptVal.Text = "0";
            this.lblMetricDeptVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetricDeptTitle
            // 
            this.lblMetricDeptTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMetricDeptTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblMetricDeptTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(97)))), ((int)(((byte)(122)))));
            this.lblMetricDeptTitle.Location = new System.Drawing.Point(8, 8);
            this.lblMetricDeptTitle.Name = "lblMetricDeptTitle";
            this.lblMetricDeptTitle.Size = new System.Drawing.Size(224, 20);
            this.lblMetricDeptTitle.TabIndex = 0;
            this.lblMetricDeptTitle.Text = "Departments";
            this.lblMetricDeptTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMetricActive
            // 
            this.pnlMetricActive.Controls.Add(this.lblMetricActiveVal);
            this.pnlMetricActive.Controls.Add(this.lblMetricActiveTitle);
            this.pnlMetricActive.Location = new System.Drawing.Point(256, 6);
            this.pnlMetricActive.Name = "pnlMetricActive";
            this.pnlMetricActive.Padding = new System.Windows.Forms.Padding(8);
            this.pnlMetricActive.Size = new System.Drawing.Size(240, 80);
            this.pnlMetricActive.TabIndex = 1;
            // 
            // lblMetricActiveVal
            // 
            this.lblMetricActiveVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMetricActiveVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMetricActiveVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblMetricActiveVal.Location = new System.Drawing.Point(8, 28);
            this.lblMetricActiveVal.Name = "lblMetricActiveVal";
            this.lblMetricActiveVal.Size = new System.Drawing.Size(224, 44);
            this.lblMetricActiveVal.TabIndex = 1;
            this.lblMetricActiveVal.Text = "0";
            this.lblMetricActiveVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetricActiveTitle
            // 
            this.lblMetricActiveTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMetricActiveTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblMetricActiveTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(97)))), ((int)(((byte)(122)))));
            this.lblMetricActiveTitle.Location = new System.Drawing.Point(8, 8);
            this.lblMetricActiveTitle.Name = "lblMetricActiveTitle";
            this.lblMetricActiveTitle.Size = new System.Drawing.Size(224, 20);
            this.lblMetricActiveTitle.TabIndex = 0;
            this.lblMetricActiveTitle.Text = "Active Employees";
            this.lblMetricActiveTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMetricTotal
            // 
            this.pnlMetricTotal.Controls.Add(this.lblMetricTotalVal);
            this.pnlMetricTotal.Controls.Add(this.lblMetricTotalTitle);
            this.pnlMetricTotal.Location = new System.Drawing.Point(0, 6);
            this.pnlMetricTotal.Name = "pnlMetricTotal";
            this.pnlMetricTotal.Padding = new System.Windows.Forms.Padding(8);
            this.pnlMetricTotal.Size = new System.Drawing.Size(240, 80);
            this.pnlMetricTotal.TabIndex = 0;
            // 
            // lblMetricTotalVal
            // 
            this.lblMetricTotalVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMetricTotalVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMetricTotalVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.lblMetricTotalVal.Location = new System.Drawing.Point(8, 28);
            this.lblMetricTotalVal.Name = "lblMetricTotalVal";
            this.lblMetricTotalVal.Size = new System.Drawing.Size(224, 44);
            this.lblMetricTotalVal.TabIndex = 1;
            this.lblMetricTotalVal.Text = "0";
            this.lblMetricTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetricTotalTitle
            // 
            this.lblMetricTotalTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMetricTotalTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblMetricTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(97)))), ((int)(((byte)(122)))));
            this.lblMetricTotalTitle.Location = new System.Drawing.Point(8, 8);
            this.lblMetricTotalTitle.Name = "lblMetricTotalTitle";
            this.lblMetricTotalTitle.Size = new System.Drawing.Size(224, 20);
            this.lblMetricTotalTitle.TabIndex = 0;
            this.lblMetricTotalTitle.Text = "Total Employees";
            this.lblMetricTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNavBanner
            // 
            this.pnlNavBanner.Controls.Add(this.btnNavHistory);
            this.pnlNavBanner.Controls.Add(this.btnNavEmployees);
            this.pnlNavBanner.Controls.Add(this.btnRefresh);
            this.pnlNavBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavBanner.Location = new System.Drawing.Point(16, 16);
            this.pnlNavBanner.Name = "pnlNavBanner";
            this.pnlNavBanner.Size = new System.Drawing.Size(1048, 60);
            this.pnlNavBanner.TabIndex = 0;
            // 
            // btnNavHistory
            // 
            this.btnNavHistory.Location = new System.Drawing.Point(232, 10);
            this.btnNavHistory.Name = "btnNavHistory";
            this.btnNavHistory.Size = new System.Drawing.Size(230, 40);
            this.btnNavHistory.TabIndex = 1;
            this.btnNavHistory.Text = "Employment History";
            this.btnNavHistory.UseVisualStyleBackColor = true;
            // 
            // btnNavEmployees
            // 
            this.btnNavEmployees.Location = new System.Drawing.Point(4, 10);
            this.btnNavEmployees.Name = "btnNavEmployees";
            this.btnNavEmployees.Size = new System.Drawing.Size(220, 40);
            this.btnNavEmployees.TabIndex = 0;
            this.btnNavEmployees.Text = "Employee Directory (CRUDS)";
            this.btnNavEmployees.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(920, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDbStatus,
            this.tsSeparator,
            this.tsTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1080, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsDbStatus
            // 
            this.tsDbStatus.Name = "tsDbStatus";
            this.tsDbStatus.Size = new System.Drawing.Size(130, 17);
            this.tsDbStatus.Text = "SQL Server: Connecting...";
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(895, 17);
            this.tsSeparator.Spring = true;
            // 
            // tsTime
            // 
            this.tsTime.Name = "tsTime";
            this.tsTime.Size = new System.Drawing.Size(40, 17);
            this.tsTime.Text = "00:00:00";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 676);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlTopHeader);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management System - Visual Studio Purple";
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlDeptSummaryCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptStats)).EndInit();
            this.pnlDeptHeader.ResumeLayout(false);
            this.pnlDeptHeader.PerformLayout();
            this.pnlMetricsRow.ResumeLayout(false);
            this.pnlMetricAvgSalary.ResumeLayout(false);
            this.pnlMetricDepartments.ResumeLayout(false);
            this.pnlMetricActive.ResumeLayout(false);
            this.pnlMetricTotal.ResumeLayout(false);
            this.pnlNavBanner.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openEmployeeDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openEmploymentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseDiagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlNavBanner;
        private System.Windows.Forms.Button btnNavEmployees;
        private System.Windows.Forms.Button btnNavHistory;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlMetricsRow;
        private System.Windows.Forms.Panel pnlMetricTotal;
        private System.Windows.Forms.Label lblMetricTotalVal;
        private System.Windows.Forms.Label lblMetricTotalTitle;
        private System.Windows.Forms.Panel pnlMetricActive;
        private System.Windows.Forms.Label lblMetricActiveVal;
        private System.Windows.Forms.Label lblMetricActiveTitle;
        private System.Windows.Forms.Panel pnlMetricDepartments;
        private System.Windows.Forms.Label lblMetricDeptVal;
        private System.Windows.Forms.Label lblMetricDeptTitle;
        private System.Windows.Forms.Panel pnlMetricAvgSalary;
        private System.Windows.Forms.Label lblMetricAvgSalaryVal;
        private System.Windows.Forms.Label lblMetricAvgSalaryTitle;
        private System.Windows.Forms.Panel pnlDeptSummaryCard;
        private System.Windows.Forms.Panel pnlDeptHeader;
        private System.Windows.Forms.Label lblDeptStatsTitle;
        private System.Windows.Forms.DataGridView dgvDeptStats;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsDbStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsSeparator;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.Timer timerClock;
    }
}
