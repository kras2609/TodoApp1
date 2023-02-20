
namespace TodoApp1
{
    partial class adminForm
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
            this.usersList = new System.Windows.Forms.ListBox();
            this.usersBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usersList
            // 
            this.usersList.DisplayMember = "GetInfo";
            this.usersList.FormattingEnabled = true;
            this.usersList.ItemHeight = 15;
            this.usersList.Location = new System.Drawing.Point(12, 42);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(236, 334);
            this.usersList.TabIndex = 0;
            this.usersList.ValueMember = "Id";
            this.usersList.DoubleClick += new System.EventHandler(this.usersList_MouseDoubleClick);
            // 
            // usersBox
            // 
            this.usersBox.BackColor = System.Drawing.Color.SandyBrown;
            this.usersBox.Location = new System.Drawing.Point(12, 13);
            this.usersBox.Name = "usersBox";
            this.usersBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usersBox.Size = new System.Drawing.Size(236, 23);
            this.usersBox.TabIndex = 1;
            this.usersBox.Text = "Список пользователей";
            this.usersBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 450);
            this.Controls.Add(this.usersBox);
            this.Controls.Add(this.usersList);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.TextBox usersBox;
    }
}