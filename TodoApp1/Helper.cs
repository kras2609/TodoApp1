using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp1
{
    public class Helper
    {
        public static string GetTodoPath(Guid id)
        {
            return $"E:\\Todos\\{id}.txt";
        }

        public static string GetTodoFolderPath()
        {
            return @"E:\Todos";
        }
    }
}
