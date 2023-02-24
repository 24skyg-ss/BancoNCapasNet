using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Banco.Entidades;
using System.Threading.Tasks;

namespace Banco.Data
{
    public class ClienteDB
    {
        // TODO: Listar todos los clientes.
        public List<Cliente> Listar()
        {
            var listado = new List<Cliente>();

            using (SqlConnection conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Cliente", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            while (lector.Read())
                            {
                                Cliente cliente = new Cliente();
                                cliente.ID = (int)lector["ID"];
                                cliente.Nombres = lector["Nombres"].ToString();
                                cliente.Apellidos= lector["Apellidos"].ToString();
                                cliente.RazonSocial = lector["RazonSocial"].ToString();
                                cliente.NumeroDocumento = lector["NumeroDoc"].ToString();
                                cliente.IdTipoCliente = (int)lector["IdTipoCliente"];
                                cliente.IdTipoDocumento = (int)lector["IdTipoDoc"];
                                cliente.Direccion = lector["Direccion"].ToString();
                                cliente.Referencia = lector["Referencia"].ToString();
                                cliente.Telefono = lector["Telefono"].ToString();
                                cliente.Email= lector["Email"].ToString();

                                // AGREGA EL CLIENTE AL LISTADO
                                listado.Add(cliente);
                            }
                        }
                    }
                }
            }
            return listado;
        }

        public int Insertar(Cliente cliente)
        {
            int filas = 0;

            using (SqlConnection conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                var query = "INSERT INTO [dbo].[Cliente] " +
                    "([Nombres],[Apellidos],[RazonSocial],[NumeroDoc],[IdTipoCliente],[IdTipoDoc],[Direccion],[Referencia],[Telefono],[Email]) " +
                    "VALUES(@Nombres,@Apellidos,@RazonSocial,@NumeroDoc,@IdTipoDoc,@IdTipoCliente," +
                    "@Direccion,@Referencia,@Telefono,@Email)";
                using (var comando = new SqlCommand(query,conexion))
                {
                    comando.Parameters.AddWithValue("@Nombres",cliente.Nombres);
                    comando.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                    comando.Parameters.AddWithValue("@RazonSocial", cliente.RazonSocial);
                    comando.Parameters.AddWithValue("@NumeroDoc", cliente.NumeroDocumento);
                    comando.Parameters.AddWithValue("@IdTipoDoc", cliente.IdTipoDocumento);
                    comando.Parameters.AddWithValue("@IdTipoCliente", cliente.IdTipoCliente);
                    comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    comando.Parameters.AddWithValue("@Referencia", cliente.Referencia);
                    comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@Email", cliente.Email);

                    filas = comando.ExecuteNonQuery();
                }
            }

            return filas;
        }

    }
}
