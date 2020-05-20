using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cerrajeria_2
{
    public partial class CapturarInventario : Form
    {
        public CapturarInventario(string Usuario)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario(lblUsuario.Text);
            inventario.Show();
            this.Hide();
        }
    }
}
