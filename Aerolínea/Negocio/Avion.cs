using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolínea.Negocio
{
    internal class Avion
    {
        public string Matricula {  get; set; }
        public string Modelo { get; set; }

        public int Capacidad {  get; set; }

        public int Autonomia { get; set; }

        public DateTime Mantenimiento {  get; set; }

        public bool Operativo { get; set; }

        public bool Disponible {  get; set; }

        public Aeropuerto Aeropuerto { get; set; }

        public override string ToString()
        {
            return Matricula;
        }
    }
}
