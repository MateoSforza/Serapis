namespace Serapis.Vista
{
    partial class PanelClientesControl
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
            btnCargar = new Button();
            lblBaja = new Label();
            cbxInactivos = new ComboBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            panel2 = new Panel();
            txtDNI = new TextBox();
            lblDNI = new Label();
            chkInactivos = new CheckBox();
            txtObraSocial = new TextBox();
            txtTelefono = new TextBox();
            btnLimpiar = new Button();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblObraSocial = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            panel3 = new Panel();
            dgvClientes = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCargar);
            panel1.Controls.Add(lblBaja);
            panel1.Controls.Add(cbxInactivos);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 512);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 132);
            panel1.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(261, 71);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(212, 48);
            btnCargar.TabIndex = 20;
            btnCargar.Text = "CARGAR";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // lblBaja
            // 
            lblBaja.AutoSize = true;
            lblBaja.Location = new Point(752, 18);
            lblBaja.Name = "lblBaja";
            lblBaja.Size = new Size(131, 25);
            lblBaja.TabIndex = 19;
            lblBaja.Text = "Dados de baja:";
            // 
            // cbxInactivos
            // 
            cbxInactivos.FormattingEnabled = true;
            cbxInactivos.Location = new Point(910, 15);
            cbxInactivos.Name = "cbxInactivos";
            cbxInactivos.Size = new Size(182, 33);
            cbxInactivos.TabIndex = 18;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(261, 15);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(212, 48);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(22, 71);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(212, 48);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(22, 15);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(212, 48);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(15, 403);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(122, 25);
            lblBuscar.TabIndex = 21;
            lblBuscar.Text = "Buscar cliente:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(173, 400);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(150, 31);
            txtBuscar.TabIndex = 20;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDNI);
            panel2.Controls.Add(lblDNI);
            panel2.Controls.Add(chkInactivos);
            panel2.Controls.Add(lblBuscar);
            panel2.Controls.Add(txtObraSocial);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(lblObraSocial);
            panel2.Controls.Add(lblTelefono);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblApellido);
            panel2.Controls.Add(lblNombre);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 512);
            panel2.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(172, 133);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(150, 31);
            txtDNI.TabIndex = 24;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(22, 136);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(43, 25);
            lblDNI.TabIndex = 23;
            lblDNI.Text = "Dni:";
            // 
            // chkInactivos
            // 
            chkInactivos.AutoSize = true;
            chkInactivos.Location = new Point(38, 469);
            chkInactivos.Name = "chkInactivos";
            chkInactivos.Size = new Size(164, 29);
            chkInactivos.TabIndex = 22;
            chkInactivos.Text = "VER INACTIVOS";
            chkInactivos.UseVisualStyleBackColor = true;
            chkInactivos.CheckedChanged += chkInactivos_CheckedChanged;
            // 
            // txtObraSocial
            // 
            txtObraSocial.Location = new Point(172, 272);
            txtObraSocial.Name = "txtObraSocial";
            txtObraSocial.Size = new Size(150, 31);
            txtObraSocial.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(173, 224);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 18;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(297, 458);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(56, 48);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "\U0001f9f9";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(172, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 17;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(173, 85);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 16;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 15;
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Location = new Point(21, 275);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(107, 25);
            lblObraSocial.TabIndex = 14;
            lblObraSocial.Text = "Obra Social:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(22, 227);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(83, 25);
            lblTelefono.TabIndex = 13;
            lblTelefono.Text = "Telefono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(21, 179);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(22, 88);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 25);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(22, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvClientes);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(359, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(747, 512);
            panel3.TabIndex = 2;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.Location = new Point(0, 0);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(747, 512);
            dgvClientes.TabIndex = 11;
            // 
            // PanelClientesControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PanelClientesControl";
            Size = new Size(1106, 644);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvClientes;
        private TextBox txtObraSocial;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblObraSocial;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Label lblBaja;
        private ComboBox cbxInactivos;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private CheckBox chkInactivos;
        private TextBox txtDNI;
        private Label lblDNI;
        private Button btnCargar;
    }
}
