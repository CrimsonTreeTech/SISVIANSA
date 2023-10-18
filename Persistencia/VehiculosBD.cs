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
                MessageBox.Show("Error VehiculoBD: " + ex.Message);
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
                MessageBox.Show("Error VehiculoBD: " + ex.Message);
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
                MessageBox.Show("Error VehiculoBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }


        // Baja
        public bool bajaAltaVehiculo(int id, bool activo)
        {
            filasAfectadas = -1;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "UPDATE vehiculo SET activo=@activo WHERE id_vehiculo=@id;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", vehiculo.Id);
                            cmd.Parameters.AddWithValue("@activo", vehiculo.Activo);
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
                MessageBox.Show("Error VehiculoBD: " + ex.Message);
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
                        consulta = "SELECT id_vehiculo, cap_carga FROM vehiculo WHERE matricula LIKE @matricula;";
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
                                        Matricula = matricula,
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
                MessageBox.Show("Error VehiculoBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return vehiculos;
        }

        public List<Vehiculo> filtrarPorZona(int id_zona)
        {
            vehiculos = new List<Vehiculo>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT vehiculo.id_vehiculo, vehiculo.matricula, vehiculo.cap_carga " +
                                   "FROM vehiculo JOIN reparte ON vehiculo.id_vehiculo = reparte.id_vehiculo " +
                                   "WHERE reparte.id_zona = @id_zona;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id_zona", id_zona);
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
                MessageBox.Show("Error VehiculoBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return vehiculos;
        }


    }
}
