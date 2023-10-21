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
        public List<Pedido> listarTodosLosPedidos()
        {
            pedidos = new List<Pedido>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT p.nro_pedido, p.id_menu, c.nombre, p.fecha_realizado, p.cantidad, e.nombre AS estado,  p.id_zona, c.dir ";
                        consulta += "FROM pide p ";
                        consulta += "JOIN clientes c ON c.id_cliente = p.id_cliente ";
                        consulta += "JOIN pasa ON pasa.nro_pedido = p.nro_pedido ";
                        consulta += "JOIN estado e ON pasa.id_estado = e.id_estado ";
                        consulta += "WHERE pasa.fecha_act IS NULL ";
                        consulta += "ORDER BY p.nro_pedido ASC; ";

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
                                        Cliente = reader.GetString("nombre"),
                                        FechaRealizado = reader.GetDateTime("fecha_realizado").ToString("yyyy-mm-dd"),
                                        Cantidad = reader.GetInt32("cantidad"),
                                        Estado = reader.GetString("estado"),
                                        Zona = reader.GetInt32("id_zona"),
                                        Dir = reader.GetString("dir")
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

        public List<Pedido> filtrarPorNro(int valFiltro)
        {
            pedidos = new List<Pedido>();
            try
            {
                using(bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT p.nro_pedido, c.nombre, p.id_menu, p.fecha_realizado, p.cantidad, e.nombre AS estado,  p.id_zona, c.dir ";
                        consulta += "FROM pide p ";
                        consulta += "JOIN clientes c ON c.id_cliente = p.id_cliente ";
                        consulta += "JOIN pasa ON pasa.nro_pedido = p.nro_pedido ";
                        consulta += "JOIN estado e ON pasa.id_estado = e.id_estado ";
                        consulta += "WHERE pasa.fecha_act IS NULL ";
                        consulta += "AND p.nro_pedido = @valFiltro ";
                        consulta += "ORDER BY p.nro_pedido ASC; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@valFiltro", valFiltro);
                            
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    pedido = new Pedido(this.rol)
                                    {
                                        NroPedido = reader.GetInt32("nro_pedido"),
                                        IdMenu = reader.GetInt32("id_menu"),
                                        Cliente = reader.GetString("nombre"),
                                        FechaRealizado = reader.GetDateTime("fecha_realizado").ToString("yyyy-mm-dd"),
                                        Cantidad = reader.GetInt32("cantidad"),
                                        Estado = reader.GetString("estado"),
                                        Zona = reader.GetInt32("id_zona"),
                                        Dir = reader.GetString("dir")
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

        public List<Pedido> filtrarPorCliente(string valFiltro)
        {
            pedidos = new List<Pedido>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT p.nro_pedido, c.nombre, p.id_menu, p.fecha_realizado, p.cantidad, e.nombre AS estado,  p.id_zona, c.dir ";
                        consulta += "FROM pide p ";
                        consulta += "JOIN clientes c ON c.id_cliente = p.id_cliente ";
                        consulta += "JOIN pasa ON pasa.nro_pedido = p.nro_pedido ";
                        consulta += "JOIN estado e ON pasa.id_estado = e.id_estado ";
                        consulta += "WHERE pasa.fecha_act IS NULL ";
                        consulta += "AND c.nombre LIKE @valFiltro ";
                        consulta += "ORDER BY p.nro_pedido ASC; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@valFiltro", "%" + valFiltro + "%");

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    pedido = new Pedido(this.rol)
                                    {
                                        NroPedido = reader.GetInt32("nro_pedido"),
                                        IdMenu = reader.GetInt32("id_menu"),
                                        Cliente = reader.GetString("nombre"),
                                        FechaRealizado = reader.GetDateTime("fecha_realizado").ToString("yyyy-mm-dd"),
                                        Cantidad = reader.GetInt32("cantidad"),
                                        Estado = reader.GetString("estado"),
                                        Zona = reader.GetInt32("id_zona"),
                                        Dir = reader.GetString("dir")
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

        public List<Pedido> filtrarPorEstado(string valFiltro)
        {
            pedidos = new List<Pedido>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT p.nro_pedido, c.nombre, p.id_menu, p.fecha_realizado, p.cantidad, e.nombre AS estado,  p.id_zona, c.dir ";
                        consulta += "FROM pide p ";
                        consulta += "JOIN clientes c ON c.id_cliente = p.id_cliente ";
                        consulta += "JOIN pasa ON pasa.nro_pedido = p.nro_pedido ";
                        consulta += "JOIN estado e ON pasa.id_estado = e.id_estado ";
                        consulta += "WHERE pasa.fecha_act IS NULL ";
                        consulta += "AND e.nombre = @valFiltro ";
                        consulta += "ORDER BY p.nro_pedido ASC; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@valFiltro", valFiltro);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    pedido = new Pedido(this.rol)
                                    {
                                        NroPedido = reader.GetInt32("nro_pedido"),
                                        IdMenu = reader.GetInt32("id_menu"),
                                        Cliente = reader.GetString("nombre"),
                                        FechaRealizado = reader.GetDateTime("fecha_realizado").ToString("yyyy-mm-dd"),
                                        Cantidad = reader.GetInt32("cantidad"),
                                        Estado = reader.GetString("estado"),
                                        Zona = reader.GetInt32("id_zona"),
                                        Dir = reader.GetString("dir")
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

        public List<Pedido> filtrarPorZona(int valFiltro)
        {
            pedidos = new List<Pedido>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT p.nro_pedido, c.nombre, p.id_menu, p.fecha_realizado, p.cantidad, e.nombre AS estado,  p.id_zona, c.dir ";
                        consulta += "FROM pide p ";
                        consulta += "JOIN clientes c ON c.id_cliente = p.id_cliente ";
                        consulta += "JOIN pasa ON pasa.nro_pedido = p.nro_pedido ";
                        consulta += "JOIN estado e ON pasa.id_estado = e.id_estado ";
                        consulta += "WHERE pasa.fecha_act IS NULL ";
                        consulta += "AND p.id_zona = @valFiltro ";
                        consulta += "ORDER BY p.nro_pedido ASC; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@valFiltro", valFiltro);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    pedido = new Pedido(this.rol)
                                    {
                                        NroPedido = reader.GetInt32("nro_pedido"),
                                        IdMenu = reader.GetInt32("id_menu"),
                                        Cliente = reader.GetString("nombre"),
                                        FechaRealizado = reader.GetDateTime("fecha_realizado").ToString("yyyy-mm-dd"),
                                        Cantidad = reader.GetInt32("cantidad"),
                                        Estado = reader.GetString("estado"),
                                        Zona = reader.GetInt32("id_zona"),
                                        Dir = reader.GetString("dir")
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
