namespace Ecocipe
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelPage = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnMyRecipe = new System.Windows.Forms.Button();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panelMenu.Controls.Add(this.panelNav);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnMyRecipe);
            this.panelMenu.Controls.Add(this.btnDiscover);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 913);
            this.panelMenu.TabIndex = 0;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.panelNav.Location = new System.Drawing.Point(0, 201);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(8, 100);
            this.panelNav.TabIndex = 5;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelLogo.Controls.Add(this.btnMenu);
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(300, 201);
            this.panelLogo.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnMaximize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(300, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(962, 30);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // panelPage
            // 
            this.panelPage.BackColor = System.Drawing.SystemColors.Control;
            this.panelPage.Controls.Add(this.lblHome);
            this.panelPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPage.Location = new System.Drawing.Point(300, 30);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(962, 883);
            this.panelPage.TabIndex = 2;
            this.panelPage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPage_Paint);
            // 
            // lblHome
            // 
            this.lblHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblHome.Location = new System.Drawing.Point(271, 375);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(422, 49);
            this.lblHome.TabIndex = 5;
            this.lblHome.Text = "Welcome to Ecocipe";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(722, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(80, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(802, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(80, 30);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(882, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Ecocipe.Properties.Resources.iconLogout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 795);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(300, 118);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Tag = "Log out";
            this.btnLogout.Text = "     Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::Ecocipe.Properties.Resources.iconAbout;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 401);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(300, 100);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Tag = "About";
            this.btnAbout.Text = "     About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMyRecipe
            // 
            this.btnMyRecipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyRecipe.FlatAppearance.BorderSize = 0;
            this.btnMyRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyRecipe.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyRecipe.ForeColor = System.Drawing.Color.White;
            this.btnMyRecipe.Image = global::Ecocipe.Properties.Resources.iconRecipe;
            this.btnMyRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyRecipe.Location = new System.Drawing.Point(0, 301);
            this.btnMyRecipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMyRecipe.Name = "btnMyRecipe";
            this.btnMyRecipe.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnMyRecipe.Size = new System.Drawing.Size(300, 100);
            this.btnMyRecipe.TabIndex = 2;
            this.btnMyRecipe.Tag = "My Recipe";
            this.btnMyRecipe.Text = "     My Recipe";
            this.btnMyRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyRecipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyRecipe.UseVisualStyleBackColor = true;
            this.btnMyRecipe.Click += new System.EventHandler(this.btnMyRecipe_Click);
            // 
            // btnDiscover
            // 
            this.btnDiscover.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiscover.FlatAppearance.BorderSize = 0;
            this.btnDiscover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscover.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscover.ForeColor = System.Drawing.Color.White;
            this.btnDiscover.Image = global::Ecocipe.Properties.Resources.iconHome;
            this.btnDiscover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscover.Location = new System.Drawing.Point(0, 201);
            this.btnDiscover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnDiscover.Size = new System.Drawing.Size(300, 100);
            this.btnDiscover.TabIndex = 1;
            this.btnDiscover.Tag = "Discover";
            this.btnDiscover.Text = "     Discover";
            this.btnDiscover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 32;
            this.btnMenu.Location = new System.Drawing.Point(203, 48);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(80, 72);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Ecocipe.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(16, 48);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(179, 72);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 913);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelPage.ResumeLayout(false);
            this.panelPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnMyRecipe;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelPage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panelNav;
    }
}

