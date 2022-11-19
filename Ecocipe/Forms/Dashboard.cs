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

namespace Ecocipe
{
    public partial class Dashboard : Form
    {
        //Fields
        private int borderSize = 2;
        private Form activeForm;
        private Button currentButton;

        private NpgsqlConnection conn;
        private readonly string connstring = "Host=localhost;Port=5432;Username=postgres;Password=kyubi123;Database=ecocipe";

        //Constructor
        public Dashboard()
        {
            InitializeComponent();
            CollapseMenu();
            panelNav.Visible = false;
            this.Padding = new Padding(borderSize); //border size
            this.BackColor = Color.FromArgb(19, 19, 19); //border color
        }

        

        //Drag form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, uint wMsg, int wParam, int lParam);

        private void Form1_Load(object sender, EventArgs e)
        {
            // Open connection to postgres
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                Console.WriteLine("Database connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured when opening postgres connection.", ex.Message);
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured when closing postgres connection.", ex.Message);
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overriden Methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            //const int WM_SYSCOMMAND = 0x0112;
            //const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            //const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch(this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(15, 8, 8, 15);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        
        //Top Bar: Minimize, Maximize, Close
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Collapse & Expand Menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse Menu
            {
                panelMenu.Width = 100;
                pictureBoxLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else //Expand Menu
            {
                panelMenu.Width = 300;
                pictureBoxLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "    " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(24);
                }
            }
        }

        //Open child form
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelPage.Controls.Add(childForm);
            this.panelPage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }

        private void ActivateMenu(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableMenu();
                    currentButton = (Button)btnSender;
                    panelNav.Visible = true;
                    panelNav.Height = currentButton.Height;
                    panelNav.Top = currentButton.Top;
                }
            }

        }

        private void DisableMenu()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    panelNav.Visible = false;
                }
            }
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Discover(conn), sender);
            ActivateMenu(sender);
        }

        private void btnMyRecipe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MyRecipe(conn), sender);
            ActivateMenu(sender);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.About(), sender);
            ActivateMenu(sender);
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.About(), sender);
            DisableMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelPage_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
