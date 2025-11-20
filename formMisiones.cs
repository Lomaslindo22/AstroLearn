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
    public partial class formMisiones : Form
    {
        public formMisiones()
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
