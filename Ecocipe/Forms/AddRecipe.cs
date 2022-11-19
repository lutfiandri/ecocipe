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
using Npgsql;

namespace Ecocipe.Forms
{
    public partial class AddRecipe : Form
    {
        //Fields
        private int borderSize = 2;
        private NpgsqlConnection conn;
        private string type; // add | edit
        private Recipe initialRecipe;

        public AddRecipe(NpgsqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
            this.Padding = new Padding(borderSize); //border size
            this.BackColor = Color.FromArgb(19, 19, 19); //border color
        }

        public AddRecipe(NpgsqlConnection connection, string type, Recipe initialRecipe)
        {
            InitializeComponent();
            conn = connection;
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
            NpgsqlCommand cmd;
            if (type == "edit")
            {
                var sql = @"select * from update_recipe(:_id, :_title, :_category, :_imageurl, :_ingredients, :_steps)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", initialRecipe.Id);
                cmd.Parameters.AddWithValue("_title", tbTitle.Text);
                cmd.Parameters.AddWithValue("_category", tbCategory.Text);
                cmd.Parameters.AddWithValue("_imageurl", tbImageLink.Text);
                cmd.Parameters.AddWithValue("_ingredients", rtbIngredients.Text);
                cmd.Parameters.AddWithValue("_steps", rtbSteps.Text);
            } 
            else
            {
                var sql = @"select * from insert_recipe(:_title, :_author_id, :_category, :_imageurl, :_ingredients, :_steps)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_title", tbTitle.Text);
                cmd.Parameters.AddWithValue("_author_id", 1);
                cmd.Parameters.AddWithValue("_category", tbCategory.Text);
                cmd.Parameters.AddWithValue("_imageurl", tbImageLink.Text);
                cmd.Parameters.AddWithValue("_ingredients", rtbIngredients.Text);
                cmd.Parameters.AddWithValue("_steps", rtbSteps.Text);
            }

            if((int)cmd.ExecuteScalar() == 1)
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
