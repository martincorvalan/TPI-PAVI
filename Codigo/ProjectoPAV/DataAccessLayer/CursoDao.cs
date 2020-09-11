using ProjectoPAV.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
