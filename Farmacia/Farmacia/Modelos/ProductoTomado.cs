using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Modelos
{
    public class ProductoTomado : Medicina
    {
        public string nombreEnvase { get; set; }

        public Boolean Flagcuchara { get; set; }

        public string cuchara()
        {
            if(Flagcuchara == true)
            {
                return "Si";
            }
            else
            {
                return "No";
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nEnvase: {nombreEnvase} \nCuchara(Si/No): {cuchara()}";
        }
    }
}
