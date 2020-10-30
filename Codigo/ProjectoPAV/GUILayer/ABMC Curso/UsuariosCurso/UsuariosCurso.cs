﻿using ProjectoPAV.Entities;
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
    public partial class UsuariosCurso : Form
    {
        private Curso oCurso;
        public UsuariosCurso(Curso curso)
        {
            InitializeComponent();
            oCurso = curso;
            lblNombreCurso.Text = oCurso.nombre;
            lblFechaContenido.Text = oCurso.fecha.ToString();
            lblDescripcionContenido.Text = oCurso.descripcion;
        }

        private void UsuariosCurso_Load(object sender, EventArgs e)
        {
            usuariosInscriptos();
            
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
            ABMUsuariosCurso agregarUsr = new ABMUsuariosCurso(oCurso);
            agregarUsr.ShowDialog();
            usuariosInscriptos();
        }

        private void usuariosInscriptos()
        {
            this.usuariosDelCursoTableAdapter.FillUsuariosDelCurso(this.dataSet1.UsuariosDelCurso, oCurso.id_curso);
        }

        private void dgvUsuariosCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuariosCurso.CurrentCell.ColumnIndex == 3)
            {
                
            }
        }
    }
}