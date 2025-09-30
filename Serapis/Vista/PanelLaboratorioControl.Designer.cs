namespace Serapis.Vista
{
    partial class PanelLaboratorioControl
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
            gbxLaboratorio = new GroupBox();
            lblFDV = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            lblLaboratorio = new Label();
            lblCodigo = new Label();
            lblNombre = new Label();
            btnDesactivar = new Button();
            btnAgregar = new Button();
            chkReceta = new CheckBox();
            dtpFdv = new DateTimePicker();
            nudPrecio = new NumericUpDown();
            nudStock = new NumericUpDown();
            txtLaboratorio = new TextBox();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            dgvProductosLabo = new DataGridView();
            gbxLaboratorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosLabo).BeginInit();
            SuspendLayout();
            // 
            // gbxLaboratorio
            // 
            gbxLaboratorio.Controls.Add(lblFDV);
            gbxLaboratorio.Controls.Add(lblPrecio);
            gbxLaboratorio.Controls.Add(lblStock);
            gbxLaboratorio.Controls.Add(lblLaboratorio);
            gbxLaboratorio.Controls.Add(lblCodigo);
            gbxLaboratorio.Controls.Add(lblNombre);
            gbxLaboratorio.Controls.Add(btnDesactivar);
            gbxLaboratorio.Controls.Add(btnAgregar);
            gbxLaboratorio.Controls.Add(chkReceta);
            gbxLaboratorio.Controls.Add(dtpFdv);
            gbxLaboratorio.Controls.Add(nudPrecio);
            gbxLaboratorio.Controls.Add(nudStock);
            gbxLaboratorio.Controls.Add(txtLaboratorio);
            gbxLaboratorio.Controls.Add(txtCodigo);
            gbxLaboratorio.Controls.Add(txtNombre);
            gbxLaboratorio.Dock = DockStyle.Left;
            gbxLaboratorio.Location = new Point(0, 0);
            gbxLaboratorio.Name = "gbxLaboratorio";
            gbxLaboratorio.Size = new Size(471, 755);
            gbxLaboratorio.TabIndex = 0;
            gbxLaboratorio.TabStop = false;
            gbxLaboratorio.Text = "Laboratorio";
            // 
            // lblFDV
            // 
            lblFDV.AutoSize = true;
            lblFDV.Location = new Point(17, 409);
            lblFDV.Name = "lblFDV";
            lblFDV.Size = new Size(113, 25);
            lblFDV.TabIndex = 16;
            lblFDV.Text = "Vencimiento:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(66, 340);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(64, 25);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(71, 275);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(59, 25);
            lblStock.TabIndex = 14;
            lblStock.Text = "Stock:";
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Location = new Point(22, 208);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(108, 25);
            lblLaboratorio.TabIndex = 13;
            lblLaboratorio.Text = "Laboratorio:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(55, 140);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(75, 25);
            lblCodigo.TabIndex = 10;
            lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(48, 77);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre:";
            // 
            // btnDesactivar
            // 
            btnDesactivar.Location = new Point(250, 599);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(194, 58);
            btnDesactivar.TabIndex = 8;
            btnDesactivar.Text = "DESACTIVAR PRODUCTO";
            btnDesactivar.UseVisualStyleBackColor = true;
            btnDesactivar.Click += btnDesactivar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(17, 599);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(194, 58);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "AGREGAR PRODUCTO";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // chkReceta
            // 
            chkReceta.AutoSize = true;
            chkReceta.Location = new Point(122, 477);
            chkReceta.Name = "chkReceta";
            chkReceta.Size = new Size(183, 29);
            chkReceta.TabIndex = 6;
            chkReceta.Text = "REQUIERE RECETA";
            chkReceta.UseVisualStyleBackColor = true;
            // 
            // dtpFdv
            // 
            dtpFdv.Location = new Point(149, 404);
            dtpFdv.Name = "dtpFdv";
            dtpFdv.Size = new Size(300, 31);
            dtpFdv.TabIndex = 5;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(149, 338);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(180, 31);
            nudPrecio.TabIndex = 4;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(149, 273);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(180, 31);
            nudStock.TabIndex = 3;
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Location = new Point(149, 205);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(150, 31);
            txtLaboratorio.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(149, 137);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 31);
            txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(149, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 0;
            // 
            // dgvProductosLabo
            // 
            dgvProductosLabo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosLabo.Dock = DockStyle.Fill;
            dgvProductosLabo.Location = new Point(471, 0);
            dgvProductosLabo.Name = "dgvProductosLabo";
            dgvProductosLabo.RowHeadersWidth = 62;
            dgvProductosLabo.Size = new Size(496, 755);
            dgvProductosLabo.TabIndex = 1;
            // 
            // PanelLaboratorioControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvProductosLabo);
            Controls.Add(gbxLaboratorio);
            Name = "PanelLaboratorioControl";
            Size = new Size(967, 755);
            gbxLaboratorio.ResumeLayout(false);
            gbxLaboratorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosLabo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxLaboratorio;
        private Label lblFDV;
        private Label lblPrecio;
        private Label lblStock;
        private Label lblLaboratorio;
        private Label lblCodigo;
        private Label lblNombre;
        private Button btnDesactivar;
        private Button btnAgregar;
        private CheckBox chkReceta;
        private DateTimePicker dtpFdv;
        private NumericUpDown nudPrecio;
        private NumericUpDown nudStock;
        private TextBox txtLaboratorio;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private DataGridView dgvProductosLabo;
    }
}
