namespace Ecocipe.Forms
{
    partial class Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlBorder.SuspendLayout();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.Controls.Add(this.pnlCard);
            this.pnlBorder.Location = new System.Drawing.Point(10, 10);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(495, 455);
            this.pnlBorder.TabIndex = 0;
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCard.Controls.Add(this.pbPicture);
            this.pnlCard.Controls.Add(this.lblDetails);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblCategory);
            this.pnlCard.Location = new System.Drawing.Point(2, 2);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(491, 451);
            this.pnlCard.TabIndex = 5;
            this.pnlCard.Click += new System.EventHandler(this.card_Click);
            this.pnlCard.MouseEnter += new System.EventHandler(this.card_Hover);
            this.pnlCard.MouseLeave += new System.EventHandler(this.card_Hover);
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.Color.Gainsboro;
            this.pbPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPicture.InitialImage")));
            this.pbPicture.Location = new System.Drawing.Point(0, 0);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(0);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Padding = new System.Windows.Forms.Padding(12);
            this.pbPicture.Size = new System.Drawing.Size(491, 319);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            this.pbPicture.Click += new System.EventHandler(this.card_Click);
            this.pbPicture.MouseEnter += new System.EventHandler(this.card_Hover);
            this.pbPicture.MouseLeave += new System.EventHandler(this.card_Hover);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblDetails.Location = new System.Drawing.Point(29, 407);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(177, 16);
            this.lblDetails.TabIndex = 3;
            this.lblDetails.Text = "Lorem ipsum dolor sit amet";
            this.lblDetails.Click += new System.EventHandler(this.card_Click);
            this.lblDetails.MouseEnter += new System.EventHandler(this.card_Hover);
            this.lblDetails.MouseLeave += new System.EventHandler(this.card_Hover);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Inter ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(26, 341);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 34);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title Here";
            this.lblTitle.Click += new System.EventHandler(this.card_Click);
            this.lblTitle.MouseEnter += new System.EventHandler(this.card_Hover);
            this.lblTitle.MouseLeave += new System.EventHandler(this.card_Hover);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblCategory.Location = new System.Drawing.Point(28, 378);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(87, 20);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            this.lblCategory.Click += new System.EventHandler(this.card_Click);
            this.lblCategory.MouseEnter += new System.EventHandler(this.card_Hover);
            this.lblCategory.MouseLeave += new System.EventHandler(this.card_Hover);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlBorder);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(523, 485);
            this.pnlBorder.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategory;
    }
}
