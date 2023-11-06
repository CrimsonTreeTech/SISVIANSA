using SISVIANSA_ITI_2023.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventana3;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class MenuGerente : Form
    {
        private byte rol;

        // ------------ CONSTRUCTOR -------------
        public MenuGerente(byte rol)
        {
            this.rol = rol;
            InitializeComponent();
        }


        // ----------- METODOS WIDGETS -------------
        private void btnListarVehiculo_Click(object sender, EventArgs e)
        {
            ListarVehiculo listarVehiculo = new ListarVehiculo(rol);
            listarVehiculo.Show(this);
            Hide();
        }

        private void btnListarMenu_Click(object sender, EventArgs e)
        {
            ListarMenus listarMenus = new ListarMenus(rol);
            listarMenus.Show(this);
            Hide();
        }

        private void btnListarZona_Click(object sender, EventArgs e)
        {
            ListarZonas listarZonas = new ListarZonas(rol);
            listarZonas.Show(this);
            Hide();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            ListarCliente listarCliente = new ListarCliente(rol);
            listarCliente.Show(this);
            Hide();
        }

        private void btnListarPedidos_Click(object sender, EventArgs e)
        {
            ListarPedidos listarPedido = new ListarPedidos(rol);
            listarPedido.Show(this);
            Hide();
        }

        private void btnListarSucursales_Click(object sender, EventArgs e)
        {
            ListarSucursales listarSucursales = new ListarSucursales(rol);
            listarSucursales.Show(this);
            Hide();
        }

        private void btnListarDietas_Click(object sender, EventArgs e)
        {
            ListarDietas listarDietas = new ListarDietas(rol);
            listarDietas.Show(this);
            Hide();
        }

        private void btnListarComida_Click(object sender, EventArgs e)
        {
            ListarComidas listarComidas = new ListarComidas(rol);
            listarComidas.Show(this);
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (rol == 1) // Nro de rol de gerente
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

        private void btnIngresarSucursal_Click(object sender, EventArgs e)
        {
            GestionarSucursal ingresarSucursal = new GestionarSucursal(rol);
            ingresarSucursal.Show(this);
            Hide();
        }

        private void btnListarViandas_Click(object sender, EventArgs e)
        {
            ListarViandas listarViandas = new ListarViandas(rol, 0);
            listarViandas.Show(this);
            Hide();
        }
    }
}
