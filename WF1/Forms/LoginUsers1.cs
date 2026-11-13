using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WF1.Repositories;

namespace WF1.Forms
{
    public partial class LoginUsers1 : Form
    {
        public LoginUsers1()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;

            this.AcceptButton = btn1login;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private readonly LoginRepository _repository = new LoginRepository();


        private void btn1login_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Debe ingresar usuario y contraseña.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                bool loginValido = _repository.ValidarLogin(usuario, password);

                if (loginValido)
                {
                    txtPassword.Clear();

                    this.Hide();

                    using var principal = new Form1();
                    principal.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos, o usuario inactivo.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al iniciar sesión: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var AbmUsers = new AbmUsers();
            AbmUsers.ShowDialog();
        }
    }
}
