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
        private int filaSeleccionada, idClienteSeleccionado, idMenuSeleccionado;
        private double precioTotal;
        private bool accionExitosa;
        private Cliente cliente;
        private Pedido pedido;
        private Menu menu;
        private Zona zona;
        private Dieta dieta;
        private List<Dieta> listaDietas;
        private List<Cliente> listaClientes;
        private List<Menu> listaMenus;
        private List<Zona> listaZonas;

        public GestionarPedido(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            cliente = new Cliente(rol);
            pedido = new Pedido(rol);
            menu = new Menu(rol);
            dieta = new Dieta(rol);
            zona = new Zona(rol);
            modificarDatosPedido_Pedido();
        }

        // ------------ METODOS AUXILIARES ----------------
        private void calcularPrecioTotal()
        {
            precioTotal = (double)nudCantidadMenu.Value * menu.Precio;
            precioTotal += zona.obtenerPrecio(zona.Id);

            txtTotalPrecioMenu.Text = precioTotal.ToString();
        }

        private Pedido obtenerDatosDePedido()
        {
            pedido = new Pedido(rol);
   
            pedido.IdCliente = cliente.Id;
            pedido.Cliente = txtNombreClienteDatos.Text;
            pedido.IdMenu = Convert.ToInt32(txtMenuDatos.Text);
            pedido.Cantidad = Convert.ToInt32(nudCantidadMenu.Text);
            pedido.Estado = txtEstado.Text;
            pedido.FechaRealizado = txtUltimaAct.Text;
            pedido.Zona = Convert.ToInt32(cboZona.Text);
            pedido.Calle = cliente.Calle;
            pedido.Esq = cliente.Esq;
            pedido.NroPuerta = cliente.NroPuerta;
            pedido.PrecioTotal = Convert.ToDouble(txtTotalPrecioMenu.Text);

            return pedido;
        }

        // Cargar combo box
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

        private void cargarCboZonasPedido()
        {
            cboZona.Items.Clear();
            listaZonas = zona.todasLasZonas();
            foreach (Zona zona in listaZonas)
            {
                cboZona.Items.Add(zona.Id);
            }
            cboZona.SelectedIndex = 0;

            calcularPrecioTotal();
        }


        // Seleccion de la data grid view
        private Cliente clienteSeleccionado()
        {
            filaSeleccionada = dgvCliente.CurrentCell.RowIndex;
            idClienteSeleccionado = Convert.ToInt32(dgvCliente.Rows[filaSeleccionada].Cells[0].Value);

            cliente = cliente.cargarDatosDeCliente(idClienteSeleccionado);
            return cliente;
        }

        private Menu menuSeleccionado()
        {
            filaSeleccionada = dgvMenu.CurrentCell.RowIndex;
            idMenuSeleccionado = Convert.ToInt32(dgvMenu.Rows[filaSeleccionada].Cells[0].Value);

            menu.cargarDatosDeMenu(idMenuSeleccionado);
            return menu;
        }



        // Cargado de listas
        private void cargarListaClientes(List<Cliente> listaClientes)
        {
            dgvCliente.Rows.Clear();

            foreach (Cliente cliente in listaClientes)
            {
                dgvCliente.Rows.Add(cliente.Id, cliente.Doc, cliente.NombreEmpresa, cliente.Tels[0], cliente.Mails[0], cliente.Activo, cliente.Autorizado);
            }

        }

        private void cargarListaMenus(List<Menu> listaMenus)
        {
            dgvMenu.Rows.Clear();
            foreach (Menu menu in listaMenus)
            {
                dgvMenu.Rows.Add(menu.Id, menu.Tipo, menu.Precio, menu.DietasSTR);
            }
        }



        // Obtener val filtro
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

        private void habilitarApartadoPedido()
        {
            cboZona.Enabled = true;
            nudCantidadMenu.Enabled = true;
            cargarCboZonasPedido();
            calcularPrecioTotal();
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

        private void modificarDatosPedido_Menu(Menu menu)
        {
            txtMenuDatos.Text = menu.Id.ToString();
        }

        private void modificarDatosPedido_Pedido()
        {
            txtEstado.Text = "Solicitado";
            txtUltimaAct.Text = DateTime.Now.ToString("yyyy-mm-dd");
        }



        // ---------------- METODOS DE WIDGETS ---------------------
        private void GestionarPedido_Load(object sender, EventArgs e)
        {
            inhabilitarFiltrosCliente();
            deshabilitarApartadoMenu();
            rbtnAutorizadosYActivosCliente.Checked = true;
            listaClientes = cliente.realizarBusquedaFiltrada("activo y autorizado", "");
            cargarListaClientes(listaClientes);
        }

        private void nudCantidadMenu_ValueChanged(object sender, EventArgs e)
        {
            calcularPrecioTotal();
        }

        
        // Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            pedido = obtenerDatosDePedido();
            accionExitosa = pedido.ingresar();
            if (accionExitosa)
            {
                MessageBox.Show("Se ha ingresado el pedido exitosamente");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error, no se ha logrado ingresar el pedido");
            }
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

        private void dgvMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            menu = menuSeleccionado();

            modificarDatosPedido_Menu(menu);
            habilitarApartadoPedido();
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
