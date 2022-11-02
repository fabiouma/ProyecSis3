using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class Facturacion
    {
        public int IdFacturacion { get; set; }
        public int TipoPagoIdTipoPago { get; set; }
        public double TotalVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int LineaDetalleIdLineaDetalle { get; set; }
        public int PersonaIdPersona { get; set; }

        public virtual LineaDetalle LineaDetalleIdLineaDetalleNavigation { get; set; } = null!;
        public virtual Persona PersonaIdPersonaNavigation { get; set; } = null!;
        public virtual TipoPago TipoPagoIdTipoPagoNavigation { get; set; } = null!;
    }
}
