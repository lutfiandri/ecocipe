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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
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
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCard.Controls.Add(this.pbPicture);
            this.pnlCard.Controls.Add(this.lblDetails);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblCategory);
            this.pnlCard.Location = new System.Drawing.Point(15, 17);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(491, 451);
            this.pnlCard.TabIndex = 4;
            this.pnlCard.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.Color.Gainsboro;
            this.pbPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPicture.InitialImage")));
            this.pbPicture.Location = new System.Drawing.Point(0, 0);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(0);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Padding = new System.Windows.Forms.Padding(12);
            this.pbPicture.Size = new System.Drawing.Size(490, 319);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlCard);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(550, 485);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Panel pnlCard;
    }
}
