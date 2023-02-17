using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    internal class Cliente
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string RazonSocial { get; set; }
        public string NumeroDocumento { get; set; }
        public int IdTipoCliente { get; set; }
        public int IdTipoDocumento { get; set; }
        public string Direccion { get; set; }
        public string Referencia { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }


    }
}
