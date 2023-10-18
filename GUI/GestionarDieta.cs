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
    public partial class GestionarDieta : Form
    {
        Dieta dieta;
        byte rol, opcion;
        delegate bool metodoDelegado();


        // ------------------ METODOS AL INICIAR ------------------
        public GestionarDieta(byte rol)
        {
            this.rol = rol;
            this.opcion = 0;
            dieta = new Dieta(rol);
            InitializeComponent();
        }

        public GestionarDieta(byte rol, Dieta dieta)
        {
            InitializeComponent();
            this.rol = rol;
            this.opcion = 1;
            this.dieta = dieta;
            cargarDatos();
        }


        // ---------------- METODOS AUXILIARES ----------------------
        private void regresarAlMenu()
        {
            Owner.Show();
            Close();
        }

        private void marcarIncorrecto(bool valido, Label obj)
        {
            if (valido)
                obj.ForeColor = System.Drawing.Color.Black;
            else
                obj.ForeColor = System.Drawing.Color.Red;
        }

        private bool validarDatos()
        {
            bool nombre = dieta.campoNoVacio(txtNombre.Text);
            bool descripcion = dieta.campoNoVacio(rtxtDescripcion.Text);
            marcarIncorrecto(nombre, lblNombre);
            marcarIncorrecto(descripcion, lblDescripcion);
            return nombre && descripcion;
        }

        private void actualizarDatos()
        {
            dieta.Nombre = txtNombre.Text;
            dieta.Descripcion = rtxtDescripcion.Text;
            dieta.Activo = chkActivo.Checked;
            dieta.Autorizado = chkAutorizado.Checked;
        }

        
        // --------------- GUARDAR / CARGAR CAMBIOS -------------------
        private void cargarDatos()
        {
            txtNombre.Text = dieta.Nombre;
            rtxtDescripcion.Text = dieta.Descripcion;
            chkActivo.Checked = dieta.Activo;
            chkAutorizado.Checked = dieta.Autorizado;
        }

        private void guardarCambios(metodoDelegado metodo)
        {
            if(validarDatos())
            {
                actualizarDatos();
                bool resultado = metodo();
                if (resultado)
                    MessageBox.Show("Se guardaron los cambios", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se han guardaron los cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        // ---------------------- METODOS DE WIDGETS --------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (opcion == 0)
                guardarCambios(dieta.ingresar);
            else if (opcion == 1)
                guardarCambios(dieta.modificar);
        }
    }
}
