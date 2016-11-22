namespace TaskManagement.WorkModules
{
    partial class WorkListForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnForward = new System.Windows.Forms.Button();
            this.cmbEmployeeProject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbWorkStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWork = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çalışanYönlendirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işiÜzerineAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işiYönlendirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvWork);
            this.splitContainer1.Size = new System.Drawing.Size(761, 368);
            this.splitContainer1.SplitterDistance = 85;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(3, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 68);
            this.panel2.TabIndex = 5;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 48);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(107, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Başlanmamış işler";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Devam eden işler";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bütün İşler";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnForward);
            this.panel3.Controls.Add(this.cmbEmployeeProject);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(456, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 68);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForward.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnForward.Location = new System.Drawing.Point(172, 12);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(97, 44);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "Yönlendir";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // cmbEmployeeProject
            // 
            this.cmbEmployeeProject.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbEmployeeProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEmployeeProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbEmployeeProject.FormattingEnabled = true;
            this.cmbEmployeeProject.Location = new System.Drawing.Point(14, 31);
            this.cmbEmployeeProject.Name = "cmbEmployeeProject";
            this.cmbEmployeeProject.Size = new System.Drawing.Size(152, 25);
            this.cmbEmployeeProject.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(72, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Çalışan Seçiniz";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbWorkStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(153, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 68);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(172, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "İş Durumu Değiştir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cmbWorkStatus
            // 
            this.cmbWorkStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbWorkStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWorkStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbWorkStatus.FormattingEnabled = true;
            this.cmbWorkStatus.Location = new System.Drawing.Point(14, 31);
            this.cmbWorkStatus.Name = "cmbWorkStatus";
            this.cmbWorkStatus.Size = new System.Drawing.Size(152, 25);
            this.cmbWorkStatus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(94, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İş Durumu";
            // 
            // dgvWork
            // 
            this.dgvWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWork.Location = new System.Drawing.Point(0, 0);
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.Size = new System.Drawing.Size(761, 279);
            this.dgvWork.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanYönlendirToolStripMenuItem,
            this.işiÜzerineAlToolStripMenuItem,
            this.işiYönlendirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 70);
            // 
            // çalışanYönlendirToolStripMenuItem
            // 
            this.çalışanYönlendirToolStripMenuItem.Name = "çalışanYönlendirToolStripMenuItem";
            this.çalışanYönlendirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.çalışanYönlendirToolStripMenuItem.Text = "Çalışan Yönlendir";
            this.çalışanYönlendirToolStripMenuItem.Click += new System.EventHandler(this.çalışanYönlendirToolStripMenuItem_Click);
            // 
            // işiÜzerineAlToolStripMenuItem
            // 
            this.işiÜzerineAlToolStripMenuItem.Name = "işiÜzerineAlToolStripMenuItem";
            this.işiÜzerineAlToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.işiÜzerineAlToolStripMenuItem.Text = "İşi Başlat";
            this.işiÜzerineAlToolStripMenuItem.Click += new System.EventHandler(this.işiÜzerineAlToolStripMenuItem_Click);
            // 
            // işiYönlendirToolStripMenuItem
            // 
            this.işiYönlendirToolStripMenuItem.Name = "işiYönlendirToolStripMenuItem";
            this.işiYönlendirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.işiYönlendirToolStripMenuItem.Text = "İşi Yönlendir";
            this.işiYönlendirToolStripMenuItem.Click += new System.EventHandler(this.işiYönlendirToolStripMenuItem_Click);
            // 
            // WorkListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(761, 368);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(777, 406);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(777, 406);
            this.Name = "WorkListForm";
            this.Text = "İŞ LİSTELEME FORMU";
            this.Load += new System.EventHandler(this.WorkListForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çalışanYönlendirToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbWorkStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem işiÜzerineAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işiYönlendirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.ComboBox cmbEmployeeProject;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvWork;
    }
}