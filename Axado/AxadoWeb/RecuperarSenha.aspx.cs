using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace AxadoWeb
{
    public partial class RecuperarSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                string novaSenha = "123456"; //gerar nova senha

                MembershipUser usr = Membership.GetUser(Membership.GetUserNameByEmail(txtEmail.Text));

                if (usr != null)
                {
                    string resetPwd = usr.ResetPassword();
                    usr.ChangePassword(resetPwd, novaSenha);

                    lblResposta.Text = "A nova senha foi enviada para o seu email com sucesso!";
                }
                else
                    lblResposta.Text = "Esse email não foi encontrado em nossa base de dados. Por favor, entre com seu email de login.";
            }
        }
    }
}