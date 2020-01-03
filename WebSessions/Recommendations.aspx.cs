using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Recommendations : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session.Count != 0)
        {
            foreach (string keyName in Session.Keys)
                booksListBox.Items.Add(keyName +
                " How to Program. ISBN#: " + Session[keyName]);
        }
        else
        {
            recommendationsLabel.Text = "No Recommendations";
            booksListBox.Items.Clear();
            booksListBox.Visible = false;
            languageLink.Text = "Click here to choose a language";
        }
    }
}