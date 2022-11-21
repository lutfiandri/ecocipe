using Ecocipe.Forms;
using Ecocipe.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecocipe.Models
{
    public class User
    {
        private int id;
        private string username;
        private string password;

        public int Id { get => id; }
        public string Username { get => username; }
        public string Password { get => password; }

        public User(int id, string username)
        {
            this.id = id;
            this.username = username;
            this.password = null;
        }

        public User(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public static User FindOne(string username)
        {
            try
            {
                var sql = "select * from select_user(:username)";

                var cmd = new NpgsqlCommand(sql, Database.Connection);
                cmd.Parameters.AddWithValue("username", username);
                var data = cmd.ExecuteReader();

                if (data.HasRows)
                {
                    data.Read();
                    var user = new User(
                        data.GetInt32(0),
                        data.GetString(1),
                        data.GetString(2)
                    );
                    data.Close();
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public static User FindOne(int id)
        {
            try
            {
                var sql = "select * from select_user(:id)";

                var cmd = new NpgsqlCommand(sql, Database.Connection);
                cmd.Parameters.AddWithValue("username", id);
                var data = cmd.ExecuteReader();

                if (data.HasRows)
                {
                    data.Read();
                    var user = new User(
                        data.GetInt32(0),
                        data.GetString(1),
                        data.GetString(2)
                    );
                    data.Close();
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public static (bool,Exception ex) Create(User user)
        {
            try
            {
                var sql = @"select * from insert_user(:username, :password)";
                var cmd = new NpgsqlCommand(sql, Database.Connection);
                cmd.Parameters.AddWithValue("username", user.Username);
                cmd.Parameters.AddWithValue("password", user.Password);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    return (true, null);
                }
                return (false, null);
            }
            catch (Exception ex)
            {
                return (false, ex);
            }
        }
    }
}
