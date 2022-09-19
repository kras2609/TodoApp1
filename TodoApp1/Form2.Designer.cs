
namespace TodoApp1
{
    partial class Form2
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
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.bodyLabel2 = new System.Windows.Forms.Label();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.bodyTextBox2 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Location = new System.Drawing.Point(24, 28);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(59, 15);
            this.nameLabel2.TabIndex = 0;
            this.nameLabel2.Text = "Название";
            // 
            // bodyLabel2
            // 
            this.bodyLabel2.AutoSize = true;
            this.bodyLabel2.Location = new System.Drawing.Point(24, 72);
            this.bodyLabel2.Name = "bodyLabel2";
            this.bodyLabel2.Size = new System.Drawing.Size(76, 15);
            this.bodyLabel2.TabIndex = 1;
            this.bodyLabel2.Text = "Содержание";
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Location = new System.Drawing.Point(24, 46);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(252, 23);
            this.nameTextBox2.TabIndex = 2;
            // 
            // bodyTextBox2
            // 
            this.bodyTextBox2.Location = new System.Drawing.Point(24, 90);
            this.bodyTextBox2.Multiline = true;
            this.bodyTextBox2.Name = "bodyTextBox2";
            this.bodyTextBox2.Size = new System.Drawing.Size(252, 179);
            this.bodyTextBox2.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(24, 289);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(252, 49);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 376);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.bodyTextBox2);
            this.Controls.Add(this.nameTextBox2);
            this.Controls.Add(this.bodyLabel2);
            this.Controls.Add(this.nameLabel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label bodyLabel2;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.TextBox bodyTextBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}