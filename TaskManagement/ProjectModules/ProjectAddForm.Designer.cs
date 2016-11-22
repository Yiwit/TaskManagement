namespace TaskManagement.ProjectModules
{
    partial class ProjectAddForm
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
            this.grpProjectAdd = new System.Windows.Forms.GroupBox();
            this.txtProjectDetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPlannedFinish = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPlannedStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.txtMenagemerName = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.btnProjectCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lViewAddEmployeeList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lViewEmployeeList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEmployeeRemove = new System.Windows.Forms.Button();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.grpProjectAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProjectAdd
            // 
            this.grpProjectAdd.Controls.Add(this.txtProjectDetail);
            this.grpProjectAdd.Controls.Add(this.label1);
            this.grpProjectAdd.Controls.Add(this.btnCustomerAdd);
            this.grpProjectAdd.Controls.Add(this.label2);
            this.grpProjectAdd.Controls.Add(this.dtpPlannedFinish);
            this.grpProjectAdd.Controls.Add(this.label3);
            this.grpProjectAdd.Controls.Add(this.label4);
            this.grpProjectAdd.Controls.Add(this.label5);
            this.grpProjectAdd.Controls.Add(this.dtpPlannedStart);
            this.grpProjectAdd.Controls.Add(this.label6);
            this.grpProjectAdd.Controls.Add(this.cmbCompanyName);
            this.grpProjectAdd.Controls.Add(this.txtMenagemerName);
            this.grpProjectAdd.Controls.Add(this.txtProjectName);
            this.grpProjectAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpProjectAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grpProjectAdd.Location = new System.Drawing.Point(12, 12);
            this.grpProjectAdd.Name = "grpProjectAdd";
            this.grpProjectAdd.Size = new System.Drawing.Size(635, 244);
            this.grpProjectAdd.TabIndex = 8;
            this.grpProjectAdd.TabStop = false;
            this.grpProjectAdd.Text = "Proje Oluştur";
            // 
            // txtProjectDetail
            // 
            this.txtProjectDetail.Location = new System.Drawing.Point(299, 40);
            this.txtProjectDetail.Multiline = true;
            this.txtProjectDetail.Name = "txtProjectDetail";
            this.txtProjectDetail.Size = new System.Drawing.Size(311, 127);
            this.txtProjectDetail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(67, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proje Adı :";
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCustomerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomerAdd.Location = new System.Drawing.Point(183, 133);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(109, 34);
            this.btnCustomerAdd.TabIndex = 4;
            this.btnCustomerAdd.Text = "Müşteri Ekle";
            this.btnCustomerAdd.UseVisualStyleBackColor = false;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(298, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proje Detayları : ";
            // 
            // dtpPlannedFinish
            // 
            this.dtpPlannedFinish.Location = new System.Drawing.Point(299, 199);
            this.dtpPlannedFinish.Name = "dtpPlannedFinish";
            this.dtpPlannedFinish.Size = new System.Drawing.Size(311, 25);
            this.dtpPlannedFinish.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(33, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Proje Müşterisi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(18, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Projeyi Oluşturan :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(128, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Planlanan Başlama Tarihi :";
            // 
            // dtpPlannedStart
            // 
            this.dtpPlannedStart.Location = new System.Drawing.Point(299, 173);
            this.dtpPlannedStart.Name = "dtpPlannedStart";
            this.dtpPlannedStart.Size = new System.Drawing.Size(311, 25);
            this.dtpPlannedStart.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(153, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Planlanan Bitiş Tarihi :";
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.BackColor = System.Drawing.Color.White;
            this.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCompanyName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(144, 102);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(148, 25);
            this.cmbCompanyName.TabIndex = 2;
            // 
            // txtMenagemerName
            // 
            this.txtMenagemerName.Enabled = false;
            this.txtMenagemerName.Location = new System.Drawing.Point(144, 71);
            this.txtMenagemerName.Name = "txtMenagemerName";
            this.txtMenagemerName.Size = new System.Drawing.Size(149, 25);
            this.txtMenagemerName.TabIndex = 1;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(143, 40);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(149, 25);
            this.txtProjectName.TabIndex = 1;
            // 
            // btnProjectCreate
            // 
            this.btnProjectCreate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnProjectCreate.FlatAppearance.BorderSize = 0;
            this.btnProjectCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProjectCreate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProjectCreate.Location = new System.Drawing.Point(21, 184);
            this.btnProjectCreate.Name = "btnProjectCreate";
            this.btnProjectCreate.Size = new System.Drawing.Size(589, 37);
            this.btnProjectCreate.TabIndex = 5;
            this.btnProjectCreate.Text = "Projeyi Oluştur";
            this.btnProjectCreate.UseVisualStyleBackColor = false;
            this.btnProjectCreate.Click += new System.EventHandler(this.btnProjectCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lViewAddEmployeeList);
            this.groupBox1.Controls.Add(this.lViewEmployeeList);
            this.groupBox1.Controls.Add(this.btnProjectCreate);
            this.groupBox1.Controls.Add(this.btnEmployeeRemove);
            this.groupBox1.Controls.Add(this.btnEmployeeAdd);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 230);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proje Çalışanları";
            // 
            // lViewAddEmployeeList
            // 
            this.lViewAddEmployeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lViewAddEmployeeList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lViewAddEmployeeList.Location = new System.Drawing.Point(346, 19);
            this.lViewAddEmployeeList.Name = "lViewAddEmployeeList";
            this.lViewAddEmployeeList.Size = new System.Drawing.Size(264, 159);
            this.lViewAddEmployeeList.TabIndex = 0;
            this.lViewAddEmployeeList.UseCompatibleStateImageBehavior = false;
            this.lViewAddEmployeeList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adı";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Soyadı";
            this.columnHeader5.Width = 74;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Görevi";
            this.columnHeader6.Width = 74;
            // 
            // lViewEmployeeList
            // 
            this.lViewEmployeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lViewEmployeeList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lViewEmployeeList.Location = new System.Drawing.Point(21, 19);
            this.lViewEmployeeList.Name = "lViewEmployeeList";
            this.lViewEmployeeList.Size = new System.Drawing.Size(264, 159);
            this.lViewEmployeeList.TabIndex = 0;
            this.lViewEmployeeList.UseCompatibleStateImageBehavior = false;
            this.lViewEmployeeList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Görevi";
            this.columnHeader3.Width = 74;
            // 
            // btnEmployeeRemove
            // 
            this.btnEmployeeRemove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEmployeeRemove.FlatAppearance.BorderSize = 0;
            this.btnEmployeeRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeRemove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployeeRemove.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployeeRemove.Location = new System.Drawing.Point(291, 109);
            this.btnEmployeeRemove.Name = "btnEmployeeRemove";
            this.btnEmployeeRemove.Size = new System.Drawing.Size(49, 44);
            this.btnEmployeeRemove.TabIndex = 4;
            this.btnEmployeeRemove.Text = "<";
            this.btnEmployeeRemove.UseVisualStyleBackColor = false;
            this.btnEmployeeRemove.Click += new System.EventHandler(this.btnEmployeeRemove_Click);
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEmployeeAdd.FlatAppearance.BorderSize = 0;
            this.btnEmployeeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployeeAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployeeAdd.Location = new System.Drawing.Point(291, 59);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(49, 44);
            this.btnEmployeeAdd.TabIndex = 4;
            this.btnEmployeeAdd.Text = ">";
            this.btnEmployeeAdd.UseVisualStyleBackColor = false;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // ProjectAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(662, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpProjectAdd);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(678, 544);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(678, 544);
            this.Name = "ProjectAddForm";
            this.Text = "PROJE EKLEME FORMU";
            this.Load += new System.EventHandler(this.ProjectAddForm_Load);
            this.grpProjectAdd.ResumeLayout(false);
            this.grpProjectAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProjectAdd;
        private System.Windows.Forms.TextBox txtProjectDetail;
        private System.Windows.Forms.Button btnProjectCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPlannedFinish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPlannedStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.TextBox txtMenagemerName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lViewAddEmployeeList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lViewEmployeeList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnEmployeeRemove;
        private System.Windows.Forms.Button btnEmployeeAdd;
    }
}