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
    public partial class EmployeeAddForm : Form
    {

        PositionBLL _posBLL;
        EmployeeBLL employeeBLL;
        EmployeeListForm _empList;
        Random rnd = new Random();

        Employee employee;
        internal Employee _updateEmployee;



        public EmployeeAddForm()
        {
            InitializeComponent();
            _posBLL = new PositionBLL();
            _empList = new EmployeeListForm();


            employeeBLL = new EmployeeBLL();
            employee = new Employee();
        }


        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {

            if (_updateEmployee != null)
            {
                txtFirstName.Text = _updateEmployee.FirstName;
                txtLastName.Text = _updateEmployee.LastName;
                cmbPosition.SelectedValue = _updateEmployee.PositionID;
                txtMail.Text = _updateEmployee.EMail;
                txtPassword.Text = _updateEmployee.Password;
                btnEmployeeAdd.Text = "Güncelle";
            }

            cmbPosition.DataSource = _posBLL.GetAll();
            cmbPosition.ValueMember = "ID";
            cmbPosition.DisplayMember = "PositionName";

        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty && txtMail.Text != string.Empty && txtPassword.Text != string.Empty)
            {

                if (_updateEmployee == null)
                {
                    int pass = rnd.Next(10000000, 99999999);

                    employee.FirstName = txtFirstName.Text;
                    employee.LastName = txtLastName.Text;
                    employee.PositionID = (int)cmbPosition.SelectedValue;
                    employee.EMail = txtMail.Text;
                    employee.Password = pass.ToString();
                    if (employeeBLL.Add(employee))
                    {
                        mail mail = new mail();
                        if (mail.SentMail(txtMail.Text,"Aramıza hoşgeldiniz",string.Format(
                            "Değerli çalışanımız : {0}\n\nBizimle olmanızdan dolayı mutluyuz\n\nSistemi kullanmak için bilgileriniz : \n\nMail Adres:{1}\nParola : {2}\n\n\n\nİyi Çalışmalar dileriz\n\nBlack Group"
                            ,employee.FullName,employee.EMail,employee.Password
                            )))
                        {
                            MessageBox.Show("Çalışan kaydı oluşturuldu bilgiler çalışan mail adresine gönderildi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Ekleme Başarısız");
                    }
                }
                else
                {
                    _updateEmployee.FirstName = txtFirstName.Text;
                    _updateEmployee.LastName = txtLastName.Text;
                    _updateEmployee.PositionID = (int)cmbPosition.SelectedValue;
                    _updateEmployee.EMail = txtMail.Text;
                    _updateEmployee.Password = txtPassword.Text;

                    if (employeeBLL.Update(_updateEmployee))
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
                if (item is EmployeeListForm)
                {
                    ((EmployeeListForm)item).EmployeeList();
                    item.BringToFront();
                    control = false;
                }
            }
            if (control)
            {
                EmployeeListForm employeeList = new EmployeeListForm();
                employeeList.MdiParent = MdiParent;
                employeeList.Show();
            }


            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }


        }
    }
}
