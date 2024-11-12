using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Models
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int Factura { get; set; }
        public DateOnly fecha { get; set; }
        public decimal Total { get; set; }
        //relaciones
        public int ClienteId { get; set; }
        public virtual ICollection<DetalleVenta> Detalle { get; set; }

    }
}
