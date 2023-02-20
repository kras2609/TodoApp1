using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoApp1.Enums;

namespace TodoApp1
{
    public partial class registrWindow : Form
    {
        public registrWindow()
        {
            InitializeComponent();
        }

        private async void registrButton_Click(object sender, EventArgs e)
        {    
            var service = new UserService();
            var user = new User()
            {
                Surname = surnameText.Text,
                Name = nameText.Text,
                SecondName = secondnameText.Text,
                Sex = (SexByType)sexBox.SelectedValue,
                Birthday = dateTimePicker.Value,
                Login = loginText.Text,
                Password = passwordText.Text
            };
            if (againPasswordText.Text != passwordText.Text )
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            
            var result = await service.CreateAsync(user);

            if (result == true)
            {
                MessageBox.Show("Регистрация прошла успешно", "Успешно!");
                TodoApp todoapp = new TodoApp();
                todoapp.Show();
            }
            else
            {
                MessageBox.Show("Не удалось зарегистрироваться", "Ошибка!");
            }
        }

        private void registrWindow_Load(object sender, EventArgs e)
        {
            var list = new List<Gender>
            {
                new Gender() {Sex = "Мужской", Value = SexByType.Male},
                new Gender() {Sex = "Женский", Value = SexByType.Female}
            };
            sexBox.DisplayMember = "Sex";
            sexBox.ValueMember = "Value";
            sexBox.DataSource = list;

        }
    }
}
