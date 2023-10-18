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
    public partial class DetallesVehiculo : Form
    {
        byte rol;
        Vehiculo vehiculo;

        // ------------------------ METODOS INICIO -------------------------------
        public DetallesVehiculo(byte rol, Vehiculo vehiculo)
        {
            InitializeComponent();
            this.rol = rol;
            this.vehiculo = vehiculo;
            bloqueraFuncionalidadesSegunRol(rol);
        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1)
                btnAsignarZonas.Enabled = false;
        }

        private void DetallesVehiculo_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            txtMatricula.Text = vehiculo.Matricula;
            txtCapacidad.Text = vehiculo.CapCarga.ToString();
            foreach (Zona zona in vehiculo.ListaZonasDeReparto)
            {
                string cadena = "Zona " + zona.Id.ToString();
                lstZonas.Items.Add(cadena);
            }
        }


        // ------------------------ METODOS WIDGETS -------------------------------
        private void btnAsignarZonas_Click(object sender, EventArgs e)
        {
            AsignarZonas asignarZonas = new AsignarZonas(vehiculo, this.rol);
            asignarZonas.Show(Owner);
            Close();
        }

        private void btnListadoVehiculos_Click(object sender, EventArgs e)
        {
            ListarVehiculo listarVehiculo = new ListarVehiculo(this.rol);
            listarVehiculo.Show(Owner);
            Close();
        }
    
    
    }
}
