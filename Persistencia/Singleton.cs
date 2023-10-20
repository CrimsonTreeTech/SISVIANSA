using System;
using System.Configuration;
using MySqlConnector;

namespace SISVIANSA_ITI_2023.Persistencia
{
    public class Singleton : IDisposable
    {
        private MySqlConnection conexion;
        private static Singleton instanciaBD = null;

        private string cadena, conexionRol;

        // ------------- CONSTRUCTOR --------------------
        private Singleton() { }

        // -------------- Implementación de IDisposable ----------------
        public void Dispose()
        {
            if (conexion != null)
            {
                CerrarConexion();
            }
        }


        // --------------- METODOS DE CONEXION -------------------------
        public MySqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }

        public static Singleton RecuperarInstancia()
        {
            if (instanciaBD == null)
                instanciaBD = new Singleton();

            return instanciaBD;
        }

        public bool Conectar(int rol)
        {
            conexionRol = ConexionSegunRol(rol);
            if (conexion == null || conexion.State == System.Data.ConnectionState.Closed)
            {
                Conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings[conexionRol].ConnectionString);
                conexion.Open();
            }
            return true;
        }

        public void CerrarConexion()
        {
            if (conexion != null && conexion.State != System.Data.ConnectionState.Closed)
            {
                conexion.Close();
            }
        }

        private string ConexionSegunRol(int rol)
        {
            cadena = null;
            switch (rol)
            {
                case 1: cadena = "conexionGerente"; break;
                case 2: cadena = "conexionCocina"; break;
                case 3: cadena = "conexionAdmin"; break;
                case 4: cadena = "conexionATC"; break;
                case 5: cadena = "conexionTransporte"; break;
                case 6: cadena = "conexionInformatico"; break;
            }
            return cadena;
        }
    }
}
