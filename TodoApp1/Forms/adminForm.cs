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

namespace TodoApp1
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }
        private async void adminForm_Load(object sender, EventArgs e)
        {
            var userinfo = new UserInfo();
            var service = new UserService();
            var result = await service.GetAdminListAsync();
            foreach (var item in result)
            {
                usersList.Items.Add(item);
            }           
        }

        private void usersList_MouseDoubleClick(object sender, EventArgs e)
        {
            if (usersList.SelectedItem != null)
            {
                var userInfo = (UserInfo)usersList.SelectedItem;
                var admUserInfo = new adminUserInfo(userInfo.Id);
                admUserInfo.Show();
            }
        }

    }
}
