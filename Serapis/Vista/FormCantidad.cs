using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serapis.Vista
{
    public partial class FormCantidad : Form
    {
        public int CantidadSeleccionada { get; private set; } = 1;

        public FormCantidad(int stockMaximo)
        {
            InitializeComponent();
            numericUpDownCantidad.Maximum = stockMaximo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CantidadSeleccionada = (int)numericUpDownCantidad.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }
    }
}
