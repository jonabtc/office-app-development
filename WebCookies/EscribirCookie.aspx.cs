using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EscribirCookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookie = new HttpCookie("MyTestCookie");
        DateTime now = DateTime.Now;

        // Set the cookie value.
        myCookie.Value = now.ToString();
        // Set the cookie expiration date.
        myCookie.Expires = now.AddMinutes(1);

        // Add the cookie.
        Response.Cookies.Add(myCookie);

        Response.Write("<p> The cookie has been written.");
    }
}