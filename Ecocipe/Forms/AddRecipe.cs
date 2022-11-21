using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecocipe.Models;
using Ecocipe.Utils;
using Npgsql;

namespace Ecocipe.Forms
{
    public partial class AddRecipe : Form
    {
        //Fields
        private int borderSize = 2;
        private string type; // add | edit
        private Recipe initialRecipe;
        private User user;

        public AddRecipe(User user)
        {
            InitializeComponent();

            this.Padding = new Padding(borderSize); //border size
            this.BackColor = Color.FromArgb(19, 19, 19); //border color
            this.user = user;
        }

        public AddRecipe(NpgsqlConnection connection, string type, Recipe initialRecipe)
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //border size
            this.BackColor = Color.FromArgb(19, 19, 19); //border color
            this.type = type;
            this.initialRecipe = initialRecipe;

            if(type == "edit")
            {
                lblTitle.Text = "Edit Recipe";
            }
        }

        //Drag form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, uint wMsg, int wParam, int lParam);

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            var ok = false;

            if (type == "edit")
            {
                var newRecipe = new Recipe(initialRecipe.Id, tbTitle.Text, initialRecipe.Author, tbCategory.Text, tbImageLink.Text, rtbIngredients.Text, rtbSteps.Text);
                ok = Recipe.Update(newRecipe);
            } 
            else
            {
                var newRecipe = new Recipe(0, tbTitle.Text, user, tbCategory.Text, tbImageLink.Text, rtbIngredients.Text, rtbSteps.Text);
                ok = Recipe.Create(newRecipe);
            }

            if(ok)
            {
                var text = $"{tbTitle.Text} successfully added.";
                if (type == "edit") text = $"{tbTitle.Text} successfully edited.";
                MessageBox.Show(text);
                this.Close();
            } else
            {
                MessageBox.Show("An error occured");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTop_MouseHover(object sender, EventArgs e)
        {
            panelTop.Cursor = Cursors.Hand;
        }

        private void AddRecipe_Load(object sender, EventArgs e)
        {
            if(type == "edit")
            {
                tbImageLink.Text = initialRecipe.ImageUrl;
                tbTitle.Text = initialRecipe.Title;
                tbCategory.Text = initialRecipe.Category;
                rtbIngredients.Text = initialRecipe.Ingredients;
                rtbSteps.Text = initialRecipe.Steps;
            }
        }
    }
}
