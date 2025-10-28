using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serapis.Controladoras;
using Serapis.Controladores;
using Serapis.Data;
using Serapis.Modelo;
using Serapis.Servicios;

namespace Serapis.Vista
{
    public partial class FormPrincipal : Form
    {
        private bool esAdmin;
        private Usuario _usuario;
        private readonly SerapisDbContext _context;

        public FormPrincipal()
        {
            InitializeComponent();
            _context = new SerapisDbContextFactory().CreateDbContext(Array.Empty<string>());

            panelContenido.Visible = false;
            panelLateral.Visible = false; // si tenés un panel lateral para botones

            MostrarLogin();
        }


        private void MostrarLogin()
        {
            var loginControl = new LoginControl(new UsuarioController(_context));
            loginControl.Dock = DockStyle.None;
            loginControl.Anchor = AnchorStyles.None;

            CentrarLogin(loginControl);

            this.Controls.Add(loginControl);
            loginControl.BringToFront();

            loginControl.LoginExitoso += Usuario_Logueado;

            // Reposicionar cuando se cambie el tamaño de la ventana
            this.Resize += (s, e) => CentrarLogin(loginControl);
        }

        private void CentrarLogin(Control loginControl)
        {
            loginControl.Location = new Point(
                (this.ClientSize.Width - loginControl.Width) / 2,
                (this.ClientSize.Height - loginControl.Height) / 2
            );
        }

        private void Usuario_Logueado(Usuario usuario)
        {
            _usuario = usuario;
            esAdmin = usuario.EsAdmin;


            foreach (var login in this.Controls.OfType<LoginControl>())
            {
                this.Controls.Remove(login);
                login.Dispose();
            }

            // Mostrar UI principal
            panelContenido.Visible = true;
            panelLateral.Visible = true; // si tenés panel de botones

            ConfigurarAcceso();
        }

        private void ConfigurarAcceso()
        {
            if (esAdmin)
            {
                // Admin: habilitar y restaurar textos
                btnEmpleados.Enabled = true;
                btnConfiguracion.Enabled = true;
                btnEmpleados.Text = "EMPLEADOS";
                btnConfiguracion.Text = "Configuracion";
            }
            else
            {
                // Empleado: deshabilitar y mostrar candado
                btnEmpleados.Text = "🔒 Empleados";
                btnConfiguracion.Text = "🔒 Configuración";

                btnEmpleados.Enabled = false;
                btnConfiguracion.Enabled = false;
            }
        }

        private void AbrirUserControl(UserControl control)
        {
            panelContenido.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(control);
        }

        private void btnVenta_Click(object sender, EventArgs e) => AbrirUserControl(new PanelVentasControl(_context, _usuario));

        private void btnProductos_Click(object sender, EventArgs e) => AbrirUserControl(new PanelProductosControl(_context));

        private void btnClientes_Click(object sender, EventArgs e) => AbrirUserControl(new PanelClientesControl(_context));

        private void btnProveedores_Click(object sender, EventArgs e) => AbrirUserControl(new PanelProveedoresControl(_context));

        private void btnRegistrarCompra_Click(object sender, EventArgs e) => AbrirUserControl(new PanelRegistrarComprasControl(new CompraController(_context)));

        private void btnVerCompra_Click(object sender, EventArgs e) => AbrirUserControl(new PanelComprasRealizadasControl(new CompraController(_context)));

        private void btnLaboratorio_Click(object sender, EventArgs e) => AbrirUserControl(new PanelLaboratorioControl(_context));

        private void btnReportes_Click(object sender, EventArgs e) => AbrirUserControl(new PanelReportesControl(_context));

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if(esAdmin)
            {
                AbrirUserControl(new PanelUsuariosControl(new UsuarioController(_context)));
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if (esAdmin)
                AbrirUserControl (new PanelConfiguracionControl(_usuario, _context));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            using (var formConfirm = new FormConfirmExit())
            {
                if (formConfirm.ShowDialog() == DialogResult.OK)
                {
                    if (formConfirm.Accion == FormConfirmExit.AccionSeleccionada.CerrarSesion)
                    {
                        SesionActual.UsuarioLogueado = null;
                        _usuario = null;

                        panelContenido.Visible = false;
                        panelLateral.Visible = false;

                        MostrarLogin();

                    }
                    else if (formConfirm.Accion == FormConfirmExit.AccionSeleccionada.SalirPrograma)
                    {
                        Application.Exit();
                    }
                }
            }
        }
    }
}
