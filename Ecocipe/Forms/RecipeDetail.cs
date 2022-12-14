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
using Ecocipe.Models;
using Ecocipe.Utils;

namespace Ecocipe.Forms
{
    public partial class RecipeDetail : UserControl
    {
        private Recipe recipe;
        private RecipeDetails container;
        private User user;
        public dynamic parentForm;

        public RecipeDetail(Recipe recipeArg, RecipeDetails containerArg, User user, dynamic parentForm)
        {
            InitializeComponent();
            recipe = recipeArg;
            container = containerArg;
            this.user = user;
            this.parentForm = parentForm;
        }

        #region Properties

        private string _title;
        private string _category;
        private string _ingredients;
        private string _steps;
        private string _pictureUrl;

        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
        [Category("Custom Props")]
        public string Category
        {
            get { return _category; }
            set { _category = value; lblCategory.Text = value; }
        }
        [Category("Custom Props")]
        public string Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; gbIngredients.Text = value; }
        }
        [Category("Custom Props")]
        public string Steps
        {
            get { return _steps; }
            set { _steps = value; gbSteps.Text = value; }
        }
        [Category("Custom Props")]
        public string PictureUrl
        {
            get { return _pictureUrl; }
            set { _pictureUrl = value; pbImage.ImageLocation = value; }
        }

        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Do you want to delete {Title}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var ok = Recipe.Delete(recipe.Id);
                if (ok)
                {
                    MessageBox.Show($"{recipe.Title} deleted.");
                    container.Close();
                }
                else
                {
                    MessageBox.Show("An error occured when deleting recipe.");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var myForm = new AddRecipe("edit", recipe, parentForm);
            myForm.Show();
        }

        private void RecipeDetail_Load(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnDelete.Visible = false;

            if(user != null && recipe.Author.Id == user?.Id)
            {
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
        }
    }
}
