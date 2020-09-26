using ProjectoPAV.BussinesLayer;
using ProjectoPAV.DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Menu = ProjectoPAV.GUILayer.Menu;

namespace ProjectoPAV
{
    public partial class Login : Form
    {
        private readonly UserService userService;

        public String UserLog { get; internal set; }

        public Login()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                //Llama al servicio validar usuario y espera el retorno del objeto usuario
                var user = userService.ValidarUser(txtBoxUser.Text, txtBoxPass.Text);

                //Control de credenciales de login
                if (user != null)
                {
                    UserLog = user.Username;
                    Menu menu1 = new Menu(txtBoxUser.Text);
                    menu1.Show();
                    this.Hide();
                }
                else
                {
                    txtBoxPass.Text = "";
                    txtBoxPass.Focus();
                    lblContraseñaValida.Text = "Contraseña Incorrecta";
                    lblContraseñaValida.Visible = true;

                }
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


                //Verifica que la consulta haya devuelto alguna fila
                if (queryResult.Rows.Count >= 1)
                {
                    //Valida la contraseña comparando la cuonsulta sql y el campo txtPass.Text 
                    if (queryResult.Rows[0]["password"].ToString() == pass)
                    {
                        validUser = true;
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(String.Concat("Error en la base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
            return validUser;
        }

        private bool ValidarCampos()
        {
            bool validacion = true;

            if (txtBoxUser.Text == string.Empty)
            {
                lblFaltaNombreUsuario.Visible = true;
                txtBoxUser.Focus();
                validacion = false;
            }
            else
                lblFaltaNombreUsuario.Visible = false;

            if (txtBoxPass.Text == string.Empty)
            {
                lblContraseñaValida.Text = "Ingrese una contraseña valida";
                lblContraseñaValida.Visible = true;
                txtBoxPass.Focus();
                validacion = false;
            }
            else
                lblContraseñaValida.Visible = false;

            return validacion;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnIngresar_Click(sender, e);
            }
        }
    }
}
