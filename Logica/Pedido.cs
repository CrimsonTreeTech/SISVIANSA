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
        byte rol;
        int nroPedido, idMenu, idCliente, cantidad;
        string fechaRealizado, estado;
        PedidoBD pedidoBD;

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


        // --------------------------- CONSULTAS --------------------------------
        public List<Pedido> listarPedidosOrdenados(string columna, string orden)
        {
            return pedidoBD.listarPedidosOrdenados(columna, orden);
        }

        public List<Pedido> listarPedidosOrdenadosYFiltrados(string colFiltro, object valFiltro, string colOrden, string valOrden)
        {
            return pedidoBD.listarPedidosOrdenadosYFiltrados(colFiltro, valFiltro, colOrden, valOrden);
        }

    }
}
