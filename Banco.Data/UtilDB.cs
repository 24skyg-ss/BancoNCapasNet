using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Data
{
    public static class UtilDB
    {
        public static string CadenaConexion()
        {
            string cadenaConex = @"Server=DESKTOP-29K2QJ8\MYSQLSERVER; DataBase=BancoBD; User=APPData; Password=71819736";

            return cadenaConex;
        }
    }
}
