using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace AxadoWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LoginUser_LoggedIn(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrativa/Principal.aspx");
        }
        protected void LoginUser_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (LoginUser.UserName.Contains("@")) //validação por email
            {
                string username = Membership.GetUserNameByEmail(LoginUser.UserName);

                if (username != null)
                {

                    if (Membership.ValidateUser(username, LoginUser.Password))
                    {
                        LoginUser.UserName = username;
                        e.Authenticated = true;
                    }
                    else
                    {
                        e.Authenticated = false;
                    }
                }
            }
            else // validação username normal
            {
                if (Membership.ValidateUser(LoginUser.UserName, LoginUser.Password))
                    e.Authenticated = true;
                else
                    e.Authenticated = false;
            }
        }
    }
}