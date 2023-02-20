using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Dapper;
using TodoApp1.Models;

namespace TodoApp1
{
    public partial class RedactWindow : Form
    {
        
        public RedactWindow()
        {
            InitializeComponent();

        }
        public int Id { get; set; }
        
        public ListBox listbox2;
        public TextBox showtextBox2;
        public RedactWindow(int id)
        {
            InitializeComponent();
            Id = id;
        }
      
        private async void saveButton_Click(object sender, EventArgs e)
        {
            
            var service = new TodoService();
            listbox2.Items.RemoveAt(listbox2.SelectedIndex);
            var response = await service.DeleteAsync(Id);
            var todo = new Todo()
            {
                Name = nameTextBox2.Text,
                Body = bodyTextBox2.Text,
                Created = DateTime.Now
            };
           
            using var connection = new SqlConnection(TodoService.conString);
            connection.Open();
            var query = "DELETE FROM [Todos] WHERE Id = @Id";
            connection.Execute(query, new { Id = Id });
            
            var result = await service.CreateAsync(todo);
            listbox2.Items.Add(todo);
            showtextBox2.Clear();
            Close();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            var service = new TodoService();
            var get = await service.GetAsync(Id);
            string showText = Convert.ToString(get.Name);
            nameTextBox2.Text = showText;
            string showText2 = Convert.ToString(get.Body);
            bodyTextBox2.Text = showText2;
        }
    }
}
