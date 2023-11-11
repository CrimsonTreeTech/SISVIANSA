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
        private int idMenu, filaSeleccionada, idMenuSelecioando;
        private string colFiltro;
        private bool valido;
        private Menu menu;
        private Dieta dieta;
        private List<string> valFiltro;
        private List<Menu> listaMenus;
        private List<Dieta> listaDietas;

        // ---------------------------- METODOS AL INICIAR --------------------------------
        public ListarMenus(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            menu = new Menu(rol);
            dieta = new Dieta(rol);
            valFiltro = new List<string>();
            colFiltro = "todo";
        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1) // Gerente
            {
                btnModificar.Enabled = false;
            }
            else if (rol == 2) // Cocina
            {
                btnAutorizar.Enabled = false;
            }
            else if (rol == 4) // Atc
            {
                btnBaja.Enabled = false;
                btnAlta.Enabled = false;
                btnModificar.Enabled = false;
                btnAutorizar.Enabled = false;
            }

        }

        // ------------------------ METODOS AUXILIARES --------------------------------
        private int seleccionarMenu()
        {
            return Convert.ToInt32(dgvMenu.SelectedCells[0].Value);
        }

        private void cargarLista(List<Menu> listaMenus)
        {
            dgvMenu.Rows.Clear();
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

        private List<string> obtenerValFiltro()
        {
            valFiltro = new List<string>();

            if (colFiltro.Equals("id"))
            {
                valFiltro.Add(txtMenu.Text);
            }

            else if (colFiltro.Equals("tipo"))
            {
                valFiltro.Add(cboTipo.Text);
            }

            else if (colFiltro.Equals("dieta"))
            {
                valFiltro = obtenerDietasSeleccionadas();
            }

            else
            {
                valFiltro.Add("");
            }
            return valFiltro;
        }

        private int obtenerIdMenuSeleccionado()
        {
            filaSeleccionada = dgvMenu.CurrentCell.RowIndex;
            idMenuSelecioando = Convert.ToInt32(dgvMenu.Rows[filaSeleccionada].Cells[0].Value);
            return idMenuSelecioando;
        }

        // ---------------------------- METODOS DE FILTROS --------------------------
        private void inhabilitarFiltros()
        {
            txtMenu.Clear();
            cboTipo.SelectedItem = null;
            chkLstDietas.Items.Clear();

            txtMenu.Enabled = false;
            cboTipo.Enabled = false;
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

        private List<string> obtenerDietasSeleccionadas()
        {
            valFiltro = new List<string>();

            for (int i = 0; i < chkLstDietas.Items.Count; i++)
            {
                if (chkLstDietas.GetItemChecked(i))
                {
                    string dietaCheckeada = chkLstDietas.Items[i].ToString();
                    valFiltro.Add(dietaCheckeada);
                }
            }

            return valFiltro;
        }

        private void realizarBusqueda()
        {
            valFiltro = obtenerValFiltro();
            valido = menu.verificarFiltroDeMenu(valFiltro);
            if (valido)
            {
                listaMenus = menu.buscarMenuFiltrados(colFiltro, valFiltro);
                cargarLista(listaMenus);
            }
            else
            {
                MessageBox.Show("No seleccionó filtros de búsqueda correctos");
            }
        }

        // ------------------------- METODOS DE WIDGETS ---------------------------------
        private void ListarMenus_Load(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            busquedaSinFiltroNiOrden();
            bloqueraFuncionalidadesSegunRol(rol);
            rbtnTodo.Checked = true;
            listaMenus = menu.obtenerTodosLosMenu();
            cargarLista(listaMenus);
        }


        // Botones
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en mantenimiento", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*
            idMenu = seleccionarMenu();
            DetallesMenu detalles = new DetallesMenu(idMenu, this.rol);
            detalles.Show(Owner);
            Close();
            */
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en mantenimiento", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*
            int idMenu = seleccionarMenu();
            GestionarMenu gestionarMenu = new GestionarMenu(this.rol, idMenu);
            gestionarMenu.Show(Owner);
            Close();
            */
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            idMenuSelecioando = obtenerIdMenuSeleccionado();
            bool res = menu.autorizar(idMenuSelecioando);
            if (res)
            {
                MessageBox.Show("Se guardaron los valores cambiados.");
                realizarBusqueda();
            }
            else
            {
                MessageBox.Show("No se han logrado cambiar los valores.");
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            idMenuSelecioando = obtenerIdMenuSeleccionado();
            bool res = menu.baja(idMenuSelecioando);
            if (res)
            {
                MessageBox.Show("Se guardaron los valores cambiados.");
                realizarBusqueda();
            }
            else
            {
                MessageBox.Show("No se han logrado cambiar los valores.");
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            idMenuSelecioando = obtenerIdMenuSeleccionado();
            bool res = menu.alta(idMenuSelecioando);
            if (res)
            {
                MessageBox.Show("Se guardaron los valores cambiados.");
                realizarBusqueda();
            }
            else
            {
                MessageBox.Show("No se han logrado cambiar los valores.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            realizarBusqueda();
        }


        // Radio buttons filtros
        private void rbtnTodo_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            colFiltro = "todo";
        }

        private void rbtnMenu_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            txtMenu.Enabled = true;
            colFiltro = "id";
        }

        private void rbtnTipo_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            cboTipo.Enabled = true;
            cboTipo.SelectedIndex = 0;
            colFiltro = "tipo";
        }

        private void rbtnNoAutorizados_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            colFiltro = "noAutorizado";
        }

        private void rbtnAutorizado_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            colFiltro = "autorizado";
        }

        private void rbtnActivo_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            colFiltro = "activo";
        }

        private void rbtnInactivo_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            colFiltro = "inactivo";
        }

        private void rbtnDieta_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            cargarListaDietas();
            colFiltro = "dieta";
        }

    }

}
