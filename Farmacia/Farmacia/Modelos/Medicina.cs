using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Modelos
{
    public class Medicina
    {
        public string nombre { get; set; }

        public double precio { get; set; }

        public DateTime fechaVencimiento { get; set; }

        public List<string> ingredientes { get; set; } = new List<string>();

        public string listaIngredientes()
        {
            string resultado = "\nIngredientes: ";

            for (int i = 0; i < ingredientes.Count; i++)
            {
                resultado += "\n" + ingredientes[i];
            }

            return resultado;
        }

        public override string ToString()
        {
            return $"\nNombre: {nombre} \nPrecio: L.{precio} \nFecha Vencimiento(MM/YY): {fechaVencimiento.ToString("MM/yy")} {listaIngredientes()}";
        }
    }
}
