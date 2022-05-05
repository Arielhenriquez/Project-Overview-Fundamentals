using System;
using static Project_Overview_Fundamentals.Persona;

namespace Project_Overview_Fundamentals
{
    
    public enum diasSemana
    {
        Lunes, Martes, Miercoles, Jueves, Viernes
    }
    
    class Generic<TNombre, TEdad>
    {
        public TNombre Nombre { get; set; }
        public TEdad Edad { get; set; }

        public override string ToString()
        {
            return Nombre + " tiene" + " " + Edad;
        }
    }

    class Animal
    {
        public string nombre = Console.ReadLine();
        public void Correr() 
        {
            Console.WriteLine($"El: {nombre} corre");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Classes and objects
            Console.WriteLine("Ingrese el tipo de animal:");
            var cat = new Animal();
            cat.Correr();
            //Type paramaters
            var datosPersona = new Generic<string, int>()
            {
                Nombre = "Waldis",
                Edad = 22
            };
            Console.WriteLine(datosPersona);
            //Base classes
            var peter = new Peter
            {
                Nombre = " Peter parker",
                Edad = 20
            };
            peter.MostrarDatos();

            //Interfaces
            var calculos = new Calculos();
            Console.WriteLine("La sumatoria es: " + calculos.Suma(5, 5));

            //Enums
            var dias = diasSemana.Lunes;
            Console.WriteLine(dias);

            //Nullable types
            int? numero = null;
            string print = (numero.HasValue) ? $"El valor es {numero}" : "Su valor es null";
            Console.WriteLine(print);
        }
    }
}
