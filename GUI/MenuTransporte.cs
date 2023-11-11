using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventana3;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class MenuTransporte : Form
    {
        private byte rol;
        public MenuTransporte(byte rol)
        {
            this.rol = rol;
            InitializeComponent();
        }

        private void IngresarVehiculo_Click(object sender, EventArgs e)
        {
            GestionarVehiculo ingresarVehiculo = new GestionarVehiculo(rol);
            ingresarVehiculo.Show(this);
            Hide();
        }

        private void btnListarVehiculo_Click(object sender, EventArgs e)
        {
            ListarVehiculo listarVehiculo = new ListarVehiculo(rol);
            listarVehiculo.Show(this);
            Hide();
            
        }

        private void btnIngresarZona_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en mantenimiento", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*
            GestionarZona gestionarZona = new GestionarZona(rol);
            gestionarZona.Show(this);
            Hide();
            */
        }

        private void btnListarZona_Click(object sender, EventArgs e)
        {
            ListarZonas listarZonas = new ListarZonas(rol);
            listarZonas.Show(this);
            Hide();
        }

        private void btnListarPedidos_Click(object sender, EventArgs e)
        {
            ListarPedidos listarPedido = new ListarPedidos(rol);
            listarPedido.Show(this);
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (rol == 5) // Nro de rol de transporte
            {
                IniciarSesion iniciarSesion = new IniciarSesion();
                iniciarSesion.Show(Owner);
            }
            else if (rol == 6)
            {
                AdministrarMenu administrarMenu = new AdministrarMenu(rol);
                administrarMenu.Show(Owner);
            }
            Close();
        }
    }
}
