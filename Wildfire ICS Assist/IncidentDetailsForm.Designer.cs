﻿namespace Wildfire_ICS_Assist
{
    partial class IncidentDetailsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncidentDetailsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dgvMembersOnTask = new System.Windows.Forms.DataGridView();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberSARGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSignInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberAssignmentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddAMember = new System.Windows.Forms.Button();
            this.btnBulkSignIn = new System.Windows.Forms.Button();
            this.btnMembersOnTaskNewWindow = new System.Windows.Forms.Button();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.dgvTaskEquipment = new System.Windows.Forms.DataGridView();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReferenceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipmentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAssignEquipment = new System.Windows.Forms.Button();
            this.btnViewEquipment = new System.Windows.Forms.Button();
            this.btnReturnEquipment = new System.Windows.Forms.Button();
            this.pnlOpsPeriod = new System.Windows.Forms.Panel();
            this.btnCloseOpPeriod = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.datOpsEnd = new System.Windows.Forms.DateTimePicker();
            this.datOpsStart = new System.Windows.Forms.DateTimePicker();
            this.numOpPeriod = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTaskInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtICPCallsign = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutstandingLogItems = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnViewPositionLog = new System.Windows.Forms.Button();
            this.btnAddToPositionLog = new System.Windows.Forms.Button();
            this.txtTaskNumber = new System.Windows.Forms.TextBox();
            this.btnICSRoleHelp = new System.Windows.Forms.Button();
            this.cboICSRole = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblTaskNumber = new System.Windows.Forms.Label();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.lblVersionNumber = new System.Windows.Forms.Label();
            this.tcStatus = new System.Windows.Forms.TabControl();
            this.tpMembersOnTask = new System.Windows.Forms.TabPage();
            this.tpEquipment = new System.Windows.Forms.TabPage();
            this.tpNetworkLog = new System.Windows.Forms.TabPage();
            this.txtNetworkLog = new System.Windows.Forms.TextBox();
            this.imglTabIcons = new System.Windows.Forms.ImageList(this.components);
            this.pnlInternetSyncStart = new System.Windows.Forms.Panel();
            this.btnCancelInternetSync = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlNetworkSyncInProgress = new System.Windows.Forms.Panel();
            this.lblNetworkShareMoreInfoMsg = new System.Windows.Forms.Label();
            this.btnNetworkSyncDone = new System.Windows.Forms.Button();
            this.pbNetworkSyncInProgress = new System.Windows.Forms.ProgressBar();
            this.btnCloseNetworkSyncInProgress = new System.Windows.Forms.Button();
            this.lblNetworkSyncStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentIncidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToIncidentFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.savedValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationsSystemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medivacServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentObjectivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safetyNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentActionPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentObjectivesICS202ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationsPlanICS205ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalPlanICS206ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationChartICS207ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safetyMessageICS208ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.additionalDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationsListICS205AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.logisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionLogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.planningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionLogToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.networkInternetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForTemplateUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForAppUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCIAPPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llProgramURL = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.svdTaskFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenTaskFile = new System.Windows.Forms.OpenFileDialog();
            this.fbdSaveLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.tmrAutoSave = new System.Windows.Forms.Timer(this.components);
            this.tmrPositionLogReminders = new System.Windows.Forms.Timer(this.components);
            this.tmrInternetSync = new System.Windows.Forms.Timer(this.components);
            this.tmrNetwork = new System.Windows.Forms.Timer(this.components);
            this.cpIncidentActionPlan = new Wildfire_ICS_Assist.CustomControls.CollapsiblePanel();
            this.btnBriefings2 = new System.Windows.Forms.Button();
            this.btnSafetyPlans = new System.Windows.Forms.Button();
            this.btnIncidentObjectives = new System.Windows.Forms.Button();
            this.btnMedicalPlan = new System.Windows.Forms.Button();
            this.btnPrintIAP = new System.Windows.Forms.Button();
            this.btnPrintOrgChart = new System.Windows.Forms.Button();
            this.btnCommsPlan = new System.Windows.Forms.Button();
            this.btnLogisticsBulkSignIn = new System.Windows.Forms.Button();
            this.btnLogisticsSignIn = new System.Windows.Forms.Button();
            this.btnLogisticsMemberStatus = new System.Windows.Forms.Button();
            this.btnAdditionalContacts = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnLogisticsDashboard = new System.Windows.Forms.Button();
            this.btnPlanningAddAssignment = new System.Windows.Forms.Button();
            this.btnTeamAssignments = new System.Windows.Forms.Button();
            this.btnTimeline = new System.Windows.Forms.Button();
            this.btnPlanningDashboard = new System.Windows.Forms.Button();
            this.cpPlanning = new Wildfire_ICS_Assist.CustomControls.CollapsiblePanel();
            this.btnNotes = new System.Windows.Forms.Button();
            this.cpLogistics = new Wildfire_ICS_Assist.CustomControls.CollapsiblePanel();
            this.cpOperations = new Wildfire_ICS_Assist.CustomControls.CollapsiblePanel();
            this.btnOpsAssignments = new System.Windows.Forms.Button();
            this.btnOpsMemberStatus = new System.Windows.Forms.Button();
            this.btnOpsDashboard = new System.Windows.Forms.Button();
            this.btnTeamStatus = new System.Windows.Forms.Button();
            this.btnCommsLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersOnTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskEquipment)).BeginInit();
            this.pnlOpsPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpPeriod)).BeginInit();
            this.pnlTaskInfo.SuspendLayout();
            this.tcStatus.SuspendLayout();
            this.tpMembersOnTask.SuspendLayout();
            this.tpEquipment.SuspendLayout();
            this.tpNetworkLog.SuspendLayout();
            this.pnlInternetSyncStart.SuspendLayout();
            this.pnlNetworkSyncInProgress.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cpIncidentActionPlan.SuspendLayout();
            this.cpPlanning.SuspendLayout();
            this.cpLogistics.SuspendLayout();
            this.cpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer4
            // 
            resources.ApplyResources(this.splitContainer4, "splitContainer4");
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dgvMembersOnTask);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnAddAMember);
            this.splitContainer4.Panel2.Controls.Add(this.btnBulkSignIn);
            this.splitContainer4.Panel2.Controls.Add(this.btnMembersOnTaskNewWindow);
            // 
            // dgvMembersOnTask
            // 
            this.dgvMembersOnTask.AllowUserToAddRows = false;
            this.dgvMembersOnTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembersOnTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberName,
            this.colMemberSARGroup,
            this.colSignInTime,
            this.colAssignmentNumber,
            this.colMemberAssignmentStatus});
            resources.ApplyResources(this.dgvMembersOnTask, "dgvMembersOnTask");
            this.dgvMembersOnTask.MultiSelect = false;
            this.dgvMembersOnTask.Name = "dgvMembersOnTask";
            this.dgvMembersOnTask.ReadOnly = true;
            this.dgvMembersOnTask.RowHeadersVisible = false;
            this.dgvMembersOnTask.RowTemplate.Height = 30;
            this.dgvMembersOnTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // colMemberName
            // 
            this.colMemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemberName.DataPropertyName = "MemberName";
            resources.ApplyResources(this.colMemberName, "colMemberName");
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.ReadOnly = true;
            // 
            // colMemberSARGroup
            // 
            this.colMemberSARGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMemberSARGroup.DataPropertyName = "OrganizationName";
            resources.ApplyResources(this.colMemberSARGroup, "colMemberSARGroup");
            this.colMemberSARGroup.Name = "colMemberSARGroup";
            this.colMemberSARGroup.ReadOnly = true;
            // 
            // colSignInTime
            // 
            this.colSignInTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSignInTime.DataPropertyName = "SignInTimeAsText";
            dataGridViewCellStyle1.Format = "HH:mm yyyy-MMM-dd";
            dataGridViewCellStyle1.NullValue = null;
            this.colSignInTime.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.colSignInTime, "colSignInTime");
            this.colSignInTime.Name = "colSignInTime";
            this.colSignInTime.ReadOnly = true;
            // 
            // colAssignmentNumber
            // 
            this.colAssignmentNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAssignmentNumber.DataPropertyName = "getCurrentActivityName";
            resources.ApplyResources(this.colAssignmentNumber, "colAssignmentNumber");
            this.colAssignmentNumber.Name = "colAssignmentNumber";
            this.colAssignmentNumber.ReadOnly = true;
            // 
            // colMemberAssignmentStatus
            // 
            this.colMemberAssignmentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMemberAssignmentStatus.DataPropertyName = "AssignmentStatus";
            resources.ApplyResources(this.colMemberAssignmentStatus, "colMemberAssignmentStatus");
            this.colMemberAssignmentStatus.Name = "colMemberAssignmentStatus";
            this.colMemberAssignmentStatus.ReadOnly = true;
            // 
            // btnAddAMember
            // 
            resources.ApplyResources(this.btnAddAMember, "btnAddAMember");
            this.btnAddAMember.Name = "btnAddAMember";
            this.btnAddAMember.UseVisualStyleBackColor = true;
            // 
            // btnBulkSignIn
            // 
            resources.ApplyResources(this.btnBulkSignIn, "btnBulkSignIn");
            this.btnBulkSignIn.Name = "btnBulkSignIn";
            this.btnBulkSignIn.UseVisualStyleBackColor = true;
            // 
            // btnMembersOnTaskNewWindow
            // 
            resources.ApplyResources(this.btnMembersOnTaskNewWindow, "btnMembersOnTaskNewWindow");
            this.btnMembersOnTaskNewWindow.Name = "btnMembersOnTaskNewWindow";
            this.btnMembersOnTaskNewWindow.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            resources.ApplyResources(this.splitContainer5, "splitContainer5");
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.dgvTaskEquipment);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.btnAssignEquipment);
            this.splitContainer5.Panel2.Controls.Add(this.btnViewEquipment);
            this.splitContainer5.Panel2.Controls.Add(this.btnReturnEquipment);
            // 
            // dgvTaskEquipment
            // 
            this.dgvTaskEquipment.AllowUserToAddRows = false;
            this.dgvTaskEquipment.AllowUserToDeleteRows = false;
            this.dgvTaskEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategory,
            this.colSubCategory,
            this.colName,
            this.colReferenceID,
            this.colEquipmentStatus,
            this.colAssignee});
            resources.ApplyResources(this.dgvTaskEquipment, "dgvTaskEquipment");
            this.dgvTaskEquipment.Name = "dgvTaskEquipment";
            this.dgvTaskEquipment.ReadOnly = true;
            this.dgvTaskEquipment.RowHeadersVisible = false;
            this.dgvTaskEquipment.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaskEquipment.RowTemplate.Height = 30;
            this.dgvTaskEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // colCategory
            // 
            this.colCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCategory.DataPropertyName = "ParentCategoryName";
            resources.ApplyResources(this.colCategory, "colCategory");
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colSubCategory
            // 
            this.colSubCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSubCategory.DataPropertyName = "CategoryName";
            resources.ApplyResources(this.colSubCategory, "colSubCategory");
            this.colSubCategory.Name = "colSubCategory";
            this.colSubCategory.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.DataPropertyName = "EquipmentName";
            resources.ApplyResources(this.colName, "colName");
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colReferenceID
            // 
            this.colReferenceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colReferenceID.DataPropertyName = "ReferenceID";
            resources.ApplyResources(this.colReferenceID, "colReferenceID");
            this.colReferenceID.Name = "colReferenceID";
            this.colReferenceID.ReadOnly = true;
            // 
            // colEquipmentStatus
            // 
            this.colEquipmentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEquipmentStatus.DataPropertyName = "StatusName";
            resources.ApplyResources(this.colEquipmentStatus, "colEquipmentStatus");
            this.colEquipmentStatus.Name = "colEquipmentStatus";
            this.colEquipmentStatus.ReadOnly = true;
            // 
            // colAssignee
            // 
            this.colAssignee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAssignee.DataPropertyName = "AssigneeName";
            resources.ApplyResources(this.colAssignee, "colAssignee");
            this.colAssignee.Name = "colAssignee";
            this.colAssignee.ReadOnly = true;
            // 
            // btnAssignEquipment
            // 
            resources.ApplyResources(this.btnAssignEquipment, "btnAssignEquipment");
            this.btnAssignEquipment.Name = "btnAssignEquipment";
            this.btnAssignEquipment.UseVisualStyleBackColor = true;
            // 
            // btnViewEquipment
            // 
            resources.ApplyResources(this.btnViewEquipment, "btnViewEquipment");
            this.btnViewEquipment.Name = "btnViewEquipment";
            this.btnViewEquipment.UseVisualStyleBackColor = true;
            // 
            // btnReturnEquipment
            // 
            resources.ApplyResources(this.btnReturnEquipment, "btnReturnEquipment");
            this.btnReturnEquipment.Name = "btnReturnEquipment";
            this.btnReturnEquipment.UseVisualStyleBackColor = true;
            // 
            // pnlOpsPeriod
            // 
            resources.ApplyResources(this.pnlOpsPeriod, "pnlOpsPeriod");
            this.pnlOpsPeriod.BackColor = System.Drawing.Color.White;
            this.pnlOpsPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpsPeriod.Controls.Add(this.btnCloseOpPeriod);
            this.pnlOpsPeriod.Controls.Add(this.label18);
            this.pnlOpsPeriod.Controls.Add(this.label15);
            this.pnlOpsPeriod.Controls.Add(this.datOpsEnd);
            this.pnlOpsPeriod.Controls.Add(this.datOpsStart);
            this.pnlOpsPeriod.Controls.Add(this.numOpPeriod);
            this.pnlOpsPeriod.Controls.Add(this.label1);
            this.pnlOpsPeriod.Name = "pnlOpsPeriod";
            // 
            // btnCloseOpPeriod
            // 
            resources.ApplyResources(this.btnCloseOpPeriod, "btnCloseOpPeriod");
            this.btnCloseOpPeriod.Name = "btnCloseOpPeriod";
            this.btnCloseOpPeriod.TabStop = false;
            this.btnCloseOpPeriod.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // datOpsEnd
            // 
            resources.ApplyResources(this.datOpsEnd, "datOpsEnd");
            this.datOpsEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datOpsEnd.Name = "datOpsEnd";
            // 
            // datOpsStart
            // 
            resources.ApplyResources(this.datOpsStart, "datOpsStart");
            this.datOpsStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datOpsStart.Name = "datOpsStart";
            // 
            // numOpPeriod
            // 
            resources.ApplyResources(this.numOpPeriod, "numOpPeriod");
            this.numOpPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOpPeriod.Name = "numOpPeriod";
            this.numOpPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pnlTaskInfo
            // 
            resources.ApplyResources(this.pnlTaskInfo, "pnlTaskInfo");
            this.pnlTaskInfo.BackColor = System.Drawing.Color.White;
            this.pnlTaskInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTaskInfo.Controls.Add(this.panel1);
            this.pnlTaskInfo.Controls.Add(this.txtICPCallsign);
            this.pnlTaskInfo.Controls.Add(this.label2);
            this.pnlTaskInfo.Controls.Add(this.btnOutstandingLogItems);
            this.pnlTaskInfo.Controls.Add(this.label19);
            this.pnlTaskInfo.Controls.Add(this.btnViewPositionLog);
            this.pnlTaskInfo.Controls.Add(this.btnAddToPositionLog);
            this.pnlTaskInfo.Controls.Add(this.txtTaskNumber);
            this.pnlTaskInfo.Controls.Add(this.btnICSRoleHelp);
            this.pnlTaskInfo.Controls.Add(this.cboICSRole);
            this.pnlTaskInfo.Controls.Add(this.label17);
            this.pnlTaskInfo.Controls.Add(this.label16);
            this.pnlTaskInfo.Controls.Add(this.txtTaskName);
            this.pnlTaskInfo.Controls.Add(this.lblTaskName);
            this.pnlTaskInfo.Controls.Add(this.lblTaskNumber);
            this.pnlTaskInfo.Name = "pnlTaskInfo";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Name = "panel1";
            // 
            // txtICPCallsign
            // 
            resources.ApplyResources(this.txtICPCallsign, "txtICPCallsign");
            this.txtICPCallsign.Name = "txtICPCallsign";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnOutstandingLogItems
            // 
            resources.ApplyResources(this.btnOutstandingLogItems, "btnOutstandingLogItems");
            this.btnOutstandingLogItems.Name = "btnOutstandingLogItems";
            this.btnOutstandingLogItems.TabStop = false;
            this.btnOutstandingLogItems.UseVisualStyleBackColor = true;
            this.btnOutstandingLogItems.Click += new System.EventHandler(this.btnOutstandingLogItems_Click);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // btnViewPositionLog
            // 
            resources.ApplyResources(this.btnViewPositionLog, "btnViewPositionLog");
            this.btnViewPositionLog.Name = "btnViewPositionLog";
            this.btnViewPositionLog.TabStop = false;
            this.btnViewPositionLog.UseVisualStyleBackColor = true;
            this.btnViewPositionLog.Click += new System.EventHandler(this.btnViewPositionLog_Click);
            // 
            // btnAddToPositionLog
            // 
            resources.ApplyResources(this.btnAddToPositionLog, "btnAddToPositionLog");
            this.btnAddToPositionLog.Name = "btnAddToPositionLog";
            this.btnAddToPositionLog.TabStop = false;
            this.btnAddToPositionLog.UseVisualStyleBackColor = true;
            this.btnAddToPositionLog.Click += new System.EventHandler(this.btnAddToPositionLog_Click);
            // 
            // txtTaskNumber
            // 
            resources.ApplyResources(this.txtTaskNumber, "txtTaskNumber");
            this.txtTaskNumber.Name = "txtTaskNumber";
            this.txtTaskNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaskNumber_KeyPress);
            this.txtTaskNumber.Leave += new System.EventHandler(this.txtTaskNumber_Leave);
            this.txtTaskNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtTaskNumber_Validating);
            // 
            // btnICSRoleHelp
            // 
            resources.ApplyResources(this.btnICSRoleHelp, "btnICSRoleHelp");
            this.btnICSRoleHelp.Name = "btnICSRoleHelp";
            this.btnICSRoleHelp.TabStop = false;
            this.btnICSRoleHelp.UseVisualStyleBackColor = true;
            // 
            // cboICSRole
            // 
            resources.ApplyResources(this.cboICSRole, "cboICSRole");
            this.cboICSRole.DisplayMember = "RoleNameForDropdown";
            this.cboICSRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboICSRole.FormattingEnabled = true;
            this.cboICSRole.Name = "cboICSRole";
            this.cboICSRole.ValueMember = "RoleID";
            this.cboICSRole.SelectedIndexChanged += new System.EventHandler(this.cboICSRole_SelectedIndexChanged);
            this.cboICSRole.Leave += new System.EventHandler(this.cboICSRole_Leave);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // txtTaskName
            // 
            resources.ApplyResources(this.txtTaskName, "txtTaskName");
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Leave += new System.EventHandler(this.txtTaskName_Leave);
            this.txtTaskName.Validating += new System.ComponentModel.CancelEventHandler(this.txtTaskName_Validating);
            // 
            // lblTaskName
            // 
            resources.ApplyResources(this.lblTaskName, "lblTaskName");
            this.lblTaskName.Name = "lblTaskName";
            // 
            // lblTaskNumber
            // 
            resources.ApplyResources(this.lblTaskNumber, "lblTaskNumber");
            this.lblTaskNumber.Name = "lblTaskNumber";
            // 
            // lblServerStatus
            // 
            resources.ApplyResources(this.lblServerStatus, "lblServerStatus");
            this.lblServerStatus.Name = "lblServerStatus";
            // 
            // lblVersionNumber
            // 
            resources.ApplyResources(this.lblVersionNumber, "lblVersionNumber");
            this.lblVersionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVersionNumber.Name = "lblVersionNumber";
            // 
            // tcStatus
            // 
            resources.ApplyResources(this.tcStatus, "tcStatus");
            this.tcStatus.Controls.Add(this.tpMembersOnTask);
            this.tcStatus.Controls.Add(this.tpEquipment);
            this.tcStatus.Controls.Add(this.tpNetworkLog);
            this.tcStatus.ImageList = this.imglTabIcons;
            this.tcStatus.Multiline = true;
            this.tcStatus.Name = "tcStatus";
            this.tcStatus.SelectedIndex = 0;
            // 
            // tpMembersOnTask
            // 
            resources.ApplyResources(this.tpMembersOnTask, "tpMembersOnTask");
            this.tpMembersOnTask.Controls.Add(this.splitContainer4);
            this.tpMembersOnTask.Name = "tpMembersOnTask";
            this.tpMembersOnTask.UseVisualStyleBackColor = true;
            // 
            // tpEquipment
            // 
            this.tpEquipment.Controls.Add(this.splitContainer5);
            resources.ApplyResources(this.tpEquipment, "tpEquipment");
            this.tpEquipment.Name = "tpEquipment";
            this.tpEquipment.UseVisualStyleBackColor = true;
            // 
            // tpNetworkLog
            // 
            this.tpNetworkLog.Controls.Add(this.txtNetworkLog);
            resources.ApplyResources(this.tpNetworkLog, "tpNetworkLog");
            this.tpNetworkLog.Name = "tpNetworkLog";
            this.tpNetworkLog.UseVisualStyleBackColor = true;
            // 
            // txtNetworkLog
            // 
            resources.ApplyResources(this.txtNetworkLog, "txtNetworkLog");
            this.txtNetworkLog.Name = "txtNetworkLog";
            this.txtNetworkLog.ReadOnly = true;
            // 
            // imglTabIcons
            // 
            this.imglTabIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglTabIcons.ImageStream")));
            this.imglTabIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imglTabIcons.Images.SetKeyName(0, "glyphicons-basic-532-user-family.png");
            this.imglTabIcons.Images.SetKeyName(1, "glyphicons-basic-849-computer-network.png");
            this.imglTabIcons.Images.SetKeyName(2, "glyphicons-basic-876-palette-package.png");
            // 
            // pnlInternetSyncStart
            // 
            resources.ApplyResources(this.pnlInternetSyncStart, "pnlInternetSyncStart");
            this.pnlInternetSyncStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(130)))), ((int)(((byte)(236)))));
            this.pnlInternetSyncStart.Controls.Add(this.btnCancelInternetSync);
            this.pnlInternetSyncStart.Controls.Add(this.label22);
            this.pnlInternetSyncStart.Controls.Add(this.label21);
            this.pnlInternetSyncStart.Controls.Add(this.progressBar1);
            this.pnlInternetSyncStart.Name = "pnlInternetSyncStart";
            // 
            // btnCancelInternetSync
            // 
            resources.ApplyResources(this.btnCancelInternetSync, "btnCancelInternetSync");
            this.btnCancelInternetSync.Name = "btnCancelInternetSync";
            this.btnCancelInternetSync.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label22.Name = "label22";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Name = "label21";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // pnlNetworkSyncInProgress
            // 
            resources.ApplyResources(this.pnlNetworkSyncInProgress, "pnlNetworkSyncInProgress");
            this.pnlNetworkSyncInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(130)))), ((int)(((byte)(236)))));
            this.pnlNetworkSyncInProgress.Controls.Add(this.lblNetworkShareMoreInfoMsg);
            this.pnlNetworkSyncInProgress.Controls.Add(this.btnNetworkSyncDone);
            this.pnlNetworkSyncInProgress.Controls.Add(this.pbNetworkSyncInProgress);
            this.pnlNetworkSyncInProgress.Controls.Add(this.btnCloseNetworkSyncInProgress);
            this.pnlNetworkSyncInProgress.Controls.Add(this.lblNetworkSyncStatus);
            this.pnlNetworkSyncInProgress.Name = "pnlNetworkSyncInProgress";
            // 
            // lblNetworkShareMoreInfoMsg
            // 
            resources.ApplyResources(this.lblNetworkShareMoreInfoMsg, "lblNetworkShareMoreInfoMsg");
            this.lblNetworkShareMoreInfoMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNetworkShareMoreInfoMsg.Name = "lblNetworkShareMoreInfoMsg";
            // 
            // btnNetworkSyncDone
            // 
            resources.ApplyResources(this.btnNetworkSyncDone, "btnNetworkSyncDone");
            this.btnNetworkSyncDone.Name = "btnNetworkSyncDone";
            this.btnNetworkSyncDone.UseVisualStyleBackColor = true;
            // 
            // pbNetworkSyncInProgress
            // 
            resources.ApplyResources(this.pbNetworkSyncInProgress, "pbNetworkSyncInProgress");
            this.pbNetworkSyncInProgress.Maximum = 4;
            this.pbNetworkSyncInProgress.Name = "pbNetworkSyncInProgress";
            this.pbNetworkSyncInProgress.Step = 1;
            // 
            // btnCloseNetworkSyncInProgress
            // 
            resources.ApplyResources(this.btnCloseNetworkSyncInProgress, "btnCloseNetworkSyncInProgress");
            this.btnCloseNetworkSyncInProgress.Name = "btnCloseNetworkSyncInProgress";
            this.btnCloseNetworkSyncInProgress.UseVisualStyleBackColor = true;
            // 
            // lblNetworkSyncStatus
            // 
            resources.ApplyResources(this.lblNetworkSyncStatus, "lblNetworkSyncStatus");
            this.lblNetworkSyncStatus.ForeColor = System.Drawing.Color.White;
            this.lblNetworkSyncStatus.Name = "lblNetworkSyncStatus";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.iAPToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.logisticsToolStripMenuItem,
            this.planningToolStripMenuItem,
            this.networkInternetToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newIncidentToolStripMenuItem,
            this.openToolStripMenuItem,
            this.recentIncidentsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.browseToIncidentFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newIncidentToolStripMenuItem
            // 
            this.newIncidentToolStripMenuItem.Name = "newIncidentToolStripMenuItem";
            resources.ApplyResources(this.newIncidentToolStripMenuItem, "newIncidentToolStripMenuItem");
            this.newIncidentToolStripMenuItem.Click += new System.EventHandler(this.newIncidentToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // recentIncidentsToolStripMenuItem
            // 
            this.recentIncidentsToolStripMenuItem.Name = "recentIncidentsToolStripMenuItem";
            resources.ApplyResources(this.recentIncidentsToolStripMenuItem, "recentIncidentsToolStripMenuItem");
            this.recentIncidentsToolStripMenuItem.Click += new System.EventHandler(this.recentIncidentsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // browseToIncidentFolderToolStripMenuItem
            // 
            resources.ApplyResources(this.browseToIncidentFolderToolStripMenuItem, "browseToIncidentFolderToolStripMenuItem");
            this.browseToIncidentFolderToolStripMenuItem.Name = "browseToIncidentFolderToolStripMenuItem";
            this.browseToIncidentFolderToolStripMenuItem.Click += new System.EventHandler(this.browseToIncidentFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripSeparator3,
            this.savedValuesToolStripMenuItem,
            this.communicationsSystemsToolStripMenuItem,
            this.hospitalsToolStripMenuItem,
            this.medivacServicesToolStripMenuItem,
            this.contactsToolStripMenuItem,
            this.equipmentToolStripMenuItem,
            this.teamMembersToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.toolStripSeparator4,
            this.templatesToolStripMenuItem,
            this.incidentObjectivesToolStripMenuItem,
            this.safetyNotesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // savedValuesToolStripMenuItem
            // 
            this.savedValuesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.savedValuesToolStripMenuItem, "savedValuesToolStripMenuItem");
            this.savedValuesToolStripMenuItem.Name = "savedValuesToolStripMenuItem";
            // 
            // communicationsSystemsToolStripMenuItem
            // 
            this.communicationsSystemsToolStripMenuItem.Name = "communicationsSystemsToolStripMenuItem";
            resources.ApplyResources(this.communicationsSystemsToolStripMenuItem, "communicationsSystemsToolStripMenuItem");
            this.communicationsSystemsToolStripMenuItem.Click += new System.EventHandler(this.communicationsSystemsToolStripMenuItem_Click);
            // 
            // hospitalsToolStripMenuItem
            // 
            this.hospitalsToolStripMenuItem.Name = "hospitalsToolStripMenuItem";
            resources.ApplyResources(this.hospitalsToolStripMenuItem, "hospitalsToolStripMenuItem");
            this.hospitalsToolStripMenuItem.Click += new System.EventHandler(this.hospitalsToolStripMenuItem_Click);
            // 
            // medivacServicesToolStripMenuItem
            // 
            this.medivacServicesToolStripMenuItem.Name = "medivacServicesToolStripMenuItem";
            resources.ApplyResources(this.medivacServicesToolStripMenuItem, "medivacServicesToolStripMenuItem");
            this.medivacServicesToolStripMenuItem.Click += new System.EventHandler(this.medivacServicesToolStripMenuItem_Click);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            resources.ApplyResources(this.contactsToolStripMenuItem, "contactsToolStripMenuItem");
            this.contactsToolStripMenuItem.Click += new System.EventHandler(this.contactsToolStripMenuItem_Click);
            // 
            // equipmentToolStripMenuItem
            // 
            this.equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            resources.ApplyResources(this.equipmentToolStripMenuItem, "equipmentToolStripMenuItem");
            // 
            // teamMembersToolStripMenuItem
            // 
            this.teamMembersToolStripMenuItem.Name = "teamMembersToolStripMenuItem";
            resources.ApplyResources(this.teamMembersToolStripMenuItem, "teamMembersToolStripMenuItem");
            this.teamMembersToolStripMenuItem.Click += new System.EventHandler(this.teamMembersToolStripMenuItem_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            resources.ApplyResources(this.vehiclesToolStripMenuItem, "vehiclesToolStripMenuItem");
            this.vehiclesToolStripMenuItem.Click += new System.EventHandler(this.vehiclesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // templatesToolStripMenuItem
            // 
            resources.ApplyResources(this.templatesToolStripMenuItem, "templatesToolStripMenuItem");
            this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            // 
            // incidentObjectivesToolStripMenuItem
            // 
            this.incidentObjectivesToolStripMenuItem.Name = "incidentObjectivesToolStripMenuItem";
            resources.ApplyResources(this.incidentObjectivesToolStripMenuItem, "incidentObjectivesToolStripMenuItem");
            this.incidentObjectivesToolStripMenuItem.Click += new System.EventHandler(this.incidentObjectivesToolStripMenuItem_Click);
            // 
            // safetyNotesToolStripMenuItem
            // 
            this.safetyNotesToolStripMenuItem.Name = "safetyNotesToolStripMenuItem";
            resources.ApplyResources(this.safetyNotesToolStripMenuItem, "safetyNotesToolStripMenuItem");
            this.safetyNotesToolStripMenuItem.Click += new System.EventHandler(this.safetyNotesToolStripMenuItem_Click);
            // 
            // iAPToolStripMenuItem
            // 
            this.iAPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidentActionPlanToolStripMenuItem,
            this.incidentObjectivesICS202ToolStripMenuItem,
            this.communicationsPlanICS205ToolStripMenuItem,
            this.medicalPlanICS206ToolStripMenuItem,
            this.organizationChartICS207ToolStripMenuItem,
            this.safetyMessageICS208ToolStripMenuItem,
            this.toolStripSeparator5,
            this.additionalDocumentsToolStripMenuItem,
            this.communicationsListICS205AToolStripMenuItem});
            this.iAPToolStripMenuItem.Name = "iAPToolStripMenuItem";
            resources.ApplyResources(this.iAPToolStripMenuItem, "iAPToolStripMenuItem");
            // 
            // incidentActionPlanToolStripMenuItem
            // 
            resources.ApplyResources(this.incidentActionPlanToolStripMenuItem, "incidentActionPlanToolStripMenuItem");
            this.incidentActionPlanToolStripMenuItem.Name = "incidentActionPlanToolStripMenuItem";
            // 
            // incidentObjectivesICS202ToolStripMenuItem
            // 
            this.incidentObjectivesICS202ToolStripMenuItem.Name = "incidentObjectivesICS202ToolStripMenuItem";
            resources.ApplyResources(this.incidentObjectivesICS202ToolStripMenuItem, "incidentObjectivesICS202ToolStripMenuItem");
            this.incidentObjectivesICS202ToolStripMenuItem.Click += new System.EventHandler(this.incidentObjectivesICS202ToolStripMenuItem_Click);
            // 
            // communicationsPlanICS205ToolStripMenuItem
            // 
            this.communicationsPlanICS205ToolStripMenuItem.Name = "communicationsPlanICS205ToolStripMenuItem";
            resources.ApplyResources(this.communicationsPlanICS205ToolStripMenuItem, "communicationsPlanICS205ToolStripMenuItem");
            this.communicationsPlanICS205ToolStripMenuItem.Click += new System.EventHandler(this.communicationsPlanICS205ToolStripMenuItem_Click);
            // 
            // medicalPlanICS206ToolStripMenuItem
            // 
            this.medicalPlanICS206ToolStripMenuItem.Name = "medicalPlanICS206ToolStripMenuItem";
            resources.ApplyResources(this.medicalPlanICS206ToolStripMenuItem, "medicalPlanICS206ToolStripMenuItem");
            // 
            // organizationChartICS207ToolStripMenuItem
            // 
            this.organizationChartICS207ToolStripMenuItem.Name = "organizationChartICS207ToolStripMenuItem";
            resources.ApplyResources(this.organizationChartICS207ToolStripMenuItem, "organizationChartICS207ToolStripMenuItem");
            this.organizationChartICS207ToolStripMenuItem.Click += new System.EventHandler(this.organizationChartICS207ToolStripMenuItem_Click);
            // 
            // safetyMessageICS208ToolStripMenuItem
            // 
            this.safetyMessageICS208ToolStripMenuItem.Name = "safetyMessageICS208ToolStripMenuItem";
            resources.ApplyResources(this.safetyMessageICS208ToolStripMenuItem, "safetyMessageICS208ToolStripMenuItem");
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // additionalDocumentsToolStripMenuItem
            // 
            resources.ApplyResources(this.additionalDocumentsToolStripMenuItem, "additionalDocumentsToolStripMenuItem");
            this.additionalDocumentsToolStripMenuItem.Name = "additionalDocumentsToolStripMenuItem";
            // 
            // communicationsListICS205AToolStripMenuItem
            // 
            this.communicationsListICS205AToolStripMenuItem.Name = "communicationsListICS205AToolStripMenuItem";
            resources.ApplyResources(this.communicationsListICS205AToolStripMenuItem, "communicationsListICS205AToolStripMenuItem");
            this.communicationsListICS205AToolStripMenuItem.Click += new System.EventHandler(this.communicationsListICS205AToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionLogToolStripMenuItem,
            this.toolStripSeparator8});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            resources.ApplyResources(this.operationsToolStripMenuItem, "operationsToolStripMenuItem");
            // 
            // positionLogToolStripMenuItem
            // 
            this.positionLogToolStripMenuItem.Name = "positionLogToolStripMenuItem";
            resources.ApplyResources(this.positionLogToolStripMenuItem, "positionLogToolStripMenuItem");
            this.positionLogToolStripMenuItem.Click += new System.EventHandler(this.positionLogToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // logisticsToolStripMenuItem
            // 
            this.logisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionLogToolStripMenuItem1,
            this.toolStripSeparator7});
            this.logisticsToolStripMenuItem.Name = "logisticsToolStripMenuItem";
            resources.ApplyResources(this.logisticsToolStripMenuItem, "logisticsToolStripMenuItem");
            // 
            // positionLogToolStripMenuItem1
            // 
            this.positionLogToolStripMenuItem1.Name = "positionLogToolStripMenuItem1";
            resources.ApplyResources(this.positionLogToolStripMenuItem1, "positionLogToolStripMenuItem1");
            this.positionLogToolStripMenuItem1.Click += new System.EventHandler(this.positionLogToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // planningToolStripMenuItem
            // 
            this.planningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionLogToolStripMenuItem2,
            this.toolStripSeparator6});
            this.planningToolStripMenuItem.Name = "planningToolStripMenuItem";
            resources.ApplyResources(this.planningToolStripMenuItem, "planningToolStripMenuItem");
            // 
            // positionLogToolStripMenuItem2
            // 
            this.positionLogToolStripMenuItem2.Name = "positionLogToolStripMenuItem2";
            resources.ApplyResources(this.positionLogToolStripMenuItem2, "positionLogToolStripMenuItem2");
            this.positionLogToolStripMenuItem2.Click += new System.EventHandler(this.positionLogToolStripMenuItem2_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // networkInternetToolStripMenuItem
            // 
            this.networkInternetToolStripMenuItem.Name = "networkInternetToolStripMenuItem";
            resources.ApplyResources(this.networkInternetToolStripMenuItem, "networkInternetToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForTemplateUpdatesToolStripMenuItem,
            this.checkForAppUpdatesToolStripMenuItem,
            this.toolStripSeparator2,
            this.supportToolStripMenuItem,
            this.aboutCIAPPToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // checkForTemplateUpdatesToolStripMenuItem
            // 
            this.checkForTemplateUpdatesToolStripMenuItem.Name = "checkForTemplateUpdatesToolStripMenuItem";
            resources.ApplyResources(this.checkForTemplateUpdatesToolStripMenuItem, "checkForTemplateUpdatesToolStripMenuItem");
            // 
            // checkForAppUpdatesToolStripMenuItem
            // 
            this.checkForAppUpdatesToolStripMenuItem.Name = "checkForAppUpdatesToolStripMenuItem";
            resources.ApplyResources(this.checkForAppUpdatesToolStripMenuItem, "checkForAppUpdatesToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            resources.ApplyResources(this.supportToolStripMenuItem, "supportToolStripMenuItem");
            // 
            // aboutCIAPPToolStripMenuItem
            // 
            this.aboutCIAPPToolStripMenuItem.Name = "aboutCIAPPToolStripMenuItem";
            resources.ApplyResources(this.aboutCIAPPToolStripMenuItem, "aboutCIAPPToolStripMenuItem");
            this.aboutCIAPPToolStripMenuItem.Click += new System.EventHandler(this.aboutCIAPPToolStripMenuItem_Click);
            // 
            // llProgramURL
            // 
            resources.ApplyResources(this.llProgramURL, "llProgramURL");
            this.llProgramURL.Name = "llProgramURL";
            this.llProgramURL.TabStop = true;
            this.llProgramURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llProgramURL_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wildfire_ICS_Assist.Properties.Resources.ics_canada_logo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ofdOpenTaskFile
            // 
            this.ofdOpenTaskFile.DefaultExt = "xml";
            resources.ApplyResources(this.ofdOpenTaskFile, "ofdOpenTaskFile");
            // 
            // tmrAutoSave
            // 
            this.tmrAutoSave.Interval = 60000;
            // 
            // tmrPositionLogReminders
            // 
            this.tmrPositionLogReminders.Interval = 60000;
            // 
            // tmrInternetSync
            // 
            this.tmrInternetSync.Interval = 2000;
            // 
            // tmrNetwork
            // 
            this.tmrNetwork.Interval = 10000;
            // 
            // cpIncidentActionPlan
            // 
            this.cpIncidentActionPlan.BackColor = System.Drawing.Color.White;
            this.cpIncidentActionPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpIncidentActionPlan.CollapsedHeight = 40;
            this.cpIncidentActionPlan.CollapsedWidth = 485;
            this.cpIncidentActionPlan.CollapseLeft = true;
            this.cpIncidentActionPlan.Controls.Add(this.btnBriefings2);
            this.cpIncidentActionPlan.Controls.Add(this.btnSafetyPlans);
            this.cpIncidentActionPlan.Controls.Add(this.btnIncidentObjectives);
            this.cpIncidentActionPlan.Controls.Add(this.btnMedicalPlan);
            this.cpIncidentActionPlan.Controls.Add(this.btnPrintIAP);
            this.cpIncidentActionPlan.Controls.Add(this.btnPrintOrgChart);
            this.cpIncidentActionPlan.Controls.Add(this.btnCommsPlan);
            this.cpIncidentActionPlan.CurrentlyCollapsed = false;
            this.cpIncidentActionPlan.ExpandedHeight = 262;
            this.cpIncidentActionPlan.ExpandedWidth = 710;
            resources.ApplyResources(this.cpIncidentActionPlan, "cpIncidentActionPlan");
            this.cpIncidentActionPlan.Name = "cpIncidentActionPlan";
            this.cpIncidentActionPlan.TitleText = "Incident Action Plan";
            // 
            // btnBriefings2
            // 
            resources.ApplyResources(this.btnBriefings2, "btnBriefings2");
            this.btnBriefings2.Name = "btnBriefings2";
            this.btnBriefings2.UseVisualStyleBackColor = true;
            // 
            // btnSafetyPlans
            // 
            resources.ApplyResources(this.btnSafetyPlans, "btnSafetyPlans");
            this.btnSafetyPlans.Name = "btnSafetyPlans";
            this.btnSafetyPlans.UseVisualStyleBackColor = true;
            // 
            // btnIncidentObjectives
            // 
            resources.ApplyResources(this.btnIncidentObjectives, "btnIncidentObjectives");
            this.btnIncidentObjectives.Name = "btnIncidentObjectives";
            this.btnIncidentObjectives.UseVisualStyleBackColor = true;
            this.btnIncidentObjectives.Click += new System.EventHandler(this.btnIncidentObjectives_Click);
            // 
            // btnMedicalPlan
            // 
            resources.ApplyResources(this.btnMedicalPlan, "btnMedicalPlan");
            this.btnMedicalPlan.Name = "btnMedicalPlan";
            this.btnMedicalPlan.UseVisualStyleBackColor = true;
            // 
            // btnPrintIAP
            // 
            resources.ApplyResources(this.btnPrintIAP, "btnPrintIAP");
            this.btnPrintIAP.Image = global::Wildfire_ICS_Assist.Properties.Resources.glyphicons_basic_16_print;
            this.btnPrintIAP.Name = "btnPrintIAP";
            this.btnPrintIAP.UseVisualStyleBackColor = true;
            // 
            // btnPrintOrgChart
            // 
            resources.ApplyResources(this.btnPrintOrgChart, "btnPrintOrgChart");
            this.btnPrintOrgChart.Name = "btnPrintOrgChart";
            this.btnPrintOrgChart.UseVisualStyleBackColor = true;
            this.btnPrintOrgChart.Click += new System.EventHandler(this.btnPrintOrgChart_Click);
            // 
            // btnCommsPlan
            // 
            resources.ApplyResources(this.btnCommsPlan, "btnCommsPlan");
            this.btnCommsPlan.Name = "btnCommsPlan";
            this.btnCommsPlan.UseVisualStyleBackColor = true;
            this.btnCommsPlan.Click += new System.EventHandler(this.btnCommsPlan_Click);
            // 
            // btnLogisticsBulkSignIn
            // 
            resources.ApplyResources(this.btnLogisticsBulkSignIn, "btnLogisticsBulkSignIn");
            this.btnLogisticsBulkSignIn.Name = "btnLogisticsBulkSignIn";
            this.btnLogisticsBulkSignIn.UseVisualStyleBackColor = true;
            // 
            // btnLogisticsSignIn
            // 
            resources.ApplyResources(this.btnLogisticsSignIn, "btnLogisticsSignIn");
            this.btnLogisticsSignIn.Name = "btnLogisticsSignIn";
            this.btnLogisticsSignIn.UseVisualStyleBackColor = true;
            // 
            // btnLogisticsMemberStatus
            // 
            resources.ApplyResources(this.btnLogisticsMemberStatus, "btnLogisticsMemberStatus");
            this.btnLogisticsMemberStatus.Name = "btnLogisticsMemberStatus";
            this.btnLogisticsMemberStatus.UseVisualStyleBackColor = true;
            // 
            // btnAdditionalContacts
            // 
            resources.ApplyResources(this.btnAdditionalContacts, "btnAdditionalContacts");
            this.btnAdditionalContacts.Name = "btnAdditionalContacts";
            this.btnAdditionalContacts.UseVisualStyleBackColor = true;
            // 
            // btnEquipment
            // 
            resources.ApplyResources(this.btnEquipment, "btnEquipment");
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.UseVisualStyleBackColor = true;
            // 
            // btnVehicles
            // 
            resources.ApplyResources(this.btnVehicles, "btnVehicles");
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.UseVisualStyleBackColor = true;
            // 
            // btnLogisticsDashboard
            // 
            resources.ApplyResources(this.btnLogisticsDashboard, "btnLogisticsDashboard");
            this.btnLogisticsDashboard.Name = "btnLogisticsDashboard";
            this.btnLogisticsDashboard.UseVisualStyleBackColor = true;
            // 
            // btnPlanningAddAssignment
            // 
            resources.ApplyResources(this.btnPlanningAddAssignment, "btnPlanningAddAssignment");
            this.btnPlanningAddAssignment.Name = "btnPlanningAddAssignment";
            this.btnPlanningAddAssignment.UseVisualStyleBackColor = true;
            // 
            // btnTeamAssignments
            // 
            resources.ApplyResources(this.btnTeamAssignments, "btnTeamAssignments");
            this.btnTeamAssignments.Name = "btnTeamAssignments";
            this.btnTeamAssignments.UseVisualStyleBackColor = true;
            // 
            // btnTimeline
            // 
            resources.ApplyResources(this.btnTimeline, "btnTimeline");
            this.btnTimeline.Name = "btnTimeline";
            this.btnTimeline.UseVisualStyleBackColor = true;
            // 
            // btnPlanningDashboard
            // 
            resources.ApplyResources(this.btnPlanningDashboard, "btnPlanningDashboard");
            this.btnPlanningDashboard.Name = "btnPlanningDashboard";
            this.btnPlanningDashboard.UseVisualStyleBackColor = true;
            // 
            // cpPlanning
            // 
            resources.ApplyResources(this.cpPlanning, "cpPlanning");
            this.cpPlanning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.cpPlanning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpPlanning.CollapsedHeight = 40;
            this.cpPlanning.CollapsedWidth = 485;
            this.cpPlanning.CollapseLeft = false;
            this.cpPlanning.Controls.Add(this.btnPlanningAddAssignment);
            this.cpPlanning.Controls.Add(this.btnNotes);
            this.cpPlanning.Controls.Add(this.btnTeamAssignments);
            this.cpPlanning.Controls.Add(this.btnPlanningDashboard);
            this.cpPlanning.Controls.Add(this.btnTimeline);
            this.cpPlanning.CurrentlyCollapsed = true;
            this.cpPlanning.ExpandedHeight = 270;
            this.cpPlanning.ExpandedWidth = 485;
            this.cpPlanning.Name = "cpPlanning";
            this.cpPlanning.TitleText = "PLANNING";
            // 
            // btnNotes
            // 
            resources.ApplyResources(this.btnNotes, "btnNotes");
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.UseVisualStyleBackColor = true;
            // 
            // cpLogistics
            // 
            resources.ApplyResources(this.cpLogistics, "cpLogistics");
            this.cpLogistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.cpLogistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpLogistics.CollapsedHeight = 40;
            this.cpLogistics.CollapsedWidth = 485;
            this.cpLogistics.CollapseLeft = false;
            this.cpLogistics.Controls.Add(this.btnLogisticsBulkSignIn);
            this.cpLogistics.Controls.Add(this.btnLogisticsSignIn);
            this.cpLogistics.Controls.Add(this.btnAdditionalContacts);
            this.cpLogistics.Controls.Add(this.btnLogisticsMemberStatus);
            this.cpLogistics.Controls.Add(this.btnLogisticsDashboard);
            this.cpLogistics.Controls.Add(this.btnEquipment);
            this.cpLogistics.Controls.Add(this.btnVehicles);
            this.cpLogistics.CurrentlyCollapsed = true;
            this.cpLogistics.ExpandedHeight = 246;
            this.cpLogistics.ExpandedWidth = 530;
            this.cpLogistics.Name = "cpLogistics";
            this.cpLogistics.TitleText = "LOGISTICS";
            // 
            // cpOperations
            // 
            resources.ApplyResources(this.cpOperations, "cpOperations");
            this.cpOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.cpOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpOperations.CollapsedHeight = 40;
            this.cpOperations.CollapsedWidth = 485;
            this.cpOperations.CollapseLeft = false;
            this.cpOperations.Controls.Add(this.btnOpsAssignments);
            this.cpOperations.Controls.Add(this.btnOpsMemberStatus);
            this.cpOperations.Controls.Add(this.btnOpsDashboard);
            this.cpOperations.Controls.Add(this.btnTeamStatus);
            this.cpOperations.Controls.Add(this.btnCommsLog);
            this.cpOperations.CurrentlyCollapsed = true;
            this.cpOperations.ExpandedHeight = 260;
            this.cpOperations.ExpandedWidth = 485;
            this.cpOperations.Name = "cpOperations";
            this.cpOperations.TitleText = "OPERATIONS";
            // 
            // btnOpsAssignments
            // 
            resources.ApplyResources(this.btnOpsAssignments, "btnOpsAssignments");
            this.btnOpsAssignments.Name = "btnOpsAssignments";
            this.btnOpsAssignments.UseVisualStyleBackColor = true;
            // 
            // btnOpsMemberStatus
            // 
            resources.ApplyResources(this.btnOpsMemberStatus, "btnOpsMemberStatus");
            this.btnOpsMemberStatus.Name = "btnOpsMemberStatus";
            this.btnOpsMemberStatus.UseVisualStyleBackColor = true;
            // 
            // btnOpsDashboard
            // 
            resources.ApplyResources(this.btnOpsDashboard, "btnOpsDashboard");
            this.btnOpsDashboard.Name = "btnOpsDashboard";
            this.btnOpsDashboard.UseVisualStyleBackColor = true;
            // 
            // btnTeamStatus
            // 
            resources.ApplyResources(this.btnTeamStatus, "btnTeamStatus");
            this.btnTeamStatus.Name = "btnTeamStatus";
            this.btnTeamStatus.UseVisualStyleBackColor = true;
            // 
            // btnCommsLog
            // 
            resources.ApplyResources(this.btnCommsLog, "btnCommsLog");
            this.btnCommsLog.Name = "btnCommsLog";
            this.btnCommsLog.UseVisualStyleBackColor = true;
            // 
            // IncidentDetailsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.cpIncidentActionPlan);
            this.Controls.Add(this.llProgramURL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlInternetSyncStart);
            this.Controls.Add(this.pnlNetworkSyncInProgress);
            this.Controls.Add(this.pnlOpsPeriod);
            this.Controls.Add(this.pnlTaskInfo);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.lblVersionNumber);
            this.Controls.Add(this.tcStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cpLogistics);
            this.Controls.Add(this.cpOperations);
            this.Controls.Add(this.cpPlanning);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IncidentDetailsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncidentDetailsForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IncidentDetailsForm_FormClosed);
            this.Load += new System.EventHandler(this.IncidentDetailsForm_Load);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersOnTask)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskEquipment)).EndInit();
            this.pnlOpsPeriod.ResumeLayout(false);
            this.pnlOpsPeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpPeriod)).EndInit();
            this.pnlTaskInfo.ResumeLayout(false);
            this.pnlTaskInfo.PerformLayout();
            this.tcStatus.ResumeLayout(false);
            this.tpMembersOnTask.ResumeLayout(false);
            this.tpEquipment.ResumeLayout(false);
            this.tpNetworkLog.ResumeLayout(false);
            this.tpNetworkLog.PerformLayout();
            this.pnlInternetSyncStart.ResumeLayout(false);
            this.pnlNetworkSyncInProgress.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cpIncidentActionPlan.ResumeLayout(false);
            this.cpPlanning.ResumeLayout(false);
            this.cpLogistics.ResumeLayout(false);
            this.cpOperations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpsPeriod;
        private System.Windows.Forms.Button btnCloseOpPeriod;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker datOpsEnd;
        private System.Windows.Forms.DateTimePicker datOpsStart;
        private System.Windows.Forms.NumericUpDown numOpPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTaskInfo;
        private System.Windows.Forms.Button btnOutstandingLogItems;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnViewPositionLog;
        private System.Windows.Forms.Button btnAddToPositionLog;
        private System.Windows.Forms.TextBox txtTaskNumber;
        private System.Windows.Forms.Button btnICSRoleHelp;
        private System.Windows.Forms.ComboBox cboICSRole;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblTaskNumber;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Label lblVersionNumber;
        private System.Windows.Forms.TabControl tcStatus;
        private System.Windows.Forms.TabPage tpMembersOnTask;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dgvMembersOnTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberSARGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSignInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberAssignmentStatus;
        private System.Windows.Forms.Button btnAddAMember;
        private System.Windows.Forms.Button btnBulkSignIn;
        private System.Windows.Forms.Button btnMembersOnTaskNewWindow;
        private System.Windows.Forms.TabPage tpEquipment;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView dgvTaskEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReferenceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipmentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignee;
        private System.Windows.Forms.Button btnAssignEquipment;
        private System.Windows.Forms.Button btnViewEquipment;
        private System.Windows.Forms.Button btnReturnEquipment;
        private System.Windows.Forms.TabPage tpNetworkLog;
        private System.Windows.Forms.TextBox txtNetworkLog;
        private System.Windows.Forms.Panel pnlInternetSyncStart;
        private System.Windows.Forms.Button btnCancelInternetSync;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pnlNetworkSyncInProgress;
        private System.Windows.Forms.Label lblNetworkShareMoreInfoMsg;
        private System.Windows.Forms.Button btnNetworkSyncDone;
        private System.Windows.Forms.ProgressBar pbNetworkSyncInProgress;
        private System.Windows.Forms.Button btnCloseNetworkSyncInProgress;
        private System.Windows.Forms.Label lblNetworkSyncStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btnBriefings2;
        private System.Windows.Forms.Button btnSafetyPlans;
        private System.Windows.Forms.Button btnMedicalPlan;
        private System.Windows.Forms.Button btnPrintOrgChart;
        private System.Windows.Forms.Button btnCommsPlan;
        private System.Windows.Forms.Button btnPrintIAP;
        private System.Windows.Forms.Button btnIncidentObjectives;
        private System.Windows.Forms.Button btnLogisticsBulkSignIn;
        private System.Windows.Forms.Button btnLogisticsSignIn;
        private System.Windows.Forms.Button btnLogisticsMemberStatus;
        private System.Windows.Forms.Button btnAdditionalContacts;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnLogisticsDashboard;
        private System.Windows.Forms.Button btnPlanningAddAssignment;
        private System.Windows.Forms.Button btnTeamAssignments;
        private System.Windows.Forms.Button btnTimeline;
        private System.Windows.Forms.Button btnPlanningDashboard;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkInternetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llProgramURL;
        private System.Windows.Forms.ToolStripMenuItem newIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentIncidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToIncidentFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem communicationsSystemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCIAPPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem savedValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentObjectivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safetyNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForTemplateUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForAppUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ImageList imglTabIcons;
        private System.Windows.Forms.ToolStripMenuItem medivacServicesToolStripMenuItem;
        private CustomControls.CollapsiblePanel cpIncidentActionPlan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtICPCallsign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog svdTaskFile;
        private System.Windows.Forms.OpenFileDialog ofdOpenTaskFile;
        private System.Windows.Forms.FolderBrowserDialog fbdSaveLocation;
        private System.Windows.Forms.Timer tmrAutoSave;
        private System.Windows.Forms.Timer tmrPositionLogReminders;
        private System.Windows.Forms.Timer tmrInternetSync;
        private System.Windows.Forms.Timer tmrNetwork;
        private System.Windows.Forms.ToolStripMenuItem incidentActionPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentObjectivesICS202ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem communicationsPlanICS205ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalPlanICS206ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem additionalDocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem communicationsListICS205AToolStripMenuItem;
        private CustomControls.CollapsiblePanel cpOperations;
        private CustomControls.CollapsiblePanel cpLogistics;
        private CustomControls.CollapsiblePanel cpPlanning;
        private System.Windows.Forms.ToolStripMenuItem organizationChartICS207ToolStripMenuItem;
        private System.Windows.Forms.Button btnOpsAssignments;
        private System.Windows.Forms.Button btnOpsMemberStatus;
        private System.Windows.Forms.Button btnOpsDashboard;
        private System.Windows.Forms.Button btnTeamStatus;
        private System.Windows.Forms.Button btnCommsLog;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.ToolStripMenuItem positionLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionLogToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem positionLogToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem safetyMessageICS208ToolStripMenuItem;
    }
}

