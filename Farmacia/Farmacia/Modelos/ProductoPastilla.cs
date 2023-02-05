using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Modelos
{
    public class ProductoPastilla : Medicina
    {

        public double Gramos { get; set; }
        public string Color { get; set; }
        public string Presentacion { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} \nGramos: {Gramos}g \nColor: {Color} \nPresentacion: {Presentacion}";
        }

    }
}
