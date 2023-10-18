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
    public partial class ListarSucursales : Form
    {
        byte rol;
        Sucursal sucursal;
        public ListarSucursales(byte rol)
        {
            this.rol = rol;
            InitializeComponent();
        }

        // ------------------ METODOS AUXILIARES ---------------------------

        private Sucursal seleccionarSucursal()
        {
            try
            {
                sucursal = new Sucursal(rol)
                {
                    Id = Convert.ToInt32(dgvSucursal.SelectedCells[0].Value),
                    CapProd = Convert.ToInt32(dgvSucursal.SelectedCells[1].Value),
                    Activo = Convert.ToBoolean(dgvSucursal.SelectedCells[2].Value)
                };
                sucursal.obtenerZonas();
                sucursal.obtenerMeta();
                return sucursal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha seleccionado ningun usuario");
                return null;
            }

        }


        // ----------------- METODOS WIDGETS --------------------------
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = seleccionarSucursal();
            DetallesSucursal detallesSucursal = new DetallesSucursal(this.rol, sucursal);
            detallesSucursal.Show(Owner);
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GestionarSucursal gestionarSucursal = new GestionarSucursal(rol);
            gestionarSucursal.Show(Owner);
            Close();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {

        }
    }
}
