using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoApp1.DTO;
using TodoApp1.Environment;

namespace TodoApp1
{
    public partial class loginWindow : Form
    {
        public loginWindow()
        {
            InitializeComponent();
        }

        private void registrButton_Click(object sender, EventArgs e)
        {
            registrWindow registrForm = new registrWindow();
            registrForm.Show();
        }

        private async void enterButton_Click(object sender, EventArgs e)
        {
            var service = new UserService();
            var user = new User()
            {
                Login = loginText.Text,
                Password = passwordText.Text
            };

            var result2 = await service.adminAutorizationAsync(user);
            if (result2.Status == Status.Success)
            {
                StaticValues.CurrentUser = result2.User;
                Hide();
                adminForm admForm = new adminForm();
                admForm.Closed += (s, args) => Close();
                admForm.Show();
            }
            else
            {
                var result = await service.AutorizationAsync(user);
                if (result.Status == Status.Success)
                {
                    MessageBox.Show("Успешная авторизация", "Успешно");
                    StaticValues.CurrentUser = result.User;
                    Hide();
                    TodoApp todoApp = new TodoApp();
                    todoApp.Closed += (s, args) => Close();
                    todoApp.Show();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }
            
        }
            

       
    }
}
