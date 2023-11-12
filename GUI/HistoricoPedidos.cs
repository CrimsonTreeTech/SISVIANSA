using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISVIANSA_ITI_2023.Logica;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class HistoricoPedidos : Form
    {
        private byte rol;
        private Pedido pedido;
        private Historico historico;

        // ----------------------- CONSTRUCTOR ----------------------
        public HistoricoPedidos(byte rol, Pedido pedido)
        {
            InitializeComponent();
            this.rol = rol;
            this.pedido = pedido;
            historico = new Historico(rol);
            pedido.Historico = historico.obtenerHistoricosDePedido(pedido.NroPedido);
            this.Text = "Histórico de pedido";
        }


        // ---------------------- METODOS AUXILIARES ---------------------------
        private void cargarDatosDePedido()
        {
            txtNroPedido.Text = pedido.NroPedido.ToString();
            txtIdCliente.Text = pedido.IdCliente.ToString();
            txtMenu.Text = pedido.IdMenu.ToString();
            txtZona.Text = pedido.Zona.ToString();
            txtFechaRealizado.Text = pedido.FechaRealizado.ToString();
        }

        private void cargarGrilla()
        {
            dgvHistorico.Rows.Clear();

            foreach (Historico h in pedido.Historico)
            {
                dgvHistorico.Rows.Add(h.Estado, h.FechaInicio, h.FechaAct);
            }
        }


        // --------------------- METODOS WIDGETS ---------------------------
        private void HistoricoPedidos_Load(object sender, EventArgs e)
        {
            cargarDatosDePedido();
            cargarGrilla();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (rol == 3) // Administrativo
            {
                MenuAdministrativo menu = new MenuAdministrativo(rol);
                menu.Show(Owner);
            }
            if (rol == 4) // Atencion al cliente
            {
                MenuAtencionCliente menu = new MenuAtencionCliente(rol);
                menu.Show(Owner);
            }
            if (rol == 6) // Informatico
            {
                AdministrarMenu menu = new AdministrarMenu(rol);
                menu.Show(Owner);
            }

            Close();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            ListarPedidos listarPedidos = new ListarPedidos(rol);
            listarPedidos.Show(Owner);
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GestionarPedido gestionarPedido = new GestionarPedido(rol);
            gestionarPedido.Show(Owner);
            Close();
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            SeguimientoPedido seguimiento = new SeguimientoPedido(rol, pedido);
            seguimiento.Show(Owner);
            Close();
        }

    }
}
