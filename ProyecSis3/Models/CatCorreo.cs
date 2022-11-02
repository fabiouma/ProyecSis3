using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class CatCorreo
    {
        public CatCorreo()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdCatCorreo { get; set; }
        public string CorreoDetalle { get; set; } = null!;
        public bool Estado { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
