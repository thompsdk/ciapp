﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_ICS_ClassLibrary.EventHandling;
using WF_ICS_ClassLibrary.Models;
using WF_ICS_ClassLibrary.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wildfire_ICS_Assist
{
    public partial class OrganizationalChartForm : Form
    {
        private WFIncident CurrentIncident { get => Program.CurrentIncident; set => Program.CurrentIncident = value; }
        private int CurrentOpPeriod { get => Program.CurrentOpPeriod; set => Program.CurrentOpPeriod = value; }
        private OrganizationChart CurrentOrgChart { get => Program.CurrentIncident.allOrgCharts.FirstOrDefault(o => o.OpPeriod == Program.CurrentOpPeriod); }

        public OrganizationalChartForm()
        {
            this.Icon = Program.programIcon;
            InitializeComponent();
        }


        private void OrganizationalChartForm_Load(object sender, EventArgs e)
        {
            PopulateTree();
          

            Program.wfIncidentService.ICSRoleChanged += Program_ICSRoleChanged;
            Program.wfIncidentService.OrganizationalChartChanged += Program_OrgChartChanged;
        }

        private void Program_OrgChartChanged(OrganizationChartEventArgs e)
        {
            if (e.item.OpPeriod == Program.CurrentOpPeriod)
            {
                PopulateTree();
            }
        }
        private void Program_ICSRoleChanged(ICSRoleEventArgs e)
        {
            PopulateTree();
        }


        private void PopulateTree()
        {
            if (!Program.CurrentIncident.allOrgCharts.Any(o => o.OpPeriod == Program.CurrentOpPeriod))
            {
                Program.CurrentIncident.createOrgChartAsNeeded(Program.CurrentOpPeriod);
            }
            treeOrgChart.Nodes.Clear();
            // call recursive function
            AddCurrentChild(Guid.Empty, treeOrgChart.Nodes);

            if (treeOrgChart.Nodes.Count > 0)
            {
                treeOrgChart.Nodes[0].ExpandAll();
                treeOrgChart.SelectedNode = treeOrgChart.Nodes[0];
                if (treeOrgChart.SelectedNode != null) treeOrgChart.SelectedNode.EnsureVisible();

            }
        }

        private void AddCurrentChild(Guid parentId, TreeNodeCollection nodes)
        {
            var rows = CurrentOrgChart.AllRoles.Where(o => o.ReportsTo == parentId).ToList();

            foreach (var row in rows)
            {
                var roleID = row.RoleID;
                string name = row.RoleNameWithIndividual;

                var node = nodes.Add(roleID.ToString(), name);
                if (row.IndividualID == Guid.Empty) { node.NodeFont = GetNodeFont(true); }
                else { node.NodeFont = GetNodeFont(false); }
                node.Tag = row; // if you need to keep a row reference on the node
                AddCurrentChild(row.RoleID, node.Nodes);
            }
        }


        private Font GetNodeFont(bool italic)
        {
            if (italic)
            {
                System.Drawing.Font MyFont = new System.Drawing.Font(this.Font.FontFamily, 16, FontStyle.Italic, GraphicsUnit.Pixel);
                return MyFont;
            } else
            {
                System.Drawing.Font MyFont = new System.Drawing.Font(this.Font.FontFamily, 16,  GraphicsUnit.Pixel);
                return MyFont;
            }
        }

        private void treeOrgChart_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeOrgChart.SelectedNode != null)
            {
               ICSRole role =  (ICSRole)treeOrgChart.SelectedNode.Tag;
                if (OrgChartTools.ProtectedRoleIDs.Contains(role.RoleID))
                {
                    btnEditRole.Enabled = false;
                    btnDeleteRole.Enabled = false;
                }
                else
                {
                    btnEditRole.Enabled = true;
                    btnDeleteRole.Enabled = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ICSRole role = new ICSRole();
            role.OrganizationalChartID = CurrentOrgChart.OrganizationalChartID;
            role.OpPeriod = CurrentOrgChart.OpPeriod;
            openRoleForEdit(role);
        }

        private void openRoleForEdit(ICSRole role)
        {
            using (OrganizationChartAddRole addRoleForm = new OrganizationChartAddRole())
            {
                addRoleForm.selectedRole = role;
                DialogResult dr = addRoleForm.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    Program.wfIncidentService.UpsertICSRole(addRoleForm.selectedRole);
                }
            }
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            ICSRole role = (ICSRole)treeOrgChart.SelectedNode.Tag;
            openRoleForEdit(role);
        }
    }
}
