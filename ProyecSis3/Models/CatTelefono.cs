using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class CatTelefono
    {
        public CatTelefono()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdCatTelefono { get; set; }
        public int TelefonoDetalle { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
