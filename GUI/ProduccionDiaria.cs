﻿using SISVIANSA_ITI_2023.Logica;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class ProduccionDiaria : Form
    {
        private byte rol;
        private int idSucursal;
        private bool estaProcesandoEndCellEdit = false;

        private int capProdScursal, capProdActual;
        private int filaSeleccionada, colSeleccionada;
        private Produccion produccion;
        private Sucursal sucursal;
        private List<Produccion> listaProduccion;

        // --------------- CONSTRUCTOR -------------------
        public ProduccionDiaria(byte rol, int idSucursal)
        {
            InitializeComponent();
            this.rol = rol;
            this.idSucursal = idSucursal;
            produccion = new Produccion(rol);
            sucursal = new Sucursal(rol);
            capProdScursal = sucursal.obtenerCapProdScursal(idSucursal);
            capProdActual = capProdScursal;
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
                dgvProduccion.Rows.Add(item.IdMenu, item.LoteMin, item.Cantidad, item.LoteMax, item.ProdMenu);
            }
            txtCapProdSuc.Text = capProdActual.ToString();
        }

        private List<Produccion> obtenerListadoProduccion()
        {
            listaProduccion = new List<Produccion>();
            foreach (DataGridViewRow row in dgvProduccion.Rows)
            {
                produccion = new Produccion(rol)
                {
                    IdMenu = Convert.ToInt32(row.Cells[0].Value),
                    Cantidad = Convert.ToInt32(row.Cells[1].Value),
                    LoteMin = Convert.ToInt32(row.Cells[2].Value),
                    LoteMax = Convert.ToInt32(row.Cells[3].Value),
                    Prioridad = Convert.ToInt32(row.Cells[4].Value),
                };
                listaProduccion.Add(produccion);
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



        // --------------- METODOS WIDGETS ------------------
        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            listaProduccion = obtenerListadoProduccion();
            /*
            byte nivelDeError = produccion.validarPrioridad(listaProduccion);
            if (nivelDeError == 0)
                guardarCambios();
            else if (nivelDeError == 2)
                MessageBox.Show("No se han completado todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (nivelDeError == 1)
                MessageBox.Show("El valor de prioridad no puede repetirse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Ha ocurrido un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            */
            MenuCocina menuCocina = new MenuCocina(rol, idSucursal);
            menuCocina.Show(Owner);
            Close();

        }

        private void ProduccionDiaria_Load(object sender, EventArgs e)
        {
            produccion.crearTablaTemporaProduccion(idSucursal);
            cargarDatos();
        }

        private void dgvProduccion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProduccion.Rows.Count)
            {
                DataGridViewRow row = dgvProduccion.Rows[e.RowIndex];
                Produccion item = listaProduccion[e.RowIndex];

                if (item.calcularBajoStock())
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = dgvProduccion.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = dgvProduccion.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void dgvProduccion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (estaProcesandoEndCellEdit)
                return;

            estaProcesandoEndCellEdit = true;

            int celdaSeleccionada = e.RowIndex;
            DataGridViewCell celda = dgvProduccion.Rows[celdaSeleccionada].Cells[4];
            string valorActualizado = celda.Value.ToString();
            bool produccionValida = produccion.comprobarInformacionValida(valorActualizado);
            if (!produccionValida)
            {
                MessageBox.Show("El valor debe ser un número mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                celda.Value = "";
                dgvProduccion.ClearSelection();
                dgvProduccion.CurrentCell = celda;
            }
            estaProcesandoEndCellEdit = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            SeleccionarSucursal seleccionarSucursal = new SeleccionarSucursal(rol);
            seleccionarSucursal.Show(Owner);
            Close();
        }

        private void dgvProduccion_Click(object sender, EventArgs e)
        {
            /* Evita que se escriban valores en la columna de cantidad a producir si no se determino el valor de prioridad antes. */
            DataGridViewCell celda = dgvProduccion.CurrentCell;
            colSeleccionada = celda.ColumnIndex;
            filaSeleccionada = celda.RowIndex;
            if(colSeleccionada == 6)
            {
                var celdaPrioridad = dgvProduccion.Rows[filaSeleccionada].Cells[5].Value;
                if (celdaPrioridad == null)
                {
                    MessageBox.Show("Debe asignar un valor de prioridad antes de determinar una cantidad a producir.");
                    dgvProduccion.ClearSelection();
                }
            }

        }
    }
}
