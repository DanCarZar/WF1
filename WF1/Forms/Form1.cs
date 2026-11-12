using WF1.Forms;
using WF1.Models;
using WF1.Repositories;

namespace WF1
{
    public partial class Form1 : Form
    {
        private readonly ProductoRepository _productoRepository;

        private int _productoSeleccionadoId = 0;

        public Form1()
        {
            InitializeComponent();

            _productoRepository = new ProductoRepository();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource =
                _productoRepository.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblNombre.Text))
            {
                MessageBox.Show("Ingresá el nombre del producto.");
                return;
            }

            var producto = new Producto
            {
                Id = _productoSeleccionadoId,
                CodigoBarra = txtCodigoBarra.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                PrecioCosto = decimal.Parse(txtPrecioCosto.Text),
                PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                Stock = decimal.Parse(txtStock.Text),
                Activo = true
            };

            if (_productoSeleccionadoId == 0)
            {
                _productoRepository.Insert(producto);
                MessageBox.Show("Producto guardado correctamente.");
            }
            else
            {
                _productoRepository.Update(producto);
                MessageBox.Show("Producto actualizado correctamente.");
            }

            Limpiar();
            CargarProductos();

            MessageBox.Show("Producto guardado correctamente.");
        }

        private void Limpiar()
        {
            _productoSeleccionadoId = 0;

            txtCodigoBarra.Clear();
            txtNombre.Clear();
            txtPrecioCosto.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();

            txtNombre.Focus();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string texto = txtBuscar.Text.Trim();

            dgvProductos.DataSource = null;

            if (string.IsNullOrWhiteSpace(texto))
            {
                dgvProductos.DataSource =
                    _productoRepository.GetAll();
            }
            else
            {
                dgvProductos.DataSource =
                    _productoRepository.Search(texto);
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var fila = dgvProductos.Rows[e.RowIndex];

            _productoSeleccionadoId =
                Convert.ToInt32(fila.Cells["Id"].Value);

            txtCodigoBarra.Text =
                fila.Cells["CodigoBarra"].Value?.ToString();

            txtNombre.Text =
                fila.Cells["Nombre"].Value?.ToString();

            txtPrecioCosto.Text =
                fila.Cells["PrecioCosto"].Value?.ToString();

            txtPrecioVenta.Text =
                fila.Cells["PrecioVenta"].Value?.ToString();

            txtStock.Text =
                fila.Cells["Stock"].Value?.ToString();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            var formVentas = new FormVentas();
            formVentas.ShowDialog();
        }
    }
}
