using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Entidades.Dtos.Compra
{
    public class CompraDto
    {
        public int CompraId { get; set; }
        public int ProveedorId { get; set; } 
        public decimal Total { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}
