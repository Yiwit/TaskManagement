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
using TaskManagement.CustomerModules;

namespace TaskManagement.ProjectModules
{
    public partial class ProjectAddForm : Form
    {
        CustomerBLL customerBLL;
        ProjectBLL _projectBLL;
        Project project;
        EmployeeBLL _employeeBLL;
        PositionBLL _positionBLL;
        ProjectEmployeeBLL _peBLL;

        internal Project _updateProject;
        public ProjectAddForm()
        {
            InitializeComponent();
            customerBLL = new CustomerBLL();
            _projectBLL = new ProjectBLL();
            project = new Project();
            _employeeBLL = new EmployeeBLL();
            _positionBLL = new PositionBLL();
            _peBLL = new ProjectEmployeeBLL();
        }

        private void ProjectAddForm_Load(object sender, EventArgs e)
        {
            cmbCompanyName.DataSource = customerBLL.GetAll();
            cmbCompanyName.DisplayMember = "CompanyName";
            cmbCompanyName.ValueMember = "ID";
            txtMenagemerName.Text = MainForm._employee.FullName;


            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList = _employeeBLL.GetAll();
            foreach (Employee employee in EmployeeList)
            {
                if (employee.PositionID != 1)
                {
                    ListViewItem item = new ListViewItem();
                    employee.Position = _positionBLL.Get(employee.PositionID);
                    item.Tag = employee;
                    item.Text = employee.FirstName;
                    item.SubItems.Add(employee.LastName);
                    item.SubItems.Add(employee.Position.PositionName);
                    lViewEmployeeList.Items.Add(item);
                }
            }
            if (_updateProject != null)
            {
                txtProjectName.Text = _updateProject.ProjectName;
                txtProjectDetail.Text = _updateProject.ProjectDetail;
                MainForm._employee.ID = _updateProject.ManagerID;
                cmbCompanyName.SelectedValue = _updateProject.CustomerID;
                dtpPlannedStart.Value = _updateProject.PlannedStartDate;
                dtpPlannedFinish.Value = _updateProject.PlannedEndDate;
                btnProjectCreate.Text = "Projeyi Güncelle";
                List<Employee> EmployeeListt = new List<Employee>();
                EmployeeListt = _employeeBLL.ProjectEmployeeGet(_updateProject.ID);
                foreach (Employee employee in EmployeeListt)
                {
                    foreach (ListViewItem item in lViewEmployeeList.Items)
                    {
                        if (item.Tag==employee)
                        {
                            lViewEployeeAdd(item);
                        }
                    }
                }
            }

        }



        private void btnProjectCreate_Click(object sender, EventArgs e)
        {
            if (_updateProject == null)
            {
                if (lViewAddEmployeeList.Items.Count == 5)
                {
                    project.ProjectName = txtProjectName.Text;
                    project.ProjectDetail = txtProjectDetail.Text;
                    project.ManagerID = MainForm._employee.ID;
                    project.CustomerID = (int)cmbCompanyName.SelectedValue;
                    project.PlannedStartDate = dtpPlannedStart.Value;
                    project.PlannedEndDate = dtpPlannedFinish.Value;
                    int projectID;
                    if (_projectBLL.Add(project, out projectID))
                    {
                        MessageBox.Show("Proje Başarıyla Eklendi.");
                        if (projectID > 0)
                        {
                            foreach (ListViewItem item in lViewAddEmployeeList.Items)
                            {
                                ProjectEmployee pe = new ProjectEmployee();
                                pe.EmployeeID = ((Employee)item.Tag).ID;
                                pe.ProjectID = projectID;
                                _peBLL.Add(pe);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Proje Ekleme Başarısız.");
                }
                else
                {
                    MessageBox.Show("Proje için 5 çalışan seçmeniz gerekiyor");
                }
            }
            else
            {
                _updateProject.ProjectName = txtProjectName.Text;
                _updateProject.ProjectDetail = txtProjectDetail.Text;
                _updateProject.ManagerID = MainForm._employee.ID;
                _updateProject.CustomerID = (int)cmbCompanyName.SelectedValue;
                _updateProject.PlannedStartDate = dtpPlannedStart.Value;
                _updateProject.PlannedEndDate = dtpPlannedFinish.Value;

                if (_projectBLL.Update(_updateProject))
                {
                    MessageBox.Show("Güncelleme Başarılı");
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarısız");
                }

            }
            bool control = true;
            foreach (var item in MdiParent.MdiChildren)
            {
                if (item is ProjectListForm)
                {
                    ((ProjectListForm)item).ProjectList();
                    item.BringToFront();
                    control = false;
                }
            }
            if (control)
            {
                ProjectListForm projectList = new ProjectListForm();
                projectList.MdiParent = MdiParent;
                projectList.Show();
            }

        }



        private void btnCustomerAdd_Click_1(object sender, EventArgs e)
        {
            CustomerAddForm customerAddForm = new CustomerAddForm();
            customerAddForm.MdiParent = this.MdiParent;
            customerAddForm.Show();
        }

        int developmentCount = 0;
        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            if (lViewEmployeeList.SelectedItems.Count > 0 && lViewEmployeeList.SelectedItems.Count < 6)
            {
                if (lViewAddEmployeeList.Items.Count < 5)
                {

                    foreach (ListViewItem item in lViewEmployeeList.SelectedItems)
                    {
                        lViewEployeeAdd(item);
                    }
                }
                else
                    MessageBox.Show("Projenin çalışan sayısı dolmuştur");
            }
            else
                MessageBox.Show("çok fazla çalışan seçtiniz");
        }

        private void lViewEployeeAdd(ListViewItem item)
        {
            bool control = true;
            foreach (ListViewItem itemControl in lViewAddEmployeeList.Items)
            {
                if ((((Employee)item.Tag).PositionID == 5) ? developmentCount > 1 : ((Employee)item.Tag).PositionID == ((Employee)itemControl.Tag).PositionID)
                {
                    control = false;
                    break;
                }
            }
            if (control)
            {
                if (((Employee)item.Tag).PositionID == 5)
                    developmentCount++;
                ListViewItem tempItem = new ListViewItem();
                tempItem = item;
                lViewEmployeeList.Items.Remove(item);
                lViewAddEmployeeList.Items.Add(tempItem);
            }
            else
                MessageBox.Show(((Employee)item.Tag).Position.PositionName + " pozisyonunda çalışanınız mevcut");

        }

        private void btnEmployeeRemove_Click(object sender, EventArgs e)
        {
            if (lViewAddEmployeeList.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lViewAddEmployeeList.SelectedItems)
                {
                    if (((Employee)item.Tag).PositionID == 5)
                    {
                        developmentCount--;
                    }
                    ListViewItem tempItem = new ListViewItem();
                    tempItem = item;
                    lViewAddEmployeeList.Items.Remove(item);
                    lViewEmployeeList.Items.Add(tempItem);
                }
            }
        }
    }
}
