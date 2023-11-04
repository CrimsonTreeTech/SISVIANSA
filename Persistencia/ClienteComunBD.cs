using SISVIANSA_ITI_2023.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace SISVIANSA_ITI_2023.Persistencia
{
    public class ClienteComunBD
    {
        private byte rol;
        private string consulta;
        private int filasAfectadas;
        private Cliente cliente;
        private List<Cliente> clientes;
        private Singleton bd;


        // ------------------- CONSTRUCTOR ----------------------
        public ClienteComunBD(byte rol)
        {
            this.rol = rol;
        }


        // ----------------- ABM ----------------------
       

        // ----------------- CONSULTAS --------------------
        public Cliente obtenerDatos(int idCliente)
        {
            cliente = null;
            try
            {
                using(bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT cc.p_nom, cc.p_ape, cc.s_nom, cc.s_ape, c.calle, c.nro_puerta, c.esq " +
                                    "FROM cliente_comun cc " +
                                    "JOIN cliente c ON cc.id_cliente = c.id_cliente AND c.id_cliente = 1;";
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
                                        PNom = reader.GetString("p_nom"),
                                        SNom = reader.GetString("p_ape"),
                                        PApe = reader.GetString("s_nom"),
                                        SApe = reader.GetString("s_ape"),
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
                MessageBox.Show("Error ClienteComunBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return cliente;
        }

    }
}
