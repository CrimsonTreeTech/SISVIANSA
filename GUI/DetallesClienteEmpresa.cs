using System;
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
    public partial class DetallesClienteEmpresa : Form
    {
        byte rol;
        Cliente cliente;

        public DetallesClienteEmpresa(byte rol)
        {
            InitializeComponent();
            cliente = new Cliente(rol);
            bloqueraFuncionalidadesSegunRol(rol);
            this.rol = rol;
        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1 || rol == 4)
                btnModificar.Enabled = false;
        }


        private void cargarDatos()
        {
            /*
            string[] datos = cliente.obtenerDatosEmpresa();

            lblRUT.Text = "RUT: " + datos[1];
            txtNombre.Text = datos[2];

            // Direccion
            txtCalle.Text = datos[3];
            txtNumeroPuerta.Text = datos[4];
            txtEsquina.Text = datos[5];
            txtBarrio.Text = datos[6];

            // Telefonos
            txtTel1.Text = datos[7];
            txtTel2.Text = datos[8];
            txtTel3.Text = datos[9];

            // Mails
            txtMail1.Text = datos[10];
            txtMail2.Text = datos[11];
            txtMail3.Text = datos[12];
            */
        }

        private void DetallesClienteEmpresa_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GestionarClienteEmpresa gestionarClienteEmpresa = new GestionarClienteEmpresa(rol);
            gestionarClienteEmpresa.Show(Owner);
            Close();
        }
    }
}
