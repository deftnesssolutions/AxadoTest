using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    /*######
    * Programa:Interface DAO PARA CRUD de entidades en Banco de Datos
    * Autor: GUSTAVO OVELAR
    * Fecha: 04/11/2012
   #####*/

    //Interface que sirve de base para la manipulación de datos de las Tablas en el banco de datos con utilización del colector de basura(Garbage Collector)
    //que sera el encargado de limpiar qualquier objeto sin uso que este utilizando  memoria
    public interface IDao<T> : IDisposable
        where T : class,new()
    {
        T Insert(T model);//metodo para insertar registro
        bool Update(T model);//metodo para actualizar registro
        bool Delete(T model);//metodo para eliminar registro 
        T FindOrDefault(params object[] keys);//metodo para retornar un registro
        IEnumerable<T> All();//metodo para retornar todos los registros
        IEnumerable<T> rowsFilter(string p1, string p2, string p3);//metodo para retornar registros filtrado por parametros
    }
}
