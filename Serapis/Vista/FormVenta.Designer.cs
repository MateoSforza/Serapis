namespace Serapis.Vista
{
    partial class FormVenta
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
            lblCliente = new Label();
            lblReceta = new Label();
            btnConfirmarVenta = new Button();
            txtReceta = new TextBox();
            chkRequiereReceta = new CheckBox();
            cbxCliente = new ComboBox();
            dgvCatalogo = new DataGridView();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            panelSuperior = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            panel2 = new Panel();
            lblTotal = new Label();
            btnQuitarProducto = new Button();
            label1 = new Label();
            dgvCarrito = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            panelSuperior.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(109, 28);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(69, 25);
            lblCliente.TabIndex = 18;
            lblCliente.Text = "Cliente:";
            // 
            // lblReceta
            // 
            lblReceta.AutoSize = true;
            lblReceta.Location = new Point(945, 78);
            lblReceta.Name = "lblReceta";
            lblReceta.Size = new Size(63, 25);
            lblReceta.TabIndex = 17;
            lblReceta.Text = "Receta";
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(24, 357);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(230, 62);
            btnConfirmarVenta.TabIndex = 16;
            btnConfirmarVenta.Text = "CONFIRMAR VENTA";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            btnConfirmarVenta.Click += btnRegistrarVenta_Click;
            // 
            // txtReceta
            // 
            txtReceta.Location = new Point(1027, 75);
            txtReceta.Name = "txtReceta";
            txtReceta.Size = new Size(182, 31);
            txtReceta.TabIndex = 15;
            // 
            // chkRequiereReceta
            // 
            chkRequiereReceta.AutoSize = true;
            chkRequiereReceta.Location = new Point(945, 28);
            chkRequiereReceta.Name = "chkRequiereReceta";
            chkRequiereReceta.Size = new Size(158, 29);
            chkRequiereReceta.TabIndex = 14;
            chkRequiereReceta.Text = "Requiere receta";
            chkRequiereReceta.UseVisualStyleBackColor = true;
            chkRequiereReceta.CheckedChanged += chkRequiereReceta_CheckedChanged;
            // 
            // cbxCliente
            // 
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(180, 25);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(182, 33);
            cbxCliente.TabIndex = 13;
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalogo.Dock = DockStyle.Fill;
            dgvCatalogo.Location = new Point(3, 3);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.RowHeadersWidth = 62;
            dgvCatalogo.Size = new Size(805, 431);
            dgvCatalogo.TabIndex = 12;
            dgvCatalogo.CellDoubleClick += dgvCatalogo_CellDoubleClick;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(565, 28);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(67, 25);
            lblBuscar.TabIndex = 19;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(645, 28);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(182, 31);
            txtBuscar.TabIndex = 20;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(cbxCliente);
            panelSuperior.Controls.Add(txtReceta);
            panelSuperior.Controls.Add(lblReceta);
            panelSuperior.Controls.Add(txtBuscar);
            panelSuperior.Controls.Add(lblBuscar);
            panelSuperior.Controls.Add(lblCliente);
            panelSuperior.Controls.Add(chkRequiereReceta);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1353, 150);
            panelSuperior.TabIndex = 21;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel.Controls.Add(dgvCatalogo, 0, 0);
            tableLayoutPanel.Controls.Add(panel2, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 150);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(1353, 437);
            tableLayoutPanel.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(btnQuitarProducto);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dgvCarrito);
            panel2.Controls.Add(btnConfirmarVenta);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(814, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(536, 431);
            panel2.TabIndex = 13;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(95, 276);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 25);
            lblTotal.TabIndex = 23;
            // 
            // btnQuitarProducto
            // 
            btnQuitarProducto.Location = new Point(285, 357);
            btnQuitarProducto.Name = "btnQuitarProducto";
            btnQuitarProducto.Size = new Size(230, 62);
            btnQuitarProducto.TabIndex = 22;
            btnQuitarProducto.Text = "QUITAR PRODUCTO";
            btnQuitarProducto.UseVisualStyleBackColor = true;
            btnQuitarProducto.Click += btnQuitarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 276);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 21;
            label1.Text = "Total:";
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Dock = DockStyle.Top;
            dgvCarrito.Location = new Point(0, 0);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.Size = new Size(536, 225);
            dgvCarrito.TabIndex = 17;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 587);
            Controls.Add(tableLayoutPanel);
            Controls.Add(panelSuperior);
            Name = "FormVenta";
            Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCliente;
        private Label lblReceta;
        private Button btnConfirmarVenta;
        private TextBox txtReceta;
        private CheckBox chkRequiereReceta;
        private ComboBox cbxCliente;
        private DataGridView dgvCatalogo;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Panel panelSuperior;
        private TableLayoutPanel tableLayoutPanel;
        private Panel panel2;
        private Label label1;
        private DataGridView dgvCarrito;
        private Button btnQuitarProducto;
        private Label lblTotal;
    }
}