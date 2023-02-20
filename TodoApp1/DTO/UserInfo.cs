using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp1.DTO
{
    public sealed class UserInfo
    {
        public int Id { get; set; }
        public string Initials { get; set; }
        public int Count { get; set; }
        public string GetInfo => $"{Id} {Initials} ({Count})";
    }
}
