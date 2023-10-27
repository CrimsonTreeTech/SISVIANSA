using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Logica;
using MySqlConnector;

namespace SISVIANSA_ITI_2023.Persistencia
{
    internal class MenuBD
    {
        private byte rol;
        private string consulta;
        private int filasAfectadas, c, d; // c y d son contadores para comida y dieta
        private Singleton bd;
        private Menu menu;
        private Comida comida;
        private Dieta dieta;
        private List<Menu> menus;
        private List<Comida> comidas;
        private List<Dieta> dietas;

        // ----------------- CONSTRUCTOR ------------------------
        public MenuBD(byte rol)
        {
            this.rol = rol;
        }


        public bool ingresasrMenu(Menu menu)
        {
            filasAfectadas = 0;
            c = 0;
            d = 0;

            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta += " INSERT INTO menu (congelable, stock_actual, lote_min, lote_max, tipo_menu, sugerencia, activo, autorizado) ";
                        consulta += " VALUES (@congelable, @stockActual, @lote_min, @lote_max, @tipo_menu, @sugerencia, @activo, @autorizado); ";

                        consulta += " SELECT LAST_INSERT_ID() INTO @nuevo_id; ";

                        foreach (Dieta dieta in menu.Dietas)
                        {
                            consulta += $"INSERT INTO pertenece (id_dieta, id_menu) VALUES (@dieta{d}, @nuevo_id); ";
                            d += 1;
                        }
                        foreach (Comida comida in menu.Comidas)
                        {
                            consulta += $" INSERT INTO integra (id_menu, id_comida, personalizado) VALUES (@nuevo_id, @comida{c}, @personalizado); ";
                            c += 1;
                        }

                        consulta += "INSERT INTO menu_precio(id_menu, fecha, valor) VALUES (@nuevo_id, CURRENT_DATE(), @precio); ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@congelable", menu.Congelable);
                            cmd.Parameters.AddWithValue("@stock_actual", menu.StockActual);
                            cmd.Parameters.AddWithValue("@lote_min", menu.StockMin);
                            cmd.Parameters.AddWithValue("@lote_max", menu.StockMax);
                            cmd.Parameters.AddWithValue("@tipo_menu", menu.Tipo);
                            cmd.Parameters.AddWithValue("@sugerencia", menu.Sugerencia);
                            cmd.Parameters.AddWithValue("@activo", menu.Activo);
                            cmd.Parameters.AddWithValue("@autorizado", menu.Autorizado);
                            cmd.Parameters.AddWithValue("@precio", menu.Precio);

                            c = 0;
                            foreach (Comida comida in menu.Comidas)
                            {
                                cmd.Parameters.AddWithValue($"@dieta{c}", menu.Comidas[c].Id);
                                c += 1;
                            }

                            d = 0;
                            foreach (Dieta dieta in menu.Dietas)
                            {
                                cmd.Parameters.AddWithValue($"@dieta{d}", menu.Dietas[d].Id);
                                d += 1;
                            }

                            filasAfectadas = cmd.ExecuteNonQuery();
                        }                       
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error MenuBD #ingresasrMenu: " + ex.Number.ToString() + ". " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }



