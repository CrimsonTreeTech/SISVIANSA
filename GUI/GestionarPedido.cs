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
    public partial class GestionarPedido : Form
    {
        public GestionarPedido()
        {
            InitializeComponent();
        }


        private void regresarAlMenu()
        {
            Owner.Show();
            Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            regresarAlMenu();
        }
    }
}
