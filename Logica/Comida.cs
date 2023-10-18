﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Persistencia;

namespace SISVIANSA_ITI_2023.Logica
{
    public class Comida
    {
        private byte rol;
        private string nombre;
        private int id, coccion;
        private bool activo, autorizado;
        private Dieta dieta;
        private ComidasBD comidaBD;
        private DietaBD dietaBD;
        private List<Dieta> dietas;
        private List<string> nombreDietasDisponibles;
        private List<string> listaDietasSeleccionadas = new List<string>();


        // -------------------- CONSTRUCTOR ----------------------
        public Comida(byte rol)
        {
            this.rol = rol;
            dieta = new Dieta(rol);
            comidaBD = new ComidasBD(rol);
            dietaBD = new DietaBD(rol);
        }


        // ----------------------- GETTERS Y SETTERS -------------------------------
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

        public int Coccion
        {
            get { return coccion; }
            set { coccion = value; }
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

        public List<Dieta> Dietas
        {
            get { return dietas; }
            set { dietas = value; }
        }

        // ---------- VALIDACIONES -----------
        public bool validarNombre(string nombre)
        {
            return !String.IsNullOrEmpty(nombre);
        }

        public bool validarDietas(List<string> dietas)
        {
            return dietas.Count() > 0;
        }

        public bool validarCoccion(string coccion)
        {
            try
            {
                int tiempoCoccion = Int32.Parse(coccion);
                return tiempoCoccion > 0;
            }
            catch
            {
                return false;
            }
        }

        // --------------------- ABM ----------------------
        public bool ingresar()
        {
            return true;
        }

        public bool modificar()
        {
            return true;
        }


        // ---------------------- CONSULTAS --------------------------
        public List<Comida> listaDeComidas()
        {
            return comidaBD.listaDeComidas();
        }

        // ------------ DIETAS DE LA COMIDA ----------------
        public void cargarDietasAObjetoComida()
        {
            Dietas = dietaBD.obtenerDietasDeComida(Id);
        }

        public void actualizarListaDeDietas(List<string> lista)
        {
            this.dietas = new List<Dieta>();
        }

        

        

        // ------------------ METODOS LISTA TEMPORAL DE DIETAS SELECCIONADAS ----------------
        public List<string> dietasDisponibles()
        {
            nombreDietasDisponibles = dieta.nombresDeDietas();
            
            foreach (string dieta in listaDietasSeleccionadas)
            {
                if(nombreDietasDisponibles.Contains(dieta))
                    nombreDietasDisponibles.Remove(dieta);
            }
            return nombreDietasDisponibles;
        }

        

        public void agregarDieta(string dieta)
        {
            listaDietasSeleccionadas.Add(dieta);
        }

        public void quitarDieta(string dieta)
        {
            listaDietasSeleccionadas.Remove(dieta);
        }

        public List<string> dietasSeleccionadas()
        {
            return listaDietasSeleccionadas;
        }

    }
}
