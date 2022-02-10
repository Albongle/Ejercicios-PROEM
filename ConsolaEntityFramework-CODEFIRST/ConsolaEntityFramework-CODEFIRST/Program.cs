using System;
using Entidades.Data;
using Entidades.Models;
using System.Linq;
using System.Collections.Generic;

namespace ConsolaEntityFramework_CODEFIRST
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>{
            new Alumno{Nombre= "Pepe", Apellido= "Gonzalez", Calificacion = 10, Edad=20},
            new Alumno{Nombre= "Luis", Apellido= "Fernandez", Calificacion = 10, Edad=30},
            new Alumno{Nombre= "Jesus", Apellido= "Lopez", Calificacion = 10, Edad=30},
            new Alumno{Nombre= "Erik", Apellido= "Messi", Calificacion = 10, Edad=25}, };
            
            using (MyDbContext db = new MyDbContext())
            {
                var lista = db.Alumnos.Where(a => a.Apellido == "Messi");

                var a = 1;
            }
        }
    }
}
