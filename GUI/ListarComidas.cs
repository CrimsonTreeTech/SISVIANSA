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
    public partial class ListarComidas : Form
    {
        private byte rol;
        private Comida comida;
        private List<Comida> comidas;

        // ----------------- METODOS AL INICIAR -------------------
        public ListarComidas(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            comida = new Comida(rol);
            bloqueraFuncionalidadesSegunRol(rol);
            cargarListadoComida();
        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1)
                btnModificar.Enabled = false;
        }

        // ---------------------- METODOS AUXILIARES ------------------------
        private Comida seleccionarComida()
        {
            comida = new Comida(rol)
            {
                Id = Convert.ToInt32(dgvComidas.SelectedCells[0].Value),
                Nombre = dgvComidas.SelectedCells[1].Value.ToString(),
                Coccion = Convert.ToInt32(dgvComidas.SelectedCells[2].Value),
                Activo = Convert.ToBoolean(dgvComidas.SelectedCells[3].Value),
                Autorizado = Convert.ToBoolean(dgvComidas.SelectedCells[4].Value)
            };
            comida.cargarDietasAObjetoComida();
            return comida;
        }

        private void cargarListadoComida()
        {
            comidas = comida.listaDeComidas();
            foreach (Comida comida in comidas)
            {
                dgvComidas.Rows.Add(comida.Id, comida.Nombre, comida.Coccion, comida.Activo, comida.Autorizado, comida.DietasSTR);
            }
        }

        // -------------------- METODOS WIDGETS -----------------------
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {

        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            comida = seleccionarComida();
            GestionarComida gestionarComida = new GestionarComida(rol, comida);
            gestionarComida.Show(Owner);
            Close();
        }


        // Radiobuttons
        private void rbtnTodo_Click(object sender, EventArgs e)
        {

        }

        private void rbtnNombre_Click(object sender, EventArgs e)
        {

        }

        private void rbtnAutorizado_Click(object sender, EventArgs e)
        {

        }

        private void rbtnNoAutorizado_Click(object sender, EventArgs e)
        {

        }

        private void rbtnActivo_Click(object sender, EventArgs e)
        {

        }

        private void rbtnInactivo_Click(object sender, EventArgs e)
        {

        }

        private void rbtnDietas_Click(object sender, EventArgs e)
        {

        }


    }
}
