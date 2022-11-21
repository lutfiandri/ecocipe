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
            recipes = Recipe.FindAll();
            PopulateItems(recipes);
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
                cards[i].Details = $"Created by: {recipes[i].Author.Username}";
                cards[i].PictureUrl = recipes[i].ImageUrl;
                
                flowLayoutPanel.Controls.Add(cards[i]);

            }
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var filteredRecipes = recipes.FindAll(recipe => {
                return recipe.Title.ToLower().Contains(tbSearch.Text.ToLower()) ||
                       recipe.Author.Username.ToLower().Contains(tbSearch.Text.ToLower()) ||
                       recipe.Category.ToLower().Contains(tbSearch.Text.ToLower());
            });
            PopulateItems(filteredRecipes);
        }
    }
}
