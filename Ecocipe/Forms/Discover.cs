using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecocipe.Forms
{
    public partial class Discover : Form
    {
        public Discover()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        private string connstring = "Host=localhost;Port=5432;Username=lutfiandri;Password=glhf;Database=ecocipe";

        private void Discover_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                Console.WriteLine("Database connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured when opening postgres connection.", ex.Message);
            }

            // get all recipes on load
            try
            {
                var sql = "select * from select_all_recipes()";
                var cmd = new NpgsqlCommand(sql, conn);
                var data = cmd.ExecuteReader();
                // TODO: show to UI (create the UI first)
                Console.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Discover_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured when closing postgres connection.", ex.Message);
            }
        }
    }
}
