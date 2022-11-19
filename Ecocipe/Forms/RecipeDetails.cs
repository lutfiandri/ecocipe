using Ecocipe.Properties;
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

namespace Ecocipe.Forms
{
    public partial class RecipeDetails : Form
    {
        public RecipeDetails()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.Cursor = Cursors.Hand;
        }

        private void RecipeDetails_Load(object sender, EventArgs e)
        {
            loadRecipe();
        }

        private void loadRecipe()
        {
            RecipeDetail rd = new RecipeDetail();

            rd.Title = "Title bos";
            rd.Category = "Category data";
            rd.Picture = Resources.Sample;
            rd.Ingredients = "\nHai\nskdadhjad\naksjhdhkasjhda\njkahdskjahdkjahskdajh\nahsdka\nsdadsa\njjk\nhhh\nhhh\nhhhhhhh\nhhh\nh\nh\njkjk\njhjkhk\njjjj\njjj\njkkjhk\njkhkjhkhjk\njkhkhjkh\nkjhk\njkhkh\njkkh\nkhjkj\nhkj\nhk\njhk\nkhj\nsdad";
            rd.Steps = "Steps";

            flowLayoutPanel.Controls.Add(rd);
        }
    }
}
