namespace Serapis.Vista
{
    partial class FormLogin
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
            btnLogin = new Button();
            lblContraseña = new Label();
            lblUsuario = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(523, 210);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(165, 242);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(105, 25);
            lblContraseña.TabIndex = 8;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(194, 183);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 25);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuario:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(298, 239);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(150, 31);
            txtContraseña.TabIndex = 6;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(298, 180);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 5;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblContraseña;
        private Label lblUsuario;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
    }
}