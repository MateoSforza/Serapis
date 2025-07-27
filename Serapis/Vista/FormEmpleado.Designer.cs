namespace Serapis.Vista
{
    partial class FormEmpleado
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
            btnClientes = new Button();
            lblNombre = new Label();
            btnProductos = new Button();
            btnVenta = new Button();
            btnRegistrarCompra = new Button();
            btnVerCompra = new Button();
            btnProveedores = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(72, 145);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(175, 54);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(163, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre Empleado";
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(305, 145);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(175, 54);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(540, 145);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(175, 54);
            btnVenta.TabIndex = 3;
            btnVenta.Text = "VENTA";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.Location = new Point(72, 261);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Size = new Size(175, 58);
            btnRegistrarCompra.TabIndex = 4;
            btnRegistrarCompra.Text = "REGISTRAR COMPRA";
            btnRegistrarCompra.UseVisualStyleBackColor = true;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // btnVerCompra
            // 
            btnVerCompra.Location = new Point(305, 263);
            btnVerCompra.Name = "btnVerCompra";
            btnVerCompra.Size = new Size(175, 54);
            btnVerCompra.TabIndex = 5;
            btnVerCompra.Text = "VER COMPRA";
            btnVerCompra.UseVisualStyleBackColor = true;
            btnVerCompra.Click += btnVerCompra_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(540, 264);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(175, 52);
            btnProveedores.TabIndex = 6;
            btnProveedores.Text = "PROVEEDORES";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProveedores);
            Controls.Add(btnVerCompra);
            Controls.Add(btnRegistrarCompra);
            Controls.Add(btnVenta);
            Controls.Add(btnProductos);
            Controls.Add(lblNombre);
            Controls.Add(btnClientes);
            Name = "FormEmpleado";
            Text = "FormEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Label lblNombre;
        private Button btnProductos;
        private Button btnVenta;
        private Button btnRegistrarCompra;
        private Button btnVerCompra;
        private Button btnProveedores;
    }
}