using Neptuno2023.Entidades.Dtos.Compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Comun.Interfases
{
    public interface IRepositorioCompras
    {
        List<CompraDto> GetCompras();
    }
}
