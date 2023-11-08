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
        private byte rol;
        private Sucursal sucursal;
        private List<Sucursal> listaSucursales;


        // ----------- CONSTRUCTOR ---------------
        public ListarSucursales(byte rol)
        {
            this.rol = rol;
            sucursal = new Sucursal(rol);
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

        private void cargarGrilla()
        {
            listaSucursales = sucursal.todasLasSucursales();

            dgvSucursal.Rows.Clear();
            foreach (Sucursal s in listaSucursales)
            {
                dgvSucursal.Rows.Add(s.Id, s.CapProd, s.Activo);
            }
        }


        // ----------------- METODOS WIDGETS --------------------------
        private void ListarSucursales_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        // Botones
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en mantenimiento", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*
            Sucursal sucursal = seleccionarSucursal();
            DetallesSucursal detallesSucursal = new DetallesSucursal(this.rol, sucursal);
            detallesSucursal.Show(Owner);
            Close();
            */
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en mantenimiento", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*
            GestionarSucursal gestionarSucursal = new GestionarSucursal(rol);
            gestionarSucursal.Show(Owner);
            Close();
            */
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            sucursal = seleccionarSucursal();
            bool res = sucursal.baja(sucursal.Id);
            if (res)
            {
                MessageBox.Show("Se guardaron los valores cambiados.");
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("No se han logrado cambiar los valores.");
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            sucursal = seleccionarSucursal();
            bool res = sucursal.alta(sucursal.Id);
            if (res)
            {
                MessageBox.Show("Se guardaron los valores cambiados.");
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("No se han logrado cambiar los valores.");
            }
        }
    }
}
