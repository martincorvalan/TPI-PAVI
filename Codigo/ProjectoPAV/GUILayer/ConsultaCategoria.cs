using System;
using ProjectoPAV.BussinesLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectoPAV.Entities;

namespace ProjectoPAV.GUILayer
{
    public partial class ConsultaCategoria : Form
    {
        private readonly CategoriaService categoriaService;
        public ConsultaCategoria()
        {
            InitializeComponent();
            categoriaService = new CategoriaService();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvCategorias.ColumnCount = 3;
            dgvCategorias.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvCategorias.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Calibri", 8, FontStyle.Regular);
            dgvCategorias.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            dgvCategorias.Columns[0].Name = "Nombre";
            dgvCategorias.Columns[0].DataPropertyName = "nombre";
            dgvCategorias.Columns[0].Width = 120;

            dgvCategorias.Columns[1].Name = "Descripción";
            dgvCategorias.Columns[1].DataPropertyName = "descripcion";
            dgvCategorias.Columns[1].Width = 120;

            dgvCategorias.Columns[2].Name = "Estado";
            dgvCategorias.Columns[2].DataPropertyName = "Estado";
            dgvCategorias.Columns[2].Width = 120;


            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvCategorias.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvCategorias.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Linea comentada abajo falta definir el service con el metodo de consulta.

            Dictionary<string, object> filtros = new Dictionary<string, object>();

            if (txtNombre.Text != string.Empty)
            {
                filtros.Add("Nombre", txtNombre.Text);
            }


            IList<Categoria> listadoCategorias = categoriaService.ConsultarCategorias(filtros);

            dgvCategorias.DataSource = listadoCategorias;

            /*if (dgvCategorias.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgvCategorias.CurrentCell != null)
            {
                ABMCategoria frmABM = new ABMCategoria();
                var categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                frmABM.InicializarForm(ABMCategoria.FormMode.modificar, categoria);
                frmABM.ShowDialog();
                btnSearch_Click(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentCell != null)
            {
                ABMCategoria frmABM = new ABMCategoria();
                var categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                frmABM.InicializarForm(ABMCategoria.FormMode.eliminar, categoria);
                frmABM.ShowDialog();
                btnSearch_Click(sender, e);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ABMCategoria agregar = new ABMCategoria();
            agregar.ShowDialog();
            btnSearch_Click(sender, e);
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

    }
}
