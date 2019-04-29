using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaGaleras
{
    public partial class Entrega : Form
    {
        ArrayList inventario;
        ArrayList domicilios;
        Cliente cliente = new Cliente();
        int[] cantidades = new int[3];

        public Entrega(ArrayList inventario, ArrayList domicilios, int[] cantidades)
        {
            InitializeComponent();
            this.cantidades = cantidades;
            this.domicilios = domicilios;
            this.inventario = inventario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text != "" && txtIdentificacionUsuario.Text != "" &&
                txtDireccion.Text != "" && txtBarrio.Text != "" && txtTelefono.Text != "" && cboDomiciliario.Text != "")
            {
                if (cboDomiciliario.SelectedItem.ToString() == "Domiciliario 1")
                {
                    cantidades[1] = cantidades[1] + 1;
                }
                else
                {
                    cantidades[2] = cantidades[2] + 1;
                }
                cliente.crearCliente(txtNombreUsuario.Text, txtIdentificacionUsuario.Text,
                    txtDireccion.Text, txtBarrio.Text, txtTelefono.Text, cboDomiciliario.Text);
                Factura form = new Factura(cliente, inventario, domicilios, cantidades);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor ingrese toda la información del cliente", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Domicilios form = new Domicilios(inventario, cantidades);
            form.Show();
            this.Hide();
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrega_Load(object sender, EventArgs e)
        {
            txtEntregasDomiciliario1.Text = cantidades[1].ToString();
            txtEntregasDomiciliario2.Text = cantidades[2].ToString();
        }
    }
}
