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
using TaskManagement.WorkModules;

namespace TaskManagement.RequestModules
{
    public partial class RequestListForm : Form
    {
        RequestBLL _requestBLL;
        ProjectBLL _projectBLL;
        RequestTypeBLL _requestTypeBLL;
        
        public RequestListForm()
        {
            InitializeComponent();
            _projectBLL = new ProjectBLL();
            _requestTypeBLL = new RequestTypeBLL();

        }
      

        private void RequestListForm_Load(object sender, EventArgs e)
        {

            cmbProject.SelectedIndex = -1;
            cmbProject.DataSource = _projectBLL.GetAll();
            cmbProject.ValueMember = "ID";
            cmbProject.DisplayMember = "ProjectName";
            cmbProject.SelectedValue = 0;           
            RequestList();
            cmbRequesttyp.SelectedIndex = -1;
            cmbRequesttyp.DataSource = _requestTypeBLL.GetAll();
            cmbRequesttyp.ValueMember = "ID";
            cmbRequesttyp.DisplayMember = "TypeName";
            cmbRequesttyp.SelectedValue = 0;
                
          
        }

        internal void RequestList()
        {
            _requestBLL = new RequestBLL();
            dgvRequest.DataSource = _requestBLL.RequstGetAll();

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestForm requestForm = new RequestForm();
            Request request = new Request();
            request.ID = (int)dgvRequest.SelectedRows[0].Cells["ID"].Value;
            request = _requestBLL.Get(request.ID);
            requestForm.MdiParent = this.MdiParent;
            requestForm._updateRequest = request;
            requestForm.Show();



        }

      private void Filter()
        {
            int project = ((int)cmbProject.SelectedIndex +1);
            int requesttyp = ((int)cmbRequesttyp.SelectedIndex + 1);


            if(cmbProject.SelectedValue !=null && cmbRequesttyp.SelectedValue !=null)
            {
                dgvRequest.DataSource = _requestBLL.RequestComboBox(requesttyp, project);
            }


        }

        private void cmbRequesttyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void işOlarakGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Request request = _requestBLL.Get((int)dgvRequest.SelectedRows[0].Cells["ID"].Value);
            WorkAddForm workAdd = new WorkAddForm();
            workAdd._newRequestToWork = request;
            workAdd.Show();
        }

        private void RequestListForm_Activated(object sender, EventArgs e)
        {
            RequestList();
        }
    }
}
