using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;

namespace AxadoWeb
{
    public partial class Contato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage oEmail = new MailMessage();
                MailAddress sDe = new MailAddress("Gustavo" + "<gusove@gmail.com>"); /*COLOQUE AQUI UMA CAIXA VALIDA @seudomínio PARA QUE O ENVIO SEJA REALIZADO DE MODO NORMALIZADO*/
                MailAddress sRpt = new MailAddress("gusove@gmail.com");

                oEmail.To.Add("gusove@gmail.com"); //DIGITE AQUI O E-MAIL PARA O QUAL SERÁ ENCAMINHADO O FORMULARIO
                oEmail.From = sDe;
                oEmail.ReplyTo = sRpt;
                oEmail.Priority = System.Net.Mail.MailPriority.Normal;
                oEmail.IsBodyHtml = false;
                oEmail.Subject = "Mensagem do site da Axado Test";

                // Monta o corpo da mensagem a ser enviada
                StringBuilder mensagem = new StringBuilder();
                mensagem.Append("").Append(Environment.NewLine);
                mensagem.Append("Nome do Contato: " + txtNome.Text + "").Append(Environment.NewLine);
                mensagem.Append("").Append(Environment.NewLine);
                mensagem.Append("E-mail do Contato: " + txtEmail.Text + "").Append(Environment.NewLine);
                mensagem.Append("").Append(Environment.NewLine);
                mensagem.Append("Assunto: " + txtAssunto.Text + "").Append(Environment.NewLine);
                mensagem.Append("").Append(Environment.NewLine);
                mensagem.Append("Mensagem: " + txtMensagem.Text + "").Append(Environment.NewLine);
                mensagem.Append("").Append(Environment.NewLine);

                oEmail.Body = mensagem.ToString();

                SmtpClient oEnviar = new SmtpClient();
                oEnviar.Host = "gusove@gmail.com"; //DIGITE AQUI O NOME DO SERVIDOR DE SMTP QUE VOCÊ IRA UTILIZAR
                oEnviar.Credentials = new System.Net.NetworkCredential("gusove@gmail.com", "123456"); // DIGITE UM E-MAIL VÁLIDO E UMA SENHA PARA AUTENTICACAO NO SERVIDOR SMTP
                oEnviar.Send(oEmail);
                oEmail.Dispose();

                txtNome.Text = "";
                txtEmail.Text = "";
                txtAssunto.Text = "";
                txtMensagem.Text = "";

                lblResposta.Text = "O email foi enviado com sucesso";
            }
            catch (Exception)
            {
                lblResposta.Text = "Houve uma falha no envio do email.";
                throw;
            }

        }
    }
}