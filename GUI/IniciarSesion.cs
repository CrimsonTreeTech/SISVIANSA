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
    public partial class IniciarSesion : Form
    {
        private const byte ROL_GERENTE = 1;
        private const byte ROL_COCINA = 2;
        private const byte ROL_ADMIN = 3;
        private const byte ROL_ATC = 4;
        private const byte ROL_TRANSPORTE = 5;
        private const byte ROL_INFORMATICO = 6;

        private short validacionUsuario;
        private Cliente cliente;
        private Usuario usuario;


        public IniciarSesion()
        {
            InitializeComponent();
            usuario = new Usuario(ROL_INFORMATICO);
            cliente = new Cliente(ROL_INFORMATICO);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MenuBD menuBD = new MenuBD(ROL_COCINA);
            menuBD.obtenerComidasMenu(9);

            validacionUsuario = usuario.comprobarCredenciales(txtUser.Text, txtPassword.Text);

            switch (validacionUsuario)
            {
                case 0:
                    MessageBox.Show("Error al ingresar.Compruebe que las credenciales sean correctas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case ROL_GERENTE:
                    MenuGerente gerente = new MenuGerente(ROL_GERENTE);
                    gerente.Show(this);
                    Hide();
                    break;
                case ROL_COCINA:
                    SeleccionarSucursal seleccionarSucursal = new SeleccionarSucursal(ROL_COCINA);
                    seleccionarSucursal.Show(this);
                    Hide();
                    break;
                case ROL_ADMIN:
                    MenuAdministrativo administrativo = new MenuAdministrativo(ROL_ADMIN);
                    administrativo.Show(this);
                    Hide();
                    break;
                case ROL_ATC:
                    MenuAtencionCliente atencionCliente = new MenuAtencionCliente(ROL_ATC);
                    atencionCliente.Show(this);
                    Hide();
                    break;
                case ROL_TRANSPORTE:
                    MenuTransporte transporte = new MenuTransporte(ROL_TRANSPORTE);
                    transporte.Show(this);
                    Hide();
                    break;
                case ROL_INFORMATICO:
                    MenuInformatico informatico = new MenuInformatico(ROL_INFORMATICO);
                    informatico.Show(this);
                    Hide();
                    break;
            }
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            // Crea las vistas necesarias al iniciar el programa
            cliente.crearVistaClientes();
        }
    }
}
