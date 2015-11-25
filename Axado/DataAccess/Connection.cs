using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    /*######
     * Programa:Implementación de la Interface de conexión al Base de Datos
     * Autor: GUSTAVO OVELAR
     * Fecha: 04/11/2012
    #####*/

    //Aqui creamos la conexión propiamente dicha, asignando el String de Conexión, la apertura de la Base de Datos
    //el Cierre y la Liberación de memoria atravez del Garbage Collector(GC.SuppressFinalize(this))
    public class Connection : IConnection
    {
        private SqlConnection _connectionString;

        #region Constructor de la Clase
        //Constructor
        public Connection()
        {
            _connectionString = new SqlConnection("User Id=postgres;Password=postgres;Host=localhost;Database=axadotest");
        }
        #endregion

        #region Implementación de Metodos de la Interface

        //Abre conexión
        public SqlConnection Open()
        {
            if (_connectionString.State == ConnectionState.Closed)
            {
                _connectionString.Open();
            }
            return _connectionString;
        }

        //Retorna conexión
        public SqlConnection Get()
        {
            return this.Open();
        }

        //Cierra conexión
        public void Close()
        {
            if (_connectionString.State == ConnectionState.Open)
            {
                _connectionString.Close();
            }
        }
        //Llama el Garbage Collector
        public void Dispose()
        {
            this.Close();
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
