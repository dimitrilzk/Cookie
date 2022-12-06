using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("username");
            cookie.Values["username"] = username.Text;
            cookie.Values["password"] = Convert.ToString(password.Text);
            Response.Cookies.Add(cookie);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect($"username.aspx?username={username.Text}");
        }
    }
}