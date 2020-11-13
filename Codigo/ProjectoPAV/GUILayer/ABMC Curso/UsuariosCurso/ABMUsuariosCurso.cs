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
    public partial class ABMUsuariosCurso : Form
    {
        private Curso oCurso;
        private readonly CursoService cursoService;
        public ABMUsuariosCurso(Curso curso)
        {
            InitializeComponent();
            oCurso = curso;
            lblNombreCurso.Text = oCurso.nombre;
            cursoService = new CursoService();
        }

        private void ABMUsuariosCurso_Load(object sender, EventArgs e)
        {
            consultarUsuariosNoInscriptos();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<int> usuarios = new List<int>();
            foreach (DataGridViewRow r in dgvUsuariosDelCurso.Rows)
            {
                bool isChecked = Convert.ToBoolean(r.Cells[3].Value);
                if (isChecked)
                {
                    usuarios.Add((int)r.Cells[0].Value);
                }
            }
            var resultado = cursoService.AgregarUsuarios(oCurso.id_curso, usuarios);
            this.Close();
        }

        private void consultarUsuariosNoInscriptos()
        {
            try
            {
                this.usuariosTableAdapter1.usuariosNoInscriptos(this.bugTrackerGrupo9DataSet1.Usuarios, oCurso.id_curso);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dgvUsuarios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvUsuariosDelCurso.IsCurrentCellDirty)
            {
                dgvUsuariosDelCurso.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
