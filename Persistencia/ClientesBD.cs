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
        private string consulta;
        private int filasAfectadas;
        private Cliente cliente;
        private List<Cliente> listaClientes;
        private Singleton bd;

        public ClientesBD (byte rol)
        {
            this.rol = rol;
        }


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

                        consulta += "DROP VIEW clientes_unificado; ";

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

        public bool buscarClientesPorNroDoc(int doc)
        {
            listaClientes = new List<Cliente>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        /*
                        SELECT c.id_cliente, c.tipo_doc, c.nro_doc, c.nombre, c.activo, c.autorizado, CONCAT(c.calle, ' ', c.nro_puerta, '. Esq.', c.esq, '.'), ct.tel
                        FROM clientes c
                        JOIN 
                        (SELECT ct.id_cliente, MAX(tel) FROM cliente_tel) ct
                        ON ct.id_cliente = c.id_cliente;
                        */

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



    }
}
