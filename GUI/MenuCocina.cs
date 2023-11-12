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
    public partial class MenuCocina : Form
    {
        private byte rol;
        private int idSucursal;

        public MenuCocina(byte rol, int idSucursal)
        {
            this.rol = rol;
            this.idSucursal = idSucursal;
            InitializeComponent();
        }

        private void btnProduccionDiaria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en mantenimiento", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*
            ProduccionDiaria produccionDiaria = new ProduccionDiaria(rol, idSucursal, true);
            produccionDiaria.Show(this);
            Hide();
            */
        }

        private void btnIngresarMenu_Click(object sender, EventArgs e)
        {
            GestionarMenu menu = new GestionarMenu(rol);
            menu.Show(this);
            Hide();
        }

        private void btnIngresarComida_Click(object sender, EventArgs e)
        {
            GestionarComida ingresarComida = new GestionarComida(rol);
            ingresarComida.Show(this);
            Hide();
        }

        private void btnIngresarDieta_Click(object sender, EventArgs e)
        {
            GestionarDieta ingresarDieta = new GestionarDieta(rol);
            ingresarDieta.Show(this);
            Hide();
        }

        private void btnListarPedidos_Click(object sender, EventArgs e)
        {
            ListarPedidos listarPedido = new ListarPedidos(rol);
            listarPedido.Show(this);
            Hide();
        }

        private void btnListarMenu_Click(object sender, EventArgs e)
        {
            ListarMenus listarMenus = new ListarMenus(rol);
            listarMenus.Show(this);
            Hide();
        }

        private void btnListarComida_Click(object sender, EventArgs e)
        {
            ListarComidas listarComidas = new ListarComidas(rol);
            listarComidas.Show(this);
            Hide();
        }

        private void btnListarDietas_Click(object sender, EventArgs e)
        {
            ListarDietas listarDietas = new ListarDietas(rol);
            listarDietas.Show(this);
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (rol == 2) // Nro de rol de cocina
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

        private void btnListarViandas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en mantenimiento", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*
            ListarViandas listarViandas = new ListarViandas(rol, idSucursal);
            listarViandas.Show(this);
            Hide();
            */
        }
    }
}
