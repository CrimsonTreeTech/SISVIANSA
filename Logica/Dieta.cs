using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.GUI;
using SISVIANSA_ITI_2023.Persistencia;

namespace SISVIANSA_ITI_2023.Logica
{
    public class Dieta
    {
        private byte rol;
        private int id;
        private string nombre, descripcion;
        private bool activo, autorizado;
        private DietaBD dietaBD;
        private List<Dieta> listaDietas;
        private List<string> nombreDietas;

        // ------------------ CONSTRUCTOR ---------------------
        public Dieta(byte rol)
        {
            dietaBD = new DietaBD(rol);
            this.rol = rol;
        }


        // --------------- GETTERS Y SETTERS ---------------------
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

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
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


        // -------------- VALIDACION DE DATOS -----------------
        public bool campoNoVacio(string str)
        {
            return !String.IsNullOrEmpty(str);
        }



        // ----------------- ABM --------------------
        public bool ingresar()
        {
            return true;
        }

        public bool modificar()
        {
            return true;
        }


        // --------------------- CONSULTAS --------------------
        public List<string> nombresDeDietas()
        {
            nombreDietas = new List<string>();
            listaDietas = dietaBD.dietasAutorizadasYActivas();
            foreach (Dieta dieta in listaDietas)
            {
                if (dieta.Activo)
                {
                    nombreDietas.Add(dieta.Nombre);
                }
            }
            return nombreDietas;
        }

        public List<Dieta> todasLasDietas()
        {
            return dietaBD.todasLasDietas(); ;
        }

        public List<Dieta> dietasAutorizadasYActivas()
        {
            return dietaBD.dietasAutorizadasYActivas();
        }

        public List<Dieta> busquedaFiltrada(string colFiltro)
        {
            listaDietas = new List<Dieta>();

            if (colFiltro.Equals("todo"))
            {
                listaDietas = dietaBD.todasLasDietas();
            }
            
            else if (colFiltro.Equals("activo y autorizado"))
            {
                listaDietas = dietaBD.dietasAutorizadasYActivas();
            }

            else if (colFiltro.Equals("inactivo"))
            {
                listaDietas = dietaBD.dietasInactivas();
            }

            else if (colFiltro.Equals("no autorizado"))
            {
                listaDietas = dietaBD.dietasNoAutorizadas();
            }

            return listaDietas;
        }

    }
}
