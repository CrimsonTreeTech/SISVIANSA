using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class AdministrarMenu : Form

    {
        byte rol;

        // -------------------- CONSTRUCTOR -------------------------
        public AdministrarMenu(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
        }


        // -------------------- METODOS WIDGETS -------------------------
        private void btnRegresar_Click(object sender, EventArgs e)
        {

            MenuInformatico menuInformatico = new MenuInformatico(rol);
            menuInformatico.Show(Owner);
            Close();

        }

        private void btnGerencia_Click(object sender, EventArgs e)
        {
            MenuGerente menuGerente = new MenuGerente(rol);
            menuGerente.Show(Owner);
            Close();
        }

        private void btnCocina_Click(object sender, EventArgs e)
        {
            SeleccionarSucursal seleccionarSucursal = new SeleccionarSucursal(rol);
            seleccionarSucursal.Show(Owner);
            Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MenuAdministrativo menuAdministrativo = new MenuAdministrativo(rol);
            menuAdministrativo.Show(Owner);
            Close();
        }

        private void btnATC_Click(object sender, EventArgs e)
        {
            MenuAdministrativo menuAdministrativo = new MenuAdministrativo(rol);
            menuAdministrativo.Show(Owner);
            Close();
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            MenuTransporte menuTransporte = new MenuTransporte(rol);
            menuTransporte.Show(Owner);
            Close();
        }
    }
}

