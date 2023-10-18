using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using SISVIANSA_ITI_2023.Logica;

namespace SISVIANSA_ITI_2023.Persistencia
{
    public class ComidasBD
    {
        private byte rol;
        private string consulta;
        private Comida comida;
        private List<Comida> comidas;
        private Singleton bd;

        // ------------------ CONSTRUCTOR --------------------
        public ComidasBD (byte rol)
        {
            this.rol = rol;
            bd = Singleton.RecuperarInstancia();
        }


        // ------------------- CONSULTAS ---------------------------
        public List<Comida> listaDeComidas()
        {
            comidas = new List<Comida>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_comida, nombre, tiempo_produccion, activo, autorizado FROM comida";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    comida = new Comida(rol)
                                    {
                                        Id = reader.GetInt32("id_comida"),
                                        Coccion = reader.GetInt32("tiempo_produccion"),
                                        Nombre = reader.GetString("nombre"),
                                        Activo = true,
                                        Autorizado = true
                                    };
                                    comidas.Add(comida);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ComidaBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return comidas;
        }

        public List<Comida> obtenerComidasSegunDieta(List<int> idDietas)
        {
            comidas = new List<Comida>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT c.id_comida, c.nombre, c.tiempo_produccion, c.activo, c.autorizado FROM comida c";
                        foreach (int id in idDietas)
                        {
                            consulta += "JOIN aplica a" + id.ToString() + " ON c.id_comida = a" + id.ToString() + ".id_comida AND a" + id.ToString() + ".id_dieta = " + id.ToString();
                        }
                        consulta += "WHERE c.activo = true AND c.autorizado = true;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    comida = new Comida(rol)
                                    {
                                        Id = reader.GetInt32("id_comida"),
                                        Coccion = reader.GetInt32("tiempo_produccion"),
                                        Nombre = reader.GetString("nombre"),
                                        Activo = true,
                                        Autorizado = true
                                    };
                                    comidas.Add(comida);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ComidaBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return comidas;
        }

        public Comida obtenerDatosComida(int idComida)
        {
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_comida, nombre, tiempo_produccion, activo, autorizado FROM comida WHERE id_comida = @id";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("id", idComida);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    comida = new Comida(rol)
                                    {
                                        Id = reader.GetInt32("id_comida"),
                                        Coccion = reader.GetInt32("tiempo_produccion"),
                                        Nombre = reader.GetString("nombre"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado")
                                    };
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ComidaBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return comida;
        }


    }
}
