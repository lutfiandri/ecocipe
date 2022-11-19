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

namespace Ecocipe.Forms
{
    public partial class RecipeDetail : UserControl
    {
        private NpgsqlConnection conn;
        private Recipe recipe;
        private RecipeDetails container;
        public RecipeDetail(Recipe recipeArg, NpgsqlConnection connection, RecipeDetails containerArg)
        {
            InitializeComponent();
            conn = connection;
            recipe = recipeArg;
            container = containerArg;
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
            if(MessageBox.Show($"Do you want to delete {Title}?") == DialogResult.OK)
            {
                var sql = @"select * from delete_recipe(:_id)";
                var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", recipe.Id);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show($"{recipe.Title} successfully deleted.");
                    container.Close();
                }
                else
                {
                    MessageBox.Show("An error occured");
                }
            }
        }
    }
}
