
namespace TodoApp1
{
    partial class TodoApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.todoNameTextBox = new System.Windows.Forms.TextBox();
            this.todoBodyTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.showtextBox = new System.Windows.Forms.TextBox();
            this.redactButton = new System.Windows.Forms.Button();
            this.sortToNewButton = new System.Windows.Forms.Button();
            this.sortToOldButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Содержание";
            // 
            // todoNameTextBox
            // 
            this.todoNameTextBox.Location = new System.Drawing.Point(12, 58);
            this.todoNameTextBox.Name = "todoNameTextBox";
            this.todoNameTextBox.Size = new System.Drawing.Size(264, 23);
            this.todoNameTextBox.TabIndex = 2;
            // 
            // todoBodyTextBox
            // 
            this.todoBodyTextBox.Location = new System.Drawing.Point(12, 120);
            this.todoBodyTextBox.Multiline = true;
            this.todoBodyTextBox.Name = "todoBodyTextBox";
            this.todoBodyTextBox.Size = new System.Drawing.Size(264, 133);
            this.todoBodyTextBox.TabIndex = 3;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createButton.Location = new System.Drawing.Point(59, 270);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(147, 35);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(299, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 199);
            this.listBox1.TabIndex = 5;
            this.listBox1.ValueMember = "Id";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(300, 270);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 35);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showButton.Location = new System.Drawing.Point(410, 270);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(118, 35);
            this.showButton.TabIndex = 7;
            this.showButton.Text = "Показать";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // showtextBox
            // 
            this.showtextBox.Location = new System.Drawing.Point(550, 58);
            this.showtextBox.Multiline = true;
            this.showtextBox.Name = "showtextBox";
            this.showtextBox.Size = new System.Drawing.Size(316, 247);
            this.showtextBox.TabIndex = 8;
            // 
            // redactButton
            // 
            this.redactButton.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.redactButton.Location = new System.Drawing.Point(340, 311);
            this.redactButton.Name = "redactButton";
            this.redactButton.Size = new System.Drawing.Size(145, 36);
            this.redactButton.TabIndex = 9;
            this.redactButton.Text = "Редактировать";
            this.redactButton.UseVisualStyleBackColor = true;
            this.redactButton.Click += new System.EventHandler(this.redactButton_Click);
            // 
            // sortToNewButton
            // 
            this.sortToNewButton.Location = new System.Drawing.Point(387, 3);
            this.sortToNewButton.Name = "sortToNewButton";
            this.sortToNewButton.Size = new System.Drawing.Size(121, 23);
            this.sortToNewButton.TabIndex = 10;
            this.sortToNewButton.Text = "От новых к старым";
            this.sortToNewButton.UseVisualStyleBackColor = true;
            this.sortToNewButton.Click += new System.EventHandler(this.sortToNewButton_Click);
            // 
            // sortToOldButton
            // 
            this.sortToOldButton.Location = new System.Drawing.Point(387, 29);
            this.sortToOldButton.Name = "sortToOldButton";
            this.sortToOldButton.Size = new System.Drawing.Size(121, 23);
            this.sortToOldButton.TabIndex = 11;
            this.sortToOldButton.Text = "От старых к новым";
            this.sortToOldButton.UseVisualStyleBackColor = true;
            this.sortToOldButton.Click += new System.EventHandler(this.sortToOldButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Сортировать:";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Coral;
            this.closeButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(723, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(143, 33);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // TodoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 363);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sortToOldButton);
            this.Controls.Add(this.sortToNewButton);
            this.Controls.Add(this.redactButton);
            this.Controls.Add(this.showtextBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.todoBodyTextBox);
            this.Controls.Add(this.todoNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TodoApp";
            this.Text = "TodoApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox todoNameTextBox;
        private System.Windows.Forms.TextBox todoBodyTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox showtextBox;
        private System.Windows.Forms.Button redactButton;
        private System.Windows.Forms.Button sortToNewButton;
        private System.Windows.Forms.Button sortToOldButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeButton;
    }
}

