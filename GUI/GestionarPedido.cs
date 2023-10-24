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
    public partial class GestionarPedido : Form
    {
        private byte rol;
        private string valFiltroCliente=null, colFiltroCliente=null, valFiltroMenu, colFiltroMenu;
        private Cliente cliente;
        private Pedido pedido;
        private Menu menu;
        private List<Cliente> listaClientes;
        private List<Menu> listaMenus;

        public GestionarPedido(byte rol)
        {
            InitializeComponent();
            cliente = new Cliente(rol);
            pedido = new Pedido(rol);
            menu = new Menu(rol);
        }

        // ------------ METODOS AUXILIARES ----------------
        private void inhabilitarFiltrosCliente()
        {
            txtDocCliente.Clear();
            txtNombreCliente.Clear();

            txtDocCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
        }

        private string obtenerValFiltroCliente()
        {
            valFiltroCliente = null;

            if (!String.IsNullOrEmpty(colFiltroCliente))
            {
                if (colFiltroCliente.Equals("nro_doc"))
                {
                    valFiltroCliente = txtDocCliente.Text;
                }
                else if (colFiltroCliente.Equals("nombre"))
                {
                    valFiltroCliente = txtNombreCliente.Text;
                }
            }

            return valFiltroCliente;

        }

        private void deshabilitarApartadoMenu()
        {
            rbtnNombreMenu.Enabled = false;
            rbtnDietaMenu.Enabled = false;
            rbtnTipoMenu.Enabled = false;

            txtNombreMenu.Enabled = false;
            cboDietaMenu.Enabled = false;
            cboTipoMenu.Enabled = false;

            btnBuscarMenu.Enabled = false;

            dgvMenu.Enabled = false;
        }


        // ---------------- METODOS DE WIDGETS ---------------------
        private void GestionarPedido_Load(object sender, EventArgs e)
        {
            inhabilitarFiltrosCliente();
            deshabilitarApartadoMenu();
        }

        // Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            valFiltroCliente = obtenerValFiltroCliente();
            if (!String.IsNullOrEmpty(valFiltroCliente))
            {
                MessageBox.Show(valFiltroCliente);
            }
            else
            {
                MessageBox.Show("No ha seleccionado valores válidos para realizar la búsqueda.");
            }
        }

        private void btnBuscarMenu_Click(object sender, EventArgs e)
        {

        }

        
        // Filtros de cliente
        private void rbtnDocCliente_Click(object sender, EventArgs e)
        {
            inhabilitarFiltrosCliente();
            txtDocCliente.Enabled = true;
            colFiltroCliente = "nro_doc";
        }

        private void rbtnNombreCliente_Click(object sender, EventArgs e)
        {
            inhabilitarFiltrosCliente();
            txtNombreCliente.Enabled = true;
            colFiltroCliente = "nombre";
        }

        
    }
}
