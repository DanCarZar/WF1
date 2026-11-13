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
            dgvUsuarios = new DataGridView();
            btndeleteuser = new Button();
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
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
            textBox2.UseSystemPasswordChar = true;
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
            btnloadusers.Location = new Point(649, 351);
            btnloadusers.Name = "btnloadusers";
            btnloadusers.Size = new Size(124, 23);
            btnloadusers.TabIndex = 7;
            btnloadusers.Text = "Cargar Usuarios";
            btnloadusers.UseVisualStyleBackColor = true;
            btnloadusers.Click += btnloadusers_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(352, 31);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(421, 273);
            dgvUsuarios.TabIndex = 8;
            // 
            // btndeleteuser
            // 
            btndeleteuser.Location = new Point(352, 349);
            btndeleteuser.Name = "btndeleteuser";
            btndeleteuser.Size = new Size(104, 27);
            btndeleteuser.TabIndex = 9;
            btndeleteuser.Text = "Borrar Usuario";
            btndeleteuser.UseVisualStyleBackColor = true;
            btndeleteuser.Click += btndeleteuser_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Cajero", "Stock" });
            checkedListBox1.Location = new Point(75, 220);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 58);
            checkedListBox1.TabIndex = 13;
            // 
            // AbmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 415);
            Controls.Add(checkedListBox1);
            Controls.Add(btndeleteuser);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnloadusers);
            Controls.Add(lblpermiso);
            Controls.Add(lbl1password);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl1username);
            Controls.Add(btn1);
            Name = "AbmUsers";
            Text = "AbmUsers";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
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
        private DataGridView dgvUsuarios;
        private Button btndeleteuser;
        private CheckedListBox checkedListBox1;
    }
}