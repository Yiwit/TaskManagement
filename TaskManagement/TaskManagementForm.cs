using _01_Entities;
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
using TaskManagement.EmployeeModules;
using TaskManagement.ProjectModules;
using TaskManagement.RequestModules;
using TaskManagement.SecurityModules;
using TaskManagement.WorkModules;

namespace TaskManagement
{
    public partial class TaskManagementForm : Form
    {
        internal static Employee _employee;
        public TaskManagementForm()
        {
            InitializeComponent();
            _employee = new Employee();
        }
        ProjectAddForm paf;
        ProjectListForm plf;
        CustomerAddForm caf;
        CustomerListForm clf;
        EmployeeAddForm eaf;
        EmployeeListForm elf;
        WorkAddForm waf;
        WorkListForm wlf;
        RequestForm raf;
        RequestListForm rlf;
        PasswordChangeForm pcf;



        private void projeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is ProjectAddForm)
                {
                    isOpen = true;
                }
            }

            if (isOpen == true)
            {
                paf.BringToFront();
            }
            else
            {
                paf = new ProjectAddForm();
                paf.MdiParent = this;
                paf.Show();
            }



        }

        private void menuProjectList_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is ProjectListForm)
                {
                    isOpen = true;
                }
            }

            if (isOpen == true)
            {
                plf.BringToFront();
            }
            else
            {
                plf = new ProjectListForm();
                plf.MdiParent = this;
                plf.Show();
            }
        }

        private void TaskManagementForm_Load(object sender, EventArgs e)
        {
            PanelControl();
        }

        private void PanelControl()
        {
            if (MainForm._employee.Position != null)
            {
                if (MainForm._employee.PositionID == 1)
                {
                    menuProjectManagement.Visible =
                        müşteriYönerimiToolStripMenuItem.Visible =
                        menuEmployeeManagement.Visible =
                        menuWorkManagement.Visible = true;
                    menuNewWork.Visible = false;
                }
                else if (MainForm._employee.PositionID == 2)
                {
                    menuWorkManagement.Visible =
                    menuRequestManagement.Visible = true;

                }
                else if (MainForm._employee.PositionID == 3)
                {
                    menuWorkManagement.Visible = 
                    menuRequestManagement.Visible = true;
                }
                else if (MainForm._employee.PositionID == 4)
                {
                    menuWorkManagement.Visible = true;
                }
                else if (MainForm._employee.PositionID == 5)
                {
                    menuWorkManagement.Visible = true;
                }
            }
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is CustomerAddForm)
                {
                    isOpen = true;
                }
            }

            if (isOpen == true)
            {
                caf.BringToFront();
            }
            else
            {
                caf = new CustomerAddForm();
                caf.MdiParent = this;
                caf.Show();
            }
        }

        private void menuAddEmployee_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is EmployeeAddForm)
                {
                    isOpen = true;
                }
            }

            if (isOpen == true)
            {
                eaf.BringToFront();
            }
            else
            {
                eaf = new EmployeeAddForm();
                eaf.MdiParent = this;
                eaf.Show();
            }
        }

        private void menuEmployeeList_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is EmployeeListForm)
                {
                    isOpen = true;
                }
            }

            if (isOpen == true)
            {
                elf.BringToFront();
            }
            else
            {
                elf = new EmployeeListForm();
                elf.MdiParent = this;
                elf.Show();
            }
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is PasswordChangeForm)
                {
                    isOpen = true;
                }
            }

            if (isOpen == true)
            {
                pcf.BringToFront();
            }
            else
            {
                pcf = new PasswordChangeForm();
                pcf.MdiParent = this;
                pcf.Show();
            }
        }

        private void müşterileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is CustomerListForm)
                {
                    isOpen = true;
                }
            }

            if (isOpen == true)
            {
                clf.BringToFront();
            }
            else
            {
                clf = new CustomerListForm();
                clf.MdiParent = this;
                clf.Show();
            }

        }

        private void talepEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is RequestForm)
                {
                    isOpen = true;
                }
            }

            if (isOpen == true)
            {
                raf.BringToFront();
            }
            else
            {
                raf = new RequestForm();
                raf.MdiParent = this;
                raf.Show();
            }
        }

        private void taleplerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is RequestListForm)
                {
                    isOpen = true;
                }
            }

            if (isOpen == true)
            {
                rlf.BringToFront();
            }
            else
            {
                rlf = new RequestListForm();
                rlf.MdiParent = this;
                rlf.Show();
            }
        }

        private void menuNewWork_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is WorkAddForm)
                {
                    isOpen = true;
                }
            }

            if (isOpen == true)
            {
                waf.BringToFront();
            }
            else
            {
                waf = new WorkAddForm();
                waf.MdiParent = this;
                waf.Show();
            }
        }

        private void menıListWork_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is WorkListForm)
                {
                    isOpen = true;
                }
            }

            if (isOpen == true)
            {
                wlf.BringToFront();
            }
            else
            {
                wlf = new WorkListForm();
                wlf.MdiParent = this;
                wlf.Show();
            }
        }

        private void menuSettings_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
        }
    }
}
