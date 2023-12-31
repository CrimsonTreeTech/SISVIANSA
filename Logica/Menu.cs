﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.GUI;
using SISVIANSA_ITI_2023.Persistencia;

namespace SISVIANSA_ITI_2023.Logica
{
    public class Menu
    {
        private byte rol;
        private int id, stockMin, stockMax, congelable, stockActual, prioridad, tiempoElaboracion;
        private string tipo, sugerencia, dietasSTR; //strimg dietasSTR es para traer las dietas concatenadas y mostrarlas en una dgv
        private bool activo, autorizado, personalizado;
        private double precio;
        private Menu menu;
        private List<Dieta> dietas;
        private List<Comida> comidas;
        private List<Menu> listaMenus;
        private MenuBD menuBD;



        // ----------------------- GETTERS Y SETTERS ----------------------------
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int StockMin
        {
            get { return stockMin; }
            set { stockMin = value; }
        }

        public int StockMax
        {
            get { return stockMax; }
            set { stockMax = value; }
        }

        public int Congelable
        {
            get { return congelable; }
            set { congelable = value; }
        }

        public int StockActual
        {
            get { return stockActual; }
            set { stockActual = value; }
        }

        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }

        public int TiempoElaboracion
        {
            get { return tiempoElaboracion; }
            set { tiempoElaboracion = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Sugerencia
        {
            get { return sugerencia; }
            set { sugerencia = value; }
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

        public bool Personalizado
        {
            get { return personalizado; }
            set { personalizado = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public List<Dieta> Dietas
        {
            get { return dietas; }
            set { dietas = value; }
        }

        public List<Comida> Comidas
        {
            get { return comidas; }
            set { comidas = value; }
        }

        public string DietasSTR
        {
            get { return dietasSTR; }
            set { dietasSTR = value; }
        }


        // ----------------------- METODOS AL INICIAR --------------------------
        public Menu(byte rol)
        {
            menuBD = new MenuBD(rol);
        }


        // ------------------------ LISTAS TEMPORALES ----------------------------------
        public List<string> listaTemporalDeComidas(string comidaSeleccionada, List<string> listaMenuTemporal, string tipoMenu)
        {
            int maxLen = tamanioMenu(tipoMenu);
            int listLen = listaMenuTemporal.Count;

            if (listLen < maxLen)
                listaMenuTemporal.Add(comidaSeleccionada);

            return listaMenuTemporal;
        }



        // ------------------------------ ABM ----------------------------------
        public bool ingresar()
        {
            return menuBD.ingresasrMenu(this);
        }



        // ------------------------ CONSULTAS ---------------------------------
        public List<Menu> obtenerTodosLosMenu()
        {
            return menuBD.obtenerTodosLosMenu();
        }

        public void cargarDatosDeMenu(int idMenu)
        {
            Id = idMenu;
            StockMin = menuBD.obtenerDatosMenu(idMenu).StockMin; 
            StockMax = menuBD.obtenerDatosMenu(idMenu).StockMax; 
            Congelable = menuBD.obtenerDatosMenu(idMenu).Congelable;
            StockActual = menuBD.obtenerDatosMenu(idMenu).StockActual;
            Tipo = menuBD.obtenerDatosMenu(idMenu).Tipo; 
            Sugerencia = menuBD.obtenerDatosMenu(idMenu).Sugerencia;
            Activo = menuBD.obtenerDatosMenu(idMenu).Activo;
            Autorizado = menuBD.obtenerDatosMenu(idMenu).Autorizado;
            Personalizado = menuBD.obtenerDatosMenu(idMenu).Personalizado;
            Precio = menuBD.obtenerDatosMenu(idMenu).Precio;
            Dietas = menuBD.obtenerDietasMenu(idMenu);
            Comidas = menuBD.obtenerComidasMenu(idMenu);
            TiempoElaboracion = calcularElaboracion();
        }

        public List<Menu> buscarMenuFiltrados(string colFiltro, List<string> valFiltro)
        {
            listaMenus = new List<Menu> ();

            if (colFiltro.Equals("todo"))
            {
                listaMenus = menuBD.obtenerTodosLosMenu();
            }

            else if (colFiltro.Equals("id"))
            {
                try
                {
                    id = Convert.ToInt32(valFiltro[0]);
                    listaMenus = menuBD.filtrarMenuPorId(id);
                }
                catch(Exception e)
                {
                    MessageBox.Show("No se selecciono un valor de filtro correcto.", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }

            else if (colFiltro.Equals("tipo"))
            {
                listaMenus = menuBD.filtrarMenuPorTipo(valFiltro[0]);
            }

            else if (colFiltro.Equals("autorizado"))
            {
                listaMenus = menuBD.filtrarMenuPorAutorizado(true);
            }

            else if (colFiltro.Equals("noAutorizado"))
            {
                listaMenus = menuBD.filtrarMenuPorAutorizado(false);
            }

            else if (colFiltro.Equals("activo"))
            {
                listaMenus = menuBD.filtrarMenuPorActivo(true);
            }

            else if (colFiltro.Equals("inactivo"))
            {
                listaMenus = menuBD.filtrarMenuPorActivo(false);
            }

            else if (colFiltro.Equals("dieta"))
            {
                listaMenus = menuBD.filtrarMenuPorDietas(valFiltro);
            }

            return listaMenus;
        }

        public List<Menu> buscarMenuFiltrados(string colFiltro, string valFiltro)
        {
            listaMenus = new List<Menu>();

            if (colFiltro.Equals("todo"))
            {
                listaMenus = menuBD.obtenerTodosLosMenu();
            }

            else if (colFiltro.Equals("id"))
            {
                id = Convert.ToInt32(valFiltro);
                listaMenus = menuBD.filtrarMenuPorId(id);
            }

            else if (colFiltro.Equals("tipo"))
            {
                listaMenus = menuBD.filtrarMenuPorTipo(valFiltro);
            }

            else if (colFiltro.Equals("dieta"))
            {
                List<string> listaValFiltro = new List<string>() { valFiltro };
                listaMenus = menuBD.filtrarMenuPorDietas(listaValFiltro);
            }

            return listaMenus;
        }

        public bool alta(int idMenu)
        {
            return menuBD.altaBajaMenu(idMenu, true);
        }

        public bool baja(int idMenu)
        {
            return menuBD.altaBajaMenu(idMenu, false);
        }

        public bool autorizar(int idMenu)
        {
            return menuBD.autorizarMenu(idMenu, true);
        }


        // --------------------- METODOS AUXILIARES ---------------------------

        // Caclular tiempo de elaboracion en base a la coccion de las comidas
        private int calcularElaboracion()
        {
            tiempoElaboracion = 0;
            foreach (Comida comida in Comidas)
                tiempoElaboracion += comida.Coccion;
            return tiempoElaboracion;
        }


        // Validacion
        private int tamanioMenu(string tipoMenu)
        {
            if (tipoMenu.Equals("Semanal"))
                return 5;
            else if (tipoMenu.Equals("Quincenal"))
                return 10;
            else
                return 20;
        }

        public bool esIntPositivo(string num)
        {
            try
            {
                int nro = Int32.Parse(num);
                return nro > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool validarPrecio(string num)
        {
            try
            {
                double precio = Double.Parse(num);
                return precio > 0;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool campoNoVacio(string str)
        {
            return !String.IsNullOrEmpty(str);
        }

        public bool verificarStockMin(string stockMinStr, string stockMaxStr)
        {
            bool stockMinCorrecto = esIntPositivo(stockMinStr);
            bool stockMaxCorrecto = esIntPositivo(stockMaxStr);

            if (stockMinCorrecto && stockMaxCorrecto)
                return Convert.ToInt32(stockMinStr) < Convert.ToInt32(stockMaxStr);
            else
                return false;
        }

        public bool listaNoVacia(List<string> lst)
        {
            return lst.Count > 0;
        }

        public bool verificarFiltroDeMenu(List<string> valFiltro)
        {
            return valFiltro.Count > 0;
        }

    }
}
