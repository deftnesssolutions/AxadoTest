using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Axado.DataAccess
{
    /*######
     * Programa:Interface de conexión para Base de Datos
     * Autor: GUSTAVO OVELAR
     * Fecha: 25/11/2015
    #####*/

    //Interface que sirve de base para la conexion al banco de datos con utilización del colector de basura(Garbage Collector)
    //que sera el encargado de limpiar qualquier objeto sin uso que este utilizando  memoria
    public interface IConnection : IDisposable
    {
        SqlConnection Open();//metodo para abrir Banco de Datos
        SqlConnection Get();//metodo para retornar la conexión al Banco de Datos
        void Close();//metodo para cerrar la conexión al Banco de Datos
    }
}
