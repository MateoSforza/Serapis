namespace Serapis.Vista
{
    partial class FormCantidad
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
            label1 = new Label();
            numericUpDownCantidad = new NumericUpDown();
            btnAceptar = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 170);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese cantidad:";
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Location = new Point(280, 168);
            numericUpDownCantidad.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDownCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(180, 31);
            numericUpDownCantidad.TabIndex = 1;
            numericUpDownCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(151, 246);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(280, 246);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(numericUpDownCantidad);
            panel1.Controls.Add(btnAceptar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 418);
            panel1.TabIndex = 4;
            // 
            // FormCantidad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 418);
            Controls.Add(panel1);
            Name = "FormCantidad";
            Text = "FormCantidad";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownCantidad;
        private Button btnAceptar;
        private Button btnCancelar;
        private Panel panel1;
    }
}