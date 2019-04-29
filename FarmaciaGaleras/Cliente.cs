using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaGaleras
{
    public class Cliente
    {
        string NombreUsuario;
        string Identificacion;
        string Direccion;
        string Barrio;
        string TelefonoContacto;
        string Domiciliario;


        public void crearCliente(string NombreUsuario,
       string Identificacion,
       string Direccion,
       string Barrio,
       string TelefonoContacto,
       string Domiciliario)

        {
            this.NombreUsuario= NombreUsuario;
            this.Identificacion = Identificacion;
            this.Direccion = Direccion;
            this.Barrio = Barrio;
            this.TelefonoContacto = TelefonoContacto;
            this.Domiciliario = Domiciliario;
        }

        public string nombreCompleto()
        {
            return this.NombreUsuario;
        }

        public string direccion()
        {
            return this.Direccion;
        }
        public string telefono()
        {
            return this.TelefonoContacto;
        }
    }
}
