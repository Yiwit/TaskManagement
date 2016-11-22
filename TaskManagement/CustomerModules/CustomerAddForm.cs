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
using TaskManagement.ProjectModules;

namespace TaskManagement.CustomerModules
{
    public partial class CustomerAddForm : Form
    {
        Customer customer;
        internal Customer _updateCustomer;
        CustomerBLL customerBLL;
        ProjectAddForm projectAdd;
        public CustomerAddForm()
        {
            InitializeComponent();
            customer = new Customer();
            customerBLL = new CustomerBLL();

        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (_updateCustomer==null)
            {
                customer.CompanyName = txtCompanyName.Text;
                customer.ContactName = txtContactName.Text;
                customer.CustomerEmail = txtEmail.Text;
                if (customerBLL.Add(customer))
                {
                    MessageBox.Show("Müşteri Ekleme Başarılı");
                    
                }
                else
                { 
                    MessageBox.Show("Müşteri Ekleme Başarısız");
                }
            }
            else
            {
                _updateCustomer.CompanyName = txtCompanyName.Text;
                _updateCustomer.ContactName = txtContactName.Text;
                _updateCustomer.CustomerEmail = txtEmail.Text;
                if (customerBLL.Update(_updateCustomer))
                {
                    MessageBox.Show("Güncelleme başarılı");
                    
                   
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız");
                }
            }
            bool control = true;
            foreach (var item in MdiParent.MdiChildren)
            {
                if (item is CustomerListForm)
                {
                    ((CustomerListForm)item).CustomerList();
                    item.BringToFront();
                    control = false;
                }
            }
            if (control)
            {
                CustomerListForm customerList = new CustomerListForm();
                customerList.MdiParent = MdiParent;
                customerList.Show();
            }
        }

        private void CustomerAddForm_Load(object sender, EventArgs e)
        {
            if (_updateCustomer!=null)
            {
                txtCompanyName.Text = _updateCustomer.CompanyName;
                txtContactName.Text = _updateCustomer.ContactName;
                txtEmail.Text = _updateCustomer.CustomerEmail;
                btnCustomerAdd.Text = "Güncelle";
            }
        }
    }
}
