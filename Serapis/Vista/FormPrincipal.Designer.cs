namespace Serapis.Vista
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            pbxFarmacia = new PictureBox();
            panelContenido = new Panel();
            panelComprasRealizadas = new Panel();
            panelRegistrarCompras = new Panel();
            panelUsuarios = new Panel();
            panelProductos = new Panel();
            panelProveedores = new Panel();
            panelClientes = new Panel();
            panelVentas = new Panel();
            panelLateral = new Panel();
            btnSalir = new Button();
            btnConfiguracion = new Button();
            btnEmpleados = new Button();
            btnReportes = new Button();
            btnLaboratorio = new Button();
            btnVerCompra = new Button();
            btnRegistrarCompra = new Button();
            btnProveedores = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            btnVenta = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pbxFarmacia).BeginInit();
            panelContenido.SuspendLayout();
            panelLateral.SuspendLayout();
            SuspendLayout();
            // 
            // pbxFarmacia
            // 
            pbxFarmacia.Dock = DockStyle.Fill;
            pbxFarmacia.Image = (Image)resources.GetObject("pbxFarmacia.Image");
            pbxFarmacia.Location = new Point(0, 0);
            pbxFarmacia.Name = "pbxFarmacia";
            pbxFarmacia.Size = new Size(1037, 777);
            pbxFarmacia.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFarmacia.TabIndex = 0;
            pbxFarmacia.TabStop = false;
            // 
            // panelContenido
            // 
            panelContenido.Controls.Add(pbxFarmacia);
            panelContenido.Controls.Add(panelComprasRealizadas);
            panelContenido.Controls.Add(panelRegistrarCompras);
            panelContenido.Controls.Add(panelUsuarios);
            panelContenido.Controls.Add(panelProductos);
            panelContenido.Controls.Add(panelProveedores);
            panelContenido.Controls.Add(panelClientes);
            panelContenido.Controls.Add(panelVentas);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(171, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1037, 777);
            panelContenido.TabIndex = 1;
            // 
            // panelComprasRealizadas
            // 
            panelComprasRealizadas.Dock = DockStyle.Fill;
            panelComprasRealizadas.Location = new Point(0, 0);
            panelComprasRealizadas.Name = "panelComprasRealizadas";
            panelComprasRealizadas.Size = new Size(1037, 777);
            panelComprasRealizadas.TabIndex = 2;
            panelComprasRealizadas.Visible = false;
            // 
            // panelRegistrarCompras
            // 
            panelRegistrarCompras.Dock = DockStyle.Fill;
            panelRegistrarCompras.Location = new Point(0, 0);
            panelRegistrarCompras.Name = "panelRegistrarCompras";
            panelRegistrarCompras.Size = new Size(1037, 777);
            panelRegistrarCompras.TabIndex = 2;
            panelRegistrarCompras.Visible = false;
            // 
            // panelUsuarios
            // 
            panelUsuarios.Dock = DockStyle.Fill;
            panelUsuarios.Location = new Point(0, 0);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Size = new Size(1037, 777);
            panelUsuarios.TabIndex = 1;
            panelUsuarios.Visible = false;
            // 
            // panelProductos
            // 
            panelProductos.Dock = DockStyle.Fill;
            panelProductos.Location = new Point(0, 0);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(1037, 777);
            panelProductos.TabIndex = 1;
            panelProductos.Visible = false;
            // 
            // panelProveedores
            // 
            panelProveedores.Dock = DockStyle.Fill;
            panelProveedores.Location = new Point(0, 0);
            panelProveedores.Name = "panelProveedores";
            panelProveedores.Size = new Size(1037, 777);
            panelProveedores.TabIndex = 1;
            panelProveedores.Visible = false;
            // 
            // panelClientes
            // 
            panelClientes.Dock = DockStyle.Fill;
            panelClientes.Location = new Point(0, 0);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(1037, 777);
            panelClientes.TabIndex = 1;
            panelClientes.Visible = false;
            // 
            // panelVentas
            // 
            panelVentas.Dock = DockStyle.Fill;
            panelVentas.Location = new Point(0, 0);
            panelVentas.Name = "panelVentas";
            panelVentas.Size = new Size(1037, 777);
            panelVentas.TabIndex = 0;
            panelVentas.Visible = false;
            // 
            // panelLateral
            // 
            panelLateral.Controls.Add(btnSalir);
            panelLateral.Controls.Add(btnConfiguracion);
            panelLateral.Controls.Add(btnEmpleados);
            panelLateral.Controls.Add(btnReportes);
            panelLateral.Controls.Add(btnLaboratorio);
            panelLateral.Controls.Add(btnVerCompra);
            panelLateral.Controls.Add(btnRegistrarCompra);
            panelLateral.Controls.Add(btnProveedores);
            panelLateral.Controls.Add(btnClientes);
            panelLateral.Controls.Add(btnProductos);
            panelLateral.Controls.Add(btnVenta);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(171, 777);
            panelLateral.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.Location = new Point(0, 704);
            btnSalir.Margin = new Padding(10);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(5);
            btnSalir.Size = new Size(171, 71);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Cerrar sesion / Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Dock = DockStyle.Top;
            btnConfiguracion.Location = new Point(0, 633);
            btnConfiguracion.Margin = new Padding(10);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(5);
            btnConfiguracion.Size = new Size(171, 71);
            btnConfiguracion.TabIndex = 16;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Dock = DockStyle.Top;
            btnEmpleados.Location = new Point(0, 562);
            btnEmpleados.Margin = new Padding(10);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Padding = new Padding(5);
            btnEmpleados.Size = new Size(171, 71);
            btnEmpleados.TabIndex = 15;
            btnEmpleados.Text = "EMPLEADOS";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.Location = new Point(0, 491);
            btnReportes.Margin = new Padding(10);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(5);
            btnReportes.Size = new Size(171, 71);
            btnReportes.TabIndex = 14;
            btnReportes.Text = "REPORTES";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnLaboratorio
            // 
            btnLaboratorio.Dock = DockStyle.Top;
            btnLaboratorio.Location = new Point(0, 420);
            btnLaboratorio.Margin = new Padding(10);
            btnLaboratorio.Name = "btnLaboratorio";
            btnLaboratorio.Padding = new Padding(5);
            btnLaboratorio.Size = new Size(171, 71);
            btnLaboratorio.TabIndex = 13;
            btnLaboratorio.Text = "LABORATORIO";
            btnLaboratorio.UseVisualStyleBackColor = true;
            btnLaboratorio.Click += btnLaboratorio_Click;
            // 
            // btnVerCompra
            // 
            btnVerCompra.Dock = DockStyle.Top;
            btnVerCompra.Location = new Point(0, 350);
            btnVerCompra.Margin = new Padding(10);
            btnVerCompra.Name = "btnVerCompra";
            btnVerCompra.Padding = new Padding(5);
            btnVerCompra.Size = new Size(171, 70);
            btnVerCompra.TabIndex = 11;
            btnVerCompra.Text = "VER COMPRA";
            btnVerCompra.UseVisualStyleBackColor = true;
            btnVerCompra.Click += btnVerCompra_Click;
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.Dock = DockStyle.Top;
            btnRegistrarCompra.Location = new Point(0, 280);
            btnRegistrarCompra.Margin = new Padding(10);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Padding = new Padding(5);
            btnRegistrarCompra.Size = new Size(171, 70);
            btnRegistrarCompra.TabIndex = 10;
            btnRegistrarCompra.Text = "REGISTRAR COMPRA";
            btnRegistrarCompra.UseVisualStyleBackColor = true;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.Location = new Point(0, 210);
            btnProveedores.Margin = new Padding(10);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(5);
            btnProveedores.Size = new Size(171, 70);
            btnProveedores.TabIndex = 12;
            btnProveedores.Text = "PROVEEDORES";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.Location = new Point(0, 140);
            btnClientes.Margin = new Padding(10);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(5);
            btnClientes.Size = new Size(171, 70);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.Location = new Point(0, 70);
            btnProductos.Margin = new Padding(10);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(5);
            btnProductos.Size = new Size(171, 70);
            btnProductos.TabIndex = 8;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVenta
            // 
            btnVenta.Dock = DockStyle.Top;
            btnVenta.Location = new Point(0, 0);
            btnVenta.Margin = new Padding(10);
            btnVenta.Name = "btnVenta";
            btnVenta.Padding = new Padding(5);
            btnVenta.Size = new Size(171, 70);
            btnVenta.TabIndex = 9;
            btnVenta.Text = "VENTAS";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1208, 777);
            Controls.Add(panelContenido);
            Controls.Add(panelLateral);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormPrincipal";
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pbxFarmacia).EndInit();
            panelContenido.ResumeLayout(false);
            panelLateral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContenido;
        private PictureBox pbxFarmacia;
        private Panel panelUsuarios;
        private Panel panelProductos;
        private Panel panelProveedores;
        private Panel panelClientes;
        private Panel panelVentas;
        private Panel panelComprasRealizadas;
        private Panel panelRegistrarCompras;
        private Panel panelLateral;
        private Button btnProveedores;
        private Button btnClientes;
        private Button btnRegistrarCompra;
        private Button btnVerCompra;
        private Button btnVenta;
        private Button btnProductos;
        private Button btnSalir;
        private Button btnConfiguracion;
        private Button btnEmpleados;
        private Button btnReportes;
        private Button btnLaboratorio;
        private ContextMenuStrip contextMenuStrip1;
    }
}