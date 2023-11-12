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
    public partial class GestionarUsuario : Form
    {
        Usuario usuario;
        byte operacion, rol;

        delegate bool metodoDelegado();

        // ------------------------- CONSTRUCTORES --------------------------------
        // Ingresar usuarios
        public GestionarUsuario(byte rol)
        {
            usuario = new Usuario(rol);
            this.rol = rol;
            InitializeComponent();
            operacion = 0;
            cboRol.SelectedIndex = 0;
            this.Text = "Ingresar usuario";
        }

        // Modificar usuarios
        public GestionarUsuario(Usuario usuario)
        {
            InitializeComponent();
            operacion = 1;
            this.usuario = usuario;
            cargarDatos();
            this.Text = "Modificar usuario";
        }



        // ------------------- METODOS AUXILIARES ---------------------------------------------------------
        private void actualizarUsuario()
        {
            usuario.Nombre = txtUsuario.Text;
            usuario.Contrasenia = txtPassword.Text;
            usuario.Rol = cboRol.Text;
        }

        private void cargarDatos()
        {
            txtUsuario.Text = usuario.Nombre;
            txtPassword.Text = usuario.Contrasenia;
            txtRepPwd.Text = usuario.Contrasenia;
            cboRol.Text = usuario.Rol;
        }

        private void regresarAlMenu()
        {
            Owner.Show();
            Close();
        }



        // ------------------- METODOS VALIDACION ---------------------------------------------------------
        private bool validarDatos()
        {
            bool nombreUsuario = usuario.validarUsuario(txtUsuario.Text);
            bool password = usuario.validarPassword(txtPassword.Text, txtRepPwd.Text);
            bool rol = usuario.validarRol(cboRol.Text);
            marcarIncorrecto(nombreUsuario, lblUser);
            marcarIncorrecto(password, lblPass);
            marcarIncorrecto(rol, lblRol);
            return nombreUsuario && password && rol;
        }

        private void marcarIncorrecto(bool valido, Label obj)
        {
            if (valido)
                obj.ForeColor = System.Drawing.Color.Black;
            else
                obj.ForeColor = System.Drawing.Color.Red;
        }



        // -------------- METODOS DE GUARDADO DE INFORMACION ----------------
        private void guardarCambios(string mensaje, metodoDelegado metodo)
        {
            if (validarDatos())
            {
                DialogResult resultadoMensaje = MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultadoMensaje == DialogResult.Yes)
                {
                    actualizarUsuario();
                    bool res = metodo();
                    if (res)
                    {
                        MessageBox.Show("Se han guardado los cambios", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        regresarAlMenu();
                    }
                    else
                    {
                        MessageBox.Show("No se han logrado guardado los cambios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        // -------------------- METODOS WIDGETS --------------------------------------------------------
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (operacion == 0)
                guardarCambios("¿Desea ingresar el usuario " + txtUsuario.Text + "?", usuario.ingresar);

            else if (operacion == 1)
                guardarCambios("¿Desea modificar el usuario " + txtUsuario.Text + "?", usuario.modificar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }



    }
}
