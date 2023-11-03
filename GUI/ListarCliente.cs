using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class ListarCliente : Form
    {
        byte rol;
        public ListarCliente(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            bloqueraFuncionalidadesSegunRol(rol);
        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1)
                btnDarBaja.Enabled = false;
            else if (rol == 4)
            {
                btnDarBaja.Enabled = false;
                btnAutorizar.Enabled = false;
            }
        }


        private void VisualizarCliente_Load(object sender, EventArgs e)
        {
            vaciarCamposFiltros();
            inhabilitarCamposFiltros();
            vaciarCamposOrden();
            inhabilitarCamposOrden();
        }



        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            vaciarCamposFiltros();
            vaciarCamposOrden();
        }

        private void rbtnFiltrarID_Click(object sender, EventArgs e)
        {
            vaciarCamposFiltros();
            inhabilitarCamposFiltros();
            rbtnFiltrarID.Checked = true;
            txtId.Enabled = true;
        }

        private void rbtnFiltrarDoc_Click(object sender, EventArgs e)
        {
            vaciarCamposFiltros();
            inhabilitarCamposFiltros();
            rbtnFiltrarDoc.Checked = true;
            txtDoc.Enabled = true;
        }

        private void rbtnFiltrarNombre_Click(object sender, EventArgs e)
        {
            vaciarCamposFiltros();
            inhabilitarCamposFiltros();
            rbtnFiltrarNombre.Checked = true;
            txtNombre.Enabled = true;
        }

        private void rbtnFiltrarTipo_Click(object sender, EventArgs e)
        {
            vaciarCamposFiltros();
            inhabilitarCamposFiltros();
            rbtnFiltrarTipo.Checked = true;
            cboTipo.Enabled = true;
        }

        private void rbtnOrdenarID_Click(object sender, EventArgs e)
        {
            vaciarCamposOrden();
            inhabilitarCamposOrden();
            rbtnOrdenarID.Checked = true;
            cboOrdenId.Enabled = true;
        }

        private void rbtnOrdenDoc_Click(object sender, EventArgs e)
        {
            vaciarCamposOrden();
            inhabilitarCamposOrden();
            rbtnOrdenDoc.Checked = true;
            cboOrdenDoc.Enabled = true;
        }

        private void rbtnOrdenNombre_Click(object sender, EventArgs e)
        {
            vaciarCamposOrden();
            inhabilitarCamposOrden();
            rbtnOrdenNombre.Checked = true;
            cboOrdenNombre.Enabled = true;
        }

        private void rbtnOrdenTipo_Click(object sender, EventArgs e)
        {
            vaciarCamposOrden();
            inhabilitarCamposOrden();
            rbtnOrdenTipo.Checked = true;
            cboOrdenTipo.Enabled = true;
        }





        ///// MEDOTOS AUXILIARES 
        private void vaciarCamposFiltros()
        {
            rbtnFiltrarDoc.Checked = false;
            rbtnFiltrarID.Checked = false;
            rbtnFiltrarNombre.Checked = false;
            rbtnFiltrarTipo.Checked = false;
            txtId.Clear();
            txtDoc.Clear();
            txtNombre.Clear();
            cboTipo.SelectedItem = null;
            inhabilitarCamposFiltros();
        }

        private void vaciarCamposOrden()
        {
            rbtnOrdenarID.Checked = false;
            rbtnOrdenDoc.Checked = false;
            rbtnOrdenNombre.Checked = false;
            rbtnOrdenTipo.Checked = false;
            cboOrdenDoc.SelectedItem = null;
            cboOrdenId.SelectedItem = null;
            cboOrdenNombre.SelectedItem = null;
            cboOrdenTipo.SelectedItem = null;
            inhabilitarCamposOrden();
        }

        private void inhabilitarCamposFiltros()
        {
            txtId.Enabled = false;
            txtDoc.Enabled = false;
            txtNombre.Enabled = false;
            cboTipo.Enabled = false;
        }

        private void inhabilitarCamposOrden()
        {
            cboOrdenId.Enabled = false;
            cboOrdenDoc.Enabled = false;
            cboOrdenNombre.Enabled = false;
            cboOrdenTipo.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private byte tipoClienteSeleccionado()
        {
            // 0 - Error
            // 1 - Comun
            // 2 - Empresa
            return 1;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (tipoClienteSeleccionado() == 1)
            {
                DetallesClienteComun detallesClienteComun = new DetallesClienteComun(this.rol);
                detallesClienteComun.Show(Owner);
                Close();
            }
        }

        private void rbtnTodos_Click(object sender, EventArgs e)
        {

        }
    }
}
