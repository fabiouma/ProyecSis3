using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class TipoPago
    {
        public TipoPago()
        {
            Facturacions = new HashSet<Facturacion>();
        }

        public int IdTipoPago { get; set; }
        public string TipoPago1 { get; set; } = null!;

        public virtual ICollection<Facturacion> Facturacions { get; set; }
    }
}
