namespace Ecocipe.Forms
{
    partial class AddRecipe
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.rtbIngredients = new System.Windows.Forms.RichTextBox();
            this.rtbSteps = new System.Windows.Forms.RichTextBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblImageLink = new System.Windows.Forms.Label();
            this.tbImageLink = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbTitle.Location = new System.Drawing.Point(60, 281);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(392, 32);
            this.tbTitle.TabIndex = 0;
            // 
            // tbCategory
            // 
            this.tbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbCategory.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCategory.Location = new System.Drawing.Point(60, 361);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(392, 32);
            this.tbCategory.TabIndex = 1;
            // 
            // rtbIngredients
            // 
            this.rtbIngredients.Location = new System.Drawing.Point(60, 446);
            this.rtbIngredients.Name = "rtbIngredients";
            this.rtbIngredients.Size = new System.Drawing.Size(392, 142);
            this.rtbIngredients.TabIndex = 3;
            this.rtbIngredients.Text = "";
            // 
            // rtbSteps
            // 
            this.rtbSteps.Location = new System.Drawing.Point(60, 643);
            this.rtbSteps.Name = "rtbSteps";
            this.rtbSteps.Size = new System.Drawing.Size(392, 158);
            this.rtbSteps.TabIndex = 4;
            this.rtbSteps.Text = "";
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.BackColor = System.Drawing.Color.Transparent;
            this.lblRecipeName.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRecipeName.Location = new System.Drawing.Point(56, 258);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(121, 20);
            this.lblRecipeName.TabIndex = 7;
            this.lblRecipeName.Text = "Recipe Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Inter", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(158, 79);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 40);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add Recipe";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(519, 23);
            this.panelTop.TabIndex = 8;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseHover += new System.EventHandler(this.panelTop_MouseHover);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCategory.Location = new System.Drawing.Point(56, 338);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(121, 20);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Region Origin:";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.BackColor = System.Drawing.Color.Transparent;
            this.lblIngredients.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIngredients.Location = new System.Drawing.Point(56, 423);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(104, 20);
            this.lblIngredients.TabIndex = 10;
            this.lblIngredients.Text = "Ingredients:";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.BackColor = System.Drawing.Color.Transparent;
            this.lblSteps.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSteps.Location = new System.Drawing.Point(56, 620);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(60, 20);
            this.lblSteps.TabIndex = 11;
            this.lblSteps.Text = "Steps:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnSubmit.Location = new System.Drawing.Point(268, 841);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(184, 53);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblImageLink
            // 
            this.lblImageLink.AutoSize = true;
            this.lblImageLink.BackColor = System.Drawing.Color.Transparent;
            this.lblImageLink.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageLink.ForeColor = System.Drawing.SystemColors.Control;
            this.lblImageLink.Location = new System.Drawing.Point(56, 175);
            this.lblImageLink.Name = "lblImageLink";
            this.lblImageLink.Size = new System.Drawing.Size(113, 20);
            this.lblImageLink.TabIndex = 14;
            this.lblImageLink.Text = "Image (Link):";
            // 
            // tbImageLink
            // 
            this.tbImageLink.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImageLink.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbImageLink.Location = new System.Drawing.Point(60, 198);
            this.tbImageLink.Name = "tbImageLink";
            this.tbImageLink.Size = new System.Drawing.Size(392, 32);
            this.tbImageLink.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(60, 841);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(193, 53);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(519, 977);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblImageLink);
            this.Controls.Add(this.tbImageLink);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.rtbSteps);
            this.Controls.Add(this.rtbIngredients);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.tbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecipe";
            this.Load += new System.EventHandler(this.AddRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.RichTextBox rtbIngredients;
        private System.Windows.Forms.RichTextBox rtbSteps;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblImageLink;
        private System.Windows.Forms.TextBox tbImageLink;
        private System.Windows.Forms.Button btnCancel;
    }
}