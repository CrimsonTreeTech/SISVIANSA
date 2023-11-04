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
        private int filasAfectadas, i;
        private Comida comida;
        private List<Comida> comidas;
        private Singleton bd;

        // ------------------ CONSTRUCTOR --------------------
        public ComidasBD (byte rol)
        {
            this.rol = rol;
            bd = Singleton.RecuperarInstancia();
        }




        // ------------------ ABM ------------------------------
        public bool ingresar(Comida comida)
        {
            filasAfectadas = 0;
            i = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta += "INSERT INTO comida(nombre, tiempo_produccion, activo, autorizado) ";
                        consulta += "VALUES  (@nombre, @coccion, @activo, @autorizado); ";

                        consulta += "SELECT LAST_INSERT_ID() INTO @nuevo_id; ";

                        foreach (Dieta dieta in comida.Dietas)
                        {
                            consulta += $"INSERT INTO aplica (id_dieta, id_comida) VALUES (@param{i}, @nuevo_id); ";
                            i += 1;
                        }
                        

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@nombre", comida.Nombre);
                            cmd.Parameters.AddWithValue("@coccion", comida.Coccion);
                            cmd.Parameters.AddWithValue("@activo", comida.Activo);
                            cmd.Parameters.AddWithValue("@autorizado", comida.Autorizado);

                            i = 0;
                            foreach (Dieta dieta in comida.Dietas)
                            {
                                cmd.Parameters.AddWithValue($"@param{i}", comida.Dietas[i].Id);
                                i += 1;
                            }

                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ComidaBD #ingresar: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
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
                        consulta  = "SELECT c.id_comida, c.nombre, c.tiempo_produccion, c.activo, c.autorizado, group_concat(' ', d.nombre) AS dietas ";
                        consulta += "FROM comida c ";
                        consulta += "JOIN aplica a ON a.id_comida = c.id_comida ";
                        consulta += "JOIN dieta d ON d.id_dieta = a.id_dieta ";
                        consulta += "GROUP BY c.id_comida; ";

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
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        DietasSTR = reader.GetString("dietas")
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

        public List<Comida> listaDeComidasPorNombre(string valFiltro)
        {
            comidas = new List<Comida>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT c.id_comida, c.nombre, c.tiempo_produccion, c.activo, c.autorizado, group_concat(' ', d.nombre) AS dietas ";
                        consulta += "FROM comida c ";
                        consulta += "JOIN aplica a ON a.id_comida = c.id_comida ";
                        consulta += "JOIN dieta d ON d.id_dieta = a.id_dieta ";
                        consulta += "WHERE c.nombre LIKE @valFiltro ";
                        consulta += "GROUP BY c.id_comida; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@valFiltro", "%" + valFiltro + "%");

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
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        DietasSTR = reader.GetString("dietas")
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

        public List<Comida> listaDeComidasPorAutorizado(bool valFiltro)
        {
            comidas = new List<Comida>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT c.id_comida, c.nombre, c.tiempo_produccion, c.activo, c.autorizado, group_concat(' ', d.nombre) AS dietas ";
                        consulta += "FROM comida c ";
                        consulta += "JOIN aplica a ON a.id_comida = c.id_comida ";
                        consulta += "JOIN dieta d ON d.id_dieta = a.id_dieta ";
                        consulta += "WHERE c.autorizado = @valFiltro ";
                        consulta += "GROUP BY c.id_comida; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@valFiltro", valFiltro);

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
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        DietasSTR = reader.GetString("dietas")
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

        public List<Comida> listaDeComidasPorActivo(bool valFiltro)
        {
            comidas = new List<Comida>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT c.id_comida, c.nombre, c.tiempo_produccion, c.activo, c.autorizado, group_concat(' ', d.nombre) AS dietas ";
                        consulta += "FROM comida c ";
                        consulta += "JOIN aplica a ON a.id_comida = c.id_comida ";
                        consulta += "JOIN dieta d ON d.id_dieta = a.id_dieta ";
                        consulta += "WHERE c.activo = @valFiltro ";
                        consulta += "GROUP BY c.id_comida; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@valFiltro", valFiltro);

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
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        DietasSTR = reader.GetString("dietas")
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

        public List<Comida> listaDeComidasPorDieta(List<string> valFiltro)
        {
            comidas = new List<Comida>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT c.id_comida, c.nombre, c.tiempo_produccion, c.activo, c.autorizado, group_concat(' ', d.nombre) AS dietas ";
                        consulta += "FROM comida c ";
                        consulta += "JOIN aplica a ON a.id_comida = c.id_comida ";
                        consulta += "JOIN dieta d ON d.id_dieta = a.id_dieta ";
                        consulta += "WHERE d.nombre IN ( ";
                        for (int i = 0; i < valFiltro.Count; i++)
                        {
                            consulta += (i > 0 ? ", " : "") + $"@param{i}";
                        }
                        consulta += ") ";
                        consulta += "GROUP BY c.id_comida; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            for (int i = 0; i < valFiltro.Count; i++)
                            {
                                cmd.Parameters.AddWithValue($"@param{i}", valFiltro[i]);
                            }

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
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        DietasSTR = reader.GetString("dietas")
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


        public Comida buscarComidaPorNombre(string nombre)
        {
            comida = new Comida(rol);
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT c.id_comida, c.nombre, c.tiempo_produccion, c.activo, c.autorizado, group_concat(' ', d.nombre) AS dietas ";
                        consulta += "FROM comida c ";
                        consulta += "JOIN aplica a ON a.id_comida = c.id_comida ";
                        consulta += "JOIN dieta d ON d.id_dieta = a.id_dieta ";
                        consulta += "WHERE c.nombre = @nombre ";
                        consulta += "GROUP BY c.id_comida; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@nombre", nombre);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    comida.Id = reader.GetInt32("id_comida");
                                    comida.Coccion = reader.GetInt32("tiempo_produccion");
                                    comida.Nombre = reader.GetString("nombre");
                                    comida.Activo = reader.GetBoolean("activo");
                                    comida.Autorizado = reader.GetBoolean("autorizado");
                                    comida.DietasSTR = reader.GetString("dietas");
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



        public bool altaBajaComida(int idComida, bool alta)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "UPDATE comida SET activo = @alta WHERE id_comida = @idComida;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idComida", idComida);
                            cmd.Parameters.AddWithValue("@alta", alta);

                            filasAfectadas = cmd.ExecuteNonQuery();
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
            return filasAfectadas > 0;
        }

        public bool autorizarComida(int idComida, bool alta)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "UPDATE comida SET autorizado = @alta WHERE id_comida = @idComida;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@idComida", idComida);
                            cmd.Parameters.AddWithValue("@alta", alta);

                            filasAfectadas = cmd.ExecuteNonQuery();
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
            return filasAfectadas > 0;
        }


    }
}
