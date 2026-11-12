using System;
using System.Collections.Generic;
using System.Text;

namespace WF1.Models
{
    public class Venta
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Total { get; set; }
    }
}
