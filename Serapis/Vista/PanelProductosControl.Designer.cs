namespace Serapis.Vista
{
    partial class PanelProductosControl
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnCargar = new Button();
            panel2 = new Panel();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            panel1 = new Panel();
            chkRequiereReceta = new CheckBox();
            chkInactivos = new CheckBox();
            dtpFdv = new DateTimePicker();
            lblLaboratorio = new Label();
            txtLaboratorio = new TextBox();
            lblFdv = new Label();
            lblStock = new Label();
            txtStock = new TextBox();
            lblPrecio = new Label();
            lblCodigo = new Label();
            lblNombre = new Label();
            txtPrecio = new TextBox();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            dgvProductos = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(276, 17);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(249, 69);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "ELIMINAR PRODUCTO";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(28, 92);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(217, 66);
            btnModificar.TabIndex = 33;
            btnModificar.Text = "MODIFICAR PRODUCTO";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(28, 17);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(217, 69);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "AGREGAR PRODUCTO";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(276, 92);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(249, 66);
            btnCargar.TabIndex = 19;
            btnCargar.Text = "CARGAR PRODUCTO";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(lblBuscar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnCargar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 770);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 173);
            panel2.TabIndex = 36;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(996, 14);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(150, 31);
            txtBuscar.TabIndex = 38;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(834, 17);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(146, 25);
            lblBuscar.TabIndex = 37;
            lblBuscar.Text = "Buscar producto:";
            // 
            // panel1
            // 
            panel1.Controls.Add(chkRequiereReceta);
            panel1.Controls.Add(chkInactivos);
            panel1.Controls.Add(dtpFdv);
            panel1.Controls.Add(lblLaboratorio);
            panel1.Controls.Add(txtLaboratorio);
            panel1.Controls.Add(lblFdv);
            panel1.Controls.Add(lblStock);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblCodigo);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(txtNombre);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 770);
            panel1.TabIndex = 0;
            // 
            // chkRequiereReceta
            // 
            chkRequiereReceta.AutoSize = true;
            chkRequiereReceta.Location = new Point(169, 534);
            chkRequiereReceta.Name = "chkRequiereReceta";
            chkRequiereReceta.Size = new Size(158, 29);
            chkRequiereReceta.TabIndex = 36;
            chkRequiereReceta.Text = "Requiere receta";
            chkRequiereReceta.UseVisualStyleBackColor = true;
            // 
            // chkInactivos
            // 
            chkInactivos.AutoSize = true;
            chkInactivos.Location = new Point(251, 644);
            chkInactivos.Name = "chkInactivos";
            chkInactivos.Size = new Size(164, 29);
            chkInactivos.TabIndex = 35;
            chkInactivos.Text = "VER INACTIVOS";
            chkInactivos.UseVisualStyleBackColor = true;
            chkInactivos.CheckedChanged += chkInactivos_CheckedChanged;
            // 
            // dtpFdv
            // 
            dtpFdv.Location = new Point(251, 593);
            dtpFdv.Name = "dtpFdv";
            dtpFdv.Size = new Size(300, 31);
            dtpFdv.TabIndex = 32;
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Location = new Point(52, 473);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(108, 25);
            lblLaboratorio.TabIndex = 31;
            lblLaboratorio.Text = "Laboratorio:";
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Location = new Point(169, 470);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(150, 31);
            txtLaboratorio.TabIndex = 30;
            // 
            // lblFdv
            // 
            lblFdv.AutoSize = true;
            lblFdv.Location = new Point(57, 598);
            lblFdv.Name = "lblFdv";
            lblFdv.Size = new Size(188, 25);
            lblFdv.TabIndex = 29;
            lblFdv.Text = "Fecha de Vencimiento:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(51, 424);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(59, 25);
            lblStock.TabIndex = 28;
            lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(169, 421);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 27;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(52, 365);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(64, 25);
            lblPrecio.TabIndex = 26;
            lblPrecio.Text = "Precio:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(52, 308);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(75, 25);
            lblCodigo.TabIndex = 25;
            lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(52, 251);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(169, 362);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 23;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(169, 305);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 31);
            txtCodigo.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 248);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 21;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(600, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(712, 770);
            dgvProductos.TabIndex = 1;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // PanelProductosControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvProductos);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "PanelProductosControl";
            Size = new Size(1312, 943);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnCargar;
        private Panel panel2;
        private Panel panel1;
        private CheckBox chkInactivos;
        private DateTimePicker dtpFdv;
        private Label lblLaboratorio;
        private TextBox txtLaboratorio;
        private Label lblFdv;
        private Label lblStock;
        private TextBox txtStock;
        private Label lblPrecio;
        private Label lblCodigo;
        private Label lblNombre;
        private TextBox txtPrecio;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private DataGridView dgvProductos;
        private CheckBox chkRequiereReceta;
        private TextBox txtBuscar;
        private Label lblBuscar;
    }
}
