namespace WF1.Forms
{
    partial class LoginUsers1
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
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            lbl1username = new Label();
            lbl1password = new Label();
            btn1login = new Button();
            btn1createuser = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(289, 275);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(289, 323);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lbl1username
            // 
            lbl1username.AutoSize = true;
            lbl1username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1username.Location = new Point(164, 273);
            lbl1username.Name = "lbl1username";
            lbl1username.Size = new Size(71, 21);
            lbl1username.TabIndex = 2;
            lbl1username.Text = "Usuario :";
            // 
            // lbl1password
            // 
            lbl1password.AutoSize = true;
            lbl1password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1password.Location = new Point(139, 325);
            lbl1password.Name = "lbl1password";
            lbl1password.Size = new Size(96, 21);
            lbl1password.TabIndex = 3;
            lbl1password.Text = "Contraseña :";
            // 
            // btn1login
            // 
            btn1login.Location = new Point(571, 300);
            btn1login.Name = "btn1login";
            btn1login.Size = new Size(75, 23);
            btn1login.TabIndex = 4;
            btn1login.Text = "Ingresar";
            btn1login.UseVisualStyleBackColor = true;
            btn1login.Click += btn1login_Click;
            // 
            // btn1createuser
            // 
            btn1createuser.Location = new Point(554, 405);
            btn1createuser.Name = "btn1createuser";
            btn1createuser.Size = new Size(118, 23);
            btn1createuser.TabIndex = 5;
            btn1createuser.Text = "Crear Usuario";
            btn1createuser.UseVisualStyleBackColor = true;
            btn1createuser.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoDan;
            pictureBox1.Location = new Point(325, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LoginUsers1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(772, 470);
            Controls.Add(pictureBox1);
            Controls.Add(btn1createuser);
            Controls.Add(btn1login);
            Controls.Add(lbl1password);
            Controls.Add(lbl1username);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Name = "LoginUsers1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label lbl1username;
        private Label lbl1password;
        private Button btn1login;
        private Button btn1createuser;
        private PictureBox pictureBox1;
    }
}