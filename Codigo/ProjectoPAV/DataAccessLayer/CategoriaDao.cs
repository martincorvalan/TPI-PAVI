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
    class CategoriaDao
    {
        public IList<Categoria> GetAll()
        {
            List<Categoria> listaCategoria = new List<Categoria>();

            String SqlQuery = string.Concat("SELECT *",
                                            "FROM Categorias ",
                                            "WHERE borrado = 0");

            var resQuery = DataManager.GetInstance().ConsultaSQL(SqlQuery);

            foreach (DataRow row in resQuery.Rows)
            {
                listaCategoria.Add(ObjectMapping(row));
            }

            return listaCategoria;
        }


        public IList<Categoria> ConsultarCategoria(Dictionary<string, object> param)
        {
            List<Categoria> listaCategoria = new List<Categoria>();

            String SqlQuery = string.Concat("SELECT *",
                                            "FROM Categorias c ",
                                            "WHERE c.borrado = 0");
            if (param.ContainsKey("Nombre"))
                SqlQuery += " AND (c.nombre LIKE '%'+ @Nombre + '%') ";



            var resQuery = DataManager.GetInstance().ConsultaSQL(SqlQuery, param);

            foreach (DataRow row in resQuery.Rows)
            {
                listaCategoria.Add(ObjectMapping(row));
            }

            return listaCategoria;
        }


        public bool Insert(Categoria oCategoria)
        {
            var param = new Dictionary<string, object>();
            String sqlQuery = string.Concat("INSERT INTO [dbo].[Categorias] ",
                                            "([nombre] ",
                                            ",[descripcion] ",
                                            ",[borrado]) ",
                                            "VALUES ",
                                            "(@nombre ",
                                            ", @descripcion ",
                                            ", 0)");

            param.Add("nombre", oCategoria.nombre);
            param.Add("Descripcion", oCategoria.descripcion);


            return DataManager.GetInstance().EjecutarSqlParametros(sqlQuery, param) > 0;
        }


        public bool Modificar(Categoria oCategoria)
        {
            var param = new Dictionary<string, object>();
            String sqlQuery = string.Concat("UPDATE[dbo].[Categorias] ",
                                            "SET[nombre] = @nombre ",
                                            ",[descripcion] = @descripcion ",
                                            "WHERE id_categoria = @id_categoria"
                                             );

            param.Add("id_categoria", oCategoria.id_categoria);
            param.Add("nombre", oCategoria.nombre);
            param.Add("Descripcion", oCategoria.descripcion);

            return DataManager.GetInstance().EjecutarSqlParametros(sqlQuery, param) > 0;
        }


        public bool borrar(Categoria oCategoria)
        {
            var param = new Dictionary<string, object>();
            String sqlQuery = string.Concat("UPDATE[dbo].[Categorias] ",
                                            "SET[borrado] = 1 ",
                                            "WHERE id_categoria = @id_categoria ");
            param.Add("id_categoria", oCategoria.id_categoria);

            return DataManager.GetInstance().EjecutarSqlParametros(sqlQuery, param) != 0;

        }


        private Categoria ObjectMapping(DataRow row)
        {


            Categoria oCategoria = new Categoria
            {
                nombre = row["nombre"].ToString(),
                id_categoria = Convert.ToInt32(row["id_categoria"].ToString()),
                descripcion = row["descripcion"].ToString()
            };
            return oCategoria ;
        }

    }
}
