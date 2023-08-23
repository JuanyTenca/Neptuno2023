using Neptuno2023.Comun.Interfases;
using Neptuno2023.Entidades.Dtos.Compra;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Datos.Repositorios
{
    public class RepositorioCompras: IRepositorioCompras
    {
        private readonly string cadenaConexion;
        public RepositorioCompras()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public List<CompraDto> GetCompras()
        {
            try
            {
                List<CompraDto> lista = new List<CompraDto>();
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    conn.Open();
                    string selectQuery = @"SELECT CompraId, ProveedorId, FechaCompra, Total
                         FROM Compras INNER JOIN Proveedores
                         ON Compras.ProveedorId = Proveedores.ProveedorId
                         ORDER BY FechaCompra";
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var compra = ConstruirCompraDto(reader);
                                lista.Add(compra);
                            }
                        }
                    }
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private CompraDto ConstruirCompraDto(SqlDataReader reader)
        {
            return new CompraDto
            {
                CompraId = reader.GetInt32(0),
                FechaCompra = reader.GetDateTime(1),
                ProveedorId = reader.GetInt32(2),
                Total = reader.GetDecimal(3)
           
            };
        }
    }
}
