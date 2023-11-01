using SISVIANSA_ITI_2023.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVIANSA_ITI_2023.Logica
{
    public class Historico
    {
        byte rol;
        private int nroPedido;
        private string estado, fechaInicio, fechaAct;
        private PedidoBD pedidoBD;

        // ------------------ CONSTRUCTOR -------------------------
        public Historico(byte rol)
        {
            this.rol = rol;
            pedidoBD = new PedidoBD(rol);
        }

        // --------------- GETTERS Y SETTERS -------------------
        public int NroPedido
        {
            get { return nroPedido; }
            set { nroPedido = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public string FechaAct
        {
            get { return fechaAct; }
            set { fechaAct = value; }
        }


        // ------------------ CONSULTAS --------------------
        public List<Historico> obtenerHistoricosDePedido(int idPedido)
        {
            return pedidoBD.buscarHistoricoDePedido(idPedido);
        }


    }
}
