using Aerolínea.Datos;
using Aerolínea.Datos.DAOs;
using Aerolínea.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolínea.Presentacion
{
    public partial class FrmTripulantes : Form
    {
        TripulanteDao tDao = new TripulanteDao();
        public FrmTripulantes()
        {
            InitializeComponent();
        }

        private void cmbProfesion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmTripulantes_Load(object sender, EventArgs e)
        {
            CargarComboProfesiones();
            CargarComboIdiomas();

        }

        private void CargarComboIdiomas()
        {
            List<Idioma> listaIdiomas = tDao.TraerIdiomas();

            cmbIdioma.DataSource = listaIdiomas;

            cmbIdioma.ValueMember = "id";
            cmbIdioma.DisplayMember = "descripcion";

            cmbIdioma.SelectedIndex = -1;

        }

        private void CargarComboProfesiones()
        {
            List<Profesion> listaProfesiones = tDao.TraerProfesiones();

            cmbProfesion.DataSource = listaProfesiones;

            cmbProfesion.ValueMember = "id";
            cmbProfesion.DisplayMember = "descripcion";

            cmbProfesion.SelectedIndex = -1;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Filtro f = new Filtro();
            f.Nombre = txtNombre.Text;
            if (cmbProfesion.SelectedValue != null) f.Profesion = (int)cmbProfesion.SelectedValue;


            List<Tripulante> listaTripulantes = tDao.TraerTripulantes(f);

            dgvTripulantes.DataSource = listaTripulantes;
        }
    }
}
