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
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            btnLogin = new Button();
            lblUsuario = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(9, 341);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(125, 24);
            lblContraseña.TabIndex = 8;
            lblContraseña.Text = "CONTRASEÑA";
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(9, 368);
            txtContraseña.MaxLength = 40767;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(328, 30);
            txtContraseña.TabIndex = 6;
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(9, 274);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(328, 30);
            txtUsuario.TabIndex = 5;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 255, 192);
            btnLogin.Dock = DockStyle.Bottom;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(0, 559);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(374, 62);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "ENTRAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(9, 247);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(86, 24);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "USUARIO";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(952, 627);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(lblContraseña);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 621);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 99);
            label1.Name = "label1";
            label1.Size = new Size(372, 60);
            label1.TabIndex = 10;
            label1.Text = "Inicio Sesion";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_08_13_170135;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(383, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 621);
            panel2.TabIndex = 1;
            // 
            // FormLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 627);
            Controls.Add(tableLayoutPanel1);
            Name = "FormLogin";
            Text = "FormLogin";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblContraseña;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Button btnLogin;
        private Label lblUsuario;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}