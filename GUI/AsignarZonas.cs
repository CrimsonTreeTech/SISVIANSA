using SISVIANSA_ITI_2023.Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventana3
{
    public partial class AsignarZonas : Form
    {
        Vehiculo logicaVehiculos;
        Zona logicaZona;
        Vehiculo vehiculo;
        byte rol;


        // -------------------- METODOS DE INICIO ----------------------
        public AsignarZonas(Vehiculo vehiculo, byte rol)
        {
            InitializeComponent();
            logicaVehiculos = new Vehiculo(rol);
            logicaZona = new Zona(rol);
            this.vehiculo = vehiculo;
            this.rol = rol;
        }

        private void AsignarZonas_Load(object sender, EventArgs e)
        {
            //cargarDatos();
            //actualizarListas();
            nuevometodosensual();
        }

        private void cargarDatos()
        {
            List<Zona> zonasRepartoVehiculo = vehiculo.ListaZonasDeReparto;
            
            if (zonasRepartoVehiculo != null)
            {
                foreach (Zona item in zonasRepartoVehiculo)
                {
                    string cadena = "Zona " + item.Id.ToString();
                    logicaVehiculos.agregarZonaTemporal(cadena);
                }
            }
            
            actualizarListas();
        }

        private void nuevometodosensual()
        {
            List<Zona> zonasRepartoVehiculo = vehiculo.ListaZonasDeReparto;

            foreach (Zona zona in zonasRepartoVehiculo)
            {
                string cadena = "Zona " + zona.Id.ToString();
                logicaVehiculos.agregarZonaTemporal(cadena);
            }

            actualizarListas();

            /*
            if(vehiculo.ListaZonasDeReparto != null)
            {
                List<Zona> zonasRepartoVehiculo = vehiculo.ListaZonasDeReparto;
                string cadena = "";
                foreach (Zona zona in zonasRepartoVehiculo)
                {
                    cadena += zona.Id.ToString();
                }
                MessageBox.Show(cadena);
            }
            MessageBox.Show("Dice que es null");*/

            /*
            try
            {
                if (vehiculo.ListaZonasDeReparto != null)
                {
                    List<Zona> zonasRepartoVehiculo = vehiculo.ListaZonasDeReparto;
                    string cadena = "";
                    foreach (Zona zona in zonasRepartoVehiculo)
                    {
                        cadena += zona.Id.ToString();
                    }
                    MessageBox.Show(cadena);
                }else
                {
                    MessageBox.Show("Dice que es null");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/

        }


        // --------------- METODOS AUXILIARES -------------------
        private void regresarAlListado()
        {
            ListarVehiculo listadoVehiculo = new ListarVehiculo(rol);
            listadoVehiculo.Show(Owner);
            Close();
        }

        // Seleccion de zonas - listbox
        private void agregarListaTemporal()
        {
            try
            {
                string zonaSeleccionada = lstZonasDisponibles.SelectedItem.ToString();
                logicaVehiculos.agregarZonaTemporal(zonaSeleccionada);
                actualizarListas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha seleccionado ninguna zona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Actualiza las listas en pantalla de zonas disponibles y zonas temporales
        private void actualizarListas()
        {
            // Lista zonas seleccionadas
            lstZonasSeleccionadas.Items.Clear();
            List<string> listaZonasSeleccionadas = logicaVehiculos.zonasSeleccionadasTemporales();
            lstZonasSeleccionadas.Items.AddRange(listaZonasSeleccionadas.ToArray());

            // Lista zonas disponibles
            lstZonasDisponibles.Items.Clear();
            List<string> listaZonasDisponibles = logicaVehiculos.zonasDisponiblesTemporales();
            lstZonasDisponibles.Items.AddRange(listaZonasDisponibles.ToArray());
        }

        // Asigna al vehiculo las zonas seleccionadas
        private void actualizarZonas()
        {
            List<string> zonasSeleccionadas = lstZonasSeleccionadas.Items.OfType<string>().ToList();
            List<Zona> zonasReparto = logicaZona.convertirListaDeZonas(zonasSeleccionadas);
            vehiculo.ListaZonasDeReparto = zonasReparto;
        }



        // --------------- METODOS WIDGETS -------------------
        private void btnguardar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea establecer las siguientes zonas para el vehiculo: " + vehiculo.Matricula, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                actualizarZonas();
                vehiculo.ingresarZonas();
                MessageBox.Show("Se han guardado los cambios", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                regresarAlListado();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAlListado();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            agregarListaTemporal();
        }

        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                string zonaSeleccionada = lstZonasSeleccionadas.SelectedItem.ToString();
                logicaVehiculos.quitarZonaTemporal(zonaSeleccionada);
                actualizarListas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha seleccionado ninguna zona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
