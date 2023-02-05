using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Modelos
{
    public class ProductoInyectado : Medicina
    {
        public float mlProducto { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nDosis: {mlProducto} ml";
        }
    }
}
