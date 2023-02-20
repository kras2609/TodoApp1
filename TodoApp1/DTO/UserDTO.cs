using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp1.DTO
{
    public sealed class UserDTO
    {
        public User User { get; set; }
        public Status Status { get; set; }
    }
}
