using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                // FIXME: move connstring to parameter (if needed)
                MessageBox.Show("hai");
                var connstring = "Host=localhost;Port=5432;Username=postgres;Password=kyubi123;Database=ecocipe";

                connection = new NpgsqlConnection(connstring);
                connection.Open();
                Console.WriteLine("Database connected");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured when opening postgres connection.");
                Console.WriteLine(ex.Message);
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
