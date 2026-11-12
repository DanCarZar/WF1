using System;
using System.Collections.Generic;
using System.Text;

namespace WF1.Models
{
    public class VentaDetalle
    {
        public int Id { get; set; }

        public int VentaId { get; set; }

        public int ProductoId { get; set; }

        public decimal Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal { get; set; }
    }
}
