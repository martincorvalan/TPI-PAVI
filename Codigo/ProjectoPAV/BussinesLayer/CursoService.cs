using ProjectoPAV.DataAccessLayer;
using ProjectoPAV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPAV.BussinesLayer
{
    public class CursoService
    {
        private CursoDao cursoDao;

        public CursoService()
        {
            cursoDao = new CursoDao();
        }


        public IList<Curso> ConsultarCursos(Dictionary<string, object> param)
        {
            return cursoDao.ConsultarCurso(param);
        }
       
        public bool BorrarCurso(int id)
        {
            return cursoDao.borrar(id);
        }

        public bool AgregarCurso(Dictionary<string, object> param)
        {
            return cursoDao.Insert(param);
        }

        public bool ModificarCurso(Dictionary<string, object> param)
        {
            return cursoDao.Modificar(param);
        }
    }
}
