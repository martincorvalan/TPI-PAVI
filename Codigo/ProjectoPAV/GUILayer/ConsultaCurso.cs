﻿using ProjectoPAV.BussinesLayer;
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
    public partial class ConsultaCurso : Form
    {
        private readonly CursoService cursoService;
        public ConsultaCurso()
        {
            InitializeComponent();
            cursoService = new CursoService();
            InitializeDataGridView();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           // Linea comentada abajo falta definir el service con el metodo de consulta.

            IList<Curso> listadoCursos = cursoService.ConsultarCursos();

            dgvCursos.DataSource = listadoCursos;

            /*if (dgvCursos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/


        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvCursos.ColumnCount = 5;
            dgvCursos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvCursos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Calibri", 8, FontStyle.Regular);
            dgvCursos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvCursos.Columns[0].Name = "ID";
            dgvCursos.Columns[0].DataPropertyName = "id_curso";
            // Definimos el ancho de la columna.
            dgvCursos.Columns[0].Width = 50;

            dgvCursos.Columns[1].Name = "Nombre";
            dgvCursos.Columns[1].DataPropertyName = "nombre";
            dgvCursos.Columns[1].Width = 120;

            dgvCursos.Columns[2].Name = "Descripción";
            dgvCursos.Columns[2].DataPropertyName = "descripcion";
            dgvCursos.Columns[2].Width = 120;

            dgvCursos.Columns[3].Name = "Fecha";
            dgvCursos.Columns[3].DataPropertyName = "fecha";
            dgvCursos.Columns[3].Width = 120;

            dgvCursos.Columns[4].Name = "Categoria";
            dgvCursos.Columns[4].DataPropertyName = "categoria";
            dgvCursos.Columns[4].Width = 120;

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvCursos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvCursos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }
    }
}
