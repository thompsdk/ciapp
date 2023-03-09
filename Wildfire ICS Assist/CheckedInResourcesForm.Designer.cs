﻿namespace Wildfire_ICS_Assist
{
    partial class CheckedInResourcesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckedInResourcesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvResources = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLogisticsSignIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cpFilters = new Wildfire_ICS_Assist.CustomControls.CollapsiblePanel();
            this.cboResourceVariety = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportSignInToCSV = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.colVariety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberOfPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberOfEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).BeginInit();
            this.cpFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnExportSignInToCSV);
            this.splitContainer1.Panel2.Controls.Add(this.btnPrint);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel2.Controls.Add(this.btnLogisticsSignIn);
            this.splitContainer1.Size = new System.Drawing.Size(1245, 658);
            this.splitContainer1.SplitterDistance = 580;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvResources);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cpFilters);
            this.splitContainer2.Size = new System.Drawing.Size(1245, 580);
            this.splitContainer2.SplitterDistance = 940;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoving += new System.Windows.Forms.SplitterCancelEventHandler(this.splitContainer2_SplitterMoving);
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // dgvResources
            // 
            this.dgvResources.AllowUserToAddRows = false;
            this.dgvResources.AllowUserToDeleteRows = false;
            this.dgvResources.AllowUserToResizeColumns = false;
            this.dgvResources.AllowUserToResizeRows = false;
            this.dgvResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVariety,
            this.colName,
            this.colLeader,
            this.colNumberOfPeople,
            this.colNumberOfEquipment,
            this.colCheckIn,
            this.colLastDay,
            this.colStatus});
            this.dgvResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResources.Location = new System.Drawing.Point(0, 0);
            this.dgvResources.Name = "dgvResources";
            this.dgvResources.ReadOnly = true;
            this.dgvResources.RowHeadersVisible = false;
            this.dgvResources.RowTemplate.Height = 30;
            this.dgvResources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResources.Size = new System.Drawing.Size(940, 580);
            this.dgvResources.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::Wildfire_ICS_Assist.Properties.Resources.glyphicons_basic_31_pencil;
            this.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdit.Location = new System.Drawing.Point(152, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 66);
            this.btnEdit.TabIndex = 47;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLogisticsSignIn
            // 
            this.btnLogisticsSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogisticsSignIn.Image = ((System.Drawing.Image)(resources.GetObject("btnLogisticsSignIn.Image")));
            this.btnLogisticsSignIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogisticsSignIn.Location = new System.Drawing.Point(3, 3);
            this.btnLogisticsSignIn.Name = "btnLogisticsSignIn";
            this.btnLogisticsSignIn.Size = new System.Drawing.Size(143, 66);
            this.btnLogisticsSignIn.TabIndex = 46;
            this.btnLogisticsSignIn.Text = "Check-In";
            this.btnLogisticsSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogisticsSignIn.UseVisualStyleBackColor = true;
            this.btnLogisticsSignIn.Click += new System.EventHandler(this.btnLogisticsSignIn_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Wildfire_ICS_Assist.Properties.Resources.glyphicons_basic_432_log_out;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(307, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 66);
            this.button1.TabIndex = 48;
            this.button1.Text = "Demob Selected";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cpFilters
            // 
            this.cpFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.cpFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpFilters.CollapsedHeight = 40;
            this.cpFilters.CollapsedWidth = 290;
            this.cpFilters.CollapseLeft = true;
            this.cpFilters.Controls.Add(this.cboResourceVariety);
            this.cpFilters.Controls.Add(this.label1);
            this.cpFilters.CurrentlyCollapsed = true;
            this.cpFilters.ExpandedHeight = 300;
            this.cpFilters.ExpandedWidth = 290;
            this.cpFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpFilters.Location = new System.Drawing.Point(6, 15);
            this.cpFilters.Margin = new System.Windows.Forms.Padding(6);
            this.cpFilters.Name = "cpFilters";
            this.cpFilters.Size = new System.Drawing.Size(289, 40);
            this.cpFilters.TabIndex = 0;
            this.cpFilters.TitleText = "Filter List";
            // 
            // cboResourceVariety
            // 
            this.cboResourceVariety.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboResourceVariety.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResourceVariety.FormattingEnabled = true;
            this.cboResourceVariety.Items.AddRange(new object[] {
            "All Resources",
            "Personnel",
            "Visitor",
            "Vehicle/Equipment",
            "Crew"});
            this.cboResourceVariety.Location = new System.Drawing.Point(7, 71);
            this.cboResourceVariety.Name = "cboResourceVariety";
            this.cboResourceVariety.Size = new System.Drawing.Size(275, 32);
            this.cboResourceVariety.TabIndex = 34;
            this.cboResourceVariety.SelectedIndexChanged += new System.EventHandler(this.cboResourceVariety_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Resource Variety";
            // 
            // btnExportSignInToCSV
            // 
            this.btnExportSignInToCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportSignInToCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportSignInToCSV.Image = global::Wildfire_ICS_Assist.Properties.Resources.glyphicons_basic_400_export;
            this.btnExportSignInToCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportSignInToCSV.Location = new System.Drawing.Point(861, 2);
            this.btnExportSignInToCSV.Name = "btnExportSignInToCSV";
            this.btnExportSignInToCSV.Size = new System.Drawing.Size(197, 66);
            this.btnExportSignInToCSV.TabIndex = 50;
            this.btnExportSignInToCSV.Text = "Export to CSV";
            this.btnExportSignInToCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportSignInToCSV.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::Wildfire_ICS_Assist.Properties.Resources.glyphicons_basic_16_print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(1064, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(169, 66);
            this.btnPrint.TabIndex = 49;
            this.btnPrint.Text = "Print ICS-211";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // colVariety
            // 
            this.colVariety.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVariety.DataPropertyName = "ResourceType";
            this.colVariety.HeaderText = "Variety";
            this.colVariety.Name = "colVariety";
            this.colVariety.ReadOnly = true;
            this.colVariety.Width = 92;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "ResourceName";
            this.colName.HeaderText = "Resource ID";
            this.colName.MinimumWidth = 200;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colLeader
            // 
            this.colLeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLeader.DataPropertyName = "LeaderName";
            this.colLeader.HeaderText = "Leader";
            this.colLeader.Name = "colLeader";
            this.colLeader.ReadOnly = true;
            this.colLeader.Width = 94;
            // 
            // colNumberOfPeople
            // 
            this.colNumberOfPeople.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNumberOfPeople.DataPropertyName = "NumberOfPeople";
            this.colNumberOfPeople.HeaderText = "# Ppl";
            this.colNumberOfPeople.Name = "colNumberOfPeople";
            this.colNumberOfPeople.ReadOnly = true;
            this.colNumberOfPeople.Width = 77;
            // 
            // colNumberOfEquipment
            // 
            this.colNumberOfEquipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNumberOfEquipment.DataPropertyName = "NumberOfVehicles";
            this.colNumberOfEquipment.HeaderText = "# Equip";
            this.colNumberOfEquipment.Name = "colNumberOfEquipment";
            this.colNumberOfEquipment.ReadOnly = true;
            // 
            // colCheckIn
            // 
            this.colCheckIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCheckIn.DataPropertyName = "CheckInDate";
            dataGridViewCellStyle3.Format = "MMM-dd-yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.colCheckIn.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCheckIn.HeaderText = "Check In";
            this.colCheckIn.Name = "colCheckIn";
            this.colCheckIn.ReadOnly = true;
            this.colCheckIn.Width = 109;
            // 
            // colLastDay
            // 
            this.colLastDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colLastDay.DataPropertyName = "LastDayOnIncident";
            dataGridViewCellStyle4.Format = "MMM-dd-yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.colLastDay.DefaultCellStyle = dataGridViewCellStyle4;
            this.colLastDay.HeaderText = "Last Day";
            this.colLastDay.Name = "colLastDay";
            this.colLastDay.ReadOnly = true;
            this.colLastDay.Width = 105;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 85;
            // 
            // CheckedInResourcesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 658);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(865, 523);
            this.Name = "CheckedInResourcesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Checked In Resources";
            this.Load += new System.EventHandler(this.CheckedInResourcesForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).EndInit();
            this.cpFilters.ResumeLayout(false);
            this.cpFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvResources;
        private System.Windows.Forms.Button btnLogisticsSignIn;
        private System.Windows.Forms.Button btnEdit;
        private CustomControls.CollapsiblePanel cpFilters;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboResourceVariety;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariety;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Button btnExportSignInToCSV;
        private System.Windows.Forms.Button btnPrint;
    }
}