﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Ex3
{
    public partial class Form1 : Form
    {
        bool shouldPaint = false; // determines whether to paint
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
            this.Cursor = Cursors.Default;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint) // check if mouse button is being pressed
            {
                this.Cursor = Cursors.Hand;
                // draw a circle where the mouse pointer is present
                using (Graphics graphics = CreateGraphics())
                {
                    graphics.FillEllipse(
                    new SolidBrush(Color.BlueViolet), e.X, e.Y, 4, 4);
                } // end using; calls graphics.Dispose()
            } // end if
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            charLabel.Text = "Key pressed: " + e.KeyChar;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            charLabel.Text = "";
            keyInfoLabel.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keyInfoLabel.Text =
                "Alt: " + (e.Alt ? "Yes" : "No") + '\n' +
                "Shift: " + (e.Shift ? "Yes" : "No") + '\n' +
                "Ctrl: " + (e.Control ? "Yes" : "No") + '\n' +
                "KeyCode: " + e.KeyCode + '\n' +
                "KeyData: " + e.KeyData + '\n' +
                "KeyValue: " + e.KeyValue;
        }
    }
}
