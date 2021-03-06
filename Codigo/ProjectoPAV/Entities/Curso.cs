﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPAV.Entities
{
    public class Curso
    {
        public int id_curso { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public Categoria categoria { get; set; }
        public string borrado { get; set; }

        public BindingList<Objetivo> objetivos { get; set; }




    }

}
