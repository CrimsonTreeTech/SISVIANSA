using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Logica;
using MySqlConnector;

namespace SISVIANSA_ITI_2023.Persistencia
{
    public class DietaBD
    {
        private byte rol;
        private string consulta;
        private Singleton bd;
        private Dieta dieta;
        private List<Dieta> dietas;

        // --------------- CONSTRUCTOR --------------
        public DietaBD(byte rol)
        {
            this.rol = rol;
        }

        
        // ----------------------- CONSULTAS -------------------
        public List<Dieta> todasLasDietas()
        {
            dietas = new List<Dieta>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_dieta, nombre, descripcion, autorizado, activo FROM dieta;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    dieta = new Dieta(this.rol)
                                    {
                                        Id = reader.GetInt32("id_dieta"),
                                        Nombre = reader.GetString("nombre"),
                                        Descripcion = reader.GetString("descripcion"),
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        Activo = reader.GetBoolean("activo")
                                    };
                                    dietas.Add(dieta);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error DietaBD #1: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return dietas;
        }

        public List<Dieta> dietasAutorizadasYActivo()
        {
            dietas = new List<Dieta>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_dieta, nombre, descripcion FROM dieta WHERE autorizado = true AND activo = true;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    dieta = new Dieta(rol)
                                    {
                                        Id = reader.GetInt32("id_dieta"),
                                        Nombre = reader.GetString("nombre"),
                                        Descripcion = reader.GetString("descripcion")
                                    };
                                    dietas.Add(dieta);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error DietaBD #2: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return dietas;
        }

        public List<Dieta> obtenerDietasDeComida(int idComida)
        {
            dietas = new List<Dieta>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT dieta.id, dieta.nombre, dieta.descripcion, dieta.activo, dieta.autorizado FROM dieta JOIN aplica ON aplica.id_dieta = dieta.id_dieta WHERE aplica.id_comida = @id;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idComida);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Dieta dieta = new Dieta(rol)
                                    {
                                        Id = reader.GetInt32("id"),
                                        Nombre = reader.GetString("nombre"),
                                        Descripcion = reader.GetString("descripcion"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado")
                                    };
                                    dietas.Add(dieta);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error DietaBD #3: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return dietas;
        }

    }
}
