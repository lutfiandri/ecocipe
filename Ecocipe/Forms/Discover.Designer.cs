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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiscover
            // 
            this.lblDiscover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscover.AutoSize = true;
            this.lblDiscover.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscover.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDiscover.Location = new System.Drawing.Point(222, 153);
            this.lblDiscover.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscover.Name = "lblDiscover";
            this.lblDiscover.Size = new System.Drawing.Size(148, 37);
            this.lblDiscover.TabIndex = 0;
            this.lblDiscover.Text = "Discover";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Discover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDiscover);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Discover";
            this.Text = "Discover";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Discover_FormClosing);
            this.Load += new System.EventHandler(this.Discover_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiscover;
        private System.Windows.Forms.Label label1;
    }
}