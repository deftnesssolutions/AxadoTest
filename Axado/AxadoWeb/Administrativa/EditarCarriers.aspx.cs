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

        }
    }
}