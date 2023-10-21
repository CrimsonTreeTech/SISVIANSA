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
        private byte rol, nivelDeError;
        private int idMenu, loteMin, cantidadEnStock, loteMax, prodMenu, cantAProducir;
        private int? prioridad;
        private bool correcto;
        private List<Produccion> listaProduccion = null;
        private List<int> todasLasPrioridades, prioridadesUnicas;
        private ProduccionBD produccionBD;

        // Variables utilizadas para calcular cantidad de produccion
        private int minutosDeProduccion, tiempoProduccionDelMenu, prioridadINT, capProdSobrante;
       

        // ---------- CONSTRUCTOR -----------
        public Produccion(byte rol)
        {
            this.rol = rol;
            produccionBD = new ProduccionBD(rol);
            todasLasPrioridades = new List<int>();
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

        public int CantidadEnStock
        {
            get { return cantidadEnStock; }
            set { cantidadEnStock = value; }
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
        public bool noTieneBajoStock()
        {
            correcto =  LoteMin < CantidadEnStock;
            return correcto;
        }

        public byte validarListadoDeProduccion(string capProd)
        {
            nivelDeError = 0;
            capProdSobrante = Convert.ToInt32(capProd);

            if (capProdSobrante > 120) // Indica infraproduccion
            {
                nivelDeError = 1;
            }
            else if (capProdSobrante < -120) // Indica sobreproduccion
            {
                nivelDeError = 2;
            }

            return nivelDeError;
        }

        public bool comprobarValorPrioridad(string prioridadSTR)
        {
            correcto = true;
            try
            {
                prioridad = Convert.ToInt32(prioridadSTR);
                correcto = prioridad > 0;
            }
            catch
            {
                correcto = false;
            }
            return correcto;
        }

        public bool comprobarValorCantidadAProducir(string cantAProducirSTR, int maxStock)
        {
            correcto = true;
            try
            {
                cantAProducir = Convert.ToInt32(cantAProducirSTR);
                correcto = cantAProducir > 0 && cantAProducir < maxStock;
            }
            catch
            {
                correcto = false;
            }
            return correcto;
        }

        public int calcularCapProdActualDeSucursal(List<Produccion> listaProduccion, int capProdSucursal)
        {
            minutosDeProduccion = 0; // Variable que almacenara la suma de los minutos de produccion de los menus

            // Recorrer lista de produccion
            foreach (Produccion item in listaProduccion)
            {
                // Multiplicar el valor de produccion del menu por la cantidad a producir
                tiempoProduccionDelMenu = item.ProdMenu * item.CantAProducir;
                // Guardar el valor en una variable
                minutosDeProduccion += tiempoProduccionDelMenu;
            }
            // Restar los minutos de produccion para el menu de los minutos de produccion totales
            capProdSucursal = capProdSucursal - minutosDeProduccion;

            // Devolver el valor de la capacidad de produccion actual
            return capProdSucursal;
        }



    }
}
