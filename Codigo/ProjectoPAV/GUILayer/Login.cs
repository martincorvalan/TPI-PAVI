﻿using ProjectoPAV.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            if (ValidarLogin(txtBoxUser.Text, txtBoxPass.Text))
            {
                MessageBox.Show("Inicio de sesion correcto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
