using Serapis.Datos;
using Serapis.Modelo;
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
    public partial class FormEmpleado : Form
    {
        private readonly SerapisDbContext _context;
        private readonly Usuario _usuario;

        public FormEmpleado(SerapisDbContext context, Usuario usuario)
        {
            InitializeComponent();
            _context = context;
            _usuario = usuario;
            this.Text = $"Empleado, {_usuario.Nombre}";
        }
    }
}
