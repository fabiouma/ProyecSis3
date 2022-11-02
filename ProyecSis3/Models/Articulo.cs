using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class Articulo
    {
        public Articulo()
        {
            LineaDetalles = new HashSet<LineaDetalle>();
        }

        public int IdArticulo { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Stock { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Estado { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioNeto { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public int CategoriaIdCategoria { get; set; }
        public int ProveedorIdProveedor { get; set; }

        public virtual Categorium CategoriaIdCategoriaNavigation { get; set; } = null!;
        public virtual Proveedor ProveedorIdProveedorNavigation { get; set; } = null!;
        public virtual ICollection<LineaDetalle> LineaDetalles { get; set; }
    }
}
