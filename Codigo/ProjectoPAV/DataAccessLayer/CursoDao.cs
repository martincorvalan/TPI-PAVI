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

        public bool borrar(int id)
        {
            String sqlQuery = string.Concat("UPDATE[dbo].[Cursos] ",
                                            "SET[borrado] = 1 ",
                                            "WHERE id_curso =" + id);

            return DataManager.GetInstance().EjecutarSql(sqlQuery) != 0;

        }

        public bool Insert(Dictionary<string, object> param)
        {   
            String sqlQuery = string.Concat("ALTER TABLE[Cursos] DROP COLUMN id_curso ",
                                            "ALTER TABLE[Cursos] ADD id_curso INT IDENTITY(1, 1)",
                                            "INSERT INTO [dbo].[Cursos] ",
                                            "([nombre] ",
                                            ",[descripcion] ",
                                            ",[fecha_vigencia] ",
                                            ",[id_categoria] ",
                                            ",[borrado]) ",
                                            "VALUES ",
                                            "(id_curso ",
                                            ",@nombre ",
                                            ",'descripcion' ",
                                            ",@fecha " ,
                                            ",1 ",
                                            ", 0)");

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
                //Falta crear la entidad Categoria
                categoria = row["nomcat"].ToString()
            };

            return oCurso;
        }
    }
}
