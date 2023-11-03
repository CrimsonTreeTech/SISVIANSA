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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SISVIANSA_ITI_2023.Persistencia
{
    public class PedidoBD
    {
        private string cadenaConexion;

        private byte rol;
        private string consulta;
        private int filasAfectadas, nroPedido;
        private Pedido pedido;
        private Historico historico;
        private List<Pedido> pedidos;
        private List<Historico> historicos;
        private Singleton bd;

        // --------------------------- METODOS DE INICIO -----------------------------------
        public PedidoBD(byte rol)
        {
            this.rol = rol;
            bd = Singleton.RecuperarInstancia();
        }


        // ---------------------------- ABM ----------------------------------
        public bool ingresarPedido(Pedido pedido)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(this.rol))
                    {
                        consulta  = "INSERT INTO pide (id_menu, id_cliente, id_zona, fecha_realizado, cantidad) ";
                        consulta += "VALUES (@idMenu, @idCliente, @idZona, CURRENT_DATE(), @cantidad);";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idMenu", pedido.IdMenu);
                            cmd.Parameters.AddWithValue("@idCliente", pedido.IdCliente);
                            cmd.Parameters.AddWithValue("@idZona", pedido.Zona);
                            cmd.Parameters.AddWithValue("@cantidad", pedido.Cantidad);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error PedidoBD #ingresarPedido: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }


        public bool ingresarEstadoPedido(int idPedido, int idEstado)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "INSERT INTO pasa (nro_pedido, id_estado, fecha_ini) ";
                        consulta += "VALUES (@nroPedido, @idEstado, CURRENT_DATE()); ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@nroPedido", idPedido);
                            cmd.Parameters.AddWithValue("@idEstado", idEstado);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error PedidoBD #ingresarEstadoPedido: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }




        // ----------------------- CONSULTAS ---------------------------
        public int obtenerNroPedido(Pedido pedido)
        {
            nroPedido = -1;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT MAX(nro_pedido) AS nro FROM pide;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    nroPedido = reader.GetInt32("nro");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error PedidoBD #obtenerNroPedido: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return nroPedido;
        }

        public Pedido filtrarPedidoPorId(int id)
        {
            pedido = new Pedido(rol);

            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta += "SELECT p.nro_pedido, p.id_menu, p.id_cliente, c.nombre, p.id_zona,  ";
                        consulta += "p.fecha_realizado, p.cantidad, c.calle, c.esq, c.nro_puerta, e.nombre AS estado ";
                        consulta += "FROM pide p ";
                        consulta += "JOIN clientes c ON p.id_cliente = c.id_cliente ";
                        consulta += "JOIN pasa pa ON pa.nro_pedido = p.nro_pedido ";
                        consulta += "JOIN estado e ON pa.id_estado = e.id_estado ";
                        consulta += "WHERE p.nro_pedido = 5 AND pa.fecha_act IS NULL; ";


                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", id);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    pedido.NroPedido = reader.GetInt32("nro_pedido");
                                    pedido.IdMenu = reader.GetInt32("id_menu");
                                    pedido.IdCliente = reader.GetInt32("id_cliente");
                                    pedido.Cliente = reader.GetString("nombre");
                                    pedido.Zona = reader.GetInt32("id_zona");
                                    pedido.FechaRealizado = reader.GetDateTime("fecha_realizado").ToString("yyyy-mm-dd");
                                    pedido.Cantidad = reader.GetInt32("cantidad");
                                    pedido.Calle = reader.GetString("calle");
                                    pedido.Esq = reader.GetString("esq");
                                    pedido.NroPuerta = reader.GetInt32("nro_puerta");
                                    pedido.Estado = reader.GetString("estado");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error PedidoBD #filtrarPedidoPorId: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return pedido;
        }

        public List<Pedido> listarTodosLosPedidos()
        {
            pedidos = new List<Pedido>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT p.nro_pedido, p.id_menu, c.nombre, p.fecha_realizado, p.cantidad, e.nombre AS estado,  p.id_zona, c.calle, c.esq, c.nro_puerta ";
                        consulta += "FROM pide p ";
                        consulta += "JOIN clientes c ON c.id_cliente = p.id_cliente ";
                        consulta += "JOIN pasa ON pasa.nro_pedido = p.nro_pedido ";
                        consulta += "JOIN estado e ON pasa.id_estado = e.id_estado ";
                        consulta += "WHERE pasa.fecha_act IS NULL ";
                        consulta += "ORDER BY p.nro_pedido DESC; ";

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
                                        Calle = reader.GetString("calle"),
                                        Esq = reader.GetString("esq"),
                                        NroPuerta = reader.GetInt32("nro_puerta")
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
                        consulta  = "SELECT p.nro_pedido, p.id_menu, c.nombre, p.fecha_realizado, p.cantidad, e.nombre AS estado,  p.id_zona, c.calle, c.esq, c.nro_puerta ";
                        consulta += "FROM pide p ";
                        consulta += "JOIN clientes c ON c.id_cliente = p.id_cliente ";
                        consulta += "JOIN pasa ON pasa.nro_pedido = p.nro_pedido ";
                        consulta += "JOIN estado e ON pasa.id_estado = e.id_estado ";
                        consulta += "WHERE pasa.fecha_act IS NULL ";
                        consulta += "AND p.nro_pedido = @valFiltro ";
                        consulta += "ORDER BY p.nro_pedido DESC; ";

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
                                        Calle = reader.GetString("calle"),
                                        Esq = reader.GetString("esq"),
                                        NroPuerta = reader.GetInt32("nro_puerta")
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
                        consulta = "SELECT p.nro_pedido, c.nombre, p.id_menu, p.fecha_realizado, p.cantidad, e.nombre AS estado,  p.id_zona, c.calle, c.esq, c.nro_puerta ";
                        consulta += "FROM pide p ";
                        consulta += "JOIN clientes c ON c.id_cliente = p.id_cliente ";
                        consulta += "JOIN pasa ON pasa.nro_pedido = p.nro_pedido ";
                        consulta += "JOIN estado e ON pasa.id_estado = e.id_estado ";
                        consulta += "WHERE pasa.fecha_act IS NULL ";
                        consulta += "AND c.nombre LIKE @valFiltro ";
                        consulta += "ORDER BY p.nro_pedido DESC; ";

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
                                        Calle = reader.GetString("calle"),
                                        Esq = reader.GetString("esq"),
                                        NroPuerta = reader.GetInt32("nro_puerta")
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
                        consulta = "SELECT p.nro_pedido, c.nombre, p.id_menu, p.fecha_realizado, p.cantidad, e.nombre AS estado,  p.id_zona, c.calle, c.esq, c.nro_puerta ";
                        consulta += "FROM pide p ";
                        consulta += "JOIN clientes c ON c.id_cliente = p.id_cliente ";
                        consulta += "JOIN pasa ON pasa.nro_pedido = p.nro_pedido ";
                        consulta += "JOIN estado e ON pasa.id_estado = e.id_estado ";
                        consulta += "WHERE pasa.fecha_act IS NULL ";
                        consulta += "AND e.nombre = @valFiltro ";
                        consulta += "ORDER BY p.nro_pedido DESC; ";

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
                                        Calle = reader.GetString("calle"),
                                        Esq = reader.GetString("esq"),
                                        NroPuerta = reader.GetInt32("nro_puerta")
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
                        consulta  = "SELECT p.nro_pedido, p.id_menu, c.nombre, p.fecha_realizado, p.cantidad, e.nombre AS estado,  p.id_zona, c.calle, c.esq, c.nro_puerta ";
                        consulta += "FROM pide p ";
                        consulta += "JOIN clientes c ON c.id_cliente = p.id_cliente ";
                        consulta += "JOIN pasa ON pasa.nro_pedido = p.nro_pedido ";
                        consulta += "JOIN estado e ON pasa.id_estado = e.id_estado ";
                        consulta += "WHERE pasa.fecha_act IS NULL ";
                        consulta += "AND p.id_zona = @valFiltro ";
                        consulta += "ORDER BY p.nro_pedido DESC; ";

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
                                        Calle = reader.GetString("calle"),
                                        Esq = reader.GetString("esq"),
                                        NroPuerta = reader.GetInt32("nro_puerta")
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

        public List<Historico> buscarHistoricoDePedido(int idPedido)
        {
            historicos = new List<Historico>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT p.nro_pedido, e.nombre, p.fecha_act, p.fecha_ini ";
                        consulta += "FROM pasa p ";
                        consulta += "JOIN estado e ON p.id_estado = e.id_estado ";
                        consulta += "WHERE nro_pedido = @idPedido; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idPedido", idPedido);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    historico = new Historico(rol)
                                    {
                                        NroPedido = reader.GetInt32("nro_pedido"),
                                        Estado = reader.GetString("nombre"),
                                        FechaInicio = reader.GetDateTime("fecha_ini").ToString("yyyy-mm-dd")
                                    };

                                    if (!reader.IsDBNull(reader.GetOrdinal("fecha_act")))
                                        historico.FechaAct = reader.GetDateTime("fecha_act").ToString("yyyy-mm-dd");
                                    else
                                        historico.FechaAct = "Actualmente";
                                    historicos.Add(historico);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error PedidoBD #buscarHistoricoDePedido: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return historicos;
        }

    }
}
