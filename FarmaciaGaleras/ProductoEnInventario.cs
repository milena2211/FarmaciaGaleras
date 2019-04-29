using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaGaleras
{
    class ProductoEnInventario
    {
        DateTimePicker fechaRealizacionInventario;
        string numeroEstante;
        string codigoProducto;
        string nombreProducto;
        string concentracion;
        string presentacion;
        int cantidadDisponible;
        DateTime fechaVencimiento;
        int valorUnitario;

       


        public void crearProducto(DateTimePicker fechaRealizacionInventario,
        string numeroEstante,
        string codigoProducto,
        string nombreProducto,
        string concentracion,
        string presentacion,
        int cantidadDisponible,
        DateTime fechaVencimiento,
        int valorUnitario)
        {
            this.fechaRealizacionInventario = fechaRealizacionInventario;
            this.numeroEstante = numeroEstante;
            this.codigoProducto = codigoProducto;
            this.nombreProducto = nombreProducto;
            this.concentracion = concentracion;
            this.presentacion = presentacion;
            this.cantidadDisponible = cantidadDisponible;
            this.fechaVencimiento = fechaVencimiento;
            this.valorUnitario = valorUnitario; 



        }

        public string CodigoProducto()
        {
            return this.codigoProducto;
         }
        public void ActualizarCantidad(int Nuevacantidad)
        {
            this.cantidadDisponible = Nuevacantidad;
        }

        public int CantidadDisponible()
        {
            return this.cantidadDisponible;
        }

        public string NombreProducto()
        {
            return this.nombreProducto;
        }

        public string Concentracion()
        {
            return this.concentracion;
        }

        public string Presentacion()
        {
            return this.presentacion;
        }

        public int ValorUnitario()
        {
            return this.valorUnitario;
        }
    }   


    
}
