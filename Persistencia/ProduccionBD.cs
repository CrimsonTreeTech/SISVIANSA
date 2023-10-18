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
                        consulta = "CREATE TEMPORARY TABLE IF NOT EXISTS produccion AS";
                        consulta += "SELECT v.id_menu, m.lote_min, count(v.id_vianda) AS cantidad, m.lote_max, NULL AS prioridad";
                        consulta += "FROM vianda v";
                        consulta += "JOIN almacena a ON a.id_vianda = v.id_vianda AND id_sucursal = @idSucursal";
                        consulta += "JOIN menu m ON m.id_menu = v.id_menu";
                        consulta += "GROUP BY v.id_menu;";
                        consulta += "ALTER TABLE produccion";
                        consulta += "ADD COLUMN prioridad INT UNIQUE;";

                        using(MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        consulta = "SELECT id_menu, lote_min, cantidad, lote_max, prioridad FROM produccion WHERE cantidad BETWEEN lote_min AND lote_max;";
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
                                        Cantidad = reader.GetInt32("cantidad"),
                                        LoteMax = reader.GetInt32("lote_max")
                                    };
                                    if (!reader.IsDBNull("prioridad"))
                                        produccion.Prioridad = reader.GetInt32("prioridad");
                                    else
                                        produccion.Prioridad = null;
                                    listaProduccion.Add(produccion);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return listaProduccion;
        }

    }
}
