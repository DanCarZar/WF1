using System;
using System.Collections.Generic;
using System.Text;

namespace WF1.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string CodigoBarra { get; set; }

        public string Nombre { get; set; }

        public decimal PrecioCosto { get; set; }

        public decimal PrecioVenta { get; set; }

        public decimal Stock { get; set; }

        public bool Activo { get; set; }
    }
}
