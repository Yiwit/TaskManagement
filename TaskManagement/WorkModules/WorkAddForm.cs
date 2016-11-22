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
    public partial class WorkAddForm : Form
    {
        internal Request _newRequestToWork;
        EmployeeBLL _employeeBLL;
        ProjectBLL _projectBLL;
        Work _work;
        WorkBLL _workBLL;
        public WorkAddForm()
        {
            _employeeBLL = new EmployeeBLL();
            _projectBLL = new ProjectBLL();
            _work = new Work();
            _workBLL = new WorkBLL();
            InitializeComponent();
        }

        private void WorkAddForm_Load(object sender, EventArgs e)
        {

            ProjectList();
            txtMenagerName.Text = MainForm._employee.FullName;

            if (_newRequestToWork != null)
            {
                txtWorkDetail.Text = _newRequestToWork.RequestDetail;
                cmbProject.SelectedValue = (int)_newRequestToWork.ProjectID;
                cmbProject.Enabled = false;
            }
        }
        private void ProjectList()
        {
            cmbProject.DataSource = _projectBLL.GetAll();
            cmbProject.DisplayMember = "ProjectName";
            cmbProject.ValueMember = "ID";
            cmbProject.SelectedValue = 0;
        }
        int projectID = 0;
        private void EmployeeList()
        {
            cmbEmployee.DataSource = _employeeBLL.EmployeePositionGetAll(projectID);
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "ID";
            cmbEmployee.SelectedValue = 0;
        }

        private void btnCreatWork_Click(object sender, EventArgs e)
        {
            _work.WorkDetail = txtWorkDetail.Text;
            _work.ProjectID = (cmbProject.SelectedValue!=null)?(int)cmbProject.SelectedValue:0;
            if (cmbEmployee.SelectedValue != null)
                _work.EmployeeID = (int)cmbEmployee.SelectedValue;
            _work.ManagerID = MainForm._employee.ID;
            DateTime date = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day);
            _work.CreationDate = date;
            _work.WorkStatusID = 1;
            if (_workBLL.Add(_work))
            {
                mail mail = new mail();
                if (_work.EmployeeID!=null)
                {
                    _work.Employee = _employeeBLL.Get((int)cmbEmployee.SelectedValue);
                    if (mail.SentMail(_work.Employee.EMail,"Yeni Atanan iş",MainForm._employee.FullName+" tarafından size iş tanımlanmıştır. \n\n\nİyi çalışmalar dileriz. \n\nBlack Group :)"))
                    {
                        MessageBox.Show("İş oluşturuldu sistem çalışana mail gönderdi");
                        if (_newRequestToWork !=null)
                        {
                            _newRequestToWork.State = false;
                            RequestBLL requestBLL = new RequestBLL();
                            if (requestBLL.Update(_newRequestToWork))
                            {
                                this.Close();
                            }
                        }
                    } 
                }
                else
                {
                    MessageBox.Show("İş oluşturuldu işe çalışan atanmadı");
                }
            }
            else
            {
                MessageBox.Show("Hata meydana geldi");
            }

        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProject.SelectedItem!=null)
            {
                try
                {
                    projectID = (int)cmbProject.SelectedValue;
                }
                catch (Exception)
                {
                    projectID = 0;
                }
                EmployeeList(); 
            }
        }
    }
}
