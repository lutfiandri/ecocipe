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
            var recipes = Recipe.FindAll(user.Id);
            PopulateItems(recipes);
        }

        private void PopulateItems(List<Recipe> recipes)
        {
            //populate here
            Card[] cards = new Card[recipes.Count];
            //loop trough each items
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = new Card(recipes[i], user);
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
