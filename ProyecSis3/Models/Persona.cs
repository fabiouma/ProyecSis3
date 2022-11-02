using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class Persona
    {
        public Persona()
        {
            CuentaxCobrars = new HashSet<CuentaxCobrar>();
            Facturacions = new HashSet<Facturacion>();
        }

        public int IdPersona { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido1 { get; set; } = null!;
        public string Apellido2 { get; set; } = null!;
        public int UsuarioIdUsuario { get; set; }
        public int CatTelefonoIdCatTelefono { get; set; }
        public int CatCorreoIdCatCorreo { get; set; }
        public int CatDireccionIdCatDireccion { get; set; }

        public virtual CatCorreo CatCorreoIdCatCorreoNavigation { get; set; } = null!;
        public virtual CatDireccion CatDireccionIdCatDireccionNavigation { get; set; } = null!;
        public virtual CatTelefono CatTelefonoIdCatTelefonoNavigation { get; set; } = null!;
        public virtual Usuario UsuarioIdUsuarioNavigation { get; set; } = null!;
        public virtual ICollection<CuentaxCobrar> CuentaxCobrars { get; set; }
        public virtual ICollection<Facturacion> Facturacions { get; set; }
    }
}
