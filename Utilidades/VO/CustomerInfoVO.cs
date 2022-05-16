using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class CustomerInfoVO
    {
        private string idCliente;
        private string nombreCompania;
        private string nombreContacto;
        private string tituloContacto;
        private string direccion;
        private string ciudad;
        private string pais;
        private string telefono;

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCompania { get => nombreCompania; set => nombreCompania = value; }
        public string NombreContacto { get => nombreContacto; set => nombreContacto = value; }
        public string TituloContacto { get => tituloContacto; set => tituloContacto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
