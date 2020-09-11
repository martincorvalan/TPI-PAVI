using ProjectoPAV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectoPAV.DataAccessLayer
{
    public class UserDao
    {
        //Define y ejecuta la sentencia sql
        public IList<User> GetAll()
        {
            List<User> ListaUser = new List<User>();

            String SqlQuery = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " +
                                          "  WHERE u.borrado = 0 ");

            var resQuery = DataManager.GetInstance().ConsultaSQL(SqlQuery);

            foreach (DataRow row in resQuery.Rows)
            {
                //ListaUser.Add(ObjectMapping(row));
            }

            return ListaUser;
        }

        public User GetUser(string username)
        {

            String SqlQuery = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre perfil ",
                                          "  FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                          "  WHERE usuario = @usuario");

            var param = new Dictionary<string, object>();
            param.Add("usuario", username);
            var resQuery = DataManager.GetInstance().ConsultaSQL(SqlQuery, param);

            if (resQuery.Rows.Count > 0)
            {
                return ObjectMapping(resQuery.Rows[0]); 
            }

            return null;
        }

        private User ObjectMapping(DataRow row)
        {   //Mapeo de atributos de la consulta a objeto
            User oUser = new User
            { 
                IdUser = Convert.ToInt32(row["id_usuario"].ToString()),
                Username = row["usuario"].ToString(),
                Email = row["email"].ToString(),
                Pass = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,
                Perfil = new Perfil()
                {
                    IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                    Nombre = row["perfil"].ToString(),
                }
            };
            return oUser;
        }
    }
}
