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
        private List<Usuario> usuarios;
        private string filtroSeleccionado = "Todo";

        public ListarUsuario(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
            usuario = new Usuario(rol);
            consultarDatos();
        }


        // ----------------------- METODOS AUXILIARES -----------------------
        private Usuario seleccionarUsuario()
        {
            try
            {
                usuario = new Usuario(this.rol)
                {
                    Id = Convert.ToInt32(dgvPersonal.SelectedCells[0].Value),
                    Nombre = dgvPersonal.SelectedCells[1].Value.ToString(),
                    Rol = dgvPersonal.SelectedCells[2].Value.ToString(),
                    Activo = Convert.ToBoolean(dgvPersonal.SelectedCells[3].Value)
                };
                return usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha seleccionado ningun usuario");
                return null;
            }

        }

        private void cargarDatos(List<Usuario> usuarios)
        {
            dgvPersonal.Rows.Clear();

            foreach (Usuario usuario in usuarios)
            {
                dgvPersonal.Rows.Add(usuario.Id, usuario.Nombre, usuario.Rol, usuario.Activo);
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

        private void consultarDatos()
        {
            usuarios = new List<Usuario>();
            if (rbtnUsuario.Checked)
            {
                filtroSeleccionado = "Usuario";
                usuarios = usuario.filtrarListaUsuarios(filtroSeleccionado, txtUsuario.Text);
            }
            else if (rbtnRol.Checked)
            {
                filtroSeleccionado = "Rol";
                usuarios = usuario.filtrarListaUsuarios(filtroSeleccionado, cboRol.Text);
            }
            else if (rbtnActivo.Checked)
            {
                filtroSeleccionado = "Activo";
                usuarios = usuario.filtrarListaUsuarios(filtroSeleccionado, "");
            }
            else if (rbtnInactivo.Checked)
            {
                filtroSeleccionado = "Inactivo";
                usuarios = usuario.filtrarListaUsuarios(filtroSeleccionado, "");
            }
            else if (rbtnTodo.Checked)
            {
                filtroSeleccionado = "Todo";
                usuarios = usuario.filtrarListaUsuarios(filtroSeleccionado, "");
            }

            cargarDatos(usuarios);
        }

        // ----------------------- METODOS WIDGETS -----------------------
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
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            altaBajaUsuario(true);
        }


        // --------------------------- FILTROS ------------------------------
        private void rbtnUsuario_Click(object sender, EventArgs e)
        {
            deshabilitarCamposFiltros();
            txtUsuario.Enabled = true;
            filtroSeleccionado = "Usuario";
        }

        private void rbtnRol_Click(object sender, EventArgs e)
        {
            deshabilitarCamposFiltros();
            cboRol.Enabled = true;
            cboRol.SelectedIndex = 0;
            filtroSeleccionado = "Rol";
        }

        private void rbtnActivo_Click(object sender, EventArgs e)
        {
            deshabilitarCamposFiltros();
            filtroSeleccionado = "Activo";
        }

        private void rbtnInactivo_Click(object sender, EventArgs e)
        {
            deshabilitarCamposFiltros();
            filtroSeleccionado = "Inactivo";
        }

        private void rbtnTodo_Click(object sender, EventArgs e)
        {
            deshabilitarCamposFiltros();
            filtroSeleccionado = "Todo";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarDatos();
        }
    }
}
