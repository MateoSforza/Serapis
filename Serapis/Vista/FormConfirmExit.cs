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
    public partial class FormConfirmExit : Form
    {
        public enum AccionSeleccionada
        {
            Ninguna,
            CerrarSesion,
            SalirPrograma
        }

        public AccionSeleccionada Accion { get; private set; } = AccionSeleccionada.Ninguna;

        public FormConfirmExit()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Accion = AccionSeleccionada.CerrarSesion;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSalirPrograma_Click(object sender, EventArgs e)
        {
            Accion = AccionSeleccionada.SalirPrograma;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
