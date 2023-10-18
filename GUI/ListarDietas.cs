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
    public partial class ListarDietas : Form
    {
        private byte rol;
        private Dieta dieta;
        private List<Dieta> dietas;

        // ----------------------- METODOS AL INICIAR --------------------------
        public ListarDietas(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            dieta = new Dieta(rol);
            bloqueraFuncionalidadesSegunRol(rol);
            cargarListado();
        }

        private void bloqueraFuncionalidadesSegunRol(byte rol)
        {
            if (rol == 1)
                btnModificar.Enabled = false;
        }


        // ----------------------- METODOS AUXILIARES ------------------------------
        private void regresarAlMenu()
        {
            Owner.Show();
            Close();
        }

        private Dieta seleccionarDieta()
        {
            Dieta dieta = new Dieta(this.rol)
            {
                Id = Convert.ToInt32(dgvDieta.SelectedCells[0].Value),
                Nombre = dgvDieta.SelectedCells[0].Value.ToString(),
                Activo = Convert.ToBoolean(dgvDieta.SelectedCells[0].Value),
            };
            return dieta;
        }

        private void cargarListado()
        {
            dietas = dieta.todasLasDietas();
            foreach (Dieta dieta in dietas)
            {
                dgvDieta.Rows.Add(dieta.Id, dieta.Nombre, dieta.Activo, dieta.Autorizado);
            }
        }

        // ---------------------- METODOS WIDGETS --------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Dieta dietaSeleccionada = seleccionarDieta();
            GestionarDieta gestionarDieta = new GestionarDieta(this.rol, dietaSeleccionada);
            gestionarDieta.Show(Owner);
            Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }
    }
}
