using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cerrajeria_2
{  
    public partial class Cliente : Form
    {

        Validaciones V = new Validaciones();
        SqlConnection con = new SqlConnection("Data Source=34.71.252.51;Initial Catalog=Cerrajeria_Hns;Persist Security Info=True;User ID=sqlserver;Password=123");

        public Cliente(string Usuario)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand InCliente = new SqlCommand("sp_Cliente", con);
                InCliente.CommandType = CommandType.StoredProcedure;

                //AGREGAR PARAMETROS
                InCliente.Parameters.AddWithValue("@Nom", SqlDbType.VarChar).Value = txtNombre.Text;
                InCliente.Parameters.AddWithValue("@Rfc", SqlDbType.VarChar).Value = txtRFC.Text;
                InCliente.Parameters.AddWithValue("@Dire", SqlDbType.VarChar).Value = txtDireccion.Text;
                InCliente.Parameters.AddWithValue("@Cod", SqlDbType.VarChar).Value = txtCodigo.Text;
                InCliente.Parameters.AddWithValue("@Ciu", SqlDbType.VarChar).Value = txtCiudad.Text;
                InCliente.Parameters.AddWithValue("@Tel", SqlDbType.DateTime).Value = txtTelefono.Text;
                InCliente.Parameters.AddWithValue("@Col", SqlDbType.DateTime).Value = txtColonia.Text;
                

                //EJECUTAR SP
                InCliente.ExecuteNonQuery();
                MessageBox.Show("CLIENTE AGREGADO!", "INGRESO EXITOSO");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE CONEXION, INTENTE MAS TARDE\n\n" + ex.ToString());
            }
            finally
            {
                con.Close();
                Limpiar();
            }
        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtRFC.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtColonia.Text = "";
        }

        

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.SoloLetras(e);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.SoloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.SoloNumeros(e);
        }
    }
}
