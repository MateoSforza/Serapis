namespace Serapis.Vista
{
    partial class PanelVentasControl
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
            txtReceta = new TextBox();
            lblReceta = new Label();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            chkRequiereReceta = new CheckBox();
            panel2 = new Panel();
            cbxCliente = new ComboBox();
            lblTotal = new Label();
            btnQuitarProducto = new Button();
            btnFacturarConfirmar = new Button();
            label1 = new Label();
            lblCliente = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvCarrito = new DataGridView();
            dgvCatalogo = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtReceta);
            panel1.Controls.Add(lblReceta);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(lblBuscar);
            panel1.Controls.Add(chkRequiereReceta);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 150);
            panel1.TabIndex = 0;
            // 
            // txtReceta
            // 
            txtReceta.Location = new Point(546, 88);
            txtReceta.Name = "txtReceta";
            txtReceta.Size = new Size(182, 31);
            txtReceta.TabIndex = 22;
            // 
            // lblReceta
            // 
            lblReceta.AutoSize = true;
            lblReceta.Location = new Point(464, 91);
            lblReceta.Name = "lblReceta";
            lblReceta.Size = new Size(63, 25);
            lblReceta.TabIndex = 23;
            lblReceta.Text = "Receta";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(109, 34);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(182, 31);
            txtBuscar.TabIndex = 25;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(29, 34);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(67, 25);
            lblBuscar.TabIndex = 24;
            lblBuscar.Text = "Buscar:";
            // 
            // chkRequiereReceta
            // 
            chkRequiereReceta.AutoSize = true;
            chkRequiereReceta.Location = new Point(466, 34);
            chkRequiereReceta.Name = "chkRequiereReceta";
            chkRequiereReceta.Size = new Size(158, 29);
            chkRequiereReceta.TabIndex = 21;
            chkRequiereReceta.Text = "Requiere receta";
            chkRequiereReceta.UseVisualStyleBackColor = true;
            chkRequiereReceta.CheckedChanged += chkRequiereReceta_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbxCliente);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(btnQuitarProducto);
            panel2.Controls.Add(btnFacturarConfirmar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblCliente);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 495);
            panel2.Name = "panel2";
            panel2.Size = new Size(966, 150);
            panel2.TabIndex = 1;
            // 
            // cbxCliente
            // 
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(98, 14);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(182, 33);
            cbxCliente.TabIndex = 24;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(495, 17);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 25);
            lblTotal.TabIndex = 29;
            // 
            // btnQuitarProducto
            // 
            btnQuitarProducto.Location = new Point(27, 70);
            btnQuitarProducto.Name = "btnQuitarProducto";
            btnQuitarProducto.Size = new Size(253, 66);
            btnQuitarProducto.TabIndex = 28;
            btnQuitarProducto.Text = "QUITAR PRODUCTO";
            btnQuitarProducto.UseVisualStyleBackColor = true;
            btnQuitarProducto.Click += btnQuitarProducto_Click;
            // 
            // btnFacturarConfirmar
            // 
            btnFacturarConfirmar.Location = new Point(565, 70);
            btnFacturarConfirmar.Name = "btnFacturarConfirmar";
            btnFacturarConfirmar.Size = new Size(306, 66);
            btnFacturarConfirmar.TabIndex = 25;
            btnFacturarConfirmar.Text = "FACTURAR Y CONFIRMAR VENTA";
            btnFacturarConfirmar.UseVisualStyleBackColor = true;
            btnFacturarConfirmar.Click += btnConfirmarVenta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 17);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 27;
            label1.Text = "Total:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(27, 17);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(69, 25);
            lblCliente.TabIndex = 26;
            lblCliente.Text = "Cliente:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvCarrito, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvCatalogo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(966, 345);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Dock = DockStyle.Fill;
            dgvCarrito.Location = new Point(486, 3);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.Size = new Size(477, 339);
            dgvCarrito.TabIndex = 18;
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.AllowUserToAddRows = false;
            dgvCatalogo.AllowUserToDeleteRows = false;
            dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalogo.Dock = DockStyle.Fill;
            dgvCatalogo.Location = new Point(3, 3);
            dgvCatalogo.MultiSelect = false;
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.ReadOnly = true;
            dgvCatalogo.RowHeadersWidth = 62;
            dgvCatalogo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCatalogo.Size = new Size(477, 339);
            dgvCatalogo.TabIndex = 13;
            dgvCatalogo.CellDoubleClick += dgvCatalogo_CellDoubleClick;
            // 
            // PanelVentasControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PanelVentasControl";
            Size = new Size(966, 645);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtReceta;
        private Label lblReceta;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private CheckBox chkRequiereReceta;
        private DataGridView dgvCatalogo;
        private DataGridView dgvCarrito;
        private ComboBox cbxCliente;
        private Label lblTotal;
        private Button btnQuitarProducto;
        private Button btnFacturarConfirmar;
        private Label label1;
        private Label lblCliente;
    }
}
