using ProjectoPAV.BussinesLayer;
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
    public partial class ABMCategoria : Form
    {
        private FormMode formMode = FormMode.agregar;
        private readonly CategoriaService categoriaService;
        private Categoria oCategoriaSel;
        public ABMCategoria()
        {
            InitializeComponent();
            categoriaService = new CategoriaService();
        }

        public enum FormMode
        {
            agregar,
            modificar,
            eliminar
        }

        public void InicializarForm(FormMode opcion, Categoria categoriaSel)
        {
            formMode = opcion;
            oCategoriaSel = categoriaSel;
        }


        private void AgregarCategoria_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.agregar:
                    {
                        this.Text = "Registrar Categoria";
                        break;
                    }
                case FormMode.modificar:
                    {
                        this.Text = "Modificar Categoria";
                        MostrarDatos();
                        if (oCategoriaSel.borrado == "Borrado")
                        {
                            chbDarAlta.Visible = true;
                            lblDarAlta.Visible = true;
                        }
                        break;
                    }
                case FormMode.eliminar:
                    {
                        this.Text = "Eliminar Categoria";
                        MostrarDatos();
                        txtNombre.Enabled = false;
                        txtDescripcion.Enabled = false;
                        break;
                    }

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

            return validacion;
        }
        private void MostrarDatos()
        {
            txtNombre.Text = oCategoriaSel.nombre;
            txtDescripcion.Text = oCategoriaSel.descripcion;
        }


        private void LimpiarTextBox()
        {
            txtNombre.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.agregar:
                    {
                        if (ValidarCampos())
                        {
                            Categoria oCategoria = new Categoria();

                            oCategoria.nombre = txtNombre.Text;
                            oCategoria.descripcion = txtDescripcion.Text;

                            var resultado = categoriaService.AgregarCategoria(oCategoria);
                            LimpiarTextBox();
                            this.Close();

                        }


                        break;
                    }

                case FormMode.modificar:
                    {
                        if (ValidarCampos())
                        {
                            oCategoriaSel.nombre = txtNombre.Text;
                            oCategoriaSel.descripcion = txtDescripcion.Text;
                            if (chbDarAlta.Visible == true)
                                oCategoriaSel.borrado = chbDarAlta.Checked ? "Activo" : "Borrado";

                            var resultado = categoriaService.ModificarCategoria(oCategoriaSel);
                            if (categoriaService.ModificarCategoria(oCategoriaSel))
                            {
                                MessageBox.Show("El Categoria seleccionado fue Modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("El Categoria seleccionado no puedo ser Modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        break;
                    }

                case FormMode.eliminar:
                    if (MessageBox.Show("¿Seguro que desea eliminar el categoria?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (categoriaService.BorrarCategoria(oCategoriaSel))
                        {
                            MessageBox.Show("El Categoria Seleccionado Fue Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Error al eliminar el Categoria Seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    break;
            }
        }
    }
}
