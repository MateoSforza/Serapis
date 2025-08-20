namespace Serapis.Vista
{
    partial class PanelConfiguracionControl
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
            label1 = new Label();
            label2 = new Label();
            lblNombre = new Label();
            lblRol = new Label();
            txtCambiar = new TextBox();
            txtConfirmar = new TextBox();
            lblNueva = new Label();
            lblConfirmar = new Label();
            btnCambiarContraseña = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 51);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 112);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 1;
            label2.Text = "Rol:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(237, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 25);
            lblNombre.TabIndex = 2;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(237, 112);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(0, 25);
            lblRol.TabIndex = 3;
            // 
            // txtCambiar
            // 
            txtCambiar.Location = new Point(215, 175);
            txtCambiar.Name = "txtCambiar";
            txtCambiar.Size = new Size(150, 31);
            txtCambiar.TabIndex = 4;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(215, 247);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(150, 31);
            txtConfirmar.TabIndex = 5;
            // 
            // lblNueva
            // 
            lblNueva.AutoSize = true;
            lblNueva.Location = new Point(52, 178);
            lblNueva.Name = "lblNueva";
            lblNueva.Size = new Size(157, 25);
            lblNueva.TabIndex = 6;
            lblNueva.Text = "Nueva contraseña:";
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Location = new Point(23, 250);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(186, 25);
            lblConfirmar.TabIndex = 7;
            lblConfirmar.Text = "Confirmar contraseña:";
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.Location = new Point(105, 313);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(225, 63);
            btnCambiarContraseña.TabIndex = 8;
            btnCambiarContraseña.Text = "CAMBIAR CONTRASEÑA";
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            // 
            // PanelConfiguracionControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCambiarContraseña);
            Controls.Add(lblConfirmar);
            Controls.Add(lblNueva);
            Controls.Add(txtConfirmar);
            Controls.Add(txtCambiar);
            Controls.Add(lblRol);
            Controls.Add(lblNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PanelConfiguracionControl";
            Size = new Size(454, 432);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblNombre;
        private Label lblRol;
        private TextBox txtCambiar;
        private TextBox txtConfirmar;
        private Label lblNueva;
        private Label lblConfirmar;
        private Button btnCambiarContraseña;
    }
}
