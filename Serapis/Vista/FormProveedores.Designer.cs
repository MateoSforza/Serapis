namespace Serapis.Vista
{
    partial class FormProveedores
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
            lblCuit = new Label();
            lblRubro = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtNombre = new TextBox();
            txtCuit = new TextBox();
            txtRubro = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvProveedores = new DataGridView();
            cbxEstado = new ComboBox();
            lblEstado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(12, 119);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(53, 25);
            lblCuit.TabIndex = 1;
            lblCuit.Text = "CUIT:";
            // 
            // lblRubro
            // 
            lblRubro.AutoSize = true;
            lblRubro.Location = new Point(12, 185);
            lblRubro.Name = "lblRubro";
            lblRubro.Size = new Size(65, 25);
            lblRubro.TabIndex = 2;
            lblRubro.Text = "Rubro:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(12, 252);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(83, 25);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 319);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(94, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 5;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(94, 116);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(150, 31);
            txtCuit.TabIndex = 6;
            // 
            // txtRubro
            // 
            txtRubro.Location = new Point(94, 182);
            txtRubro.Name = "txtRubro";
            txtRubro.Size = new Size(150, 31);
            txtRubro.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(94, 249);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 316);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(266, 440);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(184, 59);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(543, 440);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(184, 59);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(822, 440);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(184, 59);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(266, 12);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 62;
            dgvProveedores.Size = new Size(740, 401);
            dgvProveedores.TabIndex = 13;
            dgvProveedores.SelectionChanged += dgvProveedores_SelectionChanged;
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(12, 454);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(182, 33);
            cbxEstado.TabIndex = 14;
            cbxEstado.SelectedIndexChanged += cbxEstado_SelectedIndexChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(12, 415);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(182, 25);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Estado de Proveedor:";
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 511);
            Controls.Add(lblEstado);
            Controls.Add(cbxEstado);
            Controls.Add(dgvProveedores);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtRubro);
            Controls.Add(txtCuit);
            Controls.Add(txtNombre);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblRubro);
            Controls.Add(lblCuit);
            Controls.Add(lblNombre);
            Name = "FormProveedores";
            Text = "FormProveedores";
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblCuit;
        private Label lblRubro;
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtNombre;
        private TextBox txtCuit;
        private TextBox txtRubro;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvProveedores;
        private ComboBox cbxEstado;
        private Label lblEstado;
    }
}