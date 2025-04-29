namespace Serapis.Vista
{
    partial class FormAdmin
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
            btnRegistrarUsuario = new Button();
            SuspendLayout();
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Location = new Point(389, 175);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(203, 34);
            btnRegistrarUsuario.TabIndex = 0;
            btnRegistrarUsuario.Text = "REGISTRAR USUARIO";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarUsuario);
            Name = "FormAdmin";
            Text = "FormAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarUsuario;
    }
}