using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISVIANSA_ITI_2023.Persistencia;

namespace SISVIANSA_ITI_2023.Logica
{
    public class Vianda
    {
        private byte rol;
        private int idVianda, idMenu;
        private string fechaEnvasado, fechaVencimiento;
        private ViandaBD viandaBD;

        // ------------------ CONSTRUCTOR ----------------------
        public Vianda(byte rol)
        {
            this.rol = rol;
            viandaBD = new ViandaBD(rol);
        }

        // ----------------- GETTERS Y SETTERS --------------------
        public int IdVianda
        {
            get { return idVianda; }
            set { idVianda = value; }
        }

        public int IdMenu
        {
            get { return idMenu; }
            set { idMenu = value; }
        }

        public string FechaEnvasado
        {
            get { return fechaEnvasado; }
            set { fechaEnvasado = value; }
        }

        public string FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }

        // ---------------------- CONSULTAS -----------------------



    }
}
