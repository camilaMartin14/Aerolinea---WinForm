using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolínea.Negocio
{
    internal class Tripulante
    {
        public int Id {  get; set; }

        public string Nombre { get; set; }

        public string Apellido {  get; set; }

        public DateTime Nacimiento { get; set; }

        public bool Activo {  get; set; }

        public int Documento { get; set; }

        public int TipoDocumento {  get; set; }

        public Profesion Profesion { get; set; }

        public int ObraSocial {  get; set; }

        public int FranjaHoraria {  get; set; }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}
