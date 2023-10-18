﻿using System;
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
    public partial class GestionarClienteComun : Form
    {
        byte rol, opcion;
        delegate bool metodoDelegado();
        Cliente cliente;

        // -------------------------- METODOS AL INICIAR -----------------------------
        public GestionarClienteComun(byte rol)
        {
            InitializeComponent();
            cliente = new Cliente(rol);
            this.rol = rol;
            this.opcion = 0;
            bloqueraFuncionalidadesSegunRol(rol);
        }

        public GestionarClienteComun(byte rol, Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.rol = rol;
            this.opcion = 1;
            bloqueraFuncionalidadesSegunRol(rol);
            cargarDatos();
        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 4)
                chkAutorizado.Enabled = false;
        }


        // --------------------------- METODOS AUXILIARES -------------------------------
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

        private bool validarDatos()
        {
            bool documento = cliente.verificarDocumentos(cboTipoDoc.Text, txtNumDoc.Text);
            bool nombre = cliente.verificarCampoNoVacio(txtPrimerNombre.Text);
            bool apellido = cliente.verificarCampoNoVacio(txtPrimerApellido.Text);
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
            marcarIncorrecto(nombre, lblPrimerNombre);
            marcarIncorrecto(apellido, lblPrimerApellido);
            marcarIncorrecto(calle, lblCalle);
            marcarIncorrecto(esquina, lblEsquina);
            marcarIncorrecto(numPuerta, lblNumeroPuerta);
            marcarIncorrecto(tel1, lblTel1);
            marcarIncorrecto(tel2, lblTel2);
            marcarIncorrecto(tel3, lblTel3);
            marcarIncorrecto(mail1, lblMail1);
            marcarIncorrecto(mail2, lblMail2);
            marcarIncorrecto(mail3, lblMail3);

            if (!tel1 || !tel2 || !tel3)
            {
                MessageBox.Show("El telefono deben ser 8 digitos: numeros fijos o celulares sin el 0 inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return documento && nombre && apellido && calle && esquina && numPuerta && tel1 && tel2 && tel3 && mail1 && mail2 && mail3;
        }


        // -------------------------- CARGAR / GUARDAR DATOS ----------------------------
        private void cargarDatos()
        {
            cboTipoDoc.Text = cliente.TipoDoc;
            txtNumDoc.Text = cliente.Doc.ToString();
            txtPrimerNombre.Text = cliente.PNom;
            txtSegundoNombre.Text = cliente.SNom;
            txtPrimerApellido.Text = cliente.PApe;
            txtSegundoApellido.Text = cliente.SApe;
            txtMail1.Text = cliente.Mails[0];
            txtMail2.Text = cliente.Mails[1];
            txtMail3.Text = cliente.Mails[2];
            txtTel1.Text = cliente.Tels[0].ToString();
            txtTel2.Text = cliente.Tels[1].ToString();
            txtTel3.Text = cliente.Tels[2].ToString();
            txtCalle.Text = cliente.Calle;
            txtEsquina.Text = cliente.Esq;
            txtNumeroPuerta.Text = cliente.NroPuerta.ToString();
            chkActivo.Checked = cliente.Activo;
            chkAutorizado.Checked = cliente.Autorizado;
        }

        private void actualizarDatos()
        {
            cliente.TipoDoc = cboTipoDoc.Text;
            cliente.Doc = Int32.Parse(txtNumDoc.Text);
            cliente.PNom = txtPrimerNombre.Text;
            cliente.SNom = txtSegundoNombre.Text;
            cliente.PApe = txtPrimerApellido.Text;
            cliente.SApe = txtSegundoApellido.Text;
            cliente.Calle = txtCalle.Text;
            cliente.Esq = txtEsquina.Text;
            cliente.NroPuerta = Int32.Parse(txtNumeroPuerta.Text);
            cliente.Activo = chkActivo.Checked;
            cliente.Autorizado = chkAutorizado.Checked;
            cliente.Mails = new List<string> { txtMail1.Text, txtMail2.Text, txtMail3.Text };
            cliente.Tels = new List<int> { Int32.Parse(txtTel1.Text), Int32.Parse(txtTel2.Text), Int32.Parse(txtTel3.Text) };
        }

        private void guardarCambios(metodoDelegado metodo)
        {
            if (validarDatos())
            {
                actualizarDatos();
                bool resultado = metodo();
                if (resultado)
                    MessageBox.Show("Se guardaron los cambios.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se han logrado guardaron los cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
