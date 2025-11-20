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
    public partial class formMiCuenta : Form
    {
        public formMiCuenta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formMenuPrincipal menu = new formMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}
