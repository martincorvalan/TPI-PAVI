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
       
        public bool BorrarCurso(Curso oCurso)
        {
            return cursoDao.borrar(oCurso);
        }

        public bool AgregarCurso(Curso oCurso)
        {
            return cursoDao.Insert(oCurso);
        }

        public bool ModificarCurso(Curso oCurso)
        {
            return cursoDao.Modificar(oCurso);
        }

        internal bool ValidarDatos(Curso oCurso)
        {
            if (oCurso.objetivos.Count == 0)
            {
                throw new Exception("Debe ingresar al menos un objetivo.");
            }

            return true;
        }
        public bool AgregarUsuarios(int idcurso, List<int> usuarios )
        {
            return cursoDao.InsertUsuarios(idcurso, usuarios);
        }

        public bool ActualizarAvanceTodos(Dictionary<string, object> avance)
        {
            return cursoDao.ActualizarAvanceTodos(avance);
        }

        public bool ActualizarAvance(Dictionary<string, object> avance)
        {
            return cursoDao.ActualizarAvance(avance);
        }

        public bool AgregarObjetivos(List<Objetivo> objetivos, int id_curso)
        {
            return cursoDao.AgregarObjetivos(objetivos, id_curso);
        }
    }
}
