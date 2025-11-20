using AstroLearn.Modelos;
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
    public partial class formObjetosAstronomicos : Form
    {
        public formObjetosAstronomicos()
        {
            InitializeComponent();
            MostrarObjetosEnGrid();
        }

        private void MostrarObjetosEnGrid()
        {
            dgvObjetos.DataSource = null;
            dgvObjetos.DataSource = ListaObjetos.Objetos;
        }
        private void LimpiarCampos()
        {
            txtNombreObjeto.Clear();
            txtAtributo1.Clear();
            txtAtributo2.Clear();
            txtAtributo3.Clear();
            txtDescripcion.Clear();
            cmbTipoObjeto.SelectedIndex = -1;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            formMenuPrincipal menu = new formMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgvObjetos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var obj = (ObjetoAstronomico)dgvObjetos.Rows[e.RowIndex].DataBoundItem;

                txtNombreObjeto.Text = obj.Nombre;
                cmbTipoObjeto.Text = obj.Tipo;
                txtAtributo1.Text = obj.Atributo1.ToString();
                txtAtributo2.Text = obj.Atributo2.ToString();
                txtAtributo3.Text = obj.Atributo3;
                txtDescripcion.Text = obj.Descripcion;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarObjeto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreObjeto.Text) ||
        string.IsNullOrWhiteSpace(cmbTipoObjeto.Text) ||
        string.IsNullOrWhiteSpace(txtAtributo1.Text) ||
        string.IsNullOrWhiteSpace(txtAtributo2.Text) ||
        string.IsNullOrWhiteSpace(txtAtributo3.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtAtributo1.Text, out double a1) ||
                !double.TryParse(txtAtributo2.Text, out double a2))
            {
                MessageBox.Show("Los atributos numéricos deben ser números válidos.", "Error");
                return;
            }

            string tipo = cmbTipoObjeto.Text.Trim();
            if (string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Seleccione un tipo de objeto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombreObjeto.Text;
            string a3 = txtAtributo3.Text;
            string descripcion = txtDescripcion.Text;

            // Validar nombre único
            if (ListaObjetos.Objetos.Any(o => o.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ya existe un objeto con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto mediante FACTORY
            var nuevo = ObjetoFactory.CrearObjeto(tipo, nombre, a1, a2, a3, descripcion);

            ListaObjetos.Objetos.Add(nuevo);

            MessageBox.Show("Objeto agregado correctamente.", "Éxito");

            MostrarObjetosEnGrid();
            LimpiarCampos();
        }

        private void btnEditarObjeto_Click(object sender, EventArgs e)
        {
            if (dgvObjetos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un objeto para editar.", "Error");
                return;
            }

            var obj = (ObjetoAstronomico)dgvObjetos.CurrentRow.DataBoundItem;

            string nuevoNombre = txtNombreObjeto.Text.Trim();

            if (!obj.Nombre.Equals(nuevoNombre, StringComparison.OrdinalIgnoreCase) &&
                ListaObjetos.Objetos.Any(o => o.Nombre.Equals(nuevoNombre, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ya existe un objeto con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Profe acá es para controlar una excepcion pero no la entendimos bien, gpt nos ayudo a controlar esto
            if (!double.TryParse(txtAtributo1.Text, out double a1) ||
                !double.TryParse(txtAtributo2.Text, out double a2))
            {
                MessageBox.Show("Los atributos numéricos deben ser números válidos.", "Error");
                return;
            }

            // Asignar valores
            obj.Nombre = nuevoNombre;
            obj.Tipo = cmbTipoObjeto.Text;
            obj.Atributo1 = a1;
            obj.Atributo2 = a2;
            obj.Atributo3 = txtAtributo3.Text;
            obj.Descripcion = txtDescripcion.Text;

            MessageBox.Show("Objeto editado correctamente.", "Éxito");

            MostrarObjetosEnGrid();
            LimpiarCampos();
        }

        private void btnEliminarObjeto_Click(object sender, EventArgs e)
        {
            if (dgvObjetos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un objeto para eliminar.", "Error");
                return;
            }

            var obj = (ObjetoAstronomico)dgvObjetos.CurrentRow.DataBoundItem;

            var resultado = MessageBox.Show($"¿Está seguro de eliminar el objeto '{obj.Nombre}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                ListaObjetos.Objetos.Remove(obj);
                MessageBox.Show("Objeto eliminado correctamente.", "Éxito");
                MostrarObjetosEnGrid();
                LimpiarCampos();
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
