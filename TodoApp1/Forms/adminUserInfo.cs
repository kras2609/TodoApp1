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
    public partial class adminUserInfo : Form
    {
        public int Id { get; set; }
        public adminUserInfo(int id)
        {
            InitializeComponent();
            Id = id;
        }
        public adminUserInfo()
        {
            InitializeComponent();
        }

        private async void adminUserInfo_Load(object sender, EventArgs e)
        {
            var service = new UserService();
            var result = await service.GetAsync(Id);
            idTextBox.Text = result.Id.ToString();
            surnameTextBox.Text = result.Surname;
            nameTextBox.Text = result.Name;
            secondnameTextBox.Text = result.SecondName;
            sexTextBox.Text = result.Sex.ToString();
            birthdayTextBox.Text = result.Birthday.ToString();
            loginTextBox.Text = result.Login;
        }

        private async void blockButton_Click(object sender, EventArgs e)
        {
            var service = new UserService();
            var result = await service.BlockUserAsync(Id);
            switch (result)
            {
                case Enums.BlockUserResult.Succes:
                    MessageBox.Show("Пользователь успешно заблокирован");
                    break;
                case Enums.BlockUserResult.UserNotFaund:
                    MessageBox.Show("Не удалось найти пользователя");
                    break;
                case Enums.BlockUserResult.UserAlreadyBlocked:
                    MessageBox.Show("Пользователь уже заблокирован");
                    break;
                case Enums.BlockUserResult.NoAdminRights:
                    MessageBox.Show("Не хватает прав администратора");
                    break;
                case Enums.BlockUserResult.UnknownError:
                    MessageBox.Show("Неизвестная ошибка");
                    break;
            }
        }

        private async void UnlockButton_Click(object sender, EventArgs e)
        {
            var service = new UserService();
            var result = await service.UnlockUserAsync(Id);
            switch (result)
            {
                case Enums.UnlockUserResult.Succes:
                    MessageBox.Show("Пользователь успешно разблокирован");
                    break;
                case Enums.UnlockUserResult.UserNotFaund:
                    MessageBox.Show("Не удалось найти пользователя");
                    break;
                case Enums.UnlockUserResult.UserAlreadyUnlocked:
                    MessageBox.Show("Пользователь не заблокирован");
                    break;
                case Enums.UnlockUserResult.NoAdminRights:
                    MessageBox.Show("Не хватает прав администратора");
                    break;
                case Enums.UnlockUserResult.UnknownError:
                    MessageBox.Show("Неизвестная ошибка");
                    break;
            }
        }
    }
}
