using SISVIANSA_ITI_2023.Logica;
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
using SISVIANSA_ITI_2023.Persistencia;

namespace ventana3
{
    public partial class ListarVehiculo : Form
    {
        private byte rol;
        private Vehiculo vehiculo;
        private Zona logicaZona;
        private string colFiltro = "todo";

        // ------------------------------- METEDOS AL INCIAR -------------------------------
        public ListarVehiculo(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            vehiculo = new Vehiculo(rol);
            logicaZona = new Zona(rol);
        }

        private void ListarVehiculo_Load(object sender, EventArgs e)
        {
            limpiarFiltros();
            inhabilitarFiltros();
            rbtnTodo.Checked = true;
            buscarTodo();
        }



        // -------------------------- METODOS AUXILIARES -----------------------------------

        // Filtros
        private void inhabilitarFiltros()
        {
            txtMatricula.Enabled = false;
            cboZona.Enabled = false;
        }

        private void limpiarFiltros()
        {
            txtMatricula.Clear();
            cboZona.SelectedItem = null;
        }


        // Buscar en BD
        private void buscarPorMatricula()
        {
            List<Vehiculo> vehiculos = vehiculo.filtrarPorMatricula(txtMatricula.Text);
            cargarDatosDGV(vehiculos);
        }

        private void buscarPorZona()
        {
            List<Vehiculo> vehiculos = vehiculo.filtrarPorZona(cboZona.Text);
            cargarDatosDGV(vehiculos);
        }

        private void buscarTodo()
        {
            cargarDatosDGV(vehiculo.obtenerVehiculos());
        }


        // Cargar datos
        private void cargarDatosDGV(List<Vehiculo> listaVehiculos)
        {
            dgvVehiculos.Rows.Clear();

            if (listaVehiculos != null)
            {
                foreach (var vehiculo in listaVehiculos)
                {
                    dgvVehiculos.Rows.Add(vehiculo.Id, vehiculo.Matricula, vehiculo.CapCarga, vehiculo.Activo);
                }
            }
            else
                MessageBox.Show("No se pudo cargar la lista");

        }

        private void cargarZonasCBO()
        {
            cboZona.Items.Clear();
            List<Zona> zonas = logicaZona.todasLasZonas();

            if (zonas != null)
            {
                foreach (var zona in zonas)
                {
                    cboZona.Items.Add("Zona " + zona.Id.ToString());
                }
                cboZona.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Ha ocurrido un error al cargar las zonas");
        }

        private void actualizarDGV()
        {
            if (colFiltro.Equals("matricula"))
                buscarPorMatricula();
            else if (colFiltro.Equals("zona"))
                buscarPorZona();
            else
                buscarTodo();
        }

        // Seleccionar  vehiculo
        private Vehiculo vehiculoSeleccionado()
        {
            DataGridViewRow fila = dgvVehiculos.SelectedRows[0];

            Vehiculo vehiculo = new Vehiculo(rol)
            {
                Id = Convert.ToInt32(fila.Cells[0].Value),
                Matricula = Convert.ToString(fila.Cells[1].Value),
                CapCarga = Convert.ToInt32(fila.Cells[2].Value)
            };
            vehiculo.obtenerZonasReparto();

            return vehiculo;
        }



        // -------------------------- METODOS WIDGETS -----------------------------------
        // Botones
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            vehiculo = vehiculoSeleccionado();
            vehiculo.bajaAlta(true);
            actualizarDGV();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            vehiculo = vehiculoSeleccionado();
            vehiculo.bajaAlta(false);
            actualizarDGV();
        }

        private void btnAsignarZona_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en mantenimiento", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*
            Vehiculo vehiculo = vehiculoSeleccionado();
            AsignarZonas asignarZonas = new AsignarZonas(vehiculo, this.rol);
            asignarZonas.Show(Owner);
            Close();
            */
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en mantenimiento", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*
            Vehiculo vehiculo = vehiculoSeleccionado();
            DetallesVehiculo detallesVehiculo = new DetallesVehiculo(this.rol, vehiculo);
            detallesVehiculo.Show(Owner);
            Close();
            */
        }


        // Filtros
        private void rbtnMatricula_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
            inhabilitarFiltros();
            colFiltro = "matricula";
            txtMatricula.Enabled = true;
        }

        private void rbtnZona_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
            inhabilitarFiltros();
            colFiltro = "zona";
            cboZona.Enabled = true;
            cargarZonasCBO();
        }

        private void rbtnTodo_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
            inhabilitarFiltros();
            colFiltro = "todo";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnMatricula.Checked)
                buscarPorMatricula();
            else if (rbtnZona.Checked)
                buscarPorZona();
            else if (rbtnTodo.Checked)
                buscarTodo();
            else
                MessageBox.Show("No se ha seleccionado criterio de búsqueda");

        }

    }
}
