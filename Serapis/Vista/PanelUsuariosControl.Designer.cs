namespace Serapis.Vista
{
    partial class PanelUsuariosControl
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
            btnCambiarContraseña = new Button();
            btnEliminar = new Button();
            btnRegistrar = new Button();
            lblRol = new Label();
            cbxRol = new ComboBox();
            lblContraseña = new Label();
            lblNombre = new Label();
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            dgvUsuarios = new DataGridView();
            lblEmail = new Label();
            txtEmail = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(btnCambiarContraseña);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(cbxRol);
            panel1.Controls.Add(lblContraseña);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtNombre);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 646);
            panel1.TabIndex = 1;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.Location = new Point(96, 485);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(198, 43);
            btnCambiarContraseña.TabIndex = 8;
            btnCambiarContraseña.Text = "Cambiar contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(199, 360);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 52);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(41, 360);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(137, 52);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(13, 259);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(133, 25);
            lblRol.TabIndex = 5;
            lblRol.Text = "Rol del usuario:";
            // 
            // cbxRol
            // 
            cbxRol.FormattingEnabled = true;
            cbxRol.Location = new Point(154, 256);
            cbxRol.Name = "cbxRol";
            cbxRol.Size = new Size(182, 33);
            cbxRol.TabIndex = 4;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(41, 178);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(105, 25);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(64, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(165, 175);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(150, 31);
            txtContraseña.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(165, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(399, 0);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(396, 646);
            dgvUsuarios.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(64, 117);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(165, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 10;
            // 
            // PanelUsuariosControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvUsuarios);
            Controls.Add(panel1);
            Name = "PanelUsuariosControl";
            Size = new Size(795, 646);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCambiarContraseña;
        private Button btnEliminar;
        private Button btnRegistrar;
        private Label lblRol;
        private ComboBox cbxRol;
        private Label lblContraseña;
        private Label lblNombre;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private DataGridView dgvUsuarios;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}
