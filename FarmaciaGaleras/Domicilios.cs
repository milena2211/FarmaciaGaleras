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
    public partial class Domicilios : Form
    {

        ProductoADomicilio producto = new ProductoADomicilio();
        ArrayList inventario;
        RequisitosDomicilios domicilio = new RequisitosDomicilios();
        ArrayList domicilios = new ArrayList();
        int[] cantidades = new int[3];



        public Domicilios(ArrayList inventario, int[] cantidades)
        {
            InitializeComponent();
            this.cantidades = cantidades;
            this.inventario = inventario;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void gtnGuardar_Click(object sender, EventArgs e)
        {
            domicilio.crearDomicilio(txtConcentracion.Text, txtNombreProducto.Text,
                 txtPresentacion.Text, txtCodigoProducto.Text, int.Parse(txtValorUnitario.Text),
                 int.Parse(txtCantidad.Text), int.Parse(txtValorTotal.Text));
            domicilios.Add(domicilio);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MDIFarmacia form = new MDIFarmacia(inventario, cantidades);
            form.Show();
            this.Hide();
        }

        private void cboBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {

            if (domicilios.Count != 0)
            {
                foreach (RequisitosDomicilios domicilio in domicilios)
                {
                    foreach (ProductoEnInventario producto in inventario)
                    {
                        if (domicilio.codigoProducto() == producto.CodigoProducto())
                        {
                            string d = domicilios.Count.ToString();
                            int nuevaCantidad = producto.CantidadDisponible() - domicilio.cantidad();
                            producto.ActualizarCantidad(nuevaCantidad);

                        }

                    }
                    Entrega form = new Entrega(inventario, domicilios, cantidades);
                    form.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Por favor agregue productos al domicilio", "Dimicilio sin productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text != "" && txtConcentracion.Text != "" &&
                txtPresentacion.Text != "" && txtCantidad.Text != "")
            {
                foreach (ProductoEnInventario p in inventario)
                {
                    if (p.NombreProducto() == txtNombreProducto.Text && p.Concentracion() == txtConcentracion.Text &&
                        p.Presentacion() == txtPresentacion.Text)
                    {
                        txtCodigoProducto.Text = p.CodigoProducto();
                        txtValorUnitario.Text = p.ValorUnitario().ToString();
                        int total = int.Parse(txtCantidad.Text) * p.ValorUnitario();
                        txtValorTotal.Text = total.ToString();
                        btnGuardar.Enabled = true;
                    }
                }

            }
            else
            {
                MessageBox.Show("Por favor llene los campos de Nombre de producto, Concentración, Presentación y Cantidad", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Domicilios_Load(object sender, EventArgs e)
        {

        }
    }

    internal class ProductoADomicilio
    {
    }
}
