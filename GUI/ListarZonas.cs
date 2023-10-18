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
    public partial class ListarZonas : Form
    {
        byte rol;
        Zona zona;
        
        // -------------------------------- METODOS INICIALES --------------------------------
        public ListarZonas(byte rol)
        {
            InitializeComponent();
            zona = new Zona(rol);
            this.rol = rol;
            bloqueraFuncionalidadesSegunRol(rol);
        }

        private void ListarZonas_Load(object sender, EventArgs e)
        {
            List<string> zonas = zona.listadoZonasTexto();
            lstZonas.Items.AddRange(zonas.ToArray());
        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1)
                btnModificar.Enabled = false;
        }


        // -------------------------------- METODOS AUXILIARES --------------------------------
        public Zona obtenerZona()
        {
            string zonaSeleccionada = lstZonas.SelectedItem.ToString();
            int id = Int32.Parse(zonaSeleccionada.Split("Zona ")[1]);

            Zona zona = new Zona();

            zona.Id = id;
            zona.Barrios = this.zona.barriosDeZona(zonaSeleccionada);
            zona.Precio = this.zona.obtenerPrecio(id);

            return zona;
        }


        // -------------------------------- METODOS WIDGETS --------------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Zona zonaSeleccionada = obtenerZona();
                if (zonaSeleccionada != null)
                {
                    GestionarZona gestionarZonas = new GestionarZona(this.rol, zonaSeleccionada);
                    gestionarZonas.Show(Owner);
                    Close();
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado zona para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void lstZonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zonaSeleccionada = lstZonas.SelectedItem.ToString();
            List<string> barrios = zona.barriosDeZona(zonaSeleccionada);

            lstBarrios.Items.Clear();
            lstBarrios.Items.AddRange(barrios.ToArray());
        }
    }
}
