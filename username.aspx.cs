using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie
{
    public partial class username : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Request.QueryString["username"];
            Response.Write($"Username loggato è {user}");

            if (user is null)
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] != null)
            {
                HttpCookie cookie = new HttpCookie("username");
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }

            Response.Redirect("Default.aspx");

            
        }
    }
}