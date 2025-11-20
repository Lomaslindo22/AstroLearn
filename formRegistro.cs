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
    public partial class formRegistro : Form
    {
        public formRegistro()
        {
            InitializeComponent();
        }

        private void lblConfirmacionContraseña_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtRegistroNombre.Text.Trim();
            string contrasena = txtRegistroContrasena.Text.Trim();
            string confirmar = txtConfirmarContrasena.Text.Trim();
            string correo = txtRegistroCorreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) ||
            string.IsNullOrWhiteSpace(contrasena) ||
            string.IsNullOrWhiteSpace(confirmar) ||
            string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (contrasena.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (contrasena != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("Ingresa un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool correoExiste = ListaUsuarios.Usuarios
                    .Any(u => u.Correo.Equals(correo, StringComparison.OrdinalIgnoreCase));

            if (correoExiste)
            {
                MessageBox.Show("El correo que ingresaste ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool nombreExiste = ListaUsuarios.Usuarios
                     .Any(u => u.NombreUsuario.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (nombreExiste)
            {
                MessageBox.Show("El nombre de usuario ya está registrado. Intenta con otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Hasta acá se hacemos las validaciones que pusimos en el doc de análisis

            Usuario nuevo = new Usuario(nombre, contrasena, correo);
            ListaUsuarios.Usuarios.Add(nuevo);

            MessageBox.Show("¡Registro exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            formInicioSeccion login = new formInicioSeccion();
            login.Show();
            this.Hide();
        }

    }
}
