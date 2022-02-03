using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ_Consola
{
    public class Program
    {
        //delegate void miDelegado(string mensaje);
        static void Main(string[] args)
        {
            //miDelegado mensajeador = new miDelegado(EscribirMensaje);
            //mensajeador("Hello World!");
            //Action<int> action = (num) => Console.WriteLine(num) ;
            //action(1);  



            List<int> listaNumeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> numeroPares = from numero in listaNumeros where (numero % 2 == 0) select numero;
            List<Persona> personas = new List<Persona>() {
                 new Persona { Id = 1, Name ="Pepe", Edad = 25},
                 new Persona{ Id = 2, Name = "Alejandro", Edad = 34},
                 new Persona{ Id = 3, Name = "Roman", Edad = 50}
            };

            //IEnumerable<object> listaAnonima = from persona in personas
            //                                   where persona.Edad > 30
            //                                   select new
            //                                   {
            //                                       id = persona.Id,
            //                                       name = persona.Name,
            //                                       mensaje = "Persona anonima"
            //                                   };

            //listaAnonima.ToList().ForEach(elemento => Console.WriteLine(elemento.ToString()));

            //foreach (int item in numeroPares)
            //{
            //    Console.WriteLine(item);
            //}
            //numeroPares.ToList().ForEach(numero => Console.WriteLine(numero));  

            //personas.Sort((persona1,persona2)=> {

            //    if(persona1.Edad < persona2.Edad)
            //    {
            //        return 1;
            //    }
            //    else if(persona1.Edad > persona2.Edad) { 
            //        return -1;
            //    }

            //    return 0;

            //});
            //personas.ForEach(persona => Console.WriteLine(persona.Edad));
            IEnumerable<int> numerosPares2 = listaNumeros.Where(numero=> numero%2 == 0);

            var resultado = listaNumeros.Average((num) => { return num / 2; });
            Console.WriteLine(resultado);
            //var resultado2 = listaNumeros.Max();

            //Console.WriteLine(resultado2);

            Console.ReadKey();
        }


        //public static void EscribirMensaje (string mensaje)
        //{
        //    Console.WriteLine(mensaje);
        //}
        //public static void EscribirMensaje2(int numero)
        //{
        //    Console.WriteLine(numero);
        //}
    }


    public class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Edad { get; set; }   
    }
}
