
namespace kiemtra1
{
    partial class Form1
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
            System.Windows.Forms.TextBox txtUserName;
            this.label1 = new System.Windows.Forms.Label();
            this.MatKhau = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(271, 64);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(175, 22);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten Dang Nhap";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSize = true;
            this.MatKhau.Location = new System.Drawing.Point(142, 112);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(62, 16);
            this.MatKhau.TabIndex = 2;
            this.MatKhau.Text = "Mat Khau";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(271, 112);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(175, 22);
            this.txtpassword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dang Nhap";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(txtUserName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MatKhau;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button button1;
    }
}

