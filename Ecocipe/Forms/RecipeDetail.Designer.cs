namespace Ecocipe.Forms
{
    partial class RecipeDetail
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
            this.gbIngredients = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSteps = new System.Windows.Forms.GroupBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIngredients
            // 
            this.gbIngredients.Location = new System.Drawing.Point(79, 603);
            this.gbIngredients.Name = "gbIngredients";
            this.gbIngredients.Size = new System.Drawing.Size(524, 406);
            this.gbIngredients.TabIndex = 9;
            this.gbIngredients.TabStop = false;
            this.gbIngredients.Text = "Ingredients";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblCategory.Location = new System.Drawing.Point(75, 135);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(87, 20);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.lblTitle.Location = new System.Drawing.Point(70, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 49);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Nama Resep";
            // 
            // gbSteps
            // 
            this.gbSteps.Location = new System.Drawing.Point(79, 1026);
            this.gbSteps.Name = "gbSteps";
            this.gbSteps.Size = new System.Drawing.Size(524, 406);
            this.gbSteps.TabIndex = 10;
            this.gbSteps.TabStop = false;
            this.gbSteps.Text = "Steps";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(79, 174);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(524, 406);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 8;
            this.pbImage.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEdit.Location = new System.Drawing.Point(419, 1459);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(184, 53);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(220, 1459);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(193, 53);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // RecipeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbSteps);
            this.Controls.Add(this.gbIngredients);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblTitle);
            this.Name = "RecipeDetail";
            this.Size = new System.Drawing.Size(725, 1571);
            this.Load += new System.EventHandler(this.RecipeDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngredients;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSteps;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}
