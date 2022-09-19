﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp1.DTO;
using Dapper;
using Microsoft.Data.SqlClient;

namespace TodoApp1
{
    public interface ITodoService
    {
        bool Create(Todo item);
        Todo Get(Guid guid);
        ResponseBase Delete(Guid guid);
        List<Todo> GetAll();
    }
    public sealed class TodoService : ITodoService
    {
        
        public bool Create(Todo item)
        {
            if (item.Name.Length >= 50)
                return false;

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

                //SqlConnection con = new SqlConnection(conString);
                //con.Open();
                //if (con.State == System.Data.ConnectionState.Open)
                //{
                //    string q = "insert into Table(Name,Body)values('" + item.Name + "','" + item.Body + "')";
                //    SqlCommand cmd = new SqlCommand(q, con);
                //    cmd.ExecuteNonQuery();
                    
                //}

                //using (var db = new SqlConnection(conString))
                //{
                //    db.Open();
                //    db.QueryFirstOrDefault<Todo>(@"
                //        INSERT INTO Table (Name, Body)
                //        VALUES (@Name, @Body)",
                //        new
                //        {
                //            Name = item.Name,
                //            Body = item.Body,
                //        });
                //}
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public ResponseBase Delete(Guid guid)
        {
            var response = new ResponseBase();

            try
            {
                File.Delete(Helper.GetTodoPath(guid));
                response.Status = Status.Success;
            }
            catch (Exception ex)
            {
                response.Exception = ex;
                response.Status = Status.Error;
            }

            return response;
        }

        public Todo Get(Guid guid)
        {
            var path = Helper.GetTodoPath(guid);
            var json = File.ReadAllText(path);

            var todo = JsonConvert.DeserializeObject<Todo>(json);
            return todo;

        }

        public List<Todo> GetAll()
        {
            var todos = new List<Todo>();
            var txtFiles = Directory.GetFiles(Helper.GetTodoFolderPath(), "*.txt").ToList();
            foreach (var currentFile in txtFiles)
            {
                var json = File.ReadAllText(currentFile);
                var todo = JsonConvert.DeserializeObject<Todo>(json);
                todos.Add(todo);
            }
            return todos;
            
        }
    }
}

