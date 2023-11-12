using SISVIANSA_ITI_2023.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class ListarViandas : Form
    {
        private byte rol;
        private int idSucursal;
        private string colFiltro, valFiltro;
        private Sucursal sucursal;
        private List<Sucursal> listaSucursales;

        // -------------- CONSTRUCTOR --------------------
        public ListarViandas(byte rol, int idSucursal)
        {
            InitializeComponent();
            this.rol = rol;
            this.idSucursal = idSucursal;
            sucursal = new Sucursal(rol);
        }


        // ----------- METODOS AUXILIARES -------------
        private void reiniciarFiltros()
        {
            txtMenu.Clear();
            txtVencimiento.Clear();
            cboSucursal.SelectedIndex = -1;

            txtMenu.Enabled = false;
            txtVencimiento.Enabled = false;
            cboSucursal.Enabled = false;

        }

        private void cargarCboSucursal()
        {
            cboSucursal.Items.Clear();

            if (rol == 1)
            {
                listaSucursales = sucursal.todasLasSucursales();
                foreach (Sucursal s in listaSucursales)
                {
                    cboSucursal.Items.Add(s.Id.ToString());
                }
            }
            else if (rol == 2)
            {
                cboSucursal.Items.Add(idSucursal.ToString());
            }

            cboSucursal.SelectedIndex = 0;
        }

        // --------------------- METODOS DE WIDGETS -----------------------
        private void ListarViandas_Load(object sender, EventArgs e)
        {
            reiniciarFiltros();

            if (rol == 1)
            {
                rbtnTodo.Checked = true;
            }
            else if (rol == 2)
            {
                rbtnTodo.Enabled = false;
                rbtnSucursal.Checked = true;
                cargarCboSucursal();
            }
        }

        // Radio buttons
        private void rbtnTodo_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            colFiltro = "todo";
        }

        private void rbtnSucursal_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            cboSucursal.Enabled = true;
            cargarCboSucursal();
            colFiltro = "suc";
        }

        private void rbtnMenu_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            txtMenu.Enabled = true;
            colFiltro = "menu";
        }

        private void rbtnVencimiento_Click(object sender, EventArgs e)
        {
            reiniciarFiltros();
            txtVencimiento.Enabled = true;
            colFiltro = "vencimiento";
        }

        // Buttons
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnDesechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad se encuentra actualmente en mantenimiento.", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


    }
}
