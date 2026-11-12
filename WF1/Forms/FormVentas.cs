using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WF1.Models;
using WF1.Repositories;
using WF1.Services;

namespace WF1.Forms
{
    public partial class FormVentas : Form
    {
        private readonly ProductoRepository _productoRepository;

        private readonly VentaService _ventaService;

        private readonly List<CarritoItem> _carrito;

        public FormVentas()
        {
            InitializeComponent();

            _productoRepository = new ProductoRepository();

            _ventaService = new VentaService();

            _carrito = new List<CarritoItem>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigoBarra = txtCodigoBarra.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigoBarra))
            {
                MessageBox.Show("Ingresá o escaneá un código de barras.");
                return;
            }

            var producto = _productoRepository.GetByCodigoBarra(codigoBarra);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado.");
                txtCodigoBarra.Clear();
                txtCodigoBarra.Focus();
                return;
            }

            AgregarAlCarrito(producto);

            txtCodigoBarra.Clear();
            txtCodigoBarra.Focus();
        }

        private void AgregarAlCarrito(Producto producto)
        {
            var itemExistente = _carrito
                .FirstOrDefault(x => x.ProductoId == producto.Id);

            decimal cantidadEnCarrito =
                itemExistente?.Cantidad ?? 0;

            if (cantidadEnCarrito >= producto.Stock)
            {
                MessageBox.Show(
                    $"Stock insuficiente.\nStock disponible: {producto.Stock}");

                return;
            }

            if (itemExistente == null)
            {
                _carrito.Add(new CarritoItem
                {
                    ProductoId = producto.Id,
                    CodigoBarra = producto.CodigoBarra,
                    Nombre = producto.Nombre,
                    Cantidad = 1,
                    PrecioUnitario = producto.PrecioVenta,
                    Subtotal = producto.PrecioVenta
                });
            }
            else
            {
                itemExistente.Cantidad++;

                itemExistente.Subtotal =
                    itemExistente.Cantidad *
                    itemExistente.PrecioUnitario;
            }

            RefrescarCarrito();
        }

        private void RefrescarCarrito()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = _carrito;

            decimal total = _carrito.Sum(x => x.Subtotal);

            lblTotal.Text = total.ToString("N2");
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (!_carrito.Any())
            {
                MessageBox.Show("No hay productos en el carrito.");
                return;
            }

            _ventaService.RegistrarVenta(_carrito);

            MessageBox.Show("Venta registrada correctamente.");

            _carrito.Clear();

            RefrescarCarrito();
        }
    }
}
