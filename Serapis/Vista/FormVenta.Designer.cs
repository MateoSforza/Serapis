namespace Serapis.Vista
{
    partial class FormVenta
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
            dgvProductos = new DataGridView();
            cbxCliente = new ComboBox();
            checkBox1 = new CheckBox();
            txtReceta = new TextBox();
            btnRegistrarVenta = new Button();
            lblReceta = new Label();
            lblCliente = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(428, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(360, 225);
            dgvProductos.TabIndex = 0;
            // 
            // cbxCliente
            // 
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(96, 167);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(182, 33);
            cbxCliente.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(96, 115);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtReceta
            // 
            txtReceta.Location = new Point(96, 48);
            txtReceta.Name = "txtReceta";
            txtReceta.Size = new Size(150, 31);
            txtReceta.TabIndex = 3;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(105, 311);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(173, 41);
            btnRegistrarVenta.TabIndex = 4;
            btnRegistrarVenta.Text = "REGISTRAR VENTA";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // lblReceta
            // 
            lblReceta.AutoSize = true;
            lblReceta.Location = new Point(23, 54);
            lblReceta.Name = "lblReceta";
            lblReceta.Size = new Size(63, 25);
            lblReceta.TabIndex = 5;
            lblReceta.Text = "Receta";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(23, 116);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 25);
            lblCliente.TabIndex = 6;
            lblCliente.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 170);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lblCliente);
            Controls.Add(lblReceta);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(txtReceta);
            Controls.Add(checkBox1);
            Controls.Add(cbxCliente);
            Controls.Add(dgvProductos);
            Name = "FormVenta";
            Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private ComboBox cbxCliente;
        private CheckBox checkBox1;
        private TextBox txtReceta;
        private Button btnRegistrarVenta;
        private Label lblReceta;
        private Label lblCliente;
        private Label label3;
    }
}