using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Entidades.Entidades
{
    public class Compra : ICloneable
    {

        public int CompraId { get; set; }
        public int ProveedorId { get; set; }

       

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
