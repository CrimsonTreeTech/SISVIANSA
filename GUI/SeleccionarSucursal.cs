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
    public partial class SeleccionarSucursal : Form
    {
        private byte rol;
        private int idSucursal;
        private string itemSeleccionado;
        private Sucursal sucursal;
        private List<Sucursal> sucursales;
        private List<string> sucursalesSTR;

        // ---------------------- CONSTRUCTOR ----------------------
        public SeleccionarSucursal(byte rol)
        {
            this.rol = rol;
            sucursal = new Sucursal(rol);
            InitializeComponent();
            cargarComboBox();
        }

        // ---------------------- METODOS AUXILIARES -------------------------
        private void cargarComboBox()
        {
            sucursales = sucursal.todasLasSucursalesActivas();
            sucursalesSTR = new List<string>();
            foreach (Sucursal sucursal in sucursales)
            {
                sucursalesSTR.Add(sucursal.Id.ToString());
            }

            cboSucursales.Items.AddRange(sucursalesSTR.ToArray());
            cboSucursales.SelectedIndex = 0;
        }

        private int seleccionarSucursal()
        {
            return Convert.ToInt32(cboSucursales.Text);
        }

        // ---------------------- METODOS WIDGETS -------------------------
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            idSucursal = seleccionarSucursal();

            if (rol == 2) // Nro de rol de cocina
            {
                ProduccionDiaria produccionDiaria = new ProduccionDiaria(rol, idSucursal, false);
                produccionDiaria.Show(Owner);
            }
            else if (rol == 6)
            {
                MenuCocina menuCocina = new MenuCocina(rol, idSucursal);
                menuCocina.Show(Owner);
            }
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (rol == 2) // Nro de rol de cocina
            {
                IniciarSesion iniciarSesion = new IniciarSesion();
                iniciarSesion.Show(Owner);
            }
            else if (rol == 6)
            {
                AdministrarMenu administrarMenu = new AdministrarMenu(rol);
                administrarMenu.Show(Owner);
            }
            Close();
        }
    }
}
