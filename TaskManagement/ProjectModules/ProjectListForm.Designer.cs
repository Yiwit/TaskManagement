namespace TaskManagement.ProjectModules
{
    partial class ProjectListForm
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
            this.contextProjectUpdate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.rbtPlanedEnd = new System.Windows.Forms.RadioButton();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.rbtPlannedStart = new System.Windows.Forms.RadioButton();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.dgvProjectList = new System.Windows.Forms.DataGridView();
            this.projeKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextProjectUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // contextProjectUpdate
            // 
            this.contextProjectUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.projeKapatToolStripMenuItem});
            this.contextProjectUpdate.Name = "contextProjectUpdate";
            this.contextProjectUpdate.Size = new System.Drawing.Size(153, 70);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.btnAll);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCompanyName);
            this.splitContainer1.Panel1.Controls.Add(this.rbtPlanedEnd);
            this.splitContainer1.Panel1.Controls.Add(this.btnDateSearch);
            this.splitContainer1.Panel1.Controls.Add(this.rbtPlannedStart);
            this.splitContainer1.Panel1.Controls.Add(this.dtpSearchDate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvProjectList);
            this.splitContainer1.Size = new System.Drawing.Size(761, 367);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAll.Location = new System.Drawing.Point(178, 22);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(82, 54);
            this.btnAll.TabIndex = 16;
            this.btnAll.Text = "Hepsini Getir";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Firmaya Göre Getir";
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCompanyName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(42, 48);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(121, 25);
            this.cmbCompanyName.TabIndex = 14;
            this.cmbCompanyName.SelectedIndexChanged += new System.EventHandler(this.cmbCompanyName_SelectedIndexChanged);
            // 
            // rbtPlanedEnd
            // 
            this.rbtPlanedEnd.AutoSize = true;
            this.rbtPlanedEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtPlanedEnd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbtPlanedEnd.Location = new System.Drawing.Point(354, 59);
            this.rbtPlanedEnd.Name = "rbtPlanedEnd";
            this.rbtPlanedEnd.Size = new System.Drawing.Size(198, 21);
            this.rbtPlanedEnd.TabIndex = 12;
            this.rbtPlanedEnd.TabStop = true;
            this.rbtPlanedEnd.Text = "Planlanan Bitiş Tarihine Göre";
            this.rbtPlanedEnd.UseVisualStyleBackColor = true;
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDateSearch.FlatAppearance.BorderSize = 0;
            this.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDateSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDateSearch.Location = new System.Drawing.Point(266, 22);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(82, 55);
            this.btnDateSearch.TabIndex = 10;
            this.btnDateSearch.Text = "Tarihe Göre Getir";
            this.btnDateSearch.UseVisualStyleBackColor = false;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click);
            // 
            // rbtPlannedStart
            // 
            this.rbtPlannedStart.AutoSize = true;
            this.rbtPlannedStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtPlannedStart.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbtPlannedStart.Location = new System.Drawing.Point(354, 41);
            this.rbtPlannedStart.Name = "rbtPlannedStart";
            this.rbtPlannedStart.Size = new System.Drawing.Size(223, 21);
            this.rbtPlannedStart.TabIndex = 13;
            this.rbtPlannedStart.TabStop = true;
            this.rbtPlannedStart.Text = "Planlanan Başlama Tarihine Göre";
            this.rbtPlannedStart.UseVisualStyleBackColor = true;
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSearchDate.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtpSearchDate.Location = new System.Drawing.Point(354, 22);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(182, 20);
            this.dtpSearchDate.TabIndex = 11;
            // 
            // dgvProjectList
            // 
            this.dgvProjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectList.ContextMenuStrip = this.contextProjectUpdate;
            this.dgvProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjectList.Location = new System.Drawing.Point(0, 0);
            this.dgvProjectList.Name = "dgvProjectList";
            this.dgvProjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjectList.Size = new System.Drawing.Size(761, 265);
            this.dgvProjectList.TabIndex = 9;
            // 
            // projeKapatToolStripMenuItem
            // 
            this.projeKapatToolStripMenuItem.Name = "projeKapatToolStripMenuItem";
            this.projeKapatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.projeKapatToolStripMenuItem.Text = "Proje Kapat";
            this.projeKapatToolStripMenuItem.Click += new System.EventHandler(this.projeKapatToolStripMenuItem_Click);
            // 
            // ProjectListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(761, 367);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(777, 406);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(777, 406);
            this.Name = "ProjectListForm";
            this.Text = "PROJE LİSTELEME FORMU";
            this.Load += new System.EventHandler(this.ProjectListForm_Load);
            this.contextProjectUpdate.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextProjectUpdate;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rbtPlanedEnd;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.RadioButton rbtPlannedStart;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.DataGridView dgvProjectList;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.ToolStripMenuItem projeKapatToolStripMenuItem;
    }
}