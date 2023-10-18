using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Logica;
using System.ComponentModel.Design.Serialization;

namespace SISVIANSA_ITI_2023.Persistencia
{
    public class SucursalBD
    {
        private byte rol;
        private Singleton bd;
        private Sucursal sucursal;
        private Zona zona;
        private List<Sucursal> sucursales;
        private List<Zona> zonas;
        private string consulta;
        private int filasAfectadas;
        private List<Produccion> listaProduccion;
        private Produccion produccion;

        // ------------------ METODOS AL INICIAR --------------------------
        public SucursalBD(byte rol)
        {
            this.rol = rol;
        }

        // ---------------------- ABM -------------------------------
        public bool ingresar(Sucursal sucursal)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "INSERT INTO sucursal (cap_prod, meta, activo) VALUES (@capProd, @meta, @activo);";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@capProd", sucursal.CapProd);
                            cmd.Parameters.AddWithValue("@meta", sucursal.Meta);
                            cmd.Parameters.AddWithValue("@activo", sucursal.Activo);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SucursalBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }

        public bool modificar(Sucursal sucursal)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "UPDATE sucursal SET cap_prod=@capProd, meta=@meta, activo=@activo;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@capProd", sucursal.CapProd);
                            cmd.Parameters.AddWithValue("@meta", sucursal.Meta);
                            cmd.Parameters.AddWithValue("@activo", sucursal.Activo);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SucursalBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }


        // --------------------- CONSULTAS ----------------------------
        public Sucursal datosDeSucursal(int id)
        {
            sucursal = new Sucursal(rol);
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_sucursal, cap_prod, meta, activo FROM sucursal WHERE id_sucursal = @id;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    sucursal.Id = reader.GetInt32("id_vehiculo");
                                    sucursal.CapProd = reader.GetInt32("cap_prod");
                                    sucursal.Meta = reader.GetString("meta");
                                    sucursal.Activo = reader.GetBoolean("activo");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SucursalBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return sucursal;
        }

        public List<Sucursal> obtenerSucursales()
        {
            sucursales = new List<Sucursal>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_sucursal, cap_prod, meta, activo FROM sucursal";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    sucursal = new Sucursal(rol)
                                    {
                                        Id = reader.GetInt32("id_sucursal"),
                                        CapProd = reader.GetInt32("cap_prod"),
                                        Meta = reader.IsDBNull(reader.GetOrdinal("meta")) ? string.Empty : reader.GetString("meta"),
                                        Activo = reader.GetBoolean("activo")
                                    };
                                    sucursales.Add(sucursal);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SucursalBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return sucursales;
        }

        public List<Sucursal> obtenerSucursalesActivas()
        {
            sucursales = new List<Sucursal>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_sucursal FROM sucursal WHERE activo = true;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    sucursal = new Sucursal(rol)
                                    {
                                        Id = reader.GetInt32("id_sucursal")
                                    };
                                    sucursales.Add(sucursal);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SucursalBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return sucursales;
        }

        public List<Zona> obtenerZonasDeSucursal(int idSucursal)
        {
            zonas = new List<Zona>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_zona FROM esta WHERE id_sucursal = @id";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    zona = new Zona(rol)
                                    {
                                        Id = reader.GetInt32("id_zona")
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
                MessageBox.Show("Error SucursalBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return zonas;
        }

    }
}




