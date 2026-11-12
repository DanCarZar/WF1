namespace WF1.Forms
{
    partial class FormVentas
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
            lblCodigoBarra = new Label();
            lblTotalTexto = new Label();
            lblTotal = new Label();
            txtCodigoBarra = new TextBox();
            btnAgregar = new Button();
            btnCobrar = new Button();
            dgvCarrito = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // lblCodigoBarra
            // 
            lblCodigoBarra.AutoSize = true;
            lblCodigoBarra.Location = new Point(15, 169);
            lblCodigoBarra.Name = "lblCodigoBarra";
            lblCodigoBarra.Size = new Size(76, 15);
            lblCodigoBarra.TabIndex = 0;
            lblCodigoBarra.Text = "Codigo Barra";
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Location = new Point(318, 623);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(47, 15);
            lblTotalTexto.TabIndex = 1;
            lblTotalTexto.Text = "TOTAL :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(557, 623);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(13, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "0";
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.Location = new Point(15, 223);
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.Size = new Size(100, 23);
            txtCodigoBarra.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(16, 324);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(1058, 634);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(75, 23);
            btnCobrar.TabIndex = 5;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(244, 33);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Size = new Size(889, 542);
            dgvCarrito.TabIndex = 6;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 731);
            Controls.Add(dgvCarrito);
            Controls.Add(btnCobrar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCodigoBarra);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalTexto);
            Controls.Add(lblCodigoBarra);
            Name = "FormVentas";
            Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoBarra;
        private Label lblTotalTexto;
        private Label lblTotal;
        private TextBox txtCodigoBarra;
        private Button btnAgregar;
        private Button btnCobrar;
        private DataGridView dgvCarrito;
    }
}