using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Layers.Framework.ADO.NET.Data;

namespace WinFormsAppSellPoint_V1._0
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            InitializeMyControl();
        }

        private void InitializeMyControl()
        {
            // The password character is an asterisk.
            txtpassword.PasswordChar = '*';
           
        }

        //Evento para cerrar el programa desde el menu
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Evento para limpiar los campos

        private void labelClearFields_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtpassword.Text = "";


        }

        //Evento para el SELECT que va a validar las credenciales del login
        private void ButtonLogin_Click_1(object sender, EventArgs e)
        {

            if (ClassData.SQLDatareader(ClassData.sqlCommand("select * from Entidades " +
                "where UserNameEntidad = '" + txtUserName.Text + "' " +
    "           and PasswordEntidad = '" + txtpassword.Text + "'", CommandType.Text)).HasRows)
            {

                Program.boolUserAuthenticated = true;
                Program.stringUserName = txtUserName.Text;
                ClassData.OpenDBSQLServer().Close();
                ClassData.OpenDBSQLServer().Dispose();
                MessageBox.Show("Credenciales correctas");
                this.DialogResult = DialogResult.OK;
                if (Program.LoginConfirm == true)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
