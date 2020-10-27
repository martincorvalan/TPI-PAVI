using ProjectoPAV.BussinesLayer;
using ProjectoPAV.DataAccessLayer;
using ProjectoPAV.Entities;
using ProjectoPAV.GUILayer.ABMC_Curso;
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


        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvCursos.ColumnCount = 7;
            dgvCursos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvCursos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Calibri", 8, FontStyle.Regular);
            dgvCursos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            dgvCursos.Columns[0].Name = "Nombre";
            dgvCursos.Columns[0].DataPropertyName = "nombre";
            dgvCursos.Columns[0].Width = 120;

            dgvCursos.Columns[1].Name = "Descripción";
            dgvCursos.Columns[1].DataPropertyName = "descripcion";
            dgvCursos.Columns[1].Width = 150;

            dgvCursos.Columns[2].Name = "Fecha";
            dgvCursos.Columns[2].DataPropertyName = "fecha";
            dgvCursos.Columns[2].Width = 70;

            dgvCursos.Columns[3].Name = "Categoria";
            dgvCursos.Columns[3].DataPropertyName = "categoria";
            dgvCursos.Columns[3].Width = 90;

            dgvCursos.Columns[4].Name = "Objetivos";
            dgvCursos.Columns[4].DataPropertyName = "objetivo";
            dgvCursos.Columns[4].Width = 60;

            dgvCursos.Columns[5].Name = "Usuarios";
            dgvCursos.Columns[5].DataPropertyName = "usuarios";
            dgvCursos.Columns[5].Width = 60;

            dgvCursos.Columns[6].Name = " ";
            dgvCursos.Columns[6].DataPropertyName = "borrado";
            dgvCursos.Columns[6].Width = 23;

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvCursos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvCursos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
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

        private void ConsultaCurso_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmbCategoria, DataManagerT.GetInstance().ConsultaSQL("SELECT * FROM Categorias"), "nombre", "id_categoria");
        }


        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            if (dgvCursos.CurrentCell.ColumnIndex == 4)
            {
                var curso = (Curso)dgvCursos.CurrentRow.DataBoundItem;
                ObjetivosCurso objXcurso = new ObjetivosCurso(curso);
                objXcurso.ShowDialog();
            }
            if (dgvCursos.CurrentCell.ColumnIndex == 5)
            {
                var curso = (Curso)dgvCursos.CurrentRow.DataBoundItem;
                UsuariosCurso UsrXcurso = new UsuariosCurso(curso);
                UsrXcurso.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
            // Linea comentada abajo falta definir el service con el metodo de consulta.

            Dictionary<string, object> filtros = new Dictionary<string, object>();

            //DateTime fecha;

            if (txtNombre.Text != string.Empty)
            {
                filtros.Add("Nombre", txtNombre.Text);
            }

            if (dtpFecha.Checked == true)
                filtros.Add("Fecha", dtpFecha.Value);

            if (!string.IsNullOrEmpty(cmbCategoria.Text))
            {
                if (cmbCategoria.FindStringExact(cmbCategoria.Text) != -1)
                {
                    var categoria = cmbCategoria.SelectedValue.ToString();
                    filtros.Add("IdCategoria", categoria);
                    lblCategoriaIncorrecta.Visible = false;
                }
                else
                {
                    lblCategoriaIncorrecta.Visible = true;
                }
            }

            if (chbBorrados.Checked)
            {
                filtros.Add("Borrado", true);
            }


            IList<Curso> listadoCursos = cursoService.ConsultarCursos(filtros);

            dgvCursos.DataSource = listadoCursos;


            for (int i = 0; i < dgvCursos.Rows.Count; i++)
            {
                dgvCursos.Rows[i].Cells["Objetivos"].Value = "           ...";

            }

            //foreach (int headers in dgvCursos.Rows)
            //{
            //    dgvCursos.Rows[0].Cells[5].Value = "...";

            //}

            lblCantidad.Text = dgvCursos.Rows.Count.ToString();

            /*if (dgvCursos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCursos.CurrentCell != null)
            {
                ABMCurso frmABM = new ABMCurso();
                var curso = (Curso)dgvCursos.CurrentRow.DataBoundItem;
                frmABM.InicializarForm(ABMCurso.FormMode.modificar, curso);
                frmABM.ShowDialog();
                btnSearch_Click(sender, e);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCursos.CurrentCell != null)
            {
                ABMCurso frmABM = new ABMCurso();
                var curso = (Curso)dgvCursos.CurrentRow.DataBoundItem;
                frmABM.InicializarForm(ABMCurso.FormMode.eliminar, curso);
                frmABM.ShowDialog();
                btnSearch_Click(sender, e);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ABMCurso agregar = new ABMCurso();
            agregar.ShowDialog();
            btnSearch_Click(sender, e);
        }

        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvCursos.Columns[e.ColumnIndex].Name == " ")
            {
                if ((string)e.Value == "Borrado")
                {
                    e.CellStyle.BackColor = Color.FromArgb(211, 110, 112);
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.SelectionBackColor = Color.FromArgb(211, 110, 112);
                }
                e.Value = "";
            }
           
        }

        private void lblBorradosCheck_Click(object sender, EventArgs e)
        {
            if(chbBorrados.CheckState == 0)
                chbBorrados.CheckState = CheckState.Checked;
            else
                chbBorrados.CheckState = CheckState.Unchecked;
        }

        //private void txtFecha_Click(object sender, EventArgs e)
        //{
        //    //txtFecha.Select(0, 0);
        //    txtFecha.SelectionStart = 0;
        //}
    }
}
