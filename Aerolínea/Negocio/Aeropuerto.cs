using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolínea.Negocio
{
    internal class Aeropuerto
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }

        public string CodigoIATA {  get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
