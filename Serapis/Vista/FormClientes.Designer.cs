namespace Serapis.Vista
{
    partial class FormClientes
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblObraSocial = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtObraSocial = new TextBox();
            dgvClientes = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            cbxInactivos = new ComboBox();
            lblBaja = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 45);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(12, 104);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 168);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(12, 232);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(83, 25);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono:";
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Location = new Point(12, 296);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(107, 25);
            lblObraSocial.TabIndex = 4;
            lblObraSocial.Text = "Obra Social:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(163, 101);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(163, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(163, 229);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 8;
            // 
            // txtObraSocial
            // 
            txtObraSocial.Location = new Point(163, 293);
            txtObraSocial.Name = "txtObraSocial";
            txtObraSocial.Size = new Size(150, 31);
            txtObraSocial.TabIndex = 9;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(334, 12);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(816, 517);
            dgvClientes.TabIndex = 10;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(48, 355);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(212, 48);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(48, 437);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(212, 48);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(48, 518);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(212, 48);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(334, 541);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(56, 48);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "\U0001f9f9";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cbxInactivos
            // 
            cbxInactivos.FormattingEnabled = true;
            cbxInactivos.Location = new Point(968, 550);
            cbxInactivos.Name = "cbxInactivos";
            cbxInactivos.Size = new Size(182, 33);
            cbxInactivos.TabIndex = 15;
            cbxInactivos.SelectedIndexChanged += cbxInactivos_SelectedIndexChanged;
            // 
            // lblBaja
            // 
            lblBaja.AutoSize = true;
            lblBaja.Location = new Point(810, 553);
            lblBaja.Name = "lblBaja";
            lblBaja.Size = new Size(131, 25);
            lblBaja.TabIndex = 16;
            lblBaja.Text = "Dados de baja:";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 601);
            Controls.Add(lblBaja);
            Controls.Add(cbxInactivos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvClientes);
            Controls.Add(txtObraSocial);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblObraSocial);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "FormClientes";
            Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblObraSocial;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtObraSocial;
        private DataGridView dgvClientes;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private ComboBox cbxInactivos;
        private Label lblBaja;
    }
}