﻿namespace WF_Ex6_UserControl
{
    partial class Form1
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
            this.clockUserControl1 = new WF_Ex6_UserControl.ClockUserControl();
            this.SuspendLayout();
            // 
            // clockUserControl1
            // 
            this.clockUserControl1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clockUserControl1.Location = new System.Drawing.Point(0, 1);
            this.clockUserControl1.Name = "clockUserControl1";
            this.clockUserControl1.Size = new System.Drawing.Size(150, 53);
            this.clockUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 55);
            this.Controls.Add(this.clockUserControl1);
            this.Name = "Form1";
            this.Text = "Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private ClockUserControl clockUserControl1;

    }
}

