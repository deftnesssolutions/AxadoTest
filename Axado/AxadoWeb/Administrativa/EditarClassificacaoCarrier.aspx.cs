using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Axado.DataAccess;
using Axado.Entities;
using Axado.DAO;

namespace AxadoWeb.Administrativa
{
    public partial class EditarClassificacaoCarrier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string xid = Request.QueryString["ID"];
                using (IConnection Conexion = new Connection())
                {
                    IDao<ClassificacaoEntity> dao = new ClassificacaoCarrierDAO(Conexion);
                    ClassificacaoEntity entity = dao.FindOrDefault(xid);
                    ddlTipo.SelectedValue = entity.tipo;
                    txtDescricao.Text = entity.descricao;
                }
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            string xid = Request.QueryString["ID"];
            using (IConnection Conexion = new Connection())
            {
                IDao<ClassificacaoEntity> dao = new ClassificacaoCarrierDAO(Conexion);
                ClassificacaoEntity entity = dao.FindOrDefault(xid);
                entity.tipo = ddlTipo.SelectedValue;
                entity.descricao = txtDescricao.Text;
                dao.Update(entity);
                Response.Redirect("~/Administrativa/ConsultarClassificacao.aspx");
            }
        }
    }
}