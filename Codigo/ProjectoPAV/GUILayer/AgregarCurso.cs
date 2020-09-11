using ProjectoPAV.BussinesLayer;
using ProjectoPAV.DataAccessLayer;
using ProjectoPAV.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoPAV.GUILayer
{
    public partial class AgregarCurso : Form
    {
        private readonly CursoService cursoService;
        public AgregarCurso()
        {
            InitializeComponent();
            cursoService = new CursoService();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Creamos un diccionario para guardar el contenido de los txtBox y el combobox

            Dictionary<string, object> listaCurso = new Dictionary <string, object>();

            DateTime fecha;
            DateTime.TryParse(txtFecha.Text, out fecha);

            listaCurso.Add("Nombre", txtNombre.Text);
            listaCurso.Add("Descripcion", txtDescripcion.Text);
            listaCurso.Add("Fecha", fecha);
            listaCurso.Add("Categoria", cmbCategoria.Text);

            var resultado = cursoService.AgregarCurso(listaCurso);

        }
    }
}
