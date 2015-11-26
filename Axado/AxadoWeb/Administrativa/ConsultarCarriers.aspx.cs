using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Axado.DataAccess;
using Axado.Entities;
using Axado.DAO;
using System.Data;

namespace AxadoWeb.Administrativa
{
    public partial class ConsultarCarriers : System.Web.UI.Page
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
    }
}