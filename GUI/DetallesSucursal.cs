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
    public partial class DetallesSucursal : Form
    {
        private byte rol;
        private Sucursal sucursal;
        
        public DetallesSucursal(byte rol, Sucursal sucursal)
        {
            InitializeComponent();
            this.rol = rol;
            this.sucursal = sucursal;
        }

        private void regresarAlMenu()
        {
            Owner.Show();
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }

        private void cargarDatos()
        {
            txtNombre.Text = sucursal.Id.ToString();
            txtCapProd.Text = sucursal.CapProd.ToString();
            rtxtMetas.Text = sucursal.Meta;

            foreach(Zona z in sucursal.Zonas)
            {
                lstZonasCubiertas.Items.Add(z.Id);
            }
        }

        private void DetallesSucursal_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
