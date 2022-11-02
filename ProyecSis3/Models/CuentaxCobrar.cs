using System;
using System.Collections.Generic;

namespace ProyecSis3.Models
{
    public partial class CuentaxCobrar
    {
        public int IdCuentaxCobrar { get; set; }
        public double SaldoPendiente { get; set; }
        public int PersonaIdPersona { get; set; }
        public DateTime FechaPago { get; set; }
        public bool Estado { get; set; }

        public virtual Persona PersonaIdPersonaNavigation { get; set; } = null!;
    }
}
