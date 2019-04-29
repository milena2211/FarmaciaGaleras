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
    public partial class Inventario : Form
    {

        ProductoEnInventario producto = new ProductoEnInventario();
        ArrayList inventario;
        int[] cantidades = new int[3];



        public Inventario(ArrayList inventario, int[] cantidades)
        {
            InitializeComponent();
            this.cantidades=cantidades;
            this.inventario = inventario;
            producto.crearProducto(dtpFechaRealizacion,"2","2","2","2","2",2,dtpFechaVencimiento.Value,2);
            inventario.Add(producto);
            producto = new ProductoEnInventario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esta = false;

            if (txtNumeroEstante.Text != "" && txtcodigoProducto.Text != "" && txtNombreProducto.Text != "" &&
                txtConcentracion.Text != "" && txtPresentacion.Text != "" && txtCantidadDisponible.Text != "" && 
                txtValorUnitario.Text != "")
            {
                producto.crearProducto(dtpFechaRealizacion, txtNumeroEstante.Text, txtcodigoProducto.Text, txtNombreProducto.Text, txtConcentracion.Text, txtPresentacion.Text, int.Parse(txtCantidadDisponible.Text), dtpFechaVencimiento.Value, int.Parse(txtValorUnitario.Text));
                foreach (ProductoEnInventario p in inventario)
                {
                    if (p.CodigoProducto() == producto.CodigoProducto())
                    {
                        int NuevaCantidad = p.CantidadDisponible() + producto.CantidadDisponible();
                        p.ActualizarCantidad(NuevaCantidad);
                        esta = true;
                    }

                }

                if (!esta)
                {
                    inventario.Add(producto);
                    producto = new ProductoEnInventario();
                }

            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MDIFarmacia form = new MDIFarmacia(inventario, cantidades);
            form.Show();
            this.Hide();
        }

        private void txtCantidadDisponible_TextChanged(object sender, EventArgs e)
        {
            int CantidadDisponible = 0;
            int.TryParse(txtCantidadDisponible.Text, out CantidadDisponible);
            if (CantidadDisponible < 10)
            {
                erpMensaje.SetError(txtCantidadDisponible, "El producto esta proximo agotarse");
            }
            else
            {
                erpMensaje.SetError(txtCantidadDisponible, null);
            }
        }
    }
}
