using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPioXII.Presentacion
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void linkLblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtContraseñaRegistro.PasswordChar == '*')
            {
                txtContraseñaRegistro.PasswordChar = '\0'; // Muestra el texto
                linkLblRegistro.Text = "OCULTAR CONTRASEÑA";
            }
            else
            {
                txtContraseñaRegistro.PasswordChar = '*'; // Oculta con *
                linkLblRegistro.Text = "VER CONTRASEÑA";
            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioRegistro.Text.Trim();
            string contraseña = txtContraseñaRegistro.Text.Trim();

            if (Logica.UsuariosLogica.CrearUsuario(usuario, contraseña))
            {
                MessageBox.Show("Usuario creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuarioRegistro.Clear();
                txtContraseñaRegistro.Clear();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al crear el usuario. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuarioRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido 'ding'
                txtContraseñaRegistro.Focus(); // Pasa a la contraseña
            }
        }

        private void txtContraseñaRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido 'ding'
                btnCrearUsuario.PerformClick(); // Simula un clic en el botón
            }
        }

    }
}
