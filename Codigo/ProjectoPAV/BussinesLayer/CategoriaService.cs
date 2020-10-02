using ProjectoPAV.DataAccessLayer;
using ProjectoPAV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPAV.BussinesLayer
{
    public class CategoriaService
    {

        private CategoriaDao categoriaDao;

        public CategoriaService()
        {
            categoriaDao = new CategoriaDao();
        }
        public IList<Categoria> ConsultarCategorias(Dictionary<string, object> param)
        {
            return categoriaDao.ConsultarCategoria(param);
        }

        public bool AgregarCategoria(Categoria oCategoria)
        {
            return categoriaDao.Insert(oCategoria);
        }

        public bool ModificarCategoria(Categoria oCategoria)
        {
            return categoriaDao.Modificar(oCategoria);
        }

        public bool BorrarCategoria(Categoria oCategoria)
        {
            return categoriaDao.borrar(oCategoria);
        }


    }
}
