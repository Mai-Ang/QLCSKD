﻿namespace QLCSKD
{
    partial class Start
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
            this.pn_contentstart = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pn_contentstart
            // 
            this.pn_contentstart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_contentstart.Location = new System.Drawing.Point(0, 0);
            this.pn_contentstart.Name = "pn_contentstart";
            this.pn_contentstart.Size = new System.Drawing.Size(622, 568);
            this.pn_contentstart.TabIndex = 0;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 568);
            this.Controls.Add(this.pn_contentstart);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_contentstart;
    }
}