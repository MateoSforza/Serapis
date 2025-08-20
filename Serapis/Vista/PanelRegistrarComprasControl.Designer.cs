namespace Serapis.Vista
{
    partial class PanelRegistrarComprasControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLimpiar = new Button();
            lblCostoTotal = new Label();
            lblTextoCosto = new Label();
            btnEliminar = new Button();
            lblStock = new Label();
            lblPrecio = new Label();
            lblCodigo = new Label();
            lblProveedor = new Label();
            dtpFecha = new DateTimePicker();
            btnRegistrarCompra = new Button();
            cmbProveedor = new ComboBox();
            lblFecha = new Label();
            btnAgregarItem = new Button();
            cmbProducto = new ComboBox();
            lblCantidad = new Label();
            lblProducto = new Label();
            nudCantidad = new NumericUpDown();
            dgvProductos = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(lblCostoTotal);
            panel1.Controls.Add(lblTextoCosto);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(lblStock);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblCodigo);
            panel1.Controls.Add(lblProveedor);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(btnRegistrarCompra);
            panel1.Controls.Add(cmbProveedor);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(btnAgregarItem);
            panel1.Controls.Add(cmbProducto);
            panel1.Controls.Add(lblCantidad);
            panel1.Controls.Add(lblProducto);
            panel1.Controls.Add(nudCantidad);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 375);
            panel1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(891, 309);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(68, 63);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "\U0001f9f9";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblCostoTotal
            // 
            lblCostoTotal.AutoSize = true;
            lblCostoTotal.Location = new Point(771, 330);
            lblCostoTotal.Name = "lblCostoTotal";
            lblCostoTotal.Size = new Size(0, 25);
            lblCostoTotal.TabIndex = 24;
            // 
            // lblTextoCosto
            // 
            lblTextoCosto.AutoSize = true;
            lblTextoCosto.Location = new Point(653, 330);
            lblTextoCosto.Name = "lblTextoCosto";
            lblTextoCosto.Size = new Size(104, 25);
            lblTextoCosto.TabIndex = 23;
            lblTextoCosto.Text = "Costo total:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(15, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(158, 50);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar Item";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(609, 146);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(59, 25);
            lblStock.TabIndex = 21;
            lblStock.Text = "label3";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(466, 146);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(59, 25);
            lblPrecio.TabIndex = 20;
            lblPrecio.Text = "label2";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(360, 146);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(59, 25);
            lblCodigo.TabIndex = 19;
            lblCodigo.Text = "label1";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(15, 22);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(98, 25);
            lblProveedor.TabIndex = 9;
            lblProveedor.Text = "Proveedor:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(497, 17);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(300, 31);
            dtpFecha.TabIndex = 18;
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.Location = new Point(217, 286);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Size = new Size(158, 50);
            btnRegistrarCompra.TabIndex = 16;
            btnRegistrarCompra.Text = "Registrar Compra";
            btnRegistrarCompra.UseVisualStyleBackColor = true;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(145, 19);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(182, 33);
            cmbProveedor.TabIndex = 10;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(404, 22);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(61, 25);
            lblFecha.TabIndex = 17;
            lblFecha.Text = "Fecha:";
            // 
            // btnAgregarItem
            // 
            btnAgregarItem.Location = new Point(15, 251);
            btnAgregarItem.Name = "btnAgregarItem";
            btnAgregarItem.Size = new Size(158, 50);
            btnAgregarItem.TabIndex = 12;
            btnAgregarItem.Text = "Agregar Item";
            btnAgregarItem.UseVisualStyleBackColor = true;
            btnAgregarItem.Click += btnAgregarItem_Click;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(143, 146);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(182, 33);
            cmbProducto.TabIndex = 15;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(15, 195);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 25);
            lblCantidad.TabIndex = 14;
            lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(13, 149);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(85, 25);
            lblProducto.TabIndex = 13;
            lblProducto.Text = "Producto";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(145, 193);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(180, 31);
            nudCantidad.TabIndex = 11;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(962, 280);
            dgvProductos.TabIndex = 5;
            dgvProductos.DoubleClick += dgvItems_DoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvProductos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 375);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 280);
            panel2.TabIndex = 1;
            // 
            // PanelRegistrarComprasControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PanelRegistrarComprasControl";
            Size = new Size(962, 655);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegistrarCompra;
        private ComboBox cmbProducto;
        private Label lblCantidad;
        private Label lblProducto;
        private Button btnAgregarItem;
        private NumericUpDown nudCantidad;
        private ComboBox cmbProveedor;
        private Label lblProveedor;
        private DataGridView dgvProductos;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Label lblCodigo;
        private Panel panel2;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblCostoTotal;
        private Label lblTextoCosto;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}
