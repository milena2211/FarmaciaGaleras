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
    public partial class QuejasSugerencias : Form
    {
        ArrayList inventario;
        int[] cantidades = new int[3];

        public QuejasSugerencias(ArrayList inventario, int[] cantidades)
        {
            InitializeComponent();
            this.cantidades = cantidades;
            this.inventario = inventario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboTipoRecurso.SelectedItem.ToString() == "Felicitación")
            {
                cantidades[0] = cantidades[0] + 1;
            }
            MDIFarmacia form = new MDIFarmacia(inventario, cantidades);
            form.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MDIFarmacia form = new MDIFarmacia(inventario, cantidades);
            form.Show();
            this.Hide();
        }

        private void QuejasSugerencias_Load(object sender, EventArgs e)
        {
            txtNumeroDeFelicitaciones.Text = cantidades[0].ToString();
        }
    }
}
