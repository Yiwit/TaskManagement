namespace TaskManagement
{
    partial class TaskManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuProjectManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProjectAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProjectList = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriYönerimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterileriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployeeManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployeeList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWorkManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewWork = new System.Windows.Forms.ToolStripMenuItem();
            this.menıListWork = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRequestManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.talepEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taleplerListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSecuritySections = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProjectManagement,
            this.müşteriYönerimiToolStripMenuItem,
            this.menuEmployeeManagement,
            this.menuWorkManagement,
            this.menuRequestManagement,
            this.menuSecuritySections,
            this.menuSettings,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuProjectManagement
            // 
            this.menuProjectManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProjectAdd,
            this.menuProjectList});
            this.menuProjectManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuProjectManagement.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuProjectManagement.Name = "menuProjectManagement";
            this.menuProjectManagement.Size = new System.Drawing.Size(108, 21);
            this.menuProjectManagement.Text = "Proje Yönetimi";
            this.menuProjectManagement.Visible = false;
            // 
            // menuProjectAdd
            // 
            this.menuProjectAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuProjectAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuProjectAdd.Name = "menuProjectAdd";
            this.menuProjectAdd.Size = new System.Drawing.Size(152, 22);
            this.menuProjectAdd.Text = "Proje Ekle";
            this.menuProjectAdd.Click += new System.EventHandler(this.projeEkleToolStripMenuItem_Click);
            // 
            // menuProjectList
            // 
            this.menuProjectList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuProjectList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuProjectList.Name = "menuProjectList";
            this.menuProjectList.Size = new System.Drawing.Size(152, 22);
            this.menuProjectList.Text = "Proje Listele";
            this.menuProjectList.Click += new System.EventHandler(this.menuProjectList_Click);
            // 
            // müşteriYönerimiToolStripMenuItem
            // 
            this.müşteriYönerimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşterileriListeleToolStripMenuItem});
            this.müşteriYönerimiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriYönerimiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.müşteriYönerimiToolStripMenuItem.Name = "müşteriYönerimiToolStripMenuItem";
            this.müşteriYönerimiToolStripMenuItem.Size = new System.Drawing.Size(123, 21);
            this.müşteriYönerimiToolStripMenuItem.Text = "Müşteri Yönerimi";
            this.müşteriYönerimiToolStripMenuItem.Visible = false;
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriEkleToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // müşterileriListeleToolStripMenuItem
            // 
            this.müşterileriListeleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşterileriListeleToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.müşterileriListeleToolStripMenuItem.Name = "müşterileriListeleToolStripMenuItem";
            this.müşterileriListeleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.müşterileriListeleToolStripMenuItem.Text = "Müşterileri Listele";
            this.müşterileriListeleToolStripMenuItem.Click += new System.EventHandler(this.müşterileriListeleToolStripMenuItem_Click);
            // 
            // menuEmployeeManagement
            // 
            this.menuEmployeeManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddEmployee,
            this.menuEmployeeList});
            this.menuEmployeeManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuEmployeeManagement.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuEmployeeManagement.Name = "menuEmployeeManagement";
            this.menuEmployeeManagement.Size = new System.Drawing.Size(119, 21);
            this.menuEmployeeManagement.Text = "Çalışan Yönetimi";
            this.menuEmployeeManagement.Visible = false;
            // 
            // menuAddEmployee
            // 
            this.menuAddEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuAddEmployee.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuAddEmployee.Name = "menuAddEmployee";
            this.menuAddEmployee.Size = new System.Drawing.Size(173, 22);
            this.menuAddEmployee.Text = "Çalışan Ekle";
            this.menuAddEmployee.Click += new System.EventHandler(this.menuAddEmployee_Click);
            // 
            // menuEmployeeList
            // 
            this.menuEmployeeList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuEmployeeList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuEmployeeList.Name = "menuEmployeeList";
            this.menuEmployeeList.Size = new System.Drawing.Size(173, 22);
            this.menuEmployeeList.Text = "Çalışanlar Listesi";
            this.menuEmployeeList.Click += new System.EventHandler(this.menuEmployeeList_Click);
            // 
            // menuWorkManagement
            // 
            this.menuWorkManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewWork,
            this.menıListWork});
            this.menuWorkManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuWorkManagement.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuWorkManagement.Name = "menuWorkManagement";
            this.menuWorkManagement.Size = new System.Drawing.Size(87, 21);
            this.menuWorkManagement.Text = "İş Yönetimi";
            this.menuWorkManagement.Visible = false;
            // 
            // menuNewWork
            // 
            this.menuNewWork.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuNewWork.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuNewWork.Name = "menuNewWork";
            this.menuNewWork.Size = new System.Drawing.Size(135, 22);
            this.menuNewWork.Text = "İş Oluştur";
            this.menuNewWork.Click += new System.EventHandler(this.menuNewWork_Click);
            // 
            // menıListWork
            // 
            this.menıListWork.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menıListWork.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menıListWork.Name = "menıListWork";
            this.menıListWork.Size = new System.Drawing.Size(135, 22);
            this.menıListWork.Text = "İş Listesi";
            this.menıListWork.Click += new System.EventHandler(this.menıListWork_Click);
            // 
            // menuRequestManagement
            // 
            this.menuRequestManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.talepEkleToolStripMenuItem,
            this.taleplerListesiToolStripMenuItem});
            this.menuRequestManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuRequestManagement.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuRequestManagement.Name = "menuRequestManagement";
            this.menuRequestManagement.Size = new System.Drawing.Size(108, 21);
            this.menuRequestManagement.Text = "Talep Yönetimi";
            this.menuRequestManagement.Visible = false;
            // 
            // talepEkleToolStripMenuItem
            // 
            this.talepEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talepEkleToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.talepEkleToolStripMenuItem.Name = "talepEkleToolStripMenuItem";
            this.talepEkleToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.talepEkleToolStripMenuItem.Text = "Talep Ekle";
            this.talepEkleToolStripMenuItem.Click += new System.EventHandler(this.talepEkleToolStripMenuItem_Click);
            // 
            // taleplerListesiToolStripMenuItem
            // 
            this.taleplerListesiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.taleplerListesiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.taleplerListesiToolStripMenuItem.Name = "taleplerListesiToolStripMenuItem";
            this.taleplerListesiToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.taleplerListesiToolStripMenuItem.Text = "Talepler Listesi";
            this.taleplerListesiToolStripMenuItem.Click += new System.EventHandler(this.taleplerListesiToolStripMenuItem_Click);
            // 
            // menuSecuritySections
            // 
            this.menuSecuritySections.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreDeğiştirToolStripMenuItem});
            this.menuSecuritySections.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuSecuritySections.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuSecuritySections.Name = "menuSecuritySections";
            this.menuSecuritySections.Size = new System.Drawing.Size(126, 21);
            this.menuSecuritySections.Text = "Güvenlik İşlemleri";
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şifreDeğiştirToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            this.şifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğiştirToolStripMenuItem_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuSettings.ForeColor = System.Drawing.Color.Red;
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(104, 21);
            this.menuSettings.Text = "Herşeyi Kapat";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // menuExit
            // 
            this.menuExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuExit.ForeColor = System.Drawing.Color.Maroon;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(51, 21);
            this.menuExit.Text = "ÇIKIŞ";
            // 
            // TaskManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(925, 467);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TaskManagementForm";
            this.Text = "İŞ YÖNETİMİ FORMU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TaskManagementForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuProjectManagement;
        private System.Windows.Forms.ToolStripMenuItem menuProjectAdd;
        private System.Windows.Forms.ToolStripMenuItem menuProjectList;
        private System.Windows.Forms.ToolStripMenuItem menuEmployeeManagement;
        private System.Windows.Forms.ToolStripMenuItem menuAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem menuEmployeeList;
        private System.Windows.Forms.ToolStripMenuItem menuWorkManagement;
        private System.Windows.Forms.ToolStripMenuItem menuRequestManagement;
        private System.Windows.Forms.ToolStripMenuItem menuSecuritySections;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripMenuItem müşteriYönerimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterileriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talepEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taleplerListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNewWork;
        private System.Windows.Forms.ToolStripMenuItem menıListWork;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
    }
}