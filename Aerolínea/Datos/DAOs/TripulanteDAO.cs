using Aerolínea.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolínea.Datos.DAOs
{
    internal class TripulanteDao
    {
        AccesoDatos oBD;
        public TripulanteDao() 
        {
            oBD = new AccesoDatos();
        }

        // Cargar Grilla Tripulantes
        public List<Tripulante> TraerTripulantes(Filtro f)
        {
            List<Tripulante> lista = new List<Tripulante>();

            string consultaSQL = " SELECT t.id_tripulante, t.nombre, t.apellido, t.fecha_nacimiento, t.activo, t.nro_doc,p.id_profesion, p.descripcion, os.descripcion, fh.descripcion FROM " +
                                    " tripulantes t, profesiones p, obras_sociales os, franjas_horarias fh WHERE t.id_profesion = p.id_profesion AND p.id_obra_social = os.id_obra_social AND p.id_franja_horaria = fh.id_franja_horaria ";



            if (!string.IsNullOrEmpty(f.Nombre))
            {
                consultaSQL += " AND t.nombre LIKE '%" + f.Nombre + "%' ";
            }

            if (f.Profesion != null)
            {
                consultaSQL += $" AND t.id_profesion = {f.Profesion}";
            }

            DataTable dt = oBD.ConsultarBD(consultaSQL);

            foreach (DataRow dr in dt.Rows)
            {
                Tripulante t = new Tripulante();

                t.Id = (int)dr["id_tripulante"];
                t.Nombre = dr["nombre"].ToString();
                t.Apellido = dr["apellido"].ToString();
                t.Nacimiento = (DateTime)dr["fecha_nacimiento"];
                t.Activo = (bool)dr["activo"];

                t.Profesion = new Profesion();
                t.Profesion.Id = (int)dr["id_profesion"];
                t.Profesion.Descripcion = dr["descripcion"].ToString();

                lista.Add(t);
            }

            return lista;
        }


        // Cargar Combo Idiomas

        // Cargar Combo Profesiones

        // Traer un Tripulante






    }
}
