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

namespace TaskManagement.SecurityModules
{
    public partial class PasswordChangeForm : Form
    {
        EmployeeBLL _employeeBLL = new EmployeeBLL();
        public PasswordChangeForm()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == MainForm._employee.Password && txtNewPassword.Text == txtNewPasswordAgain.Text)
            {
                MainForm._employee.Password = txtNewPassword.Text;
                if (_employeeBLL.Update(MainForm._employee))
                {
                    mail mail = new mail();
                    if (mail.SentMail(
                                       MainForm._employee.EMail, "Şifre Güncelleme", string.Format(
                                           "Sayın : {0}\nSisteme yeni giriş bilgileriniz aşşağıda verilmiştir. \n\nŞifreniz: {1}\n\n\nİyi Çalışmalar...\n\n\nBlack Group"
                                           , MainForm._employee.FullName, txtNewPassword.Text
                                           )))
                    {
                        MessageBox.Show("Şifreniz güncellenmiştir. \nBilgileriniz mail adresinize gönderildi");
                    }
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu");
                }
            }
            else
            {
                MessageBox.Show("Eski şifrenizi doğru birşekilde giriniz veya Girilen şifreler eşleşmiyor");
            }
        }

        private void PasswordChangeForm_Load(object sender, EventArgs e)
        {
            txtUserControl.Text = MainForm._employee.FullName;
           
        }
    }
}
