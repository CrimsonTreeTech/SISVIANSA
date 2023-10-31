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
    public partial class MenuInformatico : Form
    {
        private byte rol;

        // -------------- CONSTRUCTOR ----------------
        public MenuInformatico(byte rol)
        {
            this.rol = rol;
            InitializeComponent();
        }


        // ------------- METODOS WIDGETS -------------
        private void btnListarPersonal_Click(object sender, EventArgs e)
        {
            ListarUsuario listarUsuario = new ListarUsuario(rol);
            listarUsuario.Show(this);
            Hide();
        }

        private void btnListarSucursales_Click(object sender, EventArgs e)
        {
            GestionarUsuario gestionarUsuario = new GestionarUsuario(rol);
            gestionarUsuario.Show(this);
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnAdministrarMenu_Click(object sender, EventArgs e)
        {
            AdministrarMenu administrarMenu = new AdministrarMenu(rol); // Cambiar que seleccione surcursal
            administrarMenu.Show(Owner);
            Close();
        }
    }
}
