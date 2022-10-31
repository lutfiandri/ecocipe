namespace Ecocipe.Forms
{
    partial class Discover
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
            this.lblDiscover = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiscover
            // 
            this.lblDiscover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscover.AutoSize = true;
            this.lblDiscover.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscover.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDiscover.Location = new System.Drawing.Point(296, 188);
            this.lblDiscover.Name = "lblDiscover";
            this.lblDiscover.Size = new System.Drawing.Size(194, 49);
            this.lblDiscover.TabIndex = 0;
            this.lblDiscover.Text = "Discover";
            // 
            // Discover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDiscover);
            this.Name = "Discover";
            this.Text = "Discover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiscover;
    }
}