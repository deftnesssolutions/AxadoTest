using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Axado.Entities;
using Axado.DataAccess;
using Axado.DAO;
using System.Data.SqlClient;
using System.Data;

namespace Axado.DAO
{
    public class ClassificacaoCarrierDAO:IDao<ClassificacaoEntity>
    {
        private IConnection _conexion;
        public ClassificacaoCarrierDAO(IConnection Conexion)
        {
            this._conexion = Conexion;
        }

        public ClassificacaoEntity Insert(ClassificacaoEntity model)
        {
            using (SqlCommand cmd = _conexion.Get().CreateCommand())
            {
                string query = "INSERT INTO classificacao_carriers ";
                query += "(tipo, descricao) ";
                query += "VALUES(@tipo, @descricao) ";
                query += "; SELECT CAST(scope_identity() AS int)";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@tipo", model.tipo);
                cmd.Parameters.AddWithValue("@descricao", model.descricao);


                model.id_classificacao = int.Parse(cmd.ExecuteScalar().ToString());
            }
            return model;
        }

        public bool Update(ClassificacaoEntity model)
        {
            bool _ret = false;
            using (SqlCommand cmd = _conexion.Get().CreateCommand())
            {
                string query = "UPDATE classificacao_carriers SET ";
                query += "tipo=@tipo,descricao=@descricao ";
                query += "WHERE id_classificacao=@id_classificacao";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id_classificacao", model.id_classificacao);
                cmd.Parameters.AddWithValue("@tipo", model.tipo);
                cmd.Parameters.AddWithValue("@descricao", model.descricao);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    _ret = true;
                }
            }
            return _ret; 
        }

        public bool Delete(ClassificacaoEntity model)
        {
            bool _ret = false;
            using (SqlCommand cmd = _conexion.Get().CreateCommand())
            {
                string query = "DELETE FROM classificacao_carriers WHERE id_classificacao=@id_classificacao";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@id_classificacao", model.id_classificacao);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    _ret = true;
                }
            }
            return _ret;
        }

        public ClassificacaoEntity FindOrDefault(params object[] keys)
        {
            ClassificacaoEntity entity = null;
            using (SqlCommand cmd = _conexion.Get().CreateCommand())
            {
                string query = "SELECT ";
                query += "id_classificacao,tipo,descricao ";
                query += "FROM classificacao_carriers WHERE id_classificacao=@id_classificacao ";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@id_classificacao", keys[0]);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        entity = new ClassificacaoEntity();
                        reader.Read();
                        entity.id_classificacao = reader.GetInt32(0);
                        entity.tipo = reader.IsDBNull(1) == false ? reader.GetString(1).ToString().Trim() : "";
                        entity.descricao = reader.IsDBNull(2) == false ? reader.GetString(2).ToString().Trim() : "";
                        
                    }
                }
            }
            return entity;
        }

        public IEnumerable<ClassificacaoEntity> All()
        {
            using (SqlCommand cmd = _conexion.Get().CreateCommand())
            {
                string query = "SELECT ";
                query += "id_classificacao,tipo,descricao ";
                query += "FROM classificacao_carriers  ORDER BY id_classificacao ";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            yield return new ClassificacaoEntity()
                            {
                                id_classificacao = reader.GetInt32(0),
                                tipo = reader.IsDBNull(1) == false ? reader.GetString(1).ToString().Trim() : "",
                                descricao = reader.IsDBNull(2) == false ? reader.GetString(2).ToString().Trim() : "",
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<ClassificacaoEntity> rowsFilter(string p1, string p2, string p3)
        {
            using (SqlCommand cmd = _conexion.Get().CreateCommand())
            {
                string query = "SELECT ";
                query += "id_classificacao,tipo,descricao ";
                query += "FROM classificacao_carriers WHERE upper(descricao) LIKE upper(@descricao) ||'%'";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = p1;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            yield return new ClassificacaoEntity()
                            {
                                id_classificacao = reader.GetInt32(0),
                                tipo = reader.IsDBNull(1) == false ? reader.GetString(1).ToString().Trim() : "",
                                descricao = reader.IsDBNull(2) == false ? reader.GetString(2).ToString().Trim() : "",
                            };
                        }
                    }
                }
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
