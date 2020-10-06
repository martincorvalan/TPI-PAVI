using ProjectoPAV.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPAV.DataAccessLayer
{
    class CursoDao
    {
        public IList<Curso> GetAll()
        {
            List<Curso> listaCurso = new List<Curso>();
            
            String SqlQuery = string.Concat("SELECT c.id_curso, c.nombre, c.descripcion, c.fecha_vigencia, ca.nombre as 'nomcat' ",
                                            "FROM Cursos c ",
                                            "JOIN Categorias ca ON(c.id_categoria = ca.id_categoria) ",
                                            "WHERE c.borrado = 0 AND ca.borrado = 0");

            var resQuery = DataManager.GetInstance().ConsultaSQL(SqlQuery);

            foreach (DataRow row in resQuery.Rows)
            {
                listaCurso.Add(ObjectMapping(row));
            }

            return listaCurso;
        }

        public IList<Curso> ConsultarCurso(Dictionary<string, object> param)
        {
            List<Curso> listaCurso = new List<Curso>();

            String SqlQuery = string.Concat("SELECT c.id_curso, c.nombre, c.descripcion, c.fecha_vigencia, ca.nombre as 'nomcat', ca.id_categoria, c.borrado ",
                                            "FROM Cursos c ",
                                            "JOIN Categorias ca ON(c.id_categoria = ca.id_categoria) ",
                                            "WHERE 1 = 1");
            if (param.ContainsKey("Nombre"))
                SqlQuery += " AND (c.nombre LIKE '%'+ @Nombre + '%') ";
            if (param.ContainsKey("Fecha"))
                SqlQuery += " AND (c.fecha_vigencia >= @Fecha) ";
            if (param.ContainsKey("IdCategoria"))
                SqlQuery += " AND (ca.id_categoria = @IdCategoria) ";
            if (param.ContainsKey("Borrado"))
                SqlQuery += " AND (ca.borrado = 0) ";
            else
                SqlQuery += " AND (c.borrado = 0 AND ca.borrado = 0)";



            var resQuery = DataManager.GetInstance().ConsultaSQL(SqlQuery, param);

            foreach (DataRow row in resQuery.Rows)
            {
                listaCurso.Add(ObjectMapping(row));
            }

            return listaCurso;
        }

        public bool borrar(Curso oCurso)
        {
            var param = new Dictionary<string, object>();
            String sqlQuery = string.Concat("UPDATE[dbo].[Cursos] ",
                                            "SET[borrado] = 1 ",
                                            "WHERE id_curso = @id_curso ");
            param.Add("id_curso", oCurso.id_curso);

            return DataManager.GetInstance().EjecutarSqlParametros(sqlQuery, param) != 0;

        }

        public bool Insert(Curso oCurso)
        {
            var param = new Dictionary<string, object>();
            String sqlQuery = string.Concat("INSERT INTO [dbo].[Cursos] ",
                                            "([nombre] ",
                                            ",[descripcion] ",
                                            ",[fecha_vigencia] ",
                                            ",[id_categoria] ",
                                            ",[borrado]) ",
                                            "VALUES ",
                                            "(@nombre ",
                                            ", @descripcion ",
                                            ", @fecha " ,
                                            ", @id_categoria ",
                                            ", 0)");

            param.Add("id_curso", oCurso.id_curso);
            param.Add("nombre", oCurso.nombre);
            param.Add("Descripcion", oCurso.descripcion);
            param.Add("fecha", oCurso.fecha);
            param.Add("id_categoria", oCurso.categoria.id_categoria);

            return DataManager.GetInstance().EjecutarSqlParametros(sqlQuery, param) > 0;
        }

        public bool Modificar(Curso oCurso)
        {
            var param = new Dictionary<string, object>();
            String sqlQuery = string.Concat("UPDATE[dbo].[Cursos] ",
                                            "SET[nombre] = @nombre ",
                                            ",[descripcion] = @descripcion ",
                                            ",[fecha_vigencia] = @fecha ",
                                            ",[id_categoria] = @id_categoria ",
                                            ",[borrado] = @borrado ",
                                            "WHERE id_curso = @id_curso"
                                             );

            param.Add("id_curso", oCurso.id_curso);
            param.Add("nombre", oCurso.nombre);
            param.Add("Descripcion", oCurso.descripcion);
            param.Add("fecha", oCurso.fecha);
            param.Add("id_categoria", oCurso.categoria.id_categoria);
            if(oCurso.borrado == "Activo")
                param.Add("borrado", 0);
            else
                param.Add("borrado", 1);




            return DataManager.GetInstance().EjecutarSqlParametros(sqlQuery, param) > 0;
        }

        private Curso ObjectMapping(DataRow row)
        {
            Curso oCurso = new Curso
            {
                id_curso = Convert.ToInt32(row["id_curso"].ToString()),
                nombre = row["nombre"].ToString(),
                descripcion = row["descripcion"].ToString(),
                fecha = Convert.ToDateTime(row["fecha_vigencia"].ToString()),
                //borrado = row["borrado"].ToString(),
                borrado = row["borrado"].ToString() == "True" ? "Borrado" : "Activo",
                categoria = new Categoria
                {
                    nombre = row["nomcat"].ToString(),
                    id_categoria = Convert.ToInt32(row["id_categoria"].ToString())
                }

            };

            return oCurso;
        }
    }
}
