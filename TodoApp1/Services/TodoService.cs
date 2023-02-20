using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp1.DTO;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using TodoApp1.Enums;
using TodoApp1.Models;
using TodoApp1.Environment;

namespace TodoApp1
{
    public interface ITodoService
    {
        Task<bool> CreateAsync(Todo item);
        Task<Todo> GetAsync(int id);
        Task<ResponseBase> DeleteAsync(int id);
        Task<List<Todo>> GetAllAsync(OrderByType orderType);
        Task<List<Todo>> GetAllAsync();
    }
    public sealed class TodoService : ITodoService
    {
        public static string conString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TodoDB;Integrated Security=True";
        public async Task<bool> CreateAsync(Todo item)
        {
            if (item.Name.Length >= 50)
                return false;

            try
            {
                using var connection = new SqlConnection(conString);
                connection.Open();
                var query = "INSERT INTO [Todos] (Name,Body,Created,UserID) values (@Name,@Body,@Created,@UserID); SELECT CAST(SCOPE_IDENTITY() as int)";
                var id = await connection.QuerySingleAsync<int>(query, new { Name = item.Name, Body = item.Body, Created = item.Created, UserID = StaticValues.CurrentUser.Id });
                item.Id = id;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<ResponseBase> DeleteAsync(int id)
        {
            var response = new ResponseBase();
            try
            {
                using var connection = new SqlConnection(conString);
                connection.Open();
                var query = "DELETE FROM [Todos] WHERE Id = @Id";
                await connection.ExecuteAsync(query, new { Id = id });
                response.Status = Status.Success;
            }
            catch (Exception ex)
            {
                response.Exception = ex;
                response.Status = Status.Error;
            }

            return response;
        }

        public async Task<Todo> GetAsync(int id)
        {
            var todo = new Todo();
            using var connection = new SqlConnection(conString);
            connection.Open();
            var query = "SELECT * FROM [Todos] WHERE Id = @Id";
            todo = await connection.QuerySingleAsync<Todo>(query, new { Id = id });

            return todo;

        }

        public async Task<List<Todo>> GetAllAsync()
        {
            try
            {
                using var connection = new SqlConnection(conString);
                connection.Open();
                var query = "SELECT * FROM Todos WHERE UserID = @UserID";
                var todo = await connection.QueryAsync<Todo>(query, new { UserID = StaticValues.CurrentUser.Id });
                return todo.ToList();
            }
            catch(Exception ex)
            {
                return new List<Todo>();
            }
        }
        public async Task<List<Todo>> GetAllAsync(OrderByType type)
        {
            try
            {
                using var connection = new SqlConnection(conString);
                connection.Open();
                var query = "";
                if(type == OrderByType.MinToMax)
                    query = "SELECT * FROM Todos WHERE UserID = @UserID order by Created";
                else
                    query = "SELECT * FROM Todos WHERE UserID = @UserID order by Created desc";
                var todo = await connection.QueryAsync<Todo>(query, new { UserID = StaticValues.CurrentUser.Id });
                return todo.ToList();
            }
            catch (Exception ex)
            {
                return new List<Todo>();
            }
        }
    }
}

