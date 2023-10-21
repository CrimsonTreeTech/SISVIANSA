using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Logica;
using MySqlConnector;
using MySqlX.XDevAPI.Relational;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics.Metrics;
using System.Data;
using Org.BouncyCastle.Utilities;

namespace SISVIANSA_ITI_2023.Persistencia
{
    public class ProduccionBD
    {
        private byte rol;
        private string consulta;
        private int filasAfectadas;
        private Singleton bd;
        private Produccion produccion;
        private List<Produccion> listaProduccion;

        // ---------------- Constructor ---------------
        public ProduccionBD(byte rol)
        {
            this.rol = rol;
        }

        // ------------------- CONSULTAS -----------------------
        public bool crearTablaTemporaProduccion(int idSucursal)
        {
            filasAfectadas = 0;
            try
            {
                using(bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "CREATE VIEW produccion AS ";
                        consulta += "SELECT v.id_menu, m.lote_min, count(v.id_vianda) AS cantidad, m.lote_max, pm.produccion_menu ";
                        consulta += "FROM vianda v ";
                        consulta += "JOIN almacena a ON a.id_vianda = v.id_vianda AND id_sucursal = @idSucursal ";
                        consulta += "JOIN menu m ON m.id_menu = v.id_menu ";
                        consulta += "JOIN( ";
                        consulta += "SELECT m.id_menu, SUM(c.tiempo_produccion) AS produccion_menu ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN integra i ON i.id_menu = m.id_menu ";
                        consulta += "JOIN comida c ON c.id_comida = i.id_comida ";
                        consulta += "GROUP BY m.id_menu ";
                        consulta += ") pm ON pm.id_menu = m.id_menu ";
                        consulta += "GROUP BY v.id_menu ";
                        consulta += "ORDER BY (m.lote_min >= cantidad) DESC;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                if(ex.Number == 1050)
                {
                    borrarVistaProduccion();
                    crearTablaTemporaProduccion(idSucursal);
                }
                else
                {
                    MessageBox.Show("ProduccionBD #1: " + ex.Number.ToString() + ": " + ex.Message);
                }
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }

        public List<Produccion> obtenerListadoProduccionDiaria(int idSucursal)
        {
            listaProduccion = new List<Produccion>();
            try
            {
                using(bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT id_menu, lote_min, cantidad, lote_max, produccion_menu FROM produccion;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    produccion = new Produccion(rol)
                                    {
                                        IdMenu = reader.GetInt32("id_menu"),
                                        LoteMin = reader.GetInt32("lote_min"),
                                        CantidadEnStock = reader.GetInt32("cantidad"),
                                        LoteMax = reader.GetInt32("lote_max"),
                                        ProdMenu = reader.GetInt32("produccion_menu")
                                    };
                                    listaProduccion.Add(produccion);
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ProduccionBD #2: " + ex.Number.ToString() + ": " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return listaProduccion;
        }

        private bool borrarVistaProduccion()
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "DROP VIEW produccion;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ProduccionBD #1: " + ex.Number.ToString() + ": " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }

    }
}
