
namespace TodoApp1
{
    partial class loginWindow
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
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.registrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(28, 49);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(44, 17);
            this.login.TabIndex = 0;
            this.login.Text = "Логин";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(18, 92);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(54, 17);
            this.password.TabIndex = 1;
            this.password.Text = "Пароль";
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(78, 48);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(222, 23);
            this.loginText.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(78, 91);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(222, 23);
            this.passwordText.TabIndex = 3;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.enterButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterButton.Location = new System.Drawing.Point(78, 142);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(222, 50);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // registrButton
            // 
            this.registrButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.registrButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registrButton.Location = new System.Drawing.Point(48, 206);
            this.registrButton.Name = "registrButton";
            this.registrButton.Size = new System.Drawing.Size(274, 50);
            this.registrButton.TabIndex = 5;
            this.registrButton.Text = "Зарегистрироваться";
            this.registrButton.UseVisualStyleBackColor = false;
            this.registrButton.Click += new System.EventHandler(this.registrButton_Click);
            // 
            // loginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 306);
            this.Controls.Add(this.registrButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "loginWindow";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button registrButton;
    }
}