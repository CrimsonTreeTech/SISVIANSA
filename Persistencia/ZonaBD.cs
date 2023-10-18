using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySqlConnector;
using SISVIANSA_ITI_2023.Logica;

namespace SISVIANSA_ITI_2023.Persistencia
{
    internal class ZonaBD
    {
        private byte rol;
        private int filasAfectadas, ultimoId;
        private string consulta, barrio;
        private double precio;
        private Singleton bd;
        private Zona zona;
        private Vehiculo vehiculo;
        private List<Zona> zonas;
        private List<Vehiculo> vehiculos;
        private List<string> barrios;

        public ZonaBD(byte rol) 
        {
            this.rol = rol;
        }

        
        // -------------------------- INGRESAR --------------------------        
        public bool ingresarNuevaZona()
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "INSERT INTO zona (id_zona, activo, autorizado) VALUES (null, true, false);";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            filasAfectadas = cmd.ExecuteNonQuery();
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
            return filasAfectadas > 0;
        }

        public bool ingresarPrecioZona(int id, double valor)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "INSERT INTO zona_precio (id_zona, valor, fecha_act) VALUES (@id, @valor, DATE(NOW()));";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@valor", valor);
                            filasAfectadas = cmd.ExecuteNonQuery();
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
            return filasAfectadas > 0;
        }

        public bool ingresarBarrioZona(int id, string barrio)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "INSERT INTO zona_precio (id_zona, valor, fecha_act) VALUES (@id, @barrio, DATE(NOW()));";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@barrio", barrio);
                            filasAfectadas = cmd.ExecuteNonQuery();
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
            return filasAfectadas > 0;
        }

        public int ultimoIdIngresado()
        {
            ultimoId = -1;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT MAX(id_zona) FROM zona;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    ultimoId = reader.GetInt32("id_zona");
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
            return ultimoId;
        }


        // -------------------------- CONSULTAS ---------------------------
        public List<Zona> todasLasZonas()
        {
            zonas = new List<Zona> ();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_zona, activo, autorizado FROM zona;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    zona = new Zona(rol)
                                    {
                                        Id = reader.GetInt32("id_zona"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado")
                                    };
                                    zonas.Add(zona);
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
            return zonas;
        }

        public List<string> obtenerBarriosDeZona(int idZona)
        {
            barrios = new List<string> ();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT barrio FROM zona_barrio WHERE id_zona = @id;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idZona);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    barrio = reader.GetString("barrio");
                                    barrios.Add(barrio);
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
            return barrios;
        }

        public double obtenerPrecio(int idZona)
        {
            precio = -1;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT valor FROM zona_precio WHERE id_zona = @id AND fecha_act = (SELECT MAX(fecha_act) FROM zona_precio);";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idZona);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    precio = reader.GetDouble("valor");
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
            return precio;
        }

        public List<Zona> zonasDeRepartoDeVehiculo(int idVehiculo)
        {
            zonas = new List<Zona>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT z.id_zona, z.activo, z.autorizado, zp.precio " +
                                    "FROM zona z " +
                                    "JOIN zona_precio zp ON z.id_zona = zp.id_zona " +
                                    "JOIN reparte r ON r.id_zona = z.id_zona " +
                                    "WHERE r.id_vehiculo = 1 AND zp.fecha_act = (SELECT MAX(zp.fecha_act) FROM zona_precio zp);";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idVehiculo", idVehiculo);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    zona = new Zona(rol)
                                    {
                                        Id = reader.GetInt32("id_vehiculo"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        Precio = reader.GetDouble("precio")
                                    };
                                    vehiculos.Add(vehiculo);
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
            return zonas;
        }


        // --------------------------------------------------------------
        public List<string> obtenerZonas()
        {
            return new List<string> { "Zona 1", "Zona 2", "Zona 3", "Zona 4", "Zona 5", "Zona 6"};
        }

    }
}
