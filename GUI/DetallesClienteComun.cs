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
    public partial class DetallesClienteComun : Form
    {
        byte rol;
        Logica.Cliente logicaClienteComun;
        public DetallesClienteComun(byte rol)
        {
            InitializeComponent();
            logicaClienteComun = new Cliente(rol);
            this.rol = rol;
            bloqueraFuncionalidadesSegunRol(rol);
        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1 || rol == 4)
                btnModificar.Enabled = false;
        }

        private void cargarDatos()
        {
            /*
            string[] datos = logicaClienteComun.obtenerDatosParticular();
            lblId.Text = "ID: " + datos[0];
            txtDoc.Text = datos[1];

            // Nombre
            txtPrimerNombre.Text = datos[2];
            txtSegundoNombre.Text = datos[3];
            txtPrimerApellido.Text = datos[4];
            txtSegundoApellido.Text = datos[5];

            // Direccion
            txtCalle.Text = datos[6];
            txtNumeroPuerta.Text = datos[7];
            txtEsquina.Text = datos[8];
            txtBarrio.Text = datos[9];

            // Telefonos
            txtTel1.Text = datos[10];
            txtTel2.Text = datos[11];
            txtTel3.Text = datos[12];

            // Mails
            txtMail1.Text = datos[13];
            txtMail2.Text = datos[14];
            txtMail3.Text = datos[15];
            */
        }

        private void DetallesClienteComun_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GestionarClienteComun gestionarClienteComun = new GestionarClienteComun(rol);
            gestionarClienteComun.Show(Owner);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ListarCliente listarCliente = new ListarCliente(this.rol);
            listarCliente.Show(Owner);
            Close();
        }
    }
}
