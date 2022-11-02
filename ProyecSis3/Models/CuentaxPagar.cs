using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class CuentaxPagar
    {
        public int IdCuentaxPagar { get; set; }
        public int ProveedorIdProveedor { get; set; }
        public double SaldoPendiente { get; set; }
        public DateTime FechaPago { get; set; }
        public bool Estado { get; set; }

        public virtual Proveedor ProveedorIdProveedorNavigation { get; set; } = null!;
    }
}
