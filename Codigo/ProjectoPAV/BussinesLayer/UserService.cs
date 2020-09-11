using ProjectoPAV.DataAccessLayer;
using ProjectoPAV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPAV.BussinesLayer
{
    public class UserService
    {
        private UserDao oUserDao;

        public UserService()
        {
            oUserDao = new UserDao();
        }

        //Recibe por parametro el usuario y contraseña a buscar y retorna un objeto usuario
        public User ValidarUser(string usuario, string pass)
        {
            var user = oUserDao.GetUser(usuario);
            if (user != null)
            {
                if (user.Pass != null && user.Pass.Equals(pass))
                {
                    return user;
                }
            }

            return null;
        }

    }
}
