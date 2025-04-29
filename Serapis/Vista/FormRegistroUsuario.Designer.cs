namespace Serapis.Vista
{
    partial class FormRegistroUsuario
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
            btnRegistrar = new Button();
            lblContraseña = new Label();
            lblUsuario = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            lblRol = new Label();
            cbxRol = new ComboBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(523, 210);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(165, 242);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(105, 25);
            lblContraseña.TabIndex = 13;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(194, 183);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 25);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "Usuario:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(298, 239);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(150, 31);
            txtContraseña.TabIndex = 11;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(298, 180);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 10;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(229, 296);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(41, 25);
            lblRol.TabIndex = 15;
            lblRol.Text = "Rol:";
            // 
            // cbxRol
            // 
            cbxRol.FormattingEnabled = true;
            cbxRol.Location = new Point(298, 293);
            cbxRol.Name = "cbxRol";
            cbxRol.Size = new Size(182, 33);
            cbxRol.TabIndex = 16;
            // 
            // FormRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxRol);
            Controls.Add(lblRol);
            Controls.Add(btnRegistrar);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "FormRegistroUsuario";
            Text = "FormRegistroUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Label lblContraseña;
        private Label lblUsuario;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label lblRol;
        private ComboBox cbxRol;
    }
}