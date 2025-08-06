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

            string consultaSQL =    " SELECT t.id_tripulante," +
                                    " t.nombre," +
                                    " t.apellido," +
                                    " t.fecha_nacimiento," +
                                    " t.activo, t.nro_doc," +
                                    "p.id_profesion," +
                                    " p.descripcion," +
                                    " os.descripcion 'descripcion os' ," +
                                    " fh.descripcion 'descripcion fh'," +
                                    " os.id_obra_social," +
                                    " fh.id_franja_horaria " +
                                    " FROM tripulantes t," +
                                    " profesiones p," +
                                    " obras_sociales os," +
                                    " franjas_horarias fh " +
                                    "WHERE t.id_profesion = p.id_profesion " +
                                    "AND t.id_obra_social = os.id_obra_social " +
                                    "AND t.id_franja_horaria = fh.id_franja_horaria ";

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

                t.ObraSocial = new ObraSocial();
                t.ObraSocial.Id = (int)dr["id_obra_social"];
                t.ObraSocial.Descripcion = dr["descripcion os"].ToString();

                t.FranjaHoraria = new FranjaHoraria();
                t.FranjaHoraria.Id = (int)dr["id_franja_horaria"];
                t.FranjaHoraria.Descripcion = dr["descripcion fh"].ToString();



                lista.Add(t);
            }

            return lista;
        }


        // Cargar Combo Idiomas
        public List<Idioma> TraerIdiomas()
        {
            List<Idioma> lista = new List<Idioma>();

            DataTable dt = oBD.ConsultarTabla("Idiomas");

            foreach (DataRow dr in dt.Rows)
            {

                Idioma i = new Idioma();

                i.Id = (int)dr["id_idioma"];
                i.Descripcion = dr["descripcion"].ToString();

                lista.Add(i);

            }

            return lista;
        }

        // Cargar Combo Profesiones
        public List<Profesion> TraerProfesiones()
        {
            List<Profesion> lista = new List<Profesion>();

            DataTable dt = oBD.ConsultarTabla("Profesiones");

            foreach (DataRow dr in dt.Rows)
            {

                Profesion p = new Profesion();

                p.Id = (int)dr["id_profesion"];
                p.Descripcion = dr["descripcion"].ToString();

                lista.Add(p);

            }

            return lista;
        }

        // Traer un Tripulante






    }
}
