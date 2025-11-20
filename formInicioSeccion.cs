using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstroLearn
{
    public partial class formInicioSeccion : Form
    {
        public formInicioSeccion()
        {
            InitializeComponent();
        }

        private void btnIniciarSeccion_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuarioIS.Text.Trim();
            string contrasena = txtContrasenaIS.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor ingresa usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = ListaUsuarios.Usuarios
                               .FirstOrDefault(u => u.NombreUsuario.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (usuario == null)
            {
                MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario.Contrasena != contrasena)
            {
                MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            formMenuPrincipal menu = new formMenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            formRegistro registro = new formRegistro();
            registro.Show();
            this.Hide();
        }
    }
}
