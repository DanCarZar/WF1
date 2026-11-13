using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WF1.Repositories;
using WF1.Forms;
using WF1.Models;

namespace WF1.Forms
{
    public partial class AbmUsers : Form
    {

        private readonly AbmUsuariosRepository _abmUsuariosRepository;

        public AbmUsers()
        {
            InitializeComponent();

            _abmUsuariosRepository = new AbmUsuariosRepository();

        }


        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource =
           _abmUsuariosRepository.GetAllUsers();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ingresá Usuario.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingresá un Password para continuar.");
                return;
            }

            var Usuario = new Usuarios
            {

                Usuario = textBox1.Text.Trim(),
                Password = textBox2.Text.Trim(),
                Activo = true,
                Permiso = checkedListBox1.CheckedItems.Count > 0 ? checkedListBox1.CheckedItems[0].ToString() : string.Empty
            };


            _abmUsuariosRepository.Crear_Usuario(Usuario);

            MessageBox.Show("Usuario Generado Exitosamente.");
        }



        private void btnloadusers_Click(object sender, EventArgs e)
        {


            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource =
            _abmUsuariosRepository.GetAllUsers();

        }

        private void btndeleteuser_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            string usuario = dgvUsuarios.CurrentRow
                .Cells["Usuario"].Value?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(usuario))
                return;

            var resultado = MessageBox.Show(
                $"¿Desea eliminar al usuario {usuario}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes)
                return;

            try
            {
                var repository = new AbmUsuariosRepository();

                if (repository.Delete_Usuario(usuario))
                {
                    MessageBox.Show("Usuario eliminado correctamente.");
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
