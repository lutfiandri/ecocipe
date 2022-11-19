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
using Npgsql;

namespace Ecocipe.Forms
{
    public partial class Card : UserControl
    {
        private Recipe recipe;
        private NpgsqlConnection conn;
        public Card(Recipe recipeArg, NpgsqlConnection connection)
        {
            InitializeComponent();
            recipe = recipeArg;
            conn = connection;
        }

        #region Properties

        private string _title;
        private string _category;
        private string _details;
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
        public string Details
        {
            get { return _details; }   
            set { _details = value; lblDetails.Text = value; }
        }
        [Category("Custom Props")]
        public string PictureUrl
        {
            get { return _pictureUrl; }
            set { _pictureUrl = value; pbPicture.ImageLocation = value; }
        }

        #endregion

        private void pnlCard_Click(object sender, EventArgs e)
        {
            var myForm = new RecipeDetails(recipe, conn);
            myForm.Show();
        }
    }
}
