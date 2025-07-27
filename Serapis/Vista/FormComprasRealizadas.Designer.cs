namespace Serapis.Vista
{
    partial class FormComprasRealizadas
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
            dgvCompras = new DataGridView();
            btnVerDetalle = new Button();
            btnFiltroFecha = new Button();
            cbxProveedores = new ComboBox();
            lblProveedor = new Label();
            btnRegistrarCompra = new Button();
            dgvProductosCompra = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosCompra).BeginInit();
            SuspendLayout();
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Location = new Point(335, 299);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersWidth = 62;
            dgvCompras.Size = new Size(708, 207);
            dgvCompras.TabIndex = 0;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Location = new Point(115, 414);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(183, 54);
            btnVerDetalle.TabIndex = 1;
            btnVerDetalle.Text = "Ver Detalles";
            btnVerDetalle.UseVisualStyleBackColor = true;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // btnFiltroFecha
            // 
            btnFiltroFecha.Location = new Point(115, 489);
            btnFiltroFecha.Name = "btnFiltroFecha";
            btnFiltroFecha.Size = new Size(183, 54);
            btnFiltroFecha.TabIndex = 2;
            btnFiltroFecha.Text = "Filtrar por Fecha";
            btnFiltroFecha.UseVisualStyleBackColor = true;
            btnFiltroFecha.Click += btnFiltroFecha_Click;
            // 
            // cbxProveedores
            // 
            cbxProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProveedores.FormattingEnabled = true;
            cbxProveedores.Location = new Point(116, 158);
            cbxProveedores.Name = "cbxProveedores";
            cbxProveedores.Size = new Size(182, 33);
            cbxProveedores.TabIndex = 3;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(12, 161);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(98, 25);
            lblProveedor.TabIndex = 4;
            lblProveedor.Text = "Proveedor:";
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.Location = new Point(115, 208);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Size = new Size(183, 56);
            btnRegistrarCompra.TabIndex = 5;
            btnRegistrarCompra.Text = "Registrar Compra";
            btnRegistrarCompra.UseVisualStyleBackColor = true;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // dgvProductosCompra
            // 
            dgvProductosCompra.AllowUserToAddRows = false;
            dgvProductosCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductosCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosCompra.Location = new Point(335, 12);
            dgvProductosCompra.Name = "dgvProductosCompra";
            dgvProductosCompra.RowHeadersWidth = 62;
            dgvProductosCompra.Size = new Size(708, 256);
            dgvProductosCompra.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 271);
            label1.Name = "label1";
            label1.Size = new Size(1048, 25);
            label1.TabIndex = 7;
            label1.Text = "----------------------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(219, 27);
            label2.TabIndex = 8;
            label2.Text = "Productos para la compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(12, 299);
            label3.Name = "label3";
            label3.Size = new Size(168, 27);
            label3.TabIndex = 9;
            label3.Text = "Compras realizadas";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(743, 512);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(300, 31);
            dtpHasta.TabIndex = 10;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(335, 512);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(300, 31);
            dtpDesde.TabIndex = 11;
            // 
            // FormComprasRealizadas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 551);
            Controls.Add(dtpDesde);
            Controls.Add(dtpHasta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvProductosCompra);
            Controls.Add(btnRegistrarCompra);
            Controls.Add(lblProveedor);
            Controls.Add(cbxProveedores);
            Controls.Add(btnFiltroFecha);
            Controls.Add(btnVerDetalle);
            Controls.Add(dgvCompras);
            Name = "FormComprasRealizadas";
            Text = "FormComprasRealizadas";
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCompras;
        private Button btnVerDetalle;
        private Button btnFiltroFecha;
        private ComboBox cbxProveedores;
        private Label lblProveedor;
        private Button btnRegistrarCompra;
        private DataGridView dgvProductosCompra;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
    }
}