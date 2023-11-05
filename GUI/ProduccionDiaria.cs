using SISVIANSA_ITI_2023.Logica;
using System.Collections.Generic;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class ProduccionDiaria : Form
    {
        private byte rol;
        private bool vieneDelMenuCocina;
        private Produccion produccion;
        private Sucursal sucursal;
        private List<Produccion> listaProduccion;

        // Variables relacionadas a la capacidad de produccion
        private int idSucursal, capProdSucursal, capProdActual;
        private int stockMaximo, stockActual, stockFaltante, valorPrioridad;
        private bool noRepetido;
        private DataGridViewRow filaClonada;
        private List<int> valoresDePrioridades;

        // Variables usados en la validacion de la data grid view
        private DataGridViewCell celda;
        private int filaSeleccionada, colSeleccionada;
        private string valorCeldaModificada;
        private bool produccionValida, estaProcesandoEndCellEdit = false, procesandoIncersion = false;


        // --------------- CONSTRUCTOR -------------------
        public ProduccionDiaria(byte rol, int idSucursal, bool vieneDelMenuCocina)
        {
            InitializeComponent();
            this.rol = rol;
            this.idSucursal = idSucursal;
            this.vieneDelMenuCocina = vieneDelMenuCocina;
            produccion = new Produccion(rol);
            sucursal = new Sucursal(rol);
            capProdSucursal = sucursal.obtenerCapProdScursal(idSucursal);
            capProdActual = capProdSucursal;
            valoresDePrioridades = new List<int>();
            actualizarCapProd();
        }


        // -------------- METODOS AUXILIARES -------------------
        private void cargarDatos()
        {
            dgvProduccion.Rows.Clear();

            if (produccion.ListaProduccion == null)
                listaProduccion = produccion.listadoDeProduccion(idSucursal);
            else
                listaProduccion = produccion.ListaProduccion;


            foreach (Produccion item in listaProduccion)
            {
                dgvProduccion.Rows.Add(item.IdMenu, item.LoteMin, item.CantidadEnStock, item.LoteMax, item.ProdMenu);
            }
        }

        private List<Produccion> obtenerListadoProduccion()
        {
            listaProduccion = new List<Produccion>();
            try
            {
                foreach (DataGridViewRow row in dgvProduccion.Rows)
                {
                    produccion = new Produccion(rol)
                    {
                        IdMenu = Convert.ToInt32(row.Cells[0].Value),
                        LoteMin = Convert.ToInt32(row.Cells[1].Value),
                        CantidadEnStock = Convert.ToInt32(row.Cells[2].Value),
                        LoteMax = Convert.ToInt32(row.Cells[3].Value),
                        ProdMenu = Convert.ToInt32(row.Cells[4].Value),
                        Prioridad = Convert.ToInt32(row.Cells[5].Value),
                        CantAProducir = Convert.ToInt32(row.Cells[6].Value)
                    };
                    listaProduccion.Add(produccion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nVuelva a intentar la acción o llame a un técnico");
            }
            return listaProduccion;
        }

        private void guardarCambios()
        {
            DialogResult result = MessageBox.Show("¿Deseas establecer el siguiente orden para la producciòn del dìa?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                produccion.ListaProduccion = obtenerListadoProduccion();
                MenuCocina menuCocina = new MenuCocina(rol, idSucursal);
                menuCocina.Show(Owner);
                Close();
            }
        }

        private void actualizarCapProd()
        {
            txtCapProdSuc.Text = capProdActual.ToString();
        }

        // Data grid view

        private void comprobarValorPrioridad(int filaCeldaModificada)
        {
            celda = dgvProduccion.Rows[filaCeldaModificada].Cells[5]; // Averigua el valor de la celda modificada
            valorCeldaModificada = celda.Value.ToString(); // Convierte a string el valor de la celda modificada
            listaProduccion = obtenerListadoProduccion(); // Obtiene una lista con los valores de produccion ingresados
            produccionValida = produccion.comprobarValorPrioridad(valorCeldaModificada); // Devuelve si el valor es correcto o no

            if (produccionValida) // Si la produccion es valida
            {
                valorPrioridad = Convert.ToInt32(valorCeldaModificada);
                noRepetido = !valoresDePrioridades.Contains(valorPrioridad);
                if (noRepetido)
                {
                    calcularStockFaltantePorDefecto(filaCeldaModificada); // Calcula el stock faltante y lo muestra en la grilla
                    calcularCapProdActual(); // Actualiza el valor de los minutos de produccion restantes
                    valoresDePrioridades.Add(valorPrioridad); // Agrega el valor a la lista de prioridades seleccionadas
                }
                else
                {
                    MessageBox.Show("El valor no puede estar repetido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    celda.Value = "";
                    dgvProduccion.ClearSelection();
                }

            }
            else
            {
                MessageBox.Show("El valor debe ser un número mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                celda.Value = "";
                dgvProduccion.ClearSelection();
            }
        }

        private void calcularStockFaltantePorDefecto(int filaCeldaModificada)
        {
            /* -- Muestra el stock faltante automaticamente al completar el valor de prioridad -- */
            stockActual = Convert.ToInt32(dgvProduccion.Rows[filaCeldaModificada].Cells[2].Value); // Obtiene el valor del stock actual
            stockMaximo = Convert.ToInt32(dgvProduccion.Rows[filaCeldaModificada].Cells[3].Value); // Obtiene el valor del stock maximo
            stockFaltante = stockMaximo - stockActual; // Calcula el stock faltante
            dgvProduccion.Rows[filaCeldaModificada].Cells[6].Value = stockFaltante; // Lo muestra en la celda
        }

        private void calcularCapProdActual()
        {
            listaProduccion = obtenerListadoProduccion(); // Obtiene los datos de la grilla
            capProdActual = produccion.calcularCapProdActualDeSucursal(listaProduccion, capProdSucursal); // Obtiene la capacidad de produccion restante
            actualizarCapProd(); // Actualiza los valores de produccion de sucursal
        }

        private void comprobarValorCantidadAProducir(int filaCeldaModificada)
        {
            celda = dgvProduccion.Rows[filaCeldaModificada].Cells[6];
            valorCeldaModificada = celda.Value.ToString(); // Obtener el valor de la cantidad a producir
            stockMaximo = Convert.ToInt32(dgvProduccion.Rows[filaCeldaModificada].Cells[3].Value); // Obtener el valor maximo del stock
            produccionValida = produccion.comprobarValorCantidadAProducir(valorCeldaModificada, stockMaximo); // Llamar a un metodo que me diga si es valido o no

            if (produccionValida) // Si es valido, actualizar la cap prod actual
            {
                calcularCapProdActual();
            }
            else // Si no es valido mostrar mensaje de error
            {
                MessageBox.Show("La cantidad a producir debe ser un valor numérico mayor a cero.\nLa suma del stock actual y la cantidad a producir no puede ser mayor al stock maximo");
                dgvProduccion.Rows[filaCeldaModificada].Cells[6].Value = "";
                dgvProduccion.ClearSelection();
            }
        }

        // --------------- METODOS WIDGETS ------------------
        private void ProduccionDiaria_Load(object sender, EventArgs e)
        {
            produccion.crearTablaTemporaProduccion(idSucursal);
            cargarDatos();
        }

        // Botones
        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            listaProduccion = obtenerListadoProduccion();
            byte nivelDeError = produccion.validarListadoDeProduccion(txtCapProdSuc.Text);

            if (nivelDeError == 0)
            {
                guardarCambios();
            }
            else if (nivelDeError == 1)
            {
                MessageBox.Show("La capacidad de produccion de la sucursal no puede superar los 120 minutos.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nivelDeError == 2)
            {
                MessageBox.Show("La capacidad de produccion de la sucursal no puede ser inferior a -120 minutos..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (vieneDelMenuCocina)
            {
                MenuCocina menuCocina = new MenuCocina(rol, idSucursal);
                menuCocina.Show(Owner);
            }
            else
            {
                SeleccionarSucursal seleccionarSucursal = new SeleccionarSucursal(rol);
                seleccionarSucursal.Show(Owner);
            }
            Close();
        }


        // Data grid view
        private void dgvProduccion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                /* -- Pinta de rojo las celdas cuyos valores de stock actual sean iguales o menores al stock minimo -- */
                if (e.RowIndex >= 0 && e.RowIndex < dgvProduccion.Rows.Count)
                {
                    DataGridViewRow row = dgvProduccion.Rows[e.RowIndex];
                    Produccion item = listaProduccion[e.RowIndex];

                    if (item.noTieneBajoStock())
                    {
                        row.DefaultCellStyle.BackColor = row.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.ForeColor = row.DefaultCellStyle.ForeColor;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProduccion_Click(object sender, EventArgs e)
        {
            /* Evita que se escriban valores en la columna de cantidad a producir si no se determino el valor de prioridad antes. */
            DataGridViewCell celda = dgvProduccion.CurrentCell;
            colSeleccionada = celda.ColumnIndex;
            filaSeleccionada = celda.RowIndex;
            if (colSeleccionada == 6)
            {
                var celdaPrioridad = dgvProduccion.Rows[filaSeleccionada].Cells[5].Value;
                if (celdaPrioridad == null)
                {
                    MessageBox.Show("Debe asignar un valor de prioridad antes de determinar una cantidad a producir.");
                    dgvProduccion.ClearSelection();
                }
            }

        }

        private void dgvProduccion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /* -- Llama al metodo de validacion al terminar de modificar las columnas prioridad y cantidad a producir.
             * -- tambien actualiza los valores de capacidad de produccion actual disponible -- */

            // Comprueba que este metodo no se este ejecutando para evitar un bucle infinito
            if (estaProcesandoEndCellEdit)
                return;
            estaProcesandoEndCellEdit = true;


            // Obtiene el indice de la celda que disparo el evento
            filaSeleccionada = e.RowIndex;
            colSeleccionada = e.ColumnIndex;


            if (colSeleccionada == 5) // Si corresponde a la columna de prioridad
                comprobarValorPrioridad(filaSeleccionada); // Realiza las acciones del metodo comprobarValorPrioridad

            if (colSeleccionada == 6) // Si corresponde a la columna de cantidad a producir
                comprobarValorCantidadAProducir(filaSeleccionada); // Realiza las acciones del metodo comprobarValorCantidadAProducir

            // Cuando termina de ejecutarse el metodo, vdeja de procesarce el metodo, por lo que vale falso
            estaProcesandoEndCellEdit = false;
        }



    }
}
