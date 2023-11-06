using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using SISVIANSA_ITI_2023.Logica;

namespace SISVIANSA_ITI_2023.Persistencia
{
    public class ViandaBD
    {
        private byte rol;
        private string consulta;
        private Vianda vianda;
        private List<Vianda> listaViandas;
        private Singleton bd;

        // ------------------- CONSTRUCTOR ---------------------
        public ViandaBD(byte rol)
        {
            this.rol = rol;
            bd = Singleton.RecuperarInstancia();
        }


        // ------------------- CONSULTAS ------------------------
        public List<Vianda> todasLasViandas()
        {
            listaViandas = new List<Vianda>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT v.id_vianda, v.id_menu, v.fecha_envasado, a.id_sucursal, ";
                        consulta += "DATE_ADD(v.fecha_envasado, INTERVAL m.congelable DAY) AS fecha_vencimiento ";
                        consulta += "FROM vianda v ";
                        consulta += "JOIN menu m ON m.id_menu = v.id_menu ";
                        consulta += "JOIN almacena a ON a.id_vianda = v.id_vianda; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    vianda = new Vianda(rol)
                                    {
                                        IdVianda = reader.GetInt32("id_vianda"),
                                        IdMenu = reader.GetInt32("id_menu"),
                                        FechaEnvasado = reader.GetString("fecha_envasado"),
                                        FechaVencimiento = reader.GetString("fecha_vencimiento")
                                    };
                                    listaViandas.Add(vianda);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ZonaBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return listaViandas;
        }
       
        
        public List<Vianda> filtrarViandasPorSucursal(int idSucursal)
        {
            listaViandas = new List<Vianda>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT v.id_vianda, v.id_menu, v.fecha_envasado, a.id_sucursal, ";
                        consulta += "DATE_ADD(v.fecha_envasado, INTERVAL m.congelable DAY) AS fecha_vencimiento ";
                        consulta += "FROM vianda v ";
                        consulta += "JOIN menu m ON m.id_menu = v.id_menu ";
                        consulta += "JOIN almacena a ON a.id_vianda = v.id_vianda ";
                        consulta += "WHERE a.id_sucursal = @idSucursal; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idSucursal", idSucursal);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    vianda = new Vianda(rol)
                                    {
                                        IdVianda = reader.GetInt32("id_vianda"),
                                        IdMenu = reader.GetInt32("id_menu"),
                                        FechaEnvasado = reader.GetString("fecha_envasado"),
                                        FechaVencimiento = reader.GetString("fecha_vencimiento")
                                    };
                                    listaViandas.Add(vianda);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ZonaBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return listaViandas;
        }
    


    
    
    }
}
