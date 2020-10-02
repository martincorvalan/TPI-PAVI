using ProjectoPAV.DataAccessLayer;
using ProjectoPAV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPAV.BussinesLayer
{
    class ObjetivoService
    {
        private ObjetivoDao objetivoDao;

        public ObjetivoService()
        {
            objetivoDao = new ObjetivoDao();
        }
        public IList<Objetivo> ConsultarObjetivos(Dictionary<string, object> param)
        {
            return objetivoDao.ConsultarObjetivo(param);
        }

        public bool AgregarObjetivo(Objetivo oObjetivo)
        {
            return objetivoDao.Insert(oObjetivo);
        }

        public bool ModificarObjetivo(Objetivo oObjetivo)
        {
            return objetivoDao.Modificar(oObjetivo);
        }

        public bool BorrarObjetivo(Objetivo oObjetivo)
        {
            return objetivoDao.borrar(oObjetivo);
        }

    }
}
