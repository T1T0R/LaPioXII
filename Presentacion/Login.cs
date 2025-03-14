using LaPioXII.Logica;
using LaPioXII.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPioXII
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            string rol = UsuariosLogica.IniciarSesion(usuario, contraseña);

            if (rol != null)
            {
                MessageBox.Show($"Bienvenido, {usuario}.", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (rol == "ADMIN")
                {
                    VentasAdmin ventasAdmin = new VentasAdmin();
                    ventasAdmin.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro= new Registro();  

            registro.Show();

        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido "ding"
                textBox2.Focus(); // Pasa al siguiente TextBox
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido "ding"
                button1.PerformClick(); // Simula un clic en el botón
            }
        }
    }
}