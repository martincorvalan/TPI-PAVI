using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoPAV.GUILayer.ABMC_Curso
{
    public partial class ObjetivosCurso : Form
    {
        private int id_curso;
        public ObjetivosCurso(int id)
        {
            InitializeComponent();
            id_curso = id;
        }

        private void ObjetivosCurso_Load(object sender, EventArgs e)
        {
            try
            {
                this.objetivosTableAdapter.objetivos_x_curso1(this.bugTrackerGrupo9DataSet.Objetivos, id_curso);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
