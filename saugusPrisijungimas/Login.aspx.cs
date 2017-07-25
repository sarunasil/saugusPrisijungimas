using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace saugusPrisijungimas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void LogoBtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Login.aspx", true);
        }

        protected void Unnamed1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }
    }
}