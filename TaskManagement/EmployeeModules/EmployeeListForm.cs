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

namespace TaskManagement.EmployeeModules
{
    public partial class EmployeeListForm : Form
    {

        EmployeeBLL _empBLL;
        PositionBLL _posBLL = new PositionBLL();
        public EmployeeListForm()
        {
            InitializeComponent();
            _empBLL = new EmployeeBLL();
        }



        private void EmployeeListForm_Load(object sender, EventArgs e)
        {

            cmbPosition.SelectedIndex = -1;

            cmbPosition.DataSource = _posBLL.GetAll();
            cmbPosition.ValueMember = "ID";
            cmbPosition.DisplayMember = "PositionName";
            
            EmployeeList();

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAddForm employeeAdd = new EmployeeAddForm();
            Employee employee = new Employee();
            employee.ID = (int)dgvEmployeeList.SelectedRows[0].Cells["ID"].Value;
            employee = _empBLL.Get(employee.ID);

            employeeAdd.MdiParent = this.MdiParent;
            employeeAdd._updateEmployee = employee;
            employeeAdd.Show();
        }

        internal void EmployeeList()
        {
            dgvEmployeeList.DataSource = _empBLL.EmployeeGetAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            int position = (int)cmbPosition.SelectedValue;
            dgvEmployeeList.DataSource = _empBLL.ButtonFilter(firstName, position);
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            int position = ((int)cmbPosition.SelectedIndex + 1);



            if (cmbPosition.SelectedValue!=null)
            {
                dgvEmployeeList.DataSource = _empBLL.ComboBoxFilter(firstName, position); 
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
