using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Org.BouncyCastle.Crypto.Tls;
using SISVIANSA_ITI_2023.Logica;

namespace SISVIANSA_ITI_2023.Persistencia
{
    internal class UsuarioBD
    {
        private byte rol;
        private Singleton bd;
        private string claveAdmin = "clave_de_admin_1234";

        private string consulta, nombreRol;
        private int filasAfectadas;
        private Usuario usuario;
        private List<Usuario> usuarios;

        // ---------------------------- METODOS AL INICIAR ------------------------------
        public UsuarioBD(byte rol)
        {
            this.rol = rol;
        }


        // -------------------------- CONSULTAS -----------------------------
        public string comprobarCredenciales(string user, string pwd)
        {
            nombreRol = "No encontrado";
            try
            {
                using(bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT rol FROM usuario WHERE user = @user AND aes_encrypt(@pwd, @claveAdmin) = usuario.password;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@user", user);
                            cmd.Parameters.AddWithValue("@pwd", pwd);
                            cmd.Parameters.AddWithValue("@claveAdmin", claveAdmin);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    nombreRol = reader.GetString("rol");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error UsuarioBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return nombreRol;
        }

        public List<Usuario> obtenerListaUsuarios()
        {
            usuarios = new List<Usuario>();
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(this.rol))
                    {
                        consulta = "SELECT id_user, user, rol, activo FROM usuario;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    usuario = new Usuario(rol)
                                    {
                                        Id = reader.GetInt32("id_user"),
                                        Nombre = reader.GetString("user"),
                                        Rol = reader.GetString("rol"),
                                        Activo = reader.GetBoolean("activo")
                                    };
                                    usuarios.Add(usuario);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error UsuarioBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return usuarios;
        }

        public List<Usuario> filtrarUsuariosNombre(string filtro)
        {
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_user, user, rol, activo FROM usuario WHERE user LIKE @filtro;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    usuario = new Usuario(rol)
                                    {
                                        Id = reader.GetInt32("id_user"),
                                        Nombre = reader.GetString("user"),
                                        Activo = reader.GetBoolean("activo"),
                                        Rol = reader.GetString("rol")
                                    };
                                    usuarios.Add(usuario);
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return usuarios;
        }

        public List<Usuario> filtrarUsuariosRol(string filtro)
        {
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_user, user, rol, activo FROM usuario WHERE rol LIKE @filtro;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    usuario = new Usuario(rol)
                                    {
                                        Id = reader.GetInt32("id_user"),
                                        Nombre = reader.GetString("user"),
                                        Activo = reader.GetBoolean("activo"),
                                        Rol = reader.GetString("rol")
                                    };
                                    usuarios.Add(usuario);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return usuarios;
        }

        public List<Usuario> filtrarUsuariosActivo(bool filtro)
        {
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "SELECT id_user, user, rol, activo FROM usuario WHERE activo LIKE @filtro;";
                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@filtro", filtro);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    usuario = new Usuario(rol)
                                    {
                                        Id = reader.GetInt32("id_user"),
                                        Nombre = reader.GetString("user"),
                                        Activo = reader.GetBoolean("activo"),
                                        Rol = reader.GetString("rol")
                                    };
                                    usuarios.Add(usuario);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return usuarios;
        }


        // --------------------------- ABM -----------------------------
        public bool ingresarUsuario(Usuario usuario)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(this.rol))
                    {
                        consulta = "INSERT INTO usuario (id_user, user, password, rol, activo) VALUES (null, @user, aes_encrypt(@pwd, @clave), @rol, true);";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@user", usuario.Nombre);
                            cmd.Parameters.AddWithValue("@pwd", usuario.Contrasenia);
                            cmd.Parameters.AddWithValue("@clave", claveAdmin);
                            cmd.Parameters.AddWithValue("@rol", usuario.Rol);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error UsuarioBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }

        public bool altaBajaUsuario(int id, bool activo)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "UPDATE usuario SET activo = @activo WHERE id_user = @id;";

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
                MessageBox.Show("Error UsuarioBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }

        public bool modificarUsuario(Usuario usuario)
        {
            filasAfectadas = 0;
            try
            {
                using (bd = Singleton.RecuperarInstancia())
                {
                    if (bd.Conectar(rol))
                    {
                        consulta = "UPDATE usuario SET user=@user, password=aes_encrypt(@pwd, @claveAdmin), rol=@rol WHERE id_user=@id;";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, bd.Conexion))
                        {
                            cmd.Parameters.AddWithValue("@user", usuario.Nombre);
                            cmd.Parameters.AddWithValue("@pwd", usuario.Contrasenia);
                            cmd.Parameters.AddWithValue("@rol", usuario.Rol);
                            cmd.Parameters.AddWithValue("@id", usuario.Id);
                            cmd.Parameters.AddWithValue("@claveAdmin", claveAdmin);
                            filasAfectadas = cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error UsuarioBD: " + ex.Message);
            }
            finally
            {
                bd.CerrarConexion();
            }
            return filasAfectadas > 0;
        }


    }
}
