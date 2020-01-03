using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Ex2
{
    public partial class Form1 : Form
    {
        // create variables that store the user's choice of options
        private MessageBoxIcon iconType;
        private MessageBoxButtons buttonType;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.displayLabel.Text = "";
        }

        private void buttonType_CheckedChanged(object sender, EventArgs e)
        {

            if (sender == okRadioButton) // display OK Button
                buttonType = MessageBoxButtons.OK;

            // display OK and Cancel Buttons
            else if (sender == okCancelRadioButton)
                buttonType = MessageBoxButtons.OKCancel;

             // display Abort, Retry and Ignore Buttons
            else if (sender == abortRetryIgnoreRadioButton)
                buttonType = MessageBoxButtons.AbortRetryIgnore;

            // display Yes, No and Cancel Buttons
            else if (sender == yesNoCancelRadioButton)
                buttonType = MessageBoxButtons.YesNoCancel;

            // display Yes and No Buttons
            else if (sender == yesNoRadioButton)
                buttonType = MessageBoxButtons.YesNo;

            // only on option left--display Retry and Cancel Buttons
            else
                buttonType = MessageBoxButtons.RetryCancel;
            // end method buttonType_CheckedChanged

        }

        private void iconType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == asteriskRadioButton) // display asterisk Icon
                iconType = MessageBoxIcon.Asterisk;

            // display error Icon
            else if (sender == errorRadioButton)
                iconType = MessageBoxIcon.Error;


            // display exclamation point Icon
            else if (sender == exclamationRadioButton)
                iconType = MessageBoxIcon.Exclamation;

            // display hand Icon
            else if (sender == handRadioButton)
                iconType = MessageBoxIcon.Hand;

            // display information Icon
            else if (sender == informationRadioButton)
                iconType = MessageBoxIcon.Information;

                       // display question mark Icon
            else if (sender == questionRadioButton)
                iconType = MessageBoxIcon.Question;

            // display stop Icon
            else if (sender == stopRadioButton)
                iconType = MessageBoxIcon.Stop;

            // only one option left--display warning Icon
            else
                iconType = MessageBoxIcon.Warning;

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This is your Custom MessageBox.", "Custon MessageBox",
                                buttonType, iconType);

            switch (result)
            {
                case DialogResult.OK:
                    displayLabel.Text = "OK was pressed.";
                    break;
                case DialogResult.Cancel:
                    displayLabel.Text = "Cancel was pressed.";
                    break;
                case DialogResult.Abort:
                    displayLabel.Text = "Abort was pressed.";
                    break;
                case DialogResult.Retry:
                    displayLabel.Text = "Retry was pressed.";
                    break;
                case DialogResult.Ignore:
                    displayLabel.Text = "Ignore was pressed.";
                    break;
                case DialogResult.Yes:
                    displayLabel.Text = "Yes was pressed.";
                    break;
                case DialogResult.No:
                    displayLabel.Text = "No was pressed.";
                    break;
            } // end switch
        }



    }
}
