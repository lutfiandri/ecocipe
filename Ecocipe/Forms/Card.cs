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
        private User user;
        public Card(Recipe recipeArg, User user)
        {
            InitializeComponent();
            recipe = recipeArg;
            this.user = user;
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

        private void card_Click(object sender, EventArgs e)
        {   
            var myForm = new RecipeDetails(recipe, user);
            myForm.Show();
        }

        private void changeCursor()
        {
            if (this.Cursor == Cursors.Default)
            {
                this.Cursor = Cursors.Hand;
            }
            else this.Cursor = Cursors.Default;
        }

        private void stateHoverCard()
        {
            

            pnlBorder.BackColor = Color.FromArgb(255, 181, 0);
        }

        private void changeBorderColor()
        { 
            Color currColor = pnlBorder.BackColor;
            if(currColor == Color.Transparent)
            {
                pnlBorder.BackColor = Color.FromArgb(255, 181, 0);
            }
            else
            {
                pnlBorder.BackColor = Color.Transparent;
            }
        }

        private void card_MouseHover(object sender, EventArgs e)
        {
            changeCursor();
            stateHoverCard();
        }

        private void card_Hover(object sender, EventArgs e)
        {
            changeCursor();
            changeBorderColor();
        }
        private void card_MouseLeave(object sender, EventArgs e)
        {
            changeCursor();
            changeBorderColor();
        }

    }
}
