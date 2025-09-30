namespace Serapis.Vista
{
    partial class PanelProveedoresControl
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            panel2 = new Panel();
            lblEstado = new Label();
            cbxEstado = new ComboBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtRubro = new TextBox();
            txtCuit = new TextBox();
            txtNombre = new TextBox();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblRubro = new Label();
            lblCuit = new Label();
            lblNombre = new Label();
            panel3 = new Panel();
            dgvProveedores = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCargar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 479);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 150);
            panel1.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(821, 49);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(184, 59);
            btnCargar.TabIndex = 16;
            btnCargar.Text = "CARGAR";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(551, 49);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(184, 59);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(296, 49);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(184, 59);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 49);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(184, 59);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblEstado);
            panel2.Controls.Add(cbxEstado);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(txtRubro);
            panel2.Controls.Add(txtCuit);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblTelefono);
            panel2.Controls.Add(lblRubro);
            panel2.Controls.Add(lblCuit);
            panel2.Controls.Add(lblNombre);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 479);
            panel2.TabIndex = 1;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(57, 389);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(182, 25);
            lblEstado.TabIndex = 27;
            lblEstado.Text = "Estado de Proveedor:";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(57, 428);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(182, 33);
            cbxEstado.TabIndex = 26;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(123, 305);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(123, 238);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 24;
            // 
            // txtRubro
            // 
            txtRubro.Location = new Point(123, 171);
            txtRubro.Name = "txtRubro";
            txtRubro.Size = new Size(150, 31);
            txtRubro.TabIndex = 23;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(123, 105);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(150, 31);
            txtCuit.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(123, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 21;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(41, 308);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "Email:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(41, 241);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(83, 25);
            lblTelefono.TabIndex = 19;
            lblTelefono.Text = "Telefono:";
            // 
            // lblRubro
            // 
            lblRubro.AutoSize = true;
            lblRubro.Location = new Point(41, 174);
            lblRubro.Name = "lblRubro";
            lblRubro.Size = new Size(65, 25);
            lblRubro.TabIndex = 18;
            lblRubro.Text = "Rubro:";
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(41, 108);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(53, 25);
            lblCuit.TabIndex = 17;
            lblCuit.Text = "CUIT:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 16;
            lblNombre.Text = "Nombre:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvProveedores);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(349, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(722, 479);
            panel3.TabIndex = 2;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Dock = DockStyle.Fill;
            dgvProveedores.Location = new Point(0, 0);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 62;
            dgvProveedores.Size = new Size(722, 479);
            dgvProveedores.TabIndex = 14;
            // 
            // PanelProveedoresControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PanelProveedoresControl";
            Size = new Size(1071, 629);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblEstado;
        private ComboBox cbxEstado;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtRubro;
        private TextBox txtCuit;
        private TextBox txtNombre;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblRubro;
        private Label lblCuit;
        private Label lblNombre;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvProveedores;
        private Button btnCargar;
    }
}
