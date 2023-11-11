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

namespace ventana3
{
    public partial class GestionarVehiculo : Form
    {
        Vehiculo logicaVehiculo;
        byte rol;
        public GestionarVehiculo(byte rol)
        {
            logicaVehiculo = new Vehiculo(rol);
            this.rol = rol;
            InitializeComponent();
        }

        // -------------------- METODOS AUXILIARES -----------------------
        public void regresarAlMenu()
        {
            Owner.Show();
            Close();
        }

        private Vehiculo crearVehiculo()
        {
            Vehiculo vehiculo = new Vehiculo(this.rol)
            {
                CapCarga = Int32.Parse(txtCapacidad.Text),
                Matricula = txtMatricula.Text
            };
            return vehiculo;
        }


        // --------------------- METODOS DE VALIDACION --------------------
        private void marcarIncorrecto(bool valido, Label obj)
        {
            if (valido)
                obj.ForeColor = System.Drawing.Color.Black;
            else
                obj.ForeColor = System.Drawing.Color.Red;
        }

        private bool validarDatos()
        {
            bool matricula = logicaVehiculo.verificarMatricula(txtMatricula.Text);
            bool carga = logicaVehiculo.verificarCarga(txtCapacidad.Text);
            marcarIncorrecto(matricula, lblMatricula);
            marcarIncorrecto(carga, lblCapacidad);
            return matricula && carga;
        }


        // ---------------------- METODOS WIDGETS ------------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Vehiculo vehiculo = crearVehiculo();
                bool res = vehiculo.ingresar();
                if (res)
                {
                    MessageBox.Show("Se agregó el vehículo correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    regresarAlMenu();
                }
                else
                {
                    MessageBox.Show("No se han guardado los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            txtMatricula.Text = txtMatricula.Text.ToUpper();
            txtMatricula.SelectionStart = txtMatricula.Text.Length;
        }
    }
}
