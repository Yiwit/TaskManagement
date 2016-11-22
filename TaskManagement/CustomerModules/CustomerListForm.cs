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

namespace TaskManagement.CustomerModules
{
    public partial class CustomerListForm : Form
    {
        CustomerBLL _cusBLL;
        public CustomerListForm()
        {
            InitializeComponent();
            _cusBLL = new CustomerBLL();
        }


        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            cmbCompanyName.DataSource = _cusBLL.GetAll();
            cmbCompanyName.DisplayMember = "CompanyName";
            cmbCompanyName.ValueMember = "ID";
            cmbCompanyName.SelectedValue = 0;
            CustomerList();
            
        }
        
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerAddForm customerAdd = new CustomerAddForm();
            Customer customer = new Customer();
            customer.ID = (int)dgvCustomerList.SelectedRows[0].Cells["ID"].Value;
            customer = _cusBLL.Get(customer.ID);
            customerAdd.MdiParent = this.MdiParent;
            customerAdd._updateCustomer = customer;
            customerAdd.Show();
        }

        internal void CustomerList()
        {
            dgvCustomerList.DataSource = _cusBLL.WorkGetAll();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            CustomerList();       
        }

        private void cmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompanyName.SelectedValue!=null)
            {
                int companyID = ((Customer)cmbCompanyName.SelectedItem).ID;
                dgvCustomerList.DataSource = _cusBLL.ProjectFilter(companyID); 
            }
        }

        

        

        
    }
}
