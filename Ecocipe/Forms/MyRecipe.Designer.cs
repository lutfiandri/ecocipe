namespace Ecocipe.Forms
{
    partial class MyRecipe
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
            this.lblMyRecipe = new System.Windows.Forms.Label();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMyRecipe
            // 
            this.lblMyRecipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMyRecipe.AutoSize = true;
            this.lblMyRecipe.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyRecipe.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMyRecipe.Location = new System.Drawing.Point(281, 184);
            this.lblMyRecipe.Name = "lblMyRecipe";
            this.lblMyRecipe.Size = new System.Drawing.Size(225, 49);
            this.lblMyRecipe.TabIndex = 1;
            this.lblMyRecipe.Text = "My Recipe";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddRecipe.Location = new System.Drawing.Point(305, 283);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(173, 23);
            this.btnAddRecipe.TabIndex = 2;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // MyRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.lblMyRecipe);
            this.Name = "MyRecipe";
            this.Text = "MyRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyRecipe;
        private System.Windows.Forms.Button btnAddRecipe;
    }
}