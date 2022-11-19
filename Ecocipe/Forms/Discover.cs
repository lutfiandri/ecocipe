using Ecocipe.Models;
using Ecocipe.Properties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
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
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=kyubi123;Database=ecocipe";

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

                var recipes = new List<Recipe>();

                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        recipes.Add(new Recipe(
                            data.GetInt32(0),
                            data.GetString(1),
                            data.GetInt32(2),
                            data.GetString(3),
                            data.GetString(4),
                            data.GetString(5),
                            data.GetString(6)
                        ));
                    }
                }

                PopulateItems(recipes);

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

        private void PopulateItems(List<Recipe> recipes)
        {
            //populate here
            Card[] cards = new Card[recipes.Count];
            //loop trough each items
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = new Card();
                cards[i].Title = recipes[i].Title;
                cards[i].Category = recipes[i].Category;
                cards[i].Details = "Get data details somewhere";
                cards[i].Picture = Resources.Sample;
                //add to flowlayout
                //if (flowLayoutPanel.Controls.Count > 0)
                //{
                //    flowLayoutPanel.Controls.Clear();
                //}
                //else
                flowLayoutPanel.Controls.Add(cards[i]);

            }
        }
    }
}
