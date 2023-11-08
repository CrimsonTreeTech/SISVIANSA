using SISVIANSA_ITI_2023.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class ListarCliente : Form
    {
        private byte rol;
        private int filaSeleccionada, idClienteSelecioando;
        private string colFiltro, valFiltro;
        private List<Cliente> listaClientes;
        private Cliente cliente;

        // ------------------------- CONSTRUCTOR ---------------------------
        public ListarCliente(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            cliente = new Cliente(rol);
        }


        // ----------------------- METODOS AUXILIARES --------------------------
        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1)
                btnDarBaja.Enabled = false;
            else if (rol == 4)
            {
                btnDarBaja.Enabled = false;
                btnAutorizar.Enabled = false;
            }
        }

        private void reiniciarFiltros()
        {
            txtId.Clear();
            txtDoc.Clear();
            txtNombre.Clear();
            cboTipo.SelectedItem = null;

            txtId.Enabled = false;
            txtDoc.Enabled = false;
            txtNombre.Enabled = false;
            cboTipo.Enabled = false;
        }

        private string obtenerValFiltro()
        {
            valFiltro = "";

            if (colFiltro.Equals("id"))
                valFiltro = txtId.Text;

            else if (colFiltro.Equals("nro_doc"))
                valFiltro = txtDoc.Text;

            else if (colFiltro.Equals("nombre"))
                valFiltro = txtNombre.Text;

            else if (colFiltro.Equals("tipo"))
                valFiltro = cboTipo.Text;

            return valFiltro;
        }

        private void cargarGrilla(List<Cliente> listaClientes)
        {
            dgvClientes.Rows.Clear();

            foreach (Cliente c in listaClientes)
            {
                dgvClientes.Rows.Add(c.Id, c.TipoDoc, c.Doc, c.TipoCliente, c.NombreCompleto, c.direccion(), c.Autorizado, c.Activo);
            }
        }

        private int obtenreIdClienteSeleccionado()
        {
            filaSeleccionada = dgvClientes.CurrentCell.RowIndex;
            idClienteSelecioando = Convert.ToInt32(dgvClientes.Rows[filaSeleccionada].Cells[0].Value);
            return idClienteSelecioando;
        }

        private void realizarBusqueda()
        {
            valFiltro = obtenerValFiltro();
            listaClientes = cliente.realizarBusquedaFiltrada(colFiltro, valFiltro);
            cargarGrilla(listaClientes);
        }


        // ------------------------ METODOS DE WIDGETS -----------------------------
        private void VisualizarCliente_Load(object sender, EventArgs e)
        {
            reiniciarFiltros();
            bloqueraFuncionalidadesSegunRol(rol);
            colFiltro = "todo";
            valFiltro = "";
            rbtnTodos.Checked = true;
            listaClientes = cliente.realizarBusquedaFiltrada(colFiltro, valFiltro);
            cargarGrilla(listaClientes);
        }


        // Botones
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            realizarBusqueda();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            idClienteSelecioando = obtenreIdClienteSeleccionado();
            cliente.bajaCliente(idClienteSelecioando);
            realizarBusqueda();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            idClienteSelecioando = obtenreIdClienteSeleccionado();
            cliente.altaCliente(idClienteSelecioando);
            realizarBusqueda();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            idClienteSelecioando = obtenreIdClienteSeleccionado();
            cliente.autorizarCliente(idClienteSelecioando);
            realizarBusqueda();
        }




        // Radio buttons
        private void rbtnId_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            txtId.Enabled = true;
            colFiltro = "id";
        }

        private void rbtnDoc_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            txtDoc.Enabled = true;
            colFiltro = "nro_doc";
        }

        private void rbtnNombre_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            txtNombre.Enabled = true;
            colFiltro = "nombre";
        }

        private void rbtnTipo_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            cboTipo.Enabled = true;
            cboTipo.SelectedIndex = 0;
            colFiltro = "tipo";
        }

        private void rbtnTodos_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            colFiltro = "todo";
        }

        private void rbtnActivos_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            colFiltro = "activo";
        }

        private void rbtnInactivos_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            colFiltro = "inactivo";
        }

        private void rbtnAutorizados_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            colFiltro = "autorizado";
        }

        private void rbtnNoAutorizados_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            colFiltro = "no autorizado";
        }

        private void rbtnActivosYAutorizados_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            colFiltro = "activo y autorizado";
        }



        ///// MEDOTOS AUXILIARES 


        private byte tipoClienteSeleccionado()
        {
            // 0 - Error
            // 1 - Comun
            // 2 - Empresa
            return 1;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            idClienteSelecioando = obtenreIdClienteSeleccionado();
            cliente = cliente.cargarDatosDeCliente(idClienteSelecioando);

            if (tipoClienteSeleccionado() == 1)
            {
                DetallesCliente detallesCliente = new DetallesCliente(this.rol, cliente);
                detallesCliente.Show(Owner);
                Close();
            }
        }



    }
}
