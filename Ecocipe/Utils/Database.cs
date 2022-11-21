using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Ecocipe.Utils
{
    public static class Database
    {
        private static NpgsqlConnection connection;

        public static NpgsqlConnection Connection { get => connection; }

        static Database()
        {
            try
            {
                MessageBox.Show("Please Migrate our database scheme first. Can be found in https://pastebin.com/hLigBEF6");
                var host = XtraInputBox.Show("PostgreSQL Host", "Database Configuration", "localhost");
                var port = XtraInputBox.Show("PostgreSQL Port", "Database Configuration", "5432");
                var username = XtraInputBox.Show("PostgreSQL Username", "Database Configuration", "postgres");
                var password = XtraInputBox.Show("PostgreSQL Password", "Database Configuration", "postgres");
                var database = XtraInputBox.Show("PostgreSQL Database", "Database Configuration", "ecocipe");
                //var connstring = "Host=localhost;Port=5432;Username=postgres;Password=kyubi123;Database=ecocipe";
                var connstring = $"Host={host};Port={port};Username={username};Password={password};Database={database}";

                connection = new NpgsqlConnection(connstring);
                connection.Open();
                Console.WriteLine("Database connected");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured when opening postgres connection.");
                Console.WriteLine(ex.Message);
                MessageBox.Show($"An error occured when opening postgres connection. {ex.Message}");
            }
        }

        public static bool Close()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Database closed");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured when closing postgres connection.");
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
