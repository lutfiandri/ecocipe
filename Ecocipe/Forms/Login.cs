using Ecocipe.Models;
using Ecocipe.Utils;
using Npgsql;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '\u25CF';
        }

        //Drag form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, uint wMsg, int wParam, int lParam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = User.FindOne(tbUsername.Text);
            if(user != null)
            {
                if (tbPassword.Text == user.Password)
                {
                    this.Hide();
                    var dashboard = new Dashboard(user);
                    dashboard.Closed += (s, args) => this.Close();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            } else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '\u25CF')
            {
                tbPassword.PasswordChar = '\0';
                btnShowPass.Text = "Hide";
            }
            else
            {
                tbPassword.PasswordChar = '\u25CF';
                btnShowPass.Text = "Show";
            }
        }

        private void pnlTop_MouseHover(object sender, EventArgs e)
        {
            pnlTop.Cursor = Cursors.Hand;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MyForm = new Register();
            MyForm.Closed += (s, args) => this.Close();
            MyForm.Show();
        }

        private void btnLoginAsGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboard = new Dashboard();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }
    }
}
