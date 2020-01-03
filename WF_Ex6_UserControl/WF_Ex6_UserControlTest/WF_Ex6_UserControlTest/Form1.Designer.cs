namespace WF_Ex6_UserControlTest
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
            this.userControl1 = new System.Windows.Forms.UserControl();
            this.labelTimer1 = new WF_Ex6_UserControl_ClassLibrary.LabelTimer();
            this.SuspendLayout();
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(1, 1);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(150, 50);
            this.userControl1.TabIndex = 0;
            // 
            // labelTimer1
            // 
            this.labelTimer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTimer1.Location = new System.Drawing.Point(1, 1);
            this.labelTimer1.Name = "labelTimer1";
            this.labelTimer1.Size = new System.Drawing.Size(150, 40);
            this.labelTimer1.TabIndex = 1;
            this.labelTimer1.Load += new System.EventHandler(this.labelTimer1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 43);
            this.Controls.Add(this.labelTimer1);
            this.Controls.Add(this.userControl1);
            this.Name = "Form1";
            this.Text = "User Control Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.UserControl userControl1;
        private WF_Ex6_UserControl_ClassLibrary.LabelTimer labelTimer1;
    }
}

