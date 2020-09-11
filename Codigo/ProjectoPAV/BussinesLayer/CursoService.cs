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


        public IList<Curso> ConsultarCursos()
        {
            return cursoDao.GetAll();
        }
       
        public bool BorrarCurso(int id)
        {
            return cursoDao.borrar(id);
        }
    }
}
