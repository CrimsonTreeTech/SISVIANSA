using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Logica;
using System.IO.Pipelines;
using Org.BouncyCastle.Asn1.X509;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Data;
using System.Collections;
using MySqlConnector;

namespace SISVIANSA_ITI_2023.Persistencia
{
    internal class PedidoBD
    {
        private string cadenaConexion;
        
        private byte rol;
        private string consulta;
        private int filasAfectadas;
        private Pedido pedido;
        private List<Pedido> pedidos;
        private Singleton bd;

        // --------------------------- METODOS DE INICIO -----------------------------------
        public PedidoBD(byte rol)
        {
            this.rol = rol;
        }


        // ----------------------- CONSULTAS ---------------------------
        public List<Pedido> listarPedidosOrdenados(string colOrden, string valOrden)
        {
            pedidos = new List<Pedido>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT pide.nro_pedido, pide.id_menu, pide.id_cliente, pide.cantidad, pide.fecha_realizado, estado.nombre " +
                                            "FROM pide " +
                                            "JOIN pasa ON pide.nro_pedido = pasa.nro_pedido " +
                                            "JOIN estado ON pasa.id_estado = estado.id_estado " +
                                            "WHERE pasa.fecha_act = (SELECT MAX(fecha_act) FROM pasa WHERE pasa.nro_pedido = pide.nro_pedido) ";

                        consulta += $"ORDER BY {colOrden} {valOrden};";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    pedido = new Pedido(rol)
                                    {
                                        NroPedido = reader.GetInt32("nro_pedido"),
                                        IdMenu = reader.GetInt32("id_menu"),
                                        IdCliente = reader.GetInt32("id_cliente"),
                                        Cantidad = reader.GetInt32("cantidad"),
                                        Estado = reader.GetString("nombre"),
                                        FechaRealizado = reader.GetDateTime("fecha_realizado").ToString("yyyy-mm-dd")
                                    };
                                    pedidos.Add(pedido);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error PedidoBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return pedidos;
        }

        public List<Pedido> listarPedidosOrdenadosYFiltrados(string colFiltro, object valFiltro, string colOrden, string valOrden)
        {
            pedidos = new List<Pedido>();
            try
            {
                using(bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT pide.nro_pedido, pide.id_menu, pide.id_cliente, pide.cantidad, pide.fecha_realizado, estado.nombre " +
                                    "FROM pide " +
                                    "JOIN pasa ON pide.nro_pedido = pasa.nro_pedido " +
                                    "JOIN estado ON pasa.id_estado = estado.id_estado " +
                                    $"WHERE {colFiltro} = @valFiltro AND pasa.fecha_act = (SELECT MAX(fecha_act) FROM pasa WHERE pasa.nro_pedido = pide.nro_pedido) " +
                                    $"ORDER BY {colOrden} {valOrden};";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    pedido = new Pedido(this.rol)
                                    {
                                        NroPedido = reader.GetInt32("nro_pedido"),
                                        IdMenu = reader.GetInt32("id_menu"),
                                        IdCliente = reader.GetInt32("id_cliente"),
                                        Cantidad = reader.GetInt32("cantidad"),
                                        Estado = reader.GetString("nombre"),
                                        FechaRealizado = reader.GetString("fecha_realizado")
                                    };
                                    pedidos.Add(pedido);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error PedidoBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return pedidos;
        }


    }
}
