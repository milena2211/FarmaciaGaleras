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
    public partial class Farmacia : Form
    {
        ArrayList inventario = new ArrayList();
        string[] usuarios = new string[10];
        string[] contraseñas = new string[10];
        int[] cantidades = new int[3];

        //cantidades[0] = cantidad de felicitaciones
        //cantidades[1] = cantidad de entregas del Domiciliario 1
        //cantidades[2] = cantidad de entregas del Domiciliario 2


        public Farmacia()
        {
            InitializeComponent();
        }
        public Farmacia(ArrayList inventario, int[] cantidades)
        {
            InitializeComponent();
            this.inventario = inventario;
            this.cantidades = cantidades;
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int posicion = 0;
            for (int i = 0; i < usuarios.Length; i++)
            {
                if (txtUsuario.Text == usuarios[i])
                {
                    posicion = i;
                }
            }
            if (contraseñas[posicion] == txtContraseña.Text)
            {
                MDIFarmacia form = new MDIFarmacia(inventario, cantidades);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor ingrese los datos correctamente", "Fallo al iniciar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Farmacia_Load(object sender, EventArgs e)
        {

            usuarios[0] = "Camila";
            contraseñas[0] = "123";
            usuarios[1] = "Daniela";
            contraseñas[1] = "456";
            usuarios[2] = "Milena";
            contraseñas[2] = "678";
            usuarios[3] = "Liney";
            contraseñas[3] = "987";
        }
    }
}
