using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoPAV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "")
            {
                MessageBox.Show("Ingrese un Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return; 
            }
            if (txtBoxPass.Text == "")
            {
                MessageBox.Show("Ingrese una Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

        }

        public bool ValidarLogin(string user, string pass)
        {
            // Incializamos el valor booleano, True si coinciden False si no coinciden
            bool validUser = false;

            try
            {
                //Comenzamos realizando la consulta sql para buscar la contraseña y el nombre de usuario

                String sqlQuery = string.Concat(" SELECT * ",
                                               "  FROM Usuarios ",
                                               "  WHERE usuario =  '", user, "'");

                //Creamos un data table con el resultado de la consulta utilizando el data manager

                DataTable queryResult = DataManager.GetInstance().ConsultaSQL(sqlQuery);
            }
        }
    }
}
