using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPAV.Entities
{
    public class User
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string Pass { get; set; }
        public Perfil Perfil { get; set; }


        public override string ToString()
        {
            return Username;
        }

    }
}
