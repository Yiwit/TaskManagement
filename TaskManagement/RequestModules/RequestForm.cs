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

namespace TaskManagement.RequestModules
{
    public partial class RequestForm : Form
    {
        ProjectBLL _projectBLL;
        RequestTypeBLL _requestTypeBLL;
        RequestBLL _requestBLL;
        internal Request _updateRequest;

        public RequestForm()
        {
            InitializeComponent();
            _projectBLL = new ProjectBLL();
            _requestTypeBLL = new RequestTypeBLL();
            _requestBLL = new RequestBLL();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            cmbProject.DataSource = _projectBLL.GetAll();
            cmbProject.ValueMember = "ID";
            cmbProject.DisplayMember = "ProjectName";
            cmbRequestType.DataSource = _requestTypeBLL.GetAll();
            cmbRequestType.ValueMember = "ID";
            cmbRequestType.DisplayMember = "TypeName";
            txtEmployee.Text = MainForm._employee.FullName;



            if (_updateRequest != null)
            {
                txtEmployee.Text = MainForm._employee.FullName;
                cmbProject.SelectedValue = _updateRequest.ProjectID;
                cmbRequestType.SelectedValue = _updateRequest.RequestTypeID;
                txtRequstDetail.Text = _updateRequest.RequestDetail;
                btnRequest.Text = "Talebi Güncelle";

            }

        }




        private void btnRequest_Click(object sender, EventArgs e)
        {

            if  (txtRequstDetail.Text != string.Empty)
            {

                if (_updateRequest == null)
                {

                    Request request = new Request();
                    request.ProjectID = (int)cmbProject.SelectedValue;
                    request.RequestTypeID = (int)cmbRequestType.SelectedValue;
                    request.RequestDetail = txtRequstDetail.Text;
                    request.EmployeeID = MainForm._employee.ID;

                    if (_requestBLL.Add(request))
                    {
                        MessageBox.Show("Talep Gönderildi.");
                    }
                    else
                    {
                        MessageBox.Show("Talep Gönderme Başarısız.");
                    }
                }
                else
                {
                    _updateRequest.ProjectID = (int)cmbProject.SelectedValue;
                    _updateRequest.RequestTypeID = (int)cmbRequestType.SelectedValue;
                    _updateRequest.RequestDetail = txtRequstDetail.Text;
                    _updateRequest.EmployeeID = MainForm._employee.ID;

                    if (_requestBLL.Update(_updateRequest))
                    {
                        MessageBox.Show("Güncelleme Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Başarısız");
                    }

                }

            }

                else
                {
                    MessageBox.Show("Lütfen Açıklama Kısmını Boş Bırakmayınız");
                }






        }
    }
}
