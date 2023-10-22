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
using SISVIANSA_ITI_2023.Logica;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class GestionarMenu : Form
    {
        private byte rol, opcion;
        private Menu menu;
        private Dieta dieta;
        private Comida comida;
        private List<string> nombreDietas;
        private List<string> listaComidasMenuTemporal;


        // ------------------------ METODOS AL INICIAR ------------------------------
        public GestionarMenu(byte rol)
        {
            InitializeComponent();
            menu = new Menu(rol);
            dieta = new Dieta(rol);
            comida = new Comida(rol);
            this.rol = rol;
            this.opcion = 0;
            this.Text = "Ingresar menú";
            bloqueraFuncionalidadesSegunRol(rol);
        }

        public GestionarMenu(byte rol, int idMenu)
        {
            InitializeComponent();
            menu = new Menu(rol);
            menu.cargarDatosDeMenu(idMenu);
            dieta = new Dieta(rol);
            comida = new Comida(rol);
            this.rol = rol;
            this.opcion = 1;
            this.Text = "Modificar menú";
            bloqueraFuncionalidadesSegunRol(rol);
            cargarDatos();
        }


        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 2)
            {
                chkAutorizado.Enabled = false;
                chkPersonalizado.Enabled = false;
            }
        }

        private void IngresarMenu_Load(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = 0;
            List<string> dietas = dieta.nombresDeDietas();
            cargarListaDietas();
        }


        // ------------------------ METODOS DE VALIDACION ---------------------------
        private bool validarDatos()
        {
            bool tipo = menu.campoNoVacio(cboTipo.Text);
            bool precio = menu.esDouble(txtPrecio.Text);
            bool stockMin = menu.esInt(txtMinStock.Text);
            bool stockMax = menu.esInt(txtMaxStock.Text);
            bool congelable = menu.esInt(txtCongelable.Text);
            bool comidas = menu.listaNoVacia(lstComidasMenu.Items.OfType<string>().ToList());

            marcarIncorrecto(tipo, lblTipo);
            marcarIncorrecto(precio, lblPrecio);
            marcarIncorrecto(stockMin, lblMinStock);
            marcarIncorrecto(stockMax, lblMaxStock);
            marcarIncorrecto(congelable, lblCongelable);
            marcarIncorrecto(comidas, lblComidasMenu);

            return tipo && precio && stockMin && stockMax && congelable && comidas;
        }

        private void marcarIncorrecto(bool valido, Label obj)
        {
            if (valido)
                obj.ForeColor = System.Drawing.Color.Black;
            else
                obj.ForeColor = System.Drawing.Color.Red;
        }


        // ------------------------- METODOS AUXILIARES --------------------------------
        private void regresarAlMenu()
        {
            Owner.Show();
            Close();
        }

        private void habilitarListas()
        {
            if (cboTipo.SelectedItem != null)
            {
                lstComidasDisponibles.Enabled = true;
                lstComidasMenu.Enabled = true;
                btnAgregarComida.Enabled = true;
                btnQuitarComida.Enabled = true;
            }
        }

        private void completarListaComidasMenu(bool agregar, string comida)
        {
            // Obtiene la lista de los items en la listbox lstComidasMenu
            List<string> listaMenuTemporal = lstComidasMenu.Items.OfType<string>().ToList();

            // Agrega o quitala comida seleccionada
            if (agregar)
            {
                string tipoMenu = cboTipo.Text;
                listaComidasMenuTemporal = menu.listaTemporalDeComidas(comida, listaMenuTemporal, tipoMenu);
            }
            else
            {
                listaMenuTemporal.Remove(comida);
            }

            // Limpia la lista de comidas seleccionadas
            lstComidasMenu.Items.Clear();

            // Completa con los valores actualizados la lista de comidas
            lstComidasMenu.Items.AddRange(listaMenuTemporal.ToArray());
        }

        private void cambiarOpcionesMenu()
        {
            if (lstComidasMenu.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Al realizar este cambio se vaciará la lista de comidas seleccionadas. ¿Desea continuar con la acción?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    lstComidasMenu.Items.Clear();
                }
            }

        }

        private void cargarListaDietas()
        {
            nombreDietas = dieta.nombresDeDietas();
            ckLstDietas.Items.AddRange(nombreDietas.ToArray());
        }


        // ------------------------- CARGAR / GUARDAR DATOS ---------------------------
        private void cargarDatos()
        {
            chkPersonalizado.Checked = menu.Personalizado;
            chkAutorizado.Checked = menu.Autorizado;
            chkActivo.Checked = menu.Activo;

            cboTipo.Text = menu.Tipo;

            txtId.Text = "Menu " + menu.Id.ToString();
            txtPrecio.Text = menu.Precio.ToString();
            txtStockActual.Text = menu.StockActual.ToString();
            txtMinStock.Text = menu.StockMin.ToString();
            txtMaxStock.Text = menu.StockMax.ToString();
            txtCongelable.Text = menu.Congelable.ToString();

            rtxtSugerencias.Text = menu.Sugerencia;
        }



        // ---------------------------- METODOS WIDGETS ------------------------------

        // Combobox
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarListas();
        }

        private void cboTipo_Click(object sender, EventArgs e)
        {
            cambiarOpcionesMenu();
        }


        // Botones
        private void btnAgregarComida_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtiene la comida seleccionada
                string comidaSeleccionada = lstComidasDisponibles.SelectedItem.ToString();

                // Actualiza la lista mostrada en la interfaz
                completarListaComidasMenu(true, comidaSeleccionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una comida para eliminar del menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarComida_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtiene la comida seleccionada
                string comidaSeleccionada = lstComidasMenu.SelectedItem.ToString();

                // Actualiza la lista mostrada en la interfaz
                completarListaComidasMenu(false, comidaSeleccionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una comida para eliminar del menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                MessageBox.Show("Se ingresó el menú correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                regresarAlMenu();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }


    }
}
