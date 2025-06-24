namespace Serapis.Vista
{
    partial class FormRegistrarCompra
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
            lblProveedor = new Label();
            cmbProveedor = new ComboBox();
            nudCantidad = new NumericUpDown();
            btnAgregarItem = new Button();
            dgvItems = new DataGridView();
            lblProducto = new Label();
            lblCantidad = new Label();
            cmbProducto = new ComboBox();
            btnRegistrarCompra = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(12, 26);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(94, 25);
            lblProveedor.TabIndex = 0;
            lblProveedor.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(142, 23);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(182, 33);
            cmbProveedor.TabIndex = 1;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(142, 162);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(180, 31);
            nudCantidad.TabIndex = 2;
            // 
            // btnAgregarItem
            // 
            btnAgregarItem.Location = new Point(390, 162);
            btnAgregarItem.Name = "btnAgregarItem";
            btnAgregarItem.Size = new Size(158, 50);
            btnAgregarItem.TabIndex = 3;
            btnAgregarItem.Text = "Agregar Item";
            btnAgregarItem.UseVisualStyleBackColor = true;
            btnAgregarItem.Click += btnAgregarItem_Click;
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(12, 224);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 62;
            dgvItems.Size = new Size(776, 225);
            dgvItems.TabIndex = 4;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(12, 97);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(85, 25);
            lblProducto.TabIndex = 5;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(12, 164);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 25);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(142, 94);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(182, 33);
            cmbProducto.TabIndex = 7;
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.Location = new Point(602, 162);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Size = new Size(158, 50);
            btnRegistrarCompra.TabIndex = 8;
            btnRegistrarCompra.Text = "Registrar Compra";
            btnRegistrarCompra.UseVisualStyleBackColor = true;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // FormRegistrarCompra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarCompra);
            Controls.Add(cmbProducto);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(dgvItems);
            Controls.Add(btnAgregarItem);
            Controls.Add(nudCantidad);
            Controls.Add(cmbProveedor);
            Controls.Add(lblProveedor);
            Name = "FormRegistrarCompra";
            Text = "FormRegistrarCompra";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProveedor;
        private ComboBox cmbProveedor;
        private NumericUpDown nudCantidad;
        private Button btnAgregarItem;
        private DataGridView dgvItems;
        private Label lblProducto;
        private Label lblCantidad;
        private ComboBox cmbProducto;
        private Button btnRegistrarCompra;
    }
}