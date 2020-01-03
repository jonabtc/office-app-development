using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LeerCookies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookie = new HttpCookie("MyTestCookie");
        myCookie = Request.Cookies["MyTestCookie"];

        // Read the cookie information and display it.
        if (myCookie != null)
            Response.Write("<p>" + myCookie.Name + "<p>" + myCookie.Value);
        else
            Response.Write("not found");
    }
}