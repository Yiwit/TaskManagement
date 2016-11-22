namespace TaskManagement.WorkModules
{
    partial class ForwardToWorkEmployee
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
            this.lbl = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl.Location = new System.Drawing.Point(26, 34);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(100, 17);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Çalışan seçiniz :";
            // 
            // cmb
            // 
            this.cmb.BackColor = System.Drawing.Color.Gainsboro;
            this.cmb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(132, 30);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(121, 25);
            this.cmb.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn.Location = new System.Drawing.Point(270, 29);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(133, 25);
            this.btn.TabIndex = 2;
            this.btn.Text = "Yönlendir";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // ForwardToWorkEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(437, 129);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.lbl);
            this.Name = "ForwardToWorkEmployee";
            this.Text = "ÇALIŞANA İŞ YÖNLENDİRME FORMU";
            this.Load += new System.EventHandler(this.ForwardToWorkEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Button btn;
    }
}