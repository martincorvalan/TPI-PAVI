using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
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

namespace ProjectoPAV.GUILayer
{
    public partial class Menu : Form
    {

        public Menu(String logueado)
        {
            InitializeComponent();
            lblLogueado.Text = logueado;
        }

        private void moveImageBox(object sender)
        {
            Guna2Button c = (Guna2Button)sender;
            imageCurve.Location = new Point(c.Location.X + 166, c.Location.Y - 31);
            imageCurve.SendToBack();
        }


        private void btnCursos_CheckedChanged(object sender, EventArgs e)
        {
            imageCurve.Visible = true;
            moveImageBox(sender);
        }

        //Metodo para poder mover el formulario sin la barra
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelBar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OpenForm<MyForm>() where MyForm : Form, new()
        {
            Form formulario;
            formulario = panelCentral.Controls.OfType<MyForm>().FirstOrDefault();
            if(formulario == null)
            {
                formulario = new MyForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelCentral.Controls.Add(formulario);
                panelCentral.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            OpenForm<ConsultaCurso>();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            btnCategorias.Checked = false;
            btnCursos.Checked = false;
            btnOpcion.Checked = false;
            imageCurve.Visible = false;
            logoMenu.BringToFront();

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            panelCentral.BringToFront();
        }
    }
}
