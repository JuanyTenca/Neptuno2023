using Neptuno2023.Comun.Interfases;
using Neptuno2023.Datos.Repositorios;
using Neptuno2023.Entidades.Dtos.Compra;
using Neptuno2023.Servicios.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Servicios.Servicios
{
    public class ServiciosCompras : IServiciosCompras
    {

        private readonly IRepositorioCompras _repositorio;

        public ServiciosCompras()
        {
            _repositorio = new RepositorioCompras();
        }

        public List<CompraDto> GetCompras()
        {
            try
            {
                return _repositorio.GetCompras();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
