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
    public partial class MenuAtencionCliente : Form
    {
        private byte rol;
        public MenuAtencionCliente(byte rol)
        {
            this.rol = rol;
            InitializeComponent();
        }

        private void btnIngresarClienteComun_Click(object sender, EventArgs e)
        {
            GestionarCliente ingresarCliente = new GestionarCliente(rol);
            ingresarCliente.Show(this);
            this.Hide();
        }

        private void btnIngresarClienteEmpresa_Click(object sender, EventArgs e)
        {
            GestionarClienteEmpresa ingresarClienteEmpresa = new GestionarClienteEmpresa(rol);
            ingresarClienteEmpresa.Show(this);
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

        private void btnListarMenu_Click(object sender, EventArgs e)
        {
            ListarMenus listarMenus = new ListarMenus(rol);
            listarMenus.Show(this);
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (rol == 4) // Nro de rol de atencion al cliente
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
