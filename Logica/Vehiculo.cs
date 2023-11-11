using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.GUI;
using SISVIANSA_ITI_2023.Persistencia;

namespace SISVIANSA_ITI_2023.Logica
{
    public class Vehiculo
    {
        byte rol;
        string matricula;
        int id, capCarga;
        bool activo;

        VehiculosBD vehiculoBD;
        ZonaBD zonaBD;
        List<Zona> listaZonasDeReparto;

        List<int> listaTemporal = new List<int>();


        // --------------- CONSTRUCTORES ------------------------
        public Vehiculo(byte rol)
        { 
            this.rol = rol;
            vehiculoBD = new VehiculosBD(rol);
            zonaBD = new ZonaBD(rol);
        }

        

        // --------------- GETTERS y SETTERS ------------------------
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public int CapCarga
        {
            get { return capCarga; }
            set { capCarga = value; }
        }

        public List<Zona> ListaZonasDeReparto
        {
            get { return listaZonasDeReparto; }
            set { listaZonasDeReparto = value;  }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
        
        // ------------------- VALIDACION DE DATOS -----------------------
        public bool verificarCarga(string carga)
        {
            if (esNumero(carga))
            {
                int valorCarga = Int32.Parse(carga);
                return valorCarga > 0;
            }
            return false;
        }

        public bool verificarMatricula(string matricula)
        {
            bool largoMatriula = matricula.Length == 7;
            if (largoMatriula)
            {
                bool tresLEtras = primerasTresLetras(matricula);
                bool cuatroNumeros = ultimosCuatroDigitosMatricula(matricula);
                return tresLEtras && cuatroNumeros;
            }
            else
            {
                return false;
            }

        }

        private bool primerasTresLetras(string matricula)
        {
            string letras = matricula.Substring(0, 3);
            bool sonLetras = !esNumero(letras);
            return sonLetras;
        }

        private bool ultimosCuatroDigitosMatricula(string matricula)
        {
            string ultimosCuatroDigitos = matricula.Substring(3, 4);
            bool sonNumeros = esNumero(ultimosCuatroDigitos);
            return sonNumeros;
        }

        private bool esNumero(string str)
        {
            try
            {
                Int32.Parse(str);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }




        // ------------------- CONSULTAS ------------------------
        public List<Vehiculo> obtenerVehiculos()
        {
            return vehiculoBD.listaVehiculos();
        }

        public List<Vehiculo> filtrarPorMatricula(string matricula)
        {
            return vehiculoBD.filtrarPorMatricula(matricula);
        }

        public List<Vehiculo> filtrarPorZona(string zonaSeleccionada)
        {
            string idZonaSeleccionada = zonaSeleccionada.Split("Zona ")[1];
            int indexSeleciconado = Int32.Parse(idZonaSeleccionada);
            return vehiculoBD.filtrarPorZona(indexSeleciconado);
        }

        public void obtenerZonasReparto()
        {
            ListaZonasDeReparto = zonaBD.zonasDeRepartoDeVehiculo(Id);
        }

        
        
        // ------------------------ ABM ----------------------------------
        public bool ingresar()
        {
            return vehiculoBD.ingresarVehiculo(this);
        }

        public bool ingresarZonas()
        {
            bool zonasIngresadas = false;

            try
            {
                foreach (Zona zona in ListaZonasDeReparto)
                {
                    vehiculoBD.ingresarZonasReparto(Id, zona.Id);
                }
                zonasIngresadas = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return zonasIngresadas;
        }

        public bool bajaAlta(bool activo)
        {
            return vehiculoBD.bajaAltaVehiculo(Id, activo);
        }



        // --------------- METODOS AUXILIARES ------------------------      
        // Agregar zona a la lista de zonas seleccionadas temporales
        public void agregarZonaTemporal(string zona)
        {
            int id = Int32.Parse(zona.Split("Zona ")[1]);
            listaTemporal.Add(id);
        }

        // Quitar zona a la lista de zonas seleccionadas temporales
        public void quitarZonaTemporal(string zona)
        {
            int id = Int32.Parse(zona.Split("Zona ")[1]);
            listaTemporal.Remove(id);
        }

        // Obtener lista zonas seleccionadas temporales
        public List<string> zonasSeleccionadasTemporales()
        {
            List<string> zonasTemporales = new List<string>();
            foreach (var item in listaTemporal)
            {
                string cadena = "Zona " + item.ToString();
                zonasTemporales.Add(cadena);
            }
            return zonasTemporales;
        }

        // Obtener lista zonas seleccionadas temporales
        public List<string> zonasDisponiblesTemporales()
        {
            List<string> zonasDisponiblesTemp = new List<string>();

            List<Zona> todasLasZonas = zonaBD.todasLasZonas();

            foreach (var item in todasLasZonas)
            {
                int idZona = item.Id;
                string cadena = "Zona " + idZona.ToString();
                zonasDisponiblesTemp.Add(cadena);
            }

            foreach (string seleccionada in zonasSeleccionadasTemporales())
            {
                if (zonasDisponiblesTemp.Contains(seleccionada))
                    zonasDisponiblesTemp.Remove(seleccionada);
            }

            return zonasDisponiblesTemp;
        }


    }
}
