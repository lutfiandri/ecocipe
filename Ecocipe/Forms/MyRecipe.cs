using Ecocipe.Models;
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
using System.Windows.Forms;

namespace Ecocipe.Forms
{
    public partial class MyRecipe : Form
    {
        private User user;
        public MyRecipe(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            var myForm = new AddRecipe(user);
            myForm.Show();
        }

        private void MyRecipe_Load(object sender, EventArgs e)
        {
            // get all recipes on load
            try
            {
                var sql = "select * from select_all_recipes(:author_id)";
                var cmd = new NpgsqlCommand(sql, Database.Connection);
                cmd.Parameters.AddWithValue("author_id", user.Id);
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
                data.Close();

                Console.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PopulateItems(List<Recipe> recipes)
        {
            //populate here
            Card[] cards = new Card[recipes.Count];
            //loop trough each items
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = new Card(recipes[i], Database.Connection);
                cards[i].Title = recipes[i].Title;
                cards[i].Category = recipes[i].Category;
                cards[i].Details = "Written by: Lutfi Andriyanto (dummy)";
                cards[i].PictureUrl = recipes[i].ImageUrl;
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
