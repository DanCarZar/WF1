namespace WF1.Forms
{
    partial class AbmUsers
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
            btn1 = new Button();
            lbl1username = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbl1password = new Label();
            lblpermiso = new Label();
            btnloadusers = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            btnback = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(42, 338);
            btn1.Name = "btn1";
            btn1.Size = new Size(153, 48);
            btn1.TabIndex = 0;
            btn1.Text = "Crear Usuario";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // lbl1username
            // 
            lbl1username.AutoSize = true;
            lbl1username.Location = new Point(68, 19);
            lbl1username.Name = "lbl1username";
            lbl1username.Size = new Size(111, 15);
            lbl1username.TabIndex = 1;
            lbl1username.Text = "Nombre De Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 3;
            // 
            // lbl1password
            // 
            lbl1password.AutoSize = true;
            lbl1password.Location = new Point(97, 104);
            lbl1password.Name = "lbl1password";
            lbl1password.Size = new Size(67, 15);
            lbl1password.TabIndex = 5;
            lbl1password.Text = "Contraseña";
            // 
            // lblpermiso
            // 
            lblpermiso.AutoSize = true;
            lblpermiso.Location = new Point(79, 188);
            lblpermiso.Name = "lblpermiso";
            lblpermiso.Size = new Size(109, 15);
            lblpermiso.TabIndex = 6;
            lblpermiso.Text = "Seleccione Permiso";
            // 
            // btnloadusers
            // 
            btnloadusers.Location = new Point(649, 220);
            btnloadusers.Name = "btnloadusers";
            btnloadusers.Size = new Size(124, 23);
            btnloadusers.TabIndex = 7;
            btnloadusers.Text = "Cargar Usuarios";
            btnloadusers.UseVisualStyleBackColor = true;
            btnloadusers.Click += btnloadusers_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2 });
            dataGridView1.Location = new Point(428, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(345, 150);
            dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "Usuario";
            Column1.Name = "Column1";
            // 
            // Column3
            // 
            Column3.HeaderText = "Permiso";
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.HeaderText = "Activo";
            Column2.Name = "Column2";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(97, 224);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Cajero";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(97, 257);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(55, 19);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Stock";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            btnback.Location = new Point(698, 359);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 27);
            btnback.TabIndex = 9;
            btnback.Text = "Ir al Menu";
            btnback.UseVisualStyleBackColor = true;
            btnback.Visible = false;
            btnback.Click += btnback_Click;
            // 
            // AbmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 415);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnback);
            Controls.Add(dataGridView1);
            Controls.Add(btnloadusers);
            Controls.Add(lblpermiso);
            Controls.Add(lbl1password);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl1username);
            Controls.Add(btn1);
            Name = "AbmUsers";
            Text = "AbmUsers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label lbl1username;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbl1password;
        private Label lblpermiso;
        private Button btnloadusers;
        private DataGridView dataGridView1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private Button btnback;
    }
}