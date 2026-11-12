using System;
using System.Collections.Generic;
using System.Text;
using WF1.Models;
using WF1.Repositories;

namespace WF1.Services
{
    public class VentaService
    {

        private readonly VentaRepository _ventaRepository;

        private readonly ProductoRepository _productoRepository;

        public VentaService()
        {
            _ventaRepository = new VentaRepository();
            _productoRepository = new ProductoRepository();
        }

        public void RegistrarVenta(List<CarritoItem> carrito)
        {
            var venta = new Venta
            {
                Fecha = DateTime.Now,
                Total = carrito.Sum(x => x.Subtotal)
            };

            int ventaId =
                _ventaRepository.InsertVenta(venta);

            foreach (var item in carrito)
            {
                var detalle = new VentaDetalle
                {
                    VentaId = ventaId,
                    ProductoId = item.ProductoId,
                    Cantidad = item.Cantidad,
                    PrecioUnitario = item.PrecioUnitario,
                    Subtotal = item.Subtotal
                };

                _ventaRepository.InsertDetalle(detalle);

                _productoRepository.DescontarStock(
                    item.ProductoId,
                    item.Cantidad);
            }
        }
    }
}
