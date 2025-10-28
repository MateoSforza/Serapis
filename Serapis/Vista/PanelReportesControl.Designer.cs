namespace Serapis.Vista
{
    partial class PanelReportesControl
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
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            panel1 = new Panel();
            lblTotalVentas = new Label();
            lblTotalCompras = new Label();
            label4 = new Label();
            label3 = new Label();
            lblHasta = new Label();
            lblDesde = new Label();
            btnGenerar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvVentasClientes = new DataGridView();
            dgvCompras = new DataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentasClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(27, 120);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(300, 31);
            dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(27, 207);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(300, 31);
            dtpHasta.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotalVentas);
            panel1.Controls.Add(lblTotalCompras);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblHasta);
            panel1.Controls.Add(lblDesde);
            panel1.Controls.Add(btnGenerar);
            panel1.Controls.Add(dtpDesde);
            panel1.Controls.Add(dtpHasta);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 647);
            panel1.TabIndex = 3;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Location = new Point(198, 354);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(0, 25);
            lblTotalVentas.TabIndex = 8;
            // 
            // lblTotalCompras
            // 
            lblTotalCompras.AutoSize = true;
            lblTotalCompras.Location = new Point(198, 295);
            lblTotalCompras.Name = "lblTotalCompras";
            lblTotalCompras.Size = new Size(0, 25);
            lblTotalCompras.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 354);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 6;
            label4.Text = "Total de ventas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 295);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 5;
            label3.Text = "Total de compras:";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(27, 179);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(61, 25);
            lblHasta.TabIndex = 4;
            lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(27, 92);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(66, 25);
            lblDesde.TabIndex = 3;
            lblDesde.Text = "Desde:";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(27, 448);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(201, 50);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "GENERAR REPORTE";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvVentasClientes, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvCompras, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(379, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(540, 647);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // dgvVentasClientes
            // 
            dgvVentasClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentasClientes.Dock = DockStyle.Fill;
            dgvVentasClientes.Location = new Point(3, 3);
            dgvVentasClientes.Name = "dgvVentasClientes";
            dgvVentasClientes.RowHeadersWidth = 62;
            dgvVentasClientes.Size = new Size(534, 317);
            dgvVentasClientes.TabIndex = 1;
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Dock = DockStyle.Fill;
            dgvCompras.Location = new Point(3, 326);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersWidth = 62;
            dgvCompras.Size = new Size(534, 318);
            dgvCompras.TabIndex = 6;
            // 
            // PanelReportesControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "PanelReportesControl";
            Size = new Size(919, 647);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentasClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvVentasClientes;
        private DataGridView dgvCompras;
        private Label label4;
        private Label label3;
        private Label lblHasta;
        private Label lblDesde;
        private Button btnGenerar;
        private Label lblTotalVentas;
        private Label lblTotalCompras;
    }
}
