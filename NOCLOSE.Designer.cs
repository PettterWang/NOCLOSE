﻿
namespace NOCLOSE
{
    partial class NOCLOSE
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
            this.components = new System.ComponentModel.Container();
            this.timer_Tracker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_Tracker
            // 
            this.timer_Tracker.Enabled = true;
            this.timer_Tracker.Interval = 1;
            this.timer_Tracker.Tick += new System.EventHandler(this.timer_Tracker_Tick);
            // 
            // NOCLOSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(264, 104);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NOCLOSE";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOCLOSE";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.NOCLOSE_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_Tracker;
    }
}