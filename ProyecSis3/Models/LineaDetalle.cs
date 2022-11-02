using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class LineaDetalle
    {
        public LineaDetalle()
        {
            Facturacions = new HashSet<Facturacion>();
        }

        public int IdLineaDetalle { get; set; }
        public string CantidadArticulos { get; set; } = null!;
        public string ImpuestoVenta { get; set; } = null!;
        public double PrecioUnidad { get; set; }
        public double Descuento { get; set; }
        public int ArticuloIdArticulo { get; set; }

        public virtual Articulo ArticuloIdArticuloNavigation { get; set; } = null!;
        public virtual ICollection<Facturacion> Facturacions { get; set; }
    }
}
