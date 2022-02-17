﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp1
{
    public interface ITodoService
    {
        bool Create(Todo item);
        Todo Get(Guid guid);
    }
    public sealed class TodoService : ITodoService
    {
        public bool Create(Todo item)
        {
            
            if (item.Name.Length >= 50)
            {
                return false;
            }
            
            
            try
                {
                    var path = Helper.GetTodoPath(item.Id);
                    var isExist = File.Exists(path);
                    if (isExist != true)
                    {
                        File.Create(path).Dispose();
                    }

                    using (var streamWriter = new StreamWriter(path))
                    {
                        var json = JsonConvert.SerializeObject(item, Formatting.Indented);

                        streamWriter.WriteLine(json);
                        streamWriter.Close();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            
        }
            public Todo Get(Guid guid)
            {
                var path = Helper.GetTodoPath(guid);
                var json = File.ReadAllText(path);

                var todo = JsonConvert.DeserializeObject<Todo>(json);
                return todo;

            }
        }
    }

