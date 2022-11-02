using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class CatDireccion
    {
        public CatDireccion()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdCatDireccion { get; set; }
        public string DireccionDetalle { get; set; } = null!;
        public bool Estado { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
