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
    public partial class SeguimientoPedido : Form
    {
        private byte rol;
        private Pedido pedido;
        private Historico historico;

        // ----------------- CONSTRUCTOR -----------------
        public SeguimientoPedido(byte rol, Pedido pedido)
        {
            InitializeComponent();
            this.rol = rol;
            this.pedido = pedido;
            historico = new Historico(rol);
            pedido.Historico = historico.obtenerHistoricosDePedido(pedido.NroPedido);

        }

        // ----------------- METODOS AUXILIARES -----------------

        private void cargarDatos()
        {
            txtNroPedido.Text = pedido.NroPedido.ToString();
            txtNroCliente.Text = pedido.IdCliente.ToString();
            txtNombre.Text = pedido.Cliente;
            txtMenu.Text = pedido.IdMenu.ToString();
            txtCantidad.Text = pedido.Cantidad.ToString();
            txtPrecio.Text = pedido.PrecioTotal.ToString();
        }

        // ------------------ METODOS WIDGETS -----------------------
        private void SeguimientoPedido_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        // Botones
        private void btnListado_Click(object sender, EventArgs e)
        {
            ListarPedidos listarPedidos = new ListarPedidos(rol);
            listarPedidos.Show(Owner);
            Close();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            HistoricoPedidos historicoPedidos = new HistoricoPedidos(rol, pedido);
            historicoPedidos.Show(Owner);
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GestionarPedido gestionarPedido = new GestionarPedido(rol, pedido);
            gestionarPedido.Show(Owner);
            Close();
        }

    }
}
