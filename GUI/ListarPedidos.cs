using SISVIANSA_ITI_2023.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class ListarPedidos : Form
    {
        private byte rol;
        private string colFiltro, colOrden, valOrden; // col = columna, val = valor
        private object valFiltro;
        private Pedido pedido;
        private List<Pedido> listaPedidos;

        // --------------- METODOS AL INICIAR ---------------------
        public ListarPedidos(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            pedido = new Pedido(rol);
            colFiltro = "todo";
            colOrden = "nro_pedido";
            valOrden = "ASC";
            bloqueraFuncionalidadesSegunRol(rol);
        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1 || rol == 2 || rol == 4 || rol == 5)
                btnModificar.Enabled = false;
        }

        private void ListarPedidos_Load(object sender, EventArgs e)
        {
            reiniciarBusqueda();
            rbtnFiltrarTodo.Checked = true;
            rbtnOrdenarNroPedido.Checked = true;
            cboOrdenarNroPedido.Enabled = true;
            cboOrdenarNroPedido.SelectedIndex = 0;
            listaPedidos = pedido.listarPedidosOrdenados("nro_pedido", "ASC");
            cargarDatos(listaPedidos);
        }


        // ------------ METODOS AUXILIARES -----------------------------

        private void cargarDatos(List<Pedido> lista)
        {
            dgvPedidos.Rows.Clear();
            foreach (Pedido item in lista)
            {
                dgvPedidos.Rows.Add(item.NroPedido, item.IdMenu, item.IdCliente, item.FechaRealizado, item.Cantidad, item.Estado);
            }
        }

        private void reiniciarBusqueda()
        {
            reiniciarOrden();
            reiniciarFiltros();
            inhabilitarFiltros();
            inhabilitarOrden();
        }

        // Orden
        private void inhabilitarOrden()
        {
            cboOrdenarEstado.Enabled = false;
            cboOrdenarFecha.Enabled = false;
            cboOrdenarNroPedido.Enabled = false;
        }

        private void reiniciarOrden()
        {
            cboOrdenarEstado.SelectedItem = null;
            cboOrdenarFecha.SelectedItem = null;
            cboOrdenarNroPedido.SelectedItem = null;
        }

        // Filtros
        private void inhabilitarFiltros()
        {
            txtFiltrarNroPedido.Enabled = false;
            txtFiltrarIdCliente.Enabled = false;
            cboFiltrarEstado.Enabled = false;
        }

        private void reiniciarFiltros()
        {
            txtFiltrarNroPedido.Clear();
            txtFiltrarIdCliente.Clear();
            cboFiltrarEstado.SelectedItem = null;
        }



        // ------------------------ METODOS DE WIDGETS ------------------------------------

        // Botones
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GestionarPedido gestionarPedido = new GestionarPedido();
            gestionarPedido.Show(Owner);
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Pedido> lista = new List<Pedido>();

            if (colFiltro.Equals("todo"))
                lista = pedido.listarPedidosOrdenados(colOrden, valOrden);
            else
                lista = pedido.listarPedidosOrdenadosYFiltrados(colFiltro, valFiltro, colOrden, valOrden);

            cargarDatos(lista);

        }


        // Radiobuttons orden
        private void rbtnOrdenarNroPedido_Click(object sender, EventArgs e)
        {
            reiniciarOrden();
            inhabilitarOrden();
            rbtnOrdenarNroPedido.Checked = true;
            cboOrdenarNroPedido.Enabled = true;
            cboOrdenarNroPedido.SelectedIndex = 0;
            colOrden = "nro_pedido";
        }

        private void rbtnOrdenarFecha_Click(object sender, EventArgs e)
        {
            reiniciarOrden();
            inhabilitarOrden();
            rbtnOrdenarFecha.Checked = true;
            cboOrdenarFecha.Enabled = true;
            cboOrdenarFecha.SelectedIndex = 0;
            colOrden = "fecha_realizado";
        }

        private void rbtnOrdenarEstado_Click(object sender, EventArgs e)
        {
            reiniciarOrden();
            inhabilitarOrden();
            rbtnOrdenarEstado.Checked = true;
            cboOrdenarEstado.Enabled = true;
            cboOrdenarEstado.SelectedIndex = 0;
            colOrden = "estado.nombre";
        }


        // Radiobuttons filtros
        private void rbtnFiltrarNroPedido_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            inhabilitarFiltros();
            rbtnFiltrarNroPedido.Checked = true;
            txtFiltrarNroPedido.Enabled = true;
            colFiltro = "pide.nro_pedido";
        }

        private void rbtnFiltrarIdCliente_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            inhabilitarFiltros();
            rbtnFiltrarIdCliente.Checked = true;
            txtFiltrarIdCliente.Enabled = true;
            colFiltro = "pide.id_cliente";
        }

        private void rbtnFiltrarEstado_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            inhabilitarFiltros();
            rbtnFiltrarEstado.Checked = true;
            cboFiltrarEstado.Enabled = true;
            colFiltro = "estado.nombre";
        }

        private void rbtnFiltrarTodo_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            inhabilitarFiltros();
            rbtnFiltrarTodo.Checked = true;
            colFiltro = "todo";
        }


        // Combobox de orden
        private void cboOrdenarEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            valOrden = cboOrdenarEstado.Text;
        }

        private void cboOrdenarFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            valOrden = cboOrdenarFecha.Text;
        }

        private void cboOrdenarNroPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            valOrden = cboOrdenarNroPedido.Text;
        }


    }
}
