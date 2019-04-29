using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaGaleras
{
    public class RequisitosDomicilios
    {
        string NombreProducto;
        string Concentracion;
        string Presentacion;
        string CodigoProducto;
        int ValorUnitario;
        int Cantidad;
        int ValorTotal;

    public void crearDomicilio(
        string Concentracion,
        string NombreProducto,
        string Presentacion,
        string CodigoProducto,
        int ValorUnitario,
        int Cantidad,
        int ValorTotal)

        {  this.NombreProducto = NombreProducto;
                this.Concentracion = Concentracion;
                this.Presentacion = Presentacion;
                this.CodigoProducto = CodigoProducto;
                this.ValorUnitario = ValorUnitario;
                this.Cantidad = Cantidad;
                this.ValorTotal = ValorTotal;
        }
        public string codigoProducto()
        {
            return this.CodigoProducto;
        }
        public int cantidad()
        {
            return this.Cantidad;
        }
        public int valorTotal()
        {
            return this.ValorTotal;
        }

    }

}