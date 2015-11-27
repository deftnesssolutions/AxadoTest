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
    public partial class CadastrarClassificacaoCarrier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            using (IConnection Conexion = new Connection())
            {

                IDao<ClassificacaoEntity> dao = new ClassificacaoCarrierDAO(Conexion);
                ClassificacaoEntity entity = new ClassificacaoEntity();//Objeto tipo Modulos(taentityla)
                ClassificacaoEntity result = new ClassificacaoEntity();
                entity.tipo = ddlTipo.SelectedItem.Text;
                entity.descricao = txtDescricao.Text;
                // gravo los datos como registro en la tabla modulos
                result = dao.Insert(entity);
                lblMsg.Text = "Dados guardado com sucesso!";
                txtDescricao.Text = "";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrativa/ConsultarClassificacao.aspx");
        }
    }
}