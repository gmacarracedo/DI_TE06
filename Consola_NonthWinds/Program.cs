using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBLL;


namespace Consola_NonthWinds
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> listaClientes;
            listaClientes = OperacionesBLL.BuscarListaClientes();
            foreach (string idCliente in listaClientes) {
                Console.WriteLine(idCliente);
            }
        }

    }
}
