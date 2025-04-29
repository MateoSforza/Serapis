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
    public partial class FormAdmin : Form
    {
        private readonly SerapisDbContext _context;
        private readonly Usuario _usuario;

        public FormAdmin(SerapisDbContext context, Usuario usuario)
        {
            InitializeComponent();
            _context = context;
            _usuario = usuario;
            this.Text = $"Administrador, {_usuario.Nombre}";
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            var formRegistro = new FormRegistroUsuario(_context);
            formRegistro.ShowDialog();
        }

    }
}

