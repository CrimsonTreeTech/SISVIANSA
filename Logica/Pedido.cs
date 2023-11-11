using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Persistencia;

namespace SISVIANSA_ITI_2023.Logica
{
    public class Pedido
    {
        private byte rol;
        private int nroPedido, idMenu, cantidad, zona, valFiltroInt, nroPuerta, idCliente;
        private double precioTotal;
        private string cliente,fechaRealizado, estado, calle, esq;
        private bool pedidoIngresado, pedidoActualizado;
        private Pedido pedido;
        private List<Pedido> listaPedidos;
        private List<Historico> historico;
        private PedidoBD pedidoBD;

        // ----------------- CONSTRUCTOR --------------------

        public Pedido(byte rol)
        {
            this.rol = rol;
            pedidoBD = new PedidoBD(rol);
        }


        // --------------- GETTERS Y SETTERS --------------------
        public int NroPedido
        {
            get { return nroPedido; }
            set { nroPedido = value; }
        }

        public int IdMenu
        {
            get { return idMenu; }
            set { idMenu = value; }
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string FechaRealizado
        {
            get { return fechaRealizado; }
            set { fechaRealizado = value; }
        }

        public int Zona
        {
            get { return zona; }
            set { zona = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public string Esq
        {
            get { return esq; }
            set { esq = value; }
        }

        public int NroPuerta
        {
            get { return nroPuerta; }
            set { nroPuerta = value; }
        }

        public double PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }

        public List<Historico> Historico
        {
            get { return historico; }
            set { historico = value; }
        }

        // ------------------------------ ABM ----------------------------------

        public bool ingresar()
        {
            pedidoIngresado = pedidoBD.ingresarPedido(this);
            nroPedido = pedidoBD.obtenerNroPedido(this);
            pedidoActualizado = pedidoBD.ingresarEstadoPedido(nroPedido, 1);
            return pedidoIngresado && pedidoActualizado;
        }


        // --------------------------- CONSULTAS --------------------------------
        public List<Pedido> listarPedidosFiltrados(string colFiltro, string valFiltro)
        {
            listaPedidos = new List<Pedido>();

            if (colFiltro.Equals("todo"))
            {
                listaPedidos = pedidoBD.listarTodosLosPedidos();
            }

            else if (colFiltro.Equals("nro_pedido"))
            {
                try
                {
                    valFiltroInt = Convert.ToInt32(valFiltro);
                    listaPedidos = pedidoBD.filtrarPorNro(valFiltroInt);
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se selecciono un valor de filtro correcto.", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            
            else if (colFiltro.Equals("cliente"))
            {
                listaPedidos = pedidoBD.filtrarPorCliente(valFiltro);
            }

            else if (colFiltro.Equals("estado"))
            {
                listaPedidos = pedidoBD.filtrarPorEstado(valFiltro);
            }
            
            else if (colFiltro.Equals("zona"))
            {
                valFiltroInt = Convert.ToInt32(valFiltro);
                listaPedidos = pedidoBD.filtrarPorZona(valFiltroInt);
            }


            return listaPedidos;
        }

        public Pedido cargarDatosPedido(int id)
        {
            pedido = pedidoBD.filtrarPedidoPorId(id);
            pedido.Historico = pedidoBD.buscarHistoricoDePedido(id);

            return pedidoBD.filtrarPedidoPorId(id);
        }


    }
}
