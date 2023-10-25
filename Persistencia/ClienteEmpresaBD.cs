using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Logica;
using MySqlConnector;

namespace SISVIANSA_ITI_2023.Persistencia
{
    public class ClienteEmpresaBD
    {
        private byte rol;
        private string consulta;
        private int filasAfectadas;
        private Cliente cliente;
        private List<Cliente> clientes;
        private Singleton bd;


        // ------------------- CONSTRUCTOR ----------------------
        public ClienteEmpresaBD(byte rol)
        {
            this.rol = rol;
        }
        
        // ----------------- CONSULTAS --------------------
        public Cliente obtenerDatos(int idCliente)
        {
            cliente = new Cliente(rol);
            try
            {
                using(bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT ce.rut, ce.nombre, c.calle, c.nro_puerta, c.esq " +
                                    "FROM cliente_empresa ce " +
                                    "JOIN cliente c ON ce.id_cliente = c.id_cliente AND c.id_cliente = 9;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("idCliente", idCliente);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    cliente = new Cliente(rol)
                                    {
                                        Id = idCliente,
                                        Doc = reader.GetInt32("rut"),
                                        NombreEmpresa = reader.GetString("nombre"),
                                        Calle = reader.GetString("calle"),
                                        NroPuerta = reader.GetInt32("nro_puerta"),
                                        Esq = reader.GetString("esq")
                                    };
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ClienteEmpresaBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return cliente;
            
        }

    }
}
