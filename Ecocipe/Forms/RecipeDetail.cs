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
    public partial class RecipeDetail : UserControl
    {
        public RecipeDetail()
        {
            InitializeComponent();
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
    }
}
