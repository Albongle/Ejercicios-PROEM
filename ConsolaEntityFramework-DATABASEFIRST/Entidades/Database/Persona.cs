using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Entidades.Database
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdDireccion { get; set; }
        public virtual Direccione IdDireccionNavigation { get; set; }
    }
}
