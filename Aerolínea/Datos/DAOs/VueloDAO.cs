using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolínea.Datos.DAOs
{
    internal class VueloDAO
    {
        AccesoDatos oBD;
        public VueloDAO() 
        {
            oBD = new AccesoDatos();
        }
    }
}
