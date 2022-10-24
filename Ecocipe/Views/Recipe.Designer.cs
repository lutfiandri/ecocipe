namespace Ecocipe.Views
{
    partial class Recipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recipe));
            this.title = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBahan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listLangkah = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(51, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(207, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Rendang Maknyos";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.subtitle.Location = new System.Drawing.Point(53, 65);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(257, 16);
            this.subtitle.TabIndex = 1;
            this.subtitle.Text = "Babang Sidiq • Resep Original • ⭐⭐⭐ (3.2)";
            // 
            // image
            // 
            this.image.InitialImage = ((System.Drawing.Image)(resources.GetObject("image.InitialImage")));
            this.image.Location = new System.Drawing.Point(56, 95);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(480, 302);
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bahan";
            // 
            // listBahan
            // 
            this.listBahan.AutoSize = true;
            this.listBahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBahan.Location = new System.Drawing.Point(51, 436);
            this.listBahan.Name = "listBahan";
            this.listBahan.Size = new System.Drawing.Size(154, 144);
            this.listBahan.TabIndex = 4;
            this.listBahan.Text = "Daging sapi - 500 gram\nGaram - 1 sdt\nDaun salam - 2 lembar\nSereh, geprek - 1 bata" +
    "ng\nDaun jeruk - 5 lembar\nLengkuas, geprek - 3 cm\nKayu manis - 5 cm\nKecap manis -" +
    " 3 sdm\nSantan - 250 ml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 600);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Langkah Memasak";
            // 
            // listLangkah
            // 
            this.listLangkah.AutoSize = true;
            this.listLangkah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLangkah.Location = new System.Drawing.Point(53, 624);
            this.listLangkah.Name = "listLangkah";
            this.listLangkah.Size = new System.Drawing.Size(559, 80);
            this.listLangkah.TabIndex = 6;
            this.listLangkah.Text = resources.GetString("listLangkah.Text");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(56, 720);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modifikasi Resep Ini";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 789);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "                                                                                ";
            // 
            // Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listLangkah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBahan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recipe";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Recipe";
            this.Load += new System.EventHandler(this.Recipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label listBahan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label listLangkah;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}