using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp1.Enums
{
    public enum SexByType
    {
        Male = 1,
        Female = 2
    }
    public class Gender
    {
        public string Sex { get; set; }
        public SexByType Value { get; set; }
    }

}
