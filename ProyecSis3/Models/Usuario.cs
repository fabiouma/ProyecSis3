using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string Contrasenna { get; set; } = null!;
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int RolIdrol { get; set; }

        public virtual Rol RolIdrolNavigation { get; set; } = null!;
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
