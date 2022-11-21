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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '\u25CF';
            tbConfirmPassword.PasswordChar = '\u25CF';
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
        private void pnlTop_MouseHover(object sender, EventArgs e)
        {
            pnlTop.Cursor = Cursors.Hand;
        }
        private void lblLogin_MouseHover(object sender, EventArgs e)
        {
            lblLogin.Cursor = Cursors.Hand;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MyForm = new Login();
            MyForm.Closed += (s, args) => this.Close();
            MyForm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "" || tbPassword.Text == "" || tbConfirmPassword.Text == "")
            {
                MessageBox.Show("Error. All fields are required.");
                return;
            }

            if(tbPassword.Text == tbConfirmPassword.Text)
            {
                var user = new User(0, tbUsername.Text, tbPassword.Text);
                var (ok, ex) = User.Create(user);

                if (ok)
                {
                    var text = $"Register Success.";
                    MessageBox.Show(text);
                    lblLogin_Click(sender, e);
                } 
                else
                {
                    if(ex != null && ex.Message.Contains("unique"))
                    {
                        MessageBox.Show("Error. The username is already registered!");
                    }
                    else
                    {
                        MessageBox.Show("An error occured when creating user.");
                    }
                }
            } 
            else
            {
                MessageBox.Show("Password and Confirm Password not match!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            showPass();
        }

        private void btnShowConfirmPass_Click(object sender, EventArgs e)
        {
            showPass();
        }

        private void showPass()
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
    }
}
