using Axado.DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Axado.DataAccess;
using Axado.Entities;
using System.Collections.Generic;


namespace Axado.TestUnit
{
  
    [TestClass()]
    public class CarriersDAOTest
    {
        public string xid = "1";
        [TestMethod()]
        public void crudTest()
        {
            //insertTest();
            updateTest();
            findOrDefaultTest();
            allTest();
            //deleteTest();
        }

        public void insertTest()
        {
            using (IConnection Conexion = new Connection())
            {
                
                IDao<CarriersEntity> dao = new CarriersDAO(Conexion);
                CarriersEntity entity = new CarriersEntity();//Objeto tipo Modulos(taentityla)
                CarriersEntity result = new CarriersEntity();
                entity.id_classificacao = 2;
                entity.tipo = "T";
                entity.nome = "teste insert";
                entity.endereco ="Teste";
                entity.cidade = "Teste";
                entity.estado = "TT";
                entity.cpf = "99999999-99";
                entity.cnpj = "999999/99/999";
                entity.inscr_estadual = "9999-999";
                entity.nro_placa = "9999-99";
                entity.estado_placa = "TT";
                // gravo los datos como registro en la tabla modulos
                result = dao.Insert(entity);
                Assert.AreEqual(entity.nome, result.nome);
            }
        }

        public void updateTest()
        {
            using (IConnection Conexion = new Connection())
            {
                IDao<CarriersEntity> dao = new CarriersDAO(Conexion);
                CarriersEntity entity = dao.FindOrDefault(xid);

                entity.nome = "teste update";

                bool esperado = true;
                bool result = dao.Update(entity);
                Assert.AreEqual(esperado, result);
            }
        }

        public void findOrDefaultTest()
        {
            using (IConnection Conexion = new Connection())
            {
                IDao<CarriersEntity> dao = new CarriersDAO(Conexion);
                CarriersEntity entity = dao.FindOrDefault(xid);
                string esperado = xid;
                string result = entity.id_carrier.ToString();
                Assert.AreEqual(esperado, result);
            }
        }
        public void allTest()
        {
            using (IConnection Conexion = new Connection())
            {
                IDao<CarriersEntity> dao = new CarriersDAO(Conexion);
                CarriersEntity entity = new CarriersEntity();
                List<CarriersEntity> lista = new List<CarriersEntity>();
                foreach (CarriersEntity b in dao.All())
                {
                    entity.id_carrier = b.id_carrier;
                    entity.tipo = b.tipo;
                    entity.nome = b.nome;
                    entity.endereco = b.endereco;
                    entity.cidade = b.cidade;
                    entity.estado = b.estado;
                    entity.cpf = b.cpf;
                    entity.cnpj = b.cnpj;
                    entity.inscr_estadual = b.inscr_estadual;
                    entity.nro_placa = b.nro_placa;
                    entity.estado_placa = b.estado_placa;
                    entity.id_classificacao = b.id_classificacao;
                    lista.Add(entity);
                }

                int esperado = 0;
                int result = lista.Count;
                Assert.AreNotEqual(esperado, result);
            }
        }

        public void deleteTest()
        {
            using (IConnection Conexion = new Connection())
            {
                IDao<CarriersEntity> dao = new CarriersDAO(Conexion);
                CarriersEntity entity = dao.FindOrDefault(xid);
                bool esperado = true;
                bool result = dao.Delete(entity);
                Assert.AreEqual(esperado, result);
            }
        }
    }
}
