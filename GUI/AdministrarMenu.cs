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
    public partial class AdministrarMenu : Form

    {
        byte rol;
        public AdministrarMenu(byte rol)
        {
            InitializeComponent();
            this.rol = rol;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            MenuInformatico menuInformatico = new MenuInformatico(rol);
            menuInformatico.Show(Owner);
            Close();

        }
    }
}

