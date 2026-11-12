using System;
using System.Collections.Generic;
using System.Text;

namespace WF1.Models
{
    public class CarritoItem
    {
        public int ProductoId { get; set; }

        public string CodigoBarra { get; set; }

        public string Nombre { get; set; }

        public decimal Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal { get; set; }
    }
}
