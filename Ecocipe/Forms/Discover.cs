using Ecocipe.Models;
using Ecocipe.Properties;
using Ecocipe.Utils;
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
        private List<Recipe> recipes;
        private User user;

        public Discover()
        {
            InitializeComponent();
        }

        public Discover(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Discover_Load(object sender, EventArgs e)
        {
            // get all recipes on load
            try
            {
                var sql = "select * from select_all_recipes()";
                //var db = new Database();

                var cmd = new NpgsqlCommand(sql, Database.Connection);
                var data = cmd.ExecuteReader();

                recipes = new List<Recipe>();

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
                data.Close();

                Console.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Discover_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void PopulateItems(List<Recipe> recipes)
        {
            //populate here
            Card[] cards = new Card[recipes.Count];
            //loop trough each items
            flowLayoutPanel.Controls.Clear();
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = new Card(recipes[i], user);
                cards[i].Title = recipes[i].Title;
                cards[i].Category = recipes[i].Category;
                cards[i].Details = $"Written by: Lutfi Andriyanto";
                cards[i].PictureUrl = recipes[i].ImageUrl;
                
                flowLayoutPanel.Controls.Add(cards[i]);

            }
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var filteredRecipes = recipes.FindAll(recipe => recipe.Title.ToLower().Contains(tbSearch.Text.ToLower()));
            PopulateItems(filteredRecipes);
        }
    }
}
