using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ADO.NET
{
    public class UserRepository : IUserRepository
    {
        public string _conn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public UserRepository()
        {           
        }
        public void Create(UserDTO user)
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = @"
INSERT INTO Users (Login, Password, RoleId)
VALUES (@login,@pass,@roleid)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@login", user.Login);
                    cmd.Parameters.AddWithValue("@pass", user.Password);
                    cmd.Parameters.AddWithValue("@roleid", user.RoleId);
                    int rowAffected = cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM Users WHERE Id = @Id;";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Id", id);
                    int rowAffected = cmd.ExecuteNonQuery();

                }
            }
        }

        public UserDTO Get(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM Users Where Id=@id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    UserDTO user = new UserDTO();
                    while (reader.Read())
                    {
                        user.Id = (int)reader["ID"];
                        user.Login = reader["Login"].ToString();
                        user.Password = reader["Password"].ToString();
                        user.RoleId = (int)reader["RoleId"];
                    }
                    return user;
                }
            }
        }
        public List<UserDTO> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users";
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    var users = new List<UserDTO>();
                    while (reader.Read())
                    {
                        users.Add(new UserDTO()
                        {
                            Id = (int)reader["Id"],
                            Login = reader["Login"].ToString(),
                            Password = reader["Password"].ToString(),
                            RoleId = (int)reader["RoleId"]
                        });
                    }
                    return users;
                }
            }
        }

        public UserDTO LoginData(string login)
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "exec spUsers_GetByLogin @Login";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Login", login);
                    SqlDataReader reader = cmd.ExecuteReader();
                    UserDTO user = new UserDTO();
                    while (reader.Read())
                    {
                        user.Id = (int)reader["Id"];
                        user.Login = reader["Login"].ToString();
                        user.Password = reader["Password"].ToString();
                    }
                    return user;
                }
            }
        }
    }
}
