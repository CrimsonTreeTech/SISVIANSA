using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private List<Dieta> dietas;
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
            dietas = dietaBD.dietasAutorizadasYActivas();
            foreach (Dieta dieta in dietas)
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

    }
}
