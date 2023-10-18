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
        private Menu menu;
        private List<Menu> listaMenus;

        // ---------------------------- METODOS AL INICIAR --------------------------------
        public ListarMenus(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            menu = new Menu(rol);
            busquedaSinFiltroNiOrden();
            bloqueraFuncionalidadesSegunRol(rol);
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
            reiniciarFiltros();
            reiniciarOrden();
            inhabilitarFiltros();
            inhabilitarOrden();
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
                dgvMenu.Rows.Add(menu.Id, menu.Tipo, menu.Precio, menu.Autorizado, menu.Activo);
            }
        }

        private void busquedaSinFiltroNiOrden()
        {
            listaMenus = menu.obtenerTodosLosMenu();
            cargarLista(listaMenus);
        }

        // ---------------------------- METODOS DE FILTROS --------------------------
        private void reiniciarFiltros()
        {
            rbtnFiltrarTipo.Checked = false;
            rbtnFiltroNombre.Checked = false;
            rbtnFiltroNoAutorizados.Checked = false;

            txtFiltroNombre.Clear();
            cboFiltroTipo.SelectedItem = null;
        }

        private void reiniciarOrden()
        {
            rbtnOrdenNombre.Checked = false;
            rbtnOrdenTipo.Checked = false;

            cboOrdenNombre.SelectedItem = null;
            cboOrdenTipo.SelectedItem = null;
        }

        private void inhabilitarFiltros()
        {
            txtFiltroNombre.Enabled = false;
            cboFiltroTipo.Enabled = false;
        }

        private void inhabilitarOrden()
        {
            cboOrdenNombre.Enabled = false;
            cboOrdenTipo.Enabled = false;
        }



        // ------------------------- METODOS DE WIDGETS ---------------------------------

        // Radio buttons filtros
        private void rbtnFiltroNombre_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            inhabilitarFiltros();
            rbtnFiltroNombre.Checked = true;
            txtFiltroNombre.Enabled = true;
        }

        private void rbtnFiltrarTipo_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            inhabilitarFiltros();
            rbtnFiltrarTipo.Checked = true;
            cboFiltroTipo.Enabled = true;
        }

        private void rbtnNoAutorizados_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            inhabilitarFiltros();
            rbtnFiltroNoAutorizados.Checked = true;
        }

        // Radiobuttons orden
        private void rbtnOrdenNombre_Click(object sender, EventArgs e)
        {
            reiniciarOrden();
            inhabilitarOrden();
            rbtnOrdenNombre.Checked = true;
            cboOrdenNombre.Enabled = true;
        }

        private void rbtnOrdenTipo_Click(object sender, EventArgs e)
        {
            reiniciarOrden();
            inhabilitarOrden();
            rbtnOrdenTipo.Checked = true;
            cboOrdenTipo.Enabled = true;
        }

        private void rbtnOrdenStock_Click(object sender, EventArgs e)
        {
            reiniciarOrden();
            inhabilitarOrden();
        }


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
            reiniciarFiltros();
            reiniciarOrden();
            inhabilitarFiltros();
            inhabilitarOrden();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
