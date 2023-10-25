﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Logica;
using MySqlConnector;

namespace SISVIANSA_ITI_2023.Persistencia
{
    public class ClientesBD
    {
        private byte rol;
        private string consulta, mail;
        private int filasAfectadas, tel;
        private Cliente cliente;
        private List<Cliente> listaClientes;
        private List<int> listaTelefonos;
        private List<string> listaMails;
        private Singleton bd;

        public ClientesBD (byte rol)
        {
            this.rol = rol;
        }

        // -------------- CREAR VISTA -------------------
        public bool crearVistaClientes()
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "CREATE VIEW clientes_unificado AS ";
                        consulta += "SELECT ce.id_cliente, 'Empresa' AS tipo_cliente, 'RUT' AS tipo_doc, ";
                        consulta += "rut AS nro_doc, nombre ";
                        consulta += "FROM cliente_empresa ce ";
                        consulta += "UNION ";
                        consulta += "SELECT cc.id_cliente, 'Particular' AS tipo_cliente, cc.tipo_doc, cc.doc AS nro_doc, ";
                        consulta += "CONCAT(cc.p_nom, ' ', cc.s_nom, ' ', cc.p_ape, ' ', cc.s_ape) AS nombre ";
                        consulta += "FROM cliente_comun cc; ";

                        consulta += "CREATE OR REPLACE VIEW clientes AS ";
                        consulta += "SELECT cu.id_cliente, cu.tipo_cliente, cu.tipo_doc, cu.nro_doc, ";
                        consulta += "cu.nombre, c.calle, c.nro_puerta, c.esq ";
                        consulta += "FROM clientes_unificado cu ";
                        consulta += "JOIN cliente c ON c.id_cliente = cu.id_cliente; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }

                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number != 1050)
                {
                    MessageBox.Show("ClientesBD #crearVistaClientes\n" + ex.Number.ToString() + ": " + ex.Message);
                }
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }


        // ------------------- CONSULTAS POR FILTROS --------------------------
        public List<Cliente> buscarTodosLosClientes()
        {
            listaClientes = new List<Cliente>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT c.id_cliente, c.tipo_doc, c.nro_doc, c.nombre, c.activo, c.autorizado, c.calle, c.nro_puerta, c.esq ";
                        consulta += "FROM clientes c;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    cliente = new Cliente(rol)
                                    {
                                        Id = reader.GetInt32("id_cliente"),
                                        TipoDoc = reader.GetString("tipo_doc"),
                                        Doc = reader.GetInt64("nro_doc"),
                                        NombreEmpresa = reader.GetString("nombre"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        Calle = reader.GetString("calle"),
                                        NroPuerta = reader.GetInt32("nro_puerta"),
                                        Esq = reader.GetString("esq")
                                    };
                                    listaClientes.Add(cliente);
                                }
                            }
                        }

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ClientesBD #buscarTodosLosClientes\n" + ex.Number.ToString() + ": " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return listaClientes;
        }


        public List<Cliente> buscarClientesPorNroDoc(long doc)
        {
            listaClientes = new List<Cliente>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT c.id_cliente, c.tipo_doc, c.nro_doc, c.nombre, c.activo, c.autorizado, c.calle, c.nro_puerta, c.esq ";
                        consulta += "FROM clientes c ";
                        consulta += "WHERE c.nro_doc = @doc;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@doc", doc);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    cliente = new Cliente(rol)
                                    {
                                        Id = reader.GetInt32("id_cliente"),
                                        TipoDoc = reader.GetString("tipo_doc"),
                                        Doc = reader.GetInt64("nro_doc"),
                                        NombreEmpresa = reader.GetString("nombre"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        Calle = reader.GetString("calle"),
                                        NroPuerta = reader.GetInt32("nro_puerta"),
                                        Esq = reader.GetString("esq")
                                    };
                                    listaClientes.Add(cliente);
                                }
                            }
                        }

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ClientesBD #buscarClientesPorNroDoc\n" + ex.Number.ToString() + ": " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return listaClientes;
        }



        // ---------------------- OTRAS CONSULTAS -----------------------
        public List<int> buscarTelefonosDeCliente(int idCliente)
        {
            listaTelefonos = new List<int>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT tel FROM cliente_tel WHERE id_cliente = @idCliente;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idCliente", idCliente);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    tel = reader.GetInt32("tel");
                                }
                                listaTelefonos.Add(tel);
                            }
                        }

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ClientesBD #buscarTelefonosDeCliente\n" + ex.Number.ToString() + ": " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return listaTelefonos;
        }

        public List<string> buscarMailsDeCliente(int idCliente)
        {
            listaMails = new List<string>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT mail FROM cliente_mail WHERE id_cliente = @idCliente;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idCliente", idCliente);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    mail = reader.GetString("mail");
                                }
                                listaMails.Add(mail);
                            }
                        }

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ClientesBD #buscarMailsDeCliente\n" + ex.Number.ToString() + ": " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return listaMails;
        }


    }
}
