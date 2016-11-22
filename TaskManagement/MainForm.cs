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

namespace TaskManagement
{
    public partial class MainForm : Form
    {
        internal static Employee _employee;
        EmployeeBLL _employeeBLL;
        PositionBLL _positionBLL;
        public MainForm()
        {
            InitializeComponent();
            _employee = new Employee();
            _employeeBLL = new EmployeeBLL();
            _positionBLL = new PositionBLL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _employee = _employeeBLL.Get(txtMail.Text, txtPassword.Text);
            if (_employee!=null)
            {
                _employee.Position = _positionBLL.Get(_employee.PositionID);
                TaskManagementForm _task = new TaskManagementForm();
                TaskManagementForm._employee = _employee;
                _task.Show();
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            txtMail.Text = "yiğit@gmail.com";
            txtPassword.Text = "1234";
        }
    }
}
