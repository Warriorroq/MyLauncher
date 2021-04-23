
namespace Launcher
{
    partial class RegisterAccount
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
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.sumbitRegistration = new System.Windows.Forms.Button();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(70, 90);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(191, 23);
            this.login.TabIndex = 3;
            this.login.Text = "new login:";
            this.login.DoubleClick += new System.EventHandler(this.login_DoubleClick);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(70, 144);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(191, 23);
            this.password.TabIndex = 4;
            this.password.Text = "Password:";
            this.password.DoubleClick += new System.EventHandler(this.password_DoubleClick);
            // 
            // sumbitRegistration
            // 
            this.sumbitRegistration.Location = new System.Drawing.Point(12, 384);
            this.sumbitRegistration.Name = "sumbitRegistration";
            this.sumbitRegistration.Size = new System.Drawing.Size(191, 54);
            this.sumbitRegistration.TabIndex = 5;
            this.sumbitRegistration.Text = "Sumbit";
            this.sumbitRegistration.UseVisualStyleBackColor = true;
            this.sumbitRegistration.Click += new System.EventHandler(this.sumbitRegistration_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(70, 204);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(191, 54);
            this.buttonCreateAccount.TabIndex = 6;
            this.buttonCreateAccount.Text = "CreateAccount";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // RegisterAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.sumbitRegistration);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "RegisterAccount";
            this.Text = "RegisterAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button sumbitRegistration;
        private System.Windows.Forms.Button buttonCreateAccount;
    }
}