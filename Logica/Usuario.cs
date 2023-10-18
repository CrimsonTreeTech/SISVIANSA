using Org.BouncyCastle.Crypto.Agreement.Srp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Persistencia;
using Microsoft.VisualBasic.ApplicationServices;
using SISVIANSA_ITI_2023.Persistencia;
using ZstdSharp.Unsafe;

namespace SISVIANSA_ITI_2023.Logica
{
    public class Usuario
    {
        UsuarioBD usuarioBD;
        private int id;
        private string nombre;
        private string contrasenia;
        private string rol;
        private bool activo;
        private byte byteRol;
        private List<Usuario> usuarios;


        // ------------------ CONSTRUCTOR ----------------------
        public Usuario(byte byteRol)
        {
            this.byteRol = byteRol;
            usuarioBD = new UsuarioBD(byteRol);
        }

        // --------------------------- GETTERS Y SETTERS --------------------------------

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }



        // ----------------------------- VALIDACION DE DATOS -------------------------------------
        public bool validarUsuario(string usuario)
        {
            return !String.IsNullOrEmpty(usuario);
        }

        public bool validarPassword(string pwd, string confirmPwd)
        {
            if (!String.IsNullOrEmpty(pwd))
                return pwd.Equals(confirmPwd);
            else
                return false;
        }

        public bool validarRol(string rol)
        {
            return !String.IsNullOrEmpty(rol);
        }



        // ---------------------- INGRESO DE SESION DE USUARIO -----------------------
        public byte comprobarCredenciales(string user, string passwrd)
        {
            rol = usuarioBD.comprobarCredenciales(user, passwrd);
            byteRol = nroRol(rol);
            return byteRol;
        }

        private byte nroRol(string rol)
        {
            if (rol.Equals("Gerente"))
                return 1;
            else if (rol.Equals("Jefe de cocina"))
                return 2;
            else if (rol.Equals("Administrativo"))
                return 3;
            else if (rol.Equals("Atencion al cliente"))
                return 4;
            else if (rol.Equals("Transporte"))
                return 5;
            else if (rol.Equals("Informatico"))
                return 6;
            else
                return 0;
        }


        // ------------------------------------- ABM -------------------------------------------
        public bool ingresar()
        {
            return usuarioBD.ingresarUsuario(this);
        }

        public bool altaBaja(bool activo)
        {
            return usuarioBD.altaBajaUsuario(this.id, activo);
        }

        public bool modificar()
        {
            return usuarioBD.modificarUsuario(this);
        }


        // ------------------------------- CONSULTAS ----------------------------------
        public List<Usuario> filtrarListaUsuarios(string filtro, string condicion)
        {
            usuarios = new List<Usuario>();

            if (filtro.Equals("Usuario"))
            {
                usuarios = usuarioBD.filtrarUsuariosNombre(condicion);
            }
            else if (filtro.Equals("Rol"))
            {
                usuarios = usuarioBD.filtrarUsuariosRol(condicion);
            }
            else if (filtro.Equals("Activo"))
            {
                usuarios = usuarioBD.filtrarUsuariosActivo(true);
            }
            else if (filtro.Equals("Inactivo"))
            {
                usuarios = usuarioBD.filtrarUsuariosActivo(false);
            }
            else if (filtro.Equals("Todo"))
            {
                usuarios = usuarioBD.obtenerListaUsuarios();
            }

            return usuarios;
        }

    }
}
