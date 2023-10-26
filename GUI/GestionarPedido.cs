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
        private string valFiltroCliente = null, colFiltroCliente = null, valFiltroMenu, colFiltroMenu;
        private int filaSeleccionada, idClienteSeleccionado;
        private Cliente cliente;
        private Pedido pedido;
        private Menu menu;
        private Dieta dieta;
        private List<Dieta> listaDietas;
        private List<Cliente> listaClientes;
        private List<Menu> listaMenus;

        public GestionarPedido(byte rol)
        {
            InitializeComponent();
            cliente = new Cliente(rol);
            pedido = new Pedido(rol);
            menu = new Menu(rol);
            dieta = new Dieta(rol);
        }

        // ------------ METODOS AUXILIARES ----------------
        private void cargarCboDietasMenu()
        {
            cboDietaMenu.Enabled = true;
            listaDietas = dieta.dietasAutorizadasYActivas();
            foreach (Dieta dieta in listaDietas)
            {
                cboDietaMenu.Items.Add(dieta.Nombre);
            }
            cboDietaMenu.SelectedIndex = 0;
        }

        // Cargado de listas
        private Cliente clienteSeleccionado()
        {
            filaSeleccionada = dgvCliente.CurrentCell.RowIndex;
            idClienteSeleccionado = Convert.ToInt32(dgvCliente.Rows[filaSeleccionada].Cells[0].Value);

            cliente = cliente.cargarDatosDeCliente(idClienteSeleccionado);
            return cliente;
        }
       
        private string obtenerValFiltroCliente()
        {
            valFiltroCliente = "";

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

        private void cargarListaClientes(List<Cliente> listaClientes)
        {
            dgvCliente.Rows.Clear();

            foreach (Cliente cliente in listaClientes)
            {
                dgvCliente.Rows.Add(cliente.Id, cliente.Doc, cliente.NombreEmpresa, cliente.Tels[0], cliente.Mails[0], cliente.Activo, cliente.Autorizado);
            }

        }

        private string obtenerValFiltroMenu()
        {
            valFiltroMenu = "";

            if (!String.IsNullOrEmpty(colFiltroCliente))
            {

                if (colFiltroMenu.Equals("id"))
                {
                    valFiltroMenu = txtNombreMenu.Text;
                }

                else if (colFiltroMenu.Equals("dieta"))
                {
                    valFiltroMenu = cboDietaMenu.Text;
                }

                else if (colFiltroMenu.Equals("tipo"))
                {
                    valFiltroMenu = cboTipoMenu.Text;
                }
            }
            return valFiltroMenu;
        }

        private void cargarListaMenus(List<Menu> listaMenus)
        {
            dgvMenu.Rows.Clear();
            foreach (Menu menu in listaMenus)
            {
                dgvMenu.Rows.Add(menu.Id, menu.Tipo, menu.Precio, menu.DietasSTR);
            }
        }


        // Deshabilitar / Habilitar apartados
        private void deshabilitarApartadoMenu()
        {
            rbtnTodoMenu.Enabled = false;
            rbtnNombreMenu.Enabled = false;
            rbtnDietaMenu.Enabled = false;
            rbtnTipoMenu.Enabled = false;

            txtNombreMenu.Enabled = false;
            cboDietaMenu.Enabled = false;
            cboTipoMenu.Enabled = false;

            btnBuscarMenu.Enabled = false;

            dgvMenu.Enabled = false;
        }

        private void habilitarApartadoMenu()
        {
            rbtnTodoMenu.Enabled = true;
            rbtnNombreMenu.Enabled = true;
            rbtnDietaMenu.Enabled = true;
            rbtnTipoMenu.Enabled = true;

            btnBuscarMenu.Enabled = true;

            dgvMenu.Enabled = true;

            rbtnTodoMenu.Checked = true;

            listaMenus = menu.buscarMenuFiltrados("todo", "");
            cargarListaMenus(listaMenus);
        }

        private void deshabilitarApartadoPedido()
        {
            txtNroPedidoDatos.Enabled = false;
            txtNroClienteDatos.Enabled = false;
            txtNroDocDatos.Enabled = false;
            txtNombreClienteDatos.Enabled = false;
            rtxtDir.Enabled = false;
            cboZona.Enabled = false;
            txtMenuDatos.Enabled = false;
            nudCantidadMenu.Enabled = false;
            txtEstado.Enabled = false;
            txtUltimaAct.Enabled = false;
            txtTotalPrecioMenu.Enabled = false;
        }


        // Inhabilitar filtros
        private void inhabilitarFiltrosCliente()
        {
            txtDocCliente.Clear();
            txtNombreCliente.Clear();

            txtDocCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
        }

        private void inhabilitarFiltrosMenu()
        {
            txtNombreMenu.Clear();
            cboDietaMenu.SelectedIndex = -1;
            cboTipoMenu.SelectedIndex = -1;

            txtNombreMenu.Enabled = false;
            cboDietaMenu.Enabled = false;
            cboTipoMenu.Enabled = false;
        }

        

        // Modificar datos del pedido
        private void modificarDatosPedido_Cliente(Cliente cliente)
        {
            txtNroClienteDatos.Text = cliente.Id.ToString();
            lblTipoDocDatos.Text = cliente.TipoDoc.ToString();
            txtNroDocDatos.Text = cliente.Doc.ToString();
            txtNombreClienteDatos.Text = cliente.NombreEmpresa;
            rtxtDir.Text = cliente.direccion();
        }


        // ---------------- METODOS DE WIDGETS ---------------------
        private void GestionarPedido_Load(object sender, EventArgs e)
        {
            inhabilitarFiltrosCliente();
            deshabilitarApartadoMenu();
            deshabilitarApartadoPedido();
            rbtnAutorizadosYActivosCliente.Checked = true;
            listaClientes = cliente.realizarBusquedaFiltrada("activo y autorizado", "");
            cargarListaClientes(listaClientes);
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
            listaClientes = cliente.realizarBusquedaFiltrada(colFiltroCliente, valFiltroCliente);
            cargarListaClientes(listaClientes);
        }

        private void btnBuscarMenu_Click(object sender, EventArgs e)
        {
            valFiltroMenu = obtenerValFiltroMenu();
            listaMenus = menu.buscarMenuFiltrados(colFiltroMenu, valFiltroMenu);
            cargarListaMenus(listaMenus);
        }

        // Data grid views
        private void dgvCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cliente = clienteSeleccionado();

            if (!cliente.Autorizado)
            {
                MessageBox.Show("El cliente no se encuentra autorizado. No podrá hacer pedidos hasta ser autorizado.");
            }
            else if (cliente.Autorizado && !cliente.Activo)
            {
                MessageBox.Show("El cliente no está activo, activelo antes de realizar el pedido.");
            }
            else
            {
                modificarDatosPedido_Cliente(cliente);
                habilitarApartadoMenu();
            }


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

        private void rbtnTodoCliente_CheckedChanged(object sender, EventArgs e)
        {
            inhabilitarFiltrosCliente();
            colFiltroCliente = "todo";
        }

        private void rbtnAutorizadosYActivosCliente_Click(object sender, EventArgs e)
        {
            inhabilitarFiltrosCliente();
            colFiltroCliente = "activo y autorizado";
        }


        // Filtros menu
        private void rbtnTodoMenu_Click(object sender, EventArgs e)
        {
            inhabilitarFiltrosMenu();
            colFiltroMenu = "todo";
        }

        private void rbtnNombreMenu_Click(object sender, EventArgs e)
        {
            inhabilitarFiltrosMenu();
            txtNombreMenu.Enabled = true;
            colFiltroMenu = "id";
        }

        private void rbtnDietaMenu_Click(object sender, EventArgs e)
        {
            inhabilitarFiltrosMenu();
            cargarCboDietasMenu();
            colFiltroMenu = "dieta";
        }

        private void rbtnTipoMenu_Click(object sender, EventArgs e)
        {
            inhabilitarFiltrosMenu();
            cboTipoMenu.Enabled = true;
            cboTipoMenu.SelectedIndex = 0;
            colFiltroMenu = "tipo";
        }
    }
}
