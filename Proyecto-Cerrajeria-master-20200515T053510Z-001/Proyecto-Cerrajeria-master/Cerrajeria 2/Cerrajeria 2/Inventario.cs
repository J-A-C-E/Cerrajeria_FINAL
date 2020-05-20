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
    public partial class Inventario : Form
    {
        public Inventario(string Usuario)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
        }

        private void btnCapturarInventario_Click(object sender, EventArgs e)
        {
            CapturarInventario miCaptura = new CapturarInventario(lblUsuario.Text);
            miCaptura.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal(lblUsuario.Text);
            principal.Show();
            this.Hide();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }
    }
}
