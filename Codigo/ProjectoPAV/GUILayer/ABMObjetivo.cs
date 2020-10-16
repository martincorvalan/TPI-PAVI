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
    public partial class ABMObjetivo : Form
    {
        private FormMode formMode = FormMode.agregar;
        private readonly ObjetivoService objetivoService;
        private Objetivo oObjetivoSel;
        private Curso oCursoSel;
        private BindingList<Objetivo> objetivos;
        public ABMObjetivo()
        {
            InitializeComponent();
            objetivoService = new ObjetivoService();
            objetivos = new BindingList<Objetivo>();
            oCursoSel = new Curso();
        }

        public enum FormMode
        {
            agregar,
            modificar,
            eliminar,
            agregarACurso
        }


        public void InicializarForm(FormMode opcion, Objetivo objetivoSel)
        {
            formMode = opcion;
            oObjetivoSel = objetivoSel;
        }

        public void InicializarForm(FormMode opcion, Curso curso)
        {
            formMode = opcion;
            oCursoSel = curso;
        }

        private void AgregarObjetivo_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.agregar:
                    {
                        this.Text = "Registrar Objetivo";
                        this.btnCancelar.Text = "Cancelar";
                        break;
                    }
                case FormMode.modificar:
                    {
                        this.Text = "Modificar Objetivo";
                        MostrarDatos();
                        this.btnCancelar.Text = "Cancelar";
                        break;
                    }
                case FormMode.eliminar:
                    {
                        this.Text = "Eliminar Objetivo";
                        MostrarDatos();
                        txtNombreCorto.Enabled = false;
                        txtNombreLargo.Enabled = false;
                        this.btnCancelar.Text = "Cancelar";
                        break;
                    }
                case FormMode.agregarACurso:
                    {
                        this.Text = "Registrar Objetivo";
                        this.btnCancelar.Text = "Terminar";
                        break;
                    }

            }
        }





        private bool ValidarCampos()
        {
            bool validacion = true;

            if (txtNombreCorto.Text == string.Empty)
            {
                lblFaltaNombre.Visible = true;
                txtNombreCorto.Focus();
                validacion = false;
            }
            else
                lblFaltaNombre.Visible = false;

            return validacion;
        }
        private void MostrarDatos()
        {
            txtNombreCorto.Text = oObjetivoSel.nombre_corto;
            txtNombreLargo.Text = oObjetivoSel.nombre_largo;
        }


        private void LimpiarTextBox()
        {
            txtNombreCorto.Text = String.Empty;
            txtNombreLargo.Text = String.Empty;
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
                            Objetivo oObjetivo = new Objetivo();

                            oObjetivo.nombre_corto = txtNombreCorto.Text;
                            oObjetivo.nombre_largo = txtNombreLargo.Text;

                            var resultado = objetivoService.AgregarObjetivo(oObjetivo);
                            LimpiarTextBox();
                            this.Close();

                        }


                        break;
                    }

                case FormMode.modificar:
                    {
                        if (ValidarCampos())
                        {
                            oObjetivoSel.nombre_corto = txtNombreCorto.Text;
                            oObjetivoSel.nombre_largo = txtNombreLargo.Text;

                            var resultado = objetivoService.ModificarObjetivo(oObjetivoSel);
                            if (objetivoService.ModificarObjetivo(oObjetivoSel))
                            {
                                MessageBox.Show("El Objetivo seleccionado fue Modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("El Objetivo seleccionado no puedo ser Modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        break;
                    }

                case FormMode.eliminar:
                    if (MessageBox.Show("¿Seguro que desea eliminar el objetivo?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (objetivoService.BorrarObjetivo(oObjetivoSel))
                        {
                            MessageBox.Show("El Objetivo Seleccionado Fue Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Error al eliminar el Objetivo Seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    break;

                case FormMode.agregarACurso:
                    {
                        if (ValidarCampos())
                        {
                            Objetivo oObjetivo = new Objetivo();

                            oObjetivo.nombre_corto = txtNombreCorto.Text;
                            oObjetivo.nombre_largo = txtNombreLargo.Text;

                            objetivos.Add(oObjetivo);
                            LimpiarTextBox();
                            
                            
                        }


                        break;
                    }
            }
        }

        public BindingList<Objetivo> GetObjetivos()
        {
            return objetivos;
        }
    }
}
