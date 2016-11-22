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
    public partial class ForwardToWorkEmployee : Form
    {
        internal Work work;
        WorkBLL _workBLL;
        EmployeeBLL _employeeBLL;
        WorkListForm wlf;

        public ForwardToWorkEmployee()
        {
            work = new Work();
            _workBLL = new WorkBLL();
            _employeeBLL = new EmployeeBLL();

            InitializeComponent();
        }
        private void ForwardToWorkEmployee_Load(object sender, EventArgs e)
        {
            cmb.DataSource = _employeeBLL.EmployeePositionGetAll(work.ProjectID);
            cmb.DisplayMember = "FullName";
            cmb.ValueMember = "ID";
            cmb.SelectedValue = 0;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            work.EmployeeID = (int)cmb.SelectedValue;
            if (_workBLL.Update(work))
            {
                MessageBox.Show("İş Çalışana yönlendirilmiştir");
                this.Close();
                WorkList();
            }
        }
        private void WorkList()
        {
            wlf = new WorkListForm();
            wlf.dgvWork.DataSource = _workBLL.WorkGetAll();
        }

       
    
    }
}
