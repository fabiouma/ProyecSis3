using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Articulos = new HashSet<Articulo>();
        }

        public int IdCategoria { get; set; }
        public string NomCategoria { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Estado { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
