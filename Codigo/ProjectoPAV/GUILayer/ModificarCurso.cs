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
    public partial class ModificarCurso : Form
    {
        private readonly CursoService cursoService;
        private Curso oCurso;
        public ModificarCurso()
        {
            InitializeComponent();
            cursoService = new CursoService(); 
        }

        public void InicializarForm(Curso curso)
        {
            oCurso = curso;
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
           /* Dictionary<string, object> listaCurso = new Dictionary<string, object>();

            DateTime fecha;
            DateTime.TryParse(txtFecha.Text, out fecha);

            listaCurso.Add("id", oCurso.id_curso);
            listaCurso.Add("Nombre", txtNombre.Text);
            listaCurso.Add("Descripcion", txtDescripcion.Text);
            listaCurso.Add("Fecha", fecha);
            if (!string.IsNullOrEmpty(cmbCategoria.Text))
            {
                var categoria = cmbCategoria.SelectedValue.ToString();
                listaCurso.Add("id_categoria", categoria);
            }

            var resultado = cursoService.ModificarCurso(listaCurso);*/

        }

        private void MostrarDatos()
        {
            txtNombre.Text = oCurso.nombre;
            txtDescripcion.Text = oCurso.descripcion;
            txtFecha.Text = oCurso.fecha.ToString("dd/MM/yyyy");
            cmbCategoria.Text = oCurso.categoria.nombre;
        }



        private void LlenarCombo(ComboBox cmb, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cmb.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cmb.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cmb.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cmb.SelectedIndex = -1;
        }

        private void ModificarCurso_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmbCategoria, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Categorias"), "nombre", "id_categoria");
        }
    }
}
