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

        public bool AgregarObjetivos(List<Objetivo> objetivos, int id_curso)
        {
            DataManagerT dm = new DataManagerT();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                foreach (var itemObjetivo in objetivos)
                {

                    if (itemObjetivo.id_objetivo == 0)
                    {
                        var paramObj = new Dictionary<string, object>();
                        String sqlQueryObj = string.Concat("INSERT INTO [dbo].[Objetivos] ",
                                                        "([nombre_corto] ",
                                                        ",[nombre_largo] ",
                                                        ",[borrado]) ",
                                                        "VALUES ",
                                                        "(@nombreC ",
                                                        ", @nombreL ",
                                                        ", 0) ",

                                                       "INSERT INTO [dbo].[ObjetivosCursos] ",
                                                       "([id_objetivo] ",
                                                       ",[id_curso] ",
                                                       ",[puntos] ",
                                                       ",[borrado]) ",
                                                       "VALUES ",
                                                       "( ident_current('Objetivos')",
                                                       ", @id_curso ",
                                                       ", 4 ",
                                                       ", 0 )");

                        paramObj.Add("nombreC", itemObjetivo.nombre_corto);
                        paramObj.Add("nombreL", itemObjetivo.nombre_largo);
                        paramObj.Add("id_curso", id_curso);

                        dm.EjecutarSQL(sqlQueryObj, paramObj);
                        continue;
                    }

                    var paramObjxCurso = new Dictionary<string, object>();
                    paramObjxCurso.Add("id_objetivo", itemObjetivo.id_objetivo);
                    paramObjxCurso.Add("id_curso", id_curso);

                    String sqlObjXCurso = string.Concat("INSERT INTO [dbo].[ObjetivosCursos] ",
                                               "([id_objetivo] ",
                                               ",[id_curso] ",
                                               ",[puntos] ",
                                               ",[borrado]) ",
                                               "VALUES ",
                                               "( @id_objetivo",
                                               ", @id_curso ",
                                               ", 4 ",
                                               ", 0 )");
                    dm.EjecutarSQL(sqlObjXCurso, paramObjxCurso);

                }

                dm.Commit();
            }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

            return true;

        }

        public bool ActualizarAvance(Dictionary<string, object> avance)
        {
            String sqlQuery = @"UPDATE [dbo].[UsuariosCursoAvance]
                               SET[porc_avance] = @avance
                               WHERE id_curso = @id_curso AND id_usuario = @id_usuario";
            return DataManager.GetInstance().EjecutarSqlParametros(sqlQuery, avance) != 0;
        }

        public bool ActualizarAvanceTodos(Dictionary<string, object> avance)
        {
            String sqlQuery = @"UPDATE [dbo].[UsuariosCursoAvance]
                               SET[porc_avance] = @avance
                               WHERE id_curso = @id_curso";
            return DataManager.GetInstance().EjecutarSqlParametros(sqlQuery, avance) != 0;


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
            DataManagerT dm = new DataManagerT();
            try
            {
                dm.Open();
                dm.BeginTransaction();

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
                                                ", @fecha ",
                                                ", @id_categoria ",
                                                ", 0)");

                param.Add("id_curso", oCurso.id_curso);
                param.Add("nombre", oCurso.nombre);
                param.Add("Descripcion", oCurso.descripcion);
                param.Add("fecha", oCurso.fecha);
                param.Add("id_categoria", oCurso.categoria.id_categoria);

                dm.EjecutarSQL(sqlQuery, param);



                foreach (var itemObjetivo in oCurso.objetivos)
                {

                    if (itemObjetivo.id_objetivo == 0)
                    {
                        var paramObj = new Dictionary<string, object>();
                        String sqlQueryObj = string.Concat("INSERT INTO [dbo].[Objetivos] ",
                                                        "([nombre_corto] ",
                                                        ",[nombre_largo] ",
                                                        ",[borrado]) ",
                                                        "VALUES ",
                                                        "(@nombreC ",
                                                        ", @nombreL ",
                                                        ", 0) ",

                                                       "INSERT INTO [dbo].[ObjetivosCursos] ",
                                                       "([id_objetivo] ",
                                                       ",[id_curso] ",
                                                       ",[puntos] ",
                                                       ",[borrado]) ",
                                                       "VALUES ",
                                                       "( ident_current('Objetivos')",
                                                       ", ident_current('Cursos') ",
                                                       ", 4 ",
                                                       ", 0 )");

                        paramObj.Add("nombreC", itemObjetivo.nombre_corto);
                        paramObj.Add("nombreL", itemObjetivo.nombre_largo);

                        dm.EjecutarSQL(sqlQueryObj, paramObj);
                        continue;
                    }

                    var paramObjxCurso = new Dictionary<string, object>();
                    paramObjxCurso.Add("id_objetivo", itemObjetivo.id_objetivo);

                    String sqlObjXCurso = string.Concat("INSERT INTO [dbo].[ObjetivosCursos] ",
                                               "([id_objetivo] ",
                                               ",[id_curso] ",
                                               ",[puntos] ",
                                               ",[borrado]) ",
                                               "VALUES ",
                                               "( @id_objetivo",
                                               ", ident_current('Cursos') ",
                                               ", 4 ",
                                               ", 0 )");
                    dm.EjecutarSQL(sqlObjXCurso, paramObjxCurso);

                }

                dm.Commit();
            }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

            return true;
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


        public bool InsertUsuarios(int idcurso, List<int> usuarios)
        {
            DataManagerT dm = new DataManagerT();
            DateTime fecha = DateTime.Now;
            try
            {
                dm.Open();
                dm.BeginTransaction();
                
                foreach (int idUsr in usuarios)
                {

                    var param = new Dictionary<string, Object>();
                    String sqlQuery = string.Concat("INSERT INTO [dbo].[UsuariosCurso] ",
                                                    "([id_usuario] ",
                                                    ",[id_curso] ",
                                                    ",[puntuacion] ",
                                                    ",[observaciones] ",
                                                    ",[fecha_inicio] ",
                                                    ",[fecha_fin]) ",
                                                    "VALUES ",
                                                    "(@id_usuario ",
                                                    ", @id_curso ",
                                                    ", 5 ",
                                                    ", 'nada' ",
                                                    ", @fecha ",
                                                    ", @fecha)",

                                                    "INSERT INTO [dbo].[UsuariosCursoAvance] ",
                                                    "([id_usuario] ",
                                                    ",[id_curso] ",
                                                    ",[inicio] ",
                                                    ",[fin] ",
                                                    ",[porc_avance]) ",
                                                    "VALUES ",
                                                    "(@id_usuario ",
                                                    ", @id_curso ",
                                                    ", @fecha ",
                                                    ", @fecha ",
                                                    ", 1)");

                    param.Add("id_usuario", idUsr);
                    param.Add("id_curso", idcurso);
                    param.Add("fecha", fecha);

                    dm.EjecutarSQL(sqlQuery, param);
                }

                dm.Commit();
            }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

            return true;

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
