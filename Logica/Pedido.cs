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
        private int nroPedido, idMenu, cantidad, zona, valFiltroInt, nroPuerta;
        private string cliente,fechaRealizado, estado, calle, esq;
        private List<Pedido> listaPedidos;
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
                valFiltroInt = Convert.ToInt32(valFiltro);
                listaPedidos = pedidoBD.filtrarPorNro(valFiltroInt);
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

    }
}
