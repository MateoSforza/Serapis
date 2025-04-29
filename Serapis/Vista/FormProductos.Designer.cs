namespace Serapis.Vista
{
    partial class FormProductos
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
            dgvProductos = new DataGridView();
            btnCargar = new Button();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            txtPrecio = new TextBox();
            lblNombre = new Label();
            lblCodigo = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            txtStock = new TextBox();
            lblFdv = new Label();
            lblLaboratorio = new Label();
            txtLaboratorio = new TextBox();
            dtpFdv = new DateTimePicker();
            btnModificar = new Button();
            btnEliminar = new Button();
            cbxInactivos = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(589, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(717, 381);
            dgvProductos.TabIndex = 0;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(594, 473);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(217, 42);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "CARGAR PRODUCTO";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(594, 415);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(217, 42);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR PRODUCTO";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 248);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(125, 305);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 31);
            txtCodigo.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(125, 362);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 254);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(44, 308);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(75, 25);
            lblCodigo.TabIndex = 7;
            lblCodigo.Text = "Codigo:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(55, 368);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(64, 25);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(60, 424);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(59, 25);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(125, 421);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 9;
            // 
            // lblFdv
            // 
            lblFdv.AutoSize = true;
            lblFdv.Location = new Point(11, 557);
            lblFdv.Name = "lblFdv";
            lblFdv.Size = new Size(188, 25);
            lblFdv.TabIndex = 12;
            lblFdv.Text = "Fecha de Vencimiento:";
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Location = new Point(11, 473);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(108, 25);
            lblLaboratorio.TabIndex = 14;
            lblLaboratorio.Text = "Laboratorio:";
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Location = new Point(125, 470);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(150, 31);
            txtLaboratorio.TabIndex = 13;
            // 
            // dtpFdv
            // 
            dtpFdv.Location = new Point(205, 552);
            dtpFdv.Name = "dtpFdv";
            dtpFdv.Size = new Size(300, 31);
            dtpFdv.TabIndex = 15;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(841, 415);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(216, 42);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "MODIFICAR PRODUCTO";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(841, 470);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(216, 42);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "ELIMINAR PRODUCTO";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbxInactivos
            // 
            cbxInactivos.AutoSize = true;
            cbxInactivos.Location = new Point(205, 603);
            cbxInactivos.Name = "cbxInactivos";
            cbxInactivos.Size = new Size(164, 29);
            cbxInactivos.TabIndex = 18;
            cbxInactivos.Text = "VER INACTIVOS";
            cbxInactivos.UseVisualStyleBackColor = true;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 644);
            Controls.Add(cbxInactivos);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(dtpFdv);
            Controls.Add(lblLaboratorio);
            Controls.Add(txtLaboratorio);
            Controls.Add(lblFdv);
            Controls.Add(lblStock);
            Controls.Add(txtStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblCodigo);
            Controls.Add(lblNombre);
            Controls.Add(txtPrecio);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(btnCargar);
            Controls.Add(dgvProductos);
            Name = "FormProductos";
            Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnCargar;
        private Button btnAgregar;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private TextBox txtPrecio;
        private Label lblNombre;
        private Label lblCodigo;
        private Label lblPrecio;
        private Label lblStock;
        private TextBox txtStock;
        private Label lblFdv;
        private Label lblLaboratorio;
        private TextBox txtLaboratorio;
        private DateTimePicker dtpFdv;
        private Button btnModificar;
        private Button btnEliminar;
        private CheckBox cbxInactivos;
    }
}