using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using SISVIANSA_ITI_2023.Logica;

namespace SISVIANSA_ITI_2023.Persistencia
{
    internal class VehiculosBD
    {
        private byte rol;
        private int filasAfectadas;
        private string consulta;
        private Vehiculo vehiculo;
        private List<Vehiculo> vehiculos;
        private Singleton bd;


        // ------------------- CONSTRUCTOR -------------------
        public VehiculosBD(byte rol)
        {
            this.rol = rol;
        }


        // ---------------------------- ABM -----------------------------------
        
        // Ingresar
        public bool ingresarVehiculo(Vehiculo vehiculo)
        {
            filasAfectadas = -1;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "INSERT INTO vehiculo (id_vehiculo, matricula, cap_carga, activo) VALUES (null, @matricula, @capCarga, true);";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@matricula", vehiculo.Matricula);
                            cmd.Parameters.AddWithValue("@capCarga", vehiculo.CapCarga);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error VehiculoBD #1: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }

        public bool ingresarZonasReparto(int idVehiculo, int idZona)
        {
            filasAfectadas = -1;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "INSERT INTO reparte (id_vehiculo, id_zona, fecha_ini, fecha_fin) VALUES (@idVehiculo, @idZona, DATE(NOW()), null);";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idVehiculo", idVehiculo);
                            cmd.Parameters.AddWithValue("@idZona", idZona);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error VehiculoBD #2: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }

        private bool modificarUltimaFecha(int idVehiculo, int idZona)
        {
            filasAfectadas = -1;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "UPDATE reparte SET fecha_fin = CURRENT_DATE WHERE id_vehiculo = @idVehiculo AND id_zona = @idZona;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idVehiculo", idVehiculo);
                            cmd.Parameters.AddWithValue("@idZona", idZona);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error VehiculoBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }

        
        // Modificar
        public bool modificarVehiculo(Vehiculo vehiculo)
        {
            filasAfectadas = -1;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "UPDATE vehiculo SET matricula=@matricula, cap_carga=@capCarga WHERE id_vehiculo=@id;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", vehiculo.Id);
                            cmd.Parameters.AddWithValue("@matricula", vehiculo.Matricula);
                            cmd.Parameters.AddWithValue("@capCarga", vehiculo.CapCarga);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error VehiculoBD #4: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }


        // Alta / Baja
        public bool bajaAltaVehiculo(int id, bool activo)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "UPDATE vehiculo SET activo=@activo WHERE id_vehiculo=@id;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@activo", activo);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error VehiculoBD #5: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }




        // ------------------------ CONSULTAS ------------------------------------
        public List<Vehiculo> listaVehiculos()
        {
            vehiculos = new List<Vehiculo>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_vehiculo, matricula, cap_carga, activo FROM vehiculo;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    vehiculo = new Vehiculo(rol)
                                    {
                                        Id = reader.GetInt32("id_vehiculo"),
                                        Matricula = reader.GetString("matricula"),
                                        CapCarga = reader.GetInt32("cap_carga"),
                                        Activo = reader.GetBoolean("activo")
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
                MessageBox.Show("Error VehiculoBD #6: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return vehiculos;
            }

        public List<Vehiculo> filtrarPorMatricula(string matricula)
        {
            vehiculos = new List<Vehiculo>();
            try
            {
                using( bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_vehiculo, matricula, cap_carga, activo FROM vehiculo WHERE matricula LIKE @matricula;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@matricula", "%" + matricula + "%");
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    vehiculo = new Vehiculo(rol)
                                    {
                                        Id = reader.GetInt32("id_vehiculo"),
                                        Matricula = reader.GetString("matricula"),
                                        CapCarga = reader.GetInt32("cap_carga"),
                                        Activo = reader.GetBoolean("activo")
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
                MessageBox.Show("Error VehiculoBD #7: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return vehiculos;
        }

        public List<Vehiculo> filtrarPorZona(int idZona)
        {
            vehiculos = new List<Vehiculo>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT v.id_vehiculo, v.matricula, v.cap_carga, v.activo ";
                        consulta += "FROM vehiculo v ";
                        consulta += "JOIN reparte r ON v.id_vehiculo = r.id_vehiculo ";
                        consulta += "WHERE r.id_zona = @idZona; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idZona", idZona);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    vehiculo = new Vehiculo(rol)
                                    {
                                        Id = reader.GetInt32("id_vehiculo"),
                                        Matricula = reader.GetString("matricula"),
                                        CapCarga = reader.GetInt32("cap_carga"),
                                        Activo = reader.GetBoolean("activo")
                                    };
                                    vehiculos.Add(vehiculo);
                                }
                            }
                        }
                    }
                }
                bd.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error VehiculoBD #8: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return vehiculos;
        }


    }
}
