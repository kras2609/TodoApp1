using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();

        }
        public Guid Id { get; set; }
        
        public ListBox listbox2;
        public TextBox showtextBox2;
        public Form2(Guid id)
        {
            InitializeComponent();
            Id = id;
            

        }
      
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            var service = new TodoService();
            listbox2.Items.RemoveAt(listbox2.SelectedIndex);
            var response = service.Delete(Id);
            var todo = new Todo()
            {
                Id = Guid.NewGuid(),
                Name = nameTextBox2.Text,
                Body = bodyTextBox2.Text,
                Created = DateTime.Now
            };
            var result = service.Create(todo);
            listbox2.Items.Add(todo);
            showtextBox2.Clear();
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var service = new TodoService();
            var get = service.Get(Id);
            string showText = Convert.ToString(get.Name);
            nameTextBox2.Text = showText;
            string showText2 = Convert.ToString(get.Body);
            bodyTextBox2.Text = showText2;
        }
    }
}
