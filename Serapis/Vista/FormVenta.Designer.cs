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
            chkRequiereReceta = new CheckBox();
            txtReceta = new TextBox();
            btnRegistrarVenta = new Button();
            lblReceta = new Label();
            lblCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(311, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(673, 488);
            dgvProductos.TabIndex = 0;
            // 
            // cbxCliente
            // 
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(96, 28);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(182, 33);
            cbxCliente.TabIndex = 1;
            // 
            // chkRequiereReceta
            // 
            chkRequiereReceta.AutoSize = true;
            chkRequiereReceta.Location = new Point(49, 89);
            chkRequiereReceta.Name = "chkRequiereReceta";
            chkRequiereReceta.Size = new Size(158, 29);
            chkRequiereReceta.TabIndex = 2;
            chkRequiereReceta.Text = "Requiere receta";
            chkRequiereReceta.UseVisualStyleBackColor = true;
            chkRequiereReceta.CheckedChanged += chkRequiereReceta_CheckedChanged;
            // 
            // txtReceta
            // 
            txtReceta.Location = new Point(96, 142);
            txtReceta.Name = "txtReceta";
            txtReceta.Size = new Size(182, 31);
            txtReceta.TabIndex = 3;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(34, 231);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(230, 62);
            btnRegistrarVenta.TabIndex = 4;
            btnRegistrarVenta.Text = "REGISTRAR VENTA";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // lblReceta
            // 
            lblReceta.AutoSize = true;
            lblReceta.Location = new Point(14, 148);
            lblReceta.Name = "lblReceta";
            lblReceta.Size = new Size(63, 25);
            lblReceta.TabIndex = 5;
            lblReceta.Text = "Receta";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(12, 31);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 25);
            lblCliente.TabIndex = 6;
            lblCliente.Text = "Cliente";
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 512);
            Controls.Add(lblCliente);
            Controls.Add(lblReceta);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(txtReceta);
            Controls.Add(chkRequiereReceta);
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
        private CheckBox chkRequiereReceta;
        private TextBox txtReceta;
        private Button btnRegistrarVenta;
        private Label lblReceta;
        private Label lblCliente;
    }
}