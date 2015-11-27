using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AxadoWeb.Administrativa
{
    public partial class ConsultarClassificacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["texto"] != null && Session["texto"] != "")
                {
                    txtBusca.Text = Session["texto"].ToString();
                    ListView1.DataBind();
                }
            }
        }

        protected void btnPesquisa_Click(object sender, EventArgs e)
        {
            Session["texto"] = txtBusca.Text;
            ListView1.DataBind();

            if (txtBusca.Text != "")
                lblContador.Text = "Encontrados " + DataPager1.TotalRowCount.ToString() + " anúncios.";
            else
                lblContador.Text = "Encontrados 0 Transportadoras.";
        }

        protected void ListView1_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            LinkButton LinkButton3;
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                LinkButton3 = (LinkButton)e.Item.FindControl("LinkButton3");
                if (LinkButton3 != null)
                {
                    //Label lbdescricao = (Label)e.Item.FindControl("lbdescricao");
                    //string descricao = lbdescricao.Text;
                    string prompt = "javascript:return confirm('Desea realmente excluir a Classificação: ?')";
                    LinkButton3.Attributes.Add("onClick", prompt);
                }
            }
        }
    }
}