using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Options : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            responseLabel.Visible = true;
            idLabel.Visible = true;
            timeoutLabel.Visible = true;
            languageLink.Visible = true;
            recommendationsLink.Visible = true;

            promptLabel.Visible = false;
            languageList.Visible = false;
            submitButton.Visible = false;

            if (languageList.SelectedItem != null)
                responseLabel.Text += " You selected " +
                languageList.SelectedItem.Text;
            else
                responseLabel.Text += " You did not select a language.";

            idLabel.Text = "Your unique session ID is: " + Session.SessionID;

            timeoutLabel.Text = "Timeout: " + Session.Timeout + " minutes.";
        }

    }
    protected void submitButton_Click(object sender, EventArgs e)
    {
        if (languageList.SelectedItem != null)
            Session.Add(languageList.SelectedItem.Text,languageList.SelectedItem.Value);
    }
}