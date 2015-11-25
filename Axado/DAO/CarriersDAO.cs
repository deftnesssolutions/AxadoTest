using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Axado.DAO;
using Axado.DataAccess;
using Axado.Entities;
using System.Data.SqlClient;
using System.Data;
namespace Axado.DAO
{
    public class CarriersDAO:IDao<CarriersEntity>
    {
        private IConnection _conexion;
        public CarriersDAO(IConnection Conexion)
        {
            this._conexion = Conexion;
        }

        public CarriersEntity Insert(CarriersEntity model)
        {
            using (SqlCommand cmd = _conexion.Get().CreateCommand())
            {
                string query = "INSERT INTO carriers ";
                query += "(tipo,nome,endereco,cidade,estado,cpf,cnpj,inscr_estadual,nro_placa,estado_placa,id_classificacao) ";
                query += "VALUES(@tipo,@nome,@endereco,@cidade,@estado,@cpf,@cnpj,@inscr_estadual,@nro_placa,@estado_placa,@id_classificacao) ";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = model.tipo;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = model.nome;
                cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = model.endereco;
                cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = model.cidade;
                cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = model.estado;
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = model.cpf;
                cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = model.cnpj;
                cmd.Parameters.Add("@inscr_estadual", SqlDbType.VarChar).Value = model.inscr_estadual;
                cmd.Parameters.Add("@nro_placa", SqlDbType.VarChar).Value = model.nro_placa;
                cmd.Parameters.Add("@estado_placa", SqlDbType.VarChar).Value = model.estado_placa;
                cmd.Parameters.Add("@id_classificacao", SqlDbType.Int).Value = model.id_classificacao;

                model.id_carrier = int.Parse(cmd.ExecuteScalar().ToString());
            }
            return model;
        }

        public bool Update(CarriersEntity model)
        {
            bool _ret = false;
            using (SqlCommand cmd = _conexion.Get().CreateCommand())
            {
                string query = "UPDATE carriers SET ";
                query += "tipo=@tipo,nome=@nome,endereco=@endereco,cidade=@cidade,estado=@estado,cpf=@cpf,cnpj=@cnpj, ";
                query += "inscr_estadual=@inscr_estadual,nro_placa=@nro_placa,estado_placa=@estado_placa,id_classificacao=@id_classificacao ";
                query += "WHERE id_carrier=@id_carrier";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add("@id_carrier", SqlDbType.Int).Value = model.id_carrier;
                cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = model.tipo;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = model.nome;
                cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = model.endereco;
                cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = model.cidade;
                cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = model.estado;
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = model.cpf;
                cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = model.cnpj;
                cmd.Parameters.Add("@inscr_estadual", SqlDbType.VarChar).Value = model.inscr_estadual;
                cmd.Parameters.Add("@nro_placa", SqlDbType.VarChar).Value = model.nro_placa;
                cmd.Parameters.Add("@estado_placa", SqlDbType.VarChar).Value = model.estado_placa;
                cmd.Parameters.Add("@id_classificacao", SqlDbType.Int).Value = model.id_classificacao;
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    _ret = true;
                }
            }
            return _ret; 
        }

