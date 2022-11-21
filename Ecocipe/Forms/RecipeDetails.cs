using Ecocipe.Properties;
using Ecocipe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Npgsql;

namespace Ecocipe.Forms
{
    public partial class RecipeDetails : Form
    {
        private Recipe recipe;
        private User user;
        public RecipeDetails(Recipe recipeArg, User user)
        {
            InitializeComponent();
            recipe = recipeArg;
            this.user = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnClose.Cursor = Cursors.Hand;
        }

        private void RecipeDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            RecipeDetail rd = new RecipeDetail(recipe, this, user, this);

            rd.Title = recipe.Title;
            rd.Category = recipe.Category;
            rd.PictureUrl = recipe.ImageUrl;
            rd.Ingredients = $"\nINGREDIENTS\n{recipe.Ingredients}";
            rd.Steps = $"\nSTEPS\n{recipe.Ingredients}";

            flowLayoutPanel.Controls.Add(rd);
        }
    }
}
