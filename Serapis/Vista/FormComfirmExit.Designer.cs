namespace Serapis.Vista
{
    partial class FormComfirmExit
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
            panel1 = new Panel();
            btnSalirPrograma = new Button();
            btnCerrarSesion = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalirPrograma);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 206);
            panel1.TabIndex = 0;
            // 
            // btnSalirPrograma
            // 
            btnSalirPrograma.Location = new Point(230, 135);
            btnSalirPrograma.Name = "btnSalirPrograma";
            btnSalirPrograma.Size = new Size(176, 43);
            btnSalirPrograma.TabIndex = 2;
            btnSalirPrograma.Text = "Salir del programa";
            btnSalirPrograma.UseVisualStyleBackColor = true;
            btnSalirPrograma.Click += btnSalirPrograma_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(12, 135);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(176, 43);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 71);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 0;
            label1.Text = "¿Que accion desea realizar?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormComfirmExit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 206);
            Controls.Add(panel1);
            Name = "FormComfirmExit";
            Text = "FormComfirmExit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnSalirPrograma;
        private Button btnCerrarSesion;
    }
}