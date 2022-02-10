using System;
using System.Collections.Generic;

#nullable disable

namespace Entidades.Database
{
    public partial class Direccione
    {


        public Direccione()
        {
            Personas = new HashSet<Persona>();
        }

        public int Id { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
