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
    public partial class ABMCurso : Form
   {
        private FormMode formMode = FormMode.agregar;
        private readonly CursoService cursoService;
        private Curso oCursoSel;
        public ABMCurso()
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
            LlenarCombo(cmbCategoria, DataManagerT.GetInstance().ConsultaSQL("SELECT * FROM Categorias"), "nombre", "id_categoria");

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
                        if (oCursoSel.borrado == "Borrado")
                        {
                            chbDarAlta.Visible = true;
                            lblDarAlta.Visible = true;
                        }
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
                        try
                        {
                            if (ValidarCampos())
                            {
                                Curso oCurso = new Curso();
                                oCurso.categoria = new Categoria();
                                oCurso.nombre = txtNombre.Text;
                                oCurso.descripcion = txtDescripcion.Text;
                                oCurso.fecha = Convert.ToDateTime(txtFecha.Text);
                                oCurso.categoria.id_categoria = (int)cmbCategoria.SelectedValue;
                                AgregarObjetivo(oCurso);

                                if (cursoService.ValidarDatos(oCurso))
                                {
                                    var resultado = cursoService.AgregarCurso(oCurso);
                                    LimpiarTextBox();
                                    this.Close();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al registrar el curso " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


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
                            if (chbDarAlta.Visible == true)
                                oCursoSel.borrado = chbDarAlta.Checked ? "Activo" : "Borrado";



                           var resultado = cursoService.ModificarCurso(oCursoSel);
                            if (cursoService.ModificarCurso(oCursoSel))
                            {
                                MessageBox.Show("El Curso seleccionado fue Modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("El Curso seleccionado no puedo ser Modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        break;
                    }

                case FormMode.eliminar:
                        if (MessageBox.Show("¿Seguro que desea eliminar el curso?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            if (cursoService.BorrarCurso(oCursoSel))
                            {
                                MessageBox.Show("El Curso Seleccionado Fue Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al eliminar el Curso Seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }   break;
            }
        }
        
        private bool ValidarCampos()
        {
            bool validacion = true;

            if (txtNombre.Text == string.Empty)
            {
                lblFaltaNombre.Visible = true;
                txtNombre.Focus();
                validacion = false;
            }
            else
                lblFaltaNombre.Visible = false;

            if (!EsFecha(txtFecha.Text))
            {

                lblFechaIncorrecta.Visible = true;
                txtFecha.Focus();
                validacion = false;
            }
            else
                lblFechaIncorrecta.Visible = false;

            if (cmbCategoria.Text == string.Empty)
            {
                lblCategoriaIncorrecta.Text = "Seleccione una categoria!";
                lblCategoriaIncorrecta.Visible = true;
                cmbCategoria.Focus();
                validacion = false;
            }
            else
            {
                if (cmbCategoria.FindStringExact(cmbCategoria.Text) != -1)
                {
                    lblCategoriaIncorrecta.Visible = false;
                }
                else
                {
                    lblCategoriaIncorrecta.Text = "La categoria ingresada no existe";
                    lblCategoriaIncorrecta.Visible = true;
                    validacion = false;
                }
            };

            return validacion;
        }

        public static Boolean EsFecha(String fecha)
        {
            try
            {
                DateTime fechaMin = new DateTime(1753,1,1);
                DateTime fechaIng = DateTime.Parse(fecha);
                if (fechaIng.CompareTo(fechaMin) < 0 )
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarObjetivo(Curso oCurso)
        {
            ABMObjetivo agregar = new ABMObjetivo();
            agregar.InicializarForm(ABMObjetivo.FormMode.agregarACurso, oCurso);
            agregar.ShowDialog();
            oCurso.objetivos = agregar.GetObjetivos();
        }
    }
}
