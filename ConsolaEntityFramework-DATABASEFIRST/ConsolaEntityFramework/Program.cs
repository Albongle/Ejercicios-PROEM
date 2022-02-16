using System;
using System.Collections.Generic;
using System.Linq;
using Entidades.Database;
using Microsoft.EntityFrameworkCore;

namespace ConsolaEntityFramework
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Alta de Usuario
            using (MyDataBase db = new MyDataBase())
            {
                Direccione dr = new Direccione { Provincia = "BSAS", Localidad = "Lanus", Direccion = "Direccion 124" };
                db.Direcciones.Add(dr).State = EntityState.Added;
                Persona persona = new Persona { Nombre = "Jose", Apellido = "Perez", IdDireccion = dr.Id, IdDireccionNavigation = dr };
                db.Personas.Add(persona).State = EntityState.Added;
                db.SaveChanges();

                Console.WriteLine("Termine de Agregar");
            }

            //using(MyDataBase db = new MyDataBase())
            //{
            //    Persona p = db.Personas.Where(p => p.Id == 2).First();
            //    p.Apellido = "Lopez";
            //    p.Nombre = "Ramon";
            //    db.Personas.Update(p).State = EntityState.Modified;
            //    db.SaveChanges();
            //    Console.WriteLine("Termine de Modificar");
            //}



            //using (MyDataBase db = new MyDataBase())
            //{
            //    Direccione d = db.Direcciones.First();  
            //    Persona persona = new Persona { Nombre = "Jose", Apellido = "Perez", IdDireccion = d.Id, IdDireccionNavigation = d };
            //    db.Personas.Add(persona).State = EntityState.Added;
            //    db.SaveChanges();

            //    Console.WriteLine("Termine de Agregar");
            //}



            //using (MyDataBase db = new MyDataBase())
            //{
            //    Direccione d = db.Direcciones.First();
            //    db.Direcciones.Remove(d);
            //    db.SaveChanges();
            //    Console.WriteLine("Termine de Elimar");
            //}

            using (MyDataBase db = new MyDataBase())
            {
                var result = db.Personas.Include(d => d.IdDireccionNavigation).ToList();
            }


            Console.ReadKey();
        }
    }
}
