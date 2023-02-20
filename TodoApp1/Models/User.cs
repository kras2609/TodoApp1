using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp1.Enums;

namespace TodoApp1
{
    public sealed class User
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public SexByType Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public bool IsBlocked { get; set; }

        public User()
        {

        }
    }
    
    
}
