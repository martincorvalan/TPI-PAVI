﻿using ProjectoPAV.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPAV.DataAccessLayer
{
    class ObjetivoDao
    {
        public IList<Objetivo> ConsultarObjetivo(Dictionary<string, object> param)
        {
            List<Objetivo> listaObjetivo = new List<Objetivo>();

            String SqlQuery = string.Concat("SELECT *",
                                            "FROM Objetivos  ",
                                            "WHERE borrado = 0 ");
            if (param.ContainsKey("Nombre"))
                SqlQuery += " AND (nombre_corto LIKE '%'+ @Nombre + '%') ";



            var resQuery = DataManager.GetInstance().ConsultaSQL(SqlQuery, param);

            foreach (DataRow row in resQuery.Rows)
            {
                listaObjetivo.Add(ObjectMapping(row));
            }

            return listaObjetivo;
        }


        public bool Insert(Objetivo oObjetivo)
        {
            var param = new Dictionary<string, object>();
            String sqlQuery = string.Concat("INSERT INTO [dbo].[Objetivos] ",
                                            "([nombre_corto] ",
                                            ",[nombre_largo] ",
                                            ",[borrado]) ",
                                            "VALUES ",
                                            "(@nombreC ",
                                            ", @nombreL ",
                                            ", 0)");

            param.Add("nombreC", oObjetivo.nombre_corto);
            param.Add("nombreL", oObjetivo.nombre_largo);


            return DataManager.GetInstance().EjecutarSqlParametros(sqlQuery, param) > 0;
        }


        public bool Modificar(Objetivo oObjetivo)
        {
            var param = new Dictionary<string, object>();
            String sqlQuery = string.Concat("UPDATE[dbo].[Objetivos] ",
                                            "SET[nombre_corto] = @nombre_corto ",
                                            ",[nombre_largo] = @nombre_largo ",
                                            "WHERE id_objetivo = @id_objetivo"
                                             );

            param.Add("id_objetivo", oObjetivo.id_objetivo);
            param.Add("nombre_corto", oObjetivo.nombre_corto);
            param.Add("nombre_largo", oObjetivo.nombre_largo);

            return DataManager.GetInstance().EjecutarSqlParametros(sqlQuery, param) > 0;
        }


        public bool borrar(Objetivo oObjetivo)
        {
            var param = new Dictionary<string, object>();
            String sqlQuery = string.Concat("UPDATE[dbo].[Objetivos] ",
                                            "SET[borrado] = 1 ",
                                            "WHERE id_objetivo = @id_objetivo ");
            param.Add("id_objetivo", oObjetivo.id_objetivo);

            return DataManager.GetInstance().EjecutarSqlParametros(sqlQuery, param) != 0;

        }


        private Objetivo ObjectMapping(DataRow row)
        {


            Objetivo oObjetivo = new Objetivo
            {
                nombre_corto = row["nombre_corto"].ToString(),
                id_objetivo = Convert.ToInt32(row["id_objetivo"].ToString()),
                nombre_largo = row["nombre_largo"].ToString()
            };
            return oObjetivo;
        }
    }
}