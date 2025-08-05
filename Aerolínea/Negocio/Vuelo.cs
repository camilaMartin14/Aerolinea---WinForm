using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolínea.Negocio
{
    internal class Vuelo
    {
        public int Id {  get; set; }

        public string Descripcion {  get; set; }

        public DateTime Salida { get; set; }

        public DateTime Llegada { get; set; }

        public int DuracionEstimada {  get; set; }  

        public Avion Avion { get; set; }

        public Aeropuerto AeropuertoOrigen { get; set; }

        public Aeropuerto AeropuertoDestino { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
