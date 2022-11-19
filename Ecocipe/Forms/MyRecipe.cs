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
    public partial class MyRecipe : Form
    {
        public MyRecipe()
        {
            InitializeComponent();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            var myForm = new AddRecipe();
            myForm.Show();
        }
    }
}
