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
    public partial class AMB : Form
   {
        private FormMode formMode = FormMode.agregar;
        private readonly CursoService cursoService;
        private Curso oCursoSel;
        public AMB()
        {
            InitializeComponent();
            cursoService = new CursoService();
        }

        public enum FormMode
        {
            agregar,
            modificar,
            eliminar
        }

        private void AgregarCurso_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmbCategoria, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Categorias"), "nombre", "id_categoria");

            switch (formMode)
            {
                case FormMode.agregar:
                    {
                        this.Text = "Registrar curso";
                        break;
                    }
                case FormMode.modificar:
                    {
                        this.Text = "Modificar curso";
                        MostrarDatos();
                        break;
                    }
                case FormMode.eliminar:
                    {
                        this.Text = "Eliminar curso";
                        MostrarDatos();
                        txtNombre.Enabled = false;
                        txtDescripcion.Enabled = false;
                        cmbCategoria.Enabled = false;
                        txtFecha.Enabled = false;
                        break;
                    }

            }
        }

        public void InicializarForm(FormMode opcion, Curso cursoSel)
        {
            formMode = opcion;
            oCursoSel = cursoSel;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.agregar:
                    {
                        Curso oCurso = new Curso();
                        oCurso.categoria = new Categoria();
                        oCurso.nombre = txtNombre.Text;
                        oCurso.descripcion = txtDescripcion.Text;
                        oCurso.fecha = Convert.ToDateTime(txtFecha.Text);
                        oCurso.categoria.id_categoria = (int)cmbCategoria.SelectedValue;

                        var resultado = cursoService.AgregarCurso(oCurso);

                        LimpiarTextBox();

                        break;
                    }

                case FormMode.modificar:
                    {
                        if (ValidarCampos())
                        {
                            oCursoSel.nombre = txtNombre.Text;
                            oCursoSel.descripcion = txtDescripcion.Text;
                            oCursoSel.fecha = Convert.ToDateTime(txtFecha.Text);
                            oCursoSel.categoria.id_categoria = (int)cmbCategoria.SelectedValue;

                            var resultado = cursoService.ModificarCurso(oCursoSel);
                            if (cursoService.ModificarCurso(oCursoSel))
                            {
                                MessageBox.Show("El Curso seleccionado fue Modificado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("El Curso seleccionado no puedo ser Modificado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        break;
                    }

                case FormMode.eliminar:
                    {
                        if (cursoService.BorrarCurso(oCursoSel))
                        {
                            MessageBox.Show("Curso Borrado");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Error al eliminar el Curso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    }
            }
        }
        private bool ValidarCampos()
        {

            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.DarkRed;
                txtNombre.Focus();
                return false;
            }
            else
                txtNombre.BackColor = Color.White;

            return true;
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

        private void LimpiarTextBox()
        {
            txtNombre.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            txtFecha.Text = String.Empty;
            cmbCategoria.ResetText(); 
        }

        private void MostrarDatos()
        {
            txtNombre.Text = oCursoSel.nombre;
            txtDescripcion.Text = oCursoSel.descripcion;
            txtFecha.Text = oCursoSel.fecha.ToString("dd/MM/yyyy");
            cmbCategoria.Text = oCursoSel.categoria.nombre;
        }


    }
}
