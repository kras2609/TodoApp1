using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp1.DTO
{
    public class ResponseBase
    {
        public Status Status { get; set; }
        public Exception Exception { get; set; }
    }
}
