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

        public Menu obtenerDatosMenu(int idMenu)
        {
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT menu.id_menu, menu.activo, menu.autorizado, menu.congelable, menu.lote_max, menu.lote_min, menu.prioridad, menu.stock_actual, menu.sugerencia, menu.tipo_menu, menu_precio.valor FROM menu JOIN menu_precio ON menu.id_menu = menu_precio.id_menu WHERE menu.id_menu = @id AND menu_precio.fecha = (SELECT MAX(menu_precio.fecha) FROM menu_precio);";

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
                                        Prioridad = reader.GetInt32("prioridad"),
                                        StockActual = reader.GetInt32("stock_actual"),
                                        Tipo = reader.GetString("tipo_menu"),
                                        Precio = reader.GetDouble("valor")
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
                MessageBox.Show("Error MenuBD #4: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return menu;
        }

    }
}
