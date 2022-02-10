using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public sealed class Alumno : Persona
    { 
        public int Calificacion { get; set; }   
    }
}
