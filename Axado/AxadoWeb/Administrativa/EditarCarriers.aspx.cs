using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Axado.Entities;
using Axado.DataAccess;
using Axado.DAO;

namespace AxadoWeb.Administrativa
{
    public partial class EditarCarriers : System.Web.UI.Page
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
                lista = new List<ClassificacaoEntity>();
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
                string xid = Request.QueryString["ID"];
                using (IConnection Conexion = new Connection())
                {
                    IDao<CarriersEntity> dao = new CarriersDAO(Conexion);
                    CarriersEntity entity = dao.FindOrDefault(xid);
                    ddlCassificacao.SelectedValue = entity.id_classificacao.ToString();
                    ddlTipo.SelectedValue = entity.tipo;
                    txtDescricao.Text = entity.nome;
                    txtEndereco.Text = entity.endereco;
                    txtCidade.Text = entity.cidade;
                    ddluf.SelectedValue = entity.estado;
                    txtcpfcnpj.Text = entity.cpf;
                    txtcpfcnpj.Text = entity.cnpj;
                    txtInscr_estadual.Text = entity.inscr_estadual;
                    txtPlaca.Text = entity.nro_placa;
                    ddlEstadoPlaca.SelectedValue = entity.estado_placa;
                }
            }
             
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            string xid = Request.QueryString["ID"];
            using (IConnection Conexion = new Connection())
            {
                IDao<CarriersEntity> dao = new CarriersDAO(Conexion);
                CarriersEntity entity = dao.FindOrDefault(xid);
                entity.id_classificacao = Convert.ToInt32(ddlCassificacao.SelectedValue);
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
                dao.Update(entity);
                Response.Redirect("~/Administrativa/ConsultarCarriers.aspx");
            }
        }

       
    }
}