using System;
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
        private int filasAfectadas;
        private int? tel;
        private Cliente cliente;
        private List<Cliente> listaClientes;
        private List<int?> listaTelefonos;
        private List<string> listaMails, listaNombresParticular;
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


        // -------------- ABM CLIENTE COMUN ---------------------
        public bool ingresarClienteComun(Cliente cliente)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "INSERT INTO cliente(calle, esq, nro_puerta, activo, autorizado) ";
                        consulta += "VALUES (@calle, @esq, @nro_puerta, @activo, @autorizado); ";

                        consulta += "SELECT LAST_INSERT_ID() INTO @nuevo_id; ";

                        consulta += "INSERT INTO cliente_comun(id_cliente, doc, tipo_doc, p_nom, s_nom, p_ape, s_ape) ";
                        consulta += "VALUES (@nuevo_id, @doc, @tipo_doc, @p_nom, @s_nom, @p_ape, @s_ape); ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@calle", cliente.Calle);
                            cmd.Parameters.AddWithValue("@esq", cliente.Esq);
                            cmd.Parameters.AddWithValue("@nro_puerta", cliente.NroPuerta);
                            cmd.Parameters.AddWithValue("@activo", cliente.Activo);
                            cmd.Parameters.AddWithValue("@autorizado", cliente.Autorizado);
                            cmd.Parameters.AddWithValue("@doc", cliente.Doc);
                            cmd.Parameters.AddWithValue("@tipo_doc", cliente.TipoDoc);
                            cmd.Parameters.AddWithValue("@p_nom", cliente.PNom);
                            cmd.Parameters.AddWithValue("@s_nom", cliente.SNom);
                            cmd.Parameters.AddWithValue("@p_ape", cliente.PApe);
                            cmd.Parameters.AddWithValue("@s_ape", cliente.SApe);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }

                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Ya existe un cliente registrado con este documento", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error inesperado y no se han guardado los datos. Consulte con el técnico", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas >0;
        }


        // -------------- ABM CLIENTE COMUN ---------------------
        public bool ingresarClienteEmpresa(Cliente cliente)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "INSERT INTO cliente(calle, esq, nro_puerta, activo, autorizado) ";
                        consulta += "VALUES (@calle, @esq, @nro_puerta, @activo, @autorizado); ";

                        consulta += "SELECT LAST_INSERT_ID() INTO @nuevo_id; ";

                        consulta += "INSERT INTO cliente_empresa(id_cliente, rut, nombre) ";
                        consulta += "VALUES (@nuevo_id, @rut, @nombre); ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@calle", cliente.Calle);
                            cmd.Parameters.AddWithValue("@esq", cliente.Esq);
                            cmd.Parameters.AddWithValue("@nro_puerta", cliente.NroPuerta);
                            cmd.Parameters.AddWithValue("@activo", cliente.Activo);
                            cmd.Parameters.AddWithValue("@autorizado", cliente.Autorizado);
                            cmd.Parameters.AddWithValue("@rut", cliente.Doc);
                            cmd.Parameters.AddWithValue("@nombre", cliente.PNom);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }

                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Ya existe un cliente registrado con este documento", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error inesperado y no se han guardado los datos. Consulte con el técnico", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        consulta = "SELECT c.id_cliente, c.tipo_cliente, c.tipo_doc, c.nro_doc, c.nombre,";
                        consulta += "c.calle, c.nro_puerta, c.esq, c.activo, c.autorizado ";
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
                                        TipoCliente = reader.GetString("tipo_cliente"),
                                        TipoDoc = reader.GetString("tipo_doc"),
                                        Doc = reader.GetInt64("nro_doc"),
                                        NombreCompleto = reader.GetString("nombre"),
                                        Calle = reader.GetString("calle"),
                                        NroPuerta = reader.GetInt32("nro_puerta"),
                                        Esq = reader.GetString("esq"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado")
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

        public Cliente buscarClientesPorId(int id)
        {
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT c.id_cliente, c.tipo_cliente, c.tipo_doc, c.nro_doc, c.nombre,";
                        consulta += "c.calle, c.nro_puerta, c.esq, c.activo, c.autorizado ";
                        consulta += "FROM clientes c ";
                        consulta += "WHERE c.id_cliente = @id;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", id);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    cliente = new Cliente(rol)
                                    {
                                        Id = reader.GetInt32("id_cliente"),
                                        TipoCliente = reader.GetString("tipo_cliente"),
                                        TipoDoc = reader.GetString("tipo_doc"),
                                        Doc = reader.GetInt64("nro_doc"),
                                        NombreCompleto = reader.GetString("nombre"),
                                        Calle = reader.GetString("calle"),
                                        NroPuerta = reader.GetInt32("nro_puerta"),
                                        Esq = reader.GetString("esq"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado")
                                    };
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
            return cliente;
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
                        consulta = "SELECT c.id_cliente, c.tipo_cliente, c.tipo_doc, c.nro_doc, c.nombre,";
                        consulta += "c.calle, c.nro_puerta, c.esq, c.activo, c.autorizado ";
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
                                        TipoCliente = reader.GetString("tipo_cliente"),
                                        TipoDoc = reader.GetString("tipo_doc"),
                                        Doc = reader.GetInt64("nro_doc"),
                                        NombreCompleto = reader.GetString("nombre"),
                                        Calle = reader.GetString("calle"),
                                        NroPuerta = reader.GetInt32("nro_puerta"),
                                        Esq = reader.GetString("esq"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado")
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

        public List<Cliente> buscarClientesPorNombre(string nombre)
        {
            listaClientes = new List<Cliente>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT c.id_cliente, c.tipo_cliente, c.tipo_doc, c.nro_doc, c.nombre,";
                        consulta += "c.calle, c.nro_puerta, c.esq, c.activo, c.autorizado ";
                        consulta += "FROM clientes c ";
                        consulta += "WHERE c.nombre LIKE @nombre;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@nombre", "%"+nombre +"%");

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    cliente = new Cliente(rol)
                                    {
                                        Id = reader.GetInt32("id_cliente"),
                                        TipoCliente = reader.GetString("tipo_cliente"),
                                        TipoDoc = reader.GetString("tipo_doc"),
                                        Doc = reader.GetInt64("nro_doc"),
                                        NombreCompleto = reader.GetString("nombre"),
                                        Calle = reader.GetString("calle"),
                                        NroPuerta = reader.GetInt32("nro_puerta"),
                                        Esq = reader.GetString("esq"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado")
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

        public List<Cliente> buscarClientesPorTipo(string tipo)
        {
            listaClientes = new List<Cliente>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT c.id_cliente, c.tipo_cliente, c.tipo_doc, c.nro_doc, c.nombre,";
                        consulta += "c.calle, c.nro_puerta, c.esq, c.activo, c.autorizado ";
                        consulta += "FROM clientes c ";
                        consulta += "WHERE c.tipo_cliente = @tipo;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@tipo", tipo);


                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    cliente = new Cliente(rol)
                                    {
                                        Id = reader.GetInt32("id_cliente"),
                                        TipoCliente = reader.GetString("tipo_cliente"),
                                        TipoDoc = reader.GetString("tipo_doc"),
                                        Doc = reader.GetInt64("nro_doc"),
                                        NombreCompleto = reader.GetString("nombre"),
                                        Calle = reader.GetString("calle"),
                                        NroPuerta = reader.GetInt32("nro_puerta"),
                                        Esq = reader.GetString("esq"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado")
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

        public List<Cliente> buscarClientesActivos(bool activo)
        {
            listaClientes = new List<Cliente>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT c.id_cliente, c.tipo_cliente, c.tipo_doc, c.nro_doc, c.nombre,";
                        consulta += "c.calle, c.nro_puerta, c.esq, c.activo, c.autorizado ";
                        consulta += "FROM clientes c ";
                        consulta += "WHERE c.activo = @activo;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@activo", activo);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    cliente = new Cliente(rol)
                                    {
                                        Id = reader.GetInt32("id_cliente"),
                                        TipoCliente = reader.GetString("tipo_cliente"),
                                        TipoDoc = reader.GetString("tipo_doc"),
                                        Doc = reader.GetInt64("nro_doc"),
                                        NombreCompleto = reader.GetString("nombre"),
                                        Calle = reader.GetString("calle"),
                                        NroPuerta = reader.GetInt32("nro_puerta"),
                                        Esq = reader.GetString("esq"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado")
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

        public List<Cliente> buscarClientesAutorizados(bool autorizado)
        {
            listaClientes = new List<Cliente>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT c.id_cliente, c.tipo_cliente, c.tipo_doc, c.nro_doc, c.nombre,";
                        consulta += "c.calle, c.nro_puerta, c.esq, c.activo, c.autorizado ";
                        consulta += "FROM clientes c ";
                        consulta += "WHERE c.autorizado = @autorizado;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@autorizado", autorizado);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    cliente = new Cliente(rol)
                                    {
                                        Id = reader.GetInt32("id_cliente"),
                                        TipoCliente = reader.GetString("tipo_cliente"),
                                        TipoDoc = reader.GetString("tipo_doc"),
                                        Doc = reader.GetInt64("nro_doc"),
                                        NombreCompleto = reader.GetString("nombre"),
                                        Calle = reader.GetString("calle"),
                                        NroPuerta = reader.GetInt32("nro_puerta"),
                                        Esq = reader.GetString("esq"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado")
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

        public List<Cliente> buscarClientesActivosYAutorizados()
        {
            listaClientes = new List<Cliente>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT c.id_cliente, c.tipo_cliente, c.tipo_doc, c.nro_doc, c.nombre,";
                        consulta += "c.calle, c.nro_puerta, c.esq, c.activo, c.autorizado ";
                        consulta += "FROM clientes c ";
                        consulta += "WHERE c.autorizado = true AND c.activo = true;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    cliente = new Cliente(rol)
                                    {
                                        Id = reader.GetInt32("id_cliente"),
                                        TipoCliente = reader.GetString("tipo_cliente"),
                                        TipoDoc = reader.GetString("tipo_doc"),
                                        Doc = reader.GetInt64("nro_doc"),
                                        NombreCompleto = reader.GetString("nombre"),
                                        Calle = reader.GetString("calle"),
                                        NroPuerta = reader.GetInt32("nro_puerta"),
                                        Esq = reader.GetString("esq"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado")
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
        public List<int?> buscarTelefonosDeCliente(int idCliente)
        {
            listaTelefonos = new List<int?>();
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
                                    if (!reader.IsDBNull(reader.GetOrdinal("tel")))
                                    {
                                        tel = reader.GetInt32("tel");
                                    }                                    
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

        public List<string> obtenerNombresClienteParticular(int idCliente)
        {
            listaNombresParticular = new List<string>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT p_nom, s_nom, p_ape, s_ape ";
                        consulta += "FROM cliente_comun ";
                        consulta += "WHERE id_cliente = @idCliente;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idCliente", idCliente);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    listaNombresParticular.Add(reader.GetString("p_nom"));
                                    
                                    if (!reader.IsDBNull(reader.GetOrdinal("s_nom")))
                                    {
                                        listaNombresParticular.Add(reader.GetString("s_nom"));
                                    }
                                    else
                                    {
                                        listaNombresParticular.Add("");
                                    }

                                    
                                    listaNombresParticular.Add(reader.GetString("p_ape"));

                                    if (!reader.IsDBNull(reader.GetOrdinal("s_ape")))
                                    {
                                        listaNombresParticular.Add(reader.GetString("s_ape"));
                                    }
                                    else
                                    {
                                        listaNombresParticular.Add("");
                                    }
                                }
                            }
                        }

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ClientesBD #obtenerNombresClienteParticular\n" + ex.Number.ToString() + ": " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return listaNombresParticular;
        }



        // ------------------ AUTORIZACION ------------------
        public bool autorizarCliente(int idCliente, bool autorizar)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "UPDATE clientes SET autorizado = @autorizar WHERE id_cliente = @idCliente;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idCliente", idCliente);
                            cmd.Parameters.AddWithValue("@autorizar", autorizar);

                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ClientesBD #autorizarCliente: " + ex.Number.ToString() + ": " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }

        public bool altaBajaCliente(int idCliente, bool alta)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "UPDATE clientes SET activo = @alta WHERE id_cliente = @idCliente;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idCliente", idCliente);
                            cmd.Parameters.AddWithValue("@alta", alta);

                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ClientesBD #autorizarCliente: " + ex.Number.ToString() + ": " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }

    }
}
