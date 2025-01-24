﻿using Microsoft.Data.SqlClient;
using AspNetCoreIntro.Models;


namespace AspNetCoreIntro.Services
{
    public class UsersSqlServerService : IUsersService
    {
        
        string connStr = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jbelb\\Desktop\\AspNetCoreIntro\\App_Data\\UsersDB.mdf;Integrated Security=True;Connect Timeout=30";


        public IEnumerable<UserModel> GetUsers()
        {
            List<UserModel> users = new List<UserModel> ();
            try
            {
                using var connection = new SqlConnection(connStr);

                connection.Open();

                var sql = "SELECT * FROM Users";
                using var command = new SqlCommand(sql, connection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    UserModel user = new UserModel(
                        reader.GetInt32(0),
                           reader.GetString(1),
                              reader.GetString(2),
                                 Convert.ToDateTime(reader[3]),
                                      reader.GetString(4)
                  );

                    users.Add(user);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }

            return users;
        }

        public UserModel? GetUsersById(int id)
        {
            try
            {
                using var connection = new SqlConnection(connStr);

                connection.Open();

                var sql = "SELECT * FROM Users WHERE Id = " + id;
                using var command = new SqlCommand(sql, connection);
                var reader = command.ExecuteReader();
                if (reader.Read()) //la if solo per singolo dato 
                {
                    UserModel user = new UserModel(
                        reader.GetInt32(0),
                           reader.GetString(1),
                              reader.GetString(2),
                                 Convert.ToDateTime(reader[3]),
                                      reader.GetString(4)
                    );
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
         }
        
        
        public UserModel? AddUser(UserModel user)
        {
            Random rnd = new Random();
            int id = rnd.Next(1000,100000);
            try
            {
                using var connection = new SqlConnection(connStr);

                connection.Open();

                var sql = $"INSERT INTO Users VALUES ({id}, '{user.Name}', '{user.Surname}', '{user.DateOfBirth}', '{user.Pob}')";
                using var command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                return user;

            }
            catch (Exception e)
            {   
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public int DeleteUsersById(int id)
        {
            try
            {
                using var connection = new SqlConnection(connStr);

                connection.Open();

                var sql = "DELETE FROM Users WHERE Id = " + id;
                using var command = new SqlCommand(sql, connection);
                var reader = command.ExecuteNonQuery();

                return 1;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return -1;
            }
        }
    }
}
