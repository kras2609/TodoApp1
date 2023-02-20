
namespace TodoApp1
{
    partial class registrWindow
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
            this.name = new System.Windows.Forms.Label();
            this.secondname = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nameText = new System.Windows.Forms.TextBox();
            this.secondnameText = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.Label();
            this.sexBox = new System.Windows.Forms.ComboBox();
            this.birthday = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.againPassword = new System.Windows.Forms.Label();
            this.againPasswordText = new System.Windows.Forms.TextBox();
            this.registrButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(75, 62);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(31, 15);
            this.name.TabIndex = 0;
            this.name.Text = "Имя";
            // 
            // secondname
            // 
            this.secondname.AutoSize = true;
            this.secondname.Location = new System.Drawing.Point(48, 97);
            this.secondname.Name = "secondname";
            this.secondname.Size = new System.Drawing.Size(58, 15);
            this.secondname.TabIndex = 1;
            this.secondname.Text = "Отчество";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(48, 25);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(58, 15);
            this.surname.TabIndex = 2;
            this.surname.Text = "Фамилия";
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(112, 25);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(216, 23);
            this.surnameText.TabIndex = 3;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(112, 62);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(216, 23);
            this.nameText.TabIndex = 4;
            // 
            // secondnameText
            // 
            this.secondnameText.Location = new System.Drawing.Point(112, 97);
            this.secondnameText.Name = "secondnameText";
            this.secondnameText.Size = new System.Drawing.Size(216, 23);
            this.secondnameText.TabIndex = 5;
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(75, 138);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(30, 15);
            this.sex.TabIndex = 6;
            this.sex.Text = "Пол";
            // 
            // sexBox
            // 
            this.sexBox.FormattingEnabled = true;
            this.sexBox.Location = new System.Drawing.Point(112, 135);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(216, 23);
            this.sexBox.TabIndex = 7;
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(16, 174);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(90, 15);
            this.birthday.TabIndex = 8;
            this.birthday.Text = "Дата Рождения";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(64, 208);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(41, 15);
            this.login.TabIndex = 10;
            this.login.Text = "Логин";
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(112, 205);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(216, 23);
            this.loginText.TabIndex = 11;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(57, 244);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(49, 15);
            this.password.TabIndex = 12;
            this.password.Text = "Пароль";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(112, 241);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(216, 23);
            this.passwordText.TabIndex = 13;
            // 
            // againPassword
            // 
            this.againPassword.AutoSize = true;
            this.againPassword.Location = new System.Drawing.Point(-3, 278);
            this.againPassword.Name = "againPassword";
            this.againPassword.Size = new System.Drawing.Size(109, 15);
            this.againPassword.TabIndex = 14;
            this.againPassword.Text = "Повторите пароль";
            // 
            // againPasswordText
            // 
            this.againPasswordText.Location = new System.Drawing.Point(112, 278);
            this.againPasswordText.Name = "againPasswordText";
            this.againPasswordText.Size = new System.Drawing.Size(216, 23);
            this.againPasswordText.TabIndex = 15;
            // 
            // registrButton
            // 
            this.registrButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registrButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registrButton.Location = new System.Drawing.Point(87, 317);
            this.registrButton.Name = "registrButton";
            this.registrButton.Size = new System.Drawing.Size(268, 55);
            this.registrButton.TabIndex = 16;
            this.registrButton.Text = "Зарегистрироваться";
            this.registrButton.UseVisualStyleBackColor = false;
            this.registrButton.Click += new System.EventHandler(this.registrButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(112, 174);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(216, 23);
            this.dateTimePicker.TabIndex = 17;
            // 
            // registrWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 374);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.registrButton);
            this.Controls.Add(this.againPasswordText);
            this.Controls.Add(this.againPassword);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.password);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.login);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.sexBox);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.secondnameText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.secondname);
            this.Controls.Add(this.name);
            this.Name = "registrWindow";
            this.Text = "registrWindow";
            this.Load += new System.EventHandler(this.registrWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label secondname;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox secondnameText;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.ComboBox sexBox;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label againPassword;
        private System.Windows.Forms.TextBox againPasswordText;
        private System.Windows.Forms.Button registrButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}