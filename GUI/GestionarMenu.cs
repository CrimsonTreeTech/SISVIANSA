using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        private List<Dieta> listaDietas;
        private List<Comida> listaComidas;
        private List<string> nombreDietas;
        private List<string> listaComidasMenuTemporal;
        private List<string> listaComidasMenuDisponibles;
        private List<string> listaDietasSeleccionadas;


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
            listaDietasSeleccionadas = new List<string>();
            listaComidasMenuDisponibles = new List<string>();
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
                chkActivo.Enabled = false;
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
            bool precio = menu.validarPrecio(txtPrecio.Text);
            bool stockActual = menu.esIntPositivo(txtStockActual.Text);
            bool stockMin = menu.verificarStockMin(txtMinStock.Text, txtMaxStock.Text);
            bool stockMax = menu.esIntPositivo(txtMaxStock.Text);
            bool congelable = menu.esIntPositivo(txtCongelable.Text);
            bool comidas = menu.listaNoVacia(lstComidasMenu.Items.OfType<string>().ToList());

            marcarIncorrecto(tipo, lblTipo);
            marcarIncorrecto(precio, lblPrecio);
            marcarIncorrecto(stockActual, lblStockActual);
            marcarIncorrecto(stockMin, lblMinStock);
            marcarIncorrecto(stockMax, lblMaxStock);
            marcarIncorrecto(congelable, lblCongelable);
            marcarIncorrecto(comidas, lblComidasMenu);

            return tipo && precio && stockActual && stockMin && stockMax && congelable && comidas;
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

        private void actualizarListasTemporales(bool agregar, string comida)
        {
            // Obtiene la lista de los items en la listbox lstComidasMenu
            listaComidasMenuTemporal = lstComidasMenu.Items.OfType<string>().ToList();

            // Agrega o quitala comida seleccionada
            if (agregar)
            {
                string tipoMenu = cboTipo.Text;
                listaComidasMenuTemporal = menu.listaTemporalDeComidas(comida, listaComidasMenuTemporal, tipoMenu);
            }
            else
            {
                listaComidasMenuTemporal.Remove(comida);
                listaComidasMenuDisponibles.Add(comida);
            }

            // Limpia la lista de comidas seleccionadas
            lstComidasMenu.Items.Clear();

            // Ordena la lista de comidas temporales
            listaComidasMenuTemporal.Sort();

            // Completa con los valores actualizados la lista de comidas
            lstComidasMenu.Items.AddRange(listaComidasMenuTemporal.ToArray());

            // Borra las comidas seleccionadas de la lista de comidas disponibles
            foreach (string nombreComida in listaComidasMenuTemporal)
            {
                listaComidasMenuDisponibles.Remove(nombreComida);
            }

            // Ordena la lista de comidas disponibles
            listaComidasMenuDisponibles.Sort();

            // Vacia la listbox de comidas disponibles
            lstComidasDisponibles.Items.Clear();

            // Completa la listbox con la lista de comidas disponibles actualizada
            lstComidasDisponibles.Items.AddRange(listaComidasMenuDisponibles.ToArray());
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
            chkLstDietas.Items.AddRange(nombreDietas.ToArray());
        }

        private void habilitarChkLstDietas()
        {
            if (lstComidasMenu.Items.Count == 0)
            {
                chkLstDietas.Enabled = true;
            }
            else
            {
                chkLstDietas.Enabled = false;
            }
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

            chekcearDietasDeMenu();
        }

        private void chekcearDietasDeMenu()
        {
            listaDietas = menu.Dietas;

            foreach (Dieta dieta in listaDietas)
            {
                if (chkLstDietas.Items.Contains(dieta.Nombre))
                {
                    int indx = chkLstDietas.Items.IndexOf(dieta.Nombre);
                    chkLstDietas.SetItemChecked(indx, true);
                }
            }
        }

        private Menu obtenerInformacionParaGuardar()
        {
            Menu menu = new Menu(rol);

            menu.StockMin = Convert.ToInt32(txtMinStock.Text);
            menu.StockMax = Convert.ToInt32(txtMaxStock.Text);
            menu.StockActual = Convert.ToInt32(txtStockActual.Text);
            menu.Congelable = Convert.ToInt32(txtCongelable.Text);
            menu.Tipo = cboTipo.Text;
            menu.Sugerencia = rtxtSugerencias.Text;
            menu.Activo = chkActivo.Checked;
            menu.Autorizado = chkAutorizado.Checked;
            menu.Personalizado = chkPersonalizado.Checked;
            menu.Precio = Convert.ToDouble(txtPrecio.Text);
            menu.Dietas = dieta.obtenerDietasSegunVariosNombres(listaDietasSeleccionadas);
            menu.Comidas = comida.obtenerComidasSegunVariosNombres(listaComidasMenuTemporal);

            return menu;
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

        private void cargarListaDeComidas()
        {
            listaComidasMenuDisponibles = new List<string>();
            listaComidas = comida.listaComidasFiltradas("dietas", listaDietasSeleccionadas);

            lstComidasDisponibles.Items.Clear();
            foreach (Comida comida in listaComidas)
            {
                listaComidasMenuDisponibles.Add(comida.Nombre);
            }

            listaComidasMenuDisponibles.Sort();
            lstComidasDisponibles.Items.AddRange(listaComidasMenuDisponibles.ToArray());
        }


        // Botones
        private void btnAgregarComida_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtiene la comida seleccionada
                string comidaSeleccionada = lstComidasDisponibles.SelectedItem.ToString();

                // Actualiza la lista mostrada en la interfaz
                actualizarListasTemporales(true, comidaSeleccionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una comida para eliminar del menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            habilitarChkLstDietas();
        }

        private void btnQuitarComida_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtiene la comida seleccionada
                string comidaSeleccionada = lstComidasMenu.SelectedItem.ToString();

                // Actualiza la lista mostrada en la interfaz
                actualizarListasTemporales(false, comidaSeleccionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una comida para eliminar del menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            habilitarChkLstDietas();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                menu = obtenerInformacionParaGuardar();
                bool res = menu.ingresar();
                if (res)
                    MessageBox.Show("Se ingresó el menú correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ocurrió un problema.");
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            ListarMenus listarMenus = new ListarMenus(rol);
            listarMenus.Show(Owner);
            Close();
        }

        private void chkLstDietas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool nuevoEstado = (e.NewValue == CheckState.Checked);
            string elementoSeleccionado = chkLstDietas.Items[e.Index].ToString();

            if (nuevoEstado == true)
            {
                listaDietasSeleccionadas.Add(elementoSeleccionado);
            }
            else
            {
                listaDietasSeleccionadas.Remove(elementoSeleccionado);
            }

            cargarListaDeComidas();
        }
    }
}
