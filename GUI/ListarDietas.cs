using MySqlX.XDevAPI;
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

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class ListarDietas : Form
    {
        private byte rol;
        private int filaSeleccionada, idDietaSeleccionada;
        private string colFiltro = "activo y autorizado";
        private Dieta dieta;
        private List<Dieta> listaDietas;

        // ----------------------- CONSTRUCTOR  --------------------------
        public ListarDietas(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            dieta = new Dieta(rol);
        }


        // ----------------------- METODOS AUXILIARES ------------------------------
        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1)
            {
                btnModificar.Enabled = false;
            }
            else if (rol == 2)
            {
                btnAlta.Enabled = false;
                btnBaja.Enabled = false;
                btnAutorizar.Enabled = false;
            }
        }

        private void regresarAlMenu()
        {
            Owner.Show();
            Close();
        }

        private Dieta seleccionarDieta()
        {
            Dieta dieta = new Dieta(this.rol)
            {
                Id = Convert.ToInt32(dgvDieta.SelectedCells[0].Value),
                Nombre = dgvDieta.SelectedCells[0].Value.ToString(),
                Activo = Convert.ToBoolean(dgvDieta.SelectedCells[0].Value),
            };
            return dieta;
        }

        private void cargarListado(List<Dieta> listaDietas)
        {
            dgvDieta.Rows.Clear();

            foreach (Dieta dieta in listaDietas)
            {
                dgvDieta.Rows.Add(dieta.Id, dieta.Nombre, dieta.Activo, dieta.Autorizado);
            }
        }

        private int obtenreIdDietaSeleccionada()
        {
            filaSeleccionada = dgvDieta.CurrentCell.RowIndex;
            idDietaSeleccionada = Convert.ToInt32(dgvDieta.Rows[filaSeleccionada].Cells[0].Value);
            return idDietaSeleccionada;
        }

        private void realizarBusqueda()
        {
            listaDietas = dieta.busquedaFiltrada(colFiltro);
            cargarListado(listaDietas);
        }

        // ---------------------- METODOS WIDGETS --------------------------
        private void ListarDietas_Load(object sender, EventArgs e)
        {
            bloqueraFuncionalidadesSegunRol(rol);
            listaDietas = dieta.busquedaFiltrada(colFiltro);
            cargarListado(listaDietas);
            rbtnActivasYAutorizadas.Checked = true;
        }


        // Botones
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Dieta dietaSeleccionada = seleccionarDieta();
            GestionarDieta gestionarDieta = new GestionarDieta(this.rol, dietaSeleccionada);
            gestionarDieta.Show(Owner);
            Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            realizarBusqueda();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            idDietaSeleccionada = obtenreIdDietaSeleccionada();
            bool res = dieta.bajaDieta(idDietaSeleccionada);
            if (res)
            {
                MessageBox.Show("Se autorizo la dieta");
                realizarBusqueda();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            idDietaSeleccionada = obtenreIdDietaSeleccionada();
            bool res = dieta.altaDieta(idDietaSeleccionada);
            if (res)
            {
                MessageBox.Show("Se dio de alta la dieta");
                realizarBusqueda();
            }
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            idDietaSeleccionada = obtenreIdDietaSeleccionada();
            bool res = dieta.autorizarDieta(idDietaSeleccionada);
            if (res)
            {
                MessageBox.Show("Se autorizo la dieta");
                realizarBusqueda();
            }

        }


        // Radiobuttons
        private void rbtnTodo_Click(object sender, EventArgs e)
        {
            colFiltro = "todo";
        }

        private void rbtnActivasYAutorizadas_Click(object sender, EventArgs e)
        {
            colFiltro = "activo y autorizado";
        }

        private void rbtnInactivas_Click(object sender, EventArgs e)
        {
            colFiltro = "inactivo";
        }

        private void rbtnNoAutorizadas_Click(object sender, EventArgs e)
        {
            colFiltro = "no autorizado";
        }

    
    }
}
