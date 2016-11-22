namespace TaskManagement.SecurityModules
{
    partial class PasswordChangeForm
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
            this.txtUserControl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPasswordChange = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPasswordChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserControl
            // 
            this.txtUserControl.Enabled = false;
            this.txtUserControl.Location = new System.Drawing.Point(179, 43);
            this.txtUserControl.Name = "txtUserControl";
            this.txtUserControl.Size = new System.Drawing.Size(260, 25);
            this.txtUserControl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çalışan Adı :";
            // 
            // grpPasswordChange
            // 
            this.grpPasswordChange.Controls.Add(this.btnSave);
            this.grpPasswordChange.Controls.Add(this.btnBack);
            this.grpPasswordChange.Controls.Add(this.txtNewPasswordAgain);
            this.grpPasswordChange.Controls.Add(this.txtNewPassword);
            this.grpPasswordChange.Controls.Add(this.txtOldPassword);
            this.grpPasswordChange.Controls.Add(this.txtUserControl);
            this.grpPasswordChange.Controls.Add(this.label4);
            this.grpPasswordChange.Controls.Add(this.label3);
            this.grpPasswordChange.Controls.Add(this.label2);
            this.grpPasswordChange.Controls.Add(this.label1);
            this.grpPasswordChange.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpPasswordChange.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grpPasswordChange.Location = new System.Drawing.Point(12, 12);
            this.grpPasswordChange.Name = "grpPasswordChange";
            this.grpPasswordChange.Size = new System.Drawing.Size(539, 262);
            this.grpPasswordChange.TabIndex = 2;
            this.grpPasswordChange.TabStop = false;
            this.grpPasswordChange.Text = "Şifre Değiştirme Formu";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(312, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBack.Location = new System.Drawing.Point(179, 167);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 47);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Vazgeç";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // txtNewPasswordAgain
            // 
            this.txtNewPasswordAgain.Location = new System.Drawing.Point(179, 136);
            this.txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            this.txtNewPasswordAgain.Size = new System.Drawing.Size(260, 25);
            this.txtNewPasswordAgain.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(179, 105);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(260, 25);
            this.txtNewPassword.TabIndex = 2;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(179, 74);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(260, 25);
            this.txtOldPassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yeni Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yeni Şifre (Tekrar) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eski Şifre :";
            // 
            // PasswordChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(567, 292);
            this.Controls.Add(this.grpPasswordChange);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(583, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(583, 330);
            this.Name = "PasswordChangeForm";
            this.Text = "ŞİFRE GÜNCELLEME FORMU";
            this.Load += new System.EventHandler(this.PasswordChangeForm_Load);
            this.grpPasswordChange.ResumeLayout(false);
            this.grpPasswordChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPasswordChange;
        private System.Windows.Forms.TextBox txtNewPasswordAgain;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}