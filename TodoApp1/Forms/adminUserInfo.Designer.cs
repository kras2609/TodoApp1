
namespace TodoApp1
{
    partial class adminUserInfo
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
            this.idLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.secondnameLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.secondnameTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.blockButton = new System.Windows.Forms.Button();
            this.UnlockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(69, 26);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Id";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(28, 64);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(58, 15);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(55, 103);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(31, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Имя";
            // 
            // secondnameLabel
            // 
            this.secondnameLabel.AutoSize = true;
            this.secondnameLabel.Location = new System.Drawing.Point(28, 145);
            this.secondnameLabel.Name = "secondnameLabel";
            this.secondnameLabel.Size = new System.Drawing.Size(58, 15);
            this.secondnameLabel.TabIndex = 3;
            this.secondnameLabel.Text = "Отчество";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(-4, 226);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(90, 15);
            this.birthdayLabel.TabIndex = 4;
            this.birthdayLabel.Text = "Дата Рождения";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(55, 184);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(30, 15);
            this.sexLabel.TabIndex = 5;
            this.sexLabel.Text = "Пол";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(45, 265);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 15);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "Логин";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(92, 23);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(212, 23);
            this.idTextBox.TabIndex = 7;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(92, 61);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(212, 23);
            this.surnameTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(92, 100);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(212, 23);
            this.nameTextBox.TabIndex = 9;
            // 
            // secondnameTextBox
            // 
            this.secondnameTextBox.Location = new System.Drawing.Point(92, 142);
            this.secondnameTextBox.Name = "secondnameTextBox";
            this.secondnameTextBox.Size = new System.Drawing.Size(212, 23);
            this.secondnameTextBox.TabIndex = 10;
            // 
            // sexTextBox
            // 
            this.sexTextBox.Location = new System.Drawing.Point(91, 181);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(212, 23);
            this.sexTextBox.TabIndex = 11;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Location = new System.Drawing.Point(92, 223);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(212, 23);
            this.birthdayTextBox.TabIndex = 12;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(92, 262);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(212, 23);
            this.loginTextBox.TabIndex = 13;
            // 
            // blockButton
            // 
            this.blockButton.Location = new System.Drawing.Point(23, 312);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(297, 23);
            this.blockButton.TabIndex = 14;
            this.blockButton.Text = "Заблокировать пользователя";
            this.blockButton.UseVisualStyleBackColor = true;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // UnlockButton
            // 
            this.UnlockButton.Location = new System.Drawing.Point(23, 341);
            this.UnlockButton.Name = "UnlockButton";
            this.UnlockButton.Size = new System.Drawing.Size(297, 23);
            this.UnlockButton.TabIndex = 15;
            this.UnlockButton.Text = "Разблокировать пользователя";
            this.UnlockButton.UseVisualStyleBackColor = true;
            this.UnlockButton.Click += new System.EventHandler(this.UnlockButton_Click);
            // 
            // adminUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.UnlockButton);
            this.Controls.Add(this.blockButton);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(this.secondnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.secondnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "adminUserInfo";
            this.Text = "adminUserInfo";
            this.Load += new System.EventHandler(this.adminUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label secondnameLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox secondnameTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button blockButton;
        private System.Windows.Forms.Button UnlockButton;
    }
}