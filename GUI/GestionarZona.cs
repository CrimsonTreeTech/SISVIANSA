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
    public partial class GestionarZona : Form
    {
        private byte rol, opcion;
        private delegate bool metodoDelegado();
        private Zona zona;


        // ----------------- METODOS AL INICIAR ---------------------
        public GestionarZona(byte rol)
        {
            InitializeComponent();
            zona = new Zona(rol);
            this.rol = rol;
            opcion = 0;
            this.Text = "Ingresar zona";
        }

        public GestionarZona(byte rol, Zona zona)
        {
            InitializeComponent();
            this.rol = rol;
            this.zona = zona;
            opcion = 1;
            this.Text = "Modificar zona";
        }

        private void IngresarZona_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        // ------------------ METODOS AUXILIARES ----------------------
        private void regresarAlMenu()
        {
            Owner.Show();
            Close();
        }

        private void cargarDatos()
        {
            txtPrecio.Text = zona.Precio.ToString();
            List<string> barrios = zona.Barrios;
            lstBarrios.Items.AddRange(barrios.ToArray());
        }

        private void actualizarDatosZona()
        {
            List<string> listaZonas = lstBarrios.Items.OfType<string>().ToList();
            double precio = Double.Parse(txtPrecio.Text);
            zona.Barrios = listaZonas;
            zona.Precio = precio;
        }

        private void guardarCambios(metodoDelegado metodo)
        {
            bool datosCorrectos = validarDatos();
            if (datosCorrectos)
            {
                actualizarDatosZona();
                bool resultado = metodo();
                if (resultado)
                    MessageBox.Show("Se han guardado los cambios", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se lograron guardar los cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // -------------------- VALIDACION DE DATOS ---------------------
        private void marcarIncorrecto(bool valido, Label obj)
        {
            if (valido)
                obj.ForeColor = System.Drawing.Color.Black;
            else
                obj.ForeColor = System.Drawing.Color.Red;
        }

        private bool validarDatos()
        {
            // Validacion de datos desde logicaZona
            List<string> barriosDeZona = lstBarrios.Items.OfType<string>().ToList();
            bool listaBarrios = zona.validarBarriosZona(barriosDeZona);
            bool precio = zona.validarPrecio(txtPrecio.Text);
            marcarIncorrecto(precio, lblPrecio);
            marcarIncorrecto(listaBarrios, lblListaBarrios);

            // En caso de pulsar el boton aceptar mientras se tenga el campo de nombre de datos con contenido,
            // mostrara una advertencia, diciendo que si acepta, el barrio escrito no se guardara en los cambios
            bool nombreBarrioVacio = String.IsNullOrEmpty(txtNombreBarrio.Text);
            bool nombreBarrioValidado = true;

            if (!nombreBarrioVacio)
            {
                DialogResult resultado = MessageBox.Show("El campo para agregar barrios está completo, si continúa con la acción se perderán los cambios.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                    nombreBarrioValidado = false;
            }
            return listaBarrios && precio && nombreBarrioValidado;
        }


        // -------------------- METODOS WIDGETS -------------------
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (opcion == 0)
                guardarCambios(zona.ingresar);
            else if (opcion == 1)
                guardarCambios(zona.modificar);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string barrio = txtNombreBarrio.Text;
            bool barrioCorrecto = zona.validarBarrio(barrio);
            marcarIncorrecto(barrioCorrecto, lblNombreBarrio);
            bool zonaRepetida = lstBarrios.Items.Contains(barrio);
            if (barrioCorrecto && !zonaRepetida)
                lstBarrios.Items.Add(txtNombreBarrio.Text);
            txtNombreBarrio.Clear();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                string itemSeleccionado = (string)lstBarrios.SelectedItem;
                lstBarrios.Items.Remove(itemSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha seleccionado elemento a borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
