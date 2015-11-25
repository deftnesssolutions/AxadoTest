using Axado.DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Axado.DataAccess;
using Axado.Entities;
using System.Collections.Generic;

namespace Axado.TestUnit
{
  
    [TestClass()]
    public class ClassificacaoCarrierDAOTest
    {
        public string xid = "2";
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

                IDao<ClassificacaoEntity> dao = new ClassificacaoCarrierDAO(Conexion);
                ClassificacaoEntity entity = new ClassificacaoEntity();//Objeto tipo Modulos(taentityla)
                ClassificacaoEntity result = new ClassificacaoEntity();
                entity.tipo = "T";
                entity.descricao = "teste insert";
                // gravo los datos como registro en la tabla modulos
                result = dao.Insert(entity);
                Assert.AreEqual(entity.descricao, result.descricao);
            }
        }

        public void updateTest()
        {
            using (IConnection Conexion = new Connection())
            {
                IDao<ClassificacaoEntity> dao = new ClassificacaoCarrierDAO(Conexion);
                ClassificacaoEntity entity = dao.FindOrDefault(xid);


                entity.descricao = "teste update";

                bool esperado = true;
                bool result = dao.Update(entity);
                Assert.AreEqual(esperado, result);
            }
        }

        public void findOrDefaultTest()
        {
            using (IConnection Conexion = new Connection())
            {
                IDao<ClassificacaoEntity> dao = new ClassificacaoCarrierDAO(Conexion);
                ClassificacaoEntity entity = dao.FindOrDefault(xid);
                string esperado = xid;
                string result = entity.id_classificacao.ToString();
                Assert.AreEqual(esperado, result);
            }
        }
        public void allTest()
        {
            using (IConnection Conexion = new Connection())
            {
                IDao<ClassificacaoEntity> dao = new ClassificacaoCarrierDAO(Conexion);
                ClassificacaoEntity entity = new ClassificacaoEntity();
                List<ClassificacaoEntity> lista = new List<ClassificacaoEntity>();
                foreach (ClassificacaoEntity b in dao.All())
                {
                    entity.id_classificacao = b.id_classificacao;
                    entity.tipo = b.tipo;
                    entity.descricao = b.descricao;
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
                IDao<ClassificacaoEntity> dao = new ClassificacaoCarrierDAO(Conexion);
                ClassificacaoEntity entity = dao.FindOrDefault(xid);
                bool esperado = true;
                bool result = dao.Delete(entity);
                Assert.AreEqual(esperado, result);
            }
        }
    }
}
