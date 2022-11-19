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
using Npgsql;

namespace Ecocipe.Forms
{
    public partial class AddRecipe : Form
    {
        //Fields
        private int borderSize = 2;
        private NpgsqlConnection conn;

        public AddRecipe(NpgsqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
            this.Padding = new Padding(borderSize); //border size
            this.BackColor = Color.FromArgb(19, 19, 19); //border color
        }

        //Drag form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, uint wMsg, int wParam, int lParam);

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var sql = @"select * from insert_recipe(:_title, :_author_id, :_category, :_imageurl, :_ingredients, :_steps)";
            var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_title", tbTitle.Text);
            cmd.Parameters.AddWithValue("_author_id", 1);
            cmd.Parameters.AddWithValue("_category", tbCategory.Text);
            cmd.Parameters.AddWithValue("_imageurl", tbImageLink.Text);
            cmd.Parameters.AddWithValue("_ingredients", rtbIngredients.Text);
            cmd.Parameters.AddWithValue("_steps", rtbSteps.Text);

            if((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show($"{tbTitle.Text} successfully added.");
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
    }
}
