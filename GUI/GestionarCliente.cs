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
    public partial class GestionarCliente : Form
    {
        private byte rol, opcion;
        private delegate bool metodoDelegado();
        private Cliente cliente;
        private List<int?> tels;

        // -------------------------- METODOS AL INICIAR -----------------------------
        public GestionarCliente(byte rol)
        {
            InitializeComponent();
            cliente = new Cliente(rol);
            this.rol = rol;
            this.opcion = 0;
            bloqueraFuncionalidadesSegunRol(rol);
            entradasClienteParticular();
            cboTipoCliente.SelectedItem = "Particular";
        }

        public GestionarCliente(byte rol, Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.rol = rol;
            this.opcion = 1;
            bloqueraFuncionalidadesSegunRol(rol);
            cargarDatos();
        }


        // --------------------------- METODOS AUXILIARES -------------------------------
        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 4)
                chkAutorizado.Enabled = false;
        }

        private void marcarIncorrecto(bool valido, Label obj)
        {
            if (valido)
                obj.ForeColor = System.Drawing.Color.Black;
            else
                obj.ForeColor = System.Drawing.Color.Red;
        }

        private void regresarAlMenu()
        {
            Owner.Show();
            Close();
        }

        private bool validarNombre()
        {
            bool nombre = cliente.verificarCampoNoVacio(txtPrimerNombre.Text);
            marcarIncorrecto(nombre, lblPrimerNombre);

            if (cboTipoCliente.Text.Equals("Particular"))
            {
                bool apellido = cliente.verificarCampoNoVacio(txtPrimerApellido.Text);
                nombre = nombre && apellido;
                marcarIncorrecto(apellido, lblPrimerApellido);
            }

            return nombre;
        }


        private bool validarDatos()
        {
            bool documento = cliente.verificarDocumentos(cboTipoDoc.Text, txtNumDoc.Text);
            bool nombre = validarNombre();
            bool calle = cliente.verificarCampoNoVacio(txtCalle.Text);
            bool esquina = cliente.verificarCampoNoVacio(txtEsquina.Text);
            bool numPuerta = cliente.verificarCampoNumerico(txtNumeroPuerta.Text);
            bool tel1 = cliente.verificarTelefono(txtTel1.Text, false);
            bool tel2 = cliente.verificarTelefono(txtTel2.Text, true);
            bool tel3 = cliente.verificarTelefono(txtTel3.Text, true);
            bool mail1 = cliente.verificarMail(txtMail1.Text, false);
            bool mail2 = cliente.verificarMail(txtMail2.Text, true);
            bool mail3 = cliente.verificarMail(txtMail3.Text, true);

            marcarIncorrecto(documento, lblNumDoc);
            marcarIncorrecto(documento, lblTipoDoc);
            marcarIncorrecto(calle, lblCalle);
            marcarIncorrecto(esquina, lblEsquina);
            marcarIncorrecto(numPuerta, lblNumeroPuerta);
            marcarIncorrecto(tel1, lblTel1);
            marcarIncorrecto(tel2, lblTel2);
            marcarIncorrecto(tel3, lblTel3);
            marcarIncorrecto(mail1, lblMail1);
            marcarIncorrecto(mail2, lblMail2);
            marcarIncorrecto(mail3, lblMail3);

            return documento && nombre && calle && esquina && numPuerta && tel1 && tel2 && tel3 && mail1 && mail2 && mail3;
        }

        private void entradasClienteParticular()
        {
            cboTipoDoc.Items.Clear();
            cboTipoDoc.Items.AddRange(new object[] { "CI", "DNI" });
            cboTipoDoc.SelectedIndex = 0;

            lblPrimerNombre.Text = "Primer nombre *";
            lblSegundoNombre.Text = "Segundo nombre";
            lblPrimerApellido.Text = "Primer apellido *";
            lblSegundoApellido.Text = "Segundo apellido";

            txtPrimerNombre.Enabled = true;
            txtSegundoNombre.Enabled = true;
            txtPrimerApellido.Enabled = true;
            txtSegundoApellido.Enabled = true;
        }

        private void entradasClienteEmpresa()
        {
            cboTipoDoc.Items.Clear();
            cboTipoDoc.Items.AddRange(new object[] { "RUT" });
            cboTipoDoc.SelectedIndex = 0;

            lblPrimerNombre.Text = "Nombre *";
            lblSegundoNombre.Text = "";
            lblPrimerApellido.Text = "";
            lblSegundoApellido.Text = "";

            txtPrimerNombre.Enabled = true;
            txtSegundoNombre.Enabled = false;
            txtPrimerApellido.Enabled = false;
            txtSegundoApellido.Enabled = false;
        }

        // -------------------------- CARGAR / GUARDAR DATOS ----------------------------
        private void cargarDatos()
        {
            cboTipoCliente.SelectedItem = cliente.TipoCliente;
            cboTipoDoc.Text = cliente.TipoDoc;
            txtNumDoc.Text = cliente.Doc.ToString();
            txtCalle.Text = cliente.Calle;
            txtEsquina.Text = cliente.Esq;
            txtNumeroPuerta.Text = cliente.NroPuerta.ToString();
            chkActivo.Checked = cliente.Activo;
            chkAutorizado.Checked = cliente.Autorizado;

            txtPrimerNombre.Text = cliente.PNom;
            txtSegundoNombre.Text = cliente.SNom;
            txtPrimerApellido.Text = cliente.PApe;
            txtSegundoApellido.Text = cliente.SApe;

            cargarMails();
            cargarTels();
        }

        private void cargarTels()
        {
            txtTel1.Text = cliente.Tels[0].ToString();

            if (cliente.Tels.Count() > 1)
            {
                txtTel2.Text = cliente.Tels[1].ToString();
            }
            else if (cliente.Tels.Count > 2)
            {
                txtTel3.Text = cliente.Tels[2].ToString();
            }
        }

        private void cargarMails()
        {
            txtMail1.Text = cliente.Mails[0];

            if (cliente.Mails.Count() > 1)
            {
                txtMail2.Text = cliente.Mails[1];
            }
            else if (cliente.Mails.Count > 2)
            {
                txtMail3.Text = cliente.Mails[2];
            }
        }

        private void actualizarDatos()
        {
            cliente.TipoDoc = cboTipoDoc.Text;
            cliente.Doc = Convert.ToInt64(txtNumDoc.Text);
            cliente.PNom = txtPrimerNombre.Text;
            cliente.SNom = txtSegundoNombre.Text;
            cliente.PApe = txtPrimerApellido.Text;
            cliente.SApe = txtSegundoApellido.Text;
            cliente.Calle = txtCalle.Text;
            cliente.Esq = txtEsquina.Text;
            cliente.TipoCliente = cboTipoCliente.Text;
            cliente.NroPuerta = Convert.ToInt32(txtNumeroPuerta.Text);
            cliente.Activo = chkActivo.Checked;
            cliente.Autorizado = chkAutorizado.Checked;
            cliente.Mails = new List<string> { txtMail1.Text, txtMail2.Text, txtMail3.Text };
            cliente.Tels = asignarTelefonosACliente();
        }

        private List<int?> asignarTelefonosACliente()
        {
            tels = new List<int?>();

            if (!String.IsNullOrEmpty(txtTel1.Text))
            {
                tels.Add(Convert.ToInt32(txtTel1.Text));
            }

            if (!String.IsNullOrEmpty(txtTel2.Text))
            {
                tels.Add(Convert.ToInt32(txtTel2.Text));
            }
            else
            {
                tels.Add(null);
            }

            if (!String.IsNullOrEmpty(txtTel3.Text))
            {
                tels.Add(Convert.ToInt32(txtTel3.Text));
            }
            else
            {
                tels.Add(null);
            }
            return tels;
        }

        private void guardarCambios(metodoDelegado metodo)
        {
            if (validarDatos())
            {
                actualizarDatos();
                bool resultado = metodo();
                if (resultado)
                    MessageBox.Show("Se guardaron los cambios.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // ----------------------------- METODOS WIDGETS --------------------------------
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (opcion == 0)
                guardarCambios(cliente.ingresar);
            else if (opcion == 1)
                guardarCambios(cliente.modificar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoCliente.Text.Equals("Empresa"))
            {
                entradasClienteEmpresa();
            }
            else
            {
                entradasClienteParticular();
            }
        }
    }
}
