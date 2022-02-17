using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp1
{
    public sealed class Todo
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }

        public Todo(Guid id)
        {
            Id = id;
            Created = DateTime.Now;
        }

        public Todo()
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now;
        }

       
}

    
}
