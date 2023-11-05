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
    public partial class DetallesCliente : Form
    {
        private byte rol;
        private Cliente cliente;


        // ---------------- CONSTRUCTOR ------------------
        public DetallesCliente(byte rol, Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.rol = rol;
            bloqueraFuncionalidadesSegunRol(rol);
        }


        // ----------------- METODOS AUXILIARES ------------------
        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1 || rol == 4)
                btnModificar.Enabled = false;
        }

        private void cargarDatos()
        {
            lblId.Text = "ID: " + cliente.Id.ToString();

            txtTipoCliente.Text = cliente.TipoCliente;
            chkAutorizado.Checked = cliente.Autorizado;
            //chkActivo.Checked = cliente.Activo;

            txtNombre.Text = cliente.Nombre;
            lblDoc.Text = cliente.TipoDoc;
            txtDoc.Text = cliente.Doc.ToString();

            txtCalle.Text = cliente.Calle;
            txtNumeroPuerta.Text = cliente.NroPuerta.ToString();
            txtEsquina.Text = cliente.Esq;

            txtTel1.Text = cliente.Tels[0].ToString();
            //txtTel2.Text = cliente.Tels[1].ToString();
            //txtTel3.Text = cliente.Tels[2].ToString();

            txtMail1.Text = cliente.Mails[0];
            //txtMail2.Text = cliente.Mails[1];
            //txtMail3.Text = cliente.Mails[2];
        }



        // ------------------- METODOS DE WIDGETS -----------------
        private void DetallesClienteComun_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GestionarCliente gestionarCliente = new GestionarCliente(rol, cliente);
            gestionarCliente.Show(Owner);
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
