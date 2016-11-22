using _01_Entities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement.WorkModules
{
    public partial class WorkListForm : Form
    {
        EmployeeBLL _employeeBLL;
        WorkBLL _workBLL;
        int workState = 0;
        int updateWorkState = 0;
        WorkStatusBLL _workStatusBLL;
        ProjectBLL _projectBLL;
        Work work;
        public WorkListForm()
        {
            work = new Work();
            _employeeBLL = new EmployeeBLL();
            _workBLL = new WorkBLL();
            InitializeComponent();
            _workStatusBLL = new WorkStatusBLL();
            _projectBLL = new ProjectBLL();
        }

        private void WorkListForm_Load(object sender, EventArgs e)
        {
            WorkStatusList();
            if (MainForm._employee.PositionID == 1 || MainForm._employee.PositionID == 2)
            {
                WorkList();
                dgvWork.ContextMenuStrip = null;
                panel1.Visible = false;
                panel2.Visible = false;
            }
            else if (MainForm._employee.PositionID == 3)
            {
                workState = 2;
                updateWorkState = 6;
                EmployeeWorkList();
            }
            else if (MainForm._employee.PositionID == 4)
            {
                workState = 3;
                updateWorkState = 4;
                EmployeeWorkList();
            }
            else if (MainForm._employee.PositionID == 5)
            {
                workState = 4;
                updateWorkState = 2;
                EmployeeWorkList();
            }
            if (MainForm._employee.PositionID == 2)
            {
                updateWorkState = 3;
                dgvWork.ContextMenuStrip = contextMenuStrip1;
                panel1.Visible = true;
                contextMenuStrip1.Visible = true;
            }
        }

        private void StatusAdd()
        {
        }

        private void WorkStatusList()
        {
            cmbWorkStatus.DataSource = _workStatusBLL.GetAll();
            cmbWorkStatus.DisplayMember = "StatusName";
            cmbWorkStatus.ValueMember = "ID";
        }

        private void EmployeeWorkList()
        {
            dgvWork.DataSource = _workBLL.EmployeeWorkList(MainForm._employee.ID, workState);
        }

        private void WorkList()
        {
            dgvWork.DataSource = _workBLL.WorkGetAll();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeWorkList();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dgvWork.DataSource = _workBLL.ContinueWork(MainForm._employee.ID, workState);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dgvWork.DataSource = _workBLL.NotStartedWork(MainForm._employee.ID, workState);
        }

        private void işiÜzerineAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            work.ID = (int)dgvWork.SelectedRows[0].Cells["ID"].Value;
            work = _workBLL.Get(work.ID);
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (work.StartDate == new DateTime(0001, 01, 01))
            {
                work.StartDate = date;
            }
            work.WorkStatusID = 7;
            if (_workBLL.Update(work))
            {
                MessageBox.Show("İş tarafınızca başlatılmıştır");
                Project project = new Project();
                project = _projectBLL.Get(work.ProjectID);
                if (project.StartDate == null)
                {
                    project.StartDate = work.StartDate;
                    _projectBLL.Update(project);
                }
            }
        }
        private void işiYönlendirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            work.ID = (int)dgvWork.SelectedRows[0].Cells["ID"].Value;
            work = _workBLL.Get(work.ID);
            Project project = _projectBLL.Get(work.ProjectID);
            cmbEmployeeProject.DataSource = _employeeBLL.EmployeePositionGetAll(project.ID);
            cmbEmployeeProject.DisplayMember = "FullName";
            cmbEmployeeProject.ValueMember = "ID";
            panel3.Visible = true;
        }
        
        ForwardToWorkEmployee ftwe = new ForwardToWorkEmployee();
        private void çalışanYönlendirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            work.ID = (int)dgvWork.SelectedRows[0].Cells["ID"].Value;
            work = _workBLL.Get(work.ID);
            ftwe.work = work;
            ftwe.ShowDialog();
        }

      

        private void btnForward_Click(object sender, EventArgs e)
        {
            work.EmployeeID = (int)cmbEmployeeProject.SelectedValue;
            work.WorkStatusID = updateWorkState;
            if (_workBLL.Update(work))
            {
                MessageBox.Show("İş yönlendirildi");
            }
            panel3.Visible = false;
        }
    }
}