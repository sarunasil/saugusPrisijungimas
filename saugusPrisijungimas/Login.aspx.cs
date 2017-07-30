using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace saugusPrisijungimas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies.Clear();
            
        }

        protected void Login_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (!ConnectionUtility.checkDBConnection())
            {
                database.Utilities.MsgBox("Cannot connect to the database.", this.Page, this);
                LogoBtn_Click(sender, null);
            }

            if (ConnectionUtility.checkPassword(Login1.UserName, Login1.Password))
            {
                ConnectionUtility.user_role role = ConnectionUtility.user_role.non;
                try
                {
                    role = ConnectionUtility.getType(Login1.UserName);
                    if (role == ConnectionUtility.user_role.non)
                        throw new Exception();
                }
                catch (Exception)
                {
                    database.Utilities.MsgBox("Username not found. Internal problems. Contact Administrator", this.Page, this);
                    FormsAuthentication.RedirectToLoginPage();
                }

                createAuthenticationCookie(Login1.UserName, Login1.RememberMeSet);

                if (role == ConnectionUtility.user_role.admin)
                {
                    Response.Redirect("~/admin/admin_page.aspx", true);
                }
                else if (role == ConnectionUtility.user_role.user )
                {
                    Response.Redirect("~/user/user_page.aspx", true);
                }

                //FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
            }
            

        }

        protected void LogoBtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Login.aspx", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        private void createAuthenticationCookie(string username, bool persistent)//technically this whole thing could be skipped just saying: Response.Cookies.add(FormsAuthentication.getAuthCookie(username, persistent));
        {
            /*
            HttpCookie cookie = FormsAuthentication.GetAuthCookie(username, persistent);
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);

            FormsAuthenticationTicket tkt = new FormsAuthenticationTicket(ticket.Version, ticket.Name, ticket.IssueDate, ticket.Expiration, ticket.IsPersistent, ticket.UserData, ticket.CookiePath);

            cookie.Value = FormsAuthentication.Encrypt(tkt);

            Response.Cookies.Add(cookie);
            */
            Response.Cookies.Add(FormsAuthentication.GetAuthCookie(username, persistent));
            
        }
    }
}