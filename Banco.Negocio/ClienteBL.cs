using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Banco.Data;
using Banco.Entidades;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Banco.Negocio
{
    public static class ClienteBL
    {
        public static List<Cliente> Listar()
        {
            var clienteDB = new ClienteDB();
            return clienteDB.Listar();
        }

        public static bool Insertar(Cliente cliente)
        {
            var clienteDB = new ClienteDB();
            return clienteDB.Insertar(cliente) > 0;
        }
    }
}
