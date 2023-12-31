﻿using System;
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
    public partial class MenuAdministrativo : Form
    {
        private byte rol;
        public MenuAdministrativo(byte rol)
        {
            this.rol = rol;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (rol == 3) // Nro de rol de admin
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

        private void btnIngresarClienteComun_Click(object sender, EventArgs e)
        {
            GestionarCliente ingresarCliente = new GestionarCliente(rol);
            ingresarCliente.Show(this);
            this.Hide();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            ListarCliente listarCliente = new ListarCliente(rol);
            listarCliente.Show(this);
            Hide();
        }

        private void btnIngresarPedido_Click(object sender, EventArgs e)
        {
            GestionarPedido ingresarPedido = new GestionarPedido(rol);
            ingresarPedido.Show(this);
            Hide();
        }

        private void btnListarPedidos_Click(object sender, EventArgs e)
        {
            ListarPedidos listarPedido = new ListarPedidos(rol);
            listarPedido.Show(this);
            Hide();
        }
    }
}
