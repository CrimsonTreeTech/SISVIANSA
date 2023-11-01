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
        private string colFiltro, valFiltro;
        private int filaSeleccionada, idPedidoSeleccionado;
        private Pedido pedido;
        private Zona zona;
        private List<Pedido> listaPedidos;
        private List<Zona> listaZonas;

        // --------------- METODOS AL INICIAR ---------------------
        public ListarPedidos(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            pedido = new Pedido(rol);
            zona = new Zona(rol);
            colFiltro = "todo";
            bloqueraFuncionalidadesSegunRol(rol);
        }

        
        

        // ------------ METODOS AUXILIARES -----------------------------
        private void cargarDatos(List<Pedido> lista)
        {
            dgvPedidos.Rows.Clear();
            foreach (Pedido item in lista)
            {
                string dir = item.Calle + " " + item.NroPuerta.ToString() + " Esq. " + item.Esq;
                dgvPedidos.Rows.Add(item.NroPedido, item.IdMenu, item.Cliente, item.FechaRealizado, item.Cantidad, item.Estado, item.Zona, dir);
            }
        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1 || rol == 2 || rol == 4 || rol == 5)
                btnModificar.Enabled = false;
        }

        private Pedido obtenerPedidoSeleccionado()
        {
            filaSeleccionada =  dgvPedidos.CurrentCell.RowIndex;
            idPedidoSeleccionado = Convert.ToInt32(dgvPedidos.SelectedCells[1].Value);
            pedido = pedido.cargarDatosPedido(idPedidoSeleccionado);
            
            return pedido;
        }

        // Filtros
        private void inhabilitarFiltros()
        {
            txtNroPedido.Clear();
            txtCliente.Clear();
            cboEstado.SelectedItem = null;
            cboZona.SelectedItem = null;

            txtNroPedido.Enabled = false;
            txtCliente.Enabled = false;
            cboEstado.Enabled = false;
            cboZona.Enabled = false;
        }

        private string obtenerValFiltro()
        {
            if (rbtnTodo.Checked)
            {
                valFiltro = "";
            }

            else if (rbtnNroPedido.Checked)
            {
                valFiltro = txtNroPedido.Text;
            }

            else if (rbtnCliente.Checked)
            {
                valFiltro = txtCliente.Text;
            }

            else if (rbtnEstado.Checked)
            {
                valFiltro = cboEstado.Text;
            }

            else if (rbtnZona.Checked)
            {
                valFiltro = cboZona.Text;
            }

            return valFiltro;
        }

        private void cargarCboZona()
        {
            cboZona.Enabled = true;

            cboZona.Items.Clear();
            listaZonas = zona.todasLasZonas();
            foreach (Zona z in listaZonas)
            {
                cboZona.Items.Add(z.Id.ToString());
            }
            cboZona.SelectedIndex = 0;
        }

        // ------------------------ METODOS DE WIDGETS ------------------------------------
        private void ListarPedidos_Load(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            rbtnTodo.Checked = true;
            listaPedidos = pedido.listarPedidosFiltrados("todo", "");
            cargarDatos(listaPedidos);
        }


        // Botones
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            pedido = obtenerPedidoSeleccionado();
            GestionarPedido gestionarPedido = new GestionarPedido(rol, pedido);
            gestionarPedido.Show(Owner);
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Pedido> lista = new List<Pedido>();

            valFiltro = obtenerValFiltro();
            lista = pedido.listarPedidosFiltrados(colFiltro, valFiltro);

            cargarDatos(lista);

        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            pedido = obtenerPedidoSeleccionado();
            HistoricoPedidos historicoPedidos = new HistoricoPedidos(rol, pedido);
            historicoPedidos.Show(Owner);
            Close();
        }

        // Radiobuttons filtros
        private void rbtnNroPedido_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            txtNroPedido.Enabled = true;
            colFiltro = "nro_pedido";
        }

        private void rbtnCliente_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            txtCliente.Enabled = true;
            colFiltro = "cliente";
        }

        private void rbtnEstado_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            cboEstado.Enabled = true;
            cboEstado.SelectedIndex = 0;
            colFiltro = "estado";
        }

        private void rbtnTodo_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            colFiltro = "todo";
        }

        private void rbtnZona_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            cargarCboZona();
            colFiltro = "zona";
        }

    }
}
