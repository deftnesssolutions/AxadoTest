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
    public partial class CadastrarCarriers : System.Web.UI.Page
    {
        public DataTable dt;
        public void agregarColumnaDT()
        {
            dt = new DataTable("DrowList");
            dt.Columns.Add("id");
            dt.Columns.Add("descricao"); 
        }

        public void popularDrowListCalassificado()
        {
            agregarColumnaDT();
            DataRow dr1;
            dr1 = dt.NewRow();
            dt.Rows.Add(dr1);
            List<ClassificacaoEntity> lista = null;
            using (IConnection Conexion = new Connection())
            {
                IDao<ClassificacaoEntity> dao = new ClassificacaoCarrierDAO(Conexion);
                ClassificacaoEntity entity = new ClassificacaoEntity();
                lista= new List<ClassificacaoEntity>();
                foreach (ClassificacaoEntity x in dao.All())
                {
                    DataRow dr;
                    dr = dt.NewRow();
                    dr[0] = x.id_classificacao;
                    dr[1] = x.descricao;
                    dt.Rows.Add(dr);
                }
            }
        }

        public void limparCampos()
        {
            ddlCassificacao.SelectedValue = "";
            ddlTipo.SelectedValue = "";
            txtDescricao.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            ddluf.SelectedValue= "";
            txtcpfcnpj.Text = "";
            txtcpfcnpj.Text = "";
            txtInscr_estadual.Text = "";
            txtPlaca.Text = "";
            ddlEstadoPlaca.SelectedValue = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                popularDrowListCalassificado();
                ddlCassificacao.DataSource = dt;
                ddlCassificacao.DataTextField = "descricao";
                ddlCassificacao.DataValueField = "id";
                ddlCassificacao.DataBind();
                //ddlCassificacao.Items.Insert(0, "Selecione...");
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {

            using (IConnection Conexion = new Connection())
            {

                IDao<CarriersEntity> dao = new CarriersDAO(Conexion);
                CarriersEntity entity = new CarriersEntity();//Objeto tipo Modulos(taentityla)
                CarriersEntity result = new CarriersEntity();
                entity.id_classificacao =Convert.ToInt32(ddlCassificacao.SelectedValue);
                entity.tipo = ddlTipo.SelectedValue;
                entity.nome = txtDescricao.Text;
                entity.endereco = txtEndereco.Text;
                entity.cidade = txtCidade.Text;
                entity.estado = ddluf.SelectedValue;
                entity.cpf = txtcpfcnpj.Text;
                entity.cnpj = txtcpfcnpj.Text;
                entity.inscr_estadual = txtInscr_estadual.Text;
                entity.nro_placa = txtPlaca.Text;
                entity.estado_placa = ddlEstadoPlaca.SelectedValue;
                // gravo los datos como registro en la tabla modulos
                result = dao.Insert(entity);
                lblMsg.Text = "Dados guardado com sucesso!";
                limparCampos();
            }
        }

    }
}