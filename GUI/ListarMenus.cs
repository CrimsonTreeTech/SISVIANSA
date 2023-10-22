using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISVIANSA_ITI_2023.Logica;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class ListarMenus : Form
    {
        private byte rol;
        private int idMenu;
        private string colFiltro, valFiltro;
        private Menu menu;
        private Dieta dieta;
        private List<Menu> listaMenus;
        List<Dieta> listaDietas;

        // ---------------------------- METODOS AL INICIAR --------------------------------
        public ListarMenus(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            menu = new Menu(rol);
            dieta = new Dieta(rol);
        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1)
            {
                btnBaja.Enabled = false;
                btnModificar.Enabled = false;
            }
            else if (rol == 2)
            {
                btnBaja.Enabled = false;
                btnAutorizar.Enabled = false;
            }
            else if (rol == 4)
            {
                btnBaja.Enabled = false;
                btnModificar.Enabled = false;
                btnAutorizar.Enabled = false;
            }

        }

        private void ListarMenus_Load(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            busquedaSinFiltroNiOrden();
            bloqueraFuncionalidadesSegunRol(rol);
            valFiltro = "todo";
            rbtnTodo.Checked = true;
            listaMenus = menu.obtenerTodosLosMenu();
            cargarLista(listaMenus);
        }


        // ------------------------ METODOS AUXILIARES --------------------------------
        private int seleccionarMenu()
        {
            return Convert.ToInt32(dgvMenu.SelectedCells[0].Value);
        }

        private void cargarLista(List<Menu> listaMenus)
        {
            foreach (Menu menu in listaMenus)
            {
                dgvMenu.Rows.Add(menu.Id, menu.Tipo, menu.Precio, menu.Autorizado, menu.Activo, menu.DietasSTR);
            }
        }

        private void busquedaSinFiltroNiOrden()
        {
            listaMenus = menu.obtenerTodosLosMenu();
            cargarLista(listaMenus);
        }

        // ---------------------------- METODOS DE FILTROS --------------------------
        private void inhabilitarFiltros()
        {
            txtFiltroNombre.Clear();
            cboFiltroTipo.SelectedItem = null;
            chkLstDietas.Items.Clear();

            txtFiltroNombre.Enabled = false;
            cboFiltroTipo.Enabled = false;
            chkLstDietas.Enabled = false;
        }

        private void cargarListaDietas()
        {
            chkLstDietas.Items.Clear();
            listaDietas = dieta.todasLasDietas();
            foreach (Dieta dieta in listaDietas)
            {
                chkLstDietas.Items.Add(dieta.Nombre);
            }
            chkLstDietas.Enabled = true;
        }

        // ------------------------- METODOS DE WIDGETS ---------------------------------

        // Botones
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            idMenu = seleccionarMenu();
            DetallesMenu detalles = new DetallesMenu(idMenu, this.rol);
            detalles.Show(Owner);
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idMenu = seleccionarMenu();
            GestionarMenu gestionarMenu = new GestionarMenu(this.rol, idMenu);
            gestionarMenu.Show(Owner);
            Close();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }


        // Radio buttons filtros
        private void rbtnNombre_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            txtFiltroNombre.Enabled = true;
        }

        private void rbtnTipo_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            cboFiltroTipo.Enabled = true;
            cboFiltroTipo.SelectedIndex = 0;
        }

        private void rbtnNoAutorizados_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
        }

        private void rbtnTodo_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
        }

        private void rbtnAutorizado_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
        }

        private void rbtnActivo_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
        }

        private void rbtnInactivo_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
        }

        private void rbtnDieta_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            cargarListaDietas();
        }
    }

}
