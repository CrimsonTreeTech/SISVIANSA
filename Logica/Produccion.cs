using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Persistencia;


namespace SISVIANSA_ITI_2023.Logica
{
    public class Produccion
    {
        private byte rol;
        private int idMenu, loteMin, loteMax, cantidad, prodMenu, cantAProducir;
        private int? prioridad;
        private bool correcto;
        private List<Produccion> listaProduccion = null;
        private List<int> todasLasPrioridades;
        private ProduccionBD produccionBD;
       

        // ---------- CONSTRUCTOR -----------
        public Produccion(byte rol)
        {
            this.rol = rol;
            produccionBD = new ProduccionBD(rol);
        }

        // ------------ GETTERS Y SETTERS ---------------
        public int IdMenu
        {
            get { return idMenu; }
            set { idMenu = value; }
        }

        public int LoteMin
        {
            get { return loteMin; }
            set { loteMin = value; }
        }

        public int LoteMax
        {
            get { return loteMax; }
            set { loteMax = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public int? Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }

        public int ProdMenu
        {
            get { return prodMenu; }
            set { prodMenu = value; }
        }

        public int CantAProducir
        {
            get { return cantAProducir; }
            set { cantAProducir = value; }
        }

        public List<Produccion> ListaProduccion
        {
            get { return listaProduccion; }
            set {  listaProduccion = value; }
        }


        // ------------- CONSULTAS ------------------
        public void crearTablaTemporaProduccion(int idSucursal)
        {
            produccionBD.crearTablaTemporaProduccion(idSucursal);
        }

        public List<Produccion> listadoDeProduccion(int idSucursal)
        {
            return produccionBD.obtenerListadoProduccionDiaria(idSucursal);
        }


        // ------------- METODOS AUXILIARES --------------
        public bool calcularBajoStock()
        {
            return cantidad <= LoteMin;
        }

        /*
        public byte validarPrioridad(List<Produccion> listaProduccion)
        {
            if (valoresPrioridadCorrectos(listaProduccion))
                if(sinValoresDuplicados(listaProduccion))
                    return 0;
                else
                    return 1;
            else
                return 2;
        }
        */

        public bool comprobarInformacionValida(string prioridad)
        {
            try
            {
                int intPrioridad = Convert.ToInt32(prioridad);
                return intPrioridad > 0;
            }
            catch
            {
                return false;
            }
        }

        /*
        private bool sinValoresDuplicados(List<Produccion> listaProduccion)
        {
            correcto = true;
            todasLasPrioridades = listaDePrioridades(listaProduccion);
            for (int i = 0; i < todasLasPrioridades.Count; i++)
            {
                int elemento = todasLasPrioridades[i];
                todasLasPrioridades.Remove(todasLasPrioridades[i]);

                if (todasLasPrioridades.Contains(elemento))
                {
                    correcto = false;
                    break;
                }
            }
            return correcto;
        }
        */
        
        private bool valoresPrioridadCorrectos(List<Produccion> listaProduccion)
        {
            foreach (Produccion produccion in listaProduccion)
            {
                if (produccion.Prioridad < 1)
                    return false;
            }
            return true;
        }

        /*
        private List<int?> listaDePrioridades(List<Produccion> listaProduccion)
        {
            todasLasPrioridades = new List<int?>();
            foreach (Produccion produccion in listaProduccion)
            {
                todasLasPrioridades.Add(produccion.Prioridad);
            }
            return todasLasPrioridades;
        }
        */

    }
}
