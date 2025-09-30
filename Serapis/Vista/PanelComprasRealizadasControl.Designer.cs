namespace Serapis.Vista
{
    partial class PanelComprasRealizadasControl
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
            dgvCompras = new DataGridView();
            panel4 = new Panel();
            label4 = new Label();
            lblDesde = new Label();
            label1 = new Label();
            cmbProveedor = new ComboBox();
            dtpDesde = new DateTimePicker();
            label3 = new Label();
            btnFiltroFecha = new Button();
            dtpHasta = new DateTimePicker();
            btnVerDetalle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Dock = DockStyle.Fill;
            dgvCompras.Location = new Point(509, 0);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersWidth = 62;
            dgvCompras.Size = new Size(513, 708);
            dgvCompras.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblDesde);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cmbProveedor);
            panel4.Controls.Add(dtpDesde);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(btnFiltroFecha);
            panel4.Controls.Add(dtpHasta);
            panel4.Controls.Add(btnVerDetalle);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(509, 708);
            panel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 270);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 18;
            label4.Text = "Hasta:";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(37, 218);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(66, 25);
            lblDesde.TabIndex = 17;
            lblDesde.Text = "Desde:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 16;
            label1.Text = "Buscar Proveedor:";
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(185, 110);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(182, 33);
            cmbProveedor.TabIndex = 15;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(122, 213);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(300, 31);
            dtpDesde.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(37, 23);
            label3.Name = "label3";
            label3.Size = new Size(168, 27);
            label3.TabIndex = 12;
            label3.Text = "Compras realizadas";
            // 
            // btnFiltroFecha
            // 
            btnFiltroFecha.Location = new Point(122, 368);
            btnFiltroFecha.Name = "btnFiltroFecha";
            btnFiltroFecha.Size = new Size(183, 54);
            btnFiltroFecha.TabIndex = 11;
            btnFiltroFecha.Text = "Filtrar por Fecha";
            btnFiltroFecha.UseVisualStyleBackColor = true;
            btnFiltroFecha.Click += btnFiltroFecha_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(122, 265);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(300, 31);
            dtpHasta.TabIndex = 13;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Location = new Point(122, 481);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(183, 54);
            btnVerDetalle.TabIndex = 10;
            btnVerDetalle.Text = "Ver Detalles";
            btnVerDetalle.UseVisualStyleBackColor = true;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // PanelComprasRealizadasControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvCompras);
            Controls.Add(panel4);
            Name = "PanelComprasRealizadasControl";
            Size = new Size(1022, 708);
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private DataGridView dgvCompras;
        private Label label3;
        private Button btnFiltroFecha;
        private Button btnVerDetalle;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Label label1;
        private ComboBox cmbProveedor;
        private Label label4;
        private Label lblDesde;
    }
}
