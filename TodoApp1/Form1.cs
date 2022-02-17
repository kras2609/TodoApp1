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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new TodoService();
            var todo = new Todo()
            {
                Body = todoBodyTextBox.Text,
                Name = todoNameTextBox.Text
            };
            var result = service.Create(todo);
            
            if (result == true)
            {

                listBox1.Items.Add(todo.Name);
                listView1.Items.Add(todo.Id.ToString());
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

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Нет элементов", "Ошибка!");
            }
            else
            {
                if (listBox1.SelectedIndex != -1)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Выберите элемент", "Ошибка!");
                }
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}
