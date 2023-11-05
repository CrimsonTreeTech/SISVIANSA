using SISVIANSA_ITI_2023.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventana3;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class DetallesMenu : Form
    {
        private byte rol;
        private Menu menu;
        private List<Menu> listaMenus;

        // ----------------------- CONSTRUCTOR ----------------------------
        public DetallesMenu(int idMenu, byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            menu = new Menu(rol);
            menu.cargarDatosDeMenu(idMenu);
            cargarMenu();
        }


        // ---------------------- METODOS AUXILIARES ---------------------
        private void cargarMenu()
        {
            chkActivo.Checked = menu.Activo;
            chkAutorizado.Checked = menu.Autorizado;

            txtNombre.Text = "Menu " + menu.Id.ToString();
            txtTipo.Text = menu.Tipo;
            txtPrecio.Text = menu.Precio.ToString();
            txtMinStock.Text = menu.StockMin.ToString();
            txtMaxStock.Text = menu.StockMax.ToString();
            txtCongelable.Text = menu.Congelable.ToString();
            txtElaboracion.Text = menu.TiempoElaboracion.ToString();

            rtxtSugerencias.Text = menu.Sugerencia;

            cargarComidasCbo();
            cargarDietasCbo();
        }

        private void cargarDietasCbo()
        {
            foreach (Dieta dieta in menu.Dietas)
                lstDietas.Items.Add(dieta.Nombre);
        }

        private void cargarComidasCbo()
        {
            foreach (Comida comida in menu.Comidas)
                lstComidas.Items.Add(comida.Nombre);
        }



        // -------------------------- METODOS WIDGETS ----------------------
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ListarMenus listarMenus = new ListarMenus(this.rol);
            listarMenus.Show(Owner);
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
