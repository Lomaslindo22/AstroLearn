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
    public partial class formMenuPrincipal : Form
    {
        public formMenuPrincipal()
        {
            InitializeComponent();
        }

        private void formMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnObjetos_Click(object sender, EventArgs e)
        {
            formObjetosAstronomicos objetos = new formObjetosAstronomicos();
            objetos.Show();
            this.Hide();
        }

        private void btnMisiones_Click(object sender, EventArgs e)
        {
            formMisiones misiones = new formMisiones();
            misiones.Show();
            this.Hide();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            formMiCuenta cuenta = new formMiCuenta();
            cuenta.Show();
            this.Hide();
        }

        private void btnCerrarSeccion_Click(object sender, EventArgs e)
        {
            formInicioSeccion login = new formInicioSeccion();
            login.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
