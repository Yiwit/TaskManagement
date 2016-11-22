using _01_Entities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement.ProjectModules
{
    public partial class ProjectListForm : Form
    {
        ProjectBLL _proBLL;
        Project project = new Project();
        CustomerBLL _cusBLL = new CustomerBLL();
        WorkBLL _workBLL = new WorkBLL();
        public ProjectListForm()
        {
            InitializeComponent();
            _proBLL = new ProjectBLL();
            _workBLL = new WorkBLL();
        }
      
        private void ProjectListForm_Load(object sender, EventArgs e)
        {

            cmbCompanyName.SelectedIndex = -1;
            cmbCompanyName.DataSource = _cusBLL.GetAll();
            cmbCompanyName.DisplayMember = "CompanyName"; 
            cmbCompanyName.ValueMember = "ID";
            cmbCompanyName.SelectedValue = 0;
            ProjectList();
            
        }


        internal void ProjectList()
        {      
            dgvProjectList.DataSource = _proBLL.ProjectGetALL();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectAddForm projectAdd = new ProjectAddForm();
            Project project = new Project();
            project.ID = (int)dgvProjectList.SelectedRows[0].Cells["ID"].Value;
            project = _proBLL.Get(project.ID);
            projectAdd.MdiParent = this.MdiParent;
            projectAdd._updateProject = project;
            projectAdd.Show();

        }
        private void cmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompanyName.SelectedValue != null)
            {
                int companyID = ((Customer)cmbCompanyName.SelectedItem).ID;
                dgvProjectList.DataSource = _proBLL.CompanyNameSearch(companyID);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ProjectList();
        }

        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            bool rbtStart;
            if (rbtPlannedStart.Checked == true)
            {
                rbtStart = true;
            }
            else
            {
                rbtStart = false;
            }
            DateTime date = dtpSearchDate.Value.Date;
            dgvProjectList.DataSource = _proBLL.DateSearch(date, rbtStart);
        }

        private void projeKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            project.ID = (int)dgvProjectList.SelectedRows[0].Cells["ID"].Value;
            project = _proBLL.Get(project.ID);
            if (_workBLL.WorkControl(project.ID))
            {
                project.EndDate = _workBLL.GetEndDate(project.ID);
                if (_proBLL.Update(project))
                {
                    MessageBox.Show("Proje başarıyla kapatılmıştır");
                }
            }
            else
            {
                MessageBox.Show("Projede tamamlanmamış işler mevcut işler bitmeden proje kapatılamaz");
            }
        }
    }
}
