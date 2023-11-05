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

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class GestionarSucursal : Form
    {
        Sucursal sucursal;
        Zona zona;

        // ------------------ METODOS AL INICIAR ---------------------
        public GestionarSucursal(byte rol)
        {
            sucursal = new Sucursal(rol);
            zona = new Zona(rol);
            InitializeComponent();
        }

        public GestionarSucursal(byte rol, Sucursal sucursal)
        {
            this.sucursal = new Sucursal(rol);
            zona = new Zona(rol);
            InitializeComponent();
            cargarDatos();
        }

        private void IngresarSucursal_Load(object sender, EventArgs e)
        {
            List<string> zonasDisponibles = zona.obtenerZonas();
            lstZonsaDisponibles.Items.AddRange(zonasDisponibles.ToArray());
        }


        // -------------------- METODOS AUXILIARES ---------------------------
        private void regresarAlMenu()
        {
            Owner.Show();
            Close();
        }

        private void actualizarListas()
        {
            List<string> listaZonasSucursalesSeleccionadas = sucursal.listaTemporalZonasSuc();
            lstZonasCubiertas.Items.Clear();
            lstZonasCubiertas.Items.AddRange(listaZonasSucursalesSeleccionadas.ToArray());

            List<string> listaZonasDisponibles = sucursal.listaZonasDisponibles();
            lstZonsaDisponibles.Items.Clear();
            lstZonsaDisponibles.Items.AddRange(listaZonasDisponibles.ToArray());
        }

        private void cargarDatos()
        {
            txtNombre.Text = "Sucursal";
            txtCapProd.Text = "1";
            rtxtMetas.Text = "SADFDASFASFASFASDFSAF_asdfasdf";
        }


        // ------------------- METODOS DE VALIDACION ----------------------------
        private bool validarDatos()
        {
            List<string> listaZonasSeleccionadas = lstZonasCubiertas.Items.OfType<string>().ToList();
            bool nombre = sucursal.validarNombre(txtNombre.Text);
            bool capProd = sucursal.validarCapProd(txtCapProd.Text);
            bool zonas = sucursal.validarZonasSuc(listaZonasSeleccionadas);

            marcarIncorrecto(nombre, lblNombre);
            marcarIncorrecto(capProd, lblCapProd);
            marcarIncorrecto(zonas, lblZonasCubiertas);

            return nombre && capProd && zonas;
        }

        private void marcarIncorrecto(bool valido, Label obj)
        {
            if (valido)
                obj.ForeColor = System.Drawing.Color.Black;
            else
                obj.ForeColor = System.Drawing.Color.Red;
        }


        // ------------------- METODOS DE WIDGETS -----------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string zonaSeleccionada = lstZonsaDisponibles.SelectedItem.ToString();
                sucursal.agregarZonaSucTemporal(zonaSeleccionada);
                actualizarListas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                string zonaSeleccionada = lstZonasCubiertas.SelectedItem.ToString();
                sucursal.quitarZonaSucTemporal(zonaSeleccionada);
                actualizarListas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                MessageBox.Show("Se guardaron los datos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                regresarAlMenu();
            }
        }


    }
}
