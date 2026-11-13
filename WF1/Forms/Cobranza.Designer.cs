namespace WF1.Forms
{
    partial class Cobranza
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            treeView1 = new TreeView();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(517, 250);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.AliceBlue;
            dataGridView2.Location = new Point(588, 71);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(533, 250);
            dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.efectivo;
            button1.Location = new Point(32, 404);
            button1.Name = "button1";
            button1.Size = new Size(93, 67);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(973, 365);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(148, 97);
            treeView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 6;
            label1.Text = "Factura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(588, 36);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 7;
            label2.Text = "Pagos";
            // 
            // button2
            // 
            button2.Image = Properties.Resources.logomp;
            button2.Location = new Point(174, 399);
            button2.Name = "button2";
            button2.Size = new Size(65, 77);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 376);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 9;
            label3.Text = "Efectivo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 376);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 10;
            label4.Text = "Mercado Pago";
            // 
            // button3
            // 
            button3.Image = Properties.Resources.impresion;
            button3.Location = new Point(1071, 18);
            button3.Name = "button3";
            button3.Size = new Size(50, 47);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(995, 40);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 12;
            label5.Text = "Imprimir FC";
            // 
            // Cobranza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 503);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Cobranza";
            Text = "Cobranza";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button1;
        private TreeView treeView1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Label label5;
    }
}