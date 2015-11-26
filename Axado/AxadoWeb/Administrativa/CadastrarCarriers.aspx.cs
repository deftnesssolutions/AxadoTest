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
    public partial class CadastrarCarriers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ClassificacaoEntity> lista = new List<ClassificacaoEntity>();
            using (IConnection Conexion = new Connection())
            {
                IDao<ClassificacaoEntity> dao = new ClassificacaoCarrierDAO(Conexion);
                ClassificacaoEntity entity = new ClassificacaoEntity();
               
                foreach (ClassificacaoEntity b in dao.All())
                {
                    entity.id_classificacao = b.id_classificacao;
                    entity.tipo = b.tipo;
                    entity.descricao = b.descricao;
                    lista.Add(entity);
                }
            }
            ddlCassificacao.DataSource = lista;
            ddlCassificacao.DataBind();
            ddlCassificacao.Items.Insert(0, "Selecione...");

        }
    }
}