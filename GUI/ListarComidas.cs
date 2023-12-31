﻿using SISVIANSA_ITI_2023.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private string colFiltro = "";
        private Comida comida;
        private Dieta dieta;
        private List<Comida> listaComidas;
        private List<Dieta> listaDietas;
        private List<string> valFiltro;


        // ----------------- METODOS AL INICIAR -------------------
        public ListarComidas(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            comida = new Comida(rol);
            dieta = new Dieta(rol);
            //listaDietas = new List<Dieta>();
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

        private void cargarListadoComida(List<Comida> listaComidas)
        {
            dgvComidas.Rows.Clear();

            foreach (Comida comida in listaComidas)
            {
                dgvComidas.Rows.Add(comida.Id, comida.Nombre, comida.Coccion, comida.Activo, comida.Autorizado, comida.DietasSTR);
            }
        }

        private void inhabilitarFiltros()
        {
            txtNombre.Clear();
            chkLstDietas.Items.Clear();

            txtNombre.Enabled = false;
            chkLstDietas.Enabled = false;
        }

        private void hablitarListaDietas()
        {
            chkLstDietas.Enabled = true;

            listaDietas = dieta.todasLasDietas();
            foreach (Dieta dieta in listaDietas)
            {
                chkLstDietas.Items.Add(dieta.Nombre);
            }
        }

        private List<string> obtenerDietasSeleccionadas()
        {
            valFiltro = new List<string>();

            for (int i = 0; i < chkLstDietas.Items.Count; i++)
            {
                if (chkLstDietas.GetItemChecked(i))
                {
                    string dietaCheckeada = chkLstDietas.Items[i].ToString();
                    valFiltro.Add(dietaCheckeada);
                }
            }

            return valFiltro;
        }

        private List<string> obtenerValFiltro()
        {
            valFiltro = new List<string>();

            if (colFiltro.Equals("nombre"))
            {
                valFiltro.Add(txtNombre.Text);
            }

            else if (colFiltro.Equals("dietas"))
            {
                valFiltro = obtenerDietasSeleccionadas();
            }

            else
            {
                valFiltro.Add("");
            }

            return valFiltro;
        }

        private void realizarBusqueda()
        {
            valFiltro = obtenerValFiltro();
            listaComidas = comida.listaComidasFiltradas(colFiltro, valFiltro);
            cargarListadoComida(listaComidas);
        }


        // -------------------- METODOS WIDGETS -----------------------
        private void ListarComidas_Load(object sender, EventArgs e)
        {
            bloqueraFuncionalidadesSegunRol(rol);
            rbtnTodo.Checked = true;
            listaComidas = comida.listaComidasFiltradas("todo", null);
            cargarListadoComida(listaComidas);
        }

        // Botones
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            comida = seleccionarComida();
            bool res = comida.baja(comida.Id);
            if (res)
            {
                MessageBox.Show("Se autorizo la dieta");
                realizarBusqueda();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            comida = seleccionarComida();
            bool res = comida.alta(comida.Id);
            if (res)
            {
                MessageBox.Show("Se autorizo la dieta");
                realizarBusqueda();
            }
        }


        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            comida = seleccionarComida();
            bool res = comida.autorizar(comida.Id);
            if (res)
            {
                MessageBox.Show("Se autorizo la dieta");
                realizarBusqueda();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en mantenimiento", "SISVIANSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*
            comida = seleccionarComida();
            GestionarComida gestionarComida = new GestionarComida(rol, comida);
            gestionarComida.Show(Owner);
            Close();
            */
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            realizarBusqueda();
        }



        // Radiobuttons
        private void rbtnTodo_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            colFiltro = "todo";
        }

        private void rbtnNombre_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            txtNombre.Enabled = true;
            colFiltro = "nombre";
        }

        private void rbtnAutorizado_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            colFiltro = "autorizado";
        }

        private void rbtnNoAutorizado_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            colFiltro = "noAutorizado";
        }

        private void rbtnActivo_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            colFiltro = "activo";
        }

        private void rbtnInactivo_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            colFiltro = "inactivo";
        }

        private void rbtnDietas_Click(object sender, EventArgs e)
        {
            inhabilitarFiltros();
            hablitarListaDietas();
            colFiltro = "dietas";
        }


    }
}
