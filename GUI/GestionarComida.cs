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
    public partial class GestionarComida : Form
    {
        private byte rol, opcion;
        private Dieta dieta;
        private Comida comida;
        private delegate bool metodoDelegado();


        // ---------------------- METODOS AL INICIAR -----------------------------
        public GestionarComida(byte rol)
        {
            dieta = new Dieta(rol);
            comida = new Comida(rol);
            InitializeComponent();
            this.rol = rol;
            this.opcion = 0;
        }

        public GestionarComida(byte rol, Comida comida)
        {
            dieta = new Dieta(rol);
            this.comida = comida;
            InitializeComponent();
            this.rol = rol;
            this.opcion = 1;
            cargarDatos();

        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 2)
            {
                chkAutorizado.Enabled = false;
                chkActivo.Enabled = false;
            }
        }

        private void IngresarComida_Load(object sender, EventArgs e)
        {
            List<string> dietas = dieta.nombresDeDietas();
            lstDietasDisponibles.Items.AddRange(dietas.ToArray());
            bloqueraFuncionalidadesSegunRol(rol);
        }


        // ------------------------ METODOS AUXILIARES -------------------------------
        private void regresarAlMenu()
        {
            Owner.Show();
            Close();
        }

        private void marcarIncorrecto(bool valido, Label obj)
        {
            if (valido)
                obj.ForeColor = System.Drawing.Color.Black;
            else
                obj.ForeColor = System.Drawing.Color.Red;
        }

        public bool validarDatos()
        {
            List<string> listaDietas = lstDietasSeleccionadas.Items.OfType<string>().ToList();
            bool dietas = comida.validarDietas(listaDietas);
            bool nombre = comida.validarNombre(txtNombre.Text);
            bool coccion = comida.validarCoccion(txtCoccion.Text);

            marcarIncorrecto(nombre, lblNombre);
            marcarIncorrecto(coccion, lblTiempoCoccion);
            marcarIncorrecto(dietas, lblDietasSeleccionadas);

            return dietas && nombre && coccion;
        }

        private void actualizarListas()
        {
            List<string> dietasSeleccionadas = comida.dietasSeleccionadas();
            lstDietasSeleccionadas.Items.Clear();
            lstDietasSeleccionadas.Items.AddRange(dietasSeleccionadas.ToArray());

            List<string> dietasDisponibles = comida.dietasDisponibles();
            lstDietasDisponibles.Items.Clear();
            lstDietasDisponibles.Items.AddRange(dietasDisponibles.ToArray());
        }

        private void vaciarCampos()
        {
            txtCoccion.Text = "";
            txtNombre.Text = "";
            chkActivo.Checked = false;
            chkAutorizado.Checked = false;

            foreach (object item in lstDietasDisponibles.Items)
            {
                lstDietasSeleccionadas.Items.Add(item);
            }

            lstDietasDisponibles.ClearSelected();


        }

        // --------------------------- CARGAR / GUARDAR DATOS ---------------------------------
        private void cargarDatos()
        {
            txtNombre.Text = comida.Nombre;
            txtCoccion.Text = comida.Coccion.ToString();
            chkActivo.Checked = comida.Activo;
            chkAutorizado.Checked = comida.Autorizado;
            cargarLitaDietasDeLaComida();
            actualizarListas();
        }

        private void cargarLitaDietasDeLaComida()
        {
            lstDietasSeleccionadas.Items.Clear();
            foreach (Dieta dieta in comida.Dietas)
            {
                comida.agregarDieta(dieta.Nombre);
            }
        }

        private void actualizarDatos()
        {
            comida.Nombre = txtNombre.Text;
            comida.Coccion = Int32.Parse(txtCoccion.Text);
            comida.Activo = chkActivo.Checked;
            comida.Autorizado = chkAutorizado.Checked;
            comida.actualizarListaDeDietas(lstDietasSeleccionadas.Items.OfType<string>().ToList());
        }

        private void guardarCambios(metodoDelegado metodo)
        {
            if (validarDatos())
            {
                actualizarDatos();
                bool resultado = metodo();
                if (resultado)
                {
                    MessageBox.Show("Se guardaron los cambios.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (opcion == 0)
                        vaciarCampos();
                }
                else
                    MessageBox.Show("No se guardaron los cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ------------------------------ METODOS WIDGETS ------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (opcion == 0)
                guardarCambios(comida.ingresar);
            else if (opcion == 1)
                guardarCambios(comida.modificar);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string itemSeleccionado = lstDietasDisponibles.SelectedItem.ToString();
                comida.agregarDieta(itemSeleccionado);
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
                string itemSeleccionado = lstDietasSeleccionadas.SelectedItem.ToString();
                comida.quitarDieta(itemSeleccionado);
                actualizarListas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