        public bool Delete(CarriersEntity model)
        {
            bool _ret = false;
            using (SqlCommand cmd = _conexion.Get().CreateCommand())
            {
                string query = "DELETE FROM carriers WHERE id_carrier=@id_carrier";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.Parameters.Add("@id_carrier", SqlDbType.Int).Value = model.id_carrier;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    _ret = true;
                }
            }
            return _ret;
        }

        public CarriersEntity FindOrDefault(params object[] keys)
        {
            CarriersEntity entity = null;
            using (SqlCommand cmd = _conexion.Get().CreateCommand())
            {
                string query = "SELECT ";
                query += "id_carrier,tipo,nome,endereco,cidade,estado,cpf,cnpj,inscr_estadual,nro_placa,estado_placa,id_classificacao ";
                query += "FROM carriers WHERE id_carrier=@id_carrier ";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.Parameters.Add("@id_carrier", SqlDbType.Int).Value = keys[0];

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        entity = new CarriersEntity();
                        reader.Read();
                        entity.id_carrier = reader.GetInt32(0);
                        entity.tipo = reader.IsDBNull(1) == false ? reader.GetString(1).ToString().Trim() : "";
                        entity.nome = reader.IsDBNull(2) == false ? reader.GetString(2).ToString().Trim() : "";
                        entity.endereco = reader.IsDBNull(3) == false ? reader.GetString(3).ToString().Trim() : "";
                        entity.cidade = reader.IsDBNull(4) == false ? reader.GetString(4).ToString().Trim() : "";
                        entity.estado = reader.IsDBNull(5) == false ? reader.GetString(5).ToString().Trim() : "";
                        entity.cpf = reader.IsDBNull(6) == false ? reader.GetString(6).ToString().Trim() : "";
                        entity.cnpj = reader.IsDBNull(7) == false ? reader.GetString(7).ToString().Trim() : "";
                        entity.inscr_estadual = reader.IsDBNull(8) == false ? reader.GetString(8).ToString().Trim() : "";
                        entity.nro_placa = reader.IsDBNull(9) == false ? reader.GetString(9).ToString().Trim() : "";
                        entity.estado_placa = reader.IsDBNull(10) == false ? reader.GetString(10).ToString().Trim() : "";
                        entity.id_classificacao = reader.GetInt32(11); 
                    }
                }
            }
            return entity;
        }

        public IEnumerable<CarriersEntity> All()
        {
            using (SqlCommand cmd = _conexion.Get().CreateCommand())
            {
                string query = "SELECT ";
                query += "id_carrier,tipo,nome,endereco,cidade,estado,cpf,cnpj,inscr_estadual,nro_placa,estado_placa,id_classificacao ";
                query += "FROM carriers  ORDER BY id_carrier ";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            yield return new CarriersEntity()
                            {
                                id_carrier = reader.GetInt32(0),
                                tipo = reader.IsDBNull(1) == false ? reader.GetString(1).ToString().Trim() : "",
                                nome = reader.IsDBNull(2) == false ? reader.GetString(2).ToString().Trim() : "",
                                endereco = reader.IsDBNull(3) == false ? reader.GetString(3).ToString().Trim() : "",
                                cidade = reader.IsDBNull(4) == false ? reader.GetString(4).ToString().Trim() : "",
                                estado = reader.IsDBNull(5) == false ? reader.GetString(5).ToString().Trim() : "",
                                cpf = reader.IsDBNull(6) == false ? reader.GetString(6).ToString().Trim() : "",
                                cnpj = reader.IsDBNull(7) == false ? reader.GetString(7).ToString().Trim() : "",
                                inscr_estadual = reader.IsDBNull(8) == false ? reader.GetString(8).ToString().Trim() : "",
                                nro_placa = reader.IsDBNull(9) == false ? reader.GetString(9).ToString().Trim() : "",
                                estado_placa = reader.IsDBNull(10) == false ? reader.GetString(10).ToString().Trim() : "",
                                id_classificacao = reader.GetInt32(11), 
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<CarriersEntity> rowsFilter(string p1, string p2, string p3)
        {
            using (SqlCommand cmd = _conexion.Get().CreateCommand())
            {
                string query = "SELECT ";
                query += "id_carrier,tipo,nome,endereco,cidade,estado,cpf,cnpj,inscr_estadual,nro_placa,estado_placa,id_classificacao ";
                query += "FROM carriers WHERE upper(nome) LIKE upper(@nome) ||'%'";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = p1;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            yield return new CarriersEntity()
                            {
                                id_carrier = reader.GetInt32(0),
                                tipo = reader.IsDBNull(1) == false ? reader.GetString(1).ToString().Trim() : "",
                                nome = reader.IsDBNull(2) == false ? reader.GetString(2).ToString().Trim() : "",
                                endereco = reader.IsDBNull(3) == false ? reader.GetString(3).ToString().Trim() : "",
                                cidade = reader.IsDBNull(4) == false ? reader.GetString(4).ToString().Trim() : "",
                                estado = reader.IsDBNull(5) == false ? reader.GetString(5).ToString().Trim() : "",
                                cpf = reader.IsDBNull(6) == false ? reader.GetString(6).ToString().Trim() : "",
                                cnpj = reader.IsDBNull(7) == false ? reader.GetString(7).ToString().Trim() : "",
                                inscr_estadual = reader.IsDBNull(8) == false ? reader.GetString(8).ToString().Trim() : "",
                                nro_placa = reader.IsDBNull(9) == false ? reader.GetString(9).ToString().Trim() : "",
                                estado_placa = reader.IsDBNull(10) == false ? reader.GetString(10).ToString().Trim() : "",
                                id_classificacao = reader.GetInt32(11),
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
