using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoApp1.DTO;

namespace TodoApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var service = new TodoService();
            var todo = new Todo()
            {
                Body = todoBodyTextBox.Text,
                Name = todoNameTextBox.Text,
                Id = Guid.NewGuid(),
                Created = DateTime.Now
            };

            var result = service.Create(todo);
            
            if (result == true)
            {

                listBox1.Items.Add(todo);
                MessageBox.Show("Заметка создана", "Успешно!");
                todoNameTextBox.Clear();
                todoBodyTextBox.Clear();
                
            }
            else
            {
                MessageBox.Show("Не удалось создать заметку", "Ошибка!");
                todoNameTextBox.Clear();
                todoBodyTextBox.Clear();
            }
            
        }

       

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Нет элементов", "Ошибка!");
                return;
            }

            var todo = (Todo)listBox1.SelectedItem;
            
            if (listBox1.SelectedIndex != -1)
            {
                MessageBox.Show(todo.Id.ToString());
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                showtextBox.Clear();
            }
            else
            {
                MessageBox.Show("Выберите элемент", "Ошибка!");
                return;
            }

            var service = new TodoService();
            var response = service.Delete(todo.Id);

            if(response.Status == Status.Error)
            {
                MessageBox.Show($"Ошибка : {response.Exception.Message}");
                return;
            }

            

        }



        private void showButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Нет элементов", "Ошибка!");
                return;
            }

            
            if (listBox1.SelectedIndex != -1)
            {
                var todo = (Todo)listBox1.SelectedItem;
                var service = new TodoService();
                var get = service.Get(todo.Id);
                string showText = Convert.ToString(get.Body);
                showtextBox.Text = showText;
            }
            else
            {
                MessageBox.Show("Выберите элемент", "Ошибка!");
                return;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";

            var service = new TodoService();
            var todoList = service.GetAll();
            
            foreach (var item in todoList)
            {
                listBox1.Items.Add(item);
            }

            var items = new List<Todo>();
            foreach (var t in listBox1.Items)
            {
                var p = (Todo)t;
                items.Add(p);

            }
            listBox1.Items.Clear();
            var sorttonew = items.OrderByDescending(x => x.Created);

            foreach (var a in sorttonew)
            {
                listBox1.Items.Add(a);
            }
        }

        private void redactButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Нет элементов", "Ошибка!");
                return;
            }

            if (listBox1.SelectedIndex != -1)
            {
                var todo = (Todo)listBox1.SelectedItem;
                var id = todo.Id;
                Form2 form2 = new Form2(id);
                form2.listbox2 = listBox1;
                form2.showtextBox2 = showtextBox;
                form2.Show();
            }
            else
            {
                MessageBox.Show("Выберите элемент", "Ошибка!");
                return;
            }
        }

        private void sortToNewButton_Click(object sender, EventArgs e)
        {
            var items = new List<Todo>();
            foreach (var t in listBox1.Items)
            {
                var p = (Todo)t;
                items.Add(p);

            }
            listBox1.Items.Clear();
            var sorttonew = items.OrderByDescending(x => x.Created);

            foreach (var a in sorttonew)
            {
                listBox1.Items.Add(a);
            }
        }

        private void sortToOldButton_Click(object sender, EventArgs e)
        {
            var items = new List<Todo>();
            foreach (var t in listBox1.Items)
            {
                var p = (Todo)t;
                items.Add(p);

            }
            listBox1.Items.Clear();
            var sorttoold = items.OrderBy(x => x.Created);

            foreach (var a in sorttoold)
            {
                listBox1.Items.Add(a);
            }
        }
    }
}
