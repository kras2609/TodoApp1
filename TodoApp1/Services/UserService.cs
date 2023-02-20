using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using TodoApp1.Enums;
using TodoApp1.DTO;
using TodoApp1.Environment;

namespace TodoApp1
{
    public interface IUserService
    {
        Task<bool> CreateAsync(User user);
        Task<UserDTO> AutorizationAsync(User user);
        Task<UserDTO> adminAutorizationAsync(User user);
        Task<List<UserInfo>> GetAdminListAsync();
        Task<User> GetAsync(int id);
        Task<BlockUserResult> BlockUserAsync(int id);
        Task<UnlockUserResult> UnlockUserAsync(int id);

    }
    public class UserService:IUserService
    {
        public static string conString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TodoDB;Integrated Security=True";
        public async Task<bool> CreateAsync(User user)
        {
            if (user.Name.Length >= 30)
                return false;
            if (user.Surname.Length >= 30)
                return false;
            if (user.SecondName.Length >= 30)
                return false;
            if (user.Login.Length >= 30)
                return false;
            if (user.Password.Length >30)
                return false;
            if (user.Password.Length < 8)
                return false;
            try
                {
                var hashPassword = Hashing.ToSHA256(user.Password);
                 using var connection = new SqlConnection(conString);
                 connection.Open();
                 var query = "INSERT INTO [Users] (Surname, Name, SecondName, Sex, Birthday, Login, Password, Role) values (@Surname, @Name, @Secondname, @Sex, @Birthday, @Login, @Password, @Role); SELECT CAST(SCOPE_IDENTITY() as int)";
                var id = await connection.QuerySingleAsync<int>(query, new { Surname = user.Surname, Name = user.Name, SecondName = user.SecondName, Sex = user.Sex, Birthday = user.Birthday, Login = user.Login, Password = hashPassword, Role = Role.User });
                user.Id = id;
                StaticValues.CurrentUser = user;
                return true;
                }
            catch (Exception ex)
                {
                    return false;
                }

                
        }
        public async Task<UserDTO> AutorizationAsync(User user)
        {
            var userDTO = new UserDTO();
            try
            {
                var hashPassword = Hashing.ToSHA256(user.Password);
                using var connection = new SqlConnection(conString);
                connection.Open();
                var query = "SELECT * FROM [Users] WHERE Login = @Login AND Password = @Password";
                userDTO.User = await connection.QuerySingleAsync<User>(query, new { Login = user.Login, Password = hashPassword });
                userDTO.Status = Status.Success;
            }
            catch (Exception ex)
            {
                userDTO.Status = Status.Error;
            }
            return userDTO;
        }
        public async Task<UserDTO> adminAutorizationAsync(User user)
        {
            var userDTO = new UserDTO();
            try
            {
                var hashPassword = Hashing.ToSHA256(user.Password);
                using var connection = new SqlConnection(conString);
                connection.Open();
                var query = "SELECT * FROM [Users] WHERE Login = @Login AND Password = @Password";
                userDTO.User = await connection.QuerySingleAsync<User>(query, new { Login = user.Login, Password = hashPassword });
                if (userDTO.User.Role == Role.Administrator)
                {
                    userDTO.Status = Status.Success;
                }
                else
                {
                    userDTO.Status = Status.Error;
                }
            }
            catch (Exception ex)
            {
                userDTO.Status = Status.Error;
            }
            return userDTO;
        }
        public async Task<List<UserInfo>> GetAdminListAsync()
        {
            using var connection = new SqlConnection(conString);
            connection.Open();
            var query = "SELECT u.Id, CASE WHEN u.SecondName IS NULL OR u.SecondName = '' THEN u.Surname + ' ' + LEFT(u.Name, 1) + '.' ELSE u.Surname + ' ' + LEFT(u.Name, 1) + '.' + LEFT(u.SecondName, 1) + '.' END AS Initials, (SELECT  COUNT(t.Id) FROM Todos t WHERE t.UserID = u.Id ) AS Count FROM Users u WHERE Role = 2";
            var userList = await connection.QueryAsync<UserInfo>(query);     
            return userList.ToList();
        }

        public async Task<User> GetAsync(int id)
        {
            var user = new User();
            using var connection = new SqlConnection(conString);
            connection.Open();
            var query = "SELECT * FROM [Users] WHERE Id = @Id";
            user = await connection.QuerySingleAsync<User>(query, new { Id = id });
            return user;
        }

        public async Task<BlockUserResult> BlockUserAsync(int id)
        {
            try
            {    
                if (StaticValues.CurrentUser.Role != Role.Administrator)
                {
                    return BlockUserResult.NoAdminRights;
                }
                var user = new User();
                using var connection = new SqlConnection(conString);
                connection.Open();
                string sql = "SELECT CAST(CASE WHEN EXISTS (SELECT 1 FROM Users WHERE Id = @Id) THEN 1 ELSE 0 END as BIT)";
                var exists = await connection.ExecuteScalarAsync<bool>(sql, new { Id = id });
                if (exists == false)
                {
                    return BlockUserResult.UserNotFaund;
                }
                var query1 = "SELECT * FROM [Users] WHERE Id = @Id";
                user = await connection.QuerySingleAsync<User>(query1, new { Id = id });
                if (user.IsBlocked == true)
                {
                    return BlockUserResult.UserAlreadyBlocked;
                }
                var query2 = "UPDATE [Users] SET IsBlocked = 1 WHERE Id = @Id";
                await connection.ExecuteAsync(query2, new { Id = id });
                return BlockUserResult.Succes;
            }
            catch (Exception ex)
            {

                return BlockUserResult.UnknownError;
            }
            
        }
        public async Task<UnlockUserResult> UnlockUserAsync(int id)
        {
            try
            {
                if (StaticValues.CurrentUser.Role != Role.Administrator)
                {
                    return UnlockUserResult.NoAdminRights;
                }
                var user = new User();
                using var connection = new SqlConnection(conString);
                connection.Open();
                string sql = "SELECT CAST(CASE WHEN EXISTS (SELECT 1 FROM Users WHERE Id = @Id) THEN 1 ELSE 0 END as BIT)";
                var exists = await connection.ExecuteScalarAsync<bool>(sql, new { Id = id });
                if (exists == false)
                {
                    return UnlockUserResult.UserNotFaund;
                }
                var query1 = "SELECT * FROM [Users] WHERE Id = @Id";
                user = await connection.QuerySingleAsync<User>(query1, new { Id = id });
                if (user.IsBlocked == false)
                {
                    return UnlockUserResult.UserAlreadyUnlocked;
                }
                var query2 = "UPDATE [Users] SET IsBlocked = 0 WHERE Id = @Id";
                await connection.ExecuteAsync(query2, new { Id = id });
                return UnlockUserResult.Succes;
            }
            catch (Exception ex)
            {

                return UnlockUserResult.UnknownError;
            }
        }
    }
}
