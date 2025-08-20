namespace Serapis.Vista
{
    partial class LoginControl
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
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            btnLogin = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(112, 83);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(86, 24);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "USUARIO";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(112, 110);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(328, 30);
            txtUsuario.TabIndex = 9;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.Click += txtUsuario_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(112, 204);
            txtContraseña.MaxLength = 40767;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(328, 30);
            txtContraseña.TabIndex = 10;
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.Click += txtContraseña_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(112, 177);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(125, 24);
            lblContraseña.TabIndex = 12;
            lblContraseña.Text = "CONTRASEÑA";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 0, 192);
            btnLogin.Dock = DockStyle.Bottom;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Gold;
            btnLogin.Location = new Point(0, 367);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(574, 62);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "ENTRAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(284, 305);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 22);
            lblError.TabIndex = 14;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Name = "LoginControl";
            Size = new Size(574, 429);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private Button btnLogin;
        private Label lblError;
    }
}
