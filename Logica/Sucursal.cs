using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Persistencia;

namespace SISVIANSA_ITI_2023.Logica
{
    public class Sucursal
    {
        byte rol;

        int id, capProd;
        bool activo;
        string meta;
        List<Zona> zonas;

        SucursalBD sucursalBD;
        ZonaBD zonaBD;
        List<string> listTemporalZonasSuc = new List<string>();

        // ----------------------- CONSTRUCTOR ---------------------
        public Sucursal(byte rol)
        {
            this.rol = rol;
            sucursalBD = new SucursalBD(rol);
            zonaBD = new ZonaBD(rol);
        }


        // ---------------------- GETTERS Y SETTERS ---------------------
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int CapProd
        {
            get { return capProd; }
            set { capProd = value; }
        }

        public string Meta
        {
            get { return meta; }
            set { meta = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
        
        public List<Zona> Zonas
        {
            get { return zonas;  }
            set { zonas = value; }
        }

        // ----------------------- METODOS DE VALIDACION --------------------------------
        public bool validarNombre(string nombre)
        {
            return !String.IsNullOrEmpty(nombre);
        }

        public bool validarCapProd(string capProd)
        {
            try
            {
                int cap = Int32.Parse(capProd);
                return cap > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool validarZonasSuc(List<string> zonas)
        {
            return zonas.Count > 0;
        }



        // ------------------------ METODOS AUXILIARES ----------------------------
        
        public int almacenamientoPorEstado(string estado)
        {
            return 1;
        }



        // -------------------------- CONSULTAS -----------------------------
        public List<Zona> obtenerZonas()
        {
            return new List<Zona>();
        }

        public string obtenerMeta() 
        {
            return "a";
        }

        public List<Sucursal> todasLasSucursales()
        {
            return sucursalBD.obtenerSucursales();
        }

        public List<Sucursal> todasLasSucursalesActivas()
        {
            return sucursalBD.obtenerSucursalesActivas();
        }

        public int obtenerCapProdScursal(int idSucursal)
        {
            return sucursalBD.obtenerCapProdScursal(idSucursal);
        }



        public bool baja(int idSucursal)
        {
            return sucursalBD.altaBajaSucursal(idSucursal, false);
        }

        public bool alta(int idSucursal)
        {
            return sucursalBD.altaBajaSucursal(idSucursal, true);
        }


        /////////////////////////////////////////////////////////////////////////////////////


        public void agregarZonaSucTemporal(string zona)
        {
            listTemporalZonasSuc.Add(zona);
        }

        public void quitarZonaSucTemporal(string zona)
        {
            listTemporalZonasSuc.Remove(zona);
        }

        public List<string> listaTemporalZonasSuc()
        {
            return listTemporalZonasSuc;
        }

        public List<string> listaZonasDisponibles()
        {
            List<string> zonasDisponibles = zonaBD.obtenerZonas();

            foreach (var item in listTemporalZonasSuc)
            {
                if (zonasDisponibles.Contains(item))
                    zonasDisponibles.Remove(item);
            }
            return zonasDisponibles;
        }

        
    
        
    }
}
