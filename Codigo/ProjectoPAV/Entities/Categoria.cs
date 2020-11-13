﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPAV.Entities
{
    public class Categoria
    {
        public int id_categoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string borrado { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
