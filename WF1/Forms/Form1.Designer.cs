namespace WF1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigoBarra = new Label();
            lblNombre = new Label();
            lblPrecioCosto = new Label();
            lblPrecioVenta = new Label();
            lblStock = new Label();
            btnGuardar = new Button();
            dgvProductos = new DataGridView();
            txtCodigoBarra = new TextBox();
            txtNombre = new TextBox();
            txtPrecioCosto = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStock = new TextBox();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnVentas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblCodigoBarra
            // 
            lblCodigoBarra.AutoSize = true;
            lblCodigoBarra.Location = new Point(23, 78);
            lblCodigoBarra.Name = "lblCodigoBarra";
            lblCodigoBarra.Size = new Size(76, 15);
            lblCodigoBarra.TabIndex = 0;
            lblCodigoBarra.Text = "Codigo Barra";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 128);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AutoSize = true;
            lblPrecioCosto.Location = new Point(21, 190);
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.Size = new Size(74, 15);
            lblPrecioCosto.TabIndex = 2;
            lblPrecioCosto.Text = "Precio Costo";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(23, 246);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(72, 15);
            lblPrecioVenta.TabIndex = 3;
            lblPrecioVenta.Text = "Precio Venta";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(23, 308);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(701, 415);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(431, 78);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(636, 267);
            dgvProductos.TabIndex = 6;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.Location = new Point(135, 78);
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.Size = new Size(100, 23);
            txtCodigoBarra.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(135, 187);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(100, 23);
            txtPrecioCosto.TabIndex = 9;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(135, 238);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(135, 300);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 11;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(768, 9);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 12;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(701, 29);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(181, 23);
            txtBuscar.TabIndex = 13;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(906, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(992, 415);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(75, 23);
            btnVentas.TabIndex = 15;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += this.btnVentas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 522);
            Controls.Add(btnVentas);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCosto);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigoBarra);
            Controls.Add(dgvProductos);
            Controls.Add(btnGuardar);
            Controls.Add(lblStock);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblPrecioCosto);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigoBarra);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoBarra;
        private Label lblNombre;
        private Label lblPrecioCosto;
        private Label lblPrecioVenta;
        private Label lblStock;
        private Button btnGuardar;
        private DataGridView dgvProductos;
        private TextBox txtCodigoBarra;
        private TextBox txtNombre;
        private TextBox txtPrecioCosto;
        private TextBox txtPrecioVenta;
        private TextBox txtStock;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnVentas;
    }
}
