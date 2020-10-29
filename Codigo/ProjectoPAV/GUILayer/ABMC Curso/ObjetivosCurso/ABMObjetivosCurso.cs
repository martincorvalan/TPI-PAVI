using ProjectoPAV.BussinesLayer;
using ProjectoPAV.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoPAV.GUILayer.ABMC_Curso
{
    public partial class ABMObjetivosCurso : Form
    {
        private Curso oCurso;
        private readonly CursoService cursoService;
        private readonly ObjetivoService objetivoService;
        public ABMObjetivosCurso(Curso curso)
        {
            InitializeComponent();
            oCurso = curso;
            lblNombreCurso.Text = oCurso.nombre;
            cursoService = new CursoService();
            objetivoService = new ObjetivoService();
        }

        private void ABMObjetivosCurso_Load(object sender, EventArgs e)
        {
            consultarObjetivosNoVinculados();
        }


        //Metodo para poder mover el formulario sin la barra
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvObjetivos.Rows)
            {
                bool isChecked = Convert.ToBoolean(r.Cells[2].Value);
                if (isChecked)
                {
                    Objetivo objetivo = new Objetivo();
                    objetivo.id_objetivo = (int)r.Cells[3].Value;
                    objetivo.nombre_corto = (string)r.Cells[0].Value;
                    objetivo.nombre_largo = (string)r.Cells[1].Value;
                    oCurso.objetivos.Add(objetivo);
                }
            }
            this.Close();
        }

        private void dgvUsuarios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvObjetivos.IsCurrentCellDirty)
            {
                dgvObjetivos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void consultarObjetivosNoVinculados()
        {
            try
            {
                this.objetivosTableAdapter1.objetivosNoVinculados(this.bugTrackerGrupo9DataSet2.Objetivos, oCurso.id_curso);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Objetivo objetivo = new Objetivo();
                objetivo.nombre_corto = txtNombreCorto.Text;
                objetivo.nombre_largo = txtNombreLargo.Text;
                //var resultado = objetivoService.AgregarObjetivo(objetivo);
                oCurso.objetivos.Add(objetivo);
                txtNombreCorto.Clear();
                txtNombreLargo.Clear();
            }
        }

        private bool ValidarCampos()
        {
            bool validacion = true;

            if (txtNombreCorto.Text == string.Empty || txtNombreLargo.Text == string.Empty)
            {
                lblFaltaNombre.Visible = true;
                txtNombreCorto.Focus();
                validacion = false;
            }
            else
                lblFaltaNombre.Visible = false;
            return validacion;
        }
    }
}
