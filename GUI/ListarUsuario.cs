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
using SISVIANSA_ITI_2023.Persistencia;

namespace SISVIANSA_ITI_2023.GUI
{
    public partial class ListarUsuario : Form
    {
        private byte rol;
        private Usuario usuario;
        private List<Usuario> listaUsuarios;
        private string colFiltro = "Todo";

        public ListarUsuario(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            usuario = new Usuario(rol);
        }


        // ----------------------- METODOS AUXILIARES -----------------------
        private Usuario seleccionarUsuario()
        {
            try
            {
                usuario = new Usuario(this.rol)
                {
                    Id = Convert.ToInt32(dgvUsuarios.SelectedCells[0].Value),
                    Nombre = dgvUsuarios.SelectedCells[1].Value.ToString(),
                    Rol = dgvUsuarios.SelectedCells[2].Value.ToString(),
                    Activo = Convert.ToBoolean(dgvUsuarios.SelectedCells[3].Value)
                };
                return usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha seleccionado ningun usuario");
                return null;
            }

        }

        private void cargarDatos(List<Usuario> listaUsuarios)
        {
            dgvUsuarios.Rows.Clear();

            foreach (Usuario usuario in listaUsuarios)
            {
                dgvUsuarios.Rows.Add(usuario.Id, usuario.Nombre, usuario.Rol, usuario.Activo);
            }
        }

        private void altaBajaUsuario(bool activo)
        {
            if (seleccionarUsuario() != null)
            {
                Usuario usuario = seleccionarUsuario();
                DialogResult res = MessageBox.Show("¿Deseas cambiar el estado activo del usuario " + usuario.Nombre + "?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    bool confirmacion = usuario.altaBaja(activo);
                    if (confirmacion)
                    {
                        MessageBox.Show("Se ha cambiado el estado de los datos");
                        //consultarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se han logrado cambiar los datos");
                    }
                }
            }
        }

        private void deshabilitarCamposFiltros()
        {
            txtUsuario.Text = "";
            cboRol.SelectedIndex = -1;
            txtUsuario.Enabled = false;
            cboRol.Enabled = false;
        }

        private void actualizarGrilla()
        {
            listaUsuarios = new List<Usuario>();

            if (colFiltro.Equals("Todo"))
            {
                listaUsuarios = usuario.filtrarListaUsuarios(colFiltro, "");
            }

            else if (colFiltro.Equals("Usuario"))
            {
                listaUsuarios = usuario.filtrarListaUsuarios(colFiltro, txtUsuario.Text);
            }

            else if (colFiltro.Equals("Rol"))
            {
                listaUsuarios = usuario.filtrarListaUsuarios(colFiltro, cboRol.Text);
            }

            else if (colFiltro.Equals("Activo"))
            {
                listaUsuarios = usuario.filtrarListaUsuarios(colFiltro, "");
            }

            else if (colFiltro.Equals("Inactivo"))
            {
                listaUsuarios = usuario.filtrarListaUsuarios(colFiltro, "");
            }

            cargarDatos(listaUsuarios);
        }


        // ----------------------- METODOS WIDGETS -----------------------
        private void ListarUsuario_Load(object sender, EventArgs e)
        {
            deshabilitarCamposFiltros();
            rbtnTodo.Checked = true;
            actualizarGrilla();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario usuario = seleccionarUsuario();
            if (usuario.Activo)
            {
                GestionarUsuario gestionarUsuarios = new GestionarUsuario(usuario);
                gestionarUsuarios.Show(Owner);
                Close();
            }
            else
                MessageBox.Show("No se puede modificar un usuario dado de baja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            altaBajaUsuario(false);
            actualizarGrilla();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            altaBajaUsuario(true);
            actualizarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        // --------------------------- FILTROS ------------------------------
        private void rbtnUsuario_Click(object sender, EventArgs e)
        {
            deshabilitarCamposFiltros();
            txtUsuario.Enabled = true;
            colFiltro = "Usuario";
        }

        private void rbtnRol_Click(object sender, EventArgs e)
        {
            deshabilitarCamposFiltros();
            cboRol.Enabled = true;
            cboRol.SelectedIndex = 0;
            colFiltro = "Rol";
        }

        private void rbtnActivo_Click(object sender, EventArgs e)
        {
            deshabilitarCamposFiltros();
            colFiltro = "Activo";
        }

        private void rbtnInactivo_Click(object sender, EventArgs e)
        {
            deshabilitarCamposFiltros();
            colFiltro = "Inactivo";
        }

        private void rbtnTodo_Click(object sender, EventArgs e)
        {
            deshabilitarCamposFiltros();
            colFiltro = "Todo";
        }

        
    }
}
