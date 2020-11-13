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
    public partial class ConsultaObjetivo : Form
    {
        private readonly ObjetivoService objetivoService;
        public ConsultaObjetivo()
        {
            InitializeComponent();
            objetivoService = new ObjetivoService();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvObjetivos.ColumnCount = 3;
            dgvObjetivos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvObjetivos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Calibri", 8, FontStyle.Regular);
            dgvObjetivos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            dgvObjetivos.Columns[0].Name = "Nombre Corto";
            dgvObjetivos.Columns[0].DataPropertyName = "nombre_corto";
            dgvObjetivos.Columns[0].Width = 120;

            dgvObjetivos.Columns[1].Name = "Nombre Largo";
            dgvObjetivos.Columns[1].DataPropertyName = "nombre_Largo";
            dgvObjetivos.Columns[1].Width = 120;

            dgvObjetivos.Columns[2].Name = "Estado";
            dgvObjetivos.Columns[2].DataPropertyName = "borrado";
            dgvObjetivos.Columns[2].Width = 120;


            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvObjetivos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvObjetivos.AutoResizeRows(
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

            if (chbBorrados.Checked)
            {
                filtros.Add("Borrado", true);
            }

            IList<Objetivo> listadoObjetivos = objetivoService.ConsultarObjetivos(filtros);

            dgvObjetivos.DataSource = listadoObjetivos;

            /*if (dgvObjetivos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgvObjetivos.CurrentCell != null)
            {
                ABMObjetivo frmABM = new ABMObjetivo();
                var objetivo = (Objetivo)dgvObjetivos.CurrentRow.DataBoundItem;
                frmABM.InicializarForm(ABMObjetivo.FormMode.modificar, objetivo);
                frmABM.ShowDialog();
                btnSearch_Click(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvObjetivos.CurrentCell != null)
            {
                ABMObjetivo frmABM = new ABMObjetivo();
                var objetivo = (Objetivo)dgvObjetivos.CurrentRow.DataBoundItem;
                frmABM.InicializarForm(ABMObjetivo.FormMode.eliminar, objetivo);
                frmABM.ShowDialog();
                btnSearch_Click(sender, e);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ABMObjetivo agregar = new ABMObjetivo();
            agregar.ShowDialog();
            btnSearch_Click(sender, e);
        }

        private void dgvObjetivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void dgvObjetivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvObjetivos.Columns[e.ColumnIndex].Name == "Estado")
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
    }
}
