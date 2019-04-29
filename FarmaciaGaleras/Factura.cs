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
    public partial class Factura : Form
    {
        Cliente cliente;
        ArrayList inventario;
        ArrayList domicilios;
        int[] cantidades = new int[3];
        public Factura(Cliente cliente , ArrayList inventario, ArrayList domicilios, int[] cantidades )
        {
            InitializeComponent();
            this.cantidades = cantidades;
            this.cliente = cliente;
            this.inventario = inventario;
            this.domicilios = domicilios;
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            MDIFarmacia form = new MDIFarmacia(inventario, cantidades);
            form.Show();
            this.Hide();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            txtNombreCliente.Text=cliente.nombreCompleto();
            txtDireccion.Text = cliente.direccion();
            txtTelefono.Text = cliente.telefono();
            string cantidadProductos = domicilios.Count.ToString();
            txtCantidadProducto.Text = cantidadProductos;
            int valorTotalFactura = 0;
            foreach(RequisitosDomicilios d in domicilios)
            {
                valorTotalFactura = valorTotalFactura + d.valorTotal();
            }
            txtValorTotal.Text = valorTotalFactura.ToString();


        }
    }
}
