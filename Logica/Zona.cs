using SISVIANSA_ITI_2023.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVIANSA_ITI_2023.Logica
{
    public class Zona
    {
        private byte rol;
        private int id;
        private bool activo, autorizado;
        private double precio;
        private List<string> barrios;
        private ZonaBD zonaBD;
        private List<Zona> zonas;


        public Zona() { }

        public Zona(byte rol)
        {
            this.rol = rol;
            zonaBD = new ZonaBD(rol);
        }

        // --------------------------- GETTERS Y SETTERS -----------------------------------------
        public int Id
        {
            get { return id; }
            set {  id = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public bool Autorizado
        {
            get { return autorizado; }
            set { autorizado = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public List<string> Barrios
        {
            get { return barrios; }
            set { barrios = value; }
        }


        // ---------------------- VALIDACIO DE DATOS ----------------------------------------------
        public bool validarNombre(string nombre)
        {
            return !String.IsNullOrEmpty(nombre);
        }
        
        public bool validarPrecio(string precio)
        {
            try
            {
                double precioNumerico = Double.Parse(precio);
                return precioNumerico > 0;
            }
            catch
            {
                return false;
            }
        }
        
        public bool validarBarrio(string barrio)
        {
            return !String.IsNullOrEmpty(barrio);
        }

        public bool validarBarriosZona(List<string> barrios)
        {
            return barrios.Count() > 0;
        }


        // ------------------------- METODOS AUXILIARES -------------------------------------------
        public List<Zona> convertirListaDeZonas(List<string> zonasSeleccionadas)
        {
            List<Zona> zonasDeReparto = new List<Zona>();

            foreach (string item in zonasSeleccionadas)
            {
                Zona zona = new Zona{
                    Id = Int32.Parse(item.Split("Zona ")[1])
                };
                zonasDeReparto.Add(zona);
            }
            return zonasDeReparto;
        }




        // ------------------------- ABM -------------------------------------------
        public bool ingresar()
        {
            bool zonaIngresada = zonaBD.ingresarNuevaZona();

            int id;
            if (zonaIngresada)
                id = zonaBD.ultimoIdIngresado();
            else
                return false;


            bool precioIngresado = zonaBD.ingresarPrecioZona(id, Precio);

            bool zonasIngresadas = true;
            foreach (string barrio in Barrios)
            {
                if (zonasIngresadas)
                    zonasIngresadas = zonaBD.ingresarBarrioZona(id, barrio);
            }

            return precioIngresado && zonasIngresadas;
        }

        public bool modificar()
        {
            return true;
        }


        // ------------------------ CONSULTAS ------------------------------
        public List<Zona> todasLasZonas()
        {
            return zonaBD.todasLasZonas();
        }

        public List<string> listadoZonasTexto()
        {
            List<string> listaZonas = new List<string>();
            foreach (Zona zona in zonaBD.todasLasZonas())
            {
                string cadena = "Zona " + zona.Id.ToString();
                listaZonas.Add(cadena);
            }
            return listaZonas;
        }

        public List<string> barriosDeZona(string zona)
        {
            int idZona = Int32.Parse(zona.Split("Zona ")[1]);
            //return zonaBD.obtenerBarriosDeZona(idZona);
            List<string> lista = zonaBD.obtenerBarriosDeZona(idZona);

            //MessageBox.Show(lista.Count.ToString());

            return lista;
        }

        public double obtenerPrecio(int id)
        {
            return zonaBD.obtenerPrecio(id);
        }


        // --------------------------------------------------------------------
        public List<string> obtenerZonas()
        {
            return zonaBD.obtenerZonas();
        }

    }
}
