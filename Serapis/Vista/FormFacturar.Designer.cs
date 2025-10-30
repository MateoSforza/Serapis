namespace Serapis.UI.Vista
{
    partial class FormFacturar
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
            cmbTipo = new ComboBox();
            lblPuntoVenta = new Label();
            txtPuntoVenta = new TextBox();
            lblEfectivo = new Label();
            lblDebito = new Label();
            lblCredito = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            lblDiferencia = new Label();
            lblTotal = new Label();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(12, 40);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(182, 33);
            cmbTipo.TabIndex = 0;
            // 
            // lblPuntoVenta
            // 
            lblPuntoVenta.AutoSize = true;
            lblPuntoVenta.Location = new Point(272, 40);
            lblPuntoVenta.Name = "lblPuntoVenta";
            lblPuntoVenta.Size = new Size(137, 25);
            lblPuntoVenta.TabIndex = 1;
            lblPuntoVenta.Text = "Punto de Venta:";
            // 
            // txtPuntoVenta
            // 
            txtPuntoVenta.Location = new Point(415, 37);
            txtPuntoVenta.Name = "txtPuntoVenta";
            txtPuntoVenta.Size = new Size(150, 31);
            txtPuntoVenta.TabIndex = 2;
            // 
            // lblEfectivo
            // 
            lblEfectivo.AutoSize = true;
            lblEfectivo.Location = new Point(81, 123);
            lblEfectivo.Name = "lblEfectivo";
            lblEfectivo.Size = new Size(78, 25);
            lblEfectivo.TabIndex = 3;
            lblEfectivo.Text = "Efectivo:";
            // 
            // lblDebito
            // 
            lblDebito.AutoSize = true;
            lblDebito.Location = new Point(9, 189);
            lblDebito.Name = "lblDebito";
            lblDebito.Size = new Size(150, 25);
            lblDebito.TabIndex = 4;
            lblDebito.Text = "Tarjeta de Debito:";
            // 
            // lblCredito
            // 
            lblCredito.AutoSize = true;
            lblCredito.Location = new Point(5, 259);
            lblCredito.Name = "lblCredito";
            lblCredito.Size = new Size(154, 25);
            lblCredito.TabIndex = 5;
            lblCredito.Text = "Tarjeta de Credito:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(192, 121);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(192, 187);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(180, 31);
            numericUpDown2.TabIndex = 7;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Location = new Point(192, 257);
            numericUpDown3.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(180, 31);
            numericUpDown3.TabIndex = 8;
            // 
            // lblDiferencia
            // 
            lblDiferencia.AutoSize = true;
            lblDiferencia.Location = new Point(9, 325);
            lblDiferencia.Name = "lblDiferencia";
            lblDiferencia.Size = new Size(94, 25);
            lblDiferencia.TabIndex = 9;
            lblDiferencia.Text = "Diferencia:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(5, 376);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 25);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total a pagar:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Enabled = false;
            btnConfirmar.Location = new Point(415, 348);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(264, 53);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "CONFIRMAR Y FACTURAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // FormFacturar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 427);
            Controls.Add(btnConfirmar);
            Controls.Add(lblTotal);
            Controls.Add(lblDiferencia);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(lblCredito);
            Controls.Add(lblDebito);
            Controls.Add(lblEfectivo);
            Controls.Add(txtPuntoVenta);
            Controls.Add(lblPuntoVenta);
            Controls.Add(cmbTipo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFacturar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormFacturar";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipo;
        private Label lblPuntoVenta;
        private TextBox txtPuntoVenta;
        private Label lblEfectivo;
        private Label lblDebito;
        private Label lblCredito;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label lblDiferencia;
        private Label lblTotal;
        private Button btnConfirmar;
    }
}