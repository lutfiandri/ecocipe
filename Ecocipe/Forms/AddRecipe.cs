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

namespace Ecocipe.Forms
{
    public partial class AddRecipe : Form
    {
        //Fields
        private int borderSize = 2;

        public AddRecipe()
        {
            InitializeComponent();
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
