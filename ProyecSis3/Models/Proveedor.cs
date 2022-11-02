using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Articulos = new HashSet<Articulo>();
            CuentaxPagars = new HashSet<CuentaxPagar>();
        }

        public int IdProveedor { get; set; }
        public string Nombre { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<CuentaxPagar> CuentaxPagars { get; set; }
    }
}
