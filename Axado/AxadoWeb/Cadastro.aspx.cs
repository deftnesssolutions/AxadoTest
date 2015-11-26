using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace AxadoWeb
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            FormsAuthentication.SetAuthCookie(RegisterUser.UserName, false /* createPersistentCookie */);

            MembershipUser usr = Membership.GetUser(RegisterUser.UserName);
            Guid userId = new Guid(usr.ProviderUserKey.ToString());

            TextBox txtTelefone = (TextBox)RegisterUser.CreateUserStep.ContentTemplateContainer.FindControl("txtTelefone");
                   

            //string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            //if (String.IsNullOrEmpty(continueUrl))
            //{
            //    continueUrl = "~/";
            //}
            Response.Redirect("~/Administrativa/Principal.aspx");
        }
    }
}