        // --------------------- CONSULTAS ------------------------
        public List<Comida> obtenerComidasMenu(int idMenu)
        {
            comidas = new List<Comida>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT comida.id_comida, comida.nombre, comida.tiempo_produccion FROM comida JOIN integra ON comida.id_comida = integra.id_comida WHERE integra.id_menu = @id;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idMenu);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    comida = new Comida(rol)
                                    {
                                        Id = reader.GetInt32("id_comida"),
                                        Nombre = reader.GetString("nombre"),
                                        Coccion = reader.GetInt32("tiempo_produccion")
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
                MessageBox.Show("Error MenuBD #1: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return comidas;
        }

        public List<Dieta> obtenerDietasMenu(int idMenu)
        {
            dietas = new List<Dieta>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT dieta.id_dieta, dieta.nombre, dieta.descripcion, dieta.activo, dieta.autorizado FROM dieta JOIN pertenece ON pertenece.id_dieta = dieta.id_dieta WHERE pertenece.id_menu = @id;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idMenu);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    dieta = new Dieta(rol)
                                    {
                                        Id = reader.GetInt32("id_dieta"),
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
                MessageBox.Show("Error MenuBD #2 : " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return dietas;
        }


        public List<Menu> obtenerTodosLosMenu()
        {
            menus = new List<Menu>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT m.id_menu, m.activo, m.autorizado, m.congelable, m.lote_max, m.lote_min, m.sugerencia, m.tipo_menu, mp.valor, d.dietas ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN menu_precio mp ON m.id_menu = mp.id_menu ";
                        consulta += "JOIN ( ";
                        consulta += "SELECT m.id_menu, GROUP_CONCAT(' ', d.nombre) AS dietas ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN pertenece p ON p.id_menu = m.id_menu ";
                        consulta += "JOIN dieta d ON d.id_dieta = p.id_dieta ";
                        consulta += "GROUP BY m.id_menu ";
                        consulta += ") d ON d.id_menu = m.id_menu ";
                        consulta += "WHERE mp.fecha = (SELECT MAX(menu_precio.fecha) FROM menu_precio); ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    menu = new Menu(rol)
                                    {
                                        Id = reader.GetInt32("id_menu"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        Congelable = reader.GetInt32("congelable"),
                                        StockMin = reader.GetInt32("lote_max"),
                                        StockMax = reader.GetInt32("lote_min"),
                                        Tipo = reader.GetString("tipo_menu"),
                                        Precio = reader.GetDouble("valor"),
                                        DietasSTR = reader.GetString("dietas")
                                    };
                                    if (!reader.IsDBNull(reader.GetOrdinal("sugerencia")))
                                        menu.Sugerencia = reader.GetString("sugerencia");
                                    else
                                        menu.Sugerencia = "";
                                    menus.Add(menu);
                                }
                            }
                        }
                    }
                }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Error MenuBD #3: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return menus;
        }

        public List<Menu> filtrarMenuPorId(int valFiltro)
        {
            menus = new List<Menu>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT m.id_menu, m.activo, m.autorizado, m.congelable, m.lote_max, m.lote_min, m.sugerencia, m.tipo_menu, mp.valor, d.dietas ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN menu_precio mp ON m.id_menu = mp.id_menu ";
                        consulta += "JOIN ( ";
                        consulta += "SELECT m.id_menu, GROUP_CONCAT(' ', d.nombre) AS dietas ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN pertenece p ON p.id_menu = m.id_menu ";
                        consulta += "JOIN dieta d ON d.id_dieta = p.id_dieta ";
                        consulta += "GROUP BY m.id_menu ";
                        consulta += ") d ON d.id_menu = m.id_menu ";
                        consulta += "WHERE mp.fecha = (SELECT MAX(menu_precio.fecha) FROM menu_precio) ";
                        consulta += "AND m.id_menu = @valFiltro; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@valFiltro", valFiltro);
                            
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    menu = new Menu(rol)
                                    {
                                        Id = reader.GetInt32("id_menu"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        Congelable = reader.GetInt32("congelable"),
                                        StockMin = reader.GetInt32("lote_max"),
                                        StockMax = reader.GetInt32("lote_min"),
                                        Tipo = reader.GetString("tipo_menu"),
                                        Precio = reader.GetDouble("valor"),
                                        DietasSTR = reader.GetString("dietas")
                                    };
                                    if (!reader.IsDBNull(reader.GetOrdinal("sugerencia")))
                                        menu.Sugerencia = reader.GetString("sugerencia");
                                    else
                                        menu.Sugerencia = "";
                                    menus.Add(menu);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error MenuBD #3: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return menus;
        }

        public List<Menu> filtrarMenuPorTipo(string valFiltro)
        {
            menus = new List<Menu>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT m.id_menu, m.activo, m.autorizado, m.congelable, m.lote_max, m.lote_min, m.sugerencia, m.tipo_menu, mp.valor, d.dietas ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN menu_precio mp ON m.id_menu = mp.id_menu ";
                        consulta += "JOIN ( ";
                        consulta += "SELECT m.id_menu, GROUP_CONCAT(' ', d.nombre) AS dietas ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN pertenece p ON p.id_menu = m.id_menu ";
                        consulta += "JOIN dieta d ON d.id_dieta = p.id_dieta ";
                        consulta += "GROUP BY m.id_menu ";
                        consulta += ") d ON d.id_menu = m.id_menu ";
                        consulta += "WHERE mp.fecha = (SELECT MAX(menu_precio.fecha) FROM menu_precio) ";
                        consulta += "AND m.tipo_menu = @valFiltro; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@valFiltro", valFiltro);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    menu = new Menu(rol)
                                    {
                                        Id = reader.GetInt32("id_menu"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        Congelable = reader.GetInt32("congelable"),
                                        StockMin = reader.GetInt32("lote_max"),
                                        StockMax = reader.GetInt32("lote_min"),
                                        Tipo = reader.GetString("tipo_menu"),
                                        Precio = reader.GetDouble("valor"),
                                        DietasSTR = reader.GetString("dietas")
                                    };
                                    if (!reader.IsDBNull(reader.GetOrdinal("sugerencia")))
                                        menu.Sugerencia = reader.GetString("sugerencia");
                                    else
                                        menu.Sugerencia = "";
                                    menus.Add(menu);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error MenuBD #3: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return menus;
        }

        public List<Menu> filtrarMenuPorAutorizado(bool valFiltro)
        {
            menus = new List<Menu>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT m.id_menu, m.activo, m.autorizado, m.congelable, m.lote_max, m.lote_min, m.sugerencia, m.tipo_menu, mp.valor, d.dietas ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN menu_precio mp ON m.id_menu = mp.id_menu ";
                        consulta += "JOIN ( ";
                        consulta += "SELECT m.id_menu, GROUP_CONCAT(' ', d.nombre) AS dietas ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN pertenece p ON p.id_menu = m.id_menu ";
                        consulta += "JOIN dieta d ON d.id_dieta = p.id_dieta ";
                        consulta += "GROUP BY m.id_menu ";
                        consulta += ") d ON d.id_menu = m.id_menu ";
                        consulta += "WHERE mp.fecha = (SELECT MAX(menu_precio.fecha) FROM menu_precio) ";
                        consulta += "AND m.autorizado = @valFiltro; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@valFiltro", valFiltro);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    menu = new Menu(rol)
                                    {
                                        Id = reader.GetInt32("id_menu"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        Congelable = reader.GetInt32("congelable"),
                                        StockMin = reader.GetInt32("lote_max"),
                                        StockMax = reader.GetInt32("lote_min"),
                                        Tipo = reader.GetString("tipo_menu"),
                                        Precio = reader.GetDouble("valor"),
                                        DietasSTR = reader.GetString("dietas")
                                    };
                                    if (!reader.IsDBNull(reader.GetOrdinal("sugerencia")))
                                        menu.Sugerencia = reader.GetString("sugerencia");
                                    else
                                        menu.Sugerencia = "";
                                    menus.Add(menu);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error MenuBD #3: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return menus;
        }

        public List<Menu> filtrarMenuPorActivo(bool valFiltro)
        {
            menus = new List<Menu>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT m.id_menu, m.activo, m.autorizado, m.congelable, m.lote_max, m.lote_min, m.sugerencia, m.tipo_menu, mp.valor, d.dietas ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN menu_precio mp ON m.id_menu = mp.id_menu ";
                        consulta += "JOIN ( ";
                        consulta += "SELECT m.id_menu, GROUP_CONCAT(' ', d.nombre) AS dietas ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN pertenece p ON p.id_menu = m.id_menu ";
                        consulta += "JOIN dieta d ON d.id_dieta = p.id_dieta ";
                        consulta += "GROUP BY m.id_menu ";
                        consulta += ") d ON d.id_menu = m.id_menu ";
                        consulta += "WHERE mp.fecha = (SELECT MAX(menu_precio.fecha) FROM menu_precio) ";
                        consulta += "AND m.activo = @valFiltro; ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@valFiltro", valFiltro);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    menu = new Menu(rol)
                                    {
                                        Id = reader.GetInt32("id_menu"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        Congelable = reader.GetInt32("congelable"),
                                        StockMin = reader.GetInt32("lote_max"),
                                        StockMax = reader.GetInt32("lote_min"),
                                        Tipo = reader.GetString("tipo_menu"),
                                        Precio = reader.GetDouble("valor"),
                                        DietasSTR = reader.GetString("dietas")
                                    };
                                    if (!reader.IsDBNull(reader.GetOrdinal("sugerencia")))
                                        menu.Sugerencia = reader.GetString("sugerencia");
                                    else
                                        menu.Sugerencia = "";
                                    menus.Add(menu);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error MenuBD #3: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return menus;
        }


        public List<Menu> filtrarMenuPorDietas(List<string> valFiltro)
        {
            menus = new List<Menu>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT m.id_menu, m.activo, m.autorizado, m.congelable, m.lote_max, m.lote_min, m.sugerencia, m.tipo_menu, mp.valor, d.dietas ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN menu_precio mp ON m.id_menu = mp.id_menu ";
                        consulta += "JOIN ( ";
                        consulta += "SELECT m.id_menu, GROUP_CONCAT(' ', d.nombre) AS dietas ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN pertenece p ON p.id_menu = m.id_menu ";
                        consulta += "JOIN dieta d ON d.id_dieta = p.id_dieta ";
                        consulta += "WHERE d.nombre IN (";
                        for (int i = 0; i < valFiltro.Count; i++)
                        {
                            consulta += (i > 0 ? ", " : "") + $"@param{i}";
                        }
                        consulta += ") ";
                        consulta += "GROUP BY m.id_menu ";
                        consulta += ") d ON d.id_menu = m.id_menu ";
                        consulta += "WHERE mp.fecha = (SELECT MAX(menu_precio.fecha) FROM menu_precio);";

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
                                    menu = new Menu(rol)
                                    {
                                        Id = reader.GetInt32("id_menu"),
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        Congelable = reader.GetInt32("congelable"),
                                        StockMin = reader.GetInt32("lote_max"),
                                        StockMax = reader.GetInt32("lote_min"),
                                        Tipo = reader.GetString("tipo_menu"),
                                        Precio = reader.GetDouble("valor"),
                                        DietasSTR = reader.GetString("dietas")
                                    };
                                    if (!reader.IsDBNull(reader.GetOrdinal("sugerencia")))
                                        menu.Sugerencia = reader.GetString("sugerencia");
                                    else
                                        menu.Sugerencia = "";
                                    menus.Add(menu);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error MenuBD #3: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return menus;
        }




        public Menu obtenerDatosMenu(int idMenu)
        {
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta  = "SELECT DISTINCT m.id_menu, m.activo, m.autorizado, m.congelable, m.lote_max, ";
                        consulta += "m.lote_min, m.sugerencia, m.tipo_menu, mp.valor, i.personalizado, p.cantidad ";
                        consulta += "FROM menu m ";
                        consulta += "JOIN menu_precio mp ON m.id_menu = mp.id_menu ";
                        consulta += "JOIN integra i ON i.id_menu = m.id_menu ";
                        consulta += "JOIN produccion p ON p.id_menu = m.id_menu ";
                        consulta += "WHERE m.id_menu = @id ";
                        consulta += "AND mp.fecha = (SELECT MAX(menu_precio.fecha) FROM menu_precio); ";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idMenu);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    menu = new Menu(rol)
                                    {
                                        Activo = reader.GetBoolean("activo"),
                                        Autorizado = reader.GetBoolean("autorizado"),
                                        Congelable = reader.GetInt32("congelable"),
                                        StockMin = reader.GetInt32("lote_max"),
                                        StockMax = reader.GetInt32("lote_min"),
                                        Tipo = reader.GetString("tipo_menu"),
                                        Precio = reader.GetDouble("valor"),
                                        Personalizado = reader.GetBoolean("personalizado"),
                                        StockActual = reader.GetInt32("cantidad")
                                    };
                                    if (!reader.IsDBNull(reader.GetOrdinal("sugerencia")))
                                        menu.Sugerencia = reader.GetString("sugerencia");
                                    else
                                        menu.Sugerencia = string.Empty;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error MenuBD #obtenerDatosMenu: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return menu;
        }

    }
}
