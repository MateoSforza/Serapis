namespace Serapis.Vista
{
    partial class FormComprasRealizadas
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
            dgvCompras = new DataGridView();
            btnVerDetalle = new Button();
            btnFiltroFecha = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Location = new Point(12, 12);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersWidth = 62;
            dgvCompras.Size = new Size(776, 327);
            dgvCompras.TabIndex = 0;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Location = new Point(174, 374);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(164, 54);
            btnVerDetalle.TabIndex = 1;
            btnVerDetalle.Text = "Ver Detalles";
            btnVerDetalle.UseVisualStyleBackColor = true;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // btnFiltroFecha
            // 
            btnFiltroFecha.Location = new Point(468, 374);
            btnFiltroFecha.Name = "btnFiltroFecha";
            btnFiltroFecha.Size = new Size(164, 54);
            btnFiltroFecha.TabIndex = 2;
            btnFiltroFecha.Text = "Filtrar por Fecha";
            btnFiltroFecha.UseVisualStyleBackColor = true;
            // 
            // FormComprasRealizadas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFiltroFecha);
            Controls.Add(btnVerDetalle);
            Controls.Add(dgvCompras);
            Name = "FormComprasRealizadas";
            Text = "FormComprasRealizadas";
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCompras;
        private Button btnVerDetalle;
        private Button btnFiltroFecha;
    }
}