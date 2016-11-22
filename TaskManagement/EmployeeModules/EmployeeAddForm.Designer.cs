namespace TaskManagement.EmployeeModules
{
    partial class EmployeeAddForm
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpEmployeeAdd = new System.Windows.Forms.GroupBox();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.grpEmployeeAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(172, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(172, 25);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(172, 84);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(172, 25);
            this.txtLastName.TabIndex = 0;
            // 
            // cmbPosition
            // 
            this.cmbPosition.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(172, 115);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(172, 25);
            this.cmbPosition.TabIndex = 1;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(172, 146);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(172, 25);
            this.txtMail.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(172, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 25);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "mail adresine gönderilecek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(131, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(111, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(112, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Görevi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(84, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mail Adresi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(111, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Şifresi : ";
            // 
            // grpEmployeeAdd
            // 
            this.grpEmployeeAdd.Controls.Add(this.btnEmployeeAdd);
            this.grpEmployeeAdd.Controls.Add(this.txtFirstName);
            this.grpEmployeeAdd.Controls.Add(this.label5);
            this.grpEmployeeAdd.Controls.Add(this.txtLastName);
            this.grpEmployeeAdd.Controls.Add(this.label4);
            this.grpEmployeeAdd.Controls.Add(this.txtMail);
            this.grpEmployeeAdd.Controls.Add(this.label3);
            this.grpEmployeeAdd.Controls.Add(this.txtPassword);
            this.grpEmployeeAdd.Controls.Add(this.label2);
            this.grpEmployeeAdd.Controls.Add(this.cmbPosition);
            this.grpEmployeeAdd.Controls.Add(this.label1);
            this.grpEmployeeAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpEmployeeAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grpEmployeeAdd.Location = new System.Drawing.Point(12, 12);
            this.grpEmployeeAdd.Name = "grpEmployeeAdd";
            this.grpEmployeeAdd.Size = new System.Drawing.Size(558, 249);
            this.grpEmployeeAdd.TabIndex = 3;
            this.grpEmployeeAdd.TabStop = false;
            this.grpEmployeeAdd.Text = "Yeni Çalışan Ekle";
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEmployeeAdd.FlatAppearance.BorderSize = 0;
            this.btnEmployeeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployeeAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployeeAdd.Location = new System.Drawing.Point(350, 52);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(102, 149);
            this.btnEmployeeAdd.TabIndex = 3;
            this.btnEmployeeAdd.Text = "Çalışan Ekle";
            this.btnEmployeeAdd.UseVisualStyleBackColor = false;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(582, 274);
            this.Controls.Add(this.grpEmployeeAdd);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(598, 312);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(598, 312);
            this.Name = "EmployeeAddForm";
            this.Text = "ÇALIŞAN EKLEME FORMU";
            this.Load += new System.EventHandler(this.EmployeeAddForm_Load);
            this.grpEmployeeAdd.ResumeLayout(false);
            this.grpEmployeeAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpEmployeeAdd;
        public System.Windows.Forms.Button btnEmployeeAdd;
    }
}