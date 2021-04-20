
namespace Launcher
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sumbitRegistration = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sumbitRegistration
            // 
            this.sumbitRegistration.Location = new System.Drawing.Point(277, 292);
            this.sumbitRegistration.Name = "sumbitRegistration";
            this.sumbitRegistration.Size = new System.Drawing.Size(191, 54);
            this.sumbitRegistration.TabIndex = 0;
            this.sumbitRegistration.Text = "Sumbit";
            this.sumbitRegistration.UseVisualStyleBackColor = true;
            this.sumbitRegistration.Click += new System.EventHandler(this.sumbitRegistration_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(277, 238);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(191, 23);
            this.password.TabIndex = 1;
            this.password.Text = "Password:";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(277, 180);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(191, 23);
            this.login.TabIndex = 2;
            this.login.Text = "Login:";
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.sumbitRegistration);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumbitRegistration;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
    }
}